using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*It is a digital clock we will need Timer which will
 help us in updating the time every second*/
namespace Digital_Clock 
{
    public partial class Form1 : Form
    {
        private Label label1;
        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            t.Interval = 1000;//set up the interval to 1 second.
            t.Tick += new EventHandler(this.t_Tick); // Add t_tick to time t;
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)//execute
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else 
            {
                time += ss;
            }
            time += ":";

            label1.Text = time;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(336, 84);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            t.Interval = 1000;//set up the interval to 1 second.
            t.Tick += new EventHandler(this.t_Tick); // Add t_tick to time t;
            t.Start();
        }
    }
}
