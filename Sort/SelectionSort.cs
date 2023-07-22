using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Sort
{
    internal class SelectionSort
    {
        internal static void Sort(int[] arr)
        {
            int minIndex; //第i次比较时最小值的index
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)  //minIndex不在i，交换
                {
                    temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        internal static void Sort<T>(T[] arr) where T : System.IComparable<T>
        {

            int minIndex; //第i次比较时最小值的index
            T temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minIndex].CompareTo(arr[j]) > 0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)  //minIndex不在i，交换
                {
                    temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
    }
}
