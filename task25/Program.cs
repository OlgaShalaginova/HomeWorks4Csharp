/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.Clear();
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine()!);
Result(A, B);
void Result(int A, int B)
{
    int res = A;
    for (int i = 1; i < B; i ++)
    {
        res = res*A;
    }
  Console.WriteLine( "А в степени B равно " + res);
}

