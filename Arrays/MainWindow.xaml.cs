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
        int[,] mas2;
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(Razmer.Text);
                int m = int.Parse(Column.Text);
                mas2 = new int[n,m];
                Random rnd = new Random();
                string st = "";
                for(int i=0;i<n;i++)
                {
                    for(int j=0;j<m;j++)
                    {
                        mas2[i,j] = rnd.Next(11)-5;
                        st += mas2[i,j] + " ";
                    }
                    st += Environment.NewLine;
                }
                Result.Text = st;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int min = int.MaxValue;
            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;
            for (int i=0;i<rows;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    if (mas2[i, j] < min) min = mas2[i,j];
                }
            }
            Result.Text += "Минимальный элемент массива:" + min+Environment.NewLine;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string st = "";
            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mas2[i, j] % 2 == 0) mas2[i, j] *= 2;
                    else mas2[i, j] *= 3;
                    st += mas2[i, j] + " ";
                }
                st += Environment.NewLine;
            }
            Result.Text += st;
            int min = int.MaxValue;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mas2[i, j] < min) min = mas2[i, j];
                }
            }
            Result.Text += "Минимальный элемент массива:" + min + Environment.NewLine;
        }
    }
}
