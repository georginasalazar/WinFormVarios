using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsVariosForms
{
    public partial class Form2 : Form
    {
        private string nom = "";
        public Form2(string nombre)
        {
            this.nom = nombre;
            InitializeComponent();
            this.textBoxNombre.Text = this.nom;
        }
        public Form2()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

   
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("adios");
            this.Close();

        }
    }
}
