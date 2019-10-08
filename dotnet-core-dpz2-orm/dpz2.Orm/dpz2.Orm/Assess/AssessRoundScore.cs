using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Assess {

    /// <summary>
    /// 考核轮得分
    /// 考核轮得分
    /// Version 1711.0001
    /// </summary>
    public class AssessRoundScore : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 考核轮得分 行数据操作器
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
            /// 设置考核标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAssessID(string value) {
                base.Row["AssessID"] = value;
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
            /// 设置总分
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetScore(string value) {
                base.Row["Score"] = value;
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
        /// 获取考核标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AssessID { get; private set; }

        /// <summary>
        /// 获取考核轮次字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AssessRounds { get; private set; }

        /// <summary>
        /// 获取总分字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Score { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AssessRoundScore() : base("AssessRoundScore") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.AssessID = new dpz2.db.SqlUnits.TableField(this, "AssessID");
            this.AssessRounds = new dpz2.db.SqlUnits.TableField(this, "AssessRounds");
            this.Score = new dpz2.db.SqlUnits.TableField(this, "Score");
        }

    }

}
