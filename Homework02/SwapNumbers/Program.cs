
//Task 3:
//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

int FirstNumber = 5;
int SecondNumber = 8;
Console.WriteLine(FirstNumber);
Console.WriteLine(SecondNumber);

int temp = FirstNumber;
FirstNumber=SecondNumber;
SecondNumber = temp;
Console.WriteLine(FirstNumber);
Console.WriteLine(SecondNumber);
