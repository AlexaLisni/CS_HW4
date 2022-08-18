// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.WriteLine("Ведите минимально число масива: ");
int minNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите максемальое число масива: ");
int maxNum = Convert.ToInt32(Console.ReadLine());
int[] res = FillArray(8,minNum,maxNum);
PrintArr(res);

int[] FillArray(int n, int min, int max)
{

    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;

}

void PrintArr(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");

        if (i < array.Length - 1) Console.Write(array[i] + ", ");

        else Console.Write(array[i] + "] ");


    }

}
