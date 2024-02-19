using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_6_Mayın_Tarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblskor.Text = "0";
        }

        private void btnuret_Click(object sender, EventArgs e)
        {
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;
            Random rnd = new Random();
            mayin1=rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin3 = rnd.Next(41, 50);
            for (int i = 1; i < 50; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(35, 35);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;
                if (mayin1==i||mayin2==i||mayin3==i)
                {
                    btnTemp.Tag = true;
                }
                else
                {
                    btnTemp.Tag = false;
                }
                //btnTemp.Tag = null;
                btnTemp.Click += BtnTemp_Click;
                flowLayoutPanel1.Controls.Add(btnTemp);
            }
        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            Button basilanbuton = ((Button)sender);
            bool mayinBulundumu = (bool)basilanbuton.Tag;
            if (mayinBulundumu)
            {
                MessageBox.Show("Mayına Bastınız..");
                basilanbuton.BackColor = Color.Red;
                int mayınInt = int.Parse(lblmayın.Text);
                mayınInt++;
                lblmayın.Text = mayınInt.ToString();
                if (mayınInt==3)
                {
                    MessageBox.Show("Game Over");
                }
            }
            else
            {
                basilanbuton.BackColor = Color.Green;
                int skorInt = int.Parse(lblskor.Text);
                skorInt++;
                lblskor.Text = skorInt.ToString();
            }
        }
    }
}
