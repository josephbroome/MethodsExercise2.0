﻿// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {


        tellAStory();

        Console.WriteLine(Add(5, 6));
        Console.WriteLine(Multiply(7, 8));
        Console.WriteLine(Sum(5,6,7,8));    
        Console.WriteLine(Multiply(12,4,3));
        Console.WriteLine(Divide(12,4));
        Console.WriteLine(Division(12,4));
    
    
    }   

   public static void tellAStory()
    {
        Console.WriteLine("Hello, what is your name");
        var name=Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
        var favoriteColor=Console.ReadLine();
        Console.WriteLine("What is your favorite animal?");
        var favoriteAnimal=Console.ReadLine();
        Console.WriteLine("What is your favorite band?");
        var faveBand=Console.ReadLine();    

        Console.WriteLine($"There was once a person named {name}. {name}'s favorite color was {favoriteColor}."); 
        Console.WriteLine($"{name}'s favorite animal is a {favoriteAnimal} and his favorite band is {faveBand}");






    }

    public static int Add(int x, int y)
    {
        return x+ y;    
    }
    
    public static int Multiply(int x, int y)
    {
        return x*y;
    }

    public static int Sum(params int[] list)
    {
        int sum = 0;

        for(int x=0; x<list.Length; x++)
        {
            sum= sum+list[x];
        }

        return sum;
    }
    public static int Division(int x, int y)
    {
        return x / y;
    }
    public static int Multiply(params int[] list)
    {
        int sum = 1;

        for (int x=0; x<list.Length; x++)
        {
             sum*=list[x];

        }

        return sum;
                        


    }
   public static double Divide(params double[] list)
    {
        double divisor =1;

        for(double i=1; i<list.Length; i++)
        {
            list[(int)i] /= divisor;
        }

        return divisor;



    }

}




