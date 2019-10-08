using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace dpz2.Mvc.XOrmForVue {

    /// <summary>
    /// 更新管理器
    /// </summary>
    public class Updater : DataOpreator {

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="db"></param>
        /// <param name="form"></param>
        /// <param name="tables"></param>
        /// <param name="config"></param>
        /// <param name="plmName"></param>
        /// <param name="tabName"></param>
        public Updater(dpz2.db.Database db, dpz2.db.OrmTables tables, dpz2.db.Row form, Config config, string plmName, string tabName) : base(db, tables, form, config, plmName, tabName) { }

        /// <summary>
        /// 修改数据保存
        /// </summary>
        /// <param name="row"></param>
        public void Save(dpz2.db.Row row = null) {

            //存储所有的列信息
            dpz2.db.SqlUnits.Formula where = null;
            dpz2.db.Row rowUpdate = new db.Row();
            string id = base.Form["ID"];
            if (id == "") throw new Exception("未发现更新唯一标识");

            //读取配置文件内容
            string xmlText = dpz2.File.UTF8File.ReadAllText(base.XmlPath);
            using (var xml = dpz2.Xml.Parser.GetDocument(xmlText)) {

                //进行提交数据检测
                var table = xml["table"];
                CheckForm(table, base.Table, row);

                var fields = table["fields"].GetNodesByTagName("field", false);
                foreach (var field in fields) {
                    if (field.Name.ToLower() == "field") {
                        string fieldName = field.Attr["name"];
                        string fieldTitle = field.Attr["title"];
                        var fieldData = field["data"];
                        if (fieldData == null) {
                            fieldData = new Xml.XmlNode("data");
                            fieldData.Attr["type"] = "";
                        }
                        string fieldDataType = fieldData.Attr["type"];
                        bool fieldDataEmpty = fieldData.Attr["empty"] != "false";
                        int fieldDataFloat = fieldData.Attr["float"].ToInteger();
                        string fieldDataEncoding = fieldData.Attr["encoding"];

                        var fieldEdit = field["edit"];
                        if (fieldEdit != null) {

                            string fieldEditSave = fieldEdit.Attr["save"];
                            switch (fieldEditSave) {
                                case "form":
                                    #region [=====从表单获取=====]
                                    string fieldValue = base.Form[fieldName];

                                    //进行编码处理
                                    switch (fieldDataEncoding?.ToLower()) {
                                        case "url":
                                            fieldValue = "encoding://url/" + HttpUtility.UrlEncode(fieldValue);
                                            break;
                                    }

                                    switch (fieldDataType) {
                                        case "string":
                                        case "varchar":
                                        case "nvarchar":
                                        case "text":
                                            rowUpdate[fieldName] = fieldValue;
                                            break;
                                        case "double":
                                        case "float":
                                        case "decimal":
                                        case "numeric":
                                            //带经度的数字
                                            if (fieldDataFloat > 0) {
                                                rowUpdate[fieldName] = $"{fieldValue.ToDouble()}";
                                            } else {
                                                rowUpdate[fieldName] = $"{fieldValue.ToLong()}";
                                            }
                                            break;
                                        case "long":
                                        case "bigint":
                                            //长整型
                                            rowUpdate[fieldName] = $"{fieldValue.ToLong()}";
                                            break;
                                        case "integer":
                                        case "int":
                                            //整型
                                            rowUpdate[fieldName] = $"{fieldValue.ToInteger()}";
                                            break;
                                        default:
                                            throw new Exception($"{fieldTitle}的数据类型'{fieldDataType}'不受支持，请检查配置文件");
                                            //return JsonContent(0, $"未知数据类型:{fieldDataType},相关字段:{fieldName}");
                                    }
                                    #endregion
                                    break;
                                case "fill":
                                    #region [=====从设定中填充=====]
                                    var fieldAddFill = fieldEdit["fill"];
                                    string fillValue = GetFillContent(base.Platform, base.Table, fieldAddFill, row);

                                    //进行编码处理
                                    switch (fieldDataEncoding.ToLower()) {
                                        case "url":
                                            fillValue = "encoding://url/" + HttpUtility.UrlEncode(fillValue);
                                            break;
                                    }

                                    rowUpdate[fieldName] = fillValue;
                                    #endregion
                                    break;
                                case "row":
                                    #region [=====从数据行参数中填充=====]
                                    string rowValue = row[fieldName];

                                    //进行编码处理
                                    switch (fieldDataEncoding.ToLower()) {
                                        case "url":
                                            rowValue = "encoding://url/" + HttpUtility.UrlEncode(rowValue);
                                            break;
                                    }

                                    rowUpdate[fieldName] = rowValue;
                                    #endregion
                                    break;
                                case "none": break;
                                default: throw new Exception($"{fieldTitle}的添加行为数据源类型'{fieldEdit}'不受支持，请检查配置文件");

                            }

                        }

                    }
                }
            }

            if (rowUpdate.IsEmpty) throw new Exception("未发现可存储字段，请检查配置文件");

            //string gdml = $"!{{$[{base.Table}]{where}&[ID=='{id}']}}";

            using (dpz2.db.Connection dbc = new db.Connection(base.Database)) {
                var table = Tables[base.Table];
                dbc.Update(table, rowUpdate).Where(table["ID"] == id).Exec();
            }

        }

    }

}
