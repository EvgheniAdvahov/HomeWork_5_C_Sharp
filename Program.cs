//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] MyArr = new int[]{345,897,2,1,568,234};
// int count =0;

// for (int i = 0; i < MyArr.Length; i++)
// {
//     if(MyArr[i] % 2 ==0) count ++;
// }
// System.Console.WriteLine($"Количество чётных чисел: {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] MyArr = new int[5];
// int sum = 0;
// for (int i = 0; i < MyArr.Length; i++)
// {
//     MyArr[i] = new Random().Next(1,6);
//     if(i % 2 ==0) sum +=MyArr[i];
// }
// System.Console.WriteLine(String.Join(",", MyArr));

// System.Console.WriteLine($"Сумма элементов равна: {sum}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] Myarr = new double[]{3,7,22.22, 2.08,78};

// double Max = Myarr[0];
// double Min = Myarr[0];

// for (int i = 0; i < Myarr.Length; i++)
// {
//     if(Myarr[i] > Max) Max = Myarr[i];
//     if(Myarr[i] < Min) Min = Myarr[i];
// }

// System.Console.WriteLine($"Разница равна: {Max - Min}");