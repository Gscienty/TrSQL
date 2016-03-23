using System.Data;

namespace TrSQL.Command
{
    public interface ISQL
    {
        /// <summary>
        /// SQL语句类型
        /// </summary>
        SqlDbType SQLType { get; }

        /// <summary>
        /// 获取SQL语句内容
        /// </summary>
        /// <returns>SQL语句内容</returns>
        string GetSQLText();

        /// <summary>
        /// 输出数据库命令
        /// </summary>
        /// <returns></returns>
        IDbCommand ToDbCommand();
    }
}
