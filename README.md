# librarysystem 图书馆借还管理系统
基于 C# WinForms 的一个简易图书馆管理系统，数据库采用MS-SQLSERVER 2008 R2。利用数据集进行数据操纵。

## 项目结构
1. 1.database -- 存放了项目的脑图构思，PowerDesigner的数据库设计及文档，数据库执行脚本
2. 2.solution -- 存放了VS2017解决方案的代码
3. 3.bin -- 程序生成路径

## 使用方法
1. 在数据库，新建一个名为librarysystem的数据库，执行1.database里面的LibrarySystemDB.sql脚本，用于初始化数据库结构
2. 在数据库新建查询，把1.database里面的测试数据脚本.sql 导入，选择对应数据库，执行脚本
3. 使用VS2017打开2.solution\librarysystem\librarysystem.sln 解决方案，在app.config里面配置一下本地数据库的用户和密码
4. 生成项目，在3.bin里打开librarysystem.exe 即可

## 实现功能
该项目目前仅通过简单的增删改测试，可能存在部分未知问题，由于时间匆促，有部分功能待实现，例如用户信息管理，费用结算等。
当前具备功能：
1. 身份验证登录
2. 书籍管理（增删改查）
3. 借阅记录管理（借出，还书）

## 其他
后续将继续完善