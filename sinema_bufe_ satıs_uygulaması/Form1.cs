namespace sinema_bufe__satıs_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet,toplam;
            misir = Convert.ToInt16(txtmisir.Text);
            su = Convert.ToInt16(txtsu.Text);
            cay = Convert.ToInt16(txtcay.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            toplam = misir * 35 + su * 5 + cay * 8 + bilet * 65;
            lbltoplam.Text = toplam.ToString() + " TL ";
            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmisir.Text = "";
            txtsu.Text = "";
            txtcay.Text = "";
            txtbilet.Text = "";
            txtmisir.Focus();
        }
    }
}