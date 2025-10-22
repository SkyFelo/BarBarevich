using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Classes
{
    internal class InputHelper
    {
        /// <summary>
        /// Метод для запрета ввода любых символов, кроме цифр.
        /// </summary>
        /// <param name="sender">Источник TextBox.</param>
        /// <param name="e">Аргументы события KeyPress.</param>
        public static void RestrictToDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Метод для запрета ввода любых цифр.
        /// </summary>
        /// <param name="sender">Источник  TextBox.</param>
        /// <param name="e">Аргументы события KeyPress.</param>
        public static void RestrictToNonDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
