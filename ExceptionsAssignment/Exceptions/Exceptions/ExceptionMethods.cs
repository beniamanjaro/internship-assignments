using ExceptionsAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment.Exceptions
{
    public static class ExceptionMethods
    {

        public static Exercise createExercise(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }

            return new Exercise() { Name = name };

        }

        public static void AddRepsAndSets(Exercise exercise, int reps, int sets)
        {
            if (reps < 0)
            {
                throw new NegativeRepsException("The reps number cannot be less than 0");
            }

            if (sets < 0)
            {
                throw new NegativeSetsException("The sets number cannot be less than 0");
            }

            exercise.NumberOfReps = reps;
            exercise.NumberOfSets = sets;


        }

        public static void TestTryCatchFinally(string name, int reps, int sets)
        {

            try
            {
                Console.WriteLine("This is the try block");
                Exercise ex = createExercise(name);
                AddRepsAndSets(ex, reps, sets);

            }
            catch (NullReferenceException)
            {

            }
            catch (NegativeRepsException)
            {
                throw;
            }
            catch (NegativeSetsException)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("this is the finally block");
            }
        }


        public static void TestDebugMode()
        {
#if DEBUG
                Console.WriteLine("This will run in the debug mode!");
#else
                Console.WriteLine("This will run in the release mode!");

#endif
        }














    }
}
