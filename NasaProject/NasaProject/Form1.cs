using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaProject
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void startbutton_MouseHover(object sender, EventArgs e)
        {
            startbutton.BackColor=Color.Transparent;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the game?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

            
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            startpanel.Hide();
            difficultypanel.Show();
        }

        private void backstartbutton_Click(object sender, EventArgs e)
        {
            startpanel.Show();
            difficultypanel.Hide();
            
        }

        QuestionClass qclass = new QuestionClass();
        private void beginnerbutton_Click(object sender, EventArgs e)
        {
            difficultypanel.Hide();
            questionpanel.Show();
            qclass.Mode = "beginner";
            qclass.QuestionNumber = 1;
            qclass.BeginnerLevel(qclass.QuestionNumber);
            qnumber.Text="Question ("+qclass.QuestionNumber+"/10)";
            question.Text = qclass.Question;
            mcqa.Text = mcqa.Text + qclass.AnswerA;
            mcqb.Text = mcqb.Text + qclass.AnswerB;
            mcqc.Text = mcqc.Text + qclass.AnswerC;
            mcqd.Text = mcqd.Text + qclass.AnswerD;



        }


        private void intermediatebutton_Click(object sender, EventArgs e)
        {
            difficultypanel.Hide();
            questionpanel.Show();
            qclass.Mode = "intermediate";
            qclass.QuestionNumber = 1;
            qclass.IntermediateLevel(qclass.QuestionNumber);
            qnumber.Text = "Question (" + qclass.QuestionNumber + "/10)";
            question.Text = qclass.Question;
            mcqa.Text = mcqa.Text + qclass.AnswerA;
            mcqb.Text = mcqb.Text + qclass.AnswerB;
            mcqc.Text = mcqc.Text + qclass.AnswerC;
            mcqd.Text = mcqd.Text + qclass.AnswerD;

        }


        private void expertbutton_Click(object sender, EventArgs e)
        {
            difficultypanel.Hide();
            questionpanel.Show();
            qclass.Mode = "expert";
            qclass.QuestionNumber = 1;
            qclass.ExpertLevel(qclass.QuestionNumber);
            qnumber.Text = "Question (" + qclass.QuestionNumber + "/10)";
            question.Text = qclass.Question;
            mcqa.Text = mcqa.Text + qclass.AnswerA;
            mcqb.Text = mcqb.Text + qclass.AnswerB;
            mcqc.Text = mcqc.Text + qclass.AnswerC;
            mcqd.Text = mcqd.Text + qclass.AnswerD;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            questionpanel.Hide();
            difficultypanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (qclass.QuestionNumber <= 10)
            {
                if (mcqa.Checked == true)
                {
                    if (qclass.Mode == "beginner")
                    {
                        qclass.BeginnerCheckAnswer(mcqa.Text.Substring(3));
                    }
                    else if (qclass.Mode == "intermediate")
                    {
                        qclass.IntermediaterCheckAnswer(mcqa.Text.Substring(3));
                    }
                    else if (qclass.Mode == "expert")
                    {
                        qclass.ExpertCheckAnswer(mcqa.Text.Substring(3));
                    }
                    mcqa.Checked = false;
                }
                else if (mcqb.Checked == true)
                {
                    if (qclass.Mode == "beginner")
                    {
                        qclass.BeginnerCheckAnswer(mcqb.Text.Substring(3));
                    }
                    else if (qclass.Mode == "intermediate")
                    {
                        qclass.IntermediaterCheckAnswer(mcqb.Text.Substring(3));
                    }
                    else if (qclass.Mode == "expert")
                    {
                        qclass.ExpertCheckAnswer(mcqb.Text.Substring(3));
                    }
                    mcqb.Checked = false;
                }
                else if (mcqc.Checked == true)
                {
                    if (qclass.Mode == "beginner")
                    {
                        qclass.BeginnerCheckAnswer(mcqc.Text.Substring(3));
                    }
                    else if (qclass.Mode == "intermediate")
                    {
                        qclass.IntermediaterCheckAnswer(mcqc.Text.Substring(3));
                    }
                    else if (qclass.Mode == "expert")
                    {
                        qclass.ExpertCheckAnswer(mcqc.Text.Substring(3));
                    }
                    mcqc.Checked = false;
                }
                else if (mcqd.Checked == true)
                {
                    if (qclass.Mode == "beginner")
                    {
                        qclass.BeginnerCheckAnswer(mcqd.Text.Substring(3));
                    }
                    else if (qclass.Mode == "intermediate")
                    {
                        qclass.IntermediaterCheckAnswer(mcqd.Text.Substring(3));
                    }
                    else if (qclass.Mode == "expert")
                    {
                        qclass.ExpertCheckAnswer(mcqd.Text.Substring(3));
                    }
                    mcqd.Checked = false;
                }
                else
                {
                    MessageBox.Show("Please answer all the question first!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            scorelabel.Text = qclass.Score + "/100";
            if (qclass.QuestionNumber < 10)
            {
                qclass.QuestionNumber = qclass.QuestionNumber + 1;
                if (qclass.QuestionNumber == 3 || qclass.QuestionNumber == 6 || qclass.QuestionNumber == 9)
                {
                    factlabel.Text = qclass.RandomFact();
                    factpanel.Show();
                    factpanel.BringToFront();
                }


                if (qclass.Mode == "beginner")
                {
                    qclass.BeginnerLevel(qclass.QuestionNumber);
                    qnumber.Text = "Question (" + qclass.QuestionNumber + "/10)";
                    question.Text = qclass.Question;
                    mcqa.Text = "A. " + qclass.AnswerA;
                    mcqb.Text = "B. " + qclass.AnswerB;
                    mcqc.Text = "C. " + qclass.AnswerC;
                    mcqd.Text = "D. " + qclass.AnswerD;
                }
                else if (qclass.Mode == "intermediate")
                {
                    qclass.IntermediateLevel(qclass.QuestionNumber);
                    qnumber.Text = "Question (" + qclass.QuestionNumber + "/10)";
                    question.Text = qclass.Question;
                    mcqa.Text = "A. " + qclass.AnswerA;
                    mcqb.Text = "B. " + qclass.AnswerB;
                    mcqc.Text = "C. " + qclass.AnswerC;
                    mcqd.Text = "D. " + qclass.AnswerD;
                }
                else if (qclass.Mode == "expert")
                {
                    qclass.ExpertLevel(qclass.QuestionNumber);
                    qnumber.Text = "Question (" + qclass.QuestionNumber + "/10)";
                    question.Text = qclass.Question;
                    mcqa.Text = "A. " + qclass.AnswerA;
                    mcqb.Text = "B. " + qclass.AnswerB;
                    mcqc.Text = "C. " + qclass.AnswerC;
                    mcqd.Text = "D. " + qclass.AnswerD;
                }
            }
            else
            {
                qclass.QuestionNumber = 1;
                qclass.Score = 0;
                MessageBox.Show("The " + qclass.Mode + " chapter is completed", "Level Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                questionpanel.Hide();
                difficultypanel.Show();
                
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            factpanel.Hide();
        }
    }
}
