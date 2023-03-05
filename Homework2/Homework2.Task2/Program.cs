Console.WriteLine("Student Group");

string[] studentG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentG2 = new string[] { "Vasko", "Nikola", "Dimitar", "Aleksandar", "Filip" };


Console.WriteLine("Please choose a student gruop 1 or 2: (enter 1/2)");
string inputNumber = Console.ReadLine();

if (inputNumber == "1")
{
    Console.WriteLine("The students in G1 are: ");
    foreach (string student in studentG1)
    {
        Console.WriteLine(student);
    }
}
else if (inputNumber == "2")
{
    Console.WriteLine("The students in G2 are: ");
    foreach (string student in studentG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Wrong entry!");
}