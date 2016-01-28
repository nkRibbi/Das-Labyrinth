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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
            //Level Label hinzufügen und 'Level 1' als selected auswählen

            
        }
        /* [AK] */
        //Get Set Geschlecht
        static string gender = "link";
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        //get set Schwierigkeit
        static int difficulty = 1;
        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        static string player_name;
        public string Player_name
        {
            get { return player_name; }
            set { player_name = value; }
        }

        //gibt den schwierigkeitsgrad für die öffentlichkeit frei

      
        private void playerChoiceClick(object sender, EventArgs e)
        {
            PictureBox player = sender as PictureBox;
            switch (player.Name)
            {
                case "pnl_Zelda": 
                    pnl_Zelda.BackColor = Color.FromArgb(211, 211, 211); 
                    pnl_Link.BackColor = Color.FromArgb(240, 240, 240);
                    Gender = "zelda";
                    break;
                case "pnl_Link": 
                    pnl_Link.BackColor = Color.FromArgb(211, 211, 211); 
                    pnl_Zelda.BackColor = Color.FromArgb(240, 240, 240);
                    Gender = "link";
                    break;
            }
            player.BackColor = Color.FromArgb(211, 211, 211);
        }

        //public int setDifficulty()
        //{
        //    string difficulty = cbb_Level.Text;
        //    switch (difficulty)
        //    {
        //        case "Level 1": return 1;
        //        case "Level 2": return 2;
        //        case "Level 3": return 3;
        //        case "Level 4": return 4;
        //        default: return 1;
        //    }
        //}

        //Läd (atm noch) nur das Drachen rechnen Spiel und setzt das Level sowie das Geschlecht [TODO]
        private void btn_Start_Click(object sender, EventArgs e)
        {
            /* Setze Schwierigkeit in abhängikeit des Textes der Combobox und rufe (das Labyrinth, Minispiel) */
            //Difficulty = setDifficulty();
            //Gender = cbb_Gender.Text;
            Player_name = txt_name.Text;
            //ActionCanvas frm = new ActionCanvas();
            DrachenRechnen frm = new DrachenRechnen();
            frm.Show();
        }

        private void levelChoiceClick(object sender, EventArgs e)
        {
            Label level = sender as Label;
            level.BackColor = Color.FromArgb(211, 211, 211);
            switch (level.Name)
            {
                case "lbl_Level1":
                    lbl_Level1.BackColor = Color.FromArgb(211, 211, 211);
                    lbl_Level2.BackColor = Color.FromArgb(240, 240, 240);
                    lbl_Level3.BackColor = Color.FromArgb(240, 240, 240);
                    lbl_Level4.BackColor = Color.FromArgb(240, 240, 240);
                    difficulty = 1;
                    break;
                case "lbl_Level2":
                    lbl_Level2.BackColor = Color.FromArgb(211, 211, 211);
                    lbl_Level1.BackColor = Color.FromArgb(240, 240, 240);
                    lbl_Level3.BackColor = Color.FromArgb(240, 240, 240);
                    lbl_Level4.BackColor = Color.FromArgb(240, 240, 240);
                    difficulty = 2;
                    break;
                case "lbl_Level3":
                    lbl_Level3.BackColor = Color.FromArgb(211, 211, 211);
                    lbl_Level2.BackColor = Color.FromArgb(240, 240, 240);
                    lbl_Level1.BackColor = Color.FromArgb(240, 240, 240);
                    lbl_Level4.BackColor = Color.FromArgb(240, 240, 240);
                    difficulty = 3;
                    break;
                case "lbl_Level4":
                    lbl_Level4.BackColor = Color.FromArgb(211, 211, 211);
                    lbl_Level2.BackColor = Color.FromArgb(240, 240, 240);
                    lbl_Level3.BackColor = Color.FromArgb(240, 240, 240);
                    lbl_Level1.BackColor = Color.FromArgb(240, 240, 240);
                    difficulty = 4;
                    break;
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            string chars = "+-*/!§$%&/()=?`@²³{[]}\'~_;.:€";
            if (Char.IsDigit(e.KeyChar) || chars.Contains(e.KeyChar.ToString().ToLower()))
            {
                e.Handled = true;
            }
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            txt_name.Text = "";
        }

        
        /* [AK] */
    }
}
