// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число:");
int num=Convert.ToInt32(Console.ReadLine());
// Проверка на трехзначность, не указанная в условиях задачи:
if (num<100 || num>999)
    {Console.WriteLine("Неправильный ввод -число должно быть трехзначным");}
else
    {Console.WriteLine("Вторая цифра числа "+num+" равна "+(num%100)/10);}

