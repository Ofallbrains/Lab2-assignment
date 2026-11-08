using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2_assignment
{
    public partial class MushroomForm : Form
    {
        int questionStep = 0;

        bool growsInForest;
        bool hasConvexCup;
        public MushroomForm()
        {
            InitializeComponent();

            StartGame();
        }

        private void StartGame()
        {
            questionStep = 0;

            growsInForest = false;
            hasConvexCup = false;

            yesBtn.Visible = true;
            noBtn.Visible = true;

            qnLbl.Text = "Question 1 of 3";

            qn1Lbl.Text =
                "Does your mushroom grow in a forest?";
        }

        private void qnLbl_Click(object sender, EventArgs e)
        {

        }

        private void qn1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            ProcessAnswer(true);
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            ProcessAnswer(false);
        }

        private void ProcessAnswer(bool answer)
        {
            // QUESTION 1: Forest?
            if (questionStep == 0)
            {
                growsInForest = answer;

                questionStep = 1;

                qnLbl.Text = "Question 2 of 3";

                qn1Lbl.Text =
                    "Does your mushroom have a convex cup?";
            }

            // QUESTION 2: Convex cup?
            else if (questionStep == 1)
            {
                hasConvexCup = answer;

                // Mushrooms growing in meadows
                if (!growsInForest)
                {
                    if (hasConvexCup)
                    {
                        ShowResult("Agaric Jaunissant");
                    }
                    else
                    {
                        ShowResult("Coprin chevelu");
                    }
                }

                // Mushrooms growing in forests
                else
                {
                    questionStep = 2;

                    qnLbl.Text = "Question 3 of 3";

                    if (hasConvexCup)
                    {
                        qn1Lbl.Text =
                            "Does your mushroom have a ring?";
                    }
                    else
                    {
                        qn1Lbl.Text =
                            "Does your mushroom have gills?";
                    }
                }
            }

            // QUESTION 3
            else if (questionStep == 2)
            {
                if (hasConvexCup)
                {
                    // Ring: Yes = Amanite, No = Pied bleu
                    if (answer)
                    {
                        ShowResult("Amanite tue-mouche");
                    }
                    else
                    {
                        ShowResult("Pied bleu");
                    }
                }
                else
                {
                    // Gills: Yes = Girolle, No = Cepe
                    if (answer)
                    {
                        ShowResult("Girolle");
                    }
                    else
                    {
                        ShowResult("Cepe de Bordeaux");
                    }
                }
            }
        }

        // Display the identified mushroom
        private void ShowResult(string mushroom)
        {
            qnLbl.Text = "Identification complete";

            qn1Lbl.Text =
                "Your mushroom is: " + mushroom;

            yesBtn.Visible = false;
            noBtn.Visible = false;

            MessageBox.Show(
                "Your mushroom is: " + mushroom,
                "Mushroom identified",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            DialogResult restart = MessageBox.Show(
                "Would you like to identify another mushroom?",
                "Play Again",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (restart == DialogResult.Yes)
            {
                StartGame();
            }
            else
            {
                MenuForm menu = new MenuForm();
                menu.Show();
                this.Close();
            }
        }
    }
}
