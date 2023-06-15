//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string numberA = Console.ReadLine()!;
 int numberIntA = Convert.ToInt32(numberA);


Console.WriteLine("Введите второе число");
string numberB = Console.ReadLine()!;
 int numberIntB = Convert.ToInt32(numberB);
 if (numberIntA < numberIntB )
 {
    Console.WriteLine("max = numberIntB, min = numberIntA"); 
 } else {
   Console.WriteLine("max = numberIntA, min = numberIntB");
 }
 