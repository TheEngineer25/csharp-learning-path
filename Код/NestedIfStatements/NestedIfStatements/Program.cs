int num1 = 0;
int num2 = 0;

bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("Please enter a whole number:");

if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal!");

    Console.WriteLine("Please enter your age:");

    int age = int.Parse(Console.ReadLine());
    if ( age >= 18)
    {
        Console.WriteLine("Please enter your " +
            "adress, so you can have the prize");

        string address = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Sorry, you can't get the price!");
    }

}
else
{
    Console.WriteLine("Numbers are not equal!");
}