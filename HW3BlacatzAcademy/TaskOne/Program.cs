//Task 1.
Console.WriteLine("Menu Choice");
Console.WriteLine("\r\n1. Insert new car");
Console.WriteLine("2. Show cars");
Console.WriteLine("0. Exit");

Console.WriteLine("make your choice");
int option = int.Parse(Console.ReadLine());


while (true)
{
    if (option == 0)
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else if (option == 1)
    {
        Console.WriteLine("New car Added");
    }
    else if (option == 2)
    {
        Console.WriteLine("Mercedes, Bmw, Audi available!");
    }
    else
    {
        Console.WriteLine("Wrong choice");
    }

    option = int.Parse(Console.ReadLine());
}

