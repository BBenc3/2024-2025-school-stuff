using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_királynő_probléma
{
    internal class Program
    {
        //Átlósan függőlegesen és viszsintesen nem lehet elhelyezni egy NxNes táblán N mennyiségű királynőt
        public static int n;
        public static char[,] matrix;
        public static int elsoFal = 0;
        public static int utolsoFal = n+2;

        static void Main(string[] args)
        {
            //minden sorban egy királynő lehet
            Console.WriteLine("Kérem adja meg az N értékét: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            matrix = new char[n + 2, n + 2]; //0 és n+1 a tábla széle
            #region Tábla körvonala
            //Bejárja a mátrix sorait
            for (int i = 0; i < n + 2; i++)
            {
                //Bejárja a mátrix oszlopait
                for (int j = 0; j < n + 2; j++)
                {
                    if (i == 0 || i == n + 1 || j == 0 || j == n + 1)
                        matrix[i, j] = ('X');
                }
            }
            #endregion

            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < n+1; j++)
                {
                    if (TestForHorizontal(i, j) && TestForVertical(i, j) && TestForDiagonal(i, j))
                        PlaceQueen(i, j);
                }
            }

            WriteMatrix(matrix);

            Console.ReadKey();
        }

        public static void WriteMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(matrix[i,j]);
                }
            }
        }

        public static bool TestForDiagonal(int row, int col)
        {

            //jobbra le
            for (int i = row; i < n + 1; i++)
            {
                for (int j = col; j < n + 1; j++)
                {
                    if (i==j)
                    {
                        if (matrix[i, j] != '\0')
                            return false;
                    }
                }
            }


            //balra le
            for (int i = row; i < n + 1; i++)
            {
                for (int j = col; j > n + 1; j--)
                {
                    if (i == j)
                    {
                        if (matrix[i, j] != '\0')
                            return false;
                    }
                }
            }

            //jobbra fel
            for (int i = row; i > n + 1; i--)
            {
                for (int j = col; j < n + 1; j++)
                {
                    if (i == j)
                    {
                        if (matrix[i, j] != '\0')
                            return false;
                    }
                }
            }

            //balra fel
            for (int i = row; i > n + 1; i--)
            {
                for (int j = col; j > n + 1; j--)
                {
                    if (i == j)
                    {
                        if (matrix[i, j] != '\0')
                            return false;
                    }
                }
            }
            
            return true;
        }

        public static bool TestForHorizontal(int row, int col)
        {
            for (int i = col; i < n+1; i++)
            {
                if (matrix[i, row] != '\0')
                {
                    return false;
                }
            }
            for (int i = col; i < 1; i++)
            {
                if (matrix[i, row] != '\0')
                {
                    return false;
                }
            }


            return true;
        }

        public static bool TestForVertical(int row, int col)
        {
            for (int i = row + 1; i < n + 1; i++)
            {
                if (matrix[col, i] != '\0')
                {
                    return false;
                }
            }
            for (int i = row - 1; i < 1; i++)
            {
                if (matrix[col, i] != '\0')
                {
                    return false;
                }
            }


            return true;
        }

        public static void PlaceQueen (int row, int col)
        {
            if (row != 0 && row != n+2 && col != 0 && col != n+2)
            {
                matrix[col, row] = 'Q';
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
                
            
        }
    }
}