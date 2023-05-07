// 1. Напишите программу, которая на вход 
// 1.принимает два числа и 
// 2.проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine($"да число {numberA} являетсия квадратом числа {numberB}");
}
else 
{
    Console.WriteLine($"нет число {numberA} не являетсия квадратом числа {numberB}");

}