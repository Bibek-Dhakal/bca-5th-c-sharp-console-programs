namespace BCA_5th_Sem_lab_work_console_programs.Programs
{
    public static class MatrixOperations
    {
        public static void Execute()
        {
            Console.Write("Enter the number of rows and columns for the matrices: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int cols = Convert.ToInt32(Console.ReadLine());

            // Initialize matrices
            int[,] matrixA = new int[rows, cols];
            int[,] matrixB = new int[rows, cols];
            int[,] sumMatrix = new int[rows, cols];
            int[,] productMatrix = new int[rows, cols];

            // Input for Matrix A
            Console.WriteLine("Enter elements for Matrix A:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Input for Matrix B
            Console.WriteLine("Enter elements for Matrix B:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Perform Addition
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sumMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            // Display Sum Matrix
            Console.WriteLine("Sum of Matrix A and Matrix B:");
            DisplayMatrix(sumMatrix);

            // Perform Multiplication
            if (cols == rows)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        productMatrix[i, j] = 0;
                        for (int k = 0; k < cols; k++)
                        {
                            productMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                        }
                    }
                }

                // Display Product Matrix
                Console.WriteLine("Product of Matrix A and Matrix B:");
                DisplayMatrix(productMatrix);
            }
            else
            {
                Console.WriteLine("Matrix multiplication is not possible with the given dimensions.");
            }
        }

        static void DisplayMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}