# Installer Generation Guide

To generate the installer for R-Instat with R bundled inside and all the R packages pre-installed requires a few steps.

## Step 1: Build R-Instat from Visual Studio

You will have to repeat this step for generating 32 bit and 64 bit binaries.
- In Visual Studio open the R-Instat solution.
- To the left of the Start button are two dropdowns.
- Select Release for the first dropdown
- Select x86 for 32 bit build, and x64 for 64 bit build.

## Step 2: Generate Bundled R Install

Once you have built release binaries of R-Instat:
- Open cmd.exe as an Administrator
- cd to the the bin folder with the Release binaries. It will probably look similar to C:/Users/YourName/source/repos/R-Instat/instat/bin/x86/Release
- Then cd into the static folder (R-Instat/instat/bin/x86/Release/static)
- Download the R installer EXE from (https://cran.r-project.org/bin/windows/base/R-3.6.2-win.exe) and save into this directory
- Run the installer using 
```
R-3.6.2-win.exe /DIR="./R-3.6.2"
```
- Go through the install process. Choose custom install and deselect either 32 bit or 64 bit. (If you're building for 32 bit then exclude 64 bit).

## Step 3: Install R packages inside bundled R

- Cd into the R folder you just installed ./R-3.6.2/bin
- Run R.exe
- Run the install_bundled_packages.R script in the same folder as this Readme.

## Step 4: Build Installer EXE using Inno Setup

- Install Inno Setup from here: https://www.jrsoftware.org/isdl.php
- Scroll down and select innosetup-6.0.3.exe (or a newer version)
- Open the Inno Script Compiler from the start menu
- From the file menu choose open
- Then navigate to the inno_install_script_32bit.iss script (or 64 bit version) in the same folder as this readme.
- From the top menu choose compile.
- The installer should be in an output folder. TODO work out exactly where

