using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEngine
{
    public delegate void MinusingEventHandler();
    public delegate void MultiplyingEventHandler();
    public delegate void DividingEventHandler();
    public interface IView
    {
        double firstnumber { get; }
        double secondnumber { get; }

        //Sum
        void GetSum(double MySum);

        event EventHandler<EventArgs> SumSetted;

        //Minus
        void GetMinus(double Minus);

        event MinusingEventHandler Minusing;

        //Multiply
        void GetMultiply(double Multiply);
        event MultiplyingEventHandler Multiplying;
        //Divide
        void GetDivide(double Divide);
        event DividingEventHandler Dividing;





    }
}
