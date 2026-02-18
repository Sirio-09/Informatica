using System.Diagnostics;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            try
            {
                int[,] matrix = LoadIntMatrix();
                PrintIntMatrix(matrix);

                Console.WriteLine();

                int[,] matrix2 = NewIntMatrixMirror(matrix, true);
                PrintIntMatrix(matrix2);

                Console.WriteLine();

                int[,] matrix3 = NewIntMatrixDiagonalMirror(matrix, false);
                PrintIntMatrix(matrix3);

                Console.WriteLine();

                int[,] matrix4 = NewIntMatrixRotation(matrix, true);
                PrintIntMatrix(matrix4);

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong:");
                Console.WriteLine(ex);
            }
        }

        /// <summary> 
        /// Loads a matrix of integers with dimensions specified by the user. 
        /// </summary> 
        /// <returns>A matrix of integers with values entered by the user.</returns> 
        /// <example>
        /// This is an example output produces by calling "loadMatrix()"
        /// > Rows:
        /// < 3
        /// > Columns:
        /// < 1
        /// > matrix[0,0]:
        /// < 1
        /// > matrix[1,0]:
        /// < 2
        /// > matrix[2,0]:
        /// < 10
        /// </example>
        public static int[,] LoadIntMatrix()
        {
            int rows, columns;

            do
            {
                Console.Write("Rows: ");
                rows = Convert.ToInt32(Console.ReadLine()!);
            } while (rows <= 0);

            do
            {
                Console.Write("Columns: ");
                columns = Convert.ToInt32(Console.ReadLine()!);
            } while (columns <= 0);

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine()!);
                }
            }

            return matrix;
        }

        /// <summary>
        /// Prints a matrix of integers to the console. 
        /// </summary> 
        /// <param name="matrix">The matrix to be printed.</param>
        public static void PrintIntMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        /// <summary> 
        /// Mirrors a matrix of integers.
        /// </summary> 
        /// <param name="matrix">The matrix to mirror.</param> 
        /// <param name="mirrorRows">If true, mirrors the rows; otherwise, mirrors the columns.</param>
        /// <returns>The mirrored matrix.</returns>
        /// <example>
        /// int [,] matrix = new int[3,3];
        /// matrix[0,0] = 1;
        /// matrix[1,0] = 1;
        /// PrintMatrix(matrix);
        /// // Output
        /// 1 0 0
        /// 1 0 0
        /// 0 0 0
        /// int[,] mirrored = NewIntMatrixMirror(matrix, true);
        /// PrintMatrix(matrix);
        /// // Output
        /// 0 0 1
        /// 0 0 1
        /// 0 0 0
        /// mirrored = NewIntMatrixMirror(matrix, true);
        /// PrintMatrix(matrix);
        /// // Output
        /// 1 0 0
        /// 1 0 0
        /// 0 0 0
        /// mirrored = NewIntMatrixMirror(matrix, false);
        /// PrintMatrix(matrix);
        /// // Output
        /// 0 0 0
        /// 1 0 0
        /// 1 0 0
        /// mirrored = NewIntMatrixMirror(matrix, false);
        /// PrintMatrix(matrix);
        /// // Output
        /// 1 0 0
        /// 1 0 0
        /// 0 0 0
        /// </example>
        public static int[,] NewIntMatrixMirror(int[,] matrix, bool mirrorRows)
        {
            int rows = matrix.GetLength (0);
            int columns = matrix.GetLength (1);


            int[,] mat = new int[rows, columns];
            int i = 0;

            while(i < rows)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mirrorRows)
                    {
                        mat[i, columns - j - 1] = matrix[i, j];
                    }
                    else
                    {
                        mat[rows - i - 1, j] = matrix[i, j];
                    }
                }
                i++;
            }

            return mat;
        }

        /// <summary> 
        /// Mirrors a matrix of integers.
        /// </summary> 
        /// <param name="matrix">The matrix to mirror.</param> 
        /// <param name="onMainDiagonal">If true, mirrors the rows on the main diagonal; otherwise, mirrors the secondary diagonal.</param>
        /// <returns>The mirrored matrix.</returns>
        /// <example>
        /// int [,] matrix = new int[3,3] {
        ///   { 1, 2, 3 },
        ///   { 4, 5, 6 },
        ///   { 7, 8, 9 },
        /// };
        /// PrintMatrix(matrix);
        /// // Output
        /// 1 2 3
        /// 4 5 6
        /// 7 8 9
        /// int[,] mirrored = NewIntMatrixDiagonalMirror(matrix, true);
        /// PrintMatrix(matrix);
        /// // Output
        /// 1 4 7
        /// 2 5 8
        /// 3 6 9
        /// mirrored = NewIntMatrixDiagonalMirror(mirrored, true);
        /// PrintMatrix(matrix);
        /// // Output
        /// 1 2 3
        /// 4 5 6
        /// 7 8 9
        /// mirrored = NewIntMatrixDiagonalMirror(matrix, false);
        /// PrintMatrix(matrix);
        /// // Output
        /// 9 6 3
        /// 8 5 2
        /// 7 4 1
        /// mirrored = NewIntMatrixDiagonalMirror(mirrored, false);
        /// PrintMatrix(matrix);
        /// // Output
        /// 1 2 3
        /// 4 5 6
        /// 7 8 9
        /// </example>
        public static int[,] NewIntMatrixDiagonalMirror(int[,] matrix, bool onMainDiagonal)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] mat = new int[rows, columns];

            if (rows != columns) 
            {
                throw new ArgumentException("Matrix must be squared in order to mirror on the diagonal");
            }

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if(onMainDiagonal)
                    {
                        mat[j, j] = matrix[rows - i - 1, j];
                    }
                    else
                    {
                        mat[rows - j - 1, j] = matrix[i, rows - j - 1];
                    }
                }
            }

            return mat;
        }

        /// <summary> 
        /// Rotates a matrix of integers by 90 degrees.
        /// </summary> 
        /// <param name="matrix">The matrix to rotate.</param> 
        /// <param name="rightRotation">If true, rotates the matrix to the right; otherwise, rotates to the left.</param>
        /// <returns>The rotated matrix.</returns>
        /// <example>
        /// int [,] matrix = new int[3,3];
        /// matrix[0,0] = 1;
        /// matrix[1,0] = 1;
        /// PrintIntMatrix(matrix);
        /// // Output
        /// 1 0 0
        /// 1 0 0
        /// 0 0 0
        /// int [,] rotated = NewIntMatrixRotation(matrix, true);
        /// PrintIntMatrix(rotated);
        /// // Output
        /// 0 1 1
        /// 0 0 0
        /// 0 0 0
        /// rotated = NewIntMatrixRotation(rotated, true);
        /// PrintIntMatrix(rotated);
        /// // Output
        /// 0 0 0
        /// 0 0 1
        /// 0 0 1
        /// rotated = NewIntMatrixRotation(rotated, true);
        /// PrintIntMatrix(rotated);
        /// // Output
        /// 0 0 0
        /// 0 0 0
        /// 1 1 0
        /// rotated = NewIntMatrixRotation(rotated, true);
        /// PrintIntMatrix(rotated);
        /// // Output
        /// 1 0 0
        /// 1 0 0
        /// 0 0 0
        /// rotated = NewIntMatrixRotation(rotated, false);
        /// PrintIntMatrix(rotated);
        /// // Output
        /// 0 0 0
        /// 0 0 0
        /// 1 1 0
        /// </example>
        public static int[,] NewIntMatrixRotation(int[,] matrix, bool rightRotation)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] res = new int[rows, columns];

            if (rows != columns)
            {
                throw new ArgumentException("Matrix must be squared in order to perform a rotation of 90 degrees");
            }
            
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (rightRotation)
                    {
                        res[j, rows - i - 1] = matrix[i, j];
                    }
                    else
                    {
                        res[columns - j - 1, i] = matrix[i, j];
                    }
                }
            }
            return res;
        }
    }
}
