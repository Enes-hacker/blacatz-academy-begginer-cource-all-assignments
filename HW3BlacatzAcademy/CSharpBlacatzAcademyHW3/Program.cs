// Task 2.

int sum = 0;


while (true)
{
    int num = int.Parse(Console.ReadLine());
    if (num == 0)
    {
        
        break;
    }
    
       //num = int.Parse(Console.ReadLine());
        sum += num; //sum = sum + num;
}

Console.WriteLine(sum);