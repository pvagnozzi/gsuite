cd ..
cd tools
git clone https://github.com/emscripten-core/emsdk.git
cd emsdk
git pull
emsdk install latest
emsdk activate latest
emsdk_env.ps1