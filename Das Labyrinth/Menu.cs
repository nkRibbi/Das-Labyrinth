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
            cbb_Level.Items.Add("Level 1");
            cbb_Level.Items.Add("Level 2");
            cbb_Level.Items.Add("Level 3");
            cbb_Level.Items.Add("Level 4");
            cbb_Level.SelectedItem = "Level 1";
            
        }
        /* [AK] */
        //Get Set Geschlecht
        static string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        //get set Schwierigkeit
        static int difficulty;
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

        public int setDifficulty()
        {
            string difficulty = cbb_Level.Text;
            switch (difficulty)
            {
                case "Level 1": return 1;
                case "Level 2": return 2;
                case "Level 3": return 3;
                case "Level 4": return 4;
                default: return 1;
            }
        }

        //Läd (atm noch) nur das Drachen rechnen Spiel und setzt das Level sowie das Geschlecht [TODO]
        private void btn_Start_Click(object sender, EventArgs e)
        {
            /* Setze Schwierigkeit in abhängikeit des Textes der Combobox und rufe (das Labyrinth, Minispiel) */
            Difficulty = setDifficulty();
            Gender = cbb_Gender.Text;
            Player_name = txt_name.Text;
            Console.WriteLine(Difficulty);
            DrachenRechnen frm = new DrachenRechnen();
            frm.Show();
        }
        /* [AK] */
    }
}
