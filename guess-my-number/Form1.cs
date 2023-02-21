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
                lblStatus.Text = "Поздравления спечелихте!";
                btnCheck.Enabled = false;
            }
            
            if (playerGuess != secretNumber)
            {
                if (score > 1)
                {
                    if (playerGuess > secretNumber) lblStatus.Text = "Числото, което търсите е по-малко.";
                    else lblStatus.Text = "Числото, което търсите е по-голямо.";
                    score--;
                    lblCurResult.Text = score.ToString();
                } else
                {
                    lblStatus.Text = "Загубихте играта! Моля започнете отначало!";
                    lblCurResult.Text = "0";
                    btnCheck.Enabled = false;
                }
            }
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            score = 20;
            secretNumber = r.Next(1, 21);
            btnCheck.Enabled = true;
            lblStatus.Text = "Започнете играта...";
            lblCurResult.Text = score.ToString();
            lblMaxResult.Text = maxScore.ToString();
            lblNumber.Text = "?";
        }
    }
}
