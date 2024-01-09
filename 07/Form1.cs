// Импортируем необходимые пространства имен
using System;
using System.Text.RegularExpressions; // Импортируем пространство имен для использования регулярных выражений
using System.Windows.Forms;

namespace _07
{
    public partial class Form1 : Form
    {
        // Глобальная переменная видна всем методам
        int[] Mas = new int[14];

        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик события нажатия на кнопку
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Создаем экземпляр класса Random
            Random rand = new Random();

            // Заполняем массив случайными числами и выводим их на ListBox
            for (int i = 0; i < 14; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }

            int sum = 0; // Переменная для хранения суммы чисел со второго отрицательного элемента массива
            int firstNegativeIndex = -1; // Индекс первого отрицательного элемента массива

            // Вычисляем сумму и находим индекс первого отрицательного элемента
            for (int i = 0; i < 14; i++)
            {
                if (firstNegativeIndex == -1 && Mas[i] < 0)
                {
                    firstNegativeIndex = i;
                }

                if (firstNegativeIndex == -1)
                {
                    sum += Mas[i];
                }
            }

            // Выводим на ListBox сумму чисел со второго отрицательного элемента массива
            listBox2.Items.Add(+sum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Код, который выполняется при загрузке формы
        }
    }
}