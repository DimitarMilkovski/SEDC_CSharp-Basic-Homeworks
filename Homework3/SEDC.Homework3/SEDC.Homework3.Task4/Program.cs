
Console.WriteLine("Homework3 Task 4");

Console.WriteLine("Age Calculator");

Console.WriteLine("Please enter your Birthday date: (dd.mm.yyyy) --> ex:(25.10.2022)");

string inputDate = Console.ReadLine();


double AgeCalculator(string someInputDate)
{
    try
    {
        if (DateTime.TryParse(someInputDate, out DateTime inputDateParsed))
        {
            double age = (DateTime.Now - inputDateParsed).TotalDays / 365.242199;
            return Math.Round(age, 1);
        }
        else
        {
            throw new Exception();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Error, wrong entry!");
    }
    return 0;
    

}

Console.WriteLine($"Your age is: {AgeCalculator(inputDate)} years");
