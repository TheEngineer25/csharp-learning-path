int age = int.Parse(Console.ReadLine());
bool isWithParents = false;

if (age >= 13 && isWithParents)
{
    Console.WriteLine("Go party in the club with your parents!");
} else if (age > 18)
{
    Console.WriteLine("Go party in the club!");
}
else
{
    Console.WriteLine("Go party in kindergarden!");
}



Console.ReadKey();