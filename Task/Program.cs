﻿// Задача: 

// Написать программу, которая из имеющегося массива
// строк формирует новый массив из строк, длина которых
// меньше, либо равна 3 символам. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно
// массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void Main()
{
    string[] Array = ReadArray("Enter several Symbols using a spacebar: ");
    int NewArraySize = ArraySize(Array, 3);
    System.Console.WriteLine(ArraySize(Array, 3));
    PrintArray(FillUserArray(Array, NewArraySize, 3));
    
}

string[] ReadArray(string text)
{
    System.Console.Write(text);
    string[] inputArray = Console.ReadLine().Split(" ");
    return inputArray;
}

int ArraySize(string[] array, int border)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= border)
        {
            size++;
        }
    }
    return size;
}

string[] FillUserArray(string[] array, int size, int border)
{
    string[] userArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        int j =0;
        if (array[i].Length <= border)
        {
            userArray[j]= array[i];
            j++;
        }
    }
    return userArray;
}

void PrintArray(string[] arr)
{
    System.Console.WriteLine("{" + string.Join(",", arr) + "}");
}

Main();
