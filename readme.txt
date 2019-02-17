this is for the c sharp projects and demos.

OrchardCMS github :源代码(C# good open source code)

解决git每次都提交用户名和密码的问题：
方法1： 修改全局配置
%userprofile%\.gitconfig添加配置选项
[user]
	email = {emai}
	name = {username}
	password={pwd}
[credential]
	helper = store


方法2：修改该项目下的git配置
\.git\config文件添加内容：
[user]
	email = {emai}
	name = {username}
	password={pwd}
[credential]
	helper = store

方法3：使用git命令行[如果是只是一个项目，可以去掉--global 选项]
git config --global user.email {email}
git config --global user.name {name}
git config --global user.password {pwd}

git config --global credential.helper store   

