// See https://aka.ms/new-console-template for more information
using ExceptionsAssignment.Exceptions;

//try
//{
//    ExceptionMethods.TestTryCatchFinally(exName, 10, 3);
//} catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//    Console.WriteLine(e.StackTrace);
//}

//try
//{
//    ExceptionMethods.TestTryCatchFinally("benchpress", -3, 2);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//    Console.WriteLine(e.StackTrace);
//}

try
{
    ExceptionMethods.TestDebugMode();
    ExceptionMethods.TestTryCatchFinally("squat", 10, -4);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
