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
        float x;
        float y;
        float foundation;
        float height;

        public Triangle(float x, float y, float foundation, float height)
        {
            this.x = x;
            this.y = y;
            this.foundation = foundation;
            this.height = height;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(new SolidBrush(Color.Blue), 3);
            PointF[] points = {
                                  new PointF(0, this.height),
                                  new PointF(this.foundation, this.height),
                                  new PointF(this.foundation / 2, 0),
                                  new PointF(0, this.height)
                              };
            graphics.DrawLines(pen, points);
        }

        public override void Move(PictureBox pictureBox)
        {
        }
    }
}
