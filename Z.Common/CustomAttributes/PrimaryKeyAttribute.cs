using System;

namespace Z.Common.CustomAttributes
{
    /// <summary>
    /// 主键特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class PrimaryKeyAttribute : Attribute
    {
        public string PrimaryKey { get; protected set; }
        public bool autoIncrement = false;
        public PrimaryKeyAttribute(string priName)
        {
            this.PrimaryKey = priName;
        }

    }
}
