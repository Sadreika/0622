using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SudokuValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program objectOfProgram = new Program();
            int[,] array = new int[,] { {5, 3, 4, 6, 7, 8, 9, 1, 2},
                                        {6, 7, 2, 1, 9, 5, 3, 4, 8},
                                        {1, 9, 8, 3, 4, 2, 5, 6, 7},
                                        {8, 5, 9, 7, 6, 1, 4, 2, 3},
                                        {4, 2, 6, 8, 5, 3, 7, 9, 1},
                                        {7, 1, 3, 9, 2, 4, 8, 5, 6},
                                        {9, 6, 1, 5, 3, 7, 2, 8, 4},
                                        {2, 8, 7, 4, 1, 9, 6, 3, 5},
                                        {3, 4, 5, 2, 8, 6, 1, 7, 9}};
            objectOfProgram.checking(array);
        }

        public int checkingIfAllFull(int[,] array)
        {
            int value = 1;
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if(array[i,j] == 0)
                    {
                        value = 0;
                    }
                }
            }
            return value;
        }

        public int checkingRows(int [,] array)
        {
            int returningValue = 1;
            int value;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    value = array[i, j];
                    for(int x = j + 1; x < 9; x++)
                    {
                        if(value == array[i, x])
                        {
                            returningValue = 0;
                        }
                    }
                }
            }
            return returningValue;
        }

        public int checkingColumn(int[,] array)
        {
            int returningValue = 1;
            int value;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    value = array[j, i];
                    for (int x = j + 1; x < 9; x++)
                    {
                        if (value == array[x, i])
                        {
                            returningValue = 0;
                        }
                    }
                }
            }
            return returningValue;
        }

        public int checkingSquares(int[,] array)
        {
            int returningValue = 1;

            int value;
            for (int i = 0; i < 3; i = i + 1)
            {
                for (int j = 0; j < 3; j = j + 1)
                {
                    value = array[i, j];
                    for (int x = i + 1; x < 3; x++)
                    {
                        if (value == array[x, i])
                        {
                            returningValue = 0;
                        }
                    }
                    for(int z = j + 1; z < 3; z++)
                    {
                        if(value == array[i, z])
                        {
                            returningValue = 0;
                        }
                    }
                }
            }

            return returningValue;
        }
        public void checking(int[,] array)
        {
            int value = checkingIfAllFull(array);
            if(value == 1)
            {
                Console.WriteLine("Board Filled");
                int checkingRowsValue = checkingRows(array);
                if(checkingRowsValue == 1)
                {
                    Console.WriteLine("Rows have diffrent elements");
                    int checkingColumnValue = checkingColumn(array);
                    if(checkingRowsValue == 1)
                    {
                        Console.WriteLine("Columns have diffrent elements");
                        int checkingSquaresvalue = checkingSquares(array);
                    }
                }
                

                /*for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        // array[]
                    }
                }*/
            }
            
        }
    }
}
