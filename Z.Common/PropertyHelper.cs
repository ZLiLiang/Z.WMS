using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Z.Common
{
    public class PropertyHelper
    {
        public static PropertyInfo[] GetTypeProperties<T>(string clos)
        {
            Type type = typeof(T);
            //将列名字符串转换成List,转换成小写
            List<string> listCols = clos.GetStrList(',', true);
            //获取所有属性
            PropertyInfo[] properties = type.GetProperties();
            if (listCols != null && listCols.Count > 0)
            {
                properties = properties.Where(p => listCols.Contains(p.GetColName().ToLower())).ToArray();
            }
            return properties;
        }
    }
}
