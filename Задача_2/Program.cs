        //4.Наибольшее из трех чисел
Console.WriteLine("Введите число 1 : ");
int m1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 : ");
int m2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3 : ");
int m3 = int.Parse(Console.ReadLine());
int Mmax = 0;
if (m1 > m2) Mmax = m1; else Mmax = m2;
if (Mmax < m3) Mmax = m3;
Console.WriteLine($"Наибольшее из заданных чисел: {Mmax}"); 

