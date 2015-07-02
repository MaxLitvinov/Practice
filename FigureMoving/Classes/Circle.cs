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
        float x;
        float y;
        float radius;
        PointF center;

        public Circle(float x, float y, float radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.center = new PointF(this.x + this.radius, this.y + this.radius);
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(new SolidBrush(Color.Green), 3);
            PointF location = new PointF(this.x, this.y);
            SizeF circleSize = new SizeF(radius, radius);
            RectangleF rectangleF = new RectangleF(location, circleSize);
            graphics.DrawEllipse(pen, rectangleF);
        }

        public override void Move(PictureBox pictureBox)
        {

        }
    }
}
