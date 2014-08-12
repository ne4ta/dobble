using System;

namespace Dobble
{
    public class CardsGenerator
    {
        public int[,] Generate(int n, int rep)
        {
            var array = new int[n, (rep - 1) * n + 1];

            int i;
            for (i = 0; i < n; i++)
            {
                array[i, 0] = i;
                for (int j = 0; j < rep - 1; j++)
                {
                    array[0, 1 + i * (rep - 1) + j] = i;
                }
            }

            int lastNum = i;
            int prevLast = lastNum;
            for (i = 1; i < n; i++)
            {
                for (int j = 1; j < rep; j++)
                {
                    lastNum = prevLast + (i - 1) * (n - 1) + (j - 1);
                    array[j, i] = lastNum;
                }
            }

            for (i = 0; i < n - 1; i++)
            {
                for (int k = 0; k < n - 1; k++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        array[i + 1, j + n + k * (n - 1)] = array[1 + (j + k * i) % (n - 1), i + 1];
                    }
                }
            }

            return array;
        }
    }
}
