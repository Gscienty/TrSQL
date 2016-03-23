namespace TrSQL.Define
{
    /// <summary>
    /// SQL语句类型
    /// </summary>
    internal enum SQLType : byte
    {
        /// <summary>
        /// 查询语句
        /// </summary>
        Query = 0,
        
        /// <summary>
        /// 插入语句
        /// </summary>
        Insert = 1,

        /// <summary>
        /// 更新语句
        /// </summary>
        Update = 2,

        /// <summary>
        /// 删除语句
        /// </summary>
        Delete = 3
    }
}
