Console.WriteLine("insert A");
int sideA = int.Parse(Console.ReadLine());

Console.WriteLine("insert B");
int sideB = int.Parse(Console.ReadLine());

Console.WriteLine("insert C");
int sideC = int.Parse(Console.ReadLine());

bool isThreeangleEquilateral = sideA == sideB && sideA == sideC && sideB == sideC;

//Variant 1
if (isThreeangleEquilateral)
{
    Console.WriteLine("Triagalnika e ravnostranen");
}
else
{
    Console.WriteLine("Triagalnika ne e ravnostranen");
}

//variant 2
var result = isThreeangleEquilateral ? "Triagalnika e ravnostranen" : "Triagalnika ne e ravnostranen";
Console.WriteLine(result);