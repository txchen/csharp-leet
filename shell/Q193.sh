# Read from the file file.txt and output all valid phone numbers to stdout.
cat file.txt | grep -P '^(\d{3}-|\(\d{3}\) )\d{3}-\d{4}$'
