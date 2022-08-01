// See https://aka.ms/new-console-template for more information
using LinqAssignment;
using System.Linq;

Console.WriteLine("Hello, World!");

List<Exercise> exercises = new();
exercises.Add(new Exercise() { Name = "Bench Press", Category = "Chest", NumberOfReps = 8, NumberOfSets = 3 });
exercises.Add(new Exercise() { Name = "Squat", Category = "Legs", NumberOfReps = 8, NumberOfSets = 3 });
exercises.Add(new Exercise() { Name = "Push Ups", Category = "Chest", NumberOfReps = 8, NumberOfSets = 3 });
exercises.Add(new Exercise() { Name = "Deadlift", Category = "Back", NumberOfReps = 8, NumberOfSets = 3 });
exercises.Add(new Exercise() { Name = "Pull Ups", Category = "Back", NumberOfReps = 8, NumberOfSets = 3 });
exercises.Add(new Exercise() { Name = "Ezbar Curls", Category = "Arms", NumberOfReps = 8, NumberOfSets = 3 });



// Filtering Operators

//Where

var chestExercises = exercises.Where(e => e.Category == "Chest");
HelpMethods.Print(chestExercises);

