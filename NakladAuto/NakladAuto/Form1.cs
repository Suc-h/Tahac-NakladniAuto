namespace NakladAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NakladniAuto Scania = new NakladniAuto(maskedTextBox1.Text, (int)numericUpDown1.Value);
            Scania.NalozNaklad((int)numericUpDown2.Value);
            
            MessageBox.Show(Scania.ToString());
            Scania.VylozNaklad((int)numericUpDown3.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Maximum = (int)numericUpDown1.Value;
        }
    }
}