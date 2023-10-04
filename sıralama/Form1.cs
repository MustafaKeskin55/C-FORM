using System.Collections;
using System.Windows.Forms;

namespace sıralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

           

            ArrayList list = new ArrayList();
            foreach (var o in listBox1.Items)
            {
                list.Add(o);
            }
            DialogResult result1 = MessageBox.Show("Büyükten kücüğe ise evet değil ise hayıra basınız", "secim yapınız", MessageBoxButtons.YesNo);
            if (result1==DialogResult.Yes)
            {
                list.Sort();
                list.Reverse();
                listBox1.Items.Clear();
                foreach (var o in list)
                {
                    listBox1.Items.Add(o);
                }
                

            }
            if (result1 == DialogResult.Yes)
            {
                list.Sort();
                
                listBox1.Items.Clear();
                foreach (var o in list)
                {
                    listBox1.Items.Add(o);
                }


            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}