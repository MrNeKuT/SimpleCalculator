using System;
using System.Globalization;
using System.Windows.Forms;

namespace TestForms
{
    public static class Extensions
    {
        public static bool TryParseInt(this TextBox textBox, out int result) =>
            int.TryParse(textBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out result);
    }
}
