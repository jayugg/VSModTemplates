# Vintage Story content modding template for dotnet
This repository contains the following template, which can be used with Rider, Visual Studio, or VS Code to create a new Vintage Story content mod project:
```
Template Name                Short Name      Language  Tags
---------------------------  --------------  --------  -------------------
Vintage Story Content Mod    vscontentmod    [json]    Games/Vintage Story             
```
- vscontentmod

Includes project using bas build script to zip mod archive

## Available launch settings
The template will generate the following scripts in the `scripts` folder if the `-IncludeScripts` flag is enabled (default):
- `Build`: Packages the mod as a zip file in the `Releases` folder. Set ignored files in the `.zipignore` file.
- `Client`: Launches the game with the mod loaded.
- `Server`: Launches a game server with the mod loaded.

These are available for Rider and VS Code.
Check the [Rider](#Rider) or [VS Code section](#VS-Code) sections or the [scripts readme](scripts/readme.md) for more information.

## Install locally

### Requirements
- [.NET SKD 7.0+](https://dotnet.microsoft.com/en-us/download)

### Install

Enter the parent folder of your local copy of this repository and run the following command
```bash
dotnet new install VSContentModTemplates
```

### Use
To see all the available generation options, run the command
```bash
dotnet new vscontentmod --help
```

#### Rider
In Rider you can a new dotnet project and select the `Vintage Story Content Mod` template.
The available options can be set in the GUI.

Alternatively, run the command (replace `<ModName>` with the name of your mod)
```bash
dotnet new vscontentmod -n <ModName>
```

If you have an arm64 Mac, you can use the `--ArmMacOsLaunchSettings` or `-Ar` flag to create working launch settings
```bash
dotnet new vscontentmod -n <ModName> --ArmMacOsLaunchSettings
```

#### Visual Studio
Project creation should be similar to [Rider](#Rider), but the run configurations are not automatically generated,
so you will have to create them yourself. You should be able to set a simple configuration to run the existing scripts in the `scripts` folder.
I cannot create them for Visual Studio as I do not have access to it. If you know how to create them, please submit a PR.

#### VS Code
Run the command (replace `<ModName>` with the name of your mod)
```bash
dotnet new vscontentmod -n <ModName> -VSLaunchSettings
```

### Update
To update the template, run the following command
```bash
dotnet new install VSContentModTemplates --force
```

Check out also the Vintage Story wiki instructions on [installing the official templates](https://wiki.vintagestory.at/Modding:Setting_up_your_Development_Environment#Mod_Template_package)


### Uninstall
You can go in the parent folder and run
```bash
dotnet new uninstall VSContentModTemplates
```
Alternatively you can run the command

```bash
dotnet new uninstall
```
and copy the generated command to uninstall this template