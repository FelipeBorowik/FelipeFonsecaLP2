using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string presente1 = txtPresente1.Text;
            string presente2 = txtPresente2.Text;
            string presente3 = txtPresente3.Text;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {            
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);

            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;

            command.CommandText = String.Format("INSERT INTO PRESENTES (NOME, SOBRENOME, PRESENTE, PRESENTE2, PRESENTE3) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", txtNome.Text, txtSobrenome.Text, txtPresente1.Text, txtPresente2.Text, txtPresente3.Text);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

            txtNome.Clear();
            txtSobrenome.Clear();
            txtPresente1.Clear();
            txtPresente2.Clear();
            txtPresente3.Clear();
        }
    }
}
