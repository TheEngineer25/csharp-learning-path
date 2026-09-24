
Console.WriteLine("Please enter your age:");

int age = int.Parse(Console.ReadLine());
bool isWithParents = false;

if (age > 18)
{
    Console.WriteLine("Go party in the club!");
}

else if (age >= 13)
{
    Console.WriteLine("Are you with your parents? Answe with y or n");
    string answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Go party in the club with your parents!");
    }
    else
    {
        Console.WriteLine("No party for you!");
    }
} 
else
{
    Console.WriteLine("Go party in kindergarden!");
}



Console.ReadKey();