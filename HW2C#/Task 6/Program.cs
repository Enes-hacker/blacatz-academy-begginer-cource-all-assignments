/*int Pizza = int.Parse(Console.ReadLine());
int Burger = int.Parse(Console.ReadLine());
int Juice = int.Parse(Console.ReadLine());*/

int PizzaPrice = 10;
int BurgerPrice = 5;
int getrankPris = 3;

string OrderYourFood = Console.ReadLine();

if (OrderYourFood.ToLower().Contains("pizza"))
{
    Console.WriteLine(PizzaPrice + "lv");
} else if(OrderYourFood.ToLower().Contains("burger"))
{
    Console.WriteLine(BurgerPrice + "lv");
} else if(OrderYourFood.ToLower().Contains("juice"))
{
    Console.WriteLine(getrankPris + "lv");
} else
{
    Console.WriteLine("Invalid Order");
}



