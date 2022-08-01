// See https://aka.ms/new-console-template for more information
using GenericCollectionAssignment;

string[] array = new string[8];

GenericCollection<string> stringCollection = new GenericCollection<string>(array);


stringCollection.Set("one", 0);
stringCollection.Set("two", 1);
stringCollection.Set("three", 2);
stringCollection.Set("A", 3);
stringCollection.Set("B", 4);

// Print the array values before the swap method.
Console.WriteLine("Listing elements before swapping some of them");
for (int index = 0; index < stringCollection.GetLength(); index++)
{
    string valueAtIndex = stringCollection.Get(index) ?? "Empty value";
    Console.WriteLine($"Value at index {index} is : {valueAtIndex}");
}

// Swap some elements
stringCollection.Swap(2, 1);
stringCollection.Swap(3, 4);
stringCollection.Swap("str", 2); // this will throw an exception - element not found


// Print the array values after the swap method.
Console.WriteLine("Listing elements after swapping some of them");
for (int index = 0; index < stringCollection.GetLength(); index++)
{
    string valueAtIndex = stringCollection.Get(index) ?? "Empty value";
    Console.WriteLine($"Value at index {index} is : {valueAtIndex}");
}
