Console.WriteLine("Average Numbers");
Console.WriteLine();

double average = 0;
double sum = 0;
double[] inputArray = new double[4];

Console.WriteLine("Please Enter the numbers you want to calculate average to:");
for (int i = 0; i < 4; i++)
{
    bool NumberIsParsed = double.TryParse(Console.ReadLine(), out inputArray[i]);
    if (NumberIsParsed == false)
    {
        i--;
        Console.WriteLine("Please Enter a number!");
    }
}

for (int i = 0;i < inputArray.Length; i++)
{
    sum += inputArray[i];
}

average = sum / inputArray.Length;

Console.WriteLine($"The Average of the four entered numbers is {average}");






