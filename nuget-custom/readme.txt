1 modify the Project file(Version,description,and tilte): Properties->AssemblyInfo.cs 
2 if note 1 is not enough , you can add the Nuget reference: MsBuild.NuGet.Pack,which will give you a detailed informations about the nuget dll.
  OR in the Nuget manager console: 1)cd [project]  2)nuget spec   => to get the .nuspec file 
3 you should build the project first, and then publish it. Or else it package and pubish the last build version .

reference: 
创建和发布包  https://docs.microsoft.com/zh-cn/nuget/quickstart/create-and-publish-a-package
Nuget CLI参考 https://docs.microsoft.com/zh-cn/nuget/tools/nuget-exe-cli-reference
.nuspec :    https://docs.microsoft.com/zh-cn/nuget/schema/nuspec
https://docs.microsoft.com/zh-cn/nuget/hosting-packages/nuget-server

Notes: different projects in the same solution may use different version package , 
       so you can use menu Tools->"manage nuget packager for solutions",and then merge them into the same version package of Nuget.
	   
==========================================================================================================================================
nuget
get-help nuget
get-help **-package -examples

nuget help config   ---nuget help [nuget command]


nuget push nugetpack/  -source $"My develop Libs"\%~2
echo  all is done by the end of this time.



=====================================================================================================
nuget.congig: this is copied from the vs2017 settings, here I don't use it at all. you just know that nuget can be configurated by the file.
.nuspec .vstemplate and so on : Acutually ,they are xml file and have some fixed definition , so you can search : nuspec schema/sample/reference.

%userprofile%\.nuget\packages
%LOCALAPPDATA%\NuGet\Cache


nuget pack MyProject.csproj -IncludeReferencedProjects: add reference to other projects.
