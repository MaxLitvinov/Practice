using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureMoving
{
    class Rectangle : Figure
    {
        Pen pen = new Pen(new SolidBrush(Color.Red), 3);

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, 80, 80, 200, 100);
        }

        public override void Move(int x, int y)
        {
        }
    }
}
