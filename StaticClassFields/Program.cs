using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassFields
{
    class Program
    {
        static void Main()
        {
            StaticFields staticFields = new StaticFields();
            
            Console.WriteLine(staticFields.Add(43, 12));

            StaticFields staticFields1 = new StaticFields();
            Console.WriteLine(staticFields1.Myltiply());

            
            StaticMethods staticMethods = new StaticMethods();
            Console.WriteLine(StaticMethods.Counter);


            Console.ReadLine();
        }
    }
    class StaticFields
    {
        public static double Sum;

        public double Add(double number1, double number2)
        {
            return Sum = number1 + number2;
        }
        public double Myltiply()
        {
            return Sum * 2;
        }
    }
    class StaticMethods
    {
        public StaticMethods()
        {
            counter++;
        }

        private static int counter;

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }



    }
}
