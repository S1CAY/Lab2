using System;



class Program
{
    static void Main(string[] args)
    {
        Point[] points = new Point[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Введіть координати точки {i + 1} (x y): ");
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length != 2 || !double.TryParse(input[0], out double x) || !double.TryParse(input[1], out double y))
            {
                Console.WriteLine("Неправильний ввід. Будь ласка, введіть координати у форматі 'x y'.");
                i--;
                continue;
            }

            points[i] = new Point(x, y, $"Точка {i + 1}");
        }

        Figure figure = null;

        switch (points.Length)
        {
            case 3:
                figure = new Figure(points[0], points[1], points[2]);
                break;
            case 4:
                figure = new Figure(points[0], points[1], points[2], points[3]);
                break;
            case 5:
                figure = new Figure(points[0], points[1], points[2], points[3], points[4]);
                break;
            default:
                Console.WriteLine("Багатокутник може мати від 3 до 5 точок.");
                break;
        }

        if (figure != null)
        {
            figure.CalculatePerimeter();
        }

        Console.ReadLine(); 
    }
}
