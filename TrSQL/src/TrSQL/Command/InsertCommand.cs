using System;
using System.Collections.Generic;
using System.Data;

namespace TrSQL.Command
{
    public class InsertCommand : AbstractSQL
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
        /// <param name="database"></param>
        /// <param name="tableName"></param>
        internal InsertCommand(AbstractDatabase database, String tableName) : base(database)
        {
            this._insertFields = new List<Items.DataParameter>();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 获取SQL语句字符串
        /// </summary>
        /// <returns></returns>
        public override string GetSQLText()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 转换为数据库命令
        /// </summary>
        /// <returns></returns>
        public override IDbCommand ToDbCommand()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
