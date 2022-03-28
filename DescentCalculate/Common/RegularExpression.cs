using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DescentCalculate.Common
{
    public static class RegularExpression
    {
        public static bool CheckDecimal(string decimalstring)
        {
            Regex rgx = new Regex("[0-9]+");
            return rgx.IsMatch(decimalstring);
        }
    }
}
