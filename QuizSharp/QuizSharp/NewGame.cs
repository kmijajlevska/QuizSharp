using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;


namespace QuizSharp
{
    public partial class NewGame : Form
    {
        public int poeni { get; set; }
        int Interval;
        int times;
        int i;
        int total;
        string name;
        int wait;

        public NewGame()
        {
            
            InitializeComponent();
            Interval = 250;
            name = "bla";
            times = 0;
            total = 0;
            wait = 0;
            
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (i == times)
            {
                timer1.Stop();
                Prashanja();
            }
            if (i == times / 2)
            {
                timer1.Interval = timer1.Interval * 2;
            }

            if (i == (3*times)/4)
            {
                timer1.Interval = timer1.Interval * 2;
            }

            Image tmp = pictureBox1.Image;
            Random r = new Random();
            
            int broj = r.Next(40,70);
            
            tmp = (Image)RotateBitmap((Bitmap)tmp, broj);
            pictureBox1.Image = tmp;
            pictureBox1.Invalidate();
           i++;
           total += broj;
           if (total > 360)
           {
               total = total - 360;
           }
        }

        public void Prashanja()
        {
            
            if(total>=30 && total<90)
            {
                name = "entert";
            }
            else if (total > 90 && total <= 150) 
            {
                name = "bonus";
            }
            else if (total >150 && total <= 215)
            {
                name = "sport";
            }
            else if (total > 215 && total < 270)
            {
                name = "history";
            }
            else if (total >= 270 && total <= 330)
            {
                name = "science";
            }
            else if( (total > 330 && total <= 360) || (total >=0 && total <30))
            {
                name = "Geography";
            }
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 100;
            timer2.Start();
           

        }


        public void Timer2_Stop()
        {
            OtvoriNova();
        }

        public void OtvoriNova()
        {
            if (wait == 50)
            {
                if (name == "bonus")
                {
                    Bonus nova = new Bonus();
                    nova.Show();
                    this.Close();
                }
                else
                {
                    Questions nova = new Questions();
                    nova.ime = name;

                    nova.Show();
                    this.Close();
                }
            }
        }


        private Bitmap RotateBitmap(Bitmap bm, float angle)
        {
            
            Bitmap result = new Bitmap(bm.Width, bm.Height);

            Matrix rotate_at_center = new Matrix();
            rotate_at_center.RotateAt(angle,
                new PointF(bm.Width / 2f, bm.Height / 2f));

          
            using (Graphics gr = Graphics.FromImage(result))
            {
               
                gr.InterpolationMode = InterpolationMode.High;

                
                gr.Clear(bm.GetPixel(0, 0));

                gr.Transform = rotate_at_center;
                gr.DrawImage(bm, 0, 0);
            }

            return result;
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = Interval;
            timer1.Start();
            Random k = new Random();
            times = k.Next(10, 25);
            i = 0;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void imelbl_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (wait == 50)
            {
                
                timer2.Stop();
                
                           
            }
            else
                wait++;
            OtvoriNova();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            label3.Text = poeni.ToString();
        }
    }
}
