//Task 4.


/*for (int row = 0; row < 9; row++)
{
    for (int col = 0; col < 10; col++)
    {
       

        if (col == 4 || col == 5 || col == 6)
        {
            Console.WriteLine("**        *******************************");
            
        } else if (col == 1 || col == 9)
        {
            Console.WriteLine(" **********                              ");
           
        } else if (col == 2 || col == 3 || col == 7 || col == 8)
        {
            Console.WriteLine(" *        *                              ");
        }
        else
        {
            Console.Write("*");
        }
       
    }
    Console.WriteLine();
}
*/

int row = 17;

for (int i = 1; i <= row; i++)
{
    if (i == 1 || i == row)
    {
        Console.WriteLine(" **********                              ");
    }
    else if(i == 4 || i == 5 || i == 6)
    {
        Console.WriteLine("**        *******************************");
    } else if (i == 2 || i == 3 || i == 7 || i == 8)
    {
        Console.WriteLine(" *        *                              ");
    }

}
