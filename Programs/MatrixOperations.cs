using System;

namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    public static class MatrixOperations
    {
        public static void Execute()
        {
            // Example for small matrices
            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };

            int[,] additionResult = Utils.MatrixUtils.AddMatrices(matrix1, matrix2);
            int[,] multiplicationResult = Utils.MatrixUtils.MultiplyMatrices(matrix1, matrix2);

            Console.WriteLine("Addition Result:");
            PrintMatrix(additionResult);

            Console.WriteLine("Multiplication Result:");
            PrintMatrix(multiplicationResult);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}