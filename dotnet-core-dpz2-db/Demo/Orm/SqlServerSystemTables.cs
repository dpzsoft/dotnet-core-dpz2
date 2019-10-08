using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Orm {

    /// <summary>
    /// SqlServer系统专用表
    /// </summary>
    public class SqlServerSystemTables : dpz2.Object {

        // SysObjects表对象缓存
        private SystemTables.SysObjects _sysObjects = null;

        /// <summary>
        /// SysObjects表
        /// </summary>
        public SystemTables.SysObjects SysObjects {
            get {
                if (_sysObjects == null) _sysObjects = new SystemTables.SysObjects();
                return _sysObjects;
            }
        }

        // SysObjects表对象缓存
        private SystemTables.SysColumns _sysColumns = null;

        /// <summary>
        /// SysObjects表
        /// </summary>
        public SystemTables.SysColumns SysColumns {
            get {
                if (_sysColumns == null) _sysColumns = new SystemTables.SysColumns();
                return _sysColumns;
            }
        }

        // Test 表对象缓存
        private SystemTables.abc _cacheabc = null;

        /// <summary>
        /// Test 表
        /// </summary>
        public SystemTables.abc abc {
            get {
                if (_cacheabc == null) _cacheabc = new SystemTables.abc();
                return _cacheabc;
            }
        }

        public dpz2.db.SqlUnits.Table this[string name] {
            get {
                switch (name) {
                    case "SysObjects": return this.SysObjects;
                    case "SysColumns": return this.SysColumns;
                    case "abc": return this.abc;
                    default: throw new Exception("未找到对应表定义");
                }
            }
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        protected override void OnDispose() {
            base.OnDispose();

            if (_sysObjects != null) {
                _sysObjects.Dispose();
                _sysObjects = null;
            }

            if (_sysColumns != null) {
                _sysColumns.Dispose();
                _sysColumns = null;
            }
        }

    }
}
