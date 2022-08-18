// Задача 27: Напишите программу, которая принимает на вход число и
//  выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum(int number)
{
    int originalNum = number;
    int sum = 0;
    int x = 1;
    
    while (number > 10)
    {
        sum = sum + number % 10;
        number /= 10;
        x *= 10;
    }
    return sum + originalNum / x;
}
int res = SumNum(num);
Console.WriteLine($"сумма цифр в числе {num} = {res}");

