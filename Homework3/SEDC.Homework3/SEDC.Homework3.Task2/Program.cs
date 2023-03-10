
Console.WriteLine("Homework 3 Task 2");
Console.WriteLine();
Console.WriteLine("Please enter a sentence:-->");

string inputSentence = Console.ReadLine();

string[] sentenceWords = inputSentence.Split(" ");



Console.WriteLine("The words from the input sentence are:");
foreach (string word in sentenceWords)
{
    Console.WriteLine($"{word} ");
}


