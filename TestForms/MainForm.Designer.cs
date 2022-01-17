namespace TestForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.opComboBox = new System.Windows.Forms.ComboBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.secondOperandTextBox = new System.Windows.Forms.TextBox();
            this.firstOperandTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opComboBox
            // 
            this.opComboBox.FormattingEnabled = true;
            this.opComboBox.Location = new System.Drawing.Point(187, 236);
            this.opComboBox.Name = "opComboBox";
            this.opComboBox.Size = new System.Drawing.Size(53, 21);
            this.opComboBox.TabIndex = 0;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(165, 273);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 1;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.OnCalculateBtnClick);
            // 
            // secondOperandTextBox
            // 
            this.secondOperandTextBox.Location = new System.Drawing.Point(246, 237);
            this.secondOperandTextBox.Name = "secondOperandTextBox";
            this.secondOperandTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondOperandTextBox.TabIndex = 2;
            // 
            // firstOperandTextBox
            // 
            this.firstOperandTextBox.Location = new System.Drawing.Point(81, 237);
            this.firstOperandTextBox.Name = "firstOperandTextBox";
            this.firstOperandTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstOperandTextBox.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(176, 171);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(64, 25);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 338);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.firstOperandTextBox);
            this.Controls.Add(this.secondOperandTextBox);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.opComboBox);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox opComboBox;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.TextBox secondOperandTextBox;
        private System.Windows.Forms.TextBox firstOperandTextBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

