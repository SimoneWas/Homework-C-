//Task 1
//Make a console application called SumOfEven. Inside it create an array of 6 integers. Find and print the sum of the even numbers from the array:

int[] numbers = { 6,9,7,16,22,8 };

int sumOfEven = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sumOfEven += number;
    }
}
Console.WriteLine("Sum of Even Numbers: " + sumOfEven);//52
       


