using System;




class Program
{
   
    static void Main(string[] args)
    {
        Console.Title = "Task01";
        double side1, side2;
        while (true)
        {
            Console.Write("Введіть довжину першої сторони прямокутника: ");
            if (double.TryParse(Console.ReadLine(), out side1) && side1 > 0)
                break;
            else
                Console.WriteLine("Неправильний ввід. Будь ласка, введіть додатнє число.");
        }

        while (true)
        {
            Console.Write("Введіть довжину другої сторони прямокутника: ");
            if (double.TryParse(Console.ReadLine(), out side2) && side2 > 0)
                break;
            else
                Console.WriteLine("Неправильний ввід. Будь ласка, введіть додатнє число.");
        }

        Rectangle rectangle = new Rectangle(side1, side2);
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

        Console.ReadLine();
    }
}