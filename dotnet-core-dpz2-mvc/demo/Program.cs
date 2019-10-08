using System;

namespace demo {
    class Program {
        static void Main(string[] args) {

            dpz2.db.Row cache = new dpz2.db.Row();
            ycp.orm.Tables tables = new ycp.orm.Tables();
            //dpz2.Mvc.XOrmForVue.Table form = new dpz2.Mvc.XOrmForVue.Table(null, tables, cache, new dpz2.Mvc.XOrmForVue.Config("https://dev.lywos.com/Orm/Xml", @"X:\temp\UI", @"X:\temp\Cache"), "Aos", "AosAuthorize");

            //dpz2.Mvc.XOrmForVue.Table form = new dpz2.Mvc.XOrmForVue.Table(null, tables, cache, new dpz2.Mvc.XOrmForVue.Config("https://dev.lywos.com/Orm/Xml", @"X:\temp\UI", @"X:\temp\Cache"), "Aos", "AosAuthorize");

            dpz2.Mvc.XOrmForVue.EditForm form = new dpz2.Mvc.XOrmForVue.EditForm(null, tables, cache, new dpz2.Mvc.XOrmForVue.Config("https://dev.lywos.com/Orm/Xml", @"X:\temp\UI", @"X:\temp\Cache"), "Aos", "AosAuthorize");

            // 使用插入器保存
            /*
                Name: 贝克街奇点V品
                Lv: 
                DBSign: Qidian
                DBIP: 39.96.90.26
                DBPort: 5439
                DBUser: beikejie
                DBPwd: Beikejie2019
                DBPath: 
                InterfaceUrl: 
                FileSite: 
                AppSite: 
                HomeUrl: 
                SettingUrl: 
                LogoUrl: 
                DesktopID: 0
                UrlEntrance: 
                ScriptEntrance: 
                AppConfigEntrance: 
                Status: 0
                DBType: PostgreSql
                ID: 10
                sid: db3af45c69cf46e4bc5b396edadb233f
             */
            dpz2.db.Row row = new dpz2.db.Row();
            //row["Name"] = "贝克街奇点V品";
            //row["Lv"] = "";
            //row["DBSign"] = "Qidian";
            //row["DBPort"] = "5439";
            //row["DBUser"] = "beikejie";
            //row["DBPwd"] = "Beikejie2019";
            //row["DBPath"] = "";
            //row["InterfaceUrl"] = "";
            //row["FileSite"] = "";
            //row["AppSite"] = "";
            //row["HomeUrl"] = "";
            //row["SettingUrl"] = "";
            //row["LogoUrl"] = "";
            //row["DesktopID"] = "0";
            //row["UrlEntrance"] = "";
            //row["ScriptEntrance"] = "";
            //row["AppConfigEntrance"] = "";
            //row["Status"] = "0";
            //row["DBType"] = "PostgreSql";
            //row["ID"] = "10";
            //using (var inserter = new dpz2.Mvc.XOrmForVue.Updater(null, tables, row, new dpz2.Mvc.XOrmForVue.Config("https://dev.lywos.com/Orm/Xml2", @"X:\temp\UI", @"X:\temp\Cache"), "Aos", "AosAuthorize")) {
            //    inserter.Save(new dpz2.db.Row());
            //}

            using (var inserter = new dpz2.Mvc.XOrmForVue.Inserter(null, tables, row, new dpz2.Mvc.XOrmForVue.Config("https://dev.lywos.com/Orm/Xml2", @"X:\temp\UI", @"X:\temp\Cache"), "Aos", "AosUsers")) {
                inserter.Save();
            }

            Console.WriteLine(form.GetHtml());
        }
    }
}
