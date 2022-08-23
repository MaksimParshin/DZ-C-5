// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 вёл пользователь.
// 0, 7, 8, -2, -2 -> 2в
// -1, -7, 567, 89, 223-> 3


int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

void InputNumbers(int n){
for (int i = 0; i < n; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int CountArray(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(n);

Console.WriteLine($"Введено чисел больше 0: {CountArray(arr)} ");

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения X: {x}, Y: {y}");