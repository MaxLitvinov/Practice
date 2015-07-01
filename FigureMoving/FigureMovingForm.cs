using FigureMoving.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FigureMoving
{
    public partial class FigureMovingForm : Form
    {
        bool circleFlag = false;
        bool triangleFlag = false;
        bool rectangleFlag = false;

        public FigureMovingForm()
        {
            InitializeComponent();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            circleFlag = true;
            pictureBox.Refresh();
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            triangleFlag = true;
            pictureBox.Refresh();
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            rectangleFlag = true;
            pictureBox.Refresh();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {

        }

        private void figureTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (circleFlag)
            {
                Graphics graphics = e.Graphics;
                Figure circle = new Circle();
                circle.Draw(graphics);
            } 
            if (triangleFlag)
            {
                Graphics graphics = e.Graphics;
                Figure triangle = new Triangle();
                triangle.Draw(graphics);
            }
            if (rectangleFlag)
            {
                Graphics graphics = e.Graphics;
                Figure rectangle = new Rectangle();
                rectangle.Draw(graphics);
            }
        }
    }
}
