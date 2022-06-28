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

namespace HelloWorldAPPWF
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

        private void Start1_Click(object sender, RoutedEventArgs e)
        {
            string a = TextBox1.Text;
            string b = TextBox2.Text;
            int a_1 = Convert.ToInt32(a);
            int b_1 = Convert.ToInt32(b);
            int ab = a_1 + b_1;
            TextBox3.Text = ab.ToString();
        }
    }
}
