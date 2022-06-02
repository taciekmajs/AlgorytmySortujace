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
using System.Diagnostics;
using System.Threading;

namespace AlgorytmySortujące
{
    /// <summary>
    /// Logika interakcji dla klasy HeadToHead.xaml
    /// </summary>
    public partial class HeadToHead : Window
    {
        bool bubble = false;
        bool insertion = false;
        bool merge = false;
        bool heap = false;
        bool quick = false;

        public HeadToHead()
        {
            InitializeComponent();
        }

        private void h2hBubble_Click(object sender, RoutedEventArgs e)
        {
            if (bubble==false)
            {
                bubble = true;
                h2hBubble.FontWeight = FontWeights.Bold;
            }
            else
            {
                bubble = false;
                h2hBubble.FontWeight = FontWeights.Regular;
            }
        }

        private void h2hInsertion_Click(object sender, RoutedEventArgs e)
        {
            if (insertion == false)
            {
                insertion = true;
                h2hInsertion.FontWeight = FontWeights.Bold;
            }
            else
            {
                insertion = false;
                h2hInsertion.FontWeight = FontWeights.Regular;
            }
        }

        private void h2hMerge_Click(object sender, RoutedEventArgs e)
        {
            if (merge == false)
            {
                merge = true;
                h2hMerge.FontWeight = FontWeights.Bold;
            }
            else
            {
                merge = false;
                h2hMerge.FontWeight = FontWeights.Regular;
            }
        }

        private void h2hHeap_Click(object sender, RoutedEventArgs e)
        {
            if (heap == false)
            {
                heap = true;
                h2hHeap.FontWeight = FontWeights.Bold;
            }
            else
            {
                heap = false;
                h2hHeap.FontWeight = FontWeights.Regular;
            }
        }

        private void h2hQuick_Click(object sender, RoutedEventArgs e)
        {
            if (quick == false)
            {
                quick = true;
                h2hQuick.FontWeight = FontWeights.Bold;
            }
            else
            {
                quick = false;
                h2hQuick.FontWeight = FontWeights.Regular;
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        { 
            int size;
            if (int.TryParse(arraySize.Text, out size))
            {
                if (size >= 100000000) 
                {
                    size = 100000000;
                    arraySize.Text = "100000000";
                }
                    
            }
            else
            {
                arraySize.Text = "100";
            }
            
            
            if (bubble)
            {
                Stopwatch stopwatch = new Stopwatch();
                int[] array = Algorithms.generateArray(size);
                stopwatch.Start();
                bComparisons.Text = Algorithms.bubbleSort(array).ToString();
                stopwatch.Stop();
                bTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            }
            else { bTime.Text = ""; }

            if (insertion)
            {
                Stopwatch stopwatch = new Stopwatch();
                int[] array = Algorithms.generateArray(size);
                stopwatch.Start();
                iComparisons.Text = Algorithms.insertionSort(array).ToString();
                stopwatch.Stop();
                iTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            }
            else { iTime.Text = ""; }

            if (merge)
            {
                Stopwatch stopwatch = new Stopwatch();
                int[] array = Algorithms.generateArray(size);
                stopwatch.Start();
                Algorithms.mergeSort(array, 0, size-1);
                stopwatch.Stop();
                mTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            }
            else { mTime.Text = ""; }

            if (heap)
            {
                Stopwatch stopwatch = new Stopwatch();
                int[] array = Algorithms.generateArray(size);
                stopwatch.Start();
                Algorithms.heapSort(array);
                stopwatch.Stop();
                hTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            }
            else { hTime.Text = ""; }

            if (quick)
            {
                Stopwatch stopwatch = new Stopwatch();
                int[] array = Algorithms.generateArray(size);
                stopwatch.Start();
                Algorithms.quickSort(array,0, size-1);
                stopwatch.Stop();
                qTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            }
            else { qTime.Text = ""; }

        }
    }
}
