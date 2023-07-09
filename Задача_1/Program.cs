    // 2. Большее из 2вух чисел
Console.WriteLine("Введите число 1 : ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 : ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)Console.WriteLine($"{number1} > {number2}"); 
else Console.WriteLine($"{number1} < {number2}");
