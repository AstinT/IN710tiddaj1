using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNight
{
    public partial class Form1 : Form
    {

        //Declare delegate
        public delegate int ScoreDelegate(int correct, int incorrect);
        ScoreDelegate scoreComputer;

        //Properties
        int correct;
        int incorrect;

        public Form1()
        {
            InitializeComponent();

            scoreComputer = null;

            correct = 0;
            incorrect = 0;
        }

        //Gets and converts entered data
        public void getCorrectIncorrect()
        {
            if ((tbCorrect.Text != "") && (tbIncorrect.Text != ""))
            {
                if (int.TryParse(tbCorrect.Text, out correct))
                {
                    //It was assigned
                    if(int.TryParse(tbIncorrect.Text, out incorrect))
                    {
                        //It was assigned
                    }
                    else
                        MessageBox.Show("Please enter only numbers.");
                }
                else
                    MessageBox.Show("Please enter only numbers.");
            }
            else
                MessageBox.Show("Please enter the total correct and incorrect scores.");
        }

        //Checks what radiobutton is checked and executed appropriate scoring method
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            getCorrectIncorrect();

            if (rbAdult.Checked)
            {
                scoreComputer = new ScoreDelegate(Scorer.AdultScore);
            }
            else if (rbChildren.Checked)
            {
                scoreComputer = new ScoreDelegate(Scorer.ChildrenScore);
            }
            else
                MessageBox.Show("Please select Adult or Children.");

            lblScore.Text = scoreComputer(correct, incorrect).ToString();
        }
    }
}
