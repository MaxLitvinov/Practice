using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FigureMoving.Classes
{
    class Triangle : Figure
    {
        Pen pen = new Pen(new SolidBrush(Color.Blue), 3);
        
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, 50, 0, 0, 50);
            graphics.DrawLine(pen, 0, 50, 100, 50);
            graphics.DrawLine(pen, 100, 50, 50, 0);
        }

        public override void Move(PictureBox pictureBox)
        {
        }
    }
}
