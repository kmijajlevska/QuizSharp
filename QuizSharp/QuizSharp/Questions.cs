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
using System.IO;


namespace QuizSharp
{
    public partial class Questions : Form
    {
        public string ime{get; set;}
      
        List<string> history;
        List<string> history_answers;
       
        public static int points = 0;
        string name;
        string question;
        string answer;
        string answer3;
        string answer2;
        string answer4;
        int correct;
        int broj4;

        public Questions()
        {
            broj4 = 0;
            correct = 0;
            history = new List<string>();
            history_answers = new List<string>();
            InitializeComponent();
           
            history=new List<string>();

            metodi();
            
        }

        public void metodi()
        {
            AddQuestions();
            LoadPictures();
        }

        public void LoadPictures()
        {
            
            if (name == "entert")
            {
                pbCategory.Image = Resources.categoryShowbiz;
                pbQuestion.Image = Resources.questionShowbiz;
                pbAnswer1.Image = Resources.answerShowbiz;
                pbAnswer2.Image = Resources.answerShowbiz;
                pictureBox3.Image = Resources.answerShowbiz;
                pictureBox4.Image = Resources.answerShowbiz;

            }
            else if (name == "sport")
            {
                pbCategory.Image = Resources.categorySports;
                pbQuestion.Image = Resources.questionSports;
                pbAnswer1.Image = Resources.answerSports;
                pbAnswer2.Image = Resources.answerSports;
                pictureBox3.Image = Resources.answerSports;
                pictureBox4.Image = Resources.answerSports;

            }
            else if (name == "history")
            {
                pbCategory.Image = Resources.categoryHistory;
                pbQuestion.Image = Resources.questionHistory;
                pbAnswer1.Image = Resources.answerHistory;
                pbAnswer2.Image = Resources.answerHistory;
                pictureBox3.Image = Resources.answerHistory;
                pictureBox4.Image = Resources.answerHistory;

            }

            else if (name == "science")
            {
                pbCategory.Image = Resources.categoryScience;
                pbQuestion.Image = Resources.questionScience;
                pbAnswer1.Image = Resources.answerScience;
                pbAnswer2.Image = Resources.answerScience;
                pictureBox3.Image = Resources.answerScience;
                pictureBox4.Image = Resources.answerScience;

            }
            else
            {
                pbCategory.Image = Resources.categoryGeography;
                pbQuestion.Image = Resources.questionGeography;
                pbAnswer1.Image = Resources.answerGeography;
                pbAnswer2.Image = Resources.answerGeography;
                pictureBox3.Image = Resources.answerGeography;
                pictureBox4.Image = Resources.answerGeography;
            }


        }



        public void AddQuestions() 
        {
            
            //string resource_data2 = Properties.Resources.science;
            //history = resource_data2.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //string resource_data3 = Properties.Resources.science_answers;
            //history = resource_data3.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();



            SetQuestions();
        }

        public void SetQuestions()
        {

            if (name == "history")
            {
                string resource_data = Properties.Resources.History_txt;
                history = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string resource_data1 = Properties.Resources.history_answers;
                history_answers = resource_data1.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
               
            }
            else if(name=="science")
            {
                string resource_data = Properties.Resources.science;
                history = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string resource_data1 = Properties.Resources.science_answers;
                history_answers = resource_data1.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
               
            }
            else if (name == "entert")
            {
                string resource_data = Properties.Resources.showbiz;
                history = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string resource_data1 = Properties.Resources.showbiz_answers;
                history_answers = resource_data1.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
               

            }
            else if (name == "sport")
            {
                string resource_data = Properties.Resources.sports;
                history = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string resource_data1 = Properties.Resources.sports_answers;
                history_answers = resource_data1.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
               

            }
            else
            {
                string resource_data = Properties.Resources.Geography;
                history = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string resource_data1 = Properties.Resources.Geography_answers;
                history_answers = resource_data1.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
               

            }
           
            GenerateAnswers();

        }

        public void GenerateAnswers()
        {
            if (broj4 == 5)
            {
                NewGame nova = new NewGame();
                nova.poeni = points;
                nova.Show();
                this.Close();
            }
            else
            {

                Random r = new Random();
                int broj = r.Next(29);
                int numer = broj * 4;
                question = history[broj];

                correct = r.Next(3);
                if (correct == 0)
                {
                    answer = history_answers[numer];
                    answer2 = history_answers[numer + 1];
                    answer4 = history_answers[numer + 2];
                    answer3 = history_answers[numer + 3];
                }
                else if (correct == 1)
                {
                    answer2 = history_answers[numer];
                    answer = history_answers[numer + 1];
                    answer4 = history_answers[numer + 2];
                    answer3 = history_answers[numer + 3];
                }
                else if (correct == 2)
                {
                    answer3 = history_answers[numer];
                    answer = history_answers[numer + 1];
                    answer4 = history_answers[numer + 2];
                    answer2 = history_answers[numer + 3];
                }
                else
                {
                    answer4 = history_answers[numer];
                    answer = history_answers[numer + 1];
                    answer3 = history_answers[numer + 2];
                    answer2 = history_answers[numer + 3];
                }
                broj4++;
                Invalidate();
            }
        }





        private void Questions_Load(object sender, EventArgs e)
        {
            label2.Text = ime;
            label2.Hide();
            name = label2.Text;
            LoadPictures();
            
        }

        private void pbQuestion_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 10))
            {
                e.Graphics.DrawString(question, myFont, Brushes.Blue, new Point(2, 37));
            }
        }

        private void pbAnswer1_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 14))
            {
                e.Graphics.DrawString(answer, myFont, Brushes.Blue, new Point(2, 2));
            }
        }

        private void pbAnswer2_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 14))
            {
                e.Graphics.DrawString(answer2, myFont, Brushes.Blue, new Point(2, 2));
            }
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 14))
            {
                e.Graphics.DrawString(answer3, myFont, Brushes.Blue, new Point(2, 2));
            }
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 14))
            {
                e.Graphics.DrawString(answer4, myFont, Brushes.Blue, new Point(2, 2));
            }
        }
        public void Correct0()
        {
            if (correct == 0)
            {
                if (name == "entert")
                {
                    pbAnswer1.Image = Resources.answerShowbizCORRECT;

                }
                else if (name == "sport")
                {
                    pbAnswer1.Image = Resources.answerSportsCORRECT;
                }
                else if (name == "history")
                {
                    pbAnswer1.Image = Resources.answerHistoryCORRECT;

                }

                else if (name == "science")
                {
                    pbAnswer1.Image = Resources.answerScienceCORRECT;

                }
                else
                {
                    pbAnswer1.Image = Resources.answerGeographyCORRECT;
                }

                metodi();
            }
        }


        public void Correct1()
        {
            if (correct == 1)
            {
                if (name == "entert")
                {
                    pbAnswer2.Image = Resources.answerShowbizCORRECT;

                }
                else if (name == "sport")
                {
                    pbAnswer2.Image = Resources.answerSportsCORRECT;
                }
                else if (name == "history")
                {
                    pbAnswer2.Image = Resources.answerHistoryCORRECT;

                }

                else if (name == "science")
                {
                    pbAnswer2.Image = Resources.answerScienceCORRECT;

                }
                else
                {
                    pbAnswer2.Image = Resources.answerGeographyCORRECT;
                }
                metodi();
                
            }
        }


        public void Correct2()
        {
            if (correct == 2)
            {
                if (name == "entert")
                {
                    pictureBox3.Image = Resources.answerShowbizCORRECT;

                }
                else if (name == "sport")
                {
                    pictureBox3.Image = Resources.answerSportsCORRECT;
                }
                else if (name == "history")
                {
                    pictureBox3.Image = Resources.answerHistoryCORRECT;

                }

                else if (name == "science")
                {
                    pictureBox3.Image = Resources.answerScienceCORRECT;

                }
                else
                {
                    pictureBox3.Image = Resources.answerGeographyCORRECT;
                }
                metodi();
                
            }
        }

        public void Correct3()
        {

            if (correct == 3)
            {
                
                if (name == "entert")
                {
                    pictureBox4.Image = Resources.answerShowbizCORRECT;

                }
                else if (name == "sport")
                {
                    pictureBox4.Image = Resources.answerSportsCORRECT;
                }
                else if (name == "history")
                {
                    pictureBox4.Image = Resources.answerHistoryCORRECT;

                }

                else if (name == "science")
                {
                    pictureBox4.Image = Resources.answerScienceCORRECT;

                }
                else
                {
                    pictureBox4.Image = Resources.answerGeographyCORRECT;
                }
                metodi();
               
            }
        }


        private void pbAnswer1_Click(object sender, EventArgs e)
        {
            if (correct == 0)
            {
                points++;
                Correct0();
                
            }
            else
            {
                NewGame nova = new NewGame();
                nova.poeni = points;
                nova.Show();
                this.Close();
            }
        }

        private void pbAnswer2_Click(object sender, EventArgs e)
        {
            if (correct == 1)
            {
                points++;
                Correct1();
                
            }
            else
            {
                NewGame nova = new NewGame();
                nova.poeni = points;
                nova.Show();
                this.Close();
            }

            }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (correct == 2)
            {
                points++;
                Correct2();
            }
            else
            {
                NewGame nova = new NewGame();
                nova.poeni = points;
                nova.Show();
                this.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (correct == 3)
            {
                points++;
                Correct3();
            }
            else
            {
                NewGame nova = new NewGame();
                nova.poeni = points;
                nova.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NewGame nova = new NewGame();
            nova.poeni = points;
            nova.Show();
            this.Close();
        }
        }
    
}
