# PoE2Mods.pw
Modding framework for Pillars of Eternity 2

This framework allows you to make changes to almost the entire gamut of PoE2's codebase.  Much like PoE was, PoE2's code appears to be pretty much straight non-obfuscated Unity code, so extremely easy and fun to change to your liking.

Most instructions can be followed directly from Patchwork.  This repo includes all of the relevant modifications for PoE already in place. Note that the release version of Patchwork itself is broken, so I highly recommend using the version in this repo.

# Requirements

Patchwork is a Mono/.NET application and so needs the .NET Framework or Mono to run.

    Windows: .NET Framework 4.5+
    Linux and Mac: Mono 4.2.1.102+

# Instructions

**If you ONLY want to use mods, not create them, please click the Release link at the top of the page!  Download the latest release and continue with these instructions using it.**

Using the program is straight-forward:

    Extract it into an empty folder.
	
	Copy "ModIniFile.ini" and "INIFileParser.dll" to your base POE2 directory next to the exe. Copy the "INIFileParser.dll" to [base]\PillarsOfEternityII_Data\Managed as well.
	
	Edit the ModIniFile to your liking in a text editor to disable/enable individual mods or change settings.

    Launch the program (PatchworkLauncher.exe)

    Note: On Linux, you may need to open the program using mono explicitly (see instructions on running Mono applications in your distribution).

    Specify your game folder in the dialogue box or type it in the textbox.

    Note: The dialogue box will not display hidden files or folders.

	Specify your mod folder in the dialogue box or type it in the textbox.

    Note: The dialogue box will not display hidden files or folders.

    Go to the Active Mods menu and add the mod file(s) (usually ending with .pw.dll) to the list of mods, checking those you want enabled.

    Note: Mod files so chosen will normally be copied to the Mods folder.

    Use Launch with Mods and Launch without Mods to start the game.

# Building/Development

Building is fairly straightforward. You will need to create an Open Assembly version of PoE2's original Assembly-CSharp.dll found in the PillarsOfEternity2_Data/Managed directory of your game install.  You do this via OpenAssemblyCreator.exe which is included in the repo - the OpenAssembly.bat that can handle the transformation (though you will to edit it to point to directory containing the Assembly-CSharp.dll).  Your mod projects will all need to reference this OPEN assembly.  Once this reference has been added, the solution should build just fine.

If you want to build your own mods there is a high level explanation here: https://github.com/GregRos/Patchwork (which is also the base for all the PoE2 Patchwork frameworks).
For specific examples of PoE 2 mods you can see original PoE 2 Patchwork repo (https://github.com/SonicZentropy/PoE2Mods.pw), or the mods I have made (which can be found at https://github.com/kjmikkel/PoE2Mods)
  
# STEAM ACHIEVEMENTS

Due to how the game operates with Steam, you can't get Steam Achievements with this framework directly.  You can only receive them by running the game via Steam's executable, which my mod bypasses and runs directly.  You can work around it if you really want those sweet Steam points, but it's relatively painful.  First, you need to run the game WITH all mods active that you want to be active.  Once the game has fully loaded (DO NOT CLOSE IT), open File Explorer and find POE2's directory.  From there, go into PillarsOfEternity2_Data/Managed and you'll see "Assembly-CSharp.dll".  You need to copy this file somewhere else temporarily.  Now close your game entirely and let the Mod Launcher fully close as well.  Once that's done, go back to PillarsOfEternity2_Data/Managed and RENAME "Assembly-CSharp.dll" to "Assembly-CSharp.dll.ORIGINAL".  Now paste the file you copied into this directory, so it's the new "Assembly-CSharp.dll".  Run your game through Steam and it will have all Mods applied plus allow Steam achievements.

Note that at this point, you're bypassing the launcher.  The launcher automatically does this process at runtime.  You will need to redo the whole process every time you want to change which Mods you're using OR every time Steam updates. *PLEASE NOTE* every time Steam updates POE2 you're going to have to redo this process, but ONLY after downloading a new Release from here.  If there's been a Steam update of the game and you don't see a new release here, please open an Issue or otherwise send me a message, because you will need new DLLs to handle the update.  Undefined behaviors and most likely horrible, terrible things will happen to you otherwise.  I'm not responsible for this mod framework lighting your house on fire and killing your pets.  You have been warned!

To reverse this process and remove mods (for the excellent FrostFG, thanks buddy!), you need to go back to your PillarsOfEternity2_Data/Managed folder and delete the "Assembly-CSharp.dll" from above.  Now rename the "Assembly-CSharp.dll.ORIGINAL" that you changed earlier back to "Assembly-CSharp.dll" and you're done.  Your game is now completely mod free!

# RELEASE NOTES

2.1 - Removed the mods from the framework and made some minor tweaks to the GUI (mainly adding a preferred mod folder, as it may not be the same as the Framework folder itself)

* Forked from https://github.com/SonicZentropy/PoE2Mods.pw, all mentions about individual mods in the below text can be ignored as it pertains to this repo.

2.0 - Completely refactored codebase.  See the instructions above, as everything is now controlled from a new INI file.

1.30 - Lots of new mods!  First up, DifficultyIconsMod from our first official contributor other than me, thanks man!  Fixes not having difficulty icons when you scale levels, totally awesome.  I added a companion mod that adds onto DifficultyIconsMod called DifficultyIconsAlways which also ignores difficulty level in addition to scaling, so you always get difficulty icons on any difficulty (I'm playing on PotD and hate not having them).  
I added another request that bumps up the number of spells from each tier you can cast in a fight (set at 2 right now), and an unlocked camera zoom which feels so much better. 

1.20 - Added autosave disable and the requested spell/empower reset hotkeys.

1.10 - 2 new Mods, see above!

1.07 - More Readme warnings about updating this mod along with POE2 

1.06 - Started making release notes.  Please read the section on AchievementEnabler, as usage is VERY different now and you should not continue using `iroll20s`.  Also added instructions for class/subclass modification.

