using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

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

        #region 方法


        /// <summary>
        /// 获取SQL语句字符串
        /// </summary>
        /// <returns></returns>
        public abstract string GetSQLText();

        /// <summary>
        /// 转换为数据库命令
        /// </summary>
        /// <returns></returns>
        public abstract IDbCommand ToDbCommand();
        #endregion
    }
}
