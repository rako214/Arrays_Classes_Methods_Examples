using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа для сложения");
            int firstNumber = inputNumber(1);
            int secondNumber = inputNumber(2);
            Console.WriteLine("Сумма: " + Sum(firstNumber,secondNumber));
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int inputNumber(int x)
        {
            Console.WriteLine($"Введите {x} число: ");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
