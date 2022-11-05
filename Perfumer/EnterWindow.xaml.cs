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

namespace Perfumer
{
    /// <summary>
    /// Логика взаимодействия для EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {
        public EnterWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            if (Login.Text == "" || Password.Text == "")
                MessageBox.Show("Введите все данные!");
            else
               flag = new Functions().Entry(Login.Text, Password.Text);
            if (flag)
                Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            new MainWindow().Show();
        }
    }
}
