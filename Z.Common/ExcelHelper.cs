using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Common.CustomAttributes;

namespace Z.Common
{
    public static class ExcelHelper
    {
        /// <summary>
        /// 生成excel文件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="data"></param>
        public static void ToExcel<T>(string fileName, List<T> data)
        {
            var res = GetExcelList(data);
            MiniExcel.SaveAs(
                path: fileName,
                value: res,
                printHeader: true,
                sheetName: "Sheet1",
                excelType: ExcelType.UNKNOWN,
                configuration: null,
                overwriteFile: true);
        }

        /// <summary>
        /// 设定excel格式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        private static IEnumerable<Dictionary<string, object>> GetExcelList<T>(List<T> data)
        {
            foreach (var item in data)
            {
                var excelColumn = new Dictionary<string, object>();
                var type = item.GetType();
                var properties = type.GetProperties();
                foreach (var property in properties)
                {
                    var attr = property.GetCustomAttributes(typeof(AliasAttribute), false).FirstOrDefault() as AliasAttribute;
                    if (attr == null)
                    {
                        continue;
                    }
                    excelColumn.Add(attr.ColumnName, property.GetValue(item));
                }
                yield return excelColumn;
            }
        }
    }
}
