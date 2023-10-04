using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            
             InitializeComponent();
            start.BackColor = Color.White;



        } 

        private void button1_Click(object sender, EventArgs e) 
        {
            
            timer1.Start();
        }
        int sec = 0, minute = 0, hour = 0, day = 0, spilsec = 0, week=0;

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            spilsec = 0;
            hour = 0;
            sec = 0;
            minute = 0;
            day = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop ();
            spilsec = 0;
            hour = 0;
            sec = 0;
            minute = 0;
            day = 0;
            lblspilsec.Text = "0";
            lblsec.Text = "0";
            lblminute.Text = "0";
            lblhour.Text = "0";
            lblday.Text = "0";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            spilsec++;
            lblspilsec.Text = spilsec.ToString();
            if (spilsec == 60)
            {
                sec++;
                lblsec.Text=sec.ToString();
                spilsec = 0;
                if (sec==60)
                {
                    minute++;
                    lblminute.Text = minute.ToString();
                    sec = 0;
                }
                if (minute == 60){
                    hour++;
                    lblhour.Text = hour.ToString();

                    minute = 0;
                }
                if (hour == 24)

                {
                    day++;
                    lblday.Text = day.ToString();
                   
                    
                }
                if (day == 7) {
                    timer1.Stop();

                    week++;
                    lblhaf.Text = week.ToString();
                    day = 0;
                    DialogResult uyarı = new DialogResult();
                    uyarı =MessageBox.Show("Bir gün tamalandi","UYARI",MessageBoxButtons.YesNo);
                    
                    if (uyarı==DialogResult.Yes)
                    {
                        timer1.Start();
                        spilsec = 0;
                        hour = 0; 
                        sec=0;
                        minute= 0;
                        day = 0;
                        lblspilsec.Text="0";
                        lblsec.Text = "0";
                        lblminute.Text = "0";
                        lblhour.Text = "0";
                        lblday.Text = "0";

                    }

                     
                }
                if (hour> 12)
                {
                    this.BackColor = Color.Brown;

                    



                }
                 if (hour <12)

                {

                    this.BackColor = Color.Yellow;


                }
            }




        }
    }
}
