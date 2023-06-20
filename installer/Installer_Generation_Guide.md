# Installer Generation Guide

To generate the installer for R-Instat with R bundled inside and all the R packages pre-installed requires a few steps.

### Note 
This will use the version of R currently setup in ChrisMarsh82/R-RInstat repositry. 
This will install all the packages 'instat\static\InstatObject\R\InstallPackages.R' This file will need to be updated manually if these packages change.

## 1. Run workflow to create the Installers
1. Navigate to Github Actions
2. Select Create 32 bit and 64 bit Installers
3. Click 'Run workflow'
4. Select the Branch in which the build should be created from (usually 'master')
5. Enter the Major, Minor, and Revision numbers for the build.
6. Click 'Run workflow'
This will take around 30 - 40 minutes to finish so feel free to get on with something else or practice your vollyball skills if its a nice day.

## 2. Code sign installers
Ensure that the installers are code signed by the IDEMS International code signing certificate. This requires the physical USB key. You may need to contact the key holder in the development team to arrange this.

1. Download the Windows App Certification Kit
2. Download Safenet Authentication Client
3. Insert the USB key into your computer
4. Open cmd as Administrator
5. Run `cd C:\Program Files (x86)\Windows Kits\10\App Certification Kit`
6. Run `signtool sign /tr http://timestamp.comodoca.com?td=sha256 /td sha256 /fd sha256 /n "IDEMS International Community Interest Company" "C:\Users\Danny\Downloads\R-Instat_0.7.3_Installer_32.exe"`
7. Enter the password for the key when prompted
8. You should receive the confirmation:
```
Done Adding Additional Store
Successfully signed: C:\Users\Danny\Downloads\R-Instat_0.7.3_Installer_32.exe
```

## 3. Draft a new release on GitHub

1. Go to Releases on GitHub https://github.com/africanmathsinitiative/R-Instat/releases and edit the current draft release. The changes should be auto populated from the list of merged PRs by the GitHub Action set up to do this.
2. Modify the notes as necessary.
3. Publish the (pre)-release.

## 4. Upload the installers to the website
1. Upload the installers to the central storage location (currently https://console.cloud.google.com/storage/browser/r-instat-downloads;tab=objects?forceOnBucketsSortingFiltering=false&project=glossy-attic-237012&prefix=&forceOnObjectsSortingFiltering=false)
2. Get the link to the files e.g. https://downloads.r-instat.org/R-Instat_0.7.3.1_Installer_32.exe
3. Update the R-Instat website download page to the new version and new links
