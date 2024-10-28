using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            label1.Text = contador.ToString();

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
            contador--;
            label1.Text = contador.ToString();
}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contador = 0;
            label1.Text = contador.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
       
    }
}
