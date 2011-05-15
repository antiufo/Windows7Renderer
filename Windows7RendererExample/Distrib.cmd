

@echo off
cd /d %~dp0

mkdir dist

cd bin\Release

set zip=..\..\dist\Windows7Renderer.zip
del %zip%
%Apps%\7-Zip\7z.exe a %zip% *.dll Windows7RendererExample.exe -aoa




