using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    static public class HelpMethods
    {

        static public void Print(IEnumerable<Exercise> items)
        {
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}
