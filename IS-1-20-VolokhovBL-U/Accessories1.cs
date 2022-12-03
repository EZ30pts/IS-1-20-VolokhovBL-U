using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_VolokhovBL_U
{
    public partial class Accessories1 : Form
    {
        public Accessories1()
        {
            InitializeComponent();
        }

        class Components<T>
        {
            public double Price;
            public int GodVypuska;
            public T Article;
            public Components(double price, int godVypuska ,T article)
            {
                Price = price;
                GodVypuska = godVypuska;
                Article = article;
            }

            public void Display()
            {
                 MessageBox.Show($"Цена: {Price} \n Год выпуска: {GodVypuska} \n Артикул{Article}");
            }
        }

        class Hdd : Components<string>
        {
            public int Numberofturns;
            public string Interface1;
            public int Size;

            public Hdd(int numberofturns, string interface1, string article ,int size, double price, int godVypuska) : base(price, godVypuska, article)
            {
                Numberofturns = numberofturns;
                Interface1 = interface1;
                Size = size;
            }

            public new void Display()
            {
                MessageBox.Show($"Количество Оборотов{Numberofturns} \n Интерфейс{Interface1} \n Артикул{Article} \n Объем{Size} \n Цена: {Price} \n Год выпуска: {GodVypuska} ");
            }
        }

        class VideoCard : Components<string>
        {
            public int FrequencyCPU;
            public string Manufacturer;
            public int SizeMemory;

            public VideoCard(int frequencycpu, string manufacturer, string article ,int sizememory, double price, int godVypuska): base(price, godVypuska, article)
            {
                FrequencyCPU = frequencycpu;
                Manufacturer = manufacturer;
                SizeMemory = sizememory;
            }

            public new void Display()
            {
                MessageBox.Show($"Частота{FrequencyCPU} \n Производитель{Manufacturer} \n Артикул{Article} \n Объем памяти{SizeMemory} \n Цена: {Price} \n Год выпуска: {GodVypuska} ");
            }
        }

        Hdd hdd;
        VideoCard gpu;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"Кол-во оборотов {textBox1.Text}");
            listBox1.Items.Add($"Интерфейс {textBox2.Text}");
            listBox1.Items.Add($"Артикул {textBox3.Text}");
            listBox1.Items.Add($"Объем {textBox4.Text}");
            listBox1.Items.Add($"Цена {textBox5.Text}");
            listBox1.Items.Add($"Год {textBox6.Text}");
            hdd = new Hdd(Convert.ToInt32(textBox1.Text),textBox2.Text, 
                textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            hdd.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"Частота {textBox1.Text}");
            listBox1.Items.Add($"Производитель {textBox2.Text}");
            listBox1.Items.Add($"Артикул {textBox3.Text}");
            listBox1.Items.Add($"Объем памяти {textBox4.Text}");
            listBox1.Items.Add($"Цена {textBox5.Text}");
            listBox1.Items.Add($"Год {textBox6.Text}");

            gpu = new VideoCard(Convert.ToInt32(textBox1.Text), textBox2.Text,
                textBox3.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text));
            gpu.Display();

        }
    }
}
