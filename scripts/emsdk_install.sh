#!/bin/bash
sudo apt-get -y install python3 git zip
sudo apt-get -y install build-essential cmake 

cd ..
cd tools
git clone https://github.com/emscripten-core/emsdk.git
cd emsdk
git pull
./emsdk install latest
./emsdk activate latest
./emsdk_env.sh