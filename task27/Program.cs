/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
result(n);
void result(int n)
{
    int res = 0;
    while(n/10 != 0)
    {
        res = res + (n%10);
        n = n/10;
    } 
    res = res + (n%10);
    Console.WriteLine("Сумма цифр в числе равна " + res);
}

