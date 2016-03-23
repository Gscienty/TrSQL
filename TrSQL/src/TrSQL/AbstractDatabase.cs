using TrSQL.Define;
using System.Data;
using System.Data.Common;
namespace TrSQL
{
    public abstract class AbstractDatabase
    {
        #region 字段
        private string _connectString = null;
        private DbProviderFactory _dbProvider = null;
        #endregion

        #region 属性
        /// <summary>
        /// 获取当前数据库的类型
        /// </summary>
        public abstract DatabaseType DatabaseType { get; }

        #endregion
    }
}
