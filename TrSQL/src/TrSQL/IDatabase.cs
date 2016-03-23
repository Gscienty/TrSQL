using System;
using TrSQL.Define;
using System.Data;
using System.Data.Common;

namespace TrSQL
{
    /// <summary>
    /// 数据库接口
    /// </summary>
    public interface IDatabase
    {
        #region 属性
        /// <summary>
        /// 获取当前数据库类型
        /// </summary>
        DatabaseType DatabaseType { get; }

        /// <summary>
        /// 获取当前数据库提供者名称
        /// </summary>
        string ProviderName { get; }

        /// <summary>
        /// 获取当前数据库连接字符串
        /// </summary>
        string ConnectionString { get; }
        #endregion

        #region 方法
        /// <summary>
        /// 数据库参数工厂
        /// </summary>
        /// <returns>数据库参数</returns>
        IDataParameter DataParameterFactory();

        /// <summary>
        /// 数据库命令工厂
        /// </summary>
        /// <returns>数据库命令</returns>
        IDbCommand CommandFactory();

        /// <summary>
        /// 数据库事务工厂
        /// </summary>
        /// <returns>数据库事务</returns>
        IDbConnection TransactionFactory();
        #endregion


    }
}
