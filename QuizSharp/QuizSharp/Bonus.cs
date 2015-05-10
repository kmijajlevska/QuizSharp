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
    public partial class Bonus : Form
    {
        public Bonus()
        {
            InitializeComponent();
        }

        private void Bonus_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string ime = "sport";
            Questions nova = new Questions();
            nova.ime = ime;
            nova.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string ime = "history";
            Questions nova = new Questions();
            nova.ime = ime;
            nova.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string ime = "science";
            Questions nova = new Questions();
            nova.ime = ime;
            nova.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string ime = "Geography";
            Questions nova = new Questions();
            nova.ime = ime;
            nova.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string ime = "entert";
            Questions nova = new Questions();
            nova.ime = ime;
            nova.Show();
            this.Close();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            Image food = Resources.btn_SportsMOUSEDOWN;
            pictureBox5.Image = food;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            Image food = Resources.btn_HistoryMOUSEDOWN;
            pictureBox6.Image = food;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Image food = Resources.btn_SportsHOVER;
            pictureBox5.Image = food;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Image food = Resources.btn_HistoryHOVER;
            pictureBox6.Image = food;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Image food = Resources.btn_ScienceMOUSEDOWN; 
            pictureBox3.Image = food;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Image food = Resources.btn_ScienceHOVER;
            pictureBox3.Image = food;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Image food = Resources.btn_GeographyMOUSEDOWN;
            pictureBox2.Image = food;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Image food = Resources.btn_GeographyHOVER;
            pictureBox2.Image = food;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            Image food = Resources.btn_ShowbizMOUSEDOWN;
            pictureBox4.Image = food;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Image food = Resources.btn_ShowbizHOVER;
            pictureBox4.Image = food;
        }
    }
}
