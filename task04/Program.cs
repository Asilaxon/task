// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите число А");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число D");
int numD = Convert.ToInt32(Console.ReadLine());

int max = numA; 

// if (numA > max ) max = numA;
if (numB > max ) max = numB;
if (numD > max ) max = numD;

Console.WriteLine($"Максимальное чисоло {max}");


