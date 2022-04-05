// ***********************************************************************
// Assembly         : DescentCalculate
// Author           : Claude
// Created          : 03-18-2022
//
// Last Modified By : Claude
// Last Modified On : 03-18-2022
// ***********************************************************************
// <copyright file="RegularExpression.cs" company="Mesquite Information Technologies LLC">
//     2022
// </copyright>
// <summary>Test Regular Expression</summary>
// ***********************************************************************
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
