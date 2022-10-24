// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine() ?? "");

int[] array = GetArray(size);
int count = GetCountNumbers(array);

Console.Write($"{String.Join(", ", array)}");
Console.Write($" -> {count}");

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
      Console.Write($"Введите элемент массива'");
      res[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return res;
}

int GetCountNumbers(int[] arr)
{
    int CountNumbers = 0;
    foreach (int el in arr)
    {
      if (el > 0) CountNumbers += 1;
    }
    return CountNumbers;
}

