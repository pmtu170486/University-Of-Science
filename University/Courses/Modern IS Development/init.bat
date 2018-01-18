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
cd %name%
mkdir docs
mkdir theory_exercise
mkdir lab_exercise
cd docs
mkdir theory
mkdir lab
echo %info%:FINISH
pause