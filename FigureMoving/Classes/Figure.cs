using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureMoving
{
    abstract class Figure
    {
        float x;
        float y;
        
        public Figure(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void Draw(Graphics graphics);

        public abstract void Move(PictureBox pictureBox);
    }
}
