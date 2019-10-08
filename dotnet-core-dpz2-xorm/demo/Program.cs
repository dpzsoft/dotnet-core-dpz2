using System;

namespace demo {
    class Program {
        static void Main(string[] args) {

            using (dpz2.XOrm.Setting setting = dpz2.XOrm.Setting.LoadFromUrl("https://dev.lywos.com/Orm/Xml/Setting.xml")) {
                Console.WriteLine(setting.ToString());
            }

            using (var table = dpz2.XOrm.Table.LoadFromUrl("https://dev.lywos.com/Orm/Xml/Activity/ActivityNew.xml")) {
                Console.WriteLine(table.ToString());
            }

            using (dpz2.XOrm.Syncer syncer = new dpz2.XOrm.Syncer("https://dev.lywos.com/Orm/Xml2", "X:\\temp")) {
                syncer.SyncSetting();
                syncer.SyncTable("Aos", "AosObjects");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
