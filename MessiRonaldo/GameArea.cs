using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessiRonaldo
{
    public partial class GameArea : UserControl
    {
        public GameArea()
        {
            InitializeComponent();
        }

        #region MemberFields

        public Form1 form;

        List<PictureBox> pictureBoxList = new List<PictureBox>();

        PictureBox correctPictureBox;

        int score; 

        #endregion

        private void GameArea_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Width = 100;
                    pb.Height = 100;
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    pb.Location = new Point(j * 120, i * 120);
                    pb.Click += FindTheAnswer;
                    pictureBoxList.Add(pb);
                    this.Controls.Add(pb);
                }
            }
            SetPlayerPicture(form.ChosenPlayer);
            timer1.Start();
        }

        #region MemberMethods
        private void FindTheAnswer(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb == correctPictureBox)
            {
                SetPlayerPicture(form.ChosenPlayer);
                score++;
            }
            else
            {
                FinishTheGame();
            }
        }

        private void FinishTheGame()
        {
            timer1.Stop();
            MessageBox.Show("Fake oyuncuya tıkladınız.\nSkorunuz: " + score);
            form.Controls.Remove(this);
            form.Controls.Add(form.panel1);
            form.IsChosen = false;
        }

        private void SetPlayerPicture(string playerName)
        {
            foreach (PictureBox item in pictureBoxList)
            {
                item.Image = null;
            }
            Random r = new Random();
            correctPictureBox = new PictureBox();
            correctPictureBox = pictureBoxList[r.Next(12)];
            if (playerName == "Ronaldo")
            {
                correctPictureBox.Image = imageListRonaldo.Images[r.Next(2)];
                foreach (PictureBox item in pictureBoxList)
                {
                    if (item.Image == null)
                    {
                        item.Image = imageListRonaldo.Images[r.Next(2, 7)];
                    }
                }
            }
            else
            {
                correctPictureBox.Image = imageListMessi.Images[r.Next(2)];
                foreach (PictureBox item in pictureBoxList)
                {
                    if (item.Image == null)
                    {
                        item.Image = imageListMessi.Images[r.Next(2, 7)];
                    }
                }
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Size ayrılan sürenin sonuna geldik.\nSkorunuz: " + score);
            form.Controls.Remove(this);
            form.Controls.Add(form.panel1);
            form.IsChosen = false;
        }
    }
}
