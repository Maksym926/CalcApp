using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class List
    {
        static void Main()
        {
            List<string> Names = new List<string>();
            Names.Add("Bob");
            Names.Add("Ben");
            Names.Insert(0, "Max");
            foreach(string name in Names)
            {
                Console.WriteLine(name);
                
            }
            Console.ReadLine();
        }
    }
}
