// See https://aka.ms/new-console-template for more information
using LinqAssignment;
using System.Collections;
using System.Linq;


List<Exercise> exercises = new();
exercises.Add(new Exercise() { Id = 1, Name = "Bench Press", Category = "Chest", NumberOfReps = 8, NumberOfSets = 3, Weight = 80, WorkoutId = 1,  Equipment = new List<string>() { "Barbell", "Bench" } });
exercises.Add(new Exercise() { Id = 2, Name = "Squat", Category = "Legs", NumberOfReps = 12, NumberOfSets = 3, Weight = 100, WorkoutId = 3, Equipment = new List<string>() { "Barbell", "Rack" } });
exercises.Add(new Exercise() { Id = 3, Name = "Deadlift", Category = "Back", NumberOfReps = 9, NumberOfSets = 3, Weight = 120, WorkoutId = 2, Equipment = new List<string>() { "Barbell" } });
exercises.Add(new Exercise() { Id = 4, Name = "Push Ups", Category = "Chest", NumberOfReps = 6, NumberOfSets = 3, Weight = 0, WorkoutId = 1, Equipment = new List<string>() });
exercises.Add(new Exercise() { Id = 5, Name = "Deadlift", Category = "Back", NumberOfReps = 9, NumberOfSets = 3, Weight = 120, WorkoutId = 2, Equipment = new List<string>() { "Barbell" } });
exercises.Add(new Exercise() { Id = 6, Name = "Pull Ups", Category = "Back", NumberOfReps = 15, NumberOfSets = 3, Weight = 0, WorkoutId = 2, Equipment = new List<string>() { "Pullups Bar" } });
exercises.Add(new Exercise() { Id = 7, Name = "Ezbar Curls", Category = "Arms", NumberOfReps = 15, NumberOfSets = 2, Weight = 20, WorkoutId = 4, Equipment = new List<string>() { "Ezbar" } });


List<Workout> workouts = new();
workouts.Add(new Workout() { Id = 1, Name = "Chest Workout" });
workouts.Add(new Workout() { Id = 3, Name = "Legs Workout" });
workouts.Add(new Workout() { Id = 2, Name = "Back Workout" });

List<int> nums = new() {1,2,3,4,4,5 };



// Filtering

//Where - returns a subset of elements that satisfy a given condition

var chestExercises = exercises.Where(e => e.Category.ToLower() == "chest");
HelpMethods.Print(chestExercises, "Where");

//Take
var firstExercise = exercises.Take(1);
HelpMethods.Print(firstExercise, "Take");

//Skip
var exercisesWithoutFirstThree = exercises.Skip(3);
HelpMethods.Print(exercisesWithoutFirstThree, "Skip");

//TakeWhile
var exercisesTakeWhile = exercises.TakeWhile(e => e.Weight < 100);
HelpMethods.Print(exercisesTakeWhile, "Take While");

//SkipWhile
var exercisesSkipWhile = exercises.OrderByDescending(e => e.Weight).SkipWhile(e => e.Weight >= 80);
HelpMethods.Print(exercisesSkipWhile, "Ship While");

//Distinct
var distinctExercises = exercises.Distinct();
HelpMethods.Print(distinctExercises, "Distinct");

//Distinct
var distinctNums = nums.Distinct();
HelpMethods.Print(distinctNums, "Distinct");



// Projection

//Select
var exercisesNames = exercises.Select(e => e.Name).Distinct().ToList();
HelpMethods.Print(exercisesNames, "Select");

//SelectMany
var exercisesEquipment = exercises.SelectMany(e => e.Equipment).Distinct().ToList();
HelpMethods.Print(exercisesEquipment, "SelectMany");



//Joins

//Join
var innerJoin = exercises.Join(workouts,
                               exercise => exercise.WorkoutId,
                               workout => workout.Id,
                               (exercise, workout) => new
                               {
                                   ExerciseName = exercise.Name,
                                   WorkoutName = workout.Name,
                                   WorkoutId = workout.Id,
                                }).OrderBy(w => w.WorkoutId).Distinct();
foreach(var ex in innerJoin)
{
    Console.WriteLine($"{ex.WorkoutName} - {ex.ExerciseName} ");
}



//GroupJoin
var groupJoin = workouts.GroupJoin(exercises, w => w.Id, e => e.WorkoutId, (workout, exercises) => new { exercises = exercises, workoutName = workout.Name });
foreach(var workout in groupJoin)
{
    Console.WriteLine(workout.workoutName);
    foreach(var ex in workout.exercises)
    {
        Console.WriteLine(ex);
    }
}

//Zip
var zipMethod = exercises.Zip(workouts, (first, second) => first + " - " + second.Name);
HelpMethods.Print(zipMethod, "Zip");



// Ordering

//OrderBy
var exercisesOrderedByWeigth = exercises.OrderBy(e => e.Weight);
HelpMethods.Print(exercisesOrderedByWeigth, "OrderBy");

//ThenBy
var exercisesOrderedByWeigthThenByReps = exercises.OrderBy(e => e.Weight).ThenBy(e => e.NumberOfReps);
HelpMethods.Print(exercisesOrderedByWeigthThenByReps, "ThenBy");

//OrderByDescending
var exercisesOrderedByWeigthDescending = exercises.OrderByDescending(e => e.Weight);
HelpMethods.Print(exercisesOrderedByWeigthDescending, "OrderByDescending");

//ThenByDescending
var exercisesOrderedByWeigthThenByRepsDescending = exercises.OrderBy(e => e.Weight).ThenByDescending(e => e.NumberOfReps);
HelpMethods.Print(exercisesOrderedByWeigthThenByRepsDescending, "ThenByDescending");

//Reverse
var exercisesNamesReversed = exercises.OrderBy(e => e.Name).Reverse();
HelpMethods.Print(exercisesNamesReversed, "Reverse");



// Grouping

//GroupBy
var exercisesGroupedByWorkoutId = exercises.GroupBy(e => e.WorkoutId).OrderBy(e => e.Key);
Console.WriteLine("");
foreach (var workout in exercisesGroupedByWorkoutId)
{
    Console.WriteLine(workout.Key);
    foreach (var ex in workout)
    {
        Console.WriteLine(ex);
    }
}



// Conversion Methods

//OfType
ArrayList items = new() { "one", "two", 1, false, 3 };
items.OfType<string>();

//Cast
ArrayList values = new () { 10, 2, 4, 8 };
values.Cast<int>();

//ToArray
int[] weights = exercises.Select(e => e.Weight).ToArray();

//ToList
List<string> exercisesCategories = exercises.Select(e => e.Category).Distinct().ToList();

//ToDictionary
Dictionary<int, Workout> workoutDict = workouts.ToDictionary(w => w.Id);

//ToLookup
var exercisesByWorkout = exercises.ToLookup(e => e.WorkoutId);



//Element

var defaultEx = new Exercise() { Id = 999, Name = "Default exercise", Category = "Default", NumberOfReps = 99, NumberOfSets = 9, Weight = 999, WorkoutId = 99, Equipment = new List<string>() {  } };
var emptyExercisesList = new List<Exercise>();

//First
var firstElement = exercises.First();

//FirstOrDefault
var firstExerciseOrDefault = emptyExercisesList.FirstOrDefault(defaultEx);

//Last
var lastExercise = exercises.Last();

//LastOrDefault
var lastExerciseOrDefault = emptyExercisesList.LastOrDefault(defaultEx);

//Single
var singleExercise = exercises.Single(e => e.Id == 2);

//SingleOrDefault
var singleExerciseOrDefault = emptyExercisesList.SingleOrDefault(e => e.Id == 2);

//ElementAt
var thirdExercise = exercises.ElementAt(2);

//ElementAtOrDefault
var thirdExerciseOrDefault = exercises.ElementAt(2);

//DefaultIfEmpty
var defaultExerciseIfEmpty = emptyExercisesList.DefaultIfEmpty(defaultEx);



//Aggregation Methods

//Count
var exercisesLength = exercises.Count();

//LongCount
var exercisesLengthLong = exercises.LongCount();

//Min
var lowestWeigth = exercises.Min(e => e.Weight);

//Max
var maxWeigth = exercises.Max(e => e.Weight);

//Sum
var totalWeigthLifted = exercises.Sum(e => e.Weight);

//Average
var averageNumberOfReps = exercises.Average(e => e.NumberOfReps);

//Aggregate
var totalNumberOfReps = exercises.Select(e => e.NumberOfSets).Aggregate((a, b) => a + b);



//Quatifiers

//Contains
var exNameStartsWithB = exercises[0].Name.Contains("B");

//Any
if(exercises.Any(e => e.Category == "Chest"))
{
    Console.WriteLine("There is one or more Chest exercises in the list");
} else
{
    Console.WriteLine("There are no Chest exercises in the list");
}

//All
if(exercises.All(e => e.NumberOfReps > 5))
{
    Console.WriteLine("Every exercise have a number of reps greater than 5");
} else
{
    Console.WriteLine("There is one or more exercises with the number of reps less than 5");
}

//SequenceEqual
bool isEqual = new[] { 1, 1, 2 }.Skip(1).SequenceEqual(new[] { 1, 1, 2 }.Skip(1));



//Generation Methods

//Empty
var emptyCollection = Enumerable.Empty<int>();

//Repeat
var repeatString = Enumerable.Repeat("String", 5);

//Range
IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);