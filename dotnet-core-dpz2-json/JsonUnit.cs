using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Json {

    /// <summary>
    /// 单元类型
    /// </summary>
    public enum UnitType {

        /// <summary>
        /// 数值类型
        /// </summary>
        Number = 0x01,

        /// <summary>
        /// 字符串类型
        /// </summary>
        String = 0x02,

        /// <summary>
        /// 对象类型
        /// </summary>
        Object = 0x03,

        /// <summary>
        /// 数组类型
        /// </summary>
        Array = 0x04
    }

    /// <summary>
    /// Json存储单元
    /// </summary>
    public abstract class JsonUnit : dpz2.Object {

        /// <summary>
        /// 获取单元类型
        /// </summary>
        public UnitType UnitType { get; private set; }

        /// <summary>
        /// 获取父对象
        /// </summary>
        public JsonUnit Parent { get; private set; }

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parent"></param>
        public JsonUnit(UnitType type, JsonUnit parent = null) {
            this.UnitType = type;
            this.Parent = parent;
        }

        #region [=====操作接口=====]

        /// <summary>
        /// 获取数值
        /// </summary>
        /// <returns></returns>
        protected virtual double OnGetNumber() { throw new Exception($"{this.UnitType.ToString()}类型尚未支持获取数值内容"); }

        /// <summary>
        /// 获取数值
        /// </summary>
        /// <returns></returns>
        public double GetNumber() { return OnGetNumber(); }

        /// <summary>
        /// 设置数值
        /// </summary>
        /// <returns></returns>
        protected virtual void OnSetNumber(double value) { throw new Exception($"{this.UnitType.ToString()}类型尚未支持设置数值内容"); }

        /// <summary>
        /// 设置数值
        /// </summary>
        /// <returns></returns>
        public void SetValue(double value) { this.OnSetNumber(value); }

        /// <summary>
        /// 获取数值
        /// </summary>
        /// <returns></returns>
        protected virtual bool OnGetBoolean() { throw new Exception($"{this.UnitType.ToString()}类型尚未支持获取数值内容"); }

        /// <summary>
        /// 获取数值
        /// </summary>
        /// <returns></returns>
        public bool GetBoolean() { return OnGetBoolean(); }

        /// <summary>
        /// 设置数值
        /// </summary>
        /// <returns></returns>
        protected virtual void OnSetBoolean(bool value) { throw new Exception($"{this.UnitType.ToString()}类型尚未支持设置数值内容"); }

        /// <summary>
        /// 设置数值
        /// </summary>
        /// <returns></returns>
        public void SetBoolean(bool value) { this.OnSetBoolean(value); }

        /// <summary>
        /// 获取字符串
        /// </summary>
        /// <returns></returns>
        protected virtual string OnGetString() { throw new Exception($"{this.UnitType.ToString()}类型尚未支持获取字符串内容"); }

        /// <summary>
        /// 获取数值
        /// </summary>
        /// <returns></returns>
        public string GetString() { return OnGetString(); }

        /// <summary>
        /// 设置数值
        /// </summary>
        /// <returns></returns>
        protected virtual void OnSetString(string value) { throw new Exception($"{this.UnitType.ToString()}类型尚未支持设置字符串内容"); }

        /// <summary>
        /// 设置数值
        /// </summary>
        /// <returns></returns>
        public void SetValue(string value) { this.OnSetString(value); }

        /// <summary>
        /// 获取Json标准字符串
        /// </summary>
        /// <returns></returns>
        protected virtual string OnGetJsonString() { throw new Exception($"{this.UnitType.ToString()}类型尚未支持获取Json标准字符串"); }

        /// <summary>
        /// 获取Json标准字符串
        /// </summary>
        /// <returns></returns>
        public string ToJsonString() { return OnGetJsonString(); }

        /// <summary>
        /// 获取索引对象
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected virtual JsonUnit OnGetArrayItem(int index) { throw new Exception($"{this.UnitType.ToString()}类型尚未支持获取索引对象"); }

        /// <summary>
        /// 设置索引对象
        /// </summary>
        /// <param name="index"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        protected virtual void OnSetArrayItem(int index, JsonUnit unit) { throw new Exception($"{this.UnitType.ToString()}类型尚未支持设置索引对象"); }

        /// <summary>
        /// 获取或设置数组对象
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public JsonUnit this[int index] { get { return OnGetArrayItem(index); } set { this.OnSetArrayItem(index, value); } }

        /// <summary>
        /// 获取子对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected virtual JsonUnit OnGetChildItem(string key) { throw new Exception($"{this.UnitType.ToString()}类型尚未支持获取索引子对象"); }

        /// <summary>
        /// 设置子对象
        /// </summary>
        /// <param name="key"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        protected virtual void OnSetChildItem(string key, JsonUnit unit) { throw new Exception($"{this.UnitType.ToString()}类型尚未支持设置索引子对象"); }

        /// <summary>
        /// 获取或设置子对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public JsonUnit this[string key] { get { return OnGetChildItem(key); } set { this.OnSetChildItem(key, value); } }

        /// <summary>
        /// 获取子对象键值集合
        /// </summary>
        /// <returns></returns>
        protected virtual ICollection<string> OnGetKeys() { throw new Exception($"{this.UnitType.ToString()}类型尚未支持获取子对象键值集合"); }

        /// <summary>
        /// 获取子对象键值集合
        /// </summary>
        public ICollection<string> Keys { get { return OnGetKeys(); } }

        /// <summary>
        /// 获取索引对象数量集合
        /// </summary>
        /// <returns></returns>
        protected virtual int OnGetItemCount() { throw new Exception($"{this.UnitType.ToString()}类型尚未支持索引对象数量"); }

        /// <summary>
        /// 获取索引对象数量集合
        /// </summary>
        public int Count { get { return OnGetItemCount(); } }

        #endregion

        #region [=====快捷操作入口=====]

        /// <summary>
        /// 获取一个对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public JsonObject Object(string key) {
            var res = OnGetChildItem(key);
            if (res == null) {
                var obj = new JsonObject(this);
                OnSetChildItem(key, obj);
                return obj;
            } else {
                return (JsonObject)res;
            }
        }

        /// <summary>
        /// 获取一个对象
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public JsonObject Object(int index) {
            var res = OnGetArrayItem(index);
            if (res == null) {
                var obj = new JsonObject(this);
                OnSetArrayItem(index, obj);
                return obj;
            } else {
                return (JsonObject)res;
            }
        }

        /// <summary>
        /// 获取一个数组
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public JsonArray Array(string key) {
            var res = OnGetChildItem(key);
            if (res == null) {
                var obj = new JsonArray(this);
                OnSetChildItem(key, obj);
                return obj;
            } else {
                return (JsonArray)res;
            }
        }

        /// <summary>
        /// 获取一个数组
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public JsonArray Array(int index) {
            var res = OnGetArrayItem(index);
            if (res == null) {
                var obj = new JsonArray(this);
                OnSetArrayItem(index, obj);
                return obj;
            } else {
                return (JsonArray)res;
            }
        }

        /// <summary>
        /// 获取一个字符串
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public JsonString String(string key) {
            var res = OnGetChildItem(key);
            if (res == null) {
                var obj = new JsonString(this);
                OnSetChildItem(key, obj);
                return obj;
            } else {
                return (JsonString)res;
            }
        }

        /// <summary>
        /// 获取一个字符串
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public JsonString String(int index) {
            var res = OnGetArrayItem(index);
            if (res == null) {
                var obj = new JsonString(this);
                OnSetArrayItem(index, obj);
                return obj;
            } else {
                return (JsonString)res;
            }
        }

        /// <summary>
        /// 获取一个字符串
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public JsonBoolean Bool(string key) {
            var res = OnGetChildItem(key);
            if (res == null) {
                var obj = new JsonBoolean(this);
                OnSetChildItem(key, obj);
                return obj;
            } else {
                return (JsonBoolean)res;
            }
        }

        /// <summary>
        /// 获取一个字符串
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public JsonBoolean Bool(int index) {
            var res = OnGetArrayItem(index);
            if (res == null) {
                var obj = new JsonBoolean(this);
                OnSetArrayItem(index, obj);
                return obj;
            } else {
                return (JsonBoolean)res;
            }
        }

        /// <summary>
        /// 获取一个数值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public JsonNumber Number(string key) {
            var res = OnGetChildItem(key);
            if (res == null) {
                var obj = new JsonNumber(this);
                OnSetChildItem(key, obj);
                return obj;
            } else {
                return (JsonNumber)res;
            }
        }

        /// <summary>
        /// 获取一个数值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public JsonNumber Number(int index) {
            var res = OnGetArrayItem(index);
            if (res == null) {
                var obj = new JsonNumber(this);
                OnSetArrayItem(index, obj);
                return obj;
            } else {
                return (JsonNumber)res;
            }
        }

        #endregion

        /// <summary>
        /// 获取Json字符串
        /// </summary>
        /// <returns></returns>
        protected override string OnParseString() {
            return OnGetJsonString();
        }

    }
}
