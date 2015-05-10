using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizSharp.Properties;

namespace QuizSharp
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            
            InitializeComponent();
        
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NewGame nova = new NewGame();
            nova.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            Image food = Resources.btn_NewGame_hover;
            pictureBox4.Image = food;
        }


       

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            Image food = Resources.btn_NewGame_hover;
            pictureBox4.Image = food;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Image food = Resources.btn_NewGame;
            pictureBox4.Image = food;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Image food = Resources.btn_HowToPlay_hover;
            pictureBox2.Image = food;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Image food = Resources.btn_HowToPlay;
            pictureBox2.Image = food;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Image food = Resources.btn_Exit_hover;
            pictureBox3.Image = food;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Image food = Resources.btn_Exit;
            pictureBox3.Image = food;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            NewGame nova = new NewGame();
            nova.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            Image img = Resources.logobg_hover;
            pictureBox6.Image = img;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Image img = Resources.logobg;
            pictureBox6.Image = img;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            HowToPlay nova = new HowToPlay();
            nova.Show();
            this.Hide();
        }


       
    }
}
