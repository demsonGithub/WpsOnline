@echo off

cd /d %~dp0
dotnet publish -c Release -r win-x64 -o ./packagedFile --self-contained true

echo �����ɣ�
pause
