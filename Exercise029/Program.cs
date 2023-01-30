// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]



int[] genArr(int N)
{
  int[] arrNum = new int[N];

  Random rnd = new Random();
  for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(-50, 50)) { }

  return arrNum;
}

void printArr(int N)
{
  System.Console.Write($"[{String.Join(",", genArr(N))}]\n");
}

int getVar()
{
  int varValue = 0;
  bool isNumeric = false;

  while (!isNumeric)
  {
    Console.Write($"Введите число элементов массива: ");
    isNumeric = int.TryParse(Console.ReadLine(), out varValue);
    if (varValue < 0)
    {
      isNumeric = false;
    }
  }

  return varValue;
}

int N = getVar();
printArr(N);