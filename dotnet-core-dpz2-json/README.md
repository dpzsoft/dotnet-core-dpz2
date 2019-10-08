# dotnet-core-dpz2-json

基于dpz2开发套件的Json应用扩展(.Net Core)，包括一套自行研发的json解析算法及相关的扩展操作

### 应用于更加简单的使用场景

在dpz2.Json诞生之前，我们一直使用的是Newtonsoft.Json解析库，Newtonsoft.Json最方便的地方是采用了类似JavaBean的绑定方式进行操作，但是实际操作时，我们可能更多时候只想要个解析器，好让我们能快速的辨别数据，这个时候，单纯的JavaBean方式又变得比较肘制，读取数据使用C#的动态类型确实可以比较方便的进行操作。

### 专注于直接操作

另外一个促使我们自研一个解析库的重要原因，就是Json语句的生成，如果生成数据类，确实可以达到快速生成的目的，但是为每一个Json都生成数据类，将会大大的更加程序的开发成本。

举一个简单典型的Json数据示例：

```
{
	aaa:{
		bbb:[111,222],
		cc:"abc"
	},
	ddd:"qaz"
}
```

如果使用Newtonsoft.Json在不生成数据类的情况下，依靠C#的动态类型来完成：

```
dynamic obj = new Newtonsoft.Json.Linq.JObject();
dynamic aaa = obj.aaa = new Newtonsoft.Json.Linq.JObject();
Newtonsoft.Json.Linq.JArray bbb = aaa.bbb = new Newtonsoft.Json.Linq.JArray();
bbb.Add(111);
bbb.Add(222);
aaa.cc = "abc";
obj.ddd = "qaz";
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(obj));
```

可以看到，如果不清楚Newtonsoft.Json下的各种类型，将会非常头疼。

如果使用dpz2.Json，可以有效的避免这个问题：

```
using (var json = new dpz2.Json.JsonObject()) {
	var aaa = json.Object("aaa");
	var bbb = aaa.Array("bbb");
	bbb.Number(0).Value = 111;
	bbb.Number(1).Value = 222;
	aaa.String("cc").Value = "abc";
	json.String("ddd").Value = "qaz";
	Console.WriteLine(json.ToJsonString());
}
```

如果不想使用中间变量，也可以使用直接多层操作方式(这种方式的层次非常分明，但是运行效率略慢)：

```
using (var json = new dpz2.Json.JsonObject()) {
	json.Object("aaa").Array("bbb").Number(0).Value = 111;
	json.Object("aaa").Array("bbb").Number(1).Value = 222;
	json.Object("aaa").String("cc").Value = "abc";
	json.String("ddd").Value = "qaz";
	Console.WriteLine(json.ToJsonString());
}
```

为了方便操作数据，我们提供了函数模式和索引模式两种含义不同的操作方式：函数模式为添加/访问自适应模式，即如访问的对象不存在，将自动添加对象；而索引模式则为访问模式，如访问的对象不存在，将会返回Null空对象。
两种操作方式可以更具需要自由排列组合，如上例代码可以修改为：

```
using (var json = new dpz2.Json.JsonObject()) {
	json.Object("aaa").Array("bbb").Number(0).Value = 111;
	json["aaa"]["bbb"].Number(1).Value = 222;
	json["aaa"].String("cc").Value = "abc";
	json.String("ddd").Value = "qaz";
	Console.WriteLine(json.ToJsonString());
}
```

我们提供了两种方式获取数据(两种方式是等价的，效率相仿，可按实际需求使用)：

```
double b1 = json.Object("aaa").Array("bbb").Number(0).Value;
double b1 = json["aaa"]["bbb"][0].GetNumber();
```

### 支持对象的序列化和反序列化

为了增加本类库的适用场景，自1.0.1908.2版本开始，类库将支持标准.Net对象的序列化和反序列化，代码如下（反序列化时，以TestObject类型为例）：

```
// 反序列化
TestObject obj = (TestObject)dpz2.Json.Parser.DeserializeObject(str, typeof(TestObject));
// 序列化
string str = dpz2.Json.Parser.SerializeObject(obj);
```