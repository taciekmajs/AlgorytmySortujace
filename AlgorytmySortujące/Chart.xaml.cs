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
using LiveCharts;
using LiveCharts.Wpf;

namespace AlgorytmySortujące
{
    /// <summary>
    /// Logika interakcji dla klasy Chart.xaml
    /// </summary>
    public partial class Chart : Window
    {
        bool generate = true;
        Selection.Algorithm chosen;

        public Chart(Selection.Algorithm algorithm)
        {
            InitializeComponent();
            chosen = algorithm;

            if (algorithm == Selection.Algorithm.bubble) chosenAlgorithm.Content = "Bubble Sort efficiency chart";
            if (algorithm == Selection.Algorithm.insertion) chosenAlgorithm.Content = "Insertion Sort efficiency chart";
            if (algorithm == Selection.Algorithm.merge) chosenAlgorithm.Content = "Merge Sort efficiency chart";
            if (algorithm == Selection.Algorithm.heap) chosenAlgorithm.Content = "Heap Sort efficiency chart";
            if (algorithm == Selection.Algorithm.quick) chosenAlgorithm.Content = "QuickSort efficiency chart";
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            if (!generate)
            {
                generate = true;
                load.Content = "Use already generated data";
                information.Text = "";
                start.Content = "GENERATE";
            }
            else 
            {
                generate = false;
                load.Content = "Generate data for your PC";
                information.Text = "migh take a while";
                start.Content = "SHOW";
            }
        }


        private void start_Click(object sender, RoutedEventArgs e)
        {
            if (generate)
            {
                int[] size = new int[60];
                int[] timeSpent = new int[60];
                int k = 0;
                if (chosen == Selection.Algorithm.bubble)
                {
                    for (int i = 250; i <= 15000; i += 250)
                    {
                        int[] array = Algorithms.generateArray(i);
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Algorithms.bubbleSort(array);
                        stopwatch.Stop();
                        timeSpent[k] = (int)stopwatch.ElapsedMilliseconds;
                        size[k] = i;
                        k++;
                    }
                }
                if (chosen == Selection.Algorithm.insertion)
                {
                    for (int i = 250; i <= 15000; i += 250)
                    {
                        int[] array = Algorithms.generateArray(i);
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Algorithms.insertionSort(array);
                        stopwatch.Stop();
                        timeSpent[k] = (int)stopwatch.ElapsedMilliseconds;
                        size[k] = i;
                        k++;
                    }
                }
                if (chosen == Selection.Algorithm.heap)
                {
                    for (int i = 1000; i <= 60000; i += 1000)
                    {
                        int[] array = Algorithms.generateArray(i);
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Algorithms.heapSort(array);
                        stopwatch.Stop();
                        timeSpent[k] = (int)stopwatch.ElapsedMilliseconds;
                        size[k] = i;
                        k++;
                    }
                }
                if (chosen == Selection.Algorithm.merge)
                {
                    for (int i = 1000; i <= 60000; i += 1000)
                    {
                        int[] array = Algorithms.generateArray(i);
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Algorithms.mergeSort(array, 0, i-1);
                        stopwatch.Stop();
                        timeSpent[k] = (int)stopwatch.ElapsedMilliseconds;
                        size[k] = i;
                        k++;
                    }
                }
                if (chosen == Selection.Algorithm.quick)
                {
                    for (int i = 5000; i <= 300000; i += 5000)
                    {
                        int[] array = Algorithms.generateArray(i);
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Algorithms.quickSort(array, 0, i-1);
                        stopwatch.Stop();
                        timeSpent[k] = (int)stopwatch.ElapsedMilliseconds;
                        size[k] = i;
                        k++;
                    }
                }

                
                
            }
            
        }
    }
}
