namespace Word
{
    partial class IndentDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelIndent = new Label();
            numericUpDownIndent = new NumericUpDown();
            buttonOK = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIndent).BeginInit();
            SuspendLayout();
            // 
            // labelIndent
            // 
            labelIndent.AutoSize = true;
            labelIndent.Location = new Point(12, 20);
            labelIndent.Name = "labelIndent";
            labelIndent.Size = new Size(222, 15);
            labelIndent.TabIndex = 0;
            labelIndent.Text = "Введите значение отступа (в пикселях):";
            // 
            // numericUpDownIndent
            // 
            numericUpDownIndent.Location = new Point(12, 50);
            numericUpDownIndent.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownIndent.Name = "numericUpDownIndent";
            numericUpDownIndent.Size = new Size(260, 23);
            numericUpDownIndent.TabIndex = 1;
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(130, 90);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(70, 30);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(205, 90);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(70, 30);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // IndentDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 135);
            Controls.Add(labelIndent);
            Controls.Add(numericUpDownIndent);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            MaximizeBox = false;
            MaximumSize = new Size(306, 174);
            MinimizeBox = false;
            MinimumSize = new Size(306, 174);
            Name = "IndentDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Пользовательский отступ";
            Load += IndentDialog_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownIndent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIndent;
        private NumericUpDown numericUpDownIndent;
        private Button buttonOK;
        private Button buttonCancel;
    }
}