using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z.Common.CustomAttributes
{
    /// <summary>
    /// 列名映射特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class AliasAttribute : Attribute
    {
        public string ColumnName { get; protected set; }

        public AliasAttribute(string colName)
        {
            ColumnName = colName;
        }
    }
}
