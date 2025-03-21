#!/bin/bash
echo "Generating mod archive from: $(pwd)"
# Extract data from modinfo.json using jq
VERSION=$(jq -r '.version' modinfo.json)
MODID=$(jq -r '.modid' modinfo.json)
# Clear any existing archive
rm -f "${MODID}"_*.zip
# Define mod version and output file name
OUTPUT="${MODID}_${VERSION}.zip"
zip -r "${OUTPUT}" ./ -x ".*" "*.zip" "*.DS_STORE" "changelog.txt" "build.sh" "README.md"
echo "Mod archive created: ${OUTPUT}"