using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calc
{
    public partial class Form1 : Form
    {
        int pol;
        public Form1()
        {
            InitializeComponent();
        }
        private void Female_PB_Click(object sender, EventArgs e)
        {
            Male_PB.BackColor = Color.White;
            Female_PB.BackColor = Color.Gray;
            pol = 1;
        }

        private void Male_PB_Click(object sender, EventArgs e)
        {
            Female_PB.BackColor = Color.White;
            Male_PB.BackColor = Color.Gray;
            pol = 0;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ves, rost, bmi;
            rost = Double.Parse(rost_textbox.Text);
            ves = Double.Parse(ves_textbox.Text);
            if (pol == 0)
            {
                rost = rost / 100;
            }
            else {
                rost = rost / 110;
            }
            bmi = (ves) / (rost * rost);
           
           

            trackBar1.Value = Convert.ToInt32(bmi);
            this.bmi_TB.Text = bmi.ToString("0.0");

            bmi_TB.Text =trackBar1.Value.ToString();
            status.Visible = true;
            status_PB.Visible = true;
            if (bmi < 20)
            {
                status.Text = "Недовес";
                status_PB.Image = System.Drawing.Image.FromFile("C:\\Users\\29311141\\Desktop\\BMI calc\\bmi-underweight-icon.png");
                trackBar1.Value = Convert.ToInt32(bmi);
            }

            else if (bmi > 20 && bmi < 25)
            {
                status.Text = "Здоровый";
                status_PB.Image = System.Drawing.Image.FromFile("C:\\Users\\29311141\\Desktop\\BMI calc\\bmi-healthy-icon.png");
                trackBar1.Value = Convert.ToInt32(bmi);

            }
            else if (bmi > 25 && bmi < 30)
            {
                status.Text = "Избыточный вес";
                status_PB.Image = System.Drawing.Image.FromFile("C:\\Users\\29311141\\Desktop\\BMI calc\\bmi-overweight-icon.png");
                trackBar1.Value = Convert.ToInt32(bmi);
            }

            else if (bmi >30 && bmi  < 40)
            {
                status.Text = "Ожирение" ;
                status_PB.Image = System.Drawing.Image.FromFile("C:\\Users\\29311141\\Desktop\\BMI calc\\bmi-obese-icon.png");
                trackBar1.Value = Convert.ToInt32(bmi);
            }
         
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }
    }
}
