using System;


namespace DivingInCSharpDotNetAndVSCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");
            string expression = Console.ReadLine();

            string num1 = "";
            string num2 = "";
            string arithOp = "";
            int i = 0;
            while (i < expression.Length)
            {
                if (expression[i] >= '0' && expression[i] <= '9')
                {
                    num1 += expression[i];
                }
                else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/')
                {
                    arithOp = expression[i].ToString();
                    i++;
                    break;
                }
                i++;
            }
            while (i < expression.Length)
            {
                if (expression[i] >= '0' && expression[i] <= '9')
                {
                    num2 += expression[i];
                }
                i++;
            }

            if (string.IsNullOrEmpty(arithOp) || string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2))
            {
                Console.WriteLine("Ошибка! Неверный формат выражения!");
                return;
            }

            double result = 0;
            if (arithOp == "+")
            {
                result = double.Parse(num1) + double.Parse(num2);
            }
            else if (arithOp == "-")
            {
                result = double.Parse(num1) - double.Parse(num2);
            }
            else if (arithOp == "*")
            {
                result = double.Parse(num1) * double.Parse(num2);
            }
            else if (arithOp == "/")
            {
                if (double.Parse(num2) != 0)
                {
                    result = double.Parse(num1) / double.Parse(num2);
                }
                else
                {
                    Console.WriteLine("Ошибка! На ноль не делим!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Неизвестный оператор!");
                return;
            }
            Console.WriteLine("Результат: " + result);
        }
    }
}