/*
 
Your task is to create a simple C# program that checks whether a user is logged in using a boolean variable. If the user is logged in, the program should print "Welcome back!", otherwise, it should print "Please log in."

What You Need to Do:

Inside the CheckLogin method, declare a boolean variable called isLoggedIn.

Set isLoggedIn to true (to simulate a logged-in user).

Use an if statement to check the value of isLoggedIn:

If it is true, print "Welcome back!"

Otherwise, print "Please log in."

Expected Output:

Welcome back!
 
 */

bool isLoggedIn = true;

if (isLoggedIn)
{
    Console.WriteLine("Welcome back!");
}
else
{
    Console.WriteLine("Please log in.");
}

Console.ReadKey();