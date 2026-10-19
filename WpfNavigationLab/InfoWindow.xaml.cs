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

namespace WpfNavigationLab
{
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void Hello_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Add meg a neved!");
                return;
            }

            MessageBox.Show($"Szia {txtName.Text.Trim()}!");
        }

        private void Title_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Add meg a neved!");
                return;
            }

            Title = txtName.Text.Trim();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
