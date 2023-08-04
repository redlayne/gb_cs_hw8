internal class Program
{
    private static void Main(string[] args)
    {   
        void Sort2DArrayTask54()
        {
            int[,] arrayToSort = CustomLibClass.Generate2DArray(4, 5);
            Console.WriteLine("Unsorted array");
            CustomLibClass.Print2DArray(arrayToSort);

            for (int rowIndex = 0; rowIndex < arrayToSort.GetLength(0); rowIndex++)
            {   
                for (int i = 0; i < arrayToSort.GetLength(1); i++ )
                {
                    for (int j = 0; j < arrayToSort.GetLength(1)-1; j++ )
                    {
                        if (arrayToSort[rowIndex, j] < arrayToSort[rowIndex, j+1]) CustomLibClass.Swap(ref arrayToSort[rowIndex, j], ref arrayToSort[rowIndex, j+1]);
                    }
                }
            }

            Console.WriteLine("\nSorted array");
            CustomLibClass.Print2DArray(arrayToSort);
        }

        void LowestRowTask56()
        {
            int[,] arrayLowestRow = CustomLibClass.Generate2DArray(7, 3, 1, 10);
            Console.WriteLine("Here is your array.\n");
            CustomLibClass.Print2DArray(arrayLowestRow);

            int lowestSumRowIndex = -1;
            int lowestSum = 0;

            for (int rowIndex = 0; rowIndex < arrayLowestRow.GetLength(0); rowIndex++)
            {   
                int rowSum = 0;
                for (int i = 0; i < arrayLowestRow.GetLength(1); i++) rowSum += arrayLowestRow[rowIndex, i];
                if (rowSum < lowestSum || lowestSumRowIndex == -1)
                {
                    lowestSumRowIndex = rowIndex;
                    lowestSum = rowSum;
                }
            }

            Console.WriteLine($"\nRow number {lowestSumRowIndex+1} has the lowest sum.");
            for (int i = 0; i < arrayLowestRow.GetLength(1); i++) Console.Write($"{arrayLowestRow[lowestSumRowIndex, i]} + ");
            Console.WriteLine("\b\b= " + lowestSum);
        }
        
        void SpiralTask58() //это спиральное заполнение годится для произвольной матрицы, но я поленился и взял квадратную для простоты
        {   
            int spiralSize = CustomLibClass.Input("Enter spiral size: ");
            int[,] spiral = new int[spiralSize, spiralSize];

            int spiralNumber = 1;
            int top = 0;
            int right = spiral.GetLength(1);
            int bottom = spiral.GetLength(0);
            int left = 0;
            
            while (spiralNumber <= spiral.GetLength(0) * spiral.GetLength(1))
            {
                // moving right
                for (int k = left; k < right; k++)
                {
                    spiral[top, k] = spiralNumber;
                    spiralNumber++;
                }

                //moving down
                for (int k = top+1; k < bottom; k++)
                {
                    spiral[k, right-1] = spiralNumber;
                    spiralNumber++;
                }
                top++;

                //moving left
                for (int k = right-2; k >= left; k--)
                {
                    spiral[bottom-1, k] = spiralNumber;
                    spiralNumber++;
                }
                right--;

                //moving up
                for (int k = bottom - 2; k >= top; k--)
                {
                    spiral[k, left] = spiralNumber;
                    spiralNumber++;   
                }
                bottom--;
                left++;

            }

            Console.WriteLine();
            CustomLibClass.Print2DArray(spiral);

        }

        Console.Clear();

        Sort2DArrayTask54();

        CustomLibClass.Anykey();
        CustomLibClass.Break();

        LowestRowTask56();

        CustomLibClass.Anykey();
        CustomLibClass.Break();

        SpiralTask58();

        CustomLibClass.Break();
    }
}