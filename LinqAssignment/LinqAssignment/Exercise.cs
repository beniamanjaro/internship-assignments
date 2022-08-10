using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public class Exercise : IEquatable<Exercise>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int NumberOfReps { get; set; }

        public int NumberOfSets { get; set; }

        public string Category { get; set; }

        public int Weight { get; set; }
        public int WorkoutId { get; set; }

        public IEnumerable<string> Equipment { get; set; } 

        public bool Equals(Exercise? other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            return Name.Equals(other.Name) && NumberOfReps.Equals(other.NumberOfReps) && NumberOfSets.Equals(other.NumberOfSets) && Equals(Category, other.Category) && Equals(Weight, other.Weight);

        }

        public override int GetHashCode()
        {
            int nameHashCode = Name.GetHashCode();
            int numberOfRepsHashCode = NumberOfReps.GetHashCode();
            int numberOfSetsHashCode = NumberOfSets.GetHashCode();
            int categoryHashCode = Category.GetHashCode();
            int weightHashCode = Weight.GetHashCode();

            return nameHashCode ^ numberOfRepsHashCode ^ numberOfSetsHashCode ^ categoryHashCode ^ weightHashCode;
        }

        public override string ToString()
        {
            return $"{Name} | {Category} | {NumberOfReps} | {NumberOfSets} | {Weight}";
        }
    }
}
