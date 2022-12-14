namespace NakladAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NakladniAuto Scania = new NakladniAuto("a", 1);
        Tahac Mann = new Tahac("a", 1,1);
        private void button1_Click(object sender, EventArgs e)
        {
            Scania = new NakladniAuto(maskedTextBox1.Text, (int)numericUpDown1.Value);
            Mann = new Tahac(maskedTextBox1.Text, (int)numericUpDown1.Value,(int)numericUpDown4.Value);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Mann.NalozNaklad((int)numericUpDown2.Value);
                MessageBox.Show(Mann.ToString());
            }
            else
            {

            
            Scania.NalozNaklad((int)numericUpDown2.Value);
            MessageBox.Show(Scania.ToString());
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Mann.VylozNaklad((int)numericUpDown3.Value);
                MessageBox.Show(Mann.ToString());
            }
            else
            {
                Scania.VylozNaklad((int)numericUpDown3.Value);
                MessageBox.Show(Scania.ToString());
            }
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Maximum = (int)numericUpDown1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
      
    }
}