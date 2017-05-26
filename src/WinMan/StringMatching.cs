using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    static class StringMatching
    {
        public static bool IsMatch(string pattern, StringPatternType patternType, bool ignoreCase,  string value)
        {
            if (pattern == null) return true;
            if (value == null) return true;
            switch (patternType)
            {
                case StringPatternType.Exact:
                    if (ignoreCase)
                    {
                        pattern = pattern.ToLower(CultureInfo.CurrentUICulture);
                        value = pattern.ToLower(CultureInfo.CurrentUICulture);
                    }
                    return string.Equals(pattern, value);
                case StringPatternType.Wildcard:
                    var regexPattern = "^" + Regex.Escape(pattern).Replace(@"\?", ".?").Replace(@"\*", ".*") + "$";
                    var wildCardPptions = RegexOptions.Singleline;
                    if (ignoreCase) wildCardPptions |= RegexOptions.IgnoreCase;
                    return Regex.IsMatch(value, regexPattern, wildCardPptions);
                case StringPatternType.Regex:
                    var regexOptions = RegexOptions.Singleline;
                    if (ignoreCase) regexOptions |= RegexOptions.IgnoreCase;
                    return Regex.IsMatch(value, pattern, regexOptions);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
