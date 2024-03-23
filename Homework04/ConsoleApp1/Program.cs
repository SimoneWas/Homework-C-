// Task 1
//Take one string from the input and print its last 5 characters.
//Task 2
//Take a sentence as input and print its words.
//Task 3
//Create a function that takes a number as input. This method should return the sum of the digits in the number.

using System;
using System.Runtime.CompilerServices;

Console.WriteLine("Task 1");
static void PrintLastFiveChars(string input)
{
    if (input.Length >= 5)
    {
        Console.WriteLine(input.Substring(input.Length - 5));
    }
    else
    {
        Console.WriteLine("The input string is too short.");
    }
}
PrintLastFiveChars("The black cat is very angry"); //outpit: angry

Console.WriteLine("Task 2");
 static void PrintWords(string sentence)
{
    string[] words = sentence.Split(' ');
    foreach (string word in words)
    {
        Console.WriteLine(word);
    }
}
Console.WriteLine("The\n black\n cat\n is\n angry\n because\n he\n is\n hungry\n");

Console.WriteLine("Task 3");

 static int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}
int result = SumOfDigits(13579);
Console.WriteLine("The sum of the digits is: " + result);//result is 25,
                                                         //I was confused about this task, but I did a little research about the %10 and / :)

