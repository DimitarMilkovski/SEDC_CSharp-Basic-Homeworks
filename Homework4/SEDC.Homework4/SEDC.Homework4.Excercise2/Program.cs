
using SEDC.Homework4.Excercise2.Classes;

Console.WriteLine("Excercise 2");



Console.WriteLine("please enter the name of the dog: ");

string name = Console.ReadLine();

Console.WriteLine("please enter race of the dog: ");

string race = Console.ReadLine();

Console.WriteLine("Please enter color of the dog: ");

string color = Console.ReadLine();

Dog dog1 = new Dog (name, race, color);

Console.WriteLine("Please choose what the dog should do");
Console.WriteLine("Press 1 to --> Eat, Press 2 to -->Play, Press 3 to --> Chase its tail:");

bool isInputNumberParsed = int.TryParse(Console.ReadLine(), out int  inputNumberParsed);

if (isInputNumberParsed)
{
    if (inputNumberParsed == 1)
    {
        dog1.Eat();
    }
    else if (inputNumberParsed == 2)
    {
        dog1.Play();
    }
    else if (inputNumberParsed == 3) 
    {
        dog1.ChaseTail();
    }
    else
    {
        Console.WriteLine("plase enter a number from one to 3!");
    }
}
else
{
    Console.WriteLine("Wrong entry! Please enter a number!");
}