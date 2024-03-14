

//Task 1
//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25

double number1, number2;
string operation;


Console.WriteLine("Enter the first number: ");
number1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Enter the operation (+, -, *, /): ");
operation = Console.ReadLine();


Console.WriteLine("Enter the second number: ");
number2 = Convert.ToDouble(Console.ReadLine());

switch (operation)
{
    case "+":
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        break;
    case "-":
        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        break;
    case "*":
        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
        break;
    case "/":
        if (number2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        }
        break;
    default:
        Console.WriteLine("Error: Invalid operation.");
        break;
}

