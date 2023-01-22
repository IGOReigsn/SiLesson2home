/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число:");
//int num=Convert.ToInt32(Console.ReadLine());
int num=Convert.ToInt32(Console.ReadLine());
if (num>99)
    {
    string txt=Convert.ToString(num);
    Console.WriteLine("Вывод (текстовый)"+ txt.Length +" "+ txt[2]);
    //Console.WriteLine($,"Вывод" {txt});
    //int p=Convert.ToInt32((Math.Log10(num))%1);
    int p=(int)((Math.Log10(num)))+1;
    Console.WriteLine("Вывод "+ p);
    }
else Console.WriteLine("третьей цифры нет");