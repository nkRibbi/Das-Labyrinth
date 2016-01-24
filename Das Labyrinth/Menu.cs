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

        //gibt den schwierigkeitsgrad für die öffentlichkeit frei
        public int getDifficulty()
        {
            Random rnd = new Random();
            string difficulty = cbb_Level.SelectedItem.ToString();
            Console.WriteLine(difficulty);


            switch (difficulty)
            {
                case "Level 1": return 1;
                case "Level 2": return 2;
                case "Level 3": return 3;
                case "Level 4": return 4;
            }

            return 1;
        }

        //Läd (atm noch) nur das Drachen rechnen Spiel [ToDo]
        private void btn_Start_Click(object sender, EventArgs e)
        {
            DrachenRechnen frm = new DrachenRechnen();
            frm.Show();
        }
    }
}
