using System;

namespace Z.Common.CustomAttributes
{
    /// <summary>
    /// 列名映射特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string ColumnName { get; protected set; }

        public ColumnAttribute(string colName)
        {
            ColumnName = colName;
        }
    }
}
