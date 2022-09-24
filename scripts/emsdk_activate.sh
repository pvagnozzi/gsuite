#!/bin/bash
cd ..
cd tools
cd emsdk
git pull
./emsdk install latest
./emsdk activate latest
./emsdk_env.sh