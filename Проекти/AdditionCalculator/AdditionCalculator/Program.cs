Console.WriteLine("Enter the first number:");

int myNumber = 0;
int myNumber2 = 0;

string userInput = Console.ReadLine();

myNumber = int.Parse(userInput);


Console.WriteLine("Enter the second number:");
userInput = Console.ReadLine();
myNumber2 = int.Parse(userInput);

int sum = myNumber + myNumber2;

//Console.WriteLine("The sum of " + myNumber + " and " + myNumber2 + " is " + sum);

Console.WriteLine($"The sum of {myNumber} and {myNumber2} is {sum}");

Console.ReadKey();