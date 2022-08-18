// Задача 27: Напишите программу, которая принимает на вход число и
//  выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(num > 0 ){
    num /= 10;
    sum += num;
}
Console.WriteLine(sum);