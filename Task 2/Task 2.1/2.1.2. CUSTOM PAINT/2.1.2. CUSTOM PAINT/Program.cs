using System;
using System.Collections.Generic;

namespace _2._1._2._CUSTOM_PAINT
{
    class Program
    {
        static List<Figure> figures = new List<Figure>();
        static void Main(string[] args)
        {
            List<string> figureNames = new List<string>() { "1.Окружность", "2.Круг", "3.Кольцо", "4.Квадрат", "5.Прямоугольник", "6.Треугольник", "7.Линия" };

            while (true)
            {
                Console.WriteLine($"Выберите действие:" + Environment.NewLine + "1.Добавить фигуру" + Environment.NewLine +
                   "2.Вывести фигуры" + Environment.NewLine + "3.Очистить холст" + Environment.NewLine + "4.Выход" + Environment.NewLine);
                bool correct = int.TryParse(Console.ReadLine(), out int input);
                if (!correct)
                {
                    Console.WriteLine("Некорректный ввод!");
                    continue;
                }
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Выберите тип фигуры:");
                        foreach (string item in figureNames)
                        {
                            Console.WriteLine(item);
                        }
                        AddFigure();
                        break;
                    case 2:
                        if (figures.Count == 0)
                        {
                            Console.WriteLine("У вас нет созданных фигур!");
                        }
                        foreach (var item in figures)
                        {
                            Console.WriteLine(item.GetInformation());
                        }
                        break;
                    case 3:
                        figures.Clear();
                        Console.WriteLine("Память очищена!");
                        break;
                    case 4:
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        break;
                }
            }
        }

        private static void AddFigure()
        {
            int.TryParse(Console.ReadLine(), out int input);
            switch (input)
            {
                case 1:
                    Console.WriteLine("Введите параметры фигуры окружность:");
                    Console.WriteLine("Введите координыт центра:");
                    Console.Write("X: ");
                    bool correctX = int.TryParse(Console.ReadLine(), out int x);
                    Console.Write("Y: ");
                    bool correctY = int.TryParse(Console.ReadLine(), out int y);
                    Console.Write("Введите радиус: ");
                    bool correctR = int.TryParse(Console.ReadLine(), out int r);
                    if (correctX && correctY && correctR)
                    {
                        Circle circle = new(new Point(x, y), r);
                        figures.Add(circle);
                        SuccessfullyCreated("окружность");
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите параметры фигуры круг:");
                    Console.WriteLine("Введите координыт центра:");
                    Console.Write("X: ");
                    bool correctXRound = int.TryParse(Console.ReadLine(), out int xRound);
                    Console.Write("Y: ");
                    bool correctYRound = int.TryParse(Console.ReadLine(), out int yRound);
                    Console.Write("Введите радиус: ");
                    bool correctRRound = int.TryParse(Console.ReadLine(), out int rRound);
                    if (correctXRound && correctYRound && correctRRound)
                    {
                        Round round = new(new Point(xRound, yRound), rRound);
                        figures.Add(round);
                        SuccessfullyCreated("круг");
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите параметры фигуры кольцо:");
                    Console.WriteLine("Введите координыт центра:");
                    Console.Write("X: ");
                    bool correctXRing = int.TryParse(Console.ReadLine(), out int xRing);
                    Console.Write("Y: ");
                    bool correctYRing = int.TryParse(Console.ReadLine(), out int yRing);
                    Console.Write("Введите внешний радиус: ");
                    bool correctR1Ring = int.TryParse(Console.ReadLine(), out int r1Ring);
                    Console.Write("Введите внутренний радиус: ");
                    bool correctR2Ring = int.TryParse(Console.ReadLine(), out int r2Ring);
                    if (correctXRing && correctYRing && correctR1Ring && correctR2Ring)
                    {
                        Ring ring = new(new Point(xRing, yRing), r1Ring, r2Ring);
                        figures.Add(ring);
                        SuccessfullyCreated("кольцо");
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите параметры фигуры квадрат:");
                    Console.WriteLine("Введите координыт центра:");
                    Console.Write("X: ");
                    bool correctXSquare = int.TryParse(Console.ReadLine(), out int xSquare);
                    Console.Write("Y: ");
                    bool correctYSquare = int.TryParse(Console.ReadLine(), out int ySquare);
                    Console.Write("Введите длину стороны: ");
                    bool correctSSquare = int.TryParse(Console.ReadLine(), out int sSquare);
                    if (correctXSquare && correctYSquare && correctSSquare)
                    {
                        Square square = new(new Point(xSquare, ySquare), sSquare);
                        figures.Add(square);
                        SuccessfullyCreated("квадрат");
                    }
                    break;
                case 5:
                    Console.WriteLine("Введите параметры фигуры прямоугольник:");
                    Console.WriteLine("Введите координыт центра:");
                    Console.Write("X: ");
                    bool correctXRectangle = int.TryParse(Console.ReadLine(), out int xRectangle);
                    Console.Write("Y: ");
                    bool correctYRectangle = int.TryParse(Console.ReadLine(), out int yRectangle);
                    Console.Write("Введите длину: ");
                    bool correctS1Rectangle = int.TryParse(Console.ReadLine(), out int s1Rectangle);
                    Console.Write("Введите ширину: ");
                    bool correctS2Rectangle = int.TryParse(Console.ReadLine(), out int s2Rectangle);
                    if (correctXRectangle && correctYRectangle && correctS1Rectangle && correctS2Rectangle)
                    {
                        Rectangle rectangle = new(new Point(xRectangle, yRectangle), s1Rectangle, s2Rectangle);
                        figures.Add(rectangle);
                        SuccessfullyCreated("прямоугольник");
                    }
                    break;
                case 6:
                    Console.WriteLine("Введите параметры фигуры треугольник:");
                    Console.WriteLine("Введите координыт центра:");
                    Console.Write("X: ");
                    bool correctXTriangle = int.TryParse(Console.ReadLine(), out int xTriangle);
                    Console.Write("Y: ");
                    bool correctYTriangle = int.TryParse(Console.ReadLine(), out int yTriangle);
                    Console.Write("Введите сторону 1: ");
                    bool correctS1Triangle = int.TryParse(Console.ReadLine(), out int s1Triangle);
                    Console.Write("Введите сторону 2: ");
                    bool correctS2Triangle = int.TryParse(Console.ReadLine(), out int s2Triangle);
                    Console.Write("Введите сторону 3: ");
                    bool correctS3Triangle = int.TryParse(Console.ReadLine(), out int s3Triangle);
                    if (correctXTriangle && correctYTriangle && correctS1Triangle && correctS2Triangle && correctS3Triangle)
                    {
                        Triangle triangle = new(new Point(xTriangle, yTriangle), s1Triangle, s2Triangle, s3Triangle);
                        figures.Add(triangle);
                        SuccessfullyCreated("треугольник");
                    }
                    break;
                case 7:
                    Console.WriteLine("Введите параметры фигуры линия:");
                    Console.WriteLine("Введите координыт центра:");
                    Console.Write("X: ");
                    bool correctXLine = int.TryParse(Console.ReadLine(), out int xLine);
                    Console.Write("Y: ");
                    bool correctYLine = int.TryParse(Console.ReadLine(), out int yLine);
                    Console.Write("Введите длину: ");
                    bool correctLLine = int.TryParse(Console.ReadLine(), out int lLine);
                    if (correctXLine && correctYLine && correctLLine)
                    {
                        Circle circle = new(new Point(xLine, yLine), lLine);
                        figures.Add(circle);
                        SuccessfullyCreated("линия");
                    }
                    break;
                default:
                    break;
            }
        }
        private static void SuccessfullyCreated(string name)
        {
            Console.WriteLine($"Фигура {name} успешно создана!");
        }
    }

    abstract class Figure
    {
        protected Point Coordinate;

        protected Figure(Point coordinate)
        {
            Coordinate = coordinate;
        }

        public abstract string GetInformation();

        public abstract double GetPerimeter();
    }

    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }



    abstract class Circleable : Figure
    {
        protected double radius;
        public Circleable(Point coordinate, double radius) : base(coordinate)
        {
            this.radius = radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    class Circle : Circleable
    {
        public Circle(Point coordinate, double radius) : base(coordinate, radius)
        {

        }

        public override string GetInformation()
        {
            return $"Окружность на координатах X: {Coordinate.X}, Y: {Coordinate.Y}, радиусом {radius} и длиной окружности {GetPerimeter()}";
        }
    }

    class Round : Circleable
    {
        public Round (Point coordinate, double radius) : base(coordinate, radius)
        {

        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string GetInformation()
        {
            return $"Круг на координатах X: {Coordinate.X}, Y: {Coordinate.Y}, радиусом {radius}, длиной окружности {GetPerimeter()} и площадью {GetArea()}";
        }
    }

    class Ring : Circleable
    {

        double innerRadius;

        public Ring (Point coordinate, double radius, double innerRadius) : base(coordinate, radius)
        {
            this.innerRadius = innerRadius;
        }

        public override double GetPerimeter()
        {
            return (2 * Math.PI * radius) + (2 * Math.PI * innerRadius);
        }

        public double GetArea()
        {
            return (Math.PI * Math.Pow(radius, 2)) - (Math.PI * Math.Pow(innerRadius, 2));
        }

        public override string GetInformation()
        {
            return $"Кольцо на координатах X: {Coordinate.X}, Y: {Coordinate.Y}, внешним радиусом {radius}, внутренним {innerRadius}, периметром {GetPerimeter()} и площадью {GetArea()}";
        }
    }

    class Square : Figure
    {
        double sideLength;

        public Square (Point coordinate, double sideLength) : base(coordinate)
        {
            this.sideLength = sideLength;
        }

        public override double GetPerimeter()
        {
            return 4 * sideLength;
        }

        public double GetArea()
        {
            return Math.Pow(sideLength, 2);
        }

        public override string GetInformation()
        {
            return $"Квадрат на координатах X: {Coordinate.X}, Y: {Coordinate.Y}, длиной стороны: {sideLength}, периметром {GetPerimeter()} и площадью {GetArea()}";
        }
    }

    class Rectangle : Figure
    {
        double sideLength1;
        double sideLength2;

        public Rectangle (Point coordinate, double sideLength1, double sideLength2) : base(coordinate)
        {
            this.sideLength1 = sideLength1;
            this.sideLength2 = sideLength2;
        }

        public override string GetInformation()
        {
            return $"Прямоугольник на координатах X: {Coordinate.X}, Y: {Coordinate.Y}, длиной  1 стороны: {sideLength1}, длиной  2 стороны: {sideLength2}, периметром {GetPerimeter()} и площадью {GetArea()}";
        }

        public double GetArea()
        {
            return sideLength1 * sideLength2;
        }

        public override double GetPerimeter()
        {
            return (sideLength1 * 2) + (sideLength2 * 2);
        }
    }

    class Triangle : Figure
    {
        double sideLength1;
        double sideLength2;
        double sideLength3;

        public Triangle (Point coordinate, double sideLength1, double sideLength2, double sideLength3) : base(coordinate)
        {
            this.sideLength1 = sideLength1;
            this.sideLength2 = sideLength2;
            this.sideLength3 = sideLength3;
        }

        public override string GetInformation()
        {
            return $"Треугольник на координатах X: {Coordinate.X}, Y: {Coordinate.Y}, длинами сторон: {sideLength1}, {sideLength2}, {sideLength3}, периметром {GetPerimeter()} и площадью {GetArea()}";
        }

        public override double GetPerimeter()
        {
            return sideLength1 + sideLength2 + sideLength3;
        }

        public double GetArea()
        {
            double p = (sideLength1 + sideLength2 + sideLength3) / 2;
            return Math.Sqrt(p * (p - sideLength1) * (p - sideLength2) * (p - sideLength3));
        }
    }

    class Line : Figure
    {
        double length;

        public Line (Point coordinate, double length) : base(coordinate)
        {
            this.length = length;
        }

        public override string GetInformation()
        {
            return $"Линия на координатах X: {Coordinate.X}, Y: {Coordinate.Y} и длиной {GetPerimeter()}";
        }

        public override double GetPerimeter()
        {
            return length;
        }
    }
}
