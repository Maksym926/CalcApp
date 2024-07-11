using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler1
{
    public delegate void MyDalagate(string Year);
    class EventHandlerTest
    {
        static void Main()
        {
            Console.WriteLine("How old are you");
            string Text = Console.ReadLine(); 
            MyDalagate myDalagate = new MyDalagate(HowOld);
            myDalagate += HowOld;
            myDalagate.Invoke(Text);
            
            Action action = new Action(Hello);
            action += Hello;
            action.Invoke();

            Person person = new Person();
            person.ICan += Person_ICan;
            person.Frase = "OK";
            person.ICanNot += Person_ICanNot;
            person.Comparison(50);
            person.Comparison(4320);
            

            Console.ReadLine();

        }

        private static void Person_ICanNot(object sender, EventArgs e)
        {
            if(sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Frase} l can not");
            }
        }

        private static void Person_ICan()
        {
            Console.WriteLine("Yes,l can");
        }

        private static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public static void HowOld(string Year)
        {
            
            string res = "l am " + Year;
            Console.WriteLine(res);
            
        }
        
    }

    public class Person
    {

        public delegate void Notify();
        public event Notify ICan;

        public string Frase { get; set; }

        public event EventHandler ICanNot;


        public void Comparison(double weight)
        {
            if(weight <= 70)
            {
                ICan?.Invoke();
            }
            else
            {
                ICanNot?.Invoke(this,null);
            }
        }
    }
}
