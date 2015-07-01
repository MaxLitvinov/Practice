using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FigureMoving
{
    class Circle : Figure
    {
        Pen pen = new Pen(new SolidBrush(Color.Green), 3);
        static PointF location = new PointF(100, 200);
        static SizeF circleSize = new SizeF(35, 35);
        RectangleF rectangleF = new RectangleF(location, circleSize);

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, rectangleF);
        }

        public override void Move(int x, int y)
        {
            
        }
    }
}
