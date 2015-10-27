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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConsulta f = new FormConsulta();
            f.ShowDialog();

            textBox1.Text = Convert.ToString(f.idform);

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
