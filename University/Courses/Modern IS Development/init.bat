@echo off
for %%* in (.) do set CurrDirName=%%~nx*
set info=INFO
echo %info%:Init new class for %CurrDirName% Course
rem => Enter class name
set /p name=Class name:
rem => create new folder with class name 
cd classes
mkdir %name%
rem => copy folder docs, topic into new class
cd ..
robocopy   docs classes/%name%/docs /E /CREATE
robocopy   topic classes/%name%/topic /E /CREATE
echo %info%:FINISH
pause