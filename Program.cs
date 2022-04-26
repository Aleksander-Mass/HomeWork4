/*
Знакомство с языками программирования (семинары)
Урок 4. Функции продолжение
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}
CreateRandomArray(6, 100, 999);
void ShowArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
}
int[] myArray = CreateRandomArray(6, 100, 999);
int count = 0;
for(int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0)
            {
                count = count + 1;
            }
    }
Console.Write("[");
ShowArray(myArray);
Console.WriteLine("] -> " + count);
*/


/*
Знакомство с языками программирования (семинары)
Урок 4. Функции продолжение
Задача 36 (2): Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}
CreateRandomArray(4, -99, 99);
void ShowArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
}
int[] myArray = CreateRandomArray(4, -99, 99);
int count = 0;
for(int i = 0; i < myArray.Length; i++)
    {
        if (i % 2 != 0)
            {
                count = count + myArray[i];
            }
    }
Console.Write("[");
ShowArray(myArray);
Console.WriteLine("] -> " + count);
*/
/*
Знакомство с языками программирования (семинары)
Урок 4. Функции продолжение
Задача 38 (3): Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}
CreateRandomArray(6, -99, 99);
void ShowArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
}
int[] myArray = CreateRandomArray(6, -99, 99);
int max = 0;
int min = 0;
for(int i = 0; i < myArray.Length; i++)
    {
        if (max < myArray[i])
            {
                max = myArray[i];
            }
        if (min > myArray[i])
            {
                min = myArray[i];
            }
    }
    int difference = max - min;
Console.Write("[");
ShowArray(myArray);
Console.WriteLine("] -> " + difference);
*/
