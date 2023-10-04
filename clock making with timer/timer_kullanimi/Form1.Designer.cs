namespace timer_kullanimi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.lblhour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblminute = new System.Windows.Forms.Label();
            this.lblspilsec = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.lblhaf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.Control;
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(17, 129);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(285, 37);
            this.start.TabIndex = 0;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhour
            // 
            this.lblhour.AutoSize = true;
            this.lblhour.Location = new System.Drawing.Point(192, 85);
            this.lblhour.Name = "lblhour";
            this.lblhour.Size = new System.Drawing.Size(30, 24);
            this.lblhour.TabIndex = 1;
            this.lblhour.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblminute
            // 
            this.lblminute.AutoSize = true;
            this.lblminute.Location = new System.Drawing.Point(272, 85);
            this.lblminute.Name = "lblminute";
            this.lblminute.Size = new System.Drawing.Size(30, 24);
            this.lblminute.TabIndex = 2;
            this.lblminute.Text = "00";
            // 
            // lblspilsec
            // 
            this.lblspilsec.AutoSize = true;
            this.lblspilsec.Location = new System.Drawing.Point(488, 85);
            this.lblspilsec.Name = "lblspilsec";
            this.lblspilsec.Size = new System.Drawing.Size(30, 24);
            this.lblspilsec.TabIndex = 3;
            this.lblspilsec.Text = "00";
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Location = new System.Drawing.Point(353, 85);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(30, 24);
            this.lblsec.TabIndex = 4;
            this.lblsec.Text = "00";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(108, 85);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(30, 24);
            this.lblday.TabIndex = 1;
            this.lblday.Text = "00";
            // 
            // lblhaf
            // 
            this.lblhaf.AutoSize = true;
            this.lblhaf.Location = new System.Drawing.Point(26, 85);
            this.lblhaf.Name = "lblhaf";
            this.lblhaf.Size = new System.Drawing.Size(30, 24);
            this.lblhaf.TabIndex = 1;
            this.lblhaf.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "WEEK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "DAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "HOUR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "MINUTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "SECOND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "SPLİT SECOND";
            // 
            // clear
            // 
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.clear.Location = new System.Drawing.Point(148, 182);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(275, 37);
            this.clear.TabIndex = 6;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // stop
            // 
            this.stop.ForeColor = System.Drawing.Color.Red;
            this.stop.Location = new System.Drawing.Point(321, 129);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(263, 37);
            this.stop.TabIndex = 7;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 231);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.lblspilsec);
            this.Controls.Add(this.lblminute);
            this.Controls.Add(this.lblhaf);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.lblhour);
            this.Controls.Add(this.start);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblhour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblminute;
        private System.Windows.Forms.Label lblspilsec;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lblhaf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button start;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button stop;
    }
}

