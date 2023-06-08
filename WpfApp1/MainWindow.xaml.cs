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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bt1.Click += Bt1_Click;
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            textblock1.Text = "button 1 works";
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "button 2 works";
        }
    }
}
