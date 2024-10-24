using System.Globalization;
using System;
using System.Text;

void AryphmaticFunc()
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Сумма: " + (num1 + num2).ToString() + ", Разность: " + (num1 - num2).ToString() + ", Произведение: " + (num1 * num2).ToString() + ", Частное: " + (num1 / num2).ToString());
    }
void EvenOrOdd()
{
    Console.Write("Введите число: ");
    double num = Convert.ToDouble(Console.ReadLine());
    if (num % 2 == 0)
        Console.WriteLine("Чётное число.");
    else
        Console.WriteLine("Нечётное число.");
}
void Factorial()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
        res *= i;
    }
    Console.WriteLine(res);
}
void Sort()
{
    Console.Write("Введите размер списка: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] nums = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("[" +  i + "]: ");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < size;i++)
    {
        for (int j = 0; j < size - 1; j++)
        {
            if (nums[j] > nums[j + 1])
            {
                int temp = nums[j];
                nums[j] = nums[j + 1];
                nums[j + 1] = temp;
            }
        }
    }
    for (int i = 0; i < size; ++i)
    {
        Console.WriteLine(nums[i]);
    }
}
void Palindrom()
{
    Console.Write("Введите слово: ");
    string word = Console.ReadLine();
    bool Palind = false;
    for (int i = 0; i < word.Length / 2 ; i++)
            if (word[i] == word[word.Length - i - 1])
                Palind = true;
            else
                Palind = false;
    if (Palind == true)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
    Console.WriteLine(word);
}
void ArraySum()
{
    Console.Write("Введите размер списка: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("[" + i + "]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    int res = 0;
    for (int i = 0; i < size;i++)
    {
        res += array[i];
    }
    Console.WriteLine(res);
}
void Fibonacchi()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[num];
    int previous = -1;
    int result = 1;
    for (int i = 0; i < num; i++)
    {
        int sum = result + previous;
        array[i] = sum;
        previous = result;
        result = array[i];
    }

    for (int i = 0; i < num; i++)
        Console.WriteLine("[" + i + "]: " + array[i]);
}
void OnlyUnique()
{
    Console.Write("Введите размер списка: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("[" + i + "]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    int[] res = array.Distinct().ToArray();
    for (int i = 0;i < res.Length; i++)
        Console.WriteLine("[" + i + "]: " + res[i]);
}
void Calculator()
{
    Console.Write("Введите первое число: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите оператор операции(+, -, *, /): ");
    char symb = Convert.ToChar(Console.ReadLine());
    Console.Write("Введите второе число: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double res = 0;
    switch (symb)
    {
        case '+':
            res = num1 + num2;
            break;
        case '-':
            res = num1 - num2;
            break;
        case '*':
            res = num1 * num2;
            break;
        case '/':
            if (num2 != 0)
                res = num1 / num2;
            else
                Console.WriteLine("Деление невозможно");
            break;
    }
    Console.WriteLine(res);
}
void Prime()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    List<int> primes = new List<int> { };
    for (int i = 1; i < num + 1; i++)
    {
        for (int j = 2; j < num;j++)
            if (i % j == 0)
            {
                break;
            }
            else
            {
                primes.Add(i);
            }
    }
    int[] array = primes.ToArray<int>();
    int[] res = array.Distinct().ToArray();
    for (int i = 0;i < res.Length;i++)
        Console.WriteLine("[" + i + "]: " + res[i]);
}

void TimeZone()
{

    int[] times = { 800, 1200, 1600, 2000 };
    int diff;

    Console.Write("Введите часовой пояс: ");
    int currentGMT = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Текущее время: ");
    TimeDisplay();
    Console.WriteLine();
    Console.Write("Введите новый часовой пояс: ");
    int newGMT = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Неверный часовой пояс");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        ConvertTime();        
    }
    else
    {
        ConvertTime();
    }
    Console.WriteLine("Новое время: ");

    TimeDisplay();
    Console.WriteLine();
    void TimeDisplay()
    {
        foreach (int elem in times)
        {
            string time = elem.ToString();
            int len = time.Length;
            if (len >= 3)
                time = time.Insert(len - 2, ":");
            else if (len == 2)
                time = time.Insert(0, "0:");
            else
                time = time.Insert(0, "0:0");
            Console.Write($"{time} ");
        }
    }
    void ConvertTime()
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
        for (int i = 0; i < times.Length; i++)
        {
            times[i] = (times[i] + diff) % 2400;
        }
    }
}
//AryphmaticFunc();
//EvenOrOdd();
//Factorial();
//Sort();
//Palindrom();
//ArraySum();
//Fibonacchi();
//OnlyUnique();
//Calculator();
//Prime();
TimeZone();