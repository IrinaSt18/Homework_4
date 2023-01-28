/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int GetSumOfNumbers(int number)
{   
    int SumOfNumbers  = 0;
    while (number > 0)
    {
        SumOfNumbers = SumOfNumbers + number%10;
        number = number/10;
    }
    return SumOfNumbers;
}
int number = getUserValue("Введите число: ");
int SumOfNumbers = GetSumOfNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {SumOfNumbers}");