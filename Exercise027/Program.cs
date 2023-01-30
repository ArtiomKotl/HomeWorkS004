// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10

int getVar()
{
  int varValue = 0;
  bool thisNumber = false;

  while (!thisNumber)
  {
    Console.Write($"Введите число: ");
    thisNumber = int.TryParse(Console.ReadLine(), out varValue);
    varValue = Math.Abs(varValue);

    if (varValue < 0)
    {
      thisNumber = false;
    }
  }

  return varValue;
}

int sumOfNun(int num)
{
  int sum = 0;
  while (num != 0)
  {
    sum += num % 10;
    num /= 10;
  }

  return sum;
}

int num = getVar();
int sum = sumOfNun(num);

Console.WriteLine($"Сумма цифр в числе равна: {sumOfNun(num)}");
