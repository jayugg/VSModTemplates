# Vintage Story content modding template for dotnet
This repository contains the following template, which can be used with Rider, Visual Studio, or VS Code to create a new Vintage Story content mod project:
```
Template Name                Short Name      Language  Tags
---------------------------  --------------  --------  -------------------
Vintage Story Content Mod    vscontentmod    [json]    Games/Vintage Story             
```
- vscontentmod

Includes project using bas build script to zip mod archive

## Install locally

#### Requirements
- [dotnet SKD 7.0+](https://dotnet.microsoft.com/en-us/download)

#### Install

Enter the parent folder of your local copy of this repository and run the following command
```
cd VSContentModTemplates
dotnet new install .
```

#### Use
In Visual Studio, Rider, or VS Code, create a new dotnet project and select the `Vintage Story Content Mod` template.
Visual Studio and Rider will automatically generate a solution file, but that is not necessary for content mods, so you can delete it if you want.

#### Uninstall

Run the command
```
dotnet new uninstall
```
and copy the generated command to uninstall this template