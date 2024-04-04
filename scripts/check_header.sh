#!/bin/bash

# Define the expected header
EXPECTED_HEADER="// Copyrigth (c) S.C.SoftLab S.R.L.\n// All Rigths reserved."

# Loop through each .cs file in the current directory
for file in *.cs; do
    # Check if the file exists and is readable
    if [[ -f "$file" && -r "$file" ]]; then
        # Read the first line of the file
        first_line=$(head -n 1 "$file")
        # Compare the first line with the expected header
        if [[ "$first_line" != "$EXPECTED_HEADER" ]]; then
            echo "Error: File '$file' does not have the expected header."
            exit 1
        fi
    fi
done

echo "All .cs files have the expected header."
