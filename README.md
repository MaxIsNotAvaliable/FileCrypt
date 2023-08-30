# FileCrypt
With this application you can protect your files from unauthorized access.

## How to use
1)Select files by pressing "Add files" or "Add folder" button or drag and drop files to the table
2)After selecting the files, they will appear in the table
3)If you want to create backup click "Create backup" checkbox
3.1)Press "Select backup folder" and select a directory to create a backup there
3.2)Backup namings - "[your_path]\fc_backup_[time]\[filename]"
3.3)Backups are created when files are encrypted
4)Select the "Use" checkbox in the table of the files you want to work with
5)Press "Encrypt" or "Decrypt" button.

## How it works
This code uses AES symmetric encryption to protect files. It takes a password, converts it to an encryption key, reads bytes from the input file, creates an IV and writes it to the output file, and then encrypts each byte from the file list using the key and IV.
