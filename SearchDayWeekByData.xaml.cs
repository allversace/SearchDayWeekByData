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

namespace WpfApp6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            year.MaxLength = 4;
            month.MaxLength = 2;
            day.MaxLength = 2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (month.Text != "" && day.Text != "" && year.Text != "")
            {
                int d1 = Convert.ToInt32(day.Text);
                int m1 = Convert.ToInt32(month.Text);
                int y1 = Convert.ToInt32(year.Text);
                
                if (y1 != 2023 || d1 <= 0 || d1 > 31 || m1 <= 0 || m1 > 12)
                {
                    MessageBox.Show("Введены не коректные данные");
                }
                else
                {
                    DateTime dt = new DateTime(y1, m1, d1);
                    MessageBox.Show(dt.ToString("dddd", System.Globalization.CultureInfo.CurrentCulture));
                }
            }
            else
            {
                MessageBox.Show("Введены не коректные данные");
            }
            
        }

        private void year_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void month_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void day_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
