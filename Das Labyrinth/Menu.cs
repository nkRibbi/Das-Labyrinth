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
        Bitmap LinkWalkAnim = new Bitmap("D:\\Haspel\\Das Labyrinth\\Das Labyrinth\\src\\link_move_anim.png");

        int i = 1;
        Animation frm = new Animation();

        ActionCanvas frmcanvas = new ActionCanvas();

        static int xFigure = 50;
        static int yFigure = 10;
        public System.Timers.Timer b = new System.Timers.Timer();
        public Menu()
        {
            InitializeComponent();
            //Animation a = new Animation();
            //a.test();
            //Set BackgroundImage der Panels zu dem dazugehörigen Bild
            //pnl_Link.BackgroundImage = LinkWalkAnim;
            pnl_Zelda.BackgroundImage = bmp_zelda;
            lbl_error.Text = "Gib zuerst deinen Namen ein!";
            b.Interval = 1000 / 30;                                        // Intervall der Ausführung der A_Elapsed-Methode
            b.Elapsed += A_Elapsed;
            b.Enabled = true;
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
            ActionCanvas frm = new ActionCanvas();
            //DrachenRechnen frm = new DrachenRechnen();
            frm.Show();
        }

        int xLinkWalkAnim = 10;
        int yLinkWalkAnim = 10;

        static int speedObject = 1;
        DateTime lastUpdate = DateTime.MinValue; // Letzer Zeitpunkt des Updates von Game-Logik
        TimeSpan updateInterval = new TimeSpan(0, 0, 0, 0, 66); // Wie oft soll die Game-Logik aktualisiert werden (50ms)
        public void A_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Wenn Jetzt - letzter Zeitpunkt des Game-Logik-Updates grösser als die 50ms Update-Intervall sind, dann erneut Updaten
            if (DateTime.Now - lastUpdate > updateInterval)
            {
                // Hier wird nun die Logik des Spiels vorwärts getrieben, bzw. das vom Frame erhöhen
                yLinkWalkAnim += speedObject;
                figureFrame = frm.getFrame(figureFrame, (byte)21, (byte)27, (byte)4);
                lastUpdate = DateTime.Now; // Zuletzt updated = Jetzt
            }
            this.UIThread(delegate
            {
                this.Refresh();
            });
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
        static byte figureFrame = 0;

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            
            frm.plotFrame(LinkWalkAnim, 25, 30, figureFrame, 317, 169, e);
            Color backColor = LinkWalkAnim.GetPixel(1, 1);
            LinkWalkAnim.MakeTransparent(backColor);
        }
    }

}

