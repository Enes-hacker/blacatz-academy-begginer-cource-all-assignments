using System.Diagnostics.Metrics;

double num = int.Parse(Console.ReadLine());
double sum = 0;
double avg = 0;

while (num != -1)
{
    avg += num;
    sum++;
    num = int.Parse(Console.ReadLine());
    if (num > 6 || num < 2)
    {
        Console.WriteLine("Invalid mark");
        break;


    }

}
Console.WriteLine((double)avg / (double)sum);