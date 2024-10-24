Console.Write("Введите номер вызываемой функции: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
    Console.WriteLine("Ответ = " + RightTriangleArea().ToString());
else if (num == 2)
    Console.WriteLine("Ответ = " + SquareAreaOrPerimeter().ToString());
else if (num == 3)
    Console.WriteLine("Ответ = " + TrapezoidAreaOrPerimeter().ToString());
else if (num == 4)
    Console.WriteLine("Ответ = " + TriangeAreaOrPerimeter().ToString());
else
    Console.WriteLine("Ошибка. Закрытие программы");
double RightTriangleArea()
{
    Console.Write("Введите первый катет прямоугольного треугольника: ");
    double leg1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите второй катет прямоугольного треугольника: ");
    double leg2 = Convert.ToDouble(Console.ReadLine());
    return (leg1 * leg2) / 2;
}
double SquareAreaOrPerimeter()
{
    Console.Write("Введите длину стороны квадрата: ");
    double side_len = Convert.ToDouble(Console.ReadLine());
    char symb = OperationChoice();
    if (symb == 's')
        return side_len * 2;
    else if (symb == 'r')
        return side_len * 4;
    else
    {
        Console.WriteLine("Ошибка. Закрытие программы");
        return 0;
    }
}
double TrapezoidAreaOrPerimeter()
{
    char symb = OperationChoice();
    if (symb == 's')
    {
        Console.Write("Введите первую сторону трапеции: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вторую сторону трапеции: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту трапеции: ");
        double h = Convert.ToDouble(Console.ReadLine());

        return a * b / 2 * h;
    }
    else if (symb == 'r')
    {
        Console.Write("Введите первую сторону трапеции: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вторую сторону трапеции: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третью сторону трапеции: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите четвёртую сторону трапеции: ");
        double d = Convert.ToDouble(Console.ReadLine());

        return a + b + c + d;
    }
    else
    {
        Console.WriteLine("Ошибка. Закрытие программы");
        return 0;
    }
}

double TriangeAreaOrPerimeter()
{
    char symb = OperationChoice();
    if (symb == 's')
    {
        Console.Write("Введите длину основания треугольника: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту треугольника: ");
        double h = Convert.ToDouble(Console.ReadLine());

        return a * h / 2;
    }
    else if (symb == 'r')
    {
        Console.Write("Введите первую сторону треугольника: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вторую сторону треугольника: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третью сторону треугольника: ");
        double c = Convert.ToDouble(Console.ReadLine());

        return a + b + c;
    }
    else
    {
        Console.WriteLine("Ошибка. Закрытие программы");
        return 0;
    }
}
char OperationChoice()
{
    Console.Write("Введите символ операции(s/p): ");
    char symbol = Convert.ToChar(Console.ReadLine());
    Char.ToLower(symbol);
    return symbol;
}