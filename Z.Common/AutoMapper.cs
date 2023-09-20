using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z.Common
{
    public static class AutoMapper
    {
        /// <summary>
        /// 将当前对象的值映射到目标实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        public static T Mapper<T>(this object src)
        {
            var srcType = src.GetType();
            var destType = typeof(T);
            var destInstance = Activator.CreateInstance(destType);
            var srcProperties = srcType.GetProperties();

            foreach (var item in srcProperties)
            {
                var srcValue = item.GetValue(src);
                destType.GetProperty(item.Name).SetValue(destInstance, srcValue);
            }

            return (T)destInstance;
        }
    }
}
