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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true)
            {
                textBox.Text = passwordBox.Password;
                passwordBox.Visibility = Visibility.Collapsed;
                textBox.Visibility = Visibility.Visible;
            }
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == false)
            {
                passwordBox.Password = textBox.Text;
                passwordBox.Visibility = Visibility.Visible;
                textBox.Visibility = Visibility.Collapsed;
            }
        }
    }
}
