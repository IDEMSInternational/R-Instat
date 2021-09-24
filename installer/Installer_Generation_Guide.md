# Installer Generation Guide

To generate the installer for R-Instat with R bundled inside and all the R packages pre-installed requires a few steps.

## Step 1: Build R-Instat from Visual Studio

You will have to repeat this step for generating 32 bit and 64 bit binaries.
- In Visual Studio open the R-Instat solution.
- To the left of the Start button are two dropdowns.
- Select Release for the first dropdown
- Select x86 for 32 bit build, and x64 for 64 bit build.
- Check that clsRLink.vb is pointing to the version of R you plan to bundle
```
Private strRBundledVersion As String = "3.6.2"
```

## Step 2: Generate Bundled R Install

Once you have built release binaries of R-Instat:
1. Open cmd.exe as an Administrator
2. cd to the the bin folder with the Release binaries. It will probably look similar to C:/Users/YourName/source/repos/R-Instat/instat/bin/Release
or for 64 bit /R-Instat/instat/bin/x64/Release
3. Then cd into the static folder (e.g R-Instat/instat/bin/Release/static)
4. Download the R installer EXE from (https://cran.r-project.org/bin/windows/base/R-3.6.2-win.exe) and save into this directory
5. Run the installer using 
```
R-3.6.2-win.exe /DIR="./R-3.6.2"
```
6. Go through the install process. Choose custom install and deselect either 32 bit or 64 bit. (If you're building for 32 bit then exclude 64 bit). Also uncheck "Save version number in registry" so that a registery entry isn't added on your machine.
7. Remove the installer from this folder after installing.

## Step 3: Install R packages inside bundled R

1. Cd into the R folder you just installed ./R-3.6.2/bin
2. Run R.exe
3. Run the install_bundled_packages.R script in the same folder as this Readme.
4. The ncdf4.helpers package required a custom version, you can download it from here: https://drive.google.com/file/d/1UqwqVDxMvlHNocUa0i6uiGFT24zwGdgB/view?usp=sharing
Once you've downloaded that zip file, extract the ncdf4.helpers folder into the ./R-3.6.2/library folder

## Step 4: Build Installer EXE using Inno Setup

1. Install Inno Setup from here: https://www.jrsoftware.org/isdl.php
2. Scroll down and select innosetup-6.0.3.exe (or a newer version)
3. Open the Inno Script Compiler from the start menu
4. From the file menu choose open
5. Then navigate to the inno_install_script_32bit.iss script (or 64 bit version) in the same folder as this readme.
6. Modify neccessary detailed e.g. version numbers
7. From the top menu choose compile.
8. The installer should be in installer/Output folder

## Step 5: Code sign installers
Ensure that the installers are code signed by the IDEMS International code signing certificate. This requires the physical USB key. You may need to contact a member of the development team to arrange this.

## Bundling a newer version of R

If you want to bundle a newer version of R (after discussing with the team the consequences of that) you'll need to change the following files:
- clsRLink.vb
- inno_install_script_32bit.iss
- inno_install_script_36bit.iss
- Installer_Generation_Guide.md
