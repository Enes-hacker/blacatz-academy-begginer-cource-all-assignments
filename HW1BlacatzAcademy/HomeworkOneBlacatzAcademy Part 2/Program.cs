//Задача 4.

Console.WriteLine("Enter a value for A");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Enter a value for B");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Enter a value for C");
double c = double.Parse(Console.ReadLine());

double formula = Math.Sqrt(a + b)  + Math.Pow(c, 2);

Console.WriteLine("The result is: " + formula);

