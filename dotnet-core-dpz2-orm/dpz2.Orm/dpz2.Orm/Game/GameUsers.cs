using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Game {

    /// <summary>
    /// 游戏人物
    /// 游戏人物
    /// Version 2016.0401
    /// </summary>
    public class GameUsers : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 游戏人物 行数据操作器
        /// </summary>
        public class RowOperator : dpz2.db.RowOperator {

            /// <summary>
            /// 对象实例化
            /// </summary>
            /// <param name="row">行数据对象</param>
            public RowOperator(dpz2.db.Row row) : base(row) { }

            /// <summary>
            /// 设置ID
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetID(string value) {
                base.Row["ID"] = value;
                return this;
            }

            /// <summary>
            /// 设置用户编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置服务器编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetServerID(string value) {
                base.Row["ServerID"] = value;
                return this;
            }

            /// <summary>
            /// 设置角色名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNick(string value) {
                base.Row["Nick"] = value;
                return this;
            }

            /// <summary>
            /// 设置等级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLv(string value) {
                base.Row["Lv"] = value;
                return this;
            }

            /// <summary>
            /// 设置血量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBlood(string value) {
                base.Row["Blood"] = value;
                return this;
            }

            /// <summary>
            /// 设置扩展血量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBloodExp(string value) {
                base.Row["BloodExp"] = value;
                return this;
            }

            /// <summary>
            /// 设置当前经验
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetExp(string value) {
                base.Row["Exp"] = value;
                return this;
            }

        }

        /// <summary>
        /// 获取*字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField All { get; private set; }

        /// <summary>
        /// 获取ID字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ID { get; private set; }

        /// <summary>
        /// 获取用户编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取服务器编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ServerID { get; private set; }

        /// <summary>
        /// 获取角色名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Nick { get; private set; }

        /// <summary>
        /// 获取等级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Lv { get; private set; }

        /// <summary>
        /// 获取血量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Blood { get; private set; }

        /// <summary>
        /// 获取扩展血量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BloodExp { get; private set; }

        /// <summary>
        /// 获取当前经验字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Exp { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public GameUsers() : base("GameUsers") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.ServerID = new dpz2.db.SqlUnits.TableField(this, "ServerID");
            this.Nick = new dpz2.db.SqlUnits.TableField(this, "Nick");
            this.Lv = new dpz2.db.SqlUnits.TableField(this, "Lv");
            this.Blood = new dpz2.db.SqlUnits.TableField(this, "Blood");
            this.BloodExp = new dpz2.db.SqlUnits.TableField(this, "BloodExp");
            this.Exp = new dpz2.db.SqlUnits.TableField(this, "Exp");
        }

    }

}
