Console.WriteLine("Enter the first number:");

double myNumber = 0.0;
double myNumber2 = 0;

string userInput = Console.ReadLine();

myNumber = double.Parse(userInput);


Console.WriteLine("Enter the second number:");
userInput = Console.ReadLine();
myNumber2 = double.Parse(userInput);

double sum = myNumber + myNumber2;

//Console.WriteLine("The sum of " + myNumber + " and " + myNumber2 + " is " + sum);

Console.WriteLine($"The sum of {myNumber} and {myNumber2} is {sum}");

Console.ReadKey();