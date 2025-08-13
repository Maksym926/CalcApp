using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcEngine;

namespace ConsoleView 
{
    public class ConsoleV : IView
    {
        double firstnumberC;
        double secondnumberC;
        public ConsoleV()
        {
            Presenter presenter = new Presenter(this);
            Console.WriteLine("Calc");
            while(true)
            {
                SetNumbers();
                KeyPress();
                if (!IsContinue())
                {
                    break;
                }

            }

        }

        public bool IsContinue()
        {
            Console.WriteLine("Press Y to continue or press N to finish");
            string check = Console.ReadLine();
            if(check == "N") {
                return false;
            }
            return true;
        }

        private void SetNumbers()
        {
            try{
                Console.WriteLine("Enter first number");
                firstnumberC = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second  number");
                secondnumberC = Convert.ToDouble(Console.ReadLine());
            }catch (FormatException e) {
                Console.WriteLine(e.Message);
            }
            
        }

        public double firstnumber => firstnumberC;

        public double secondnumber => secondnumberC;

        public event EventHandler<EventArgs> SumSetted;
        public event MinusingEventHandler Minusing;
        public event MultiplyingEventHandler Multiplying;
        public event DividingEventHandler Dividing;

        public void GetSum(double MySum)
        {
            Console.WriteLine(MySum);
            
        }
        public void KeyPress()
        {
            Console.WriteLine("Enter the operation sign: +, -, *, /");

            var keyInfo = Console.ReadKey(true);
            while (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
            }
            
            switch (keyInfo.Key)
            {
               
                case ConsoleKey.OemPlus:
                    
                    if (SumSetted != null)
                        SumSetted(this, EventArgs.Empty);
                        
                    break;
                case ConsoleKey.OemMinus:
                    Minusing?.Invoke();

                    break;
                case ConsoleKey.Multiply:
                    Multiplying?.Invoke();
                    break;
                case ConsoleKey.Divide:
                    Dividing.Invoke();
                    break;
                default:
                    Console.WriteLine("Incorrect sign");
                    break;
            }
        }

        public void GetMinus(double Minus)
        {
            Console.WriteLine(Minus);
        }

        public void GetMultiply(double Multiply)
        {
            Console.WriteLine(Multiply);
        }

        public void GetDivide(double Divide)
        {
            Console.WriteLine(Divide);
        }
    }
}
