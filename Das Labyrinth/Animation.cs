using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Das_Labyrinth
{
    static class InvokeThread
    {
        //Thread auslagerung für die Refresh Methode der Leinwand
        static public void UIThread(this Control control, Action code)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(code);
                return;
            }
            code.Invoke();
        }
    }
    class Animation
    {
        public System.Timers.Timer a = new System.Timers.Timer();

        // plotFrame Methode initialisiert und definiert das Bild und die Bereiche
        public void plotFrame(
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
        static byte timerFrame = 0;
        public byte getFrame(byte frame, byte min, byte max, byte step)
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

       
        int xLinkWalkAnim = 10;
        int yLinkWalkAnim = 10;
        static byte figureFrame = 0;
        static int speedObject = 1;
        static Boolean up = false, down = true, left = false, right = false;
        
    }
}
