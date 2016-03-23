using System;
using TrSQL.Define;
using System.Data;
using System.Data.Common;
using TrSQL.Items;

namespace TrSQL
{
    public abstract class AbstractDatabase : IDatabase
    {
        #region 字段
        private DbProviderFactory _dbProvider = null;
        #endregion

        #region 属性
        /// <summary>
        /// 获取当前数据库的类型
        /// </summary>
        public abstract DatabaseType DatabaseType { get; }

        /// <summary>
        /// 获取当前数据库提供者名称
        /// </summary>
        public string ProviderName { get { return this._dbProvider.GetType().ToString(); } }

        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnectionString { get; private set; } = null;
        #endregion

        #region 方法
        /// <summary>
        /// 获取当前数据库对应的数据参数工厂
        /// </summary>
        public abstract Items.DataParameter DataParameterFactory();

        /// <summary>
        /// 数据库事务工厂
        /// </summary>
        /// <returns>数据库事务</returns>
        public abstract IDbConnection TransactionFactory();

        /// <summary>
        /// 数据库命令工厂
        /// </summary>
        /// <param name="commandText">命令字符串</param>
        /// <param name="parameters">参数集合</param>
        /// <returns></returns>
        public abstract IDbCommand CommandFactory(string commandText, params DataParameter[] parameters);
        #endregion


    }
}
