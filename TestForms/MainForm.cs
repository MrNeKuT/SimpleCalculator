using System;
using System.Linq;
using System.Windows.Forms;

namespace TestForms
{
    public partial class MainForm : Form
    {
        private Calculator _calculator;

        public MainForm()
        {
            InitializeComponent();
            InitCalculator();
            InitOperationsCombobox();
        }

        private void InitCalculator()
        {
            _calculator = new Calculator()
                .AddOperation(new SumOperation())
                .AddOperation(new SubtractOperation());
        }

        private void InitOperationsCombobox()
        {
            opComboBox.Items.Clear();
            opComboBox.Items.AddRange(_calculator.GetOperationsSigns().ToArray());
        }

        private void OnCalculateBtnClick(object sender, EventArgs e)
        {
            var operationId = opComboBox.SelectedIndex;
            var op1 = 0;
            var op2 = 0;

            if (!_calculator.ValidateOperationId(operationId))
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

            var result = _calculator.Calculate(op1, op2, operationId);
            resultLabel.Text = $"{op1}{_calculator.GetOperationSign(operationId)}{op2}={result}";
        }
    }
}
