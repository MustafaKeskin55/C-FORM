using System.Windows.Forms;

namespace giris_arayüzü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = "defult";
            string sifre = "password";
            if (kullaniciadi==textBox1.Text  )
            {
                if (sifre==textBox2.Text)
                {
                    MessageBox.Show("başarılı");
                } 
            } if (textBox1.Text=="")
                {
                    errorProvider1.SetError(textBox1, "kullanıcı adını girin");
                    MessageBox.Show("kullanıcı adını girin");
                }
              if (textBox2.Text=="")
                {
                    errorProvider2.SetError(textBox2, "şifre  girin");
                     MessageBox.Show("şifrenizi girin");
                }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}