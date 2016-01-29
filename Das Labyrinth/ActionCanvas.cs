using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Das_Labyrinth
{
    public partial class ActionCanvas : Form
    {
        static int w, h;

        public bool Left { get; set; }
        public bool Right { get; set; }
        public bool Up { get; set; }
        public bool Down { get; set; }
        public bool D { get; set; }

        // Inizialisiere Bild (komisch wieso ich das hier machen muss und nicht in der eigentlichen funktion dafür...)
        //Bitmap LinkWalkAnim = new Bitmap("E:\\Das-Labyrinth\\Grundgerüst\\MainMenu\\MainMenu\\src\\link_move_anim.png");
        //[TP]
        Bitmap LinkWalkAnim = new Bitmap("C:\\Users\\Radiac\\Desktop\\Grundgerüst\\MainMenu\\MainMenu\\src\\link_move_anim.png");
        Bitmap Megaman = new Bitmap("C:\\Users\\Radiac\\Desktop\\Grundgerüst\\MainMenu\\MainMenu\\src\\megaman.png");
        //[AK]
        //Bitmap LinkWalkAnim = new Bitmap("D:\\Haspel\\Das Labyrinth\\Das Labyrinth\\src\\link_move_anim.png");

        static byte figureFrame = 0;

        Boolean isDebug = false;
        Boolean isStart = true;

        public ActionCanvas()
        {
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //UpdateStyles();
            InitializeComponent();
            btnStart.Visible = false;
            try
            {
                // Inizialisiere Bild
                //LinkWalkAnim = Bitmap.FromFile("E:\\Das-Labyrinth\\Grundgerüst\\MainMenu\\MainMenu\\src\\link_move_anim.png");
            }
            catch (Exception e) { Console.WriteLine("Bildladefehler!"); }

            // Wichtig! Nach dem Laden des Bildes
            // Erstellt Form unabhängigen Timer

            System.Timers.Timer a = new System.Timers.Timer();      // Neues Timer-Objekt
            a.Interval = 1;                                        // Intervall der Ausführung der A_Elapsed-Methode
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

        DateTime lastUpdate = DateTime.MinValue; // Letzer Zeitpunkt des Updates von Game-Logik
        TimeSpan updateInterval = new TimeSpan(0, 0, 0, 0, 50); // Wie oft soll die Game-Logik aktualisiert werden (50ms)

        // Loop-Methode die alle x ms aufgerufen wird (siehe Intervall System-Timers)
        private void A_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (isStart)
            {
            }

            // Wenn Jetzt - letzter Zeitpunkt des Game-Logik-Updates grösser als die 50ms Update-Intervall sind, dann erneut Updaten
            if (DateTime.Now - lastUpdate > updateInterval)
            {
                // Hier wird nun die Logik des Spiels vorwärts getrieben, bzw. das vom Frame erhöhen
                UpdateGameLogic();
                lastUpdate = DateTime.Now; // Zuletzt updated = Jetzt
            }

            // Immer Zeichnen
            Repaint(); // Ruft Methode zum übermalen der aktuellen Leinwand auf
            // Colli Logik hier rein weil keine framesperre
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

        static int speedObject = 2;
        public void moveObject()
        {
            if (Up)
            {
                yLinkWalkAnim -= speedObject;
                figureFrame = getFrame(figureFrame, (byte)14, (byte)20, (byte)4);
            }
            if (Down)
            {
                yLinkWalkAnim += speedObject;
                figureFrame = getFrame(figureFrame, (byte)21, (byte)27, (byte)4);
            }
            if (Left)
            {
                xLinkWalkAnim -= speedObject;
                figureFrame = getFrame(figureFrame, (byte)7, (byte)13, (byte)4);
            }
            if (Right)
            {
                xLinkWalkAnim += speedObject;
                figureFrame = getFrame(figureFrame, (byte)0, (byte)6, (byte)4);
            }
        }

        // plotFrame Methode initialisiert und definiert das Bild und die Bereiche
        public static void plotFrame(
            Bitmap bitmap, // Bildobjekt laden
            int width, // Bildlänge eines Frames
            int height, // Bildhöhe eines Frames
            int frame, // Frame zur kontrolle der Geschwindigkeit
            int x, //Position des Bild x
            int y, // Position des Bild y
            PaintEventArgs e
            )
        {
            Rectangle clipRect = new Rectangle(x, y, width, height); // Clippingbereich definieren
            e.Graphics.SetClip(clipRect); // Clippen
            e.Graphics.DrawImage(bitmap, x - frame * width, y); // Zieht den Animationsstreifen per Frame (x-Pos des Bildes - Frame * Bildlänge) 
        }

        // Eine Methode zur Kontrolle der Framerate um das Bild langsamer zu machen
        static byte timerFrame = 0;
        public static byte getFrame(byte frame, byte min, byte max, byte step)
        {
            if (frame < min || frame > max) frame = min;
            if (step < 1) step = 1;
            if (timerFrame % step == 0)
            {
                frame++;
                if (frame > max) frame = (byte)min;
            }
            return frame;
        }

        /* Pixelgenaue Collisionsprüfung (int) über Punkte
        Wir definieren 4 Punkte (Koordinaten). Eine eindeutige Kollision liegt dann vor,
        wenn alle 8 Bedingungen der if-Abfrage erfüllt sind.
        */
        public static bool checkCollision(
            int x1, int y1, // Rechteck 1: Punkt links oben
            int x2, int y2, // Rechteck 1: Punkt rechts unten
            int x3, int y3, // Rechteck 2: Punkt links oben
            int x4, int y4  // Rechteck 2: Punkt rechts unten
            )
        {
            // Ist Bedingung erfüllt dann true = Kollision
            if (x2 >= x3 && x4 >= x1 && y2 >= y3 && y4 >= y1)
            { return true; }
            else return false;
        }
        /* Pixelgenaue Collisionsprüfung (int) anhand von Rechtecken (Flächen)
        Erleichtert jetzt die Kollisionsbereiche zu zeichnen. Benutzen wir um Rechtecke um Objekte zu definieren,
        die eine Collisionsabfrage starten und sobald diese sich berühren ein true zurück werfen.
        */
        public static bool checkColRect(
            int x1, int y1, int w1, int h1, // Rechteck 1
            int x3, int y3, int w2, int h2 // Rechteck 2
            )
        {
            //Definition der Rechtecke (Bounding Box)
            int x2 = x1 + w1, y2 = y1 + h1; // Rechteck1: Punkt rechts unten!
            int x4 = x3 + w2, y4 = y3 + h2; // Rechteck 2: Punkt rechts unten!
            return checkCollision(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        // Spiel-Logik die etwas verlangsamt ausgeführt wird gegenüber dem Zeichnen (kontrolliert)
        void UpdateGameLogic()
        {
            moveObject();
        }

        // Leinwand Methode die alles grafische darstellt
        private void ActionCanvas_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(Pens.Black, 30, 30, 0+i, 0+i); // lusdisch... aber useless xD
            //e.Graphics.DrawImage(LinkWalkAnim, new Point(xLinkWalkAnim, yLinkWalkAnim));

            /* --- Clipping--- (Wichtig: Clipping muss vor dem letzten Drawcall gesetzt werden)
            Hier erstellen wir ein neues Grafikobjekt und legen es über unser SpriteObjekt.
            Das Grafikobjekt ist ein Rect mit der gleichen Höhe unseres Grafikobjektes aber nur mit einer von uns definierten Breite.
            Heisst: Bild ist 700 x30. Es handelt sich bei der Animation um 28 Einzerlbilder. Bedeutet 700 / 28 = 25. Bedeutet wir clippen
            ein Feld von 25 x 30.
            */
            //Rectangle clipRect = new Rectangle(0, 0, 25, 30);
            //e.Graphics.SetClip(clipRect);
            //e.Graphics.DrawImage(LinkWalkAnim, 0, 0, LinkWalkAnim.Width, LinkWalkAnim.Height);

            /* ---Image Loading mit Transparenz)
            Hier erstellen wir ein Image-Objekt. Davon holen wir die Hintergrundfarbe (R = 255, G = 0, B = 255) und sagen,
            dass diese Transparent sein soll.
            Unmittelbar danach, laden wir das das gleiche Objekt nochmal nur das diesesmal die Hintergrundfarbe Transparent ist.
            Ich denke mal, dass wir das in einer Toolbox später auslagern können und wenn wir uns auf eine allgemeine Transparentfarbe einigen,
            wir nicht stetig prüfen müssen um welche Hintergrundfarbe es sich handelt beim aktuellen Objekt.
            */

            //e.Graphics.DrawImage(LinkWalkAnim, 0, 0, LinkWalkAnim.Width, LinkWalkAnim.Height);
            int megax = 100;
            int megay = 100;

            bool col = checkColRect(
             xLinkWalkAnim + 2, yLinkWalkAnim + 1, 25, 30,
            megax, megay, Megaman.Width, Megaman.Height);
            //Console.WriteLine("isCollision " + col);

            if (isDebug)
            {
                // Collisionsrects for Testing
                Pen blackPen = new Pen(Color.Black, 3);
                // LINK
                e.Graphics.DrawRectangle(Pens.Red, xLinkWalkAnim + 2, yLinkWalkAnim + 1, 25, 30);
                //MEGAMAN
                e.Graphics.DrawRectangle(Pens.Red, megax, megay, Megaman.Width, Megaman.Height);
                String drawString = ("Collision: " +col);
                Font drawFont = new Font("Arial", 8);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                RectangleF drawRect = new RectangleF(xLinkWalkAnim - 10, yLinkWalkAnim + 30, 100, 20);
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect);
            }
            e.Graphics.DrawImage(Megaman, megax, megay, Megaman.Width, Megaman.Height);
            // plotMethode zeichnen
            plotFrame(LinkWalkAnim, 25, 30, figureFrame, xLinkWalkAnim, yLinkWalkAnim, e);
                Color backColor = LinkWalkAnim.GetPixel(1, 1);
                LinkWalkAnim.MakeTransparent(backColor);
        }
        // switch variable
        public int sw = 0;
        //InputManager
        private void ActionCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Left = true;
                    break;
                case Keys.Right:
                    Right = true;
                    break;
                case Keys.Up:
                    Up = true;
                    break;
                case Keys.Down:
                    Down = true;
                    break;
                // Debugmode switch per key
                case Keys.D:
                    sw += 1;
                    if (sw % 2 == 0)
                        isDebug = false;
                    else isDebug = true;
                    break;
            }
        }

        private void ActionCanvas_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Left = false;
                    break;
                case Keys.Right:
                    Right = false;
                    break;
                case Keys.Up:
                    Up = false;
                    break;
                case Keys.Down:
                    Down = false;
                    break;
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
