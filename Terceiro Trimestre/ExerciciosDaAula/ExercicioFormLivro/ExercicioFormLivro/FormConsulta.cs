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

namespace ExercicioFormLivro
{
    public partial class FormConsulta : Form
    {
        int codigolivro;

        public int idform;
        string tituloform;
        int isbnform;
        string idgenero;
        double idpreco;
        string autor; 

        public FormConsulta()
        {
         
            InitializeComponent();
         
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {

  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigolivro = int.Parse(textBox1.Text);
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            string query = string.Format("SELECT * FROM Livro WHERE ISBN = '{0}'", codigolivro);
                        
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = query;
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idform = reader.GetInt32(0);
                }

                reader.Close();
                conn.Close();
            }

            Close();
        }
    }
}
