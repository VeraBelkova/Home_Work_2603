// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел ");
string value = Console.ReadLine();
int Length = Convert.ToInt32(value);

int[] array =new int [Length];
for (int i = 0; i < array.Length; i++)
{
  Console.WriteLine($"Введите {i+1}-е число");
  int num = Convert.ToInt32(Console.ReadLine());
  array[i] = num;
}
Console.WriteLine(String.Join(",", array));

int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] > 0) count++;
}
Console.WriteLine();
Console.WriteLine(count);
