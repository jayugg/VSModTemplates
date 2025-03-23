echo "Generating mod archive from: $(pwd)"

# Extract data from modinfo.json using jq
VERSION=$(jq -r '.version' modinfo.json)
MODID=$(jq -r '.modid' modinfo.json)

echo "Mod ID: ${MODID}"
echo "Version: ${VERSION}"

# Clear and recreate the Releases folder
rm -rf Releases
mkdir Releases

# Define mod version and output file name inside Releases folder
OUTPUT="Releases/${MODID}_${VERSION}.zip"

# Build the argument list for zip command starting with default excludes
set -- "-r" "$OUTPUT" "./" "-x" "Releases/*" "-x" "scripts/" "-x" ".*" "-x" "*/.*" 

# Read additional exclude patterns from the .zipignore file if it exists
if [ -f .zipignore ]; then
  echo "Found .zipignore file, reading additional exclude patterns..."
  while IFS= read -r pattern || [ -n "$pattern" ]; do
    # Skip empty lines and comments starting with #
    case "$pattern" in
      ""|\#*)
        continue
        ;;
    esac
    set -- "$@" "-x" "$pattern"
  done < .zipignore
fi

echo "Building mod archive..."
# Execute zip with the built argument list.
zip "$@"
echo "Mod archive created: ${OUTPUT}"