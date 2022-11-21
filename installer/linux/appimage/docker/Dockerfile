FROM ubuntu:20.04

# Install build dependencies
RUN apt-get update --yes --quiet \
  && apt-get install --yes --quiet --no-install-recommends \
    gnupg \
    software-properties-common \
  && rm -rf /var/lib/apt/lists/*

RUN apt-key adv --keyserver keyserver.ubuntu.com --recv-keys E298A3A825C0D65DFD57CBB651716619E084DAB9 \
  && add-apt-repository 'deb https://cloud.r-project.org/bin/linux/ubuntu focal-cran40/' \
  && DEBIAN_FRONTEND=noninteractive apt-get install --yes --quiet --no-install-recommends \
    desktop-file-utils \
    fakeroot \
    file \
    fuse \
    g++ \
    gcc \
    gfortran \
    gtk-update-icon-cache \
    libblas-dev \
    libc6-dev \
    libcurl4-openssl-dev \
    libfontconfig1-dev \
    libgdal-dev \
    libgdk-pixbuf2.0-dev \
    liblapack-dev \
    libmagick++-dev \
    libmpfr-dev \
    libnetcdf-dev \
    libsodium-dev \
    libssl-dev \
    libudunits2-dev \
    libxml2-dev \
    make \
    patchelf \
    python3-pip \
    python3-setuptools \
    r-base \
    r-base-dev \
    strace \
    wget \
  && rm -rf /var/lib/apt/lists/*

# workaround AppImage issues with Docker
RUN wget https://github.com/AppImage/AppImageKit/releases/download/continuous/appimagetool-x86_64.AppImage -O /opt/appimagetool \
  && cd /opt/ \
  && chmod +x appimagetool \
  && sed -i 's|AI\x02|\x00\x00\x00|' appimagetool \
  && ./appimagetool --appimage-extract \
  && mv /opt/squashfs-root /opt/appimagetool.AppDir \
  && ln -s /opt/appimagetool.AppDir/AppRun /usr/local/bin/appimagetool

RUN pip3 install --no-cache-dir appimage-builder


