

using SEDC.Homework4.Excercise1.Classes;

Console.WriteLine("Excercise 1");

Console.WriteLine("please enter firstname of the human: ");

string firstname = Console.ReadLine();

Console.WriteLine("please enter lastname of the human: ");

string lastname = Console.ReadLine();

Console.WriteLine("Please enter age of the human: ");

bool isAgeInputParsed = int.TryParse(Console.ReadLine(), out int ageInputParsed);

if (isAgeInputParsed)
{
    Human human1 = new Human (firstname, lastname, ageInputParsed);

    human1.GetPersonStats();
}

else
{
    Console.WriteLine("Wrong entry!");
}
