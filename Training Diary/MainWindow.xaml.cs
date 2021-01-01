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


namespace Training_Diary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {

            int index = int.Parse(((Button)e.Source).Uid);
            GridCursorMenu.Margin = new Thickness(0 + index * 170, -5, 0, 0);
            //Main.Content = new Calendar();
        }

        private void Statistic_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            GridCursorMenu.Margin = new Thickness(0 + index * 170, -5, 0, 0);
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            GridCursorMenu.Margin = new Thickness(0 + index * 170, -5, 0, 0);
        }

        private void Developers_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            GridCursorMenu.Margin = new Thickness(0 + index * 170, -5, 0, 0);
        }
    }
}
