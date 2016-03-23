using System.Data;
using System;

namespace TrSQL.Items
{
    public class DataParameter
    {
        #region 字段
        private IDataParameter _parameter;
        #endregion

        #region 属性
        /// <summary>
        /// 获取列名
        /// </summary>
        public string ColumnName { get { return _parameter.SourceColumn; } }

        /// <summary>
        /// 获取参数名
        /// </summary>
        public string ParameterName { get { return _parameter.ParameterName; } }

        /// <summary>
        /// 获取参数值
        /// </summary>
        public object ParameterObject { get { return _parameter.Value; } }
        #endregion

        #region 构造方法
        /// <summary>
        /// 初始化SQL语句参数类
        /// </summary>
        /// <param name="database">数据库</param>
        /// <param name="columnName">字段名</param>
        /// <param name="dataParameterFactory">参数构造工厂</param>
        /// <param name="parameterIndex">参数索引</param>
        /// <param name="value">参数值</param>
        private DataParameter(
            AbstractDatabase database,
            string columnName,
            string parameterIndex,
            object value)
        {
            _parameter = database.DataParameterFactory();
            _parameter.SourceColumn = columnName;
            if(value == null)
            {
                _parameter.Value = DBNull.Value;
            }
            else if(value is DateTime)
            {
                _parameter.Value = (value as DateTime?).Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                _parameter.Value = value;
            }
        }
        #endregion

        #region 工厂方法
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="columnName"></param>
        /// <param name="parameterIndex"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DataParameter Create(AbstractDatabase database, string columnName, string parameterIndex, object value, Define.DataType dataType)
        {
            DataParameter param = new DataParameter(database, columnName, parameterIndex, value);
            param._parameter.DbType = DataParameter.GetDbType(dataType);
            return param;
        }
        #endregion



        #region 私有方法
        private static DbType GetDbType(Define.DataType dataType)
        {
            return (DbType)(int)dataType;
        }

        private static Define.DataType GetDataType(DbType dbType)
        {
            return (Define.DataType)(int)dbType;
        }
        #endregion
    }
}
