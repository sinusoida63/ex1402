// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetValue(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int SumRec(int number1, int number2)
{
  if (number2 == number1 - 1) return 0;
  else return number2 + SumRec(number1, number2 - 1);
}

int m = GetValue("Введите значение M: ");
int n = GetValue("Введите значение N: ");

Console.WriteLine($"\nСумма натуральных чисел в промежутке от {m} до {n} = {SumRec(m, n)}");