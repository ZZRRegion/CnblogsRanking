using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnblogsRanking
{
    public static class StExtend
    {
        /// <summary>
        /// 取出括号
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string RepleaceBrackets(this string @this)
        {
            if (string.IsNullOrEmpty(@this))
                return @this;
            return @this.Replace("(", string.Empty).Replace(")", string.Empty).Replace("（", string.Empty).Replace("）", string.Empty);
        }
        public static string ToDisplay<T>(this IEnumerable<T> @this, string splits = ",")
        {
            StringBuilder sb = new StringBuilder();
            foreach(T item in @this)
            {
                if(sb.Length > 0)
                {
                    sb.Append(splits);
                }
                sb.Append(item);
            }
            return sb.ToString();
        }

    }
}
