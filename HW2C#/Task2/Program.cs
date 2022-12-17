const decimal AverageMark = 3.00m;
const decimal GoodMark = 3.50m;
const decimal VeryGoodMark = 4.50m;
const decimal ExcellentMark = 5.50m;
const decimal ExcellentMark2 = 6m;
const decimal MinRange = 2m;
const decimal MaxRange = 6m;

Console.WriteLine("Enter 1st mark: ");
decimal numOne = decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter 2nd mark: ");

decimal numTwo = decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter 3rd mark: ");
decimal numThree = decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter 4th mark: ");
decimal numFour = decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter 5th mark: ");
decimal numFive = decimal.Parse(Console.ReadLine());

decimal Average = (numOne + numTwo + numThree + numFour + numFive) / 5m;

bool isMarkPoor = Average < AverageMark;
bool isMarkAverage = Average > AverageMark && Average < GoodMark;
bool isMarkGood = Average > GoodMark && Average < VeryGoodMark;
bool isMarkVeryGood = Average > VeryGoodMark && Average < ExcellentMark;
bool isMarkExcellent = Average >= ExcellentMark && Average <= ExcellentMark2;
bool isMarkRangeValid = Average >= MinRange && Average <= MaxRange;






if (isMarkPoor && isMarkRangeValid)
{
    Console.WriteLine("Slab");
    
    
}
else if (isMarkAverage && isMarkRangeValid)
{
    Console.WriteLine("Sreden");
}
else if (isMarkGood && isMarkRangeValid)
{
    Console.WriteLine("Dobyr");
}
else if (isMarkVeryGood && isMarkRangeValid)
{
    Console.WriteLine("Mnogo dobyr");
}
else if (isMarkExcellent && isMarkRangeValid)
{
    Console.WriteLine("Otlichen");
}
else
{
    Console.WriteLine("Invalid mark. Marks must be between 2 and 6");
}
