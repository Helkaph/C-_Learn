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
        Trapezoid trapez = new Trapezoid();
        trapez.TrapezoidAreaOrPerimeter();
        Console.WriteLine("Ответ = " + trapez.Result.ToString());
        break;
    case 4:
        Console.WriteLine("Ответ = " + Triangle.TriangeAreaOrPerimeter().ToString());
        break;
    case 5:
        Console.WriteLine("Ответ = " + FiguresVolume().ToString());
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
    char symb = AdditionalFunc.OperationChoice();
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



double FiguresVolume()
{
    Console.Write("Введите номер желаемой фигуры для расчёта объёма: ");
    int figure = Convert.ToInt32(Console.ReadLine());
    switch (figure)
    {
        case 1:
            Console.WriteLine("Выбран куб.");
            Console.Write("Введите длину стороны куба: ");
            double a = Convert.ToDouble(Console.ReadLine());
            return Math.Pow(a, 3);
        case 2:
            Console.WriteLine("Выбрана призма.");
            return AdditionalFunc.BaseChoice() * AdditionalFunc.Height();
        case 3:
            Console.WriteLine("Выбран параллепипед.");
            Parallelepiped paral = new Parallelepiped(false);
            return paral.s * AdditionalFunc.Height();
        case 4:
            Console.WriteLine("Выбран прямоугольный параллепипед.");
            Parallelepiped paral2 = new Parallelepiped(true);
            return paral2.s * AdditionalFunc.Height();
        case 5:
            Console.WriteLine("Выбрана пирамида.");
            return AdditionalFunc.BaseChoice() * AdditionalFunc.Height();
        case 6:
            Console.WriteLine("Выбран правильный тетраэдр.");
            Console.Write("Введите длину стороны тетраэдра: ");
            double tet = Convert.ToDouble(Console.ReadLine());
            return Math.Pow(tet, 2) * Math.Sqrt(Convert.ToDouble(3));
        case 7:
            Console.WriteLine("Выбран цилиндр.");
            Circle cil = new Circle();
            return cil.s * AdditionalFunc.Height();
        case 8:
            Console.WriteLine("Выбран конус.");
            Circle con = new Circle();
            return con.s * AdditionalFunc.Height() * 1/3;
        case 9:
            Console.WriteLine("Выбран шар");
            Circle sph = new Circle();
            return sph.s * sph.r * 4/3;
        default:
            Console.WriteLine("Ошибка. Закрытие программы");
            return 0;
    }
        
}


class Triangle
{
    public static double TriangeAreaOrPerimeter()                        // Площадь и периметр треугольника
    {
        Console.Write("Введите первую сторону треугольника: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вторую сторону треугольника: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третью сторону треугольника: ");
        double c = Convert.ToDouble(Console.ReadLine());
        char symb = AdditionalFunc.OperationChoice();
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
    public static double TriangeAreaOrPerimeter(double a, double b, double c) // Перегрузка для призмы
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}
class Trapezoid
{
    private double a;
    private double b;
    private double c;
    private double d;
    public double Result;

    public Trapezoid()
    {
        Console.Write("Введите первое основание трапеции: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе основание трапеции: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите первую сторону трапеции: ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вторую сторону трапеции: ");
        d = Convert.ToDouble(Console.ReadLine());
        SquareMath();
    }
    public void TrapezoidAreaOrPerimeter()                     // Площадь и периметр трапеции
    {
        
        char symb = AdditionalFunc.OperationChoice();
        if (symb == 's')
        {

        SquareMath();
        }
        else if (symb == 'p')
        {
           Result = a + b + c + d;
        }
        else
        {
            Console.WriteLine("Ошибка. Закрытие программы");
        }
    }
    public void SquareMath()          // Подсчёт площади трапеции
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
        Result =  part1 * part10;
    }
}
class Parallelepiped
{
    private double a;
    private double b;
    private double h;
    public double s;

    public Parallelepiped(bool rightangle)                                 // конструктор параллепипеда с автоматическим подсчётом площади основания
    {
        Console.Write("Введите длину основания параллепипеда: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите ширину основания параллепипеда: ");  
        b = Convert.ToDouble(Console.ReadLine());
        if (rightangle)
            s = a * b;
        else
        {
            Console.Write("Введите высоту основания параллепипеда: ");
            h = Convert.ToDouble(Console.ReadLine());
            s = a * h;
        }
    }
}
class Circle
{
    public double r;
    public double s;

    public Circle()
    {
        Console.Write("Введите радиус круга: ");
        r = Convert.ToDouble(Console.ReadLine());
        s = Math.Pow(r, 2) * Math.PI;
    }
}
public partial class AdditionalFunc
{
    public static char OperationChoice()                                // Выбор между поиском площади или периметра
    {
        Console.Write("Введите символ операции(s/p): ");
        char symbol = Convert.ToChar(Console.ReadLine());
        Char.ToLower(symbol);
        return symbol;
    }
    public static double BaseChoice()
    {
        Console.Write("Выберите фигуру основания(3/4-угольник): ");
        int angle = Convert.ToInt32(Console.ReadLine());
        switch (angle)
        {
            case 3:
                Console.Write("Введите первую сторону треугольника: ");
                double tr1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите вторую сторону треугольника: ");
                double tr2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите третью сторону треугольника: ");
                double tr3 = Convert.ToDouble(Console.ReadLine());
                return Triangle.TriangeAreaOrPerimeter(tr1, tr2, tr3);
            case 4:
                Console.Write("Выберите тип фигуры основания(p/r/t): ");
                char symbol = Convert.ToChar(Console.ReadLine());
                switch (symbol)
                {
                    case 'p':
                        Console.Write("Введите первую сторону: ");
                        double pr1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите вторую сторону: ");
                        double pr2 = Convert.ToDouble(Console.ReadLine());
                        return pr1 * pr2;
                    case 'r':
                        Console.Write("Введите первую сторону: ");
                        double d1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите вторую сторону: ");
                        double d2 = Convert.ToDouble(Console.ReadLine());
                        return d1 * d2 / 2;
                    case 't':
                        Trapezoid trap = new Trapezoid();
                        return trap.Result;
                    default:
                        Console.WriteLine("Ошибка. Закрытие программы");
                        return 0;
                }
            default:
                Console.WriteLine("Ошибка. Закрытие программы");
                return 0;
        }
    }
    public static double Height()
    {
        Console.Write("Введите высоту фигуры: ");
        double height = Convert.ToDouble(Console.ReadLine());
        return height;
    }
}