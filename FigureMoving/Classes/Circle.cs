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
        static float x;
        static float y;
        float radius;

        public Circle(float radius, float dx, float dy) : base(dx + radius, dy + radius)
        {
            this.radius = radius;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(new SolidBrush(Color.Green), 3);
            PointF location = new PointF(x, y);
            SizeF circleSize = new SizeF(35, 35);
            RectangleF rectangleF = new RectangleF(location, circleSize);
            graphics.DrawEllipse(pen, rectangleF);
        }

        public override void Move(PictureBox pictureBox)
        {
            if (x > 0 && y > 0)
            {
                x += 1;
                y += 1;
            }
        }
    }
}
