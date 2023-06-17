
        // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
        // 5 -> 2, 4
        // 8 -> 2, 4, 6, 8
        

        
        
 Console.WriteLine("Введите число N");
string N = Console.ReadLine();
int Op = Convert.ToInt32(N);
for ( int i = 2; i <= Op; i ++)
 if (Op % 2 == 0)
 {
      Console.WriteLine(i);  
 }  

        


    
