# dpz2

一个基于.Net Core的辅助开发套件基础件，包含格式化调试输出、基础操作类型、字符串辅助和时间处理

## 一个专用于调试的类：Debug.cs

使用此类可以轻松进行带有标记的调试信息输出。

## 一个以字符串为键的典型键-值字典：KeyValues.cs

字典是非常常用和实用的类型，而以字符串为键的字典则更为普遍。

## 一个专用动态类型：Dynamic.cs

使用动态类型可以很大程度上增加编程效率，而基于KeyValues的动态类型则更能发挥其作用。

## 一个带有释放器的对象基类：Object.cs

在标准Object上增加了IDisposable接口的支持，凡是继承了此对象的类，均获得Using语法支持。

## 一个好用的字符串辅助类：StringHelper.cs

为字符串增加了为空判断，快捷数字判断、转换，格式类型判断，MD5/Sha1运算等快捷操作。

只需在代码页面中引入dpz2组件，即可使用本辅助类中定义的字符串扩展。

示例（引用）：

    using dpz2;

示例（获取字符串MD5值）：

    string str = "123456";
	string md5 = str.GetMD5();

## 一个快速操纵的时间类型处理类：Time.cs

使用本类可进行直观的时间类型格式化输出，时间戳的换算等。

## Nuget引用

此组件目前已支持在Nuget仓库下载，Nuget页面为 [https://www.nuget.org/packages/dotnet-core-dpz2/](https://www.nuget.org/packages/dotnet-core-dpz2/)
