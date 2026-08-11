using System;

public class Program // Objeto publico de classe Programa
{
    static int verify_quadrant(double A, double B)
    {
        int pos;
        if (A > 0 & B > 0)
        {
            pos = 1;
        }
        else if (A < 0 & B > 0)
        {
            pos = 2;
        }
        else if (A < 0 & B < 0)
        {
            pos = 3;
        }
        else
        {
            pos = 4;
        }
        return pos;
    }

    public static void Main() // Objeto publico estatico tipo void
    {

        double x, y;

        Console.WriteLine("Welcome");

        Console.Write("Write the X position: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {

            Console.WriteLine("Invalid number!");
            Console.Write("Write the X position:  ");

        }
        Console.WriteLine("Sucess X position is " + x);

        Console.Write("Write the Y position: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {

            Console.WriteLine("Invalid number!");
            Console.Write("Write the Y position: ");

        }
        Console.WriteLine("Sucess Y position saved: " + y);

        int quadrant = verify_quadrant(x, y);

        Console.WriteLine("The position is: " + x + "," + y + " and the quadrant is " + quadrant);

    }
}