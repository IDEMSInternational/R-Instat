# Installer Generation Guide

To generate the installer for R-Instat with R bundled inside and all the R packages pre-installed requires a few steps.

## 1. Pull Latest Changes
1. Update your master branch with the latest changes for the installation. Pull this to your local repo.

## 2. Update frmMain Title Bar
1. Open `frmMain.resx` in a text editor mode
2. Add the version number for the new version of R-Instat to `$this.Text` i.e.
```
<data name="$this.Text" xml:space="preserve">
    <value>R-Instat 0.7.3</value>
</data>
```
3. Do **not** commit this change to the repo or your local repo. The text in the development version should remain as `R-Instat`.

## 3. Check R version in `clsRLink`
1. Check that `clsRLink.vb` is pointing to the version of R you plan to bundle e.g.
```
Private strRBundledVersion As String = "R-4.1.0"
```
2. Check that this is also consistent with `strRVersionMajorRequired` and `strRVersionMinorRequired`

## 4: Build R-Instat from Visual Studio

You will have to repeat this step for generating 32 bit and 64 bit binaries.
1. In Visual Studio open the R-Instat solution.
2. To the left of the Start button are two dropdowns.
3. Select Release for the first dropdown
4. Select x86 for 32 bit build, and x64 for 64 bit build.

## 5. Add the library data sets

1. Download the R-Instat Library datasets from https://github.com/africanmathsinitiative/R-Instat-Data
2. Copy the contents of the `data` folder into `static/Library` in the Release folders for the 64 and 32 bit versions.
3. The `Library` folder should have the same subfolders and the `data` folder on GitHub https://github.com/africanmathsinitiative/R-Instat-Data/tree/main/data

## 6. Generate Bundled R Install

Once you have built release binaries of R-Instat:
1. Open cmd.exe as an Administrator
2. cd to the the bin folder with the Release binaries. It will probably look similar to C:/Users/YourName/source/repos/R-Instat/instat/bin/Release
or for 64 bit /R-Instat/instat/bin/x64/Release
3. Then cd into the static folder (e.g R-Instat/instat/bin/Release/static)
4. Download the latest R installer EXE from (https://cran.r-project.org/) and save into this directory
5. Run the installer using 
```
R-4.1.0-win.exe /DIR="./R-4.1.0"
```
6. Go through the install process. Choose custom install and deselect either 32 bit or 64 bit. (If you're building for 32 bit then exclude 64 bit). Also uncheck "Save version number in registry" so that a registery entry isn't added on your machine.
7. **Remove the installer from this folder after installing.**

## 7. Install R packages inside bundled R

1. Open `R-4.1.0/etc/Rprofile.site` in a text editor
2. Add a blank line and then following two lines after the line that starts: `# .Library.site <-`
```r
# Only use internal library
if (length(.libPaths()) == 2) .libPaths(.libPaths()[2])
```
3. Save the file and close it. This ensures the bundled R only accesses and installs packages internally and not from other folders on your machine.

4. cd into the bin folder in the R folder you just installed `cd R-4.1.0/bin`
5. Run `R.exe`
6. Run `.libPaths()` and confirm this returns only one path which is within the bundled R e.g. 
`"C:/Users/[your name]/source/repos/R-Instat/instat/bin/x64/Release/static/R-4.1.0/library"`
7. Open the file `static\InstatObject\R\Rsetup.R` in RStudio or a text editor.
8. Copy the first part of this file up to but not including the line starting `load_R_Instat_packages <-` and paste and run the copied text into your R console running in cmd.
9. If `mmtable2` is at the end of the list remove it e.g. `packs <- packs[1:length(packs)-1]` and also from versions: `versions <- versions[1:length(versions)-1]`
10. Run `packs` to confirm this outpus a long list of R packages.
11. Run `install.packages(packs, dependencies = FALSE)`. This will install all the R packages. Select the default CRAN minor if prompted. You can confirm that the packages are being installed in the correct location by opening the folder `static\R-4.1.0\library`. After running, the new packages should be listed there.
12. Run `packages_not_installed()` (which is defined in `Rsetup.R`). This should return `character(0)` to indicate that all packages are installed with their required versions.
13. Sometimes they don't install first time. If not, try running `install.packages(packages_not_installed(), dependencies = FALSE)`. Then run `packages_not_installed()` again. If there are still packages listed try closing all R/RStudio instances down and open R again in cmd. If you're still stuck, ask an R guru.
14. Install the `mmtable2` package from CRAN if it was in `packs` list. Run `devtools::install_github("ianmoran11/mmtable2")`. If prompted about updating other packages, choose "None". Confirm that it installed `packageVersion("mmtable2")`.
15. Close cmd.

## 8. Check R-Instat runs with package messages or errors.

1. Run `instat.exe` from the top level e.g. `C:\Users\[your name]\source\repos\R-Instat\instat\bin\x64\Release`
2. Confirm the version number in the title bar is correct and that there are no warnings/errors on opening.
3. Open a data set, produce a graph, produce some output, and change the langauge (and change it back) to confirm there are no serious errors.
4. Close R-Instat. Almost there!

## 9. Build Installer EXE using Inno Setup

1. Install Inno Setup from here: https://www.jrsoftware.org/isdl.php if you don't already have it
3. Open the Inno Script Compiler from the start menu
4. From the file menu choose open
5. Then navigate to the inno_install_script_32bit.iss script (or 64 bit version) in the same folder as this readme.
6. Change the AppId. Delete the current AppId between `{` and `}`. Leave one `{` remaining and place the cursor after it. From the top menu choose Tools > Generate GUID. Use the same AppId for the 64 and 32 bit versions so only do this once and copy from the other script the second time.
6. Update the version numbers in 4 places. 
7. Change `OnlyBelowVersions` to +.1 from the new version.
8. From the top menu choose Build > Compile.
9. The installer will be in installer/Output folder

## 10. Code sign installers
Ensure that the installers are code signed by the IDEMS International code signing certificate. This requires the physical USB key. You may need to contact the key holder in the development team to arrange this.

1. Download the Windows App Certification Kit
2. Insert the USB key into your computer
3. Open cmd as Administrator
4. Run `cd C:\Program Files (x86)\Windows Kits\10\App Certification Kit`
5. Run `signtool sign /tr http://timestamp.comodoca.com?td=sha256 /td sha256 /fd sha256 /n "IDEMS International Community Interest Company" "C:\Users\Danny\Downloads\R-Instat_0.7.3_Installer_32.exe"`
6. Enter the password for the key when prompted
7. You should receive the confirmation:
```
Done Adding Additional Store
Successfully signed: C:\Users\Danny\Downloads\R-Instat_0.7.3_Installer_32.exe
```

## 11. Draft a new release on GitHub

1. Go to Releases on GitHub https://github.com/africanmathsinitiative/R-Instat/releases and edit the current draft release. The changes should be auto populated from the list of merged PRs by the GitHub Action set up to do this.
2. Modify the notes as necessary.
3. Publish the (pre)-release.

## 12. Upload the installer to the website
1. Upload the installer to the central storage location (currently https://drive.google.com/drive/folders/1h5bjyRj1eEIQmWlMiactO6t2YHTs9DQb?usp=sharing)
2. Get the public link to the files
3. Create a bit.ly short link for the installer in the format https://bit.ly/r-instat_072_installer_64bit
4. Update the R-Instat website to link to the short link