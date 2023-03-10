Console.WriteLine("Homework3 Task 3");

Console.WriteLine("Please Enter a full number:-->");

#region With strings methodds
//string inputNumber = Console.ReadLine();

//char[] charNumberArray = inputNumber.ToCharArray();
//int sumOfDigits = 0;
//bool isNanFlag  = false;

//foreach (char charNumber in charNumberArray)
//{
//    bool isNumberFromCharParsed = int.TryParse(charNumber.ToString(), out int numberFromCharParsed);

//    if (isNumberFromCharParsed)
//    {
//        sumOfDigits += numberFromCharParsed;
//    }
//    else
//    {
//        isNanFlag = true;
//        Console.WriteLine("You didnt enter a full number!");
//    }
//}
//if (isNanFlag != true)
//{
//    Console.WriteLine($"The sum of the digits is: {sumOfDigits}");
//}
#endregion

#region With Function
bool isInputNumberParsed = int.TryParse(Console.ReadLine(), out int inputNumberParsed);

if (isInputNumberParsed)
{
    Console.WriteLine($"The sum of digits is: {SumOfDigits(inputNumberParsed)}");
}
else
{
    Console.WriteLine("Wrong Entry, please enter a number!");
}

int SumOfDigits (int inputNumber)
{
    int sumOfDigits = 0;
    while (inputNumber > 0)
    {
        sumOfDigits += inputNumber % 10;
        inputNumber /= 10;
    }
    
    return sumOfDigits;
}



#endregion