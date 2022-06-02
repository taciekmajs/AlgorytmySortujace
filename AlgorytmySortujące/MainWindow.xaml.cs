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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlgorytmySortujące
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            Selection selection = new Selection(0);
            selection.Show();
        }

        private void H2H_Click(object sender, RoutedEventArgs e)
        {
            HeadToHead headToHead = new HeadToHead();
            headToHead.Show();
        }

        private void charts_Click(object sender, RoutedEventArgs e)
        {
            Selection selection = new Selection(1);
            selection.Show();
        }
    }
}
