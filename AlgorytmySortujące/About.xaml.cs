using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AlgorytmySortujące
{
    /// <summary>
    /// Logika interakcji dla klasy About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About(Selection.Algorithm algorithm)
        {
            InitializeComponent();
            Selection.Algorithm chosen = algorithm;

            if (chosen==Selection.Algorithm.bubble)
            {
                nazwa.Content = "Bubble Sort";
                opis.Text = "Bubble sort, sometimes referred to as sinking sort, is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements and swaps them if they are in the wrong order. The pass through the list is repeated until the list is sorted. The algorithm, which is a comparison sort, is named for the way smaller or larger elements \"bubble\" to the top of the list.";
            }
            if (chosen == Selection.Algorithm.insertion)
            {
                nazwa.Content = "Insertion Sort";
                opis.Text = "Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.";
            }
            if (chosen == Selection.Algorithm.merge)
            {
                nazwa.Content = "Merge Sort";
                opis.Text = "Merge Sort is a divide and conquer algorithm. It works by recursively breaking down a problem into two or more sub-problems of the same or related type, until these become simple enough to be solved directly. The solutions to the sub-problems are then combined to give a solution to the original problem.";
            }
            if (chosen == Selection.Algorithm.heap)
            {
                nazwa.Content = "Heap Sort";
                opis.Text = "Heap sort is a comparison-based sorting technique based on Binary Heap data structure. It is similar to selection sort where we first find the minimum element and place the minimum element at the beginning. We repeat the same process for the remaining elements.";
            }
            if (chosen == Selection.Algorithm.quick)
            {
                nazwa.Content = "QuickSort";
                opis.Text = "Quick Sort is a sorting algorithm, which is commonly used in computer science. Quick Sort is a divide and conquer algorithm. It creates two empty arrays to hold elements less than the pivot value and elements greater than the pivot value, and then recursively sort the sub arrays.";
            }

        }
    }
}
