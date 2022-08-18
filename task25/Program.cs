// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень его возвести? ");
int power = Convert.ToInt32(Console.ReadLine());

int PowerM(int number, int pow)
{
    int numberPow = number;
    for(int i = 1; i < pow; i++)
    {
        number = number * numberPow;
    }
    return number;
}

int res = PowerM(num, power);
Console.WriteLine($"число {num} в степени {power} = {res}");