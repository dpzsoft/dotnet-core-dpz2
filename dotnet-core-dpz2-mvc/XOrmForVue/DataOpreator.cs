using dpz2.Xml;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Mvc.XOrmForVue {

    /// <summary>
    /// 操作器
    /// </summary>
    public abstract class DataOpreator : Basic {

        //随机种子
        private Random rnd;

        /// <summary>
        /// 检查数值规则
        /// </summary>
        /// <param name="node"></param>
        /// <param name="title"></param>
        /// <param name="val"></param>
        protected void CheckNumberRule(XmlNode node, string title, double val) {

            //最小值检测
            if (node.Attr["min"] != "") {
                double limit = (node.Attr["min"]).ToDouble();
                if (val < limit) throw new Exception($"{title} 不能小于 {limit}");
            }

            //最大值检测
            if (node.Attr["max"] != "") {
                double limit = (node.Attr["max"]).ToDouble();
                if (val > limit) throw new Exception($"{title} 不能大于 {limit}");
            }

            //必须大于检测
            if (node.Attr["min-exp"] != "") {
                double limit = (node.Attr["min-exp"]).ToDouble();
                if (val <= limit) throw new Exception($"{title} 必须大于 {limit}");
            }

            //必须大于检测
            if (node.Attr["max-exp"] != "") {
                double limit = (node.Attr["max-exp"]).ToDouble();
                if (val >= limit) throw new Exception($"{title} 必须小于 {limit}");
            }

        }

        /// <summary>
        /// 检查数值唯一性规则
        /// </summary>
        /// <param name="node"></param>
        /// <param name="tabName"></param>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="val"></param>
        protected void CheckOnly(XmlNode node, string tabName, string name, string title, double val) {

            bool fieldDataOnly = node.Attr["only"] == "true";
            if (fieldDataOnly) {
                using (dpz2.db.Connection dbc = new dpz2.db.Connection(base.Database)) {
                    var table = Tables[tabName];
                    var row = dbc.Select(table)
                        .Where(table[name] == val)
                        .GetRow();
                    //var row = dbc.GetGdmlOne($"@{{$[{tabName}]&[{name}=='{val}']}}");
                    if (!row.IsEmpty) {
                        throw new Exception($"{title}已存在内容\"{val}\"，请确保{title}是唯一的");
                    }
                }
            }

        }

        /// <summary>
        /// 检查字符串唯一性规则
        /// </summary>
        /// <param name="node"></param>
        /// <param name="tabName"></param>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="val"></param>
        protected void CheckOnly(XmlNode node, string tabName, string name, string title, string val) {

            bool fieldDataOnly = node.Attr["only"] == "true";
            if (fieldDataOnly) {
                using (dpz2.db.Connection dbc = new dpz2.db.Connection(base.Database)) {
                    var table = Tables[tabName];
                    var row = dbc.Select(table)
                        .Where(table[name] == val)
                        .GetRow();
                    //var row = dbc.GetGdmlOne($"@{{$[{tabName}]&[{name}=='{val}']}}");
                    if (!row.IsEmpty) {
                        throw new Exception($"{title}已存在内容\"{val}\"，请确保{title}是唯一的");
                    }
                }
            }

        }

        /// <summary>
        /// 检查数值规则
        /// </summary>
        /// <param name="table"></param>
        /// <param name="tabName"></param>
        /// <param name="row"></param>
        protected void CheckForm(XmlNode table, string tabName, dpz2.db.Row row) {

            var fields = table["fields"].GetNodesByTagName("field", false);

            foreach (var field in fields) {
                if (field.Name.ToLower() == "field") {
                    string fieldName = field.Attr["name"];
                    string fieldTitle = field.Attr["title"];
                    var fieldData = field["data"];
                    if (fieldData == null) {
                        fieldData = new XmlNode("data");
                        fieldData.Attr["type"] = "";
                    }
                    string fieldDataType = fieldData.Attr["type"];
                    bool fieldDataEmpty = fieldData.Attr["empty"] != "false";
                    int fieldDataFloat = (fieldData.Attr["float"]).ToInteger();

                    // 获取Add定义
                    var fieldAdd = field.GetNodeByAttr("name", "add");
                    if (fieldAdd != null) {

                        string fieldAddSave = fieldAdd.Attr["save"];
                        switch (fieldAddSave) {
                            case "form":
                                #region [=====从表单获取=====]
                                string val = "";
                                if (base.Form.ContainsKey(fieldName)) {
                                    val = base.Form[fieldName];
                                }
                                string fieldValue = val;
                                switch (fieldDataType) {
                                    case "string":
                                    case "varchar":
                                    case "nvarchar":
                                    case "text":
                                        //字符串类型
                                        if (!fieldDataEmpty) {
                                            if (fieldValue.IsNone()) throw new Exception($"{fieldTitle}不允许为空");
                                        }
                                        //检测唯一性
                                        CheckOnly(fieldData, tabName, fieldName, fieldTitle, fieldValue.ToString());
                                        //where += $".[{fieldName}='{fieldValue.ToString()}']";
                                        break;
                                    case "double":
                                    case "float":
                                    case "decimal":
                                    case "numeric":
                                        //带经度的数字
                                        if (fieldDataFloat > 0) {
                                            if (!fieldValue.IsNone() && !fieldValue.IsDouble()) throw new Exception($"{fieldTitle}只允许填写数字");
                                            CheckNumberRule(fieldData, fieldTitle, fieldValue.ToDouble());
                                            //检测唯一性
                                            CheckOnly(fieldData, tabName, fieldName, fieldTitle, fieldValue.ToDouble());
                                            //where += $".[{fieldName}='{fieldValue.Double.ToString()}']";
                                        } else {
                                            if (!fieldValue.IsNone() && !fieldValue.IsLong()) throw new Exception($"{fieldTitle}只允许填写整数");
                                            //检测唯一性
                                            CheckOnly(fieldData, tabName, fieldName, fieldTitle, fieldValue.ToLong());
                                            CheckNumberRule(fieldData, fieldTitle, fieldValue.ToLong());
                                            //where += $".[{fieldName}='{fieldValue.Long.ToString()}']";
                                        }
                                        break;
                                    case "long":
                                    case "bigint":
                                        //长整型
                                        if (!fieldValue.IsNone() && !fieldValue.IsLong()) throw new Exception($"{fieldTitle}只允许填写整数");
                                        CheckNumberRule(fieldData, fieldTitle, fieldValue.ToLong());
                                        //检测唯一性
                                        CheckOnly(fieldData, tabName, fieldName, fieldTitle, fieldValue.ToLong());
                                        //where += $".[{fieldName}='{fieldValue.Long.ToString()}']";
                                        break;
                                    case "integer":
                                    case "int":
                                        //整型
                                        if (!fieldValue.IsNone() && !fieldValue.IsInteger()) throw new Exception($"{fieldTitle}只允许填写整数");
                                        CheckNumberRule(fieldData, fieldTitle, fieldValue.ToInteger());
                                        //检测唯一性
                                        CheckOnly(fieldData, tabName, fieldName, fieldTitle, fieldValue.ToInteger());
                                        //where += $".[{fieldName}='{fieldValue.Integer.ToString()}']";
                                        break;
                                    default:
                                        throw new Exception($"{fieldTitle}的数据类型'{fieldDataType}'不受支持，请检查配置文件");
                                        //return JsonContent(0, $"未知数据类型:{fieldDataType},相关字段:{fieldName}");
                                }
                                #endregion
                                break;
                            case "fill":
                                #region [=====从设定中填充=====]
                                //var fieldAddFill = fieldAdd["fill"];
                                //string fillValue = GetFillContent(plmName, tabName, fieldAddFill, row);
                                //where += $".[{fieldName}='{fillValue}']";
                                #endregion
                                break;
                            case "row":
                                #region [=====从数据行参数中填充=====]
                                //string rowValue = row[fieldName];
                                //where += $".[{fieldName}='{rowValue}']";
                                #endregion
                                break;
                            case "none": break;
                            default: throw new Exception($"{fieldTitle}的添加行为数据源类型'{fieldAddSave}'不受支持，请检查配置文件");

                        }

                    }

                }
            }

        }

        /// <summary>
        /// 填充行数据
        /// </summary>
        /// <param name="cnt"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        protected string FillWithSign(string cnt, dpz2.db.Row row) {

            string res = cnt;

            //进行内容填充
            res = res.Replace("{{", "{{}");
            res = res.Replace("}}", "{}}");
            if (row != null) {
                foreach (var item in row) {
                    res = res.Replace("{" + item.Key + "}", item.Value);
                }
            }
            if (base.Form != null) {
                foreach (var item in base.Form) {
                    res = res.Replace("{Form." + item.Key + "}", item.Value);
                }
            }
            res = res.Replace("{{}", "{");
            res = res.Replace("{}}", "}");

            return res;

        }

        /// <summary>
        /// 获取填充内容
        /// </summary>
        /// <param name="plmName"></param>
        /// <param name="tabName"></param>
        /// <param name="fills"></param>
        /// <param name="rowFill"></param>
        /// <returns></returns>
        protected string GetFillContent(string plmName, string tabName, dpz2.Xml.XmlNode fills, dpz2.db.Row rowFill) {
            string res = "";

            // 获取所有的fill定义
            var fillNodes = fills.GetNodesByTagName("fill", false);
            foreach (var fill in fillNodes) {
                switch (fill.Name.ToLower()) {
                    case "string"://字符串
                        res += FillWithSign(fill.Attr["value"], rowFill);
                        break;
                    case "random"://随机类型
                        string rType = fill.Attr["type"].ToLower();
                        switch (rType) {
                            case "string":
                                string seed = fill.Attr["seed"];
                                if (seed == "")
                                    throw new Exception("随机字符串填充中未定义密钥种子");
                                int len = fill.Attr["length"].ToInteger();
                                if (len <= 0)
                                    throw new Exception("随机字符串长度未定义或定义不规范");
                                for (int k = 0; k < len; k++) {
                                    res += seed[rnd.Next(seed.Length)];
                                }
                                break;
                            case "int":
                                int nMin = (fill.Attr["min"]).ToInteger();
                                int nMax = (fill.Attr["max"]).ToInteger();
                                if (nMax <= nMin)
                                    throw new Exception("随机数字范围未定义或定义不规范");
                                res += rnd.Next(nMin, nMax);
                                break;
                            default://默认为小数随机
                                int dbFloat = (fill.Attr["float"]).ToInteger();
                                double dbMin = (fill.Attr["min"]).ToDouble();
                                double dbMax = (fill.Attr["max"]).ToDouble();
                                if (dbMax <= dbMin)
                                    throw new Exception("随机数字范围未定义或定义不规范");
                                double dbVal = dbMin + rnd.NextDouble() * (dbMax - dbMin);
                                if (dbFloat > 0) {
                                    dbVal = Math.Round(dbVal, dbFloat);
                                }
                                res += dbVal;
                                break;
                        }
                        break;
                    case "date":
                        long ts = fill.Attr["timestamp"].ToLong();
                        if (ts <= 0) {
                            res += dpz2.Time.Now.ToString(fill.Attr["format"]);
                        } else {
                            res += dpz2.Time.New(ts).ToString(fill.Attr["format"]);
                        }
                        break;
                    case "indexer":
                        //throw new Exception("尚未支持索引器填充");
                        rType = fill.Attr["type"].ToLower();
                        string rName = FillWithSign(fill.Attr["name"], rowFill);
                        long rStart = (fill.Attr["start"]).ToLong();
                        int rLen = (fill.Attr["length"]).ToInteger();
                        string key = "Indexer";

                        //默认占位长度为1
                        if (rLen <= 0) rLen = 1;

                        //处理类型
                        switch (rType) {
                            case "year":
                                key += $"_Y{dpz2.Time.Now.ToString("yyyy")}";
                                break;
                            case "month":
                                key += $"_M{dpz2.Time.Now.ToString("yyyyMM")}";
                                break;
                            case "day":
                                key += $"_D{dpz2.Time.Now.ToString("yyyyMMdd")}";
                                break;
                            case "":
                            case "only":
                                key += $"_only";
                                break;
                            default:
                                throw new Exception($"尚未支持的索引类型\"{rType}\"");
                        }

                        key += $"_{rName}";

                        using (dpz2.db.Connection dbc = new dpz2.db.Connection(base.Database)) {

                            // 获取自动编号定义
                            var SystemAutomatic = Tables["SystemAutomatic"];
                            var row = dbc.Select(SystemAutomatic)
                                .Columns(SystemAutomatic["ID"], SystemAutomatic["Number"])
                                .Where(SystemAutomatic["Name"] == key)
                                .GetRow();

                            if (!row.IsEmpty) {
                                // 已有编号则自增加
                                long idx = row["Number"].ToLong() + 1;
                                res += ("" + idx).PadLeft(rLen, '0');
                                row["Number"] = $"{idx}";
                                dbc.Update(SystemAutomatic, row, SystemAutomatic["ID"]).Exec();
                            } else {
                                // 没有编号则添加自编号初始数值
                                var rowNew = new dpz2.db.Row();
                                rowNew["Name"] = key;
                                rowNew["Number"] = $"{rStart}";
                                res += ("" + rStart).PadLeft(rLen, '0');
                                dbc.Insert(SystemAutomatic, rowNew).Exec();
                            }
                        }
                        break;
                    case "script":
                        throw new Exception("尚未支持脚本填充");
                    default:
                        throw new Exception("未支持的填充类型:" + fill.Name);
                }
            }
            return res;
        }

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="db"></param>
        /// <param name="form"></param>
        /// <param name="tables"></param>
        /// <param name="config"></param>
        /// <param name="plmName"></param>
        /// <param name="tabName"></param>
        public DataOpreator(dpz2.db.Database db, dpz2.db.OrmTables tables, dpz2.db.Row form, Config config, string plmName, string tabName) : base(db, tables, form, config, plmName, tabName) {
            rnd = new Random();
        }

    }
}
