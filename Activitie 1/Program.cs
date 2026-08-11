using System;

public class Program // Objeto publico de classe Programa
{
    public static void Main() // Objeto publico estatico tipo void
    {

        float medium_stock, min_amount, max_amount;

        Console.WriteLine("Welcome");
        Console.Write("Write the minimum stock of this item: ");
        while (!float.TryParse(Console.ReadLine(), out min_amount))
        {

            Console.WriteLine("Invalid number!");
            Console.Write("Write the minimum stock of this item: ");

        }
        Console.WriteLine("Sucess minimium stock saved as: " + min_amount);
        Console.Write("Write the maximium stock of this item: ");
        while (!float.TryParse(Console.ReadLine(), out max_amount) || max_amount < min_amount)
        {

            Console.WriteLine("Invalid number!");
            Console.Write("Write the maximum stock of this item: ");

        }
        Console.WriteLine("Sucess maximum stock saved as: " + max_amount);
        Console.WriteLine("");
        medium_stock = (min_amount + max_amount) / 2;
        Console.WriteLine("The medium stock is: " + medium_stock);

    }
}