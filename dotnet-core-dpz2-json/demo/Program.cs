using System;

namespace demo {
    class Program {
        static void Main(string[] args) {

            string str = "{\"Header\":{\"Ver\":\"\",\"Type\":\"\",\"SessionID\":\"\",\"Time\":\"1565942801\",\"Status\":\"1\",\"Error\":\"\"},\"Data\":{\"Apis\":[{\"Url\":\"/Api/Help/Get\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.HelpController\",\"Description\":\"API\u8f85\u52a9\u63a5\u53e3\uff0c\u8fd4\u56de\u670d\u52a1\u5668\u4e0a\u6240\u6709\u7684API\u5217\u8868\"},{\"Url\":\"/Api/Info/Update\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.InfoController\",\"Description\":\"\u83b7\u53d6\u66f4\u65b0\u65e5\u5fd7\"},{\"Url\":\"/Api/Info/Environment\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.InfoController\",\"Description\":\"\u83b7\u53d6\u8fd0\u884c\u73af\u5883\u4fe1\u606f\"},{\"Url\":\"/Api/Info/Debug\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.InfoController\",\"Description\":\"\u83b7\u53d6\u8fd0\u884c\u73af\u5883\u4fe1\u606f\"},{\"Url\":\"/Api/Info/Get\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.InfoController\",\"Description\":\"\u83b7\u53d6\u6240\u6709\u4e0e\u672c\u7a0b\u5e8f\u76f8\u5173\u7684 \u4fe1\u606f\"},{\"Url\":\"/Api/User/GetInfo\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.UserController\",\"Description\":\"\u4ee5Get\u65b9\u5f0f\u83b7 \u53d6\u767b\u9646\u7528\u6237\u4fe1\u606f\"},{\"Url\":\"/Api/User/PostInfo\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.UserController\",\"Description\":\" \u4ee5Post\u65b9\u5f0f\u83b7\u53d6\u767b\u9646\u7528\u6237\u4fe1\u606f\"},{\"Url\":\"/Api/User/Get\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.UserController\",\"Description\":\"\u9ed8\u8ba4\u4ea4\u4e92\uff0c\u8fd4\u56de\u7a7a\u5185\u5bb9\"},{\"Url\":\"/Api/Ycc/GetConfig\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.YccController\",\"Description\":\"\u83b7\u53d6\u914d\u7f6e\u4fe1\u606f\"},{\"Url\":\"/Api/Ycc/CreateNew\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.YccController\",\"Description\":\"\u521b\u5efa\u4e00\u4e2a\u4ea4\u4e92\u6807\u8bc6\"},{\"Url\":\"/Api/Ycc/Get\",\"LoginNeed\":false,\"Controller\":\"Kernel.Api.YccController\",\"Description\":\"\u9ed8\u8ba4\u4ea4\u4e92\uff0c\u8fd4\u56de\u7a7a\u5185\u5bb9\"}]}}";

            int tick0 = Environment.TickCount;

            dpz2.Json.Parser.EnforceUnicode = false;
            //using (var json = dpz2.Json.Parser.ParseJson(str)) {
            //    Console.WriteLine(json.ToJsonString());
            //    //Console.WriteLine(json["Data"]["Apis"][0]["Url"].GetString());
            //    TestJttp jttp = (TestJttp)dpz2.Json.Parser.GetObject(json, typeof(TestJttp));
            //    Console.WriteLine(jttp.Data.Apis.Count);
            //}
            TestJttp jttp = (TestJttp)dpz2.Json.Parser.DeserializeObject(str, typeof(TestJttp));
            Console.WriteLine(dpz2.Json.Parser.SerializeObject(jttp));
            int tick1 = Environment.TickCount;

            TestJttp dy = (TestJttp)Newtonsoft.Json.JsonConvert.DeserializeObject(str, typeof(TestJttp));
            //Console.WriteLine(dy.Data.Apis.GetType().FullName);
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(dy));
            int tick2 = Environment.TickCount;

            Console.WriteLine($"[dpz2.Json] {tick1 - tick0}ms");
            Console.WriteLine($"[Newtonsoft.Json] {tick2 - tick1}ms");
        }
    }
}
