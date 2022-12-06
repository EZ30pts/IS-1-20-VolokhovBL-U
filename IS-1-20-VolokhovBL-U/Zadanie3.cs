using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_VolokhovBL_U
{
    public partial class Zadanie3 : Form
    {
        public Zadanie3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_7;database=is_1_20_st7_KURS;password=70179163;";
        MySqlConnection conn;

        private void Zadanie3_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand($"SELECT id, Goods, Category, Price" + $"FROM Catalog INNER JOIN login_password ON Catalog.id;", conn);
                
                MySqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    int grid = dataGridView1.Rows.Add();
                    dataGridView1.Rows[grid].Cells[0].Value = reader[0].ToString();
                    dataGridView1.Rows[grid].Cells[1].Value = reader[1].ToString();
                    dataGridView1.Rows[grid].Cells[2].Value = reader[2].ToString();
                    dataGridView1.Rows[grid].Cells[3].Value = reader[3].ToString();
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Goods = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Price = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            MessageBox.Show("ID: {id} \\n Товары: {Goods} \\n Категория: {Category} \\n Цена: {Price}\"");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            finally
            {
                MessageBox.Show("Подключено!");
                conn.Close();
            }
        }
    }
}
