Console.WriteLine("Excercise 5");

int[] intArray = new int[5];
int sumOfArray = 0; 

Console.WriteLine("please fill an integer array with five elements: -->");
for (int i = 0; i < intArray.Length; i++)
{
    bool isParsedToInt = int.TryParse(Console.ReadLine(), out int inputValue);
    if (isParsedToInt)
    {
        intArray[i] = inputValue;
        sumOfArray += inputValue;
    }
    else 
    {
        Console.WriteLine("Invalid Entry! please enter a number");
        i--;

    };
}

Console.WriteLine($"The sum of the array is: {sumOfArray}");

