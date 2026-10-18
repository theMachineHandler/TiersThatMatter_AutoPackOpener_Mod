<img width="1590" height="871" alt="ProcessingImage" src="https://github.com/user-attachments/assets/12391e7b-6af2-4b9a-9170-1e494e982cc0" />

# TiersThatMatter - AutoPackOpener Mod (for TCG Card Shop Simulator)

Tired of upgrading your Auto Pack Opener machines only to find out that higher-tier machines take longer to process your packs? This mod fixes that!

With this simple mod, every tier of Auto Pack Opener processes its maximum capacity in just 4 minutes. Now upgrading actually matters! No more filling your shop with dozens of lower-tier machines just to keep up with demand. Upgrade your machines, save space, and get back to running your store!

### Installation instructions (and requirements)

This mod requires BepInEx 5, so:
* Install BepInEx 5.
* Place AutoPackOpenerMod.dll in the game's BepInEx/plugins folder.
* Launch the game.

### Details
This mod is fully open source. You can check it's code, change it and build it yourself. 

It requires .NET SDK installed in your machine and BepInEx 5 installed in your game folder. 

Create a new C# project with 

```csharp
dotnet new classlib -n NAME_OF_YOUR_PROJECT_HERE -f netstandard2.1
```
in your desired folder (netstandard 2.1 is required for TCG Card Shop Simulator v1.0) and overwrite the default files with the ones in this repository.

Don't forget to set your game path inside the .csproj file before building it with 

```csharp
dotnet build
```
-----

Enjoy it!
