/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int [] GetArrayRandom(int length)
{
    int [] array = new int [length];
    for (int i = 0; i < length;i++)
    {
        array[i]=new Random().Next(0,100);
    }
    return array;
} 
void showArray(int []array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length ; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]},");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
}
int [] array= GetArrayRandom(8);
showArray(array);
