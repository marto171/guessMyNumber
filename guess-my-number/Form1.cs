using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess_my_number
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int score = 20;
        int maxScore = 0;
        int secretNumber;
        public Form1()
        {
            InitializeComponent();
            secretNumber = r.Next(1, 21);
            lblNumber.Text = secretNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            int playerGuess = int.Parse(txtBxNumber.Text);
            if (playerGuess == secretNumber)
            {
                if (score > maxScore) maxScore = score;
                lblNumber.Text = secretNumber.ToString();

                lblCurResult.Text = score.ToString();
                lblMaxResult.Text = maxScore.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
