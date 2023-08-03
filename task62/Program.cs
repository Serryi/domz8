// Задача 62: Заполните спирально массив 4 на 4.

int k = 4;
int[,] Massive = new int[k, k];

int count = 1;
int i = 0;
int j = 0;

while (count <= Massive.GetLength(0) * Massive.GetLength(1))
{
  Massive[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < Massive.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Massive.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Massive.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArr(Massive);

void WriteArr (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
