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
    public partial class Zadanie2 : Form
    {
        public Zadanie2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        class Subd
        {
            public MySqlConnection ConnectionBD()
            {
                string host = "chuc.caseum.ru";
                string port = "33333";
                string user = "uchebka";
                string bd = "uchebka";
                string password = "uchebka";
                string connStr = $"server={host};port={port};user={user};database={bd};password={password};";
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subd subd = new Subd();

            try
            {
                subd.ConnectionBD().Open();
            }
            catch
            {
                MessageBox.Show($"Неверные данные");
            }
            finally
            {
                MessageBox.Show($"Подключено");
                subd.ConnectionBD().Clone();
            }
        }
    }
}
