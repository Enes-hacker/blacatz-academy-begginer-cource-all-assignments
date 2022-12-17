//Task 3.
Console.WriteLine("Please enter the first word: ");
string FirstWord = Console.ReadLine();

Console.WriteLine("Please enter the second word: ");
string SecondWord = Console.ReadLine();

if(FirstWord.Length > SecondWord.Length)
{
    Console.WriteLine($"{FirstWord} wins");
} else if (FirstWord.Length < SecondWord.Length)
{
    Console.WriteLine($"{SecondWord} wins");
} else
{
    Console.WriteLine("Draw");
}