      //8. На вход принимает число, на выходе все четные числа
Console.WriteLine("Введите число : ");
int number = int.Parse(Console.ReadLine());
for (int i = 2; i <= number; i = i+2)
   Console.Write($"{i},");  

