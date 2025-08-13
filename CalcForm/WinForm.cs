using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcEngine;


namespace CalcForm
{
    public partial class WinForm : Form, IView
    {
        public WinForm()
        {
            InitializeComponent();
        }

        public double firstnumber => Convert.ToDouble(numericTextBox1.Text);
        public double secondnumber => Convert.ToDouble(numericTextBox2.Text);

        public event EventHandler<EventArgs> SumSetted;
        public event MinusingEventHandler Minusing;
        public event MultiplyingEventHandler Multiplying;
        public event DividingEventHandler Dividing;

        public void GetSum(double MySum)
        {


            OutputTextBox.Text = MySum.ToString();
        }
        public void GetMinus(double Minus)
        {
            OutputTextBox.Text = Minus.ToString();
        }

        public void GetMultiply(double Multiply)
        {
            OutputTextBox.Text = Multiply.ToString();
        }

        public void GetDivide(double Divide)
        {
            OutputTextBox.Text = Divide.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            LabelSymbol.Text = "+";

            try
            {
                if (SumSetted != null)
                    SumSetted(this, EventArgs.Empty);
            }
            catch (FormatException)
            {
                OutputTextBox.Text = "Введіть число";
            }
        }
        private void MinusButton_Click(object sender, EventArgs e)
        {
            LabelSymbol.Text = "-";
            
            try
            {
                Minusing?.Invoke();
            }
            catch (FormatException)
            {
                OutputTextBox.Text = "Введіть число";
            }
        }
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            LabelSymbol.Text = "*";
            
            try
            {
                Multiplying?.Invoke();
            }
            catch (FormatException)
            {
                OutputTextBox.Text = "Введіть число";
            }
        }
        private void DivideButton_Click(object sender, EventArgs e)
        {
            LabelSymbol.Text = "/";
            try
            {
                Dividing?.Invoke();
            }
            catch (FormatException)
            {
                OutputTextBox.Text = "Введіть число";
            }
        }

        private void WinForm_Load(object sender, EventArgs e)
        {

        }

        private void WinForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
