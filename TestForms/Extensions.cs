using System;
using System.Globalization;
using System.Windows.Forms;

namespace TestForms
{
    public static class Extensions
    {
        public static string ToLocalizedText(this OperationId id)
        {
            switch (id)
            {
                case OperationId.Sum:
                    return "+";
                case OperationId.Divide:
                    return "/";
                case OperationId.Subtract:
                    return "-";
                case OperationId.Multiply:
                    return "*";
            }

            throw new ArgumentOutOfRangeException($"No translation for {id} operation");
        }

        public static bool TryParseInt(this TextBox textBox, out int result) =>
            int.TryParse(textBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out result);
        
    }
}
