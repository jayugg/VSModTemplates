# Unused by VS Code tasks
"build.sh"
echo "Launching game client..."
//#if (ArmMacOsLaunchSettings)
"$VINTAGE_STORY/VintagestoryServer" --tracelog --addModPath "{$(pwd)}"/Releases"
#else
dotnet "$VINTAGE_STORY/VintagestoryServer.dll" --tracelog --addModPath "{$(pwd)}"/Releases"
//#endif