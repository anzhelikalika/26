using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Levels
{
    public partial class Form1 : Form
    {
        //Хранит класс первого уровня
        private ParentAntenna pa;
        //Хранит класс второго уровня
        private HeirAntenna ha;
        public Form1()
        {
            InitializeComponent();
            //Добавление типов антен в comboBox для второго класса
            comboBox1.Items.Add("Азимутальная");
            comboBox1.Items.Add("Полярная");
            comboBox1.Items.Add("Тороидальная");
        }
        //Событие нажатия первой кнопки информации
        private void bInfo1_Click(object sender, EventArgs e)
        {
            //Очищение табло в случае повторной записи
            richTextBox1.Text = String.Empty;
            //Использование конструктора для задания значений
            pa = new ParentAntenna(Convert.ToDouble(tDiameter1.Text), 
                tMaterial1.Text, 
                Convert.ToDouble(tCost1.Text));
            //Заполнение табло информацией из класса
            richTextBox1.Text = pa.GetInfo();
            //Вывод качества по формуле
            richTextBox1.Text += "Качество: " + pa.Quality() + '\n';
        }
        //Событие нажатия второй кнопки информации
        private void bInfo2_Click(object sender, EventArgs e)
        {
            //
            //Аналогично
            //
            richTextBox2.Text = String.Empty;
            ha = new HeirAntenna(Convert.ToDouble(tDiameter2.Text), 
                tMaterial2.Text, 
                Convert.ToDouble(tCost2.Text), 
                //Передаёт индекс выбранного значения
                comboBox1.SelectedIndex);
            richTextBox2.Text = ha.GetInfo();
            richTextBox2.Text += "Качество: " + ha.Quality() + '\n';
        }
    }
}
