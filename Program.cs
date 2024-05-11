using System;

class StringProcessor
{
    static void Main()
    {
        // Получение количества строк от пользователя
        int numberOfStrings = GetNumberOfStrings();

        // Создание массива для хранения строк
        string[] inputStrings = new string[numberOfStrings];

        // Считывание строк от пользователя
        ReadInputStrings(inputStrings);

        // Фильтрация строк по длине (<= 3 символа)
        string[] filteredStrings = FilterShortStrings(inputStrings);

        // Отображение результатов
        DisplayResults(inputStrings, filteredStrings);
    }

    static int GetNumberOfStrings()
    {
        Console.Write("Введите количество строк: ");
        int inputNumber;

        while (!int.TryParse(Console.ReadLine(), out inputNumber) || inputNumber <= 0)
        {
            Console.WriteLine("Необходимо ввести положительное целое число.");
            Console.Write("Введите количество строк: ");
        }

        return inputNumber;
    }

    static void ReadInputStrings(string[] strings)
    {
        for (int i = 0; i < strings.Length; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            strings[i] = Console.ReadLine();
        }
    }

    static string[] FilterShortStrings(string[] inputStrings)
    {
        int shortStringCount = 0;

        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                shortStringCount++;
            }
        }

        string[] filteredStrings = new string[shortStringCount];
        int index = 0;

        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                filteredStrings[index] = str;
                index++;
            }
        }

        return filteredStrings;
    }

    static void DisplayResults(string[] inputStrings, string[] filteredStrings)
    {
        Console.WriteLine("\nИсходный массив строк:");
        foreach (string str in inputStrings)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\nНовый массив с короткими строками (<= 3 символов):");
        foreach (string str in filteredStrings)
        {
            Console.WriteLine(str);
        }
    }
}
