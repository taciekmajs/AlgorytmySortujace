using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortujące
{
    public static class Algorithms
    {
        public static int bubbleSort(int[] arr)
        {
            int comparisons =0;
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                {
                    comparisons++;
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                    
            return comparisons;
        }
        
        public static int insertionSort(int[] arr)
        {
            int comparisons = 0;
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    comparisons++;
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return comparisons;
        }

        public static void merge(int[] arr, int l, int m, int r)
        { 
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;
           
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public static void mergeSort(int[] arr, int l, int r)
        {
            
            if (l < r)
            {
                int m = l + (r - l) / 2;

                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }

        public static void heapSort(int[] arr)
        {
            int n = arr.Length;


            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);


            for (int i = n - 1; i > 0; i--)
            {

                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;


                heapify(arr, i, 0);
            }
        }
        public static void heapify(int[] arr, int n, int i)
        {
            int largest = i; 
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 

           
            if (l < n && arr[l] > arr[largest])
                largest = l;

            
            if (r < n && arr[r] > arr[largest])
                largest = r;

            
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

               
                heapify(arr, n, largest);
            }
        }

        public static void quickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = partition(arr, left, right);

                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }

        }
        public static int partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }


        public static int[] generateArray(int size)
        {
            Random randNum = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = randNum.Next(0, size * 10);
            }
            return array;
        }

    
    }
}
