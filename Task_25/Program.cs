/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int GetNaturalPowerOfNum(int numberA,int numberB)
{
    int NaturalPowerOfNum = numberA;
for (int i = 1; i < numberB; i++)
{
    NaturalPowerOfNum = NaturalPowerOfNum * numberA;  
}
return NaturalPowerOfNum;
}
int numberA = getUserValue("Введите первое число(A): ");
int numberB = getUserValue("Введите второе число(B): ");
int NaturalPowerOfNum = GetNaturalPowerOfNum(numberA,numberB);
Console.WriteLine($"Число {numberA}, возведенное в натуральную степень {numberB} = {NaturalPowerOfNum}");