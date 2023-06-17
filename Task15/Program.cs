// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Console.WriteLine("Введите число");
//int numb = Convert.ToInt32(Console.ReadLine());
//int Length = numb.ToString().Length;
Console.WriteLine("Введите  число");
 string number = Console.ReadLine()!;
 int Length = Convert.ToInt32(number);
if ( Length == 1)
{
Console.WriteLine("Понедельник - Раб");
}
if ( Length == 2)
{
Console.WriteLine("Вторник - Раб");
} 
if ( Length == 3)
{
Console.WriteLine("Среда - Раб");
}
if ( Length == 4)
{
Console.WriteLine("Четверг - Раб");
}
if ( Length == 5)
{
Console.WriteLine("Пятница - Раб");
}
if ( Length == 6)
{
Console.WriteLine("Суббота - Выходной");
}
if ( Length == 7)
{
Console.WriteLine("Воскресенье - Выходной");
} 
 if  (Length > 8 || Length == 8 || Length == 0)
{
    Console.WriteLine("Такого дня недели не существует");
} 




 


 



