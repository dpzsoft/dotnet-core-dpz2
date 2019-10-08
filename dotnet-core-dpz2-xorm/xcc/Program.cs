using System;
using dpz2;

namespace xcc {
    class Program {

        /// <summary>
        /// 输出内容
        /// </summary>
        /// <param name="content"></param>
        public static void Say(string content, string sign = null) {
            Console.ForegroundColor = ConsoleColor.Green;
            if (sign.IsNone()) {
                Console.Write($"-");
            } else {
                Console.Write($"[{sign}]");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" > ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(content);
        }

        private static void SayHelp() {
            Console.WriteLine($"参数说明：");
            Console.WriteLine($"    -in 读入目录");
            Console.WriteLine($"    -out 输出目录");
        }

        // 加载一个表数据
        static dpz2.XOrm.Table LoadTable(string dirIn, string path) {

            dpz2.XOrm.Table table = null;
            string url = path.ToLower();

            if (url.StartsWith("http://") || url.StartsWith("https://")) {
                table = dpz2.XOrm.Table.LoadFromUrl(url);
            } else {
                table = dpz2.XOrm.Table.LoadFromFile(dirIn + path);
            };

            // 存在继承表则先加载继承表
            if (!table.Inherit.IsNoneOrNull()) {

                var tabInherit = LoadTable(dirIn, table.Inherit);

                // 数据复刻
                tabInherit.Name = table.Name;
                tabInherit.Title = table.Title;
                tabInherit.Description = table.Description;
                tabInherit.Inherit = "";

                // 将目前表中的字段与继承表中进行对标，如有相同则替换，如未发现则添加
                for (int i = 0; i < table.Fields.Count; i++) {
                    var tfName = table.Fields[i].Name;
                    bool isFound = false;
                    // 遍历继承表的字段定义
                    for (int j = 0; j < tabInherit.Fields.Count; j++) {
                        if (tabInherit.Fields[j].Name == tfName) {
                            isFound = true;
                            tabInherit.Fields.RemoveAt(j);
                            tabInherit.Fields.Insert(j, table.Fields[i].Copy());
                            break;
                        }
                    }
                    if (!isFound) {
                        tabInherit.Fields.Add(table.Fields[i].Copy());
                    }
                }
                table.Dispose();
                return tabInherit;

            }

            return table;
        }

        static void RunSetting(string dirIn, string dirOut) {
            Say("读取文件 /Setting.xml", "-");
            using (var setting = dpz2.XOrm.Setting.LoadFromFile(dirIn + "/Setting.xml")) {

                // 是否有配置变更
                bool isChanged = false;

                // 处理所有的表
                foreach (var platform in setting.Platforms) {

                    Say($"创建目录 {platform.Name}", "+");
                    if (!System.IO.Directory.Exists(dirOut + "/" + platform.Name)) System.IO.Directory.CreateDirectory(dirOut + "/" + platform.Name);

                    foreach (var table in platform.Tables) {
                        Say($"读取表配置文件 {table.Path}", "-");
                        using (var tableSetting = LoadTable(dirIn, table.Path)) {
                            Say($"输出表配置文件 {table.Path}", "+");

                            // 自动填充名称
                            if (tableSetting.Name.IsNoneOrNull()) tableSetting.Name = table.Name;

                            // 自动填充标题或标题更新
                            if (tableSetting.Title.IsNoneOrNull()) {
                                tableSetting.Title = table.Title;
                            } else {
                                if (table.Title != tableSetting.Title) table.Title = tableSetting.Title;
                            }

                            // 当源文件不存在时，先生成一份源文件
                            if (!System.IO.File.Exists(dirIn + table.Path)) tableSetting.SaveToFile(dirIn + table.Path);
                            tableSetting.SaveToFile(dirOut + table.Path);
                        }
                        string md5 = dpz2.File.BinaryFile.GetMD5(dirOut + table.Path);
                        Say($"计算MD5校验 {md5}({table.MD5}) {table.Path}", "-");
                        if (table.MD5 != md5) {
                            Say($"更新版本 {platform.Name}.{table.Name}", "+");
                            Say($"原版本 {table.Version}", "+");
                            var ver = new dpz2.TimeVersion(table.Version);
                            table.Version = ver.GetNextVersion().ToString();
                            table.MD5 = md5;
                            isChanged = true;
                            Say($"新版本 {table.Version}", "+");
                        }
                    }
                }

                if (isChanged) {
                    var ver = new dpz2.TimeVersion(setting.Version);
                    setting.Version = ver.GetNextVersion().ToString();

                    Say("输出新的配置文件 /Setting.xml", "+");
                    setting.SaveToFile(dirIn + "/Setting.xml");
                }

                Say("输出配置文件 /Setting.xml", "+");
                setting.SaveToFile(dirOut + "/Setting.xml");

                Say("输出文件 /Version.xml", "+");
                setting.SaveVersionCacheToFile(dirOut + "/Version.xml");
            }
        }

        static void Main(string[] args) {

            // 存储参数
            dpz2.KeyValues<string> pairs = new dpz2.KeyValues<string>();
            string sign = "";

            // 获取参数
            for (int i = 0; i < args.Length; i++) {
                if (sign.IsNone()) {
                    string argSign = args[i];
                    if (argSign.StartsWith("-") || argSign.StartsWith("/")) {
                        sign = argSign.Substring(1);
                    } else {
                        Say($"不支持的参数定义:{argSign}");
                        return;
                    }
                } else {
                    string argValue = args[i];
                    pairs[sign] = argValue;
                    sign = "";
                }
            }

            string dirIn = pairs["in"];
            if (dirIn.IsNone()) {
                Say("未发现读入目录!");
                Console.WriteLine();
                SayHelp();
                return;
            }

            string dirOut = pairs["out"];
            if (dirOut.IsNone()) {
                Say("未发现输出目录!");
                Console.WriteLine();
                SayHelp();
                return;
            }

            // 读取setting.xml文件
            Say("读入目录 " + dirIn);
            Say("输出目录 " + dirOut);
            RunSetting(dirIn, dirOut);

            Say("完成");
            //Console.WriteLine("Hello World!");
        }
    }
}
