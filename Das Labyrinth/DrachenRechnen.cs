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
        Menu menu = new Menu();
        
        string level;
       
        public DrachenRechnen()
        {
            level = menu.getDifficulty();
            Console.WriteLine(level);
            //lbl_Question.Text = level;
            InitializeComponent();
        }

        
    }
}
