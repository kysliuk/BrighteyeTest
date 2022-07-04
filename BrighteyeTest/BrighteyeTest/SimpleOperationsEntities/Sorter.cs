using System;

namespace BrighteyeTest
{
    internal class Sorter
    {
        internal static int[] GetSortedArray(int[] numbers)
        {
            return MargeSort(numbers, 0, numbers.Length-1);
        }

        private static int[] MargeSort(int[] array, int p, int r)
        {
            if (p < r)
            {
                int q = (Int32)((p + r) / 2);
                MargeSort(array, p, q);
                MargeSort(array, q + 1, r);
                Marge(array, p, q, r);
            }
            return array;
        }

        private static void Marge(int[] array, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] arrayB = new int[n1];
            int[] arrayC = new int[n2];

            int i = 0;
            int j = 0;

            for (i = 0; i < n1; i++) arrayB[i] = array[p + i];
            for (j = 0; j < n2; j++) arrayC[j] = array[q + 1 + j];

            i = 0;
            j = 0;

            int k = p;

            while (i < n1 && j < n2)
            {
                if (arrayB[i] <= arrayC[j]) array[k++] = arrayB[i++];
                else array[k++] = arrayC[j++];
            }

            while (i < n1) array[k++] = arrayB[i++];
            while (j < n2) array[k++] = arrayC[j++];
        }
    }
}
