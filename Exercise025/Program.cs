// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Возводим число А в степень числа B");
Console.WriteLine("Введите целое число A");
if (!int.TryParse(Console.ReadLine(), out int A))
{
  Console.WriteLine("Введено нецелое число");
}
Console.WriteLine("Введите целое число B");
if (!int.TryParse(Console.ReadLine(), out int B) || B < 1)
{
  Console.WriteLine("Введено неверное число");
  return;
}
int Exponential(int A, int B)
{
  int step = 1;
  for (int i = 1; i <= B; i++)
  {
    step = step * A;
  }
  return step;
}
int result = Exponential(A, B);
Console.WriteLine($"{A} в степени {B} равно {result}");