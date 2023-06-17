// //  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1
Console.WriteLine("Введите трехзначное число");
  int numb = Convert.ToInt32(Console.ReadLine());
  int Length = numb.ToString().Length;
  if (Length == 3)
  {
    int result = (numb /10) % 10;
    Console.WriteLine("Вторая цифра равна"+  result);
  } else {
    Console.WriteLine("число не трехзначное");
  }
 
 


