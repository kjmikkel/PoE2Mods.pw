:: User's Guide ::
Patchwork is a program that allows you to mod certain games using mod files made by others.
Repository: https://github.com/GregRos/Patchwork

:: Requirements ::
Patchwork is a Mono/.NET application and so needs the .NET Framework or Mono to run.

* **Windows:** [.NET Framework 4.5+](https://www.microsoft.com/en-us/download/details.aspx?id=30653) 
* **Linux and Mac:** [Mono 4.2.1.102+](http://www.mono-project.com/download/)

:: Instructions ::

Using the program is straight-forward:

1. Extract it into an **empty** folder.

2. Launch the program (`PatchworkLauncher.exe`)
   
   **Note:** On Linux, you may need to open the program using  `mono` explicitly (see instructions on running Mono applications in your distribution).

3. Specify your game folder in the dialog box or type it in the textbox.

   **Note:** The dialog box will not display hidden files or folders.

4. Specify the folder that contains all the mods you have downloaded.

   **Note:** The dialog box will not display hidden files or folders.

5. Go to the *Active Mods* menu and add the mod file(s) (usually ending with `.pw.dll`) to the list of mods, checking those you want enabled.
 
   **Note:** Mod files so chosen will normally be copied to the `Mods` folder.

6. Use *Launch with Mods* and *Launch without Mods* to start the game.

:: Advanced features ::

If you want to install mods permanently, you can do so using the following instructions:

1. Do step 1-5 from the previous section

2. Use the "Bake mods into game" to bake the mods into the game.

If you want to revert to the original game, use the Restore "original unmodded game"

NOTE: 
Patching a game that has been modified using this application may lead to unexpected results - it is therefore advised to validate your game after patching, and then reapply the mods.