// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

// Чтобы не злоупотреблять "спойлером", полученным на семинаре 3- сделано через строковую переменную 
Console.WriteLine("Введите цифру, обозначающую день недели:");
string? txt=Console.ReadLine();

if (txt!.Length>1)
    {Console.WriteLine("Неправильный ввод - нужна одна цифра");}
else if (txt[0]=='1' || txt[0]=='2'|| txt[0]=='3' || txt[0]=='4'  || txt[0]=='5')
    {Console.WriteLine("Нет");}
else if (txt[0]=='6' || txt[0]=='7' )
    {Console.WriteLine("ДА");}  
else 
    {Console.WriteLine("Такого дня не существует");}
