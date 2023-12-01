using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число (или 'q' для выхода): ");
            string input = Console.ReadLine();

            // Проверяем, если введен 'q', завершаем программу
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            // Пытаемся преобразовать введенную строку в целое число
            if (int.TryParse(input, out int number))
            {
                // Проверяем, если сумма цифр числа четная
                if (IsSumEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {number} нечетная.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
            }
        }
    }

    static bool IsSumEven(int num)
    {
        int sum = 0;
        // Вычисляем сумму цифр числа
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        // Проверяем, четная ли сумма
        return sum % 2 == 0;
    }
}

