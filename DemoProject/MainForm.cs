using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(1, 11);

            switch (number)
            {
                case 1:
                    button1.BackColor = Color.Red;
                    break;

                case 2:
                    button1.BackColor = Color.Blue;
                    break;

                case 3:
                    button1.BackColor = Color.Violet;
                    break;

                case 4:
                    button1.BackColor = Color.Pink;
                    break;

                case 5:
                    button1.BackColor = Color.Orange;
                    break;

                case 6:
                    button1.BackColor = Color.Yellow;
                    break;

                case 7:
                    button1.BackColor = Color.LightGreen;
                    break;

                case 8:
                    button1.BackColor = Color.Cyan;
                    break;

                case 9:
                    button1.BackColor = Color.Indigo;
                    break;

                case 10:
                    button1.BackColor = Color.Gray;
                    break;
            }
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            int count = int.Parse(Count.Text);
            count++;
            Count.Text = count.ToString();
        }
    }
}
