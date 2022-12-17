int numOne = int.Parse(Console.ReadLine()); 
int numTwo = int.Parse(Console.ReadLine());

char character = char.Parse(Console.ReadLine());    

if(character == '+')
{
    Console.WriteLine(numOne + numTwo);

} else if (character == '-')
{
    Console.WriteLine(numOne - numTwo);
} else if (character == '*')
{
    Console.WriteLine(numOne * numTwo);

} else if (character == '/')
{
    Console.WriteLine(numOne / numTwo);
}
else
{
    Console.WriteLine("Choose another character");   
}