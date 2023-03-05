Console.WriteLine("Excercise 5");

string[] namesArray = new string[1];

Console.WriteLine("Please enter a name:");

namesArray[0] = Console.ReadLine();

for ( ; ; )
{
    Console.WriteLine("Do you want to enter another name in the array? Y/N");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
        Array.Resize(ref namesArray, namesArray.Length +1);
        Console.WriteLine("Please enter the name:");
        namesArray[namesArray.Length - 1] = Console.ReadLine();
    }
    else if (answer == "N" || answer == "n")    
    {
        foreach (string name in namesArray)
        {
            Console.WriteLine("All the names that you entered:");
            Console.WriteLine(name);
        }
        break;
    }
    else { Console.WriteLine("Invalid entry! Please enter Y/N (yes or no)"); }
} 


