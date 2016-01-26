using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Das_Labyrinth
{
    public partial class DrachenRechnen: Form
    {
        Menu Menu_Frame = new Menu();
        int difficulty;
        int result, number_one, number_two, answer_A, answer_B, answer_C, answer_D;

        public DrachenRechnen()
        {
            InitializeComponent();
            //setze den Schwierigkeitsgrad und das Geschlecht
            difficulty = Menu_Frame.Difficulty;
            string gender = Menu_Frame.Gender;

            lbl_difficulty.Text = "Level " + difficulty;
            lbl_gender.Text = gender;
            start();
        }
        private void start()
        {
            Random rnd = new Random();
            //generiere operanten sowie antwortmöglichkeiten
            number_one = rnd.Next(0, difficulty * 10);
            number_two = rnd.Next(0, difficulty * 10);
            result = number_two + number_one;
            lbl_Question.Text = number_one + " + " + number_two;

            answer_A = rnd.Next(0, difficulty * 20);
            answer_B = rnd.Next(0, difficulty * 20);
            answer_C = rnd.Next(0, difficulty * 20);
            answer_D = rnd.Next(0, difficulty * 20);

            //erstmal zufällige antwort möglichkeiten für alle vier
            lbl_AnswerA.Text = answer_A.ToString();
            lbl_AnswerB.Text = answer_B.ToString();
            lbl_AnswerC.Text = answer_C.ToString();
            lbl_AnswerD.Text = answer_D.ToString();

            //ersetze ein AntwortFeld mit der richtigen Antwort
            int decide = rnd.Next(0, 3);
            switch (decide)
            {
                case 0: lbl_AnswerA.Text = result.ToString(); break;
                case 1: lbl_AnswerB.Text = result.ToString(); break;
                case 2: lbl_AnswerC.Text = result.ToString(); break;
                case 3: lbl_AnswerD.Text = result.ToString(); break;
            }
        }
        private void lbl_Question_Click(object sender, EventArgs e)
        {
            start();
        }

        /* Vergleiche den Wert des angeklickten Labels mit der richtigen Antwort*/
        public void checkAnswer_Click(object sender, EventArgs e)
        {
            Label label_clicked = sender as Label;
            int answer = Convert.ToInt32(label_clicked.Text);
            int result = this.result;

            if (result == answer)
            {
                lbl_Question.Text = "Richtige Antwort";
            }
            else
            {
                lbl_Question.Text = "Falsche Antwort";
            }

        }

    }
}
