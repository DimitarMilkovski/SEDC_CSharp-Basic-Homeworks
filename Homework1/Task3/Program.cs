Console.WriteLine("Swap Numbers");
Console.WriteLine();

int firstInputNumber = 0;
int secondInputNumber = 0;
int assistantVariable = 0;


Console.WriteLine("Please Enter the first number:");
bool firstInputNumberIsParsed = int.TryParse(Console.ReadLine(), out firstInputNumber);

Console.WriteLine("Please Enter the second number:");
bool secondInputNumberIsParsed = int.TryParse((string)Console.ReadLine(), out secondInputNumber);

if (firstInputNumberIsParsed && secondInputNumberIsParsed)
{
    assistantVariable = firstInputNumber;
    firstInputNumber = secondInputNumber;
    secondInputNumber = assistantVariable;
}
else
{
    Console.WriteLine("Wrong entry! Please enter a number!");
}

Console.WriteLine($"After Swapping: First Number: {firstInputNumber}, Second Number: {secondInputNumber}");