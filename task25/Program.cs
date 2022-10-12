/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.Clear();
int a, b;
Vvod( out a, out b);
Result(a, b);
void Vvod( out int A, out int B)
{
    Console.Write("Введите число А: ");
    A = int.Parse(Console.ReadLine()!);
     Console.Write("Введите число B: ");
    B = int.Parse(Console.ReadLine()!);
}
void Result(int A, int B)
{
    int res = A;
    for (int i = 1; i < B; i ++)
    {
        res = res*A;
    }
  Console.WriteLine( "А в степени B равно " + res);
}

