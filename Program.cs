using System;

class UniqueQuiz3
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please Enter the Operation : ");
            char operation = Console.ReadLine()[0];
            Console.WriteLine("Please Enter the Row : ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Columns : ");
            int columns = int.Parse(Console.ReadLine());
            float[][] matrix1 = new float[rows][];
            float[][] matrix2 = new float[rows][];
            Console.WriteLine("Operation [ " + operation + " ] Row [ " + rows + " ] Columns [ " + columns + " ]");

            if (operation != '+' && operation != '-')
            {
                Console.WriteLine("Operation not [+] or [-]");
                break;
            }

            for (int i = 0; i < rows; i++)
            {
                matrix1[i] = new float[columns];
                for (int j = 0; j < columns; j++)
                {
                    matrix1[i][j] = float.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                matrix2[i] = new float[columns];
                for (int j = 0; j < columns; j++)
                {
                    matrix2[i][j] = float.Parse(Console.ReadLine());
                }
            }

            CalculateMatrix(operation, matrix1, matrix2, rows, columns);
        }
    }

    static void CalculateMatrix(char operation, float[][] matrix1, float[][] matrix2, int rows, int columns)
    {
        float[][] resultMatrix = new float[rows][];
        for (int i = 0; i < rows; i++)
        {
            resultMatrix[i] = new float[columns];
            for (int j = 0; j < columns; j++)
            {
                if (operation == '+')
                {
                    resultMatrix[i][j] = matrix1[i][j] + matrix2[i][j];
                }
                else
                {
                    resultMatrix[i][j] = matrix1[i][j] - matrix2[i][j];
                }
            }
        }

        PrintMatrix(resultMatrix);
    }

    static void PrintMatrix(float[][] matrix)
    {
        Console.WriteLine("Result is : ");
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.WriteLine(matrix[i][j].ToString("F1"));
            }
        }
    }
}
