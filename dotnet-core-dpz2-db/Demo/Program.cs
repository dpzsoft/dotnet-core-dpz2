using System;
using dpz2.db;
using Demo.Orm;

namespace Demo {
    class Program {
        static void Main(string[] args) {
            int tick = Environment.TickCount;
            var db = new dpz2.db.Databases.PostgreSql() {
                Address = "111.73.45.233",
                Port = 5439,
                Name = "test",
                User = "yyt",
                Password = "Yunyitong2016"
            };
            //var db = new dpz2.db.Databases.MySql() {
            //    Address = "127.0.0.1",
            //    Port = 3306,
            //    Name = "mysql",
            //    User = "root",
            //    Password = "123456"
            //};
            //var db = new dpz2.db.Databases.Sqlite() {
            //    Path="/my/temp.db"
            //};

            // 完整的查询操作
            // 建立数据库连接
            //using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

            //    // 创建一个ORM对象
            //    using (SqlServerSystemTables orm = new SqlServerSystemTables()) {

            //        // 定义Select语句并读取一行数据
            //        var row = dbc.Select(orm.SysObjects, orm.SysColumns)
            //            .Columns(orm.SysColumns.Name)
            //            .Where((orm.SysObjects.Id == orm.SysColumns.Id) & (orm.SysObjects.Name == "SyatemObjects") & (orm.SysColumns.Name == "Name") & orm.SysObjects.Type.In("S", "U"))
            //            .GetRow();

            //        // 判断是否读取到数据
            //        if (!row.IsEmpty) {

            //            // 字段定义方式读取数据
            //            Console.WriteLine($"Name = {row[orm.SysColumns.Name]}");

            //            // 字符串定义方式读取数据
            //            Console.WriteLine($"Name = {row["Name"]}");

            //            // 动态方式读取数据
            //            dynamic dyc = row;
            //            Console.WriteLine($"Name = {dyc.Name}");
            //        }
            //    }
            //}

            // 建立数据库连接
            //using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

            //    // 创建一个ORM对象
            //    using (SqlServerSystemTables orm = new SqlServerSystemTables()) {

            //        // 新建一个行数据对象，定义需要插入的数据
            //        Row row = new Row();
            //        orm.SysColumns.Rower(row)
            //            .SetName("123");

            //        // 创建一个Insert语句并执行
            //        dbc.Insert(orm.SysColumns, row).Exec();
            //    }
            //}

            // 建立数据库连接
            //using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

            //    // 创建一个ORM对象
            //    using (SqlServerSystemTables orm = new SqlServerSystemTables()) {

            //        // 新建一个行数据对象，定义需要插入的数据
            //        Row row = new Row();
            //        orm.SysColumns.Rower(row)
            //            .SetId(1)
            //            .SetName("123");

            //        // 创建一个Update语句并执行
            //        dbc.Update(orm.SysColumns, row, orm.SysColumns.Id).Exec();
            //    }
            //}

            // 建立数据库连接
            //using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

            //    // 创建一个ORM对象
            //    using (SqlServerSystemTables orm = new SqlServerSystemTables()) {

            //        // 新建一个行数据对象，定义需要插入的数据
            //        Row row = new Row();
            //        orm.SysColumns.Rower(row)
            //            .SetName("123");

            //        // 创建一个Update语句并执行
            //        dbc.Update(orm.SysObjects, row)
            //            .Where(orm.SysColumns.Name == "456")
            //            .Exec();
            //    }
            //}

            // 建立数据库连接
            //using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

            //    // 创建一个ORM对象
            //    using (SqlServerSystemTables orm = new SqlServerSystemTables()) {

            //        // 创建一个Insert语句并执行
            //        dbc.Delete(orm.SysObjects)
            //            .Where(orm.SysColumns.Name == "456")
            //            .Exec();
            //    }
            //}

            using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

                // 查询语句带函数测试
                Console.WriteLine();
                using (SqlServerSystemTables orm = new SqlServerSystemTables()) {
                    string sql = dbc.Select(orm.SysObjects)
                        .Columns(dbc.Count(orm.SysObjects.Id))
                        .ToSqlString();
                    Console.WriteLine(sql);
                }

                // 查询语句带函数测试
                Console.WriteLine();
                using (SqlServerSystemTables orm = new SqlServerSystemTables()) {
                    string sql = dbc.Select(orm.SysObjects, orm.SysColumns)
                        .Columns(dbc.Count(orm.SysObjects.Id))
                        .Where((orm.SysObjects.Id == orm.SysColumns.Id) & (orm.SysObjects.Name == "SyatemObjects") & orm.SysObjects.Type.In("S", "U"))
                        .ToSqlString();
                    Console.WriteLine(sql);
                }

                // 查询语句测试
                Console.WriteLine();
                using (SqlServerSystemTables orm = new SqlServerSystemTables()) {
                    string sql = dbc.Select(orm.SysColumns)
                        .Where(orm.SysColumns.Id.In(dbc.Select(orm.SysObjects)
                            .Columns(orm.SysObjects.Id)
                            .Where((orm.SysObjects.Name == "SyatemObjects") & orm.SysObjects.Type.In("S", "U"))
                            ))
                        .ToSqlString();
                    Console.WriteLine(sql);
                }

                // 查询语句测试
                Console.WriteLine();
                using (SqlServerSystemTables orm = new SqlServerSystemTables()) {
                    string sql = dbc.Select(orm.SysObjects)
                        .Columns(orm.SysObjects.Name)
                        .Asc(orm.SysObjects.Name)
                        .Group(orm.SysObjects.Name)
                        .ToSqlString();
                    Console.WriteLine(sql);
                }

                // 查询语句测试
                Console.WriteLine();
                using (SqlServerSystemTables orm = new SqlServerSystemTables()) {
                    string sql = dbc.Select(orm.SysObjects)
                        .Limit(orm.SysObjects.Id, 0, 10)
                        .ToSqlString();
                    Console.WriteLine(sql);
                }

                // 插入数据测试
                Console.WriteLine();
                using (SqlServerSystemTables orm = new SqlServerSystemTables()) {
                    Row row = new Row();
                    orm.SysColumns.Rower(row)
                        .SetName("123");
                    string sql = dbc.Insert(orm.SysObjects, row)
                        .ToSqlString();
                    Console.WriteLine(sql);
                }

                // 更新数据测试
                Console.WriteLine();
                using (SqlServerSystemTables orm = new SqlServerSystemTables()) {
                    Row row = new Row();
                    orm.SysColumns.Rower(row)
                        .SetId(1)
                        .SetName("123");
                    string sql = dbc.Update(orm.SysObjects, row, orm.SysObjects.Id)
                        .ToSqlString();
                    Console.WriteLine(sql);
                }

                // 更新数据测试
                Console.WriteLine();
                using (SqlServerSystemTables orm = new SqlServerSystemTables()) {
                    Row row = new Row();
                    orm.SysColumns.Rower(row)
                        .SetName("123");
                    string sql = dbc.Update(orm.SysObjects, row)
                        .ToSqlString();
                    Console.WriteLine(sql);
                }

                // 更新数据测试
                Console.WriteLine();
                using (SqlServerSystemTables orm = new SqlServerSystemTables()) {
                    Row row = new Row();
                    orm.SysColumns.Rower(row)
                        .SetName("123");
                    string sql = dbc.Update(orm.SysObjects, row)
                        .Where(orm.SysObjects.Name == "456")
                        .ToSqlString();
                    Console.WriteLine(sql);
                }

                // 删除数据测试
                Console.WriteLine();
                using (SqlServerSystemTables orm = new SqlServerSystemTables()) {
                    string sql = dbc.Delete(orm.SysObjects)
                        .Where(orm.SysObjects.Name == "456")
                        .ToSqlString();
                    Console.WriteLine(sql);
                }


                if (!dbc.CheckDatabase("test3")) {
                    dbc.CreateDatabase("test3");
                }

                if (!dbc.CheckTable("bbb")) {
                    dbc.CreateTable("bbb");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine($"耗时 {Environment.TickCount - tick} 毫秒");
            Console.ReadKey();
        }
    }
}
