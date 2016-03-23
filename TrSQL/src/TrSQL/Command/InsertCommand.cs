using System;
using System.Collections.Generic;
using System.Data;

namespace TrSQL.Command
{
    public sealed class InsertCommand : AbstractSQL
    {
        #region 字段
        private List<Items.DataParameter> _insertFields;
        #endregion

        #region 属性
        /// <summary>
        /// SQL语句类型
        /// </summary>
        public override SqlDbType SQLType
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 初始化插入语句类
        /// </summary>
        /// <param name="database">数据库</param>
        /// <param name="tableName">数据表名</param>
        internal InsertCommand(AbstractDatabase database, String tableName) : base(database)
        {
            this._insertFields = new List<Items.DataParameter>();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 设置添加参数
        /// </summary>
        /// <param name="columnName">属性名</param>
        /// <param name="dataType">属性类型</param>
        /// <param name="value">属性值</param>
        /// <returns></returns>
        public InsertCommand Set(string columnName, Define.DataType dataType, object value)
        {
            Items.DataParameter parameter = this.CreateDataParameter(columnName, DataTable, value);
            this._insertFields.Add(parameter);
            this._parameters.Add(parameter);

            return this;
        }
        /// <summary>
        /// 获取SQL语句字符串
        /// </summary>
        /// <returns></returns>
        public override string GetSQLText()
        {
            return "";
        }
        #endregion
    }
}
