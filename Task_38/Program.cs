﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] CreateArrayRndDouble (int size, int min, int max) 
{     
    double[] arr = new double[size];     
    Random rnd = new Random();     
    for (int i = 0; i < arr.Length; i++)     
    {         
        arr[i] = rnd.NextDouble() * (max - min) + min;     
    }     
    return arr; 
    }  
    void PrintArrayDouble (double[] arr) 
    {     
        Console.Write("[");     
        for (int i = 0; i < arr.Length; i++)     
        {         
            if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");         
            else Console.Write($"{arr[i]}");     
            }     
        Console.Write("]"); 
    }