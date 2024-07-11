using System;
using CalcEngine;

public partial class _Default : System.Web.UI.Page, IView
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Presenter presenter = new Presenter(this);
    }




    #region IView
    public double firstnumber
    {
        get
        {
            return Convert.ToDouble(TextBox1.Text);
        }
    }

    public double secondnumber
    {
        get
        {
            return Convert.ToDouble(TextBox2.Text);
        }
    }

    public event EventHandler<EventArgs> SumSetted;
    public event MinusingEventHandler Minusing;
    public event MultiplyingEventHandler Multiplying;
    public event DividingEventHandler Dividing;

    public void GetSum(double MySum)
    {
        TextBox3.Text = MySum.ToString();
    }
    #endregion
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (SumSetted != null)
            SumSetted(this, EventArgs.Empty);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Minusing != null)
            Minusing();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Multiplying != null)
            Multiplying();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (Dividing != null)
            Dividing();
    }
    public void GetMinus(double Minus)
    {
        TextBox3.Text = Minus.ToString();
    }

    public void GetMultiply(double Multiply)
    {
        TextBox3.Text = Multiply.ToString();
    }

    public void GetDivide(double Divide)
    {
        TextBox3.Text = Divide.ToString();
    }
}