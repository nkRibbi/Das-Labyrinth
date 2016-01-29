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
    public partial class DrachenRechnen : Form
    {
        Menu Menu_Frame = new Menu();
        int difficulty;
        int result, number_one, number_two, answer_A, answer_B, answer_C, answer_D;
        string player_name;
        System.Timers.Timer a = new System.Timers.Timer();
        Bitmap bmp_heart_full = new Bitmap("D:\\Haspel\\Das Labyrinth\\Das Labyrinth\\src\\heart_full.png");
        Bitmap bmp_heart_empty = new Bitmap("D:\\Haspel\\Das Labyrinth\\Das Labyrinth\\src\\heart_empty.png");


        Panel pnl_Popup = new Panel();
        Label success_text = new Label();

        public DrachenRechnen()
        {
            InitializeComponent();
            //this.Controls.SetChildIndex(panel1, 0);

            //setze den Schwierigkeitsgrad und das Geschlecht
            difficulty = Menu_Frame.Difficulty;
            string gender = Menu_Frame.Gender;
            player_name = Menu_Frame.Player_name;

            pb_life1.BackgroundImage = bmp_heart_full;
            pb_life2.BackgroundImage = bmp_heart_full;
            pb_life3.BackgroundImage = bmp_heart_full;
            lbl_difficulty.Text = "Level " + difficulty;
            lbl_gender.Text = gender;
            lbl_name.Text = player_name;
            start();
        }
        private void start()
        {
            Random rnd = new Random();
            char c_operand = '+';
            
            //generiere operanten sowie antwortmöglichkeiten
            number_one = rnd.Next(0, 10);
            number_two = rnd.Next(0, 10);
            int operand = rnd.Next(0, difficulty);
            switch (operand)
            {
                case 0: result = number_one + number_two; c_operand = '+'; break;
                case 1: result = number_one - number_two; c_operand = '-'; break;
                case 2: result = number_one * number_two; c_operand = '*'; break;
                case 3: result = number_one + number_two; c_operand = '4'; break;
            }
            lbl_Question.Text = number_one + " " + c_operand + " " + number_two;
            // [TODO]
            answer_A = rnd.Next(0, 20);
            answer_B = rnd.Next(0, 20);
            answer_C = rnd.Next(0, 20);
            answer_D = rnd.Next(0, 20);

            //erstmal zufällige antwort möglichkeiten für alle vier
            lbl_AnswerA.Text = answer_A.ToString();
            lbl_AnswerB.Text = answer_B.ToString();
            lbl_AnswerC.Text = answer_C.ToString();
            lbl_AnswerD.Text = answer_D.ToString();

            //ersetze ein AntwortFeld mit der richtigen Antwort
            int decide = rnd.Next(0, 4);
            switch (decide)
            {
                case 0: lbl_AnswerA.Text = result.ToString(); break;
                case 1: lbl_AnswerB.Text = result.ToString(); break;
                case 2: lbl_AnswerC.Text = result.ToString(); break;
                case 3: lbl_AnswerD.Text = result.ToString(); break;
            }
        }
        
        /* Vergleiche den Wert des angeklickten Labels mit der richtigen Antwort*/
        public void checkAnswer_Click(object sender, EventArgs e)
        {
            Panel pnl_clicked = sender as Panel;
            Label label_clicked = sender as Label;
            int answer = Convert.ToInt32(label_clicked.Text);
            int result = this.result;

            //abfrage für eine Richtige antwort
            if (result == answer)
            {
                lbl_Question.Text = "Richtige Antwort " + player_name;
                this.Controls.SetChildIndex(pnl_success, 1);
                pnl_success.Visible = true;
            }

            //Abfrage für eine Falsche Antwort
            else
            {
                lbl_Question.Text = "Falsche Antwort";

                // Verliere das jeweilige nächste Lebel, wenn alle drei Leben verloren sind Schließe das MiniSpiel
                if (pb_life1.BackgroundImage == bmp_heart_full)
                    pb_life1.BackgroundImage = bmp_heart_empty;
                else if (pb_life2.BackgroundImage == bmp_heart_full)
                    pb_life2.BackgroundImage = bmp_heart_empty;
                else
                {
                    pb_life3.BackgroundImage = bmp_heart_empty;
                    this.Close();
                    MessageBox.Show("Du hast keine Leben mehr");
                }
                start();
            }
        }
        /* Click Event des Panels, welches nach einer richtigen Antwort erscheint */
        public void continue_after_sucess_click(object sender, EventArgs e)
        {
            pnl_success.Visible = false;
            start();
        }
        //Hover fuer die vier Antwort Moeglichkeiten
        private void pnl_AnswerA_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = Color.FromArgb(211, 211, 211);
        }
        private void pnl_AnswerA_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = Color.FromArgb(240, 240, 240);
        }

       
    }
}
