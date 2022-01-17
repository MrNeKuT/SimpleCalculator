using System;
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

            foreach (OperationId op in Enum.GetValues(typeof(OperationId)))
            {
                opComboBox.Items.Add(op.ToLocalizedText());
            }
        }

        private void OnCalculateBtnClick(object sender, EventArgs e)
        {
            var operation = OperationId.Sum;
            var op1 = 0;
            var op2 = 0;

            if (!TryParseOperationCombobox(ref operation))
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

            var result = calculator.Calculate(op1, op2, operation);
            resultLabel.Text = $"{op1}{operation.ToLocalizedText()}{op2}={result}";
        }

        private bool TryParseOperationCombobox(ref OperationId operationId)
        {
            if (Enum.IsDefined(typeof(OperationId), opComboBox.SelectedIndex))
            {
                operationId = (OperationId)opComboBox.SelectedIndex;
                return true;
            }

            return false;
        }
    }
}
