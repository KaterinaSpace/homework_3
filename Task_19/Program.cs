//Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    num = num * -1;
}
if (num < 100000 && num > 9999)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10)
    {
        Console.WriteLine("Да");
    }
    else 
    {

        Console.WriteLine("Нет");
    }

}

else
{
    Console.WriteLine("Это не пятизначное число");
}