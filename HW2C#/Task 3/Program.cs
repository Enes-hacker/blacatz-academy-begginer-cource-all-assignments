
Console.WriteLine("Insert Income");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Insert Outccome");
int Y = int.Parse(Console.ReadLine());

int Outcome = X - Y;

if(Outcome > 0)
{
    Console.WriteLine("Predpriqtieto e na pechalba s: " + Outcome);
} else if (Outcome < 0)
{
    Console.WriteLine("Predpriqtieto e na zaguba s: " + Outcome);
} else
    Console.WriteLine("Breakeven");