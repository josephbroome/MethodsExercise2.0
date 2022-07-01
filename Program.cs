// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {


        tellAStory();

        Console.WriteLine(Add(5, 6));
        Console.WriteLine(Multiply(7, 8));
        Console.WriteLine(Sum(5, 6, 7, 8));
        Console.WriteLine(Multiply(12, 4, 2));
        Console.WriteLine(Divide(12, 4, 5));
        Console.WriteLine(Division(12, 4));
        Console.WriteLine(Subtract(12, 4, 10));

        Console.WriteLine(Remainder(12, 5));

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

    public static double Remainder(params double []list)
    {
        double remainder=list[0];
        for(int i=1;i<list.Length;i++)
        {
            remainder %= list[i];
        }

        return remainder;


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

    public static int Subtract(params int[] list)
    {
        int sum = list[0];
        for(int i=1; i<list.Length; i++)
        {
            sum = sum - (list[i]);
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
        double divisor = list[0];

        for(int i=1; i<list.Length; i++)
        {
            divisor = divisor / list[ i];
        }

        return divisor;



    }

}




