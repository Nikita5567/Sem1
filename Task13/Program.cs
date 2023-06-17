// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите трехзначное число");
  int numb = Convert.ToInt32(Console.ReadLine());
  int Length = numb.ToString().Length;
  if (Length == 3)
{
     int result = (numb % 10) ;
     Console.WriteLine("Третья цифра равна"+  result);
} else {
    Console.WriteLine("число не трехзначное");
  }
    
    

 
 

