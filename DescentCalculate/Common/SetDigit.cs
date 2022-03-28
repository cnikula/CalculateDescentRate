// ***********************************************************************
// Assembly         : DescentCalculate
// Author           : Claude
// Created          : 03-18-2022
//
// Last Modified By : Claude
// Last Modified On : 03-18-2022
// ***********************************************************************
// <copyright file="SetDigit.cs" company="Mesquite Information Technologies LLC">
//     2022
// </copyright>
// <summary>
// Helpper Class dealing with Microsoft Key Enum
// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=windowsdesktop-6.0
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescentCalculate.Common
{
    public static class SetDigit
    {
        /// <summary>Sets the text box character set. Only allow numbers, period and backspaces</summary>
        /// <param name="e">The <see cref="KeyPressEventArgs" /> instance containing the event data.</param>
        /// <returns>
        ///   <c>true</c> if e.Handled, <c>false</c> otherwise true.</returns>
        public static bool SetTextBoxCharSet(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            e.Handled = false;
            
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 190)
            {
                e.Handled = true;
                
            }

            return e.Handled;
        }
    }
}
