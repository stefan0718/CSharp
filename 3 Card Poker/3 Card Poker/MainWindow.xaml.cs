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

namespace _3_Card_Poker
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

        // if click window other than tb_name, clear focus
        private void windowMouseDown(object sender, RoutedEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        // hide hint if tb_name got focus
        private void tb_name_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            l_name.Visibility = Visibility.Collapsed;
            tb_name.Background = Brushes.White;
        }

        // show hint if tb_name lost focus & is empty
        private void tb_name_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_name.Text))
            {
                l_name.Visibility = Visibility.Visible;
                tb_name.Background = Brushes.Transparent;
            }
        }

        private void b_start_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Uri("TablePage.xaml", UriKind.Relative));
        }
    }
}
