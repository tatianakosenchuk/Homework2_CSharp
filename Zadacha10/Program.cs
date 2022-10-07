/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

void SecondDigitOfNumber(int number)
{
    if (number / 100 < 1)
        Console.WriteLine($"{number} -> введено не трехзначное число");
    else
        Console.WriteLine($"{number} -> {int.Parse(Convert.ToString(number)[1].ToString())}");
    
}



SecondDigitOfNumber(612);