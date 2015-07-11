# Read from the file file.txt and print its transposed content to stdout.
array=()

while read -a columns; do
    for (( i = 0; i < ${#columns[@]}; i++ )); do
        array[i]="${array[i]} ${columns[i]}"
    done
done < file.txt

for (( i = 0; i < ${#array[@]}; i++ )); do
    echo ${array[i]}
done
