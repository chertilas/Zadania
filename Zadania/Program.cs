using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Задача 1
        Console.WriteLine("Задача 1: Сравнение двух чисел");
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2)
        {
            Console.WriteLine("Числа равны");
        }
        else if (num1 > num2)
        {
            Console.WriteLine("Первое число больше второго");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго");
        }

        // Задача 2
        Console.WriteLine("Задача 2: Проверка числа в диапазоне от 5 до 10");
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 5 && num <= 10)
        {
            Console.WriteLine("Число больше 5 и меньше 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }

        // Задача 3
        Console.WriteLine("Задача 3: Проверка числа на равенство 5 или 10");
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num == 5 || num == 10)
        {
            Console.WriteLine("Число либо равно 5, либо равно 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }

        // Задача 4
        Console.WriteLine("Задача 4: Расчет суммы вклада с процентами");
        Console.Write("Введите сумму вклада: ");
        double deposit = Convert.ToDouble(Console.ReadLine());
        double rate;

        if (deposit < 100)
        {
            rate = 0.05;
        }
        else if (deposit <= 200)
        {
            rate = 0.07;
        }
        else
        {
            rate = 0.10;
        }

        double finalAmount = deposit + (deposit * rate);
        Console.WriteLine($"Сумма вклада с процентами: {finalAmount}");

        // Задача 5
        Console.WriteLine("Задача 5: Выбор операции");
        Console.WriteLine("Введите номер операции: 1. Сложение 2. Вычитание 3. Умножение");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Операция: Сложение");
                break;
            case 2:
                Console.WriteLine("Операция: Вычитание");
                break;
            case 3:
                Console.WriteLine("Операция: Умножение");
                break;
            default:
                Console.WriteLine("Операция неопределена");
                break;
        }

        // Задача по циклам 1
        Console.WriteLine("Задача по циклам 1: Расчет суммы вклада с ежемесячными процентами");
        Console.Write("Введите сумму вклада: ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < months; i++)
        {
            depositAmount += depositAmount * 0.07M;
        }

        Console.WriteLine($"Конечная сумма вклада: {depositAmount}");

        // Задача по циклам 2
        Console.WriteLine("Задача по циклам 2: Таблица умножения");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }

        // Задача по циклам 3
        Console.WriteLine("Задача по циклам 3: Произведение чисел в диапазоне от 0 до 10");
        while (true)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && a <= 10 && b >= 0 && b <= 10)
            {
                Console.WriteLine($"Произведение чисел: {a * b}");
                break;
            }
            else
            {
                Console.WriteLine("Введенные числа недопустимы. Введите числа снова.");
            }
        }

        // Задачи по массивам 1
        Console.WriteLine("Задачи по массивам 1: Нечетные числа из массива");
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Нечетные числа: ");
        foreach (var number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
            }
        }

        // Задачи по массивам 2
        Console.WriteLine("Задачи по массивам 2: Поиск строки в массиве");
        string[] stringArray = { "apple", "banana", "cherry" };
        Console.Write("Введите строку для поиска: ");
        string searchString = Console.ReadLine();

        if (stringArray.Contains(searchString))
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }

        // Задачи по массивам 3
        Console.WriteLine("Задачи по массивам 3: Сумма и среднее арифметическое элементов массива");
        int[] array = { 1, 2, 3, 4, 5 };
        int sum = array.Sum();
        double average = array.Average();

        Console.WriteLine($"Сумма элементов массива: {sum}");
        Console.WriteLine($"Среднее арифметическое элементов массива: {average}");

        Console.ReadLine();
    }
}
