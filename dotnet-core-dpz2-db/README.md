# dpz2.db

dpz2开发套件数据库应用扩展(.Net Core)

## 致力于多数据库操作可移植性的类库

本类库目前支持SqlServer、MySql、Sqlite三个类型的数据库，使用本套件在这些数据库间切换只需重新指定数据类型即可。

## 数据库申明

Sql Server:

    var db = new dpz2.db.Databases.MicrosoftSqlServer() {
        Address = "127.0.0.1",
        Port = 1433,
        Name = "mater",
        User = "sa",
        Password = "123456"
    };

MySql:

    var db = new dpz2.db.Databases.MySql() {
        Address = "127.0.0.1",
        Port = 3306,
        Name = "mysql",
        User = "root",
        Password = "123456"
    };

Sqlite:

    var db = new dpz2.db.Databases.Sqlite() {
        Path="/my/temp.db"
    };

## 使用更接近原始SQL数据库操作语句，降低学习成本

建立数据查询，并判断后获取结果：

    // 建立数据库连接
    using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

        // 创建一个ORM对象
        using (SqlServerSystemTables orm = new SqlServerSystemTables()) {

            // 定义Select语句并读取一行数据
            var row = dbc.Select(orm.SysObjects, orm.SysColumns)
                .Columns(orm.SysColumns.Name)
                .Where((orm.SysObjects.Id == orm.SysColumns.Id) & (orm.SysObjects.Name == "SyatemObjects") & (orm.SysColumns.Name == "Name") & orm.SysObjects.Type.In("S", "U"))
                .GetRow();

            // 判断是否读取到数据
            if (!row.IsEmpty) {

                // 字段定义方式读取数据
                Console.WriteLine($"Name = {row[orm.SysColumns.Name]}");

                // 字符串定义方式读取数据
                Console.WriteLine($"Name = {row["Name"]}");

                // 动态方式读取数据
                dynamic dyc = row;
                Console.WriteLine($"Name = {dyc.Name}");
            }
        }
    }

插入数据：

    // 建立数据库连接
    using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

        // 创建一个ORM对象
        using (SqlServerSystemTables orm = new SqlServerSystemTables()) {

            // 新建一个行数据对象，定义需要插入的数据
            Row row = new Row();
            orm.SysColumns.Rower(row)
                .SetName("123");

            // 创建一个Insert语句并执行
            dbc.Insert(orm.SysColumns, row).Exec();
        }
    }

以Id为主键更新数据：

    // 建立数据库连接
    using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

        // 创建一个ORM对象
        using (SqlServerSystemTables orm = new SqlServerSystemTables()) {

            // 新建一个行数据对象，定义需要插入的数据
            Row row = new Row();
            orm.SysColumns.Rower(row)
                .SetId(1)
                .SetName("123");

            // 创建一个Update语句并执行
            dbc.Update(orm.SysColumns, row, orm.SysColumns.Id).Exec();
        }
    }

自定义条件更新数据：

    // 建立数据库连接
    using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

        // 创建一个ORM对象
        using (SqlServerSystemTables orm = new SqlServerSystemTables()) {

            // 新建一个行数据对象，定义需要插入的数据
            Row row = new Row();
            orm.SysColumns.Rower(row)
                .SetName("123");

            // 创建一个Update语句并执行
            dbc.Update(orm.SysObjects, row)
                .Where(orm.SysColumns.Name == "456")
                .Exec();
        }
    }

删除数据：

    // 建立数据库连接
    using (dpz2.db.Connection dbc = new dpz2.db.Connection(db)) {

        // 创建一个ORM对象
        using (SqlServerSystemTables orm = new SqlServerSystemTables()) {

            // 创建一个Insert语句并执行
            dbc.Delete(orm.SysObjects)
                .Where(orm.SysColumns.Name == "456")
                .Exec();
        }
    }
