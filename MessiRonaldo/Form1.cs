using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessiRonaldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isChosen;

        GameArea gameArea;

        private string chosenPlayer;

        public string ChosenPlayer { get => chosenPlayer; set => chosenPlayer = value; }

        public bool IsChosen { get => isChosen; set => isChosen = value; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(340, 460);
            panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.ClientSize.Width / 2, this.ClientSize.Height / 2 - panel1.ClientSize.Height / 2);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = ımageList1.Images[0];
            pictureBox2.Image = ımageList1.Images[1];
            label1.Location = SetLabelLocation(label1, pictureBox1);
            label2.Location = SetLabelLocation(label2, pictureBox2);
            label3.ForeColor = Color.Red;
            label3.Font = new Font(label3.Font.FontFamily, 15);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
            label1.Font = new Font(label1.Font.FontFamily, 11);
            label1.Location = SetLabelLocation(label1, pictureBox1);

            label2.ForeColor = Color.Red;
            label2.Font = new Font(label1.Font.FontFamily, 8);
            label2.Location = SetLabelLocation(label2, pictureBox2);

            IsChosen = true;
            label3.ForeColor = Color.Green;
            label3.Font = new Font(label3.Font.FontFamily, 15, FontStyle.Bold);

            ChosenPlayer = "Messi";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Green;
            label2.Font = new Font(label1.Font.FontFamily, 11);
            label2.Location = SetLabelLocation(label2, pictureBox2);

            label1.ForeColor = Color.Red;
            label1.Font = new Font(label1.Font.FontFamily, 8);
            label1.Location = SetLabelLocation(label1,pictureBox1);

            IsChosen = true;
            label3.ForeColor = Color.Green;
            label3.Font = new Font(label3.Font.FontFamily, 15, FontStyle.Bold);

            ChosenPlayer = "Ronaldo";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (IsChosen)
            {
                gameArea = new GameArea();
                gameArea.form = this;
                label1.ForeColor = Color.Black;
                label1.Font = new Font(label1.Font.FontFamily, 8);
                label2.ForeColor = Color.Black;
                label2.Font = new Font(label1.Font.FontFamily, 8);
                label3.ForeColor = Color.Red;
                label3.Font = new Font(label3.Font.FontFamily, 13);
                this.Controls.Remove(panel1);
                this.Controls.Add(gameArea);
            }
        }

        private Point SetLabelLocation(Label label, PictureBox pictureBox)
        {
            return new Point(pictureBox.Location.X + pictureBox.Width / 2 - label.Width / 2, label.Location.Y);
        }
    }
}
