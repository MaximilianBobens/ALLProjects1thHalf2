using System;
using AllProjects;
class Program
{
    public static void Main(string[] args)
    {
        Cinema c1 = new Cinema(3);
      
        c1.CreateMovies(3);
        c1.PrintMovies();
/*

        AAnimal[] aAnimal = new AAnimal[4];
        Random random = new Random();

        for (int i = 0; i < aAnimal.Length; i++)
        {
            int randomNumber = random.Next(1, 5);
            switch (randomNumber)
            {
                case 1:
                    aAnimal[i] = new Snake("Test1");
                    break;
                case 2:
                    aAnimal[i] = new Horse("Test2");
                    break;
                case 3:
                    aAnimal[i] = new Dragon("Test3");
                    break;
                case 4:
                    aAnimal[i] = new Rabbit("Test4");
                    break;
            }
        }

        foreach (AAnimal animal in aAnimal)
        {
            Console.WriteLine($"{animal}");
            animal.Eating("Food");
            animal.Running();
            animal.Moving();
            animal.Sound();
            Console.WriteLine("-------------");

        }*/



        /*
        SumUpArrayAndAverage();
        AverageCalculationRandom();
        DisplayArrayNumbers();
        Display2DStringArray();
        RandomFillArray();
  RandomFill2D();
       */

        /*
       House h1 = new House("red",3);
       Console.WriteLine(h1.ToString());
       */


        // For the player Script
/*
      Player[] _players = new Player[]
      {
          new Druide("Test", 34, 5, 3, 4)

      };

      foreach (Player player in _players)
      {
          Console.WriteLine($"{player.Name},Heal={player.Heal},Jump={player.Jump},Attack={player.AttackPower}");
      }

      foreach (Player player in _players)
      {
         player.Fight();
      }




// Coffee Example
        CoffeMachnie coffeMachnie = new CoffeMachnie(5);
        coffeMachnie.GenerateDrinks(5);
        coffeMachnie.PrintDrinks();



        Game g = new Game();

        g.PrintJumping();
        g.PrintRunning();
        g.PrintFighting();
        g.PrintPerformMagic();
        */


    }

    private static void XXBsp()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = (i + 1) * (i + 1);
        }

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
    private static void CreateArrayDiffrent()
    {
        int[] array = { 1, 2, 3 };
        int[] array2 = new int[3] { 1, 2, 3 };
        int[] array3 = new int[3];
        array3[0] = 1;
        array3[1] = 2;
        array3[2] = 3;
    }
   private static void DisplayArrayNumbers()
   {
       int[] numbers = { 3, 3, 4, 2, 5 };
       foreach (int item in numbers)
       {
           Console.WriteLine(item);
       }
   }
   private static void SumUpArrayAndAverage()
   {
       int[] array = { 2, 3, 2, 3, 4, 5, 23, 4, 5, 123, 32, 1, 34, 123, 4, 1233, 2, };
       int sum = 0;
       foreach (int number in array)
       {
           sum += number;
       }

       int average = sum / array.Length;

       Console.WriteLine(sum);
       Console.WriteLine(average);
   }

   private static void AverageCalculationRandom()
   {
       Random random = new Random();
       int sum = 0;
       int count = random.Next(1, 30);
       int[] numbers = new int [count];

       for (int i = 0; i < numbers.Length; i++)
       {
           numbers[i] = random.Next(1, 30);
           sum += numbers[i];
       }
       Console.WriteLine(sum);
   }

  
   private static void Display2DStringArray()
   {
       string[,] names = new string[3, 2] { {"Maxi", "Oli"}, {"Leon", "Felix"}, {"Oliver", "Testu"} };

       for (int i = 0; i < names.GetLength(0); i++)
       {
           for (int j = 0; j < names.GetLength(1); j++)
           {
               Console.WriteLine(names[i,j]+" ");
           }
           Console.WriteLine();
       }
   }

   private static void RandomFillArray()
   {
       Console.WriteLine("Enter array size: ");
       int arraySize = Convert.ToInt32(Console.ReadLine());
       int[] array = new int [arraySize];
       Random random = new Random();

       for (int i = 0; i < array.Length; i++)
       {
           array[i] = random.Next(1, 100);
       }

       foreach (var number in array)
       {
           Console.WriteLine(number);
       }
   }

   private static void RandomFill2D()
   {
       // Generate
       Console.WriteLine("Enter col: ");
       int col = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter row: ");
       int row = Convert.ToInt32(Console.ReadLine());
       Random random = new Random();

       int[,] array = new int[col, row];

       for (int i = 0; i < col; i++)
       {
           for (int j = 0; j < row; j++)
           {
               array[i, j] = random.Next(1, 100);
           }
       }

       // Print the 2D array
       for (int i = 0; i < col; i++)
       {
           for (int j = 0; j < row; j++)
           {
               Console.Write(array[i, j] + "\t");
           }
           Console.WriteLine();
       }
   }
}
