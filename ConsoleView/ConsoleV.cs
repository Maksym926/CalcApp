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
            firstnumberC = Convert.ToDouble(Console.ReadLine());
            secondnumberC = Convert.ToDouble(Console.ReadLine());
        }

        public double firstnumber => firstnumberC;

        public double secondnumber => secondnumberC;

        public event EventHandler<EventArgs> SumSetted;

        public void GetSum(double MySum)
        {
            Console.WriteLine(MySum);
            
        }
        public void KeyPress()
        {                 

            var keyInfo = Console.ReadKey(true);
            while (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
            }
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    
                    if (SumSetted != null)
                        SumSetted(this, EventArgs.Empty);
                        
                    break;
                
            }
        }
    }
}
