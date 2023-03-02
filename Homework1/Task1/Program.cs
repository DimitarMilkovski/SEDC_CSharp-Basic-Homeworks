Console.WriteLine("Real Calculator");
Console.WriteLine();

double firstInputNumber = 0;
double secondInputNumber = 0;
double result = 0;
string operation = "";

Console.WriteLine("Please Enter the first number you want to operate with:");
bool firstInputNumberIsParsed = double.TryParse(Console.ReadLine(), out firstInputNumber);

Console.WriteLine("Please Enter the second number you want to operate with:");
bool secondInputNumberIsParsed = double.TryParse((string)Console.ReadLine(),out secondInputNumber);

Console.WriteLine("Please Enter operator for the desired operation --> (+,-,*,/):");
string inputOperator = Console.ReadLine();

if (firstInputNumberIsParsed && secondInputNumberIsParsed)
{
    if (inputOperator == "+")
    {
        operation = "summed";
        result = firstInputNumber + secondInputNumber;
    }
    else if (inputOperator == "-") 
    {
        operation = "substracted";
        result = firstInputNumber - secondInputNumber;
    }
    else if (inputOperator == "*")
    {
        operation = "multiplicated";
        result = firstInputNumber * secondInputNumber;
    }
    else if(inputOperator == "/")
    {
        operation = "divided";
        result = firstInputNumber / secondInputNumber;
    }
    else
    {
        Console.WriteLine("Wrong entry! Please enter one of the displayed operators");
    }
}

Console.WriteLine($"{firstInputNumber} {operation} with {secondInputNumber} is equal to {result}");