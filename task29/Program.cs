﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Clear();
int[] array = new int[8];

void PrintArray(int[] array){
    for(int i=0;i<array.Length;i++){
        array[i] = new Random().Next(0,9);
    }
}

void WriteArray(int[] array){
    for(int i=0;i<array.Length;i++){
        Console.Write($"{array[i]} ");
    }
}

PrintArray(array);
WriteArray(array);