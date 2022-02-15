@echo 复制到100

cd /d %~dp0
set ROOT_PATH=%~dp0
set DATA_OUTPUT=%ROOT_PATH%client\data
set DATA_UPLOAD_OUTPUT=%ROOT_PATH%..\..\xGame\GameFramework200730\CommitResources\100\Windows\Config

call BuildConfig.bat
echo ======== 开始复制Data文件 ========
xcopy /s/y/i "%DATA_OUTPUT%\*.bin" "%DATA_UPLOAD_OUTPUT%" 
echo ======== 复制Data文件结束 ========

echo ======== 开始生成版本文件 ========
set configPath=D:\Working\DeerGameFramework\card\xGame\GameFramework200730\CommitResources\100\Windows\Config
set configVersionOutPath=D:\Working\DeerGameFramework\card\xGame\GameFramework200730\CommitResources\100\Windows
call ConfigVersion.exe %configPath% %configVersionOutPath%
echo ======== 生成版本文件结束 ========
pause