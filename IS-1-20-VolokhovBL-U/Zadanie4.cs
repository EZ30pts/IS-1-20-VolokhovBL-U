﻿using System;
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
    public partial class Zadanie4 : Form
    {
        public Zadanie4()
        {
            InitializeComponent();
        }
        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_7;database=is_1_20_st7_KURS;password=70179163;";
        MySqlConnection conn;

        private void Zadanie4_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand($"SELECT fio, date_of_Birth FROM t_datatime;", conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int grid = dataGridView1.Rows.Add();
                    dataGridView1.Rows[grid].Cells[0].Value = reader[0].ToString();
                    dataGridView1.Rows[grid].Cells[1].Value = reader[1].ToString();
                }
                reader.Close();

            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = dataGridView1.SelectedCells[0].RowIndex + 1;

                conn.Open();

                string sql = $"SELECT photoUrl FROM t_datatime WHERE Id = {id}";

                MySqlCommand command = new MySqlCommand(sql, conn);

                string picture = command.ExecuteScalar().ToString();

                pictureBox1.ImageLocation = picture;

            }
            catch
            {
                MessageBox.Show("Ошибка загрузки фото");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}