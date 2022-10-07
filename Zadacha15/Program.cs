/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

void WeekendOrNot(int weekday)
{

    if (weekday <= 5)
        Console.WriteLine($"{weekday} -> no");
    else
        if (weekday > 7)
        Console.WriteLine($"{weekday} -> not valid number");
    else
        Console.WriteLine($"{weekday} -> yes");
        
}

WeekendOrNot(1);
