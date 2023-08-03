// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int x = InputNumber("Введите число строк 1-й матрицы: ");
int y = InputNumber("Введите число столбцов 1-й матрицы (также строк 2-й): ");
int z = InputNumber("Введите число столбцов 2-й матрицы: ");
int Max = InputNumber("Введите максимальное значение элементов матриц ");

int[,] firstMartrix = new int[x, y];
CreateArr(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArr(firstMartrix);

int[,] secomdMartrix = new int[y, z];
CreateArr(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArr(secomdMartrix);

int[,] resultMatrix = new int[x,z];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение двух матриц:");
WriteArr(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumber(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArr(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(Max);
    }
  }
}

void WriteArr (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
