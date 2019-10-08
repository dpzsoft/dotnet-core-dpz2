using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Assess {

    /// <summary>
    /// 考核评分
    /// 考核评分
    /// Version 1712.0003
    /// </summary>
    public class AssessScore : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 考核评分 行数据操作器
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
            /// 设置用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置考核项目标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetItemID(string value) {
                base.Row["ItemID"] = value;
                return this;
            }

            /// <summary>
            /// 设置考核轮次
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAssessRounds(string value) {
                base.Row["AssessRounds"] = value;
                return this;
            }

            /// <summary>
            /// 设置功能标志
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFlag(string value) {
                base.Row["Flag"] = value;
                return this;
            }

            /// <summary>
            /// 设置评分
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetScore(string value) {
                base.Row["Score"] = value;
                return this;
            }

            /// <summary>
            /// 设置评分描述
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDescription(string value) {
                base.Row["Description"] = value;
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
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取考核项目标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ItemID { get; private set; }

        /// <summary>
        /// 获取考核轮次字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AssessRounds { get; private set; }

        /// <summary>
        /// 获取功能标志字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Flag { get; private set; }

        /// <summary>
        /// 获取评分字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Score { get; private set; }

        /// <summary>
        /// 获取评分描述字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Description { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AssessScore() : base("AssessScore") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.ItemID = new dpz2.db.SqlUnits.TableField(this, "ItemID");
            this.AssessRounds = new dpz2.db.SqlUnits.TableField(this, "AssessRounds");
            this.Flag = new dpz2.db.SqlUnits.TableField(this, "Flag");
            this.Score = new dpz2.db.SqlUnits.TableField(this, "Score");
            this.Description = new dpz2.db.SqlUnits.TableField(this, "Description");
        }

    }

}
