@echo off

cd /d %~dp0
dotnet publish -c Release -r win-x64 -o ./packagedFile --self-contained true

echo 打包完成！
pause
