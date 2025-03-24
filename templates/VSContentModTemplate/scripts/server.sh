# Unused by VS Code tasks
chmod +x "$(pwd)/scripts/build.sh"
"$(pwd)/scripts/build.sh"
echo "Launching game client..."
//#if (SystemSpecificLaunchSettings == SuppressWindowsConsoleWindow)
"$VINTAGE_STORY/VintagestoryServer.exe" --tracelog --addModPath "$(pwd)/Releases"
//#elif (SystemSpecificLaunchSettings == ArmMacOsLaunchSettings)
"$VINTAGE_STORY/VintagestoryServer" --tracelog --addModPath "$(pwd)/Releases"
#else
dotnet "$VINTAGE_STORY/VintagestoryServer.dll" --tracelog --addModPath "$(pwd)/Releases"
//#endif