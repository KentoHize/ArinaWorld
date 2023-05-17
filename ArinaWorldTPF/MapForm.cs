using ArinaWorld;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;
using GameData;

namespace ArinaWorldTPF
{
    public partial class MapForm : Form
    {
        Point mousePosition;

        public MapForm()
        {
            InitializeComponent();
        }

        Point TraslateTransform(Point p, int transformX, int transformY)
        {
            return new Point(p.X + transformX, p.Y + transformY);
        }

        Point RotateTransform(Point p, double multipierY, double multipierZ1, double multipierZ2)
        {
            return new Point((int)(p.X * multipierZ1 - p.Y * multipierZ2), (int)((p.Y * multipierZ1 + p.X * multipierZ2) * multipierY));
        }

        Point AmplificationTransform(Point p, int amplificationFactor)
        {
            return new Point(p.X * amplificationFactor, p.Y * amplificationFactor);
        }

        public void DrawMap(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            if (Var.Map == null || Var.Map.Grids == null)
                return;

            g.Clear(BackColor);
            int maxGridLength = Var.Map.Grids.GetLength(0) > Var.Map.Grids.GetLength(1) ? Var.Map.Grids.GetLength(0) : Var.Map.Grids.GetLength(1);
            int radius = Setting.AmplificationFactor * maxGridLength / 2;

            double multipierY = Math.Cos((double)Setting.RotateAngleY / 180);
            double multipierZ1 = Math.Cos((double)Setting.RotateAngleZ / 180);
            double multipierZ2 = Math.Sin((double)Setting.RotateAngleZ / 180);
            //int transformX = Setting.TransformX + radius;
            //int transformY = Setting.TransformY + radius;
            int transformX = Var.Map.Grids.GetLength(0) * Setting.AmplificationFactor;
            int transformY = Var.Map.Grids.GetLength(1) * Setting.AmplificationFactor;
            for (int i = 0; i < Var.Map.Grids.GetLength(0); i++)
            {
                for (int j = 0; j < Var.Map.Grids.GetLength(1); j++)
                {
                    Point[] points = new Point[4];
                    points[0] = new Point(i, j);
                    points[1] = new Point(i + 1, j);
                    points[2] = new Point(i + 1, j + 1);
                    points[3] = new Point(i, j + 1);
                    //Transform Rule
                    //x = xcosT - ysinT
                    //y = ycosT + xsinT
                    for (int k = 0; k < 4; k++)
                    {
                        points[k] = AmplificationTransform(points[k], Setting.AmplificationFactor);
                        points[k] = RotateTransform(points[k], multipierY, multipierZ1, multipierZ2);
                        points[k] = TraslateTransform(points[k], transformX, transformY);

                    }

                    Brush brush;
                    if (Var.Map.Grids[i, j].SurfaceFeature == Geography.SurfaceFeatures["Grass"])
                    {
                        brush = new SolidBrush(Color.Green);
                        g.FillPolygon(brush, points);
                    }
                    else
                    {
                        //brush = new SolidBrush(Color.Gray);
                        g.DrawPolygon(pen, points);
                        //g.FillPolygon(brush, points);
                    }
                }
            }
            g.Flush();

        }

        public void RotateLeft(int amount = 10)
        {
            Setting.RotateAngleZ -= Math.Abs(amount);
            pibMain.Invalidate();
        }

        public void RotateRight(int amount = 10)
        {
            Setting.RotateAngleZ += Math.Abs(amount);
            pibMain.Invalidate();
        }

        public void RotateUp(int amount = 10)
        {
            if (Setting.RotateAngleY > -180)
                Setting.RotateAngleY -= Math.Abs(amount);
            else
                return;
            if (Setting.RotateAngleY < -180)
                Setting.RotateAngleY = -180;
            pibMain.Invalidate();
        }

        public void RotateDown(int amount = 10)
        {
            if (Setting.RotateAngleY < 0)
                Setting.RotateAngleY += Math.Abs(amount);
            else
                return;
            if (Setting.RotateAngleY > 0)
                Setting.RotateAngleY = 0;
            pibMain.Invalidate();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            //Temp
            if (Var.Map == null)
            {
                Var.Map = new Map();
                Var.Map.Name = "TestMap";
                Var.Map.Grids = new Grid[10, 10];
                Setting.AmplificationFactor = 50;
                Setting.TransformX = 10;
                Setting.TransformY = 10;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Var.Map.Grids[i, j] = new Grid();
                    }
                }
            }
        }
        private void MapForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MapForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'q':
                    RotateLeft();
                    break;
                case 'e':
                    RotateRight();
                    break;
                case 'w':
                    RotateUp();
                    break;
                case 's':
                    RotateDown();
                    break;

            }
        }


        private void pibMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;
            DrawMap(e.Graphics);
        }

        private void pibMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mousePosition != Point.Empty)
                {
                    if (mousePosition.X - e.X > 0)
                        RotateRight(mousePosition.X - e.X);
                    else if (mousePosition.X - e.X < 0)
                        RotateLeft(e.X - mousePosition.X);
                    if (mousePosition.Y - e.Y > 0)
                        RotateDown(mousePosition.Y - e.Y);
                    else if (mousePosition.Y - e.Y < 0)
                        RotateUp(e.Y - mousePosition.Y);
                }
                mousePosition = e.Location;
            }
        }

        private void pibMain_MouseUp(object sender, MouseEventArgs e)
        {
            mousePosition = Point.Empty;
        }
    }
}
