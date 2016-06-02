using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bartenderexpressReloaded
{
    public partial class BAC_Calculator : Form
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public BAC_Calculator()
        {
            InitializeComponent();
            CueProvider CreateaCue = new CueProvider();
            CreateaCue.SetCue(valDrinks, "Enter Number of Drinks...");
            CreateaCue.SetCue(valWeight, "Enter your Body Weight (lbs)...");
            CreateaCue.SetCue(valHours, "Enter Hours since first drink...");
        }

        private void BAC_Calculator_Load(object sender, EventArgs e)
        {
               
        }

        public void calc(object sender, System.EventArgs e)
        {
            //Widmark Formula % BAC = (A x 5.14 / W x r) -.015 x H
            double A = Convert.ToDouble(valDrinks.Text);
            double W = Convert.ToDouble(valWeight.Text);
            double H = Convert.ToDouble(valHours.Text);
            double rFem = 0.66;
            double rmale = 0.73;
            double BAC;



            if (radFemale.Checked)
            {
                BAC = (A * 5.14) / (W * rFem) - .015 * H;
            }
            else
            {
                BAC = (A * 5.14) / (W * rmale) - .015 * H;
            }
            if (BAC < 0)
            {
                BAC = 0.00;
            }

            lblBAC.Text = (BAC.ToString("0.#####"));

            if (BAC >= 0.00 && BAC < 0.02)
            {
                lblAnalysis.Text = "Sober State";
                lblAnalysis2.Text = "";
                lblAnalysis3.Text = "";
            }

            if (BAC >= 0.02 && BAC < 0.05)
            {
                lblAnalysis.Text = "Loss of Judgment";
                lblAnalysis2.Text = "Trouble doing two tasks at the same time";
                lblAnalysis3.Text = "";
                lblBAC.ForeColor = Color.Black;
                timer1.Enabled = false;
            }
            else if (BAC >= 0.05 && BAC < 0.08)
            {
                lblAnalysis.Text = "Reduced coordination and ability to track moving objects";
                lblAnalysis2.Text = "Difficulty steering";
                lblAnalysis3.Text = "";
                lblBAC.ForeColor = Color.Black;
                timer1.Enabled = false;
            }
            else if (BAC >= 0.08 && BAC < 0.10)
            {
                lblAnalysis.Text = "Trouble controlling speed";
                lblAnalysis2.Text = "Difficulty processing information and reasoning";
                lblAnalysis3.Text = "0.08% and over is legally impaired in all states";
                timer1.Start();
                timer1.Enabled = true;

            }
            else if (BAC >= 0.10 && BAC < 0.15)
            {
                lblAnalysis.Text = "Markedly slowed reaction time";
                lblAnalysis2.Text = "Difficulty staying in lane and braking when needed";
                lblAnalysis3.Text = "0.08% and over is legally impaired in all states";
                timer1.Start();
                timer1.Enabled = true;
            }
            else if (BAC >= 0.15)
            {
                lblAnalysis.Text = "Serious difficulty controlling the car and focusing on driving";
                lblAnalysis2.Text = "0.08% and over is legally impaired in all states";
                lblAnalysis3.Text = "";
                timer1.Start();
                timer1.Enabled = true;
            }
        }

        private void lblAnalysis2_Click(object sender, EventArgs e)
        {

        }

        private void valWeight_Enter(object sender, EventArgs e)
        {
            valWeight.Enabled = false;
            valWeight.Enabled = true;
        }


      
        private void valWeight_TextChanged(object sender, EventArgs e)
        {
            HideCaret(valWeight.Handle);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            valWeight.Clear();
            valDrinks.Clear();
            valHours.Clear();
            lblAnalysis.Text ="";
            lblAnalysis2.Text = "";
            lblAnalysis3.Text = "";
            lblBAC.Text = "";
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            lblBAC.ForeColor = Color.FromArgb(A, R, G, B);
        }
    }
}
