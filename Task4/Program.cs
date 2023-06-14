// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
 string numberA = Console.ReadLine()!;
 int numberIntA = Convert.ToInt32(numberA);
 
Console.WriteLine("Введите второе число");
 string numberB = Console.ReadLine()!;
 int numberIntB = Convert.ToInt32(numberB);
 
Console.WriteLine("Введите третье число");
 string numberC = Console.ReadLine()!;
 int numberIntC = Convert.ToInt32(numberC);
 int max = 0;

 
 if (numberIntA > numberIntB){
   max = numberIntA;
 } else {
   max = numberIntB;
 }
 if (numberIntC > max){
   max = numberIntC;
 }
  Console.WriteLine("Наибольшее из 3-х чисел " + max);
   
 





   

 