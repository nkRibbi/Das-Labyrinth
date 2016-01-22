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
        }

        public string getDifficulty()
        {
            string level = cbb_Level.Text;

            return level;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            DrachenRechnen frm = new DrachenRechnen();
            frm.Show();
        }
    }
}
