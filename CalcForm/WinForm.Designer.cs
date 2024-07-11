

using System;

namespace CalcForm
{
    partial class WinForm 
    {
    



        private System.Windows.Forms.TextBox numericTextBox1;

        private System.Windows.Forms.Label LabelSymbol;

        private System.Windows.Forms.TextBox numericTextBox2;

        private System.Windows.Forms.Label LabelTotal;

        private System.Windows.Forms.TextBox OutputTextBox;

        private System.Windows.Forms.Button AddButton;

        private System.Windows.Forms.Button MinusButton;

        private System.Windows.Forms.Button MultiplyButton;

        private System.Windows.Forms.Button DivideButton;


        private void InitializeComponent()
        {
            this.numericTextBox1 = new System.Windows.Forms.TextBox();
            this.LabelSymbol = new System.Windows.Forms.Label();
            this.numericTextBox2 = new System.Windows.Forms.TextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(0, 0);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numericTextBox1.TabIndex = 0;
            // 
            // LabelSymbol
            // 
            this.LabelSymbol.Location = new System.Drawing.Point(0, 30);
            this.LabelSymbol.Name = "LabelSymbol";
            this.LabelSymbol.Size = new System.Drawing.Size(100, 23);
            this.LabelSymbol.TabIndex = 1;
            // 
            // numericTextBox2
            // 
            this.numericTextBox2.Location = new System.Drawing.Point(0, 60);
            this.numericTextBox2.Name = "numericTextBox2";
            this.numericTextBox2.Size = new System.Drawing.Size(100, 20);
            this.numericTextBox2.TabIndex = 2;
            // 
            // LabelTotal
            // 
            this.LabelTotal.Location = new System.Drawing.Point(0, 90);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(100, 23);
            this.LabelTotal.TabIndex = 3;
            this.LabelTotal.Text = "=";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(0, 120);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputTextBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(120, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "+";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(120, 30);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(75, 23);
            this.MinusButton.TabIndex = 6;
            this.MinusButton.Text = "-";
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(120, 60);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(120, 90);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 23);
            this.DivideButton.TabIndex = 8;
            this.DivideButton.Text = "/";
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // WinForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.LabelSymbol);
            this.Controls.Add(this.numericTextBox2);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DivideButton);
            this.Name = "WinForm";
            this.Load += new System.EventHandler(this.WinForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
