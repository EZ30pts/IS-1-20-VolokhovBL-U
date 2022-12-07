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
    public partial class Zadanie5 : Form
    {
        public Zadanie5()
        {
            InitializeComponent();
        }
        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_7;database=is_1_20_st7_KURS;password=70179163;";
        MySqlConnection conn;

        private void Zadanie5_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand command = new MySqlCommand($"INSERT INTO t_Uchebka_Volokhov (`fioStud`, `datetimeStud`) VALUES (@fio, @datetime);", conn);

                command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio.Text;
                command.Parameters.Add("@datetime", MySqlDbType.VarChar).Value = datetime.text;

                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись добавлена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM t_Uchebka_Volokhov;", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int grid = dataGridView1.Rows.Add();
                dataGridView1.Rows[grid].Cells[0].Value = reader[0].ToString();
                dataGridView1.Rows[grid].Cells[1].Value = reader[1].ToString();
                dataGridView1.Rows[grid].Cells[2].Value = DateTime.Parse(reader[2].ToString());
            }

            reader.Close();
        }
    }
}
