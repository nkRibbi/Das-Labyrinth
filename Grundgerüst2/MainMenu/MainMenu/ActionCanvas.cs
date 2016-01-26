using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainMenu
{
    public partial class ActionCanvas : Form
    {
        static int w, h;

        // Inizialisiere Bild (komisch wieso ich das hier machen muss und nicht in der eigentlichen funktion dafür...)
        Bitmap LinkWalkAnim = new Bitmap("E:\\Das-Labyrinth\\Grundgerüst\\MainMenu\\MainMenu\\src\\link_move_anim.png");
        Boolean isDebug = true;
        Boolean isStart = false;

        public ActionCanvas()
        {
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //UpdateStyles();
            InitializeComponent();
            try
            {
                // Inizialisiere Bild
                //LinkWalkAnim = Bitmap.FromFile("E:\\Das-Labyrinth\\Grundgerüst\\MainMenu\\MainMenu\\src\\link_move_anim.png");
            }
            catch (Exception e) { Console.WriteLine("Bildladefehler!"); }

            // Wichtig! Nach dem Laden des Bildes
            // Erstellt Form unabhängigen Timer

            System.Timers.Timer a = new System.Timers.Timer();      // Neues Timer-Objekt
            a.Interval = 10;                                        // Intervall der Ausführung der A_Elapsed-Methode
            a.Elapsed += A_Elapsed;
            a.Enabled = true;
        }

        private void ActionCanvas_Load(object sender, EventArgs e)
        {
            // Inizialisieren der Auflösung
            w = this.Size.Width;
            h = this.Size.Height;
        }

        // Methode zum testen der App
        private void debugMode()
        {
            if (isDebug)
            {
                Console.WriteLine("Resolution: " + w + " x " + h);
            }
        }

        // Loop-Methode die alle x ms aufgerufen wird (siehe Intervall System-Timers)
        private void A_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (isStart)
            {
            }
            Repaint(); // Ruft Methode zum übermalen der aktuellen Leinwand auf
        }

        // Refresh Methode zur Bereinigung der Leinwand
        void Repaint()
        {
            if (this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new Action(Repaint));
                }
                catch (InvalidOperationException)
                { }
            }
            else
            {
                this.Refresh();
            }
        }

        // Bewegung / Animation Methoden
        int xLinkWalkAnim = 10;
        int yLinkWalkAnim = 10;

        static int speedObject = 1;
        static Boolean up = false, down = true, left = false, right = false;
            public void moveObject()
        {
            if (up)
            {
                yLinkWalkAnim -= speedObject;
            }
            if (down)
            {
                yLinkWalkAnim += speedObject;
            }
            if (left)
            {
                xLinkWalkAnim -= speedObject;
            }
            if (right)
            {
                xLinkWalkAnim += speedObject;
            }
        }

        // Simuliere Input
        // Rechteckige Bahn
        static int i = 0;
        public void moveRect()
        {
            i++;
            switch (i)
            {
                case 150: down = false; right = true;
                    break;
                case 300: right = false; up = true;
                    break;
                case 450: up = false; left = true;
                    break;
                case 600: left = false; down = true; i = 0;
                    break;
                default:
                    break;
            }
        }

        // Versuche eigene Methode zu bauen für autom. clipping die auf alle zukünftigen Objekte angewendet werden können
        public static void plotFrame(Image image, int width, int height, int frame, int x, int y, PaintEventArgs e)
        {
            Rectangle clipRect = new Rectangle(0, 0, 25, 30);
            e.Graphics.SetClip(clipRect);
        }

        // Leinwand Methode die alles grafische darstellt
        private void ActionCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (isStart)
            {
                //e.Graphics.DrawRectangle(Pens.Black, 30, 30, 0+i, 0+i); // lusdisch... aber useless xD
                //e.Graphics.DrawImage(LinkWalkAnim, new Point(xLinkWalkAnim, yLinkWalkAnim));

                /* --- Clipping--- (Wichtig: Clipping muss vor dem letzten Drawcall gesetzt werden)
                Hier erstellen wir ein neues Grafikobjekt und legen es über unser SpriteObjekt.
                Das Grafikobjekt ist ein Rect mit der gleichen Höhe unseres Grafikobjektes aber nur mit einer von uns definierten Breite.
                Heisst: Bild ist 700 x30. Es handelt sich bei der Animation um 28 Einzerlbilder. Bedeutet 700 / 28 = 25. Bedeutet wir clippen
                ein Feld von 25 x 30.
                */

                Rectangle clipRect = new Rectangle(0, 0, 25, 30);
                //Rectangle clipRectEnd = new Rectangle(0, 0, w, h);
                e.Graphics.SetClip(clipRect);
                e.Graphics.DrawImage(LinkWalkAnim, 0, 0, LinkWalkAnim.Width, LinkWalkAnim.Height);

                /* ---Image Loading mit Transparenz)
                Hier erstellen wir ein Image-Objekt. Davon holen wir die Hintergrundfarbe (R = 255, G = 0, B = 255) und sagen,
                dass diese Transparent sein soll.
                Unmittelbar danach, laden wir das das gleiche Objekt nochmal nur das diesesmal die Hintergrundfarbe Transparent ist.
                Ich denke mal, dass wir das in einer Toolbox später auslagern können und wenn wir uns auf eine allgemeine Transparentfarbe einigen,
                wir nicht stetig prüfen müssen um welche Hintergrundfarbe es sich handelt beim aktuellen Objekt.
                */

                e.Graphics.DrawImage(LinkWalkAnim, 0, 0, LinkWalkAnim.Width, LinkWalkAnim.Height);
                Color backColor = LinkWalkAnim.GetPixel(1, 1);
                LinkWalkAnim.MakeTransparent(backColor);
                //e.Graphics.DrawImage(LinkWalkAnim, 0, 0, LinkWalkAnim.Width, LinkWalkAnim.Height);


                // Moving around some stuff
                moveObject();
                moveRect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isStart = true;
            if (isStart)
            {
                btnStart.Visible = false;
            }
        }
    }
}
