<#
.SYNOPSIS
    Diagnoses why the Cef runtime fails to initialise in R-Instat (issue #10270).

.DESCRIPTION
    Temporary diagnostic script. Run on a Windows machine where the released
    R-Instat build shows the "Cef runtime could not be initialised" message.

    Checks:
      1. CefSharp/CEF payload files present in the R-Instat install folder
      2. Architecture of instat.exe vs the CefSharp runtime (x64/x86 mismatch)
      3. Visual C++ 2015-2022 x64 redistributable (required by libcef.dll)
      4. Stale CefSharp cache lock (previous crash / second instance)
      5. Recent R-Instat logs for Cef-related warnings

.PARAMETER InstallDir
    R-Instat install folder containing instat.exe.
    If omitted, common install locations are searched.

.EXAMPLE
    powershell -ExecutionPolicy Bypass -File check_cef_runtime.ps1
    powershell -ExecutionPolicy Bypass -File check_cef_runtime.ps1 -InstallDir "C:\Program Files\R-Instat 0.8.14"
#>

param(
    [string]$InstallDir = ""
)

$ErrorActionPreference = "Continue"

# CefSharp.Common 104.4.240 (x64 build) runtime payloads expected next to instat.exe
$requiredFiles = @(
    "CefSharp.dll",
    "CefSharp.Core.dll",
    "CefSharp.Core.Runtime.dll",
    "CefSharp.WinForms.dll",
    "CefSharp.BrowserSubprocess.exe",
    "CefSharp.BrowserSubprocess.Core.dll",
    "libcef.dll",
    "chrome_elf.dll",
    "icudtl.dat",
    "icudt.dll",
    "libEGL.dll",
    "libGLESv2.dll",
    "d3dcompiler_47.dll",
    "vk_swiftshader.dll",
    "vulkan-1.dll",
    "snapshot_blob.bin",
    "v8_context_snapshot.bin"
)
$requiredDirs = @("locales", "swiftshader")

function Write-Section($title) {
    Write-Host ""
    Write-Host "=== $title ===" -ForegroundColor Cyan
}

# ---------------------------------------------------------------------------
# 0. Locate the install folder
# ---------------------------------------------------------------------------
Write-Section "0. Install folder"
if ($InstallDir -eq "") {
    $candidates = @()
    $candidates += Get-ChildItem "C:\Program Files" -Directory -ErrorAction SilentlyContinue |
        Where-Object { $_.Name -like "*R-Instat*" } | ForEach-Object { $_.FullName }
    $candidates += Get-ChildItem "C:\Program Files (x86)" -Directory -ErrorAction SilentlyContinue |
        Where-Object { $_.Name -like "*R-Instat*" } | ForEach-Object { $_.FullName }
    foreach ($c in $candidates) {
        if (Test-Path (Join-Path $c "instat.exe")) { $InstallDir = $c; break }
    }
}
if (($InstallDir -eq "") -or -not (Test-Path (Join-Path $InstallDir "instat.exe"))) {
    Write-Host "Could not find instat.exe. Re-run with -InstallDir `"<path>`"." -ForegroundColor Red
    exit 1
}
Write-Host "Using: $InstallDir"

# ---------------------------------------------------------------------------
# 1. Cef payload files
# ---------------------------------------------------------------------------
Write-Section "1. Cef payload files"
$missing = 0
foreach ($f in $requiredFiles) {
    $p = Join-Path $InstallDir $f
    if (Test-Path $p) {
        $size = (Get-Item $p).Length
        Write-Host ("  OK      {0} ({1:N0} bytes)" -f $f, $size)
    } else {
        Write-Host "  MISSING $f" -ForegroundColor Red
        $missing++
    }
}
foreach ($d in $requiredDirs) {
    $p = Join-Path $InstallDir $d
    if (Test-Path $p) {
        $count = (Get-ChildItem $p -ErrorAction SilentlyContinue).Count
        Write-Host "  OK      $d\ ($count files)"
    } else {
        Write-Host "  MISSING $d\" -ForegroundColor Red
        $missing++
    }
}
if ($missing -gt 0) {
    Write-Host ""
    Write-Host "  -> $missing payload item(s) missing. The installer is not shipping the" -ForegroundColor Yellow
    Write-Host "     complete CefSharp runtime. This alone explains the startup error." -ForegroundColor Yellow
}

# ---------------------------------------------------------------------------
# 2. Architecture check (x64 installer must ship x64 CEF binaries)
# ---------------------------------------------------------------------------
Write-Section "2. Architecture"
function Get-PeArch($path) {
    try {
        $fs = [System.IO.File]::OpenRead($path)
        $br = New-Object System.IO.BinaryReader($fs)
        $fs.Seek(0x3C, 'Begin') | Out-Null
        $peOffset = $br.ReadInt32()
        $fs.Seek($peOffset + 4, 'Begin') | Out-Null
        $machine = $br.ReadUInt16()
        $br.Close(); $fs.Close()
        switch ($machine) {
            0x8664 { return "x64" }
            0x014c { return "x86" }
            0xAA64 { return "ARM64" }
            default { return ("unknown (0x{0:X4})" -f $machine) }
        }
    } catch { return "unreadable" }
}
foreach ($f in @("instat.exe", "libcef.dll", "CefSharp.BrowserSubprocess.exe", "CefSharp.Core.Runtime.dll")) {
    $p = Join-Path $InstallDir $f
    if (Test-Path $p) {
        Write-Host ("  {0,-35} {1}" -f $f, (Get-PeArch $p))
    }
}
Write-Host "  -> instat.exe is a .NET assembly; libcef.dll and the subprocess must match the"
Write-Host "     build platform (x64 for the 64-bit installer). A mismatch breaks Cef.Initialize."

# ---------------------------------------------------------------------------
# 3. VC++ 2015-2022 x64 redistributable (libcef.dll dependency)
# ---------------------------------------------------------------------------
Write-Section "3. VC++ 2015-2022 x64 redistributable"
$vcKeys = @(
    "HKLM:\SOFTWARE\Microsoft\VisualStudio\14.0\VC\Runtimes\x64",
    "HKLM:\SOFTWARE\WOW6432Node\Microsoft\VisualStudio\14.0\VC\Runtimes\x64"
)
$vcFound = $false
foreach ($k in $vcKeys) {
    $rk = Get-ItemProperty $k -ErrorAction SilentlyContinue
    if ($rk -and $rk.Installed -eq 1) {
        Write-Host ("  Installed: v{0} (from {1})" -f $rk.Version, $k)
        $vcFound = $true
    }
}
if (-not $vcFound) {
    Write-Host "  NOT FOUND. libcef.dll needs the VC++ 2015-2022 x64 runtime." -ForegroundColor Red
    Write-Host "  Install https://aka.ms/vs/17/release/vc_redist.x64.exe and retest." -ForegroundColor Yellow
}

# ---------------------------------------------------------------------------
# 4. CefSharp cache lock (crash or second instance)
# ---------------------------------------------------------------------------
Write-Section "4. CefSharp cache"
$cacheDir = Join-Path $env:LOCALAPPDATA "CefSharp\Cache"
if (Test-Path $cacheDir) {
    Write-Host "  Cache folder: $cacheDir"
    Get-ChildItem $cacheDir -Filter "*lock*" -Recurse -ErrorAction SilentlyContinue |
        ForEach-Object { Write-Host "  Lock file present: $($_.FullName)" -ForegroundColor Yellow }
    $running = Get-Process "instat", "CefSharp.BrowserSubprocess" -ErrorAction SilentlyContinue
    if ($running) {
        Write-Host "  R-Instat/CefSharp processes currently running:" -ForegroundColor Yellow
        $running | ForEach-Object { Write-Host "    $($_.ProcessName) (PID $($_.Id))" }
        Write-Host "  -> A second R-Instat instance cannot init Cef with the same cache path."
    }
} else {
    Write-Host "  No cache folder yet ($cacheDir)"
}

# ---------------------------------------------------------------------------
# 5. Recent R-Instat logs: Cef entries
# ---------------------------------------------------------------------------
Write-Section "5. R-Instat logs"
$logDirs = @(
    (Join-Path $env:APPDATA "RInstat\logs"),
    (Join-Path $InstallDir "logs")
)
$logFound = $false
foreach ($ld in $logDirs) {
    if (Test-Path $ld) {
        $logs = Get-ChildItem $ld -Filter "*.log" | Sort-Object LastWriteTime -Descending | Select-Object -First 3
        foreach ($log in $logs) {
            $hits = Select-String -Path $log.FullName -Pattern "Cef" -ErrorAction SilentlyContinue
            if ($hits) {
                $logFound = $true
                Write-Host "  $($log.FullName)"
                $hits | ForEach-Object { Write-Host "    $($_.Line.Trim())" }
            }
        }
    }
}
if (-not $logFound) {
    Write-Host "  No Cef entries found in recent logs."
    Write-Host "  (With the code fix applied, initialisation failures are logged with the full"
    Write-Host "   exception - re-run a build with the fix and check here again.)"
}

Write-Section "Done"
Write-Host "Send this output with any issue report on #10270."
