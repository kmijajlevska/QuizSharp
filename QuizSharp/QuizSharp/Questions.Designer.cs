namespace QuizSharp
{
    partial class Questions
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
            this.label2 = new System.Windows.Forms.Label();
            this.pbQuestion = new System.Windows.Forms.PictureBox();
            this.pbAnswer2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbAnswer1 = new System.Windows.Forms.PictureBox();
            this.pbCategory = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(154, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // pbQuestion
            // 
            this.pbQuestion.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestion.Location = new System.Drawing.Point(10, 139);
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.Size = new System.Drawing.Size(315, 94);
            this.pbQuestion.TabIndex = 2;
            this.pbQuestion.TabStop = false;
            this.pbQuestion.Paint += new System.Windows.Forms.PaintEventHandler(this.pbQuestion_Paint);
            // 
            // pbAnswer2
            // 
            this.pbAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.pbAnswer2.Location = new System.Drawing.Point(19, 313);
            this.pbAnswer2.Name = "pbAnswer2";
            this.pbAnswer2.Size = new System.Drawing.Size(288, 50);
            this.pbAnswer2.TabIndex = 3;
            this.pbAnswer2.TabStop = false;
            this.pbAnswer2.Click += new System.EventHandler(this.pbAnswer2_Click);
            this.pbAnswer2.Paint += new System.Windows.Forms.PaintEventHandler(this.pbAnswer2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(19, 369);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(288, 50);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(19, 425);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(288, 50);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            // 
            // pbAnswer1
            // 
            this.pbAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.pbAnswer1.Location = new System.Drawing.Point(19, 257);
            this.pbAnswer1.Name = "pbAnswer1";
            this.pbAnswer1.Size = new System.Drawing.Size(288, 50);
            this.pbAnswer1.TabIndex = 6;
            this.pbAnswer1.TabStop = false;
            this.pbAnswer1.Click += new System.EventHandler(this.pbAnswer1_Click);
            this.pbAnswer1.Paint += new System.Windows.Forms.PaintEventHandler(this.pbAnswer1_Paint);
            // 
            // pbCategory
            // 
            this.pbCategory.BackColor = System.Drawing.Color.Transparent;
            this.pbCategory.Location = new System.Drawing.Point(55, 12);
            this.pbCategory.Name = "pbCategory";
            this.pbCategory.Size = new System.Drawing.Size(205, 48);
            this.pbCategory.TabIndex = 7;
            this.pbCategory.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuizSharp.Properties.Resources.home_button;
            this.pictureBox1.Location = new System.Drawing.Point(270, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizSharp.Properties.Resources.Form1_bgimg;
            this.ClientSize = new System.Drawing.Size(331, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbQuestion);
            this.Controls.Add(this.pbAnswer1);
            this.Controls.Add(this.pbAnswer2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Questions";
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.Questions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbQuestion;
        private System.Windows.Forms.PictureBox pbAnswer2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbAnswer1;
        private System.Windows.Forms.PictureBox pbCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}