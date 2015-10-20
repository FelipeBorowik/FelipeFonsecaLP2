using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuladeFormsComXico
{
    public partial class Entrada : Form
    {
        public string Dado;

        public Entrada()
        {
            InitializeComponent();
                    

        }

        private void Entrada_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Dado = textBox1.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Preencha o text box");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
