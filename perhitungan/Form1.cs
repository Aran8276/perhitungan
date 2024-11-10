namespace perhitungan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bYa_Click(object sender, EventArgs e)
        {
            Form2 perhitungan = new Form2();
            perhitungan.Show();
        }

        private void bTidak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
