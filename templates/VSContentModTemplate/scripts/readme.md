This folder contains the build and launch scripts.
On VScode or Rider, the template automatically generates a launch configuration for debugging the mod in the game.
For other IDEs, you can create your own run configurations, or use the following commands:
### Build
Packages the mod as a zip file in the `Releases` folder.
```bash
scripts\build.sh
```
### Launch Client
Launches the game with the mod loaded.
```bash
scripts\client.sh
```
### Launch Server
Launches a game server with the mod loaded.
```bash
scripts\server.sh
```
