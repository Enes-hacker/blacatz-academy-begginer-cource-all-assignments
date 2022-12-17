//Задача 5.
Console.WriteLine("Enter a value for A");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a value for B");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a value for C");
int c = int.Parse(Console.ReadLine());

int maxNumber = Math.Max(a, Math.Max(b, c));

Console.WriteLine(maxNumber + " e nai-golqmoto chislo");

