//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int lines = InputNumber("Введите количество строк: ");
int columns = InputNumber("Введите количество столбцов: ");
int Max = InputNumber("Введите максимальное значение элементов массива:");
Console.WriteLine($"\nСформированный массив: ");

int[,] array = new int[lines, columns];
CreateArr(array);
WriteArr(array);

Console.WriteLine($"\nСортировка по убыванию элементов в каждой строке: ");
OrderLines(array);
WriteArr(array);

int InputNumber(string input)
{
  Console.WriteLine(input);
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

void WriteArr(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
void OrderLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}
