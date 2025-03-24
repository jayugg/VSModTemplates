# Unused by VS Code tasks
chmod +x "$(pwd)/scripts/build.sh"
"$(pwd)/scripts/build.sh"
echo "Launching game client..."
//#if (SystemSpecificLaunchSettings == SuppressWindowsConsoleWindow)
"$VINTAGE_STORY/Vintagestory.exe" --tracelog --addModPath "$(pwd)/Releases"
//#elif (SystemSpecificLaunchSettings == ArmMacOsLaunchSettings)
"$VINTAGE_STORY/Vintagestory" --tracelog --addModPath "$(pwd)/Releases"
#else
dotnet "$VINTAGE_STORY/Vintagestory.dll" --tracelog --addModPath "$(pwd)/Releases"
//#endif