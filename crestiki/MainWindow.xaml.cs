using System;
using System.Windows;

namespace crestiki
{
    public partial class MainWindow : Window
    {
        // Переменная для хранения текущего символа (x или o)
        string xo = "x";

        // Флаг, указывающий на окончание игры
        bool konec = false;

        // Генератор случайных чисел
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Метод для перезапуска игры
        private void Restart()
        {
            // Очищаем все ячейки и включаем их
            _1.Content = String.Empty;
            _1.IsEnabled = true;
            _2.Content = String.Empty;
            _2.IsEnabled = true;
            _3.Content = String.Empty;
            _3.IsEnabled = true;
            _4.Content = String.Empty;
            _4.IsEnabled = true;
            _5.Content = String.Empty;
            _5.IsEnabled = true;
            _6.Content = String.Empty;
            _6.IsEnabled = true;
            _7.Content = String.Empty;
            _7.IsEnabled = true;
            _8.Content = String.Empty;
            _8.IsEnabled = true;
            _9.Content = String.Empty;
            _9.IsEnabled = true;

            // Очищаем результат
            Result.Content = String.Empty;

            // Меняем символ (x или o)
            xo = xo == "x" ? "o" : "x";
        }

        // Метод для остановки игры
        private void Stop()
        {
            // Отключаем все ячейки
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;
        }

        // Метод для хода компьютера
        private void bot()
        {
            // Генерируем случайное число от 0 до 8
            int a = rnd.Next(9);

            // Проверяем, можно ли сделать ход в случайную ячейку, и делаем его
            // Если ячейка занята, вызываем метод заново (рекурсия)
            if (a == 0 && _1.IsEnabled == true)
            { _1.Content = xo; _1.IsEnabled = false; xo = xo == "x" ? "o" : "x"; }
            else if (a == 1 && _2.IsEnabled == true)
            { _2.Content = xo; _2.IsEnabled = false; xo = xo == "x" ? "o" : "x"; }
            else if (a == 2 && _3.IsEnabled == true)
            { _3.Content = xo; _3.IsEnabled = false; xo = xo == "x" ? "o" : "x"; }
            else if (a == 3 && _4.IsEnabled == true)
            { _4.Content = xo; _4.IsEnabled = false; xo = xo == "x" ? "o" : "x"; }
            else if (a == 4 && _5.IsEnabled == true)
            { _5.Content = xo; _5.IsEnabled = false; xo = xo == "x" ? "o" : "x"; }
            else if (a == 5 && _6.IsEnabled == true)
            { _6.Content = xo; _6.IsEnabled = false; xo = xo == "x" ? "o" : "x"; }
            else if (a == 6 && _7.IsEnabled == true)
            { _7.Content = xo; _7.IsEnabled = false; xo = xo == "x" ? "o" : "x"; }
            else if (a == 7 && _8.IsEnabled == true)
            { _8.Content = xo; _8.IsEnabled = false; xo = xo == "x" ? "o" : "x"; }
            else if (a == 8 && _9.IsEnabled == true)
            { _9.Content = xo; _9.IsEnabled = false; xo = xo == "x" ? "o" : "x"; }
            else if (_1.IsEnabled == false && _2.IsEnabled == false && _3.IsEnabled == false && _4.IsEnabled == false && _5.IsEnabled == false && _6.IsEnabled == false && _7.IsEnabled == false && _8.IsEnabled == false && _9.IsEnabled == false)
            { }
            else bot();
        }

        // Метод для проверки победы
        private void Pobeda()
        {
            // Проверка для всех возможных комбинаций победы и ничьи
            if (_1.Content == _2.Content && _2.Content == _3.Content && _1.IsEnabled == false == _2.IsEnabled == false && _3.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_4.Content == _5.Content && _5.Content == _6.Content && _4.IsEnabled == false == _5.IsEnabled == false && _6.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_7.Content == _8.Content && _8.Content == _9.Content && _7.IsEnabled == false == _8.IsEnabled == false && _9.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_1.Content == _4.Content && _4.Content == _7.Content && _1.IsEnabled == false == _4.IsEnabled == false && _7.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_2.Content == _5.Content && _5.Content == _8.Content && _2.IsEnabled == false == _5.IsEnabled == false && _8.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_3.Content == _6.Content && _6.Content == _9.Content && _3.IsEnabled == false == _6.IsEnabled == false && _9.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_1.Content == _5.Content && _5.Content == _9.Content && _1.IsEnabled == false == _5.IsEnabled == false && _9.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else if (_3.Content == _5.Content && _5.Content == _7.Content && _3.IsEnabled == false == _5.IsEnabled == false && _7.IsEnabled == false)
            {
                Stop();
                konec = true;
            }
            else
            {
                if (_1.IsEnabled == false && _2.IsEnabled == false && _3.IsEnabled == false && _4.IsEnabled == false && _5.IsEnabled == false && _6.IsEnabled == false && _7.IsEnabled == false && _8.IsEnabled == false && _9.IsEnabled == false)
                {
                    Result.Content = "Ничья";
                }
            }

            // Выводим результат игры
            if (konec == true)
            {
                if (xo == "x") { Result.Content = "параша 🚽"; }
                else Result.Content = "Победа за x";
            }
        }

        // Обработчики событий для ячеек поля
        private void _1_Click_1(object sender, RoutedEventArgs e)
        {
            _1.Content = xo;
            _1.IsEnabled = false;
            xo = xo == "x" ? "o" : "x";
            Pobeda();
            bot();
            Pobeda();
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            _2.Content = xo;
            _2.IsEnabled = false;
            xo = xo == "x" ? "o" : "x";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            _3.Content = xo;
            _3.IsEnabled = false;
            xo = xo == "x" ? "o" : "x";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            _4.Content = xo;
            _4.IsEnabled = false;
            xo = xo == "x" ? "o" : "x";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            _5.Content = xo;
            _5.IsEnabled = false;
            xo = xo == "x" ? "o" : "x";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            _6.Content = xo;
            _6.IsEnabled = false;
            xo = xo == "x" ? "o" : "x";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            _7.Content = xo;
            _7.IsEnabled = false;
            xo = xo == "x" ? "o" : "x";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            _8.Content = xo;
            _8.IsEnabled = false;
            xo = xo == "x" ? "o" : "x";
            Pobeda();
            bot();
            Pobeda();

        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            _9.Content = xo;
            _9.IsEnabled = false;
            xo = xo == "x" ? "o" : "x";
            Pobeda();
            bot();
            Pobeda();
        }

        // Обработчик события нажатия кнопки "Перезапуск"
        private void restart_Click(object sender, RoutedEventArgs e)
        {
            konec = false;
            Restart();
        }
    }
}
