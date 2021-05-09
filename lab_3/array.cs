using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class ArraySort
    {
        public ArraySort() //конструктор
        {
        }

        public int[] a;

        private static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void SelectSort(int[] a, ref int sr, ref int obm)
        {
            int max;
            int length = a.Length;
            for (int i = 0; i < length - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < length; j++)
                {
                    sr++;
                    if (a[j] > a[max])
                    {
                        max = j;
                    }
                }

                sr++;
                if (max != i)
                {
                    swap(ref a[i], ref a[max]);
                    obm++;
                }
            }
        }

        public void SelectRecSort(int[] a,ref int length,ref int sr, ref int obm)
        {
            
            if (length == 1)
                return;
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < length - 1; i++)
            {
                sr++;
                if (a[i] < min)
                {
                    min = a[i];
                    index = i;
                }
            }

            sr++;
            if (min < a[length - 1])
            {
                swap(ref a[index], ref a[length - 1]);
                obm++;
            }

            int length1 = (length - 1);
            SelectRecSort(a, ref length1, ref sr, ref obm);
        }

        public void InsertSort(int[] a, ref int sr, ref int obm)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int cur = a[i];
                int j = i;
                while (j > 0 && cur > a[j - 1])
                {
                    sr++;
                    a[j] = a[j - 1];
                    j--;
                }

                a[j] = cur;
            }

            sr++;
        }

        public void BubbleSort(int[] a, ref int sr, ref int obm)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    sr++;
                    if (a[j] < a[j + 1])
                    {
                        swap(ref a[j], ref a[j + 1]);
                        obm++;
                    }
                }
            }
        }

        public void BubbleRecSort(int[] a, ref int sr, ref int obm)
        {
            int i = 0;
            for (int j = 0; j < a.Length - i - 1; j++)
            {
                sr++;
                if (a[j] < a[j + 1])
                {
                    swap(ref a[j], ref a[j + 1]);
                    obm++;
                    i++;
                }
            }

            if (i == 0)
                return;
            else
                BubbleRecSort(a, ref sr, ref obm);
        }

        public void ShellSort(int[] a, ref int sr, ref int obm)
        {
            var d = a.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < a.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (a[j - d] < a[j]))
                    {
                        swap(ref a[j], ref a[j - d]);
                        j = j - d;
                        obm++;
                        sr++;
                    }

                    sr++;
                }

                d = d / 2;
            }
        }
    }
}