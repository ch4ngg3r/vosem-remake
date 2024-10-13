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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Добавьте этот метод в C#-файл!
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Создаем массив из 20 случайных чисел в диапазоне (-100; 100)
            Random random = new Random();
            int[] numbers = Enumerable.Range(0, 20).Select(x => random.Next(-100, 101)).ToArray();

            // Находим самое маленькое число
            int x = numbers.Min();

            // Находим два самых больших числа
            int[] topTwo = numbers.OrderByDescending(n => n).Take(2).ToArray();
            int y = topTwo[0];
            int z = topTwo[1];

            // Выводим результаты в TextBlock'и
            MinNumber.Text = x.ToString();
            MaxNumber1.Text = y.ToString();
            MaxNumber2.Text = z.ToString();
        }

        private void qwe_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(MinNumber.Text);
            int y = int.Parse(MaxNumber1.Text); 
            int z = int.Parse(MaxNumber2.Text); 
            int result = (x * y) + (1 - z);
            string qwe = Convert.ToString(result);
            yrav.Text = qwe;


        }
    }
    
}