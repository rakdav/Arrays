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

namespace Arrays
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] mas;
        public MainWindow()
        {
            InitializeComponent();
            int[] mas1 = { 1, 5, 8, 3, 2, 9 };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n= int.Parse(Razmer.Text);
                mas = new int[n];
                Random rnd = new Random();
                string st = "";
                for(int i=0;i<mas.Length;i++)
                {
                    mas[i] = rnd.Next(21)-10;
                    st += mas[i] + " ";
                }
                Result.Text = st+Environment.NewLine;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(chislo.Text);
                int index = Array.LastIndexOf(mas,n);
                Result.Text +="Индекс последнего вхождения "+ index.ToString()+Environment.NewLine;
                int k = 0;
                foreach(int i in mas)
                {
                    if (i < n) k++;
                }
                Result.Text += "Количество элементов меньше "+n+":"+k.ToString()+Environment.NewLine;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int max = mas[0];
            for(int i=0;i<mas.Length;i++)
            {
                if (mas[i] > max) max = mas[i];
            }
            Result.Text += "Максимальный элемент:" +max.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string st = "";
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0) mas[i] = mas[i] * mas[i];
                else if (mas[i] > 0) mas[i] += 7;
                st += mas[i] + " ";
            }
            Result.Text += "Измененный массив:"+Environment.NewLine+st;
        }
    }
}
