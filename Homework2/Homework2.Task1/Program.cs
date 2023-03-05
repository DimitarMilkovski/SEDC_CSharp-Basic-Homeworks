
Console.WriteLine("Sum Of Even");

int[] inputNumbersArray = new int[6];
int sumOfEven = 0;

for (int i = 0; i < inputNumbersArray.Length; i++)
{
    Console.WriteLine($"please enter integer no {i+1}:");
    bool isInputNumberParsed = int.TryParse(Console.ReadLine(), out int inputNumber);
    if (isInputNumberParsed)
    {
        inputNumbersArray[i] = inputNumber; 
    }
    else
    {
        Console.WriteLine("Invalid Entry! please enter a number");
        i--;
    }
}

foreach (int number in inputNumbersArray)
{
    if (number % 2 == 0)
    {
        sumOfEven += number;
    }    
}
Console.WriteLine($"The sum of the eve numbers in the array is: {sumOfEven}");


