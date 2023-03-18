// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetValue(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

double functionAkkerman(double number1, double number2)
{
  if (number1 == 0) return number2 + 1;
  else if (number1 > 0 && number2 == 0)
    return functionAkkerman(number1 - 1, 1);
  else return functionAkkerman(number1 - 1, functionAkkerman(number1, number2 - 1));
}

int m = GetValue("Введите значение m: ");
int n = GetValue("Введите значение n: ");
Console.WriteLine($"\nA({m},{n}) = {functionAkkerman(m, n)}");
