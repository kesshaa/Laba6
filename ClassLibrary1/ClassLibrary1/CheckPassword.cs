using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CheckPassword
    {
        //Task 1
        public static int Task1(int[,] N)
        {
            int count = 0;
            int sum = 0;

            for (int i=0;i<7;i++)
                for (int j = i; j < 7-i; j++)
                    if (N[j,i]>0)
                    {
                        count++;
                        sum += N[i, j];
                    }
            return sum;
        }

        //Task 2 
        public static double Task2(int[,] N)
        {
            int C = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = i; j < 7 - i; j++)
                {
                    if (N[i, j] > N[4, 4])
                    {
                        C = C + 1;
                    }
                }
            }

            int[] S = new int[C];
            int k = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = i; j < 7 - i; j++)
                {
                    if (N[i, j] > N[4, 4])
                    {
                        S[k] = N[i, j];
                        k = k + 1;
                    }
                }
            }

            if (C > 0)
            {
                double sum = S.Sum();
                return sum / C;
            }
            else
            {
                return 0;
            }
        }
        //Task 3
        public static int[] Task3(int[,] N)
        {
            int[] K = new int[3];
            for (int j=2; j<5; j++)
            {
                int tret = 0;
                for (int i = 0; i < j; i++)
                {
                    if(N[i,j]==6)
                    { tret++;}

                }
                K[j - 2] = tret;
            }
            return K;
        }
        //Task 4
        public static int Task4(int[,] N)
        {
            int min = N[0, 0];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (N[i, j] < min)
                    {
                        min = N[i, j];
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (N[i, j] == min)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

    }
}
