// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = new int[8];
Random rnd = new Random();

Console.Write("[");

for(int i = 0; i < 8; i++)
{
    arr[i] = rnd.Next(1, 100);
    Console.Write($"{arr[i]}, ");
}
Console.Write("]");
