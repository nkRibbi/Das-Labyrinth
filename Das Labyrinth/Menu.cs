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
        Bitmap bmp_link = new Bitmap("D:\\Haspel\\Das Labyrinth\\Das Labyrinth\\src\\Link.png");
        Bitmap bmp_zelda = new Bitmap("D:\\Haspel\\Das Labyrinth\\Das Labyrinth\\src\\Zelda.png");

        public Menu()
        {
            InitializeComponent();

            //Set BackgroundImage der Panels zu dem dazugehörigen Bild
            pnl_Link.BackgroundImage = bmp_link;
            pnl_Zelda.BackgroundImage = bmp_zelda;
            lbl_error.Text = "Gib zuerst deinen Namen ein!";
        }
        static string gender = "link";
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
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
        //Läd (atm noch) die Form die getestet werden soll und setzt das Level sowie das Geschlecht [TODO]
        private void btn_Start_Click(object sender, EventArgs e)
        {

            //Abfrage der Textbox wenn der jetzige platzhalter oder nullOrWhiteSpace ist dann leite nicht weiter
            if (txt_name.Text.ToLower() == "name platzhalter" || String.IsNullOrWhiteSpace(txt_name.Text))
            {
                lbl_error.Visible = true;
                return;
            }
            Player_name = txt_name.Text;
            //ActionCanvas frm = new ActionCanvas();
            DrachenRechnen frm = new DrachenRechnen();
            frm.Show();
        }


        /* Einfache Abfrage welche PictureBox geklickt wurde. Und es wir die Farbe jeweils geändert. */
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
        }

        /* Selbe Logik wie oben. Ein Label wird ausgewählt und farblich hinterlegt, die andern drei werden auf die Hintergrundfarbe der Form gesetzt*/
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

        /* Key Abfrage in der Textbox, keine Sonderzeichen sowie keine Ziffern dürfen verwendet werden */
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            string chars = "+-*/!§$%&/()=?`@²³{[]}\'~_;.:€";
            if (Char.IsDigit(e.KeyChar) || chars.Contains(e.KeyChar.ToString().ToLower()))
            {
                e.Handled = true;
            }
        }
        /* Beim Focus auf die Textbox wird sie leer gemacht */
        private void txt_name_Enter(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            txt_name.Text = "";
        }

    }
}
