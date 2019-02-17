rem pass %1 and %2 arguments in the external settings:$(ProjectFileName) $(TargetName)
rem Uset the Tools->External tool: build and package the lastest package version.
del nugetpack /S /Q
rem if it is the first version ,you should create the folder to identity the Package Name.
if not exist G:\develop_Tools\MyPackager\%~2 (mkdir G:\develop_Tools\MyPackager\%~2)

echo set teh configurations
set mylib=G:\develop_Tools\MyPackager
%~dp0nuget.exe pack %~1 -properties Configuration=Release  -OutputDirectory nugetpack
nuget push nugetpack/  -source %mylib%\%~2
echo  Target folder: %mylib%\%~2

pause