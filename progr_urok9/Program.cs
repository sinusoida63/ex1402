// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int GetValue(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

string numbersFromNToOne(int number)
{
  if (number > 0) return $"|{number}|" + numbersFromNToOne(number - 1);
  else return String.Empty;
}

int n = GetValue("Введите значение N: ");
Console.Write(numbersFromNToOne(n));