using System.Collections.Generic;
using System.Data;
using System;

namespace TrSQL.Command
{
    /// <summary>
    /// 抽象SQL语句
    /// </summary>
    public abstract class AbstractSQL : ISQL
    {
        #region 字段
        /// <summary>
        /// 数据库
        /// </summary>
        protected AbstractDatabase _database;

        /// <summary>
        /// 基础参数组
        /// </summary>
        protected List<Items.DataParameter> _parameters;

        /// <summary>
        /// 参数索引
        /// </summary>
        private short _parameterIndex;
        #endregion

        #region 属性
        /// <summary>
        /// SQL语句类型
        /// </summary>
        public abstract SqlDbType SQLType { get; }
        #endregion

        #region 构造方法
        protected AbstractSQL(AbstractDatabase database)
        {
            this._database = database;
        }
        #endregion

        #region 共有方法
        /// <summary>
        /// 创建数据参数
        /// </summary>
        /// <param name="columnName">属性名</param>
        /// <param name="dataType">属性类型</param>
        /// <param name="value">属性值</param>
        /// <returns>数据参数</returns>
        public Items.DataParameter CreateDataParameter(string columnName,Define.DataType dataType, object value)
        {
            return Items.DataParameter.Create(this._database, columnName, this.GetNewParameterIndex(), value, dataType);
        }

        /// <summary>
        /// 获取SQL语句字符串
        /// </summary>
        /// <returns></returns>
        public abstract string GetSQLText();

        /// <summary>
        /// 转换为数据库命令
        /// </summary>
        /// <returns></returns>
        public IDbCommand ToDbCommand()
        {
            return this._database.CommandFactory(this.GetSQLText(), this._parameters.ToArray());
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 获取新参数的索引
        /// </summary>
        /// <returns></returns>
        private string GetNewParameterIndex()
        {
            return Convert.ToString(this._parameterIndex++, 16);
        }
        #endregion
    }
}
