// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Mass(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Power(int num, int deg)
{
    int pow = 1;

    for(int i = 0; i < deg; i++)
    {
        pow *= num;
    }
    return pow;
}

int A = Mass("Введите переменную А: ");
int B = Mass("Введите переменную B: ");
if (B < 0)
{
    Console.WriteLine("Степень не может быть отрицательной");
    return;
}

int result = Power(A, B);
Console.Write(result);
