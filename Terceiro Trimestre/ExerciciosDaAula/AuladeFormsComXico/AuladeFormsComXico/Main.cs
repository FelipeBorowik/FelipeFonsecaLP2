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
    public partial class Main : Form
    {
        string buffer;

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrada F = new Entrada();
            F.ShowDialog();
            buffer = F.Dado; 
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = buffer;
        }
    }
}
