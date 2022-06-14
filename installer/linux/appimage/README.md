# Overview

The contents of this directory are intended to package R-Instat into a single executable file that will run on Linux systems.

[AppImage][1] allows applications that run on Linux to be packaged into a single executable file, self-contained with the vast majority of its dependencies.

[appimage-builder][3] automates the process of building AppImages by leveraging existing Linux packaging systems to draw in dependencies and scripting any steps required to build a final AppImage file.

[Mono][2] is a cross-platform, open source implementation of the .NET Framework, and makes it possible for R-Instat to run on Linux.

# Build

## Requirements

- Docker
- Pre-compiled R-Instat binary

## Process

Place the R-Instat binary (and supporting files) in a directory called `RInstat`, within the same directory as this README.

Build the docker container image that will be used to build the AppImage.
```
docker build -t r-instat-appimage-builder:latest docker
```

To build the AppImage itself, run the Docker container created in the previous step.
```
docker run \
  --rm \
  -v $(pwd):/build \
  -w /build \
  -u $UID \
  -e 'MAKEFLAGS=-j 4'
  r-instat-appimage-builder:latest \
  appimage-builder --recipe recipe.yml --skip-test
```

The `MAKEFLAGS` environment variable sets the number of jobs that may run concurrently when the R packages are being built. The higher the better, but setting this to the number of CPU cores available is a good start.

If successful, there will be a file called `R-Instat-latest-x86_64.AppImage`.

# Run

To run R-Instat, make sure that the AppImage is executable, then just run it as you would any script or executable.
```
chmod a+x R-Instat-latest-x86_64.AppImage
./R-Instat-latest-x86_64.AppImage
```

[1]: https://appimage.org/
[2]: https://www.mono-project.com/
[3]: https://github.com/AppImageCrafters/appimage-builder
