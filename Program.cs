// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {


        //tellAStory();

        //Console.WriteLine(Multiply(7, 8));
        //Console.WriteLine(Sum(5, 6, 7, 8));
        //Console.WriteLine(Multiply(12, 4, 2));
        //Console.WriteLine(Divide(12, 4, 5));
        //Console.WriteLine(Division(12, 4));
        //Console.WriteLine(Subtract(12, 4, 10));

        //Console.WriteLine(Remainder(12, 5));
        //int[,] someNums =
        //    {
        //        { 2, 3, 5, 6 },
        //        { 5, 6, 7, 6 },
        //        { 4, 6, 7, 6 },
        //        { 2, 4, 5, 6 }
        //    };

        //Console.WriteLine(someNums[0, 2]);

        //for (int k = 0; k < 4; k++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        Console.Write(someNums[k, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        int[,,] nums = new int[1, 2, 3];

        int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

        Console.WriteLine(array3D[0, 1,1]);
        //for (int k = 0; k < 2; k++)
        //{
        //    for (int i = 0; i < 2; i++)
        //    {
        //        for (int j = 0; j < 2; j++)
        //        {
        //            Console.WriteLine(array3D[k, i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //}


        //int[] array = new int[5];
        //int sum = 0;
        //while (sum < 5)
        //{
        //    array[sum] = int.Parse(Console.ReadLine());
        //    sum++;
        //}
        //Console.WriteLine(array.Max() + array.Min());

        //Console.WriteLine(ProductIsOdd(3, 7));

        //int day1Winner = Convert.ToInt32(Console.ReadLine());
        //int day2Winner = Convert.ToInt32(Console.ReadLine());
        //int day3Winner = Convert.ToInt32(Console.ReadLine());


        //string[][] olympiad = new string[][]
        //{
        //        //day 1 - 5 participants
        //        new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
        //        //day 2 - 7 participants
        //        new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
        //        //day 3 - 4 participants
        //        new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana", }

        //};

        //Console.WriteLine(olympiad[0][0]);
        ////Console.WriteLine(olympiad[1][day2Winner - 1]);
        ////Console.WriteLine(olympiad[2][day3Winner - 1]);

        //Console.WriteLine(olympiad.Rank);

        //var x = int.Parse(Console.ReadLine());
        //var y = int.Parse(Console.ReadLine());

        //Console.WriteLine(ProductIsOdd(x, y));


        //BasicCalculator();

        //string s = "Hello";

        //char x;
        //x = s[s.Length - 1];
        //Console.WriteLine(x);
    
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
    public static void BasicCalculator()
    {
        bool isRight = true;

        do
        {



            var x = int.Parse(Console.ReadLine());

            char calculator = char.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            if (calculator == '+')
            {
                Console.WriteLine(Sum(x, y));
                isRight = true;
            }


            if (calculator == '-')
            {
                Console.WriteLine(Sum(x - y));
                isRight = true;

            }

            if (calculator == '*')
            {
                Console.WriteLine(x * y);
                isRight = true;

            }

            if (calculator == '/')
            {
                Console.WriteLine(x / y);

                isRight = true;
            }



        } while (isRight == false);
    }
    
    public static bool ProductIsOdd(int x, int y)
    {
      

        if ((x * y) % 2 == 0)
        {
            return false;
        }
        else
            return true;


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




