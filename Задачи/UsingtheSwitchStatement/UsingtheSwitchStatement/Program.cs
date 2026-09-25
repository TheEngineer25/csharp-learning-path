/*
 
 Create a simple C# program using a switch statement to replace an if-else structure for printing days of the week based on an integer value.

Alert!

The result of execution for the default string should be:

"Wednesday"

 
 
 */

int day = 3;

// TODO: Rewrite this if-else structure using a switch statement.
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thusrday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Unknown");
        break;
}



Console.ReadKey();