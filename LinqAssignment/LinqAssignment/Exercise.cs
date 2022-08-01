using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public class Exercise
    {
        public string Name { get; set; }

        public int NumberOfReps { get; set; }

        public int NumberOfSets { get; set; }

        public  string Category { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
