using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptoFile
{
    internal class Encrypt
    {
        public static string GenerateKey()
        {
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 256;
                aes.GenerateKey();
                return $"{aes.Key}";
            }
        }

        public enum FileEncryptionState
        {
            None,           // Not encrypted
            Encrypted,      // encrypted this key
            UnknownKey,     // possible(!) encription w/ another key
        }

        public static FileEncryptionState StringToState(string state)
        {
            if (state.Contains("❌"))
                return FileEncryptionState.None;
            if (state.Contains("✔"))
                return FileEncryptionState.Encrypted;
            return FileEncryptionState.UnknownKey;
        }

        public static string StateToString(FileEncryptionState state)
        {
            if (state == FileEncryptionState.None)
                return "❌ - file clear (no key encryption)";
            if (state == FileEncryptionState.Encrypted)
                return "✔ - encrypted (this key encryption)";
            return "� - unknown (probably encrypted with a different key)";
        }

        public static FileEncryptionState GetFileEncryptionState(string password, string filePath)
        {
            try
            {
                byte[] key = Encoding.UTF8.GetBytes(password);

                using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                {
                    byte[] iv = new byte[aes.IV.Length];

                    List<int> dataArray = new List<int>();

                    using (FileStream fsCrypt = new FileStream(filePath, FileMode.Open))
                    {
                        fsCrypt.Read(iv, 0, iv.Length);

                        aes.Key = key;
                        aes.IV = iv;

                        using (CryptoStream cs = new CryptoStream(fsCrypt, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            while (cs.ReadByte() != -1) { }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                bool encryptedWithAnoterKey = ex.Message.ToLower().Contains("заполнение неверно и не может быть удалено");
                return encryptedWithAnoterKey ? FileEncryptionState.UnknownKey : FileEncryptionState.None;
            }
            return FileEncryptionState.Encrypted;
        }

        public static bool IsValidKey(string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                int keySize = aes.KeySize / 16;
                return keyBytes.Length == keySize;
            }
        }

        public static bool EncryptFile(string password, string inputFile)
        {
            try
            {
                byte[] key = Encoding.UTF8.GetBytes(password);

                List<int> dataArray = new List<int>();
                using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                {
                    int data;
                    while ((data = fsIn.ReadByte()) != -1)
                    {
                        dataArray.Add(data);
                    }
                }

                using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                {
                    aes.Key = key;
                    aes.GenerateIV();

                    using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Create))
                    {
                        fsCrypt.Write(aes.IV, 0, aes.IV.Length);

                        using (CryptoStream cs = new CryptoStream(fsCrypt, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            for (int i = 0; i < dataArray.Count; i++)
                            {
                                int data = dataArray[i];
                                cs.WriteByte((byte)data);
                            }
                        }
                    }
                }
            }
            catch
            {
                //MessageBox.Show("Encryption failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool DecryptFile(string password, string inputFile)
        {
            try
            {
                byte[] key = Encoding.UTF8.GetBytes(password);

                using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                {
                    byte[] iv = new byte[aes.IV.Length];

                    List<int> dataArray = new List<int>();

                    // Read all bytes to dataArray
                    using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                    {
                        fsCrypt.Read(iv, 0, iv.Length);

                        aes.Key = key;
                        aes.IV = iv;

                        using (CryptoStream cs = new CryptoStream(fsCrypt, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            int data;
                            while ((data = cs.ReadByte()) != -1)
                            {
                                dataArray.Add(data);
                            }
                        }
                    }

                    // Save all bytes from dataArray to file
                    using (FileStream fsOut = new FileStream(inputFile, FileMode.Create))
                    {
                        for (int i = 0; i < dataArray.Count; i++)
                        {
                            int data = dataArray[i];
                            fsOut.WriteByte((byte)data);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Decryption failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
