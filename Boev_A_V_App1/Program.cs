Console.Write("Введите номер вызываемой функции: "); // Вызов методов
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("Ответ = " + RightTriangleArea().ToString());
        break;
    case 2:
        Console.WriteLine("Ответ = " + SquareAreaOrPerimeter().ToString());
        break;
    case 3:
        Console.WriteLine("Ответ = " + TrapezoidAreaOrPerimeter().ToString());
        break;
    case 4:
        Console.WriteLine("Ответ = " + TriangeAreaOrPerimeter().ToString());
        break;
    default:
        Console.WriteLine("Ошибка. Закрытие программы");
        break;
}

double RightTriangleArea()                            // Площадь прямоугольного треугольника 
{
    Console.Write("Введите первый катет прямоугольного треугольника: ");
    double leg1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите второй катет прямоугольного треугольника: ");
    double leg2 = Convert.ToDouble(Console.ReadLine());
    return (leg1 * leg2) / 2;
}
double SquareAreaOrPerimeter()                         // Площадь и периметр квадрата
{
    Console.Write("Введите длину стороны квадрата: ");
    double side_len = Convert.ToDouble(Console.ReadLine());
    char symb = OperationChoice();
    if (symb == 's')
        return side_len * 2;
    else if (symb == 'p')
        return side_len * 4;
    else
    {
        Console.WriteLine("Ошибка. Закрытие программы");
        return 0;
    }
}
double TrapezoidAreaOrPerimeter()                     // Площадь и периметр трапеции
{
    Console.Write("Введите первое основание трапеции: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите второе основание трапеции: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите первую сторону трапеции: ");
    double c = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите вторую сторону трапеции: ");
    double d = Convert.ToDouble(Console.ReadLine());
    char symb = OperationChoice();
    if (symb == 's')
    {
        double part1 = (a + b) / 2;
        double part2 = (Math.Pow(c, 2));
        double part3 = (Math.Pow((b - a), 2));
        double part4 = Math.Pow(c, 2);
        double part5 = Math.Pow(d, 2);
        double part6 = 2 * (b - a);
        double part7 = part3 + part4 - part5;
        double part8 = part7 / part6;
        double part9 = part2 - part8;
        double part10 = Math.Sqrt(part9);
        double part11 = part1 * part10;

        return part11;
    }
    else if (symb == 'p')
    {
        return a + b + c + d;
    }
    else
    {
        Console.WriteLine("Ошибка. Закрытие программы");
        return 0;
    }
}

double TriangeAreaOrPerimeter()                        // Площадь и периметр треугольника
{
    Console.Write("Введите первую сторону треугольника: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите вторую сторону треугольника: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите третью сторону треугольника: ");
    double c = Convert.ToDouble(Console.ReadLine());
    char symb = OperationChoice();
    if (symb == 's')
    {
        double p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    else if (symb == 'p')
    {
        return a + b + c;
    }
    else
    {
        Console.WriteLine("Ошибка. Закрытие программы");
        return 0;
    }
}
char OperationChoice()                                // Выбор между поиском площади или периметра
{
    Console.Write("Введите символ операции(s/p): ");
    char symbol = Convert.ToChar(Console.ReadLine());
    Char.ToLower(symbol);
    return symbol;
}