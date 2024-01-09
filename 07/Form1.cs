// ����������� ����������� ������������ ����
using System;
using System.Text.RegularExpressions; // ����������� ������������ ���� ��� ������������� ���������� ���������
using System.Windows.Forms;

namespace _07
{
    public partial class Form1 : Form
    {
        // ���������� ���������� ����� ���� �������
        int[] Mas = new int[14];

        public Form1()
        {
            InitializeComponent();
        }

        // ���������� ������� ������� �� ������
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // ������� ��������� ������ Random
            Random rand = new Random();

            // ��������� ������ ���������� ������� � ������� �� �� ListBox
            for (int i = 0; i < 14; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }

            int sum = 0; // ���������� ��� �������� ����� ����� �� ������� �������������� �������� �������
            int firstNegativeIndex = -1; // ������ ������� �������������� �������� �������

            // ��������� ����� � ������� ������ ������� �������������� ��������
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

            // ������� �� ListBox ����� ����� �� ������� �������������� �������� �������
            listBox2.Items.Add(+sum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ���, ������� ����������� ��� �������� �����
        }
    }
}