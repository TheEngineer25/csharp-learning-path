int num1 = 0;
int num2 = 0;

bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("Please enter a whole number:");

if(num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal!");
}
else
{
    Console.WriteLine("Numbers are not equal!");
}

/*
int age = 16;
bool isWithParents = false;

if (age >= 13 && isWithParents)
{
    Console.WriteLine("Go party in the club!");
}
else if (age > 18)
{
    Console.WriteLine("Go party in the club!");
}
else
{
    Console.WriteLine("Go party in kindergarden!");
}
*/


Console.ReadKey();