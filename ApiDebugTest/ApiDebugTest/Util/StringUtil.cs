using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDebug.Util
{
    /**
     * 字符串操作扩展类
     */ 
    public static class StringUtil
    {
        public static string ReplaceAll(this string source, string oldValue, string newValue)
        {
            if (source.Contains(oldValue))
            {
                source = source.Replace(oldValue, newValue);
            }
            if (source.Contains(oldValue))
            {
                return ReplaceAll(source, oldValue, newValue);
            }
            return source;
        }
    }
}