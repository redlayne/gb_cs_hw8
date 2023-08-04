public static class CustomLibClass
{

    public static void Break()
    {
        Console.WriteLine();
        Console.WriteLine(new string('*', 50));
        Console.WriteLine();
    }

    public static int Input(string inputmessage)
    {
        Console.Write(inputmessage);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }

    public static int[,] Generate2DArray(int rows, int columns, int from = 10, int to = 100)
    {
        Random rand = new Random();
        int[,] newarray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {   
            for (int j = 0; j < columns; j++)
            {
                newarray[i,j] = rand.Next(from, to);
            }
        }

        return newarray;
    }

    public static void Print2DArray(int[,] arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.GetLength(0); i++)
        {   
            for (int j = 0; j < arrayToPrint.GetLength(1); j++)
            {
                Console.Write($"{arrayToPrint[i,j]}\t");
            }
            Console.WriteLine();
        }
    }

    public static void Anykey()
    {
        Console.Write("\npress any key to continue...");
        Console.ReadKey();
        Console.WriteLine("\b"+ " ");

    }

    public static void Swap(ref int exchangeItem1, ref int exchangeItem2)
    {
        int tempExchange = 0;
        tempExchange = exchangeItem1;
        exchangeItem1 = exchangeItem2;
        exchangeItem2 = tempExchange;
    }
}