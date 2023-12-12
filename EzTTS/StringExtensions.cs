using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzTTS
{
    public static class StringExtensions
    {
        public static string Truncate(this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= 20 ? value : value.Substring(0, 20);

        }
    }
}
