using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.AI {

    /// <summary>
    /// 词汇记忆
    /// 词汇记忆
    /// Version 2016.0401
    /// </summary>
    public class AIWords : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 词汇记忆 行数据操作器
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
            /// 设置词语
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWords(string value) {
                base.Row["Words"] = value;
                return this;
            }

            /// <summary>
            /// 设置词性
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWordType(string value) {
                base.Row["WordType"] = value;
                return this;
            }

            /// <summary>
            /// 设置含义
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMeaning(string value) {
                base.Row["Meaning"] = value;
                return this;
            }

            /// <summary>
            /// 设置使用举例
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetExamples(string value) {
                base.Row["Examples"] = value;
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
        /// 获取词语字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Words { get; private set; }

        /// <summary>
        /// 获取词性字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField WordType { get; private set; }

        /// <summary>
        /// 获取含义字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Meaning { get; private set; }

        /// <summary>
        /// 获取使用举例字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Examples { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AIWords() : base("AIWords") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Words = new dpz2.db.SqlUnits.TableField(this, "Words");
            this.WordType = new dpz2.db.SqlUnits.TableField(this, "WordType");
            this.Meaning = new dpz2.db.SqlUnits.TableField(this, "Meaning");
            this.Examples = new dpz2.db.SqlUnits.TableField(this, "Examples");
        }

    }

}
