using System;
using System.Linq;
using System.Windows.Forms;

namespace TestForms
{
    public partial class MainForm : Form
    {
        private readonly Calculator calculator = new Calculator();

        public MainForm()
        {
            InitializeComponent();
            InitOperationsCombobox();
        }

        private void InitOperationsCombobox()
        {
            opComboBox.Items.Clear();
            opComboBox.Items.AddRange(calculator.GetOperationsSigns().ToArray());
        }

        private void OnCalculateBtnClick(object sender, EventArgs e)
        {
            var operationId = opComboBox.SelectedIndex;
            var op1 = 0;
            var op2 = 0;

            if (!calculator.ValidateOperationId(operationId))
            {
                resultLabel.Text = "Выберите операцию!";
                return;
            }

            if (!firstOperandTextBox.TryParseInt(out op1))
            {
                resultLabel.Text = "Неверный формат первого операнда";
                return;
            }

            if (!secondOperandTextBox.TryParseInt(out op2))
            {
                resultLabel.Text = "Неверный формат второго операнда";
                return;
            }

            var result = calculator.Calculate(op1, op2, operationId);
            resultLabel.Text = $"{op1}{calculator.GetOperationSign(operationId)}{op2}={result}";
        }
    }
}
