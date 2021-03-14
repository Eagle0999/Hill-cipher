using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_Hill
{
    public class Class1
    {
        public string str(string str)
        {
            return str = new string(str.Distinct().ToArray());
        }

        public int[] index( int size)
        {
            int[] index = new int[size];
            for (int i = 0; i < size; i++) index[i] = i;
            
            return index;
        }

        public int[,] matrix(char[,] str, int row,int column)
        {

            int[,] matrix = new int[row, column];
            int ch=0;
            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = Convert.ToInt32(str[0,ch]);
                    ch++;
                }

            }
            return matrix;
        }



        public string[,] matrix_deshifr(string[,] str, int leng, int[,] matrix, int row, int column)
        {

            char[,] key = new char[row, column];


            string[,] vector2 = new string[row, column];


            int ch = 0;
            /*int[] vector = new int[row*column];

            for (int i = 0; i < row-1; i++)
            {

                for (int j = 0; j < column-1; j++)
                {

                    vector[ch] = matrix[i, j];
                    ch++;
                }
            }*/


            
                for (int i = 0; i < row; i++)
                {

                    for (int j = 0; j < column; j++)
                    {
                       for (int k = 0; k < leng; k++)
                        {
                            if (matrix[i, j] == k)
                            {
                                vector2[i, j] = Convert.ToString(str[0,k]);
                           
                                
                            }
                       }
                    }
                }



                return vector2;
        }


        public int[,] matrix_convert(string[,] zash_key, int row_key, int column_key)
        {
            int[,] zash_key_int = new int[row_key, column_key];
            
          


            for (int j = 0; j < row_key; j++)
            {
                for (int k = 0; k < column_key; k++)
                {
                    zash_key_int[j, k] = Convert.ToInt32(zash_key[j, k]);
                }
            }

            return zash_key_int;
        }


        public int[] matrix_convert_1D(int[,] matrix, int column)
        {
            int[] vector = new int[column];

            for (int j = 0; j < column; j++)
            {
                vector[j] = matrix[0, j];
            }

            return vector;
        }


        public void Euqlid(long det, long len_alp, long[] d, long[] x, long[] y )  // a - определитель матрицы ключа (det),   b - длина входного алфавита (len_alp)
        {
            long q, r, x1, x2, y1, y2;


         if (len_alp == 0) 
        {

            //d = det, x = 1, y = 0;
            d[0] = det; x[0] = 1; y[0] = 0;
            return; 

        }

         x2 = 1; x1 = 0; y2 = 0; y1 = 1;

        while ( len_alp > 0) 
        {

    q = det/len_alp;  r = det - q * len_alp;

    x[0] = x2 - q * x1;  y[0] = y2 - q * y1;

    det = len_alp;  len_alp = r;

    x2 = x1;  x1 = x[0];  y2 = y1;  y1 = y[0];


         }

        d[0] = det; x[0] = x2;   y[0] = y2;

       }



        public long invert_det(long det, long[] x, long len_alp)
        {

            if (det < 0 && x[0] >= 0) det = x[0];

            if (det >= 0 && x[0] < 0) det = len_alp + x[0];
            
            if (det >= 0 && x[0] >= 0) det = x[0];

            if (det < 0 && x[0] < 0) det = -x[0];
               
                
                return det;
        }

        public int[,] invert_matr_minor(int[,] matrix, int row, int column, int size, int[] pow)
        {

            int[] vector = new int[(row - 1) * (column-1)];

            int[] empty = new int[column];

            int[,] vector2 = new int[row - 1,  column - 1];

            int f = 0;
           // int count_col = 1;
            /* h=Math.Pow(-1,2);
             Console.WriteLine(h);
             Console.ReadLine();*/
           // if(size > 0)
          //  {
                for (int k = size - 1; k < size; k++)
                {
                    
                        /*for (int a = 0; a < row; a++)
                        {
                            empty[a] = matrix[a, count_col];
                        }

                        for (int a = 0; a < row; a++)
                        {
                            matrix[a, count_col] = matrix[a, 0];
                        }
                        
                        for (int a = 0; a < row; a++)
                        {
                            matrix[a, 0] = empty[a];
                        }
                        */


                    for (int i = 0; i < row; i++)
                    {

                        for (int j = 0; j < column; j++)
                        {

                            if (i != k + 1 && j != 0) { vector[f] = matrix[i, j]; pow[0] = size + j; f++; }
                         //   else {  }
                            
                            //if (i != k + 1 && j != 0 && size > f2) { vector[f] = matrix[i, j]; pow[0] = i + j; f++; }
                        }

                        /* if (i > 0)
                         {
                             for (int j = 0; j < 3; j++)
                             {
                                 vector[j] = matrix[0, j];
                             }
                         }*/
                      //  if (i > 0) f2++;
                        
                    }
                    f = 0;
                  
                }

                f = 0; 
                for (int i = 0; i < row-1; i++)
                {
                    for (int j = 0; j < column-1; j++)
                    {
                        vector2[i, j] = vector[f];
                        f++;
                    }

                    /* if (i > 0)
                     {
                         for (int j = 0; j < 3; j++)
                         {
                             vector[j] = matrix[0, j];
                         }
                     }*/
                    //  if (i > 0) f2++;

                }



         //   }
            return vector2;
        }


        public void swap_matrix(int[,] matrix, int row, int column,  int count_col)
        {
            
                int[] empty = new int[column];
                        for (int a = 0; a < row; a++)
                        {
                            empty[a] = matrix[a, count_col];
                        }

                        for (int a = 0; a < row; a++)
                        {
                            matrix[a, count_col] = matrix[a, 0];
                        }
                        
                        for (int a = 0; a < row; a++)
                        {
                            matrix[a, 0] = empty[a];
                        }
                        
            
        }


        public int[,] matrix_convert_2D(int[,] vector_minor, int row, int column)
        {
            int[,] matrix_vector = new int[row,column];
            int k = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix_vector[i, j] = vector_minor[0,k];
                    k++;
                }
            }

            return matrix_vector;
        }


    }
}
