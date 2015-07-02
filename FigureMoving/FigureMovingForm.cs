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
        private List<Figure> figureList;

        bool move = false;

        public FigureMovingForm()
        {
            InitializeComponent();
            figureList = new List<Figure>();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Figure circle = new Circle();
            figureList.Add(circle);
            circle.Draw(graphics);
            figureTreeView.Nodes.Add(circle.GetType().Name.ToString());
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Figure triangle = new Triangle();
            figureList.Add(triangle);
            triangle.Draw(graphics);
            figureTreeView.Nodes.Add(triangle.GetType().Name.ToString());
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Figure rectangle = new Rectangle();
            figureList.Add(rectangle);
            rectangle.Draw(graphics);
            figureTreeView.Nodes.Add(rectangle.GetType().Name.ToString());
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            move = true;
        }

        private void figureTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (move)
            {
                foreach (var figure in figureList)
                {
                    figure.Move();
                    figure.Draw(e.Graphics);
                }
            }
        }
    }
}
