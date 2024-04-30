using System;
using System.Threading;
public class KhinkaliWithCheeseAndMushrooms
{

    public double Flour { get; set; }
    public double Water { get; set; }
    public double Salt { get; set; }


    public double Mushrooms { get; set; }
    public double Cheese { get; set; }
    public double Onion { get; set; }
    public double Butter { get; set; }
    public double SaltAndPepper { get; set; }


    public KhinkaliWithCheeseAndMushrooms(double flour, double water, double salt, double mushrooms, double cheese, double onion, double butter, double saltAndPepper)
    {
        Flour = flour;
        Water = water;
        Salt = salt;
        Mushrooms = mushrooms;
        Cheese = cheese;
        Onion = onion;
        Butter = butter;
        SaltAndPepper = saltAndPepper;
    }


    public string PrepareDough()
    {
        return "Тесто для хинкали готово!";
    }

    public string PrepareFilling()
    {
        return "Начинка из грибов и сыра готова!";
    }

    public string FormKhinkali()
    {
        return "Хинкали сформированы!";
    }

    public string CookKhinkali()
    {
        return "Хинкали с сыром и грибами готовы!";
    }
}

public class AdditionOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
public class SubtractionOperations
{
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}
public class MultiplicationOperations
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}
public class DivisionOperations
{
    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Нельзя делить на ноль.");
        }
        return a / b;
    }

    public static int Modulo(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Нельзя делить на ноль.");
        }
        return a % b;
    }
}

public class Wordls
{
    static void Main(string[] args)
    {

        KhinkaliWithCheeseAndMushrooms khinkali = new KhinkaliWithCheeseAndMushrooms(500, 250, 10, 200, 150, 50, 30, 5);


        string dough = khinkali.PrepareDough();
        string filling = khinkali.PrepareFilling();
        int result = AdditionOperations.Add(5, 3);
        Console.WriteLine(result);
        result = SubtractionOperations.Subtract(10, 4);
        Console.WriteLine(result);
        result = MultiplicationOperations.Multiply(2, 7);
        Console.WriteLine(result);
        result = DivisionOperations.Divide(15, 3);
        Console.WriteLine(result);
        result = DivisionOperations.Modulo(17, 5);
        Console.WriteLine(result);

        Console.WriteLine(dough);
        Console.WriteLine(filling);
        Thread.Sleep(2000);
    }
}