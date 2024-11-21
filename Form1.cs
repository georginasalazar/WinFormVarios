namespace WinFormsVariosForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBoxDato.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonForm1_Click(object sender, EventArgs e)
        {
            string nom = this.textBoxDato.Text;
            Form2 f2 = new Form2(nom);
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }
    }
}
