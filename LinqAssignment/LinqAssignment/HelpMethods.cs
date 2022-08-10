using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    static public class HelpMethods
    {

        static public void Print(IEnumerable<Exercise> items, string linqMethodUsed)
        {
            Console.WriteLine("");
            Console.WriteLine("Linq Method - " + linqMethodUsed);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        static public void Print(IEnumerable<int> items, string linqMethodUsed)
        {
            Console.WriteLine("");
            Console.WriteLine("Linq Method - " + linqMethodUsed);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        static public void Print(IEnumerable<string> items, string linqMethodUsed)
        {
            Console.WriteLine("");
            Console.WriteLine("Linq Method - " + linqMethodUsed);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }


    }
}
