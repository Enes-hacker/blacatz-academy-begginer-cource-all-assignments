// Task 2.

string eggs = "eggs";
string muffin = "muffin";
string banica = "banica";


string product = Console.ReadLine();


if (product.ToLower().Contains("eggs"))
{
    Console.WriteLine("5lv");
} else if (product.ToLower().Contains("muffin"))
{
    Console.WriteLine("2lv");

} else if(product.ToLower().Contains("banica")){
    Console.WriteLine("10lv");
} else
{
    Console.WriteLine("Invalid input");
}