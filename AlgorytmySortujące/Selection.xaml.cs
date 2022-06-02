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
    /// Logika interakcji dla klasy Selection.xaml
    /// </summary>
    public partial class Selection : Window
    {
        public enum Algorithm {bubble, insertion, merge, heap, quick}
        Algorithm chosen;
        int mode;
        public Selection(int mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        
        private void open(int mode, Selection.Algorithm algorithm)
        {
            if (mode == 0)
            {
                About about = new About(chosen);
                about.Show();
            }
            else
            {
                Chart chart = new Chart(chosen);
                chart.Show();
            }
        }
        
        private void bubble_Click(object sender, RoutedEventArgs e)
        {
            chosen = Algorithm.bubble;
            open(mode, chosen);
        }

        private void insertion_Click(object sender, RoutedEventArgs e)
        {
            chosen = Algorithm.insertion;
            open(mode, chosen);
        }

        private void merge_Click(object sender, RoutedEventArgs e)
        {
            chosen = Algorithm.merge;
            open(mode, chosen);
        }

        private void heap_Click(object sender, RoutedEventArgs e)
        {
            chosen = Algorithm.heap;
            open(mode, chosen);
        }

        private void quick_Click(object sender, RoutedEventArgs e)
        {
            chosen = Algorithm.quick;
            open(mode, chosen);
        }
    }
}
