//Task 1.
int DayOne = int.Parse(Console.ReadLine());
int DayTwo = int.Parse(Console.ReadLine()); 
int DayThree = int.Parse(Console.ReadLine());
int DayFour = int.Parse(Console.ReadLine());    
int DayFive = int.Parse(Console.ReadLine());    

int Total = DayOne + DayTwo + DayThree + DayFour + DayFive;


int[] array = new int[] { DayOne, DayTwo, DayThree, DayFour, DayFive };

int max = array.Max();
int min = array.Min();

decimal average = (DayOne + DayTwo + DayThree + DayFour + DayFive) / 5m;


Console.WriteLine($"Total: {Total}");
Console.WriteLine($"Min: {min}");
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Average: {average}");