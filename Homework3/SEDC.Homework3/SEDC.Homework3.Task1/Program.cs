Console.WriteLine("Homework 3 Task 1");
Console.WriteLine();
Console.WriteLine("Please Enter some string:-->");

string inputString = Console.ReadLine();

char[] charStringArray = inputString.ToCharArray();
Console.WriteLine("The last 5 characters of the input string are:");

for (int i = charStringArray.Length - 5; i <= charStringArray.Length-1; i++)
{
    Console.Write(charStringArray[i]);
}
