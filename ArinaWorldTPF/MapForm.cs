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
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.Xml;

namespace ArinaWorldTPF
{
    public partial class MapForm : Form
    {
        Point mousePosition;

        public MapForm()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            //UpdateStyles();
        }

        Point TraslateTransform(Point p, int transformX, int transformY)
        {
            return new Point(p.X + transformX, p.Y + transformY);
        }

        Point TraslateTransformInverse(Point p, int transformX, int transformY)
        {
            return new Point(p.X - transformX, p.Y - transformY);
        }

        Point RotateTransform(Point p, double multipierY, double multipierZ1, double multipierZ2)
        {
            return new Point((int)(p.X * multipierZ1 - p.Y * multipierZ2), (int)((p.Y * multipierZ1 + p.X * multipierZ2) * multipierY));
        }

        Point RotateTransformInverse(Point p, double multipierY, double multipierZ1, double multipierZ2)
        {
            Point r = new Point(p.X, (int)(p.Y / multipierY));            
            return new Point((int)((r.X * multipierZ1 + r.Y * multipierZ2) / (multipierZ1 * multipierZ1 + multipierZ2 * multipierZ2)),
                (int)((r.Y * multipierZ1 - r.X * multipierZ2) / (multipierZ1 * multipierZ1 + multipierZ2 * multipierZ2)));            
        }

        Point AmplificationTransform(Point p, int amplificationFactor)
        {
            return new Point(p.X * amplificationFactor, p.Y * amplificationFactor);
        }

        Point AmplificationTransformInverse(Point p, int amplificationFactor)
        {
            return new Point(p.X / amplificationFactor, p.Y / amplificationFactor);
        }

        public void DrawMap(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            Point[] points;
            if (Var.Map == null || Var.Map.Grids == null)
                return;

            double multipierY = Math.Cos((double)Var.RotateAngleY / 180);
            double multipierZ1 = Math.Cos((double)Var.RotateAngleZ / 180);
            double multipierZ2 = Math.Sin((double)Var.RotateAngleZ / 180);
            int transformX = Var.TransformX;
            int transformY = Var.TransformY;
            
            //計算框內的格子邊界
            Point[] vertex = { new Point(0, 0), new Point(pibMain.Width + 1, 0), new Point(0, pibMain.Height + 1), new Point(pibMain.Width + 1, pibMain.Height + 1)};
            
            for(int i = 0; i < 4; i++)
            {
                vertex[i] = TraslateTransformInverse(vertex[i], transformX, transformY);
                vertex[i] = RotateTransformInverse(vertex[i], multipierY, multipierZ1, multipierZ2);
                vertex[i] = AmplificationTransformInverse(vertex[i], Setting.AmplificationFactor);
                
            }

            int minX = Var.Map.Grids.GetLength(0), minY = Var.Map.Grids.GetLength(1), maxX = 0, maxY = 0;
            for(int i = 0; i < 4; i++)
            {
                if (minX > vertex[i].X)
                    minX = vertex[i].X;
                if (minY > vertex[i].Y)
                    minY = vertex[i].Y;
                if (maxX < vertex[i].X)
                    maxX = vertex[i].X;
                if (maxY < vertex[i].Y)
                    maxY = vertex[i].Y;
            }
            if (minX < 0)
                minX = 0;
            if (minY < 0)
                minY = 0;
            if (maxX >= Var.Map.Grids.GetLength(0))
                maxX = Var.Map.Grids.GetLength(0) - 1;
            if (maxY >= Var.Map.Grids.GetLength(1))
                maxY = Var.Map.Grids.GetLength(1) - 1;
            
            g.Clear(BackColor);
            for (int i = minX; i <= maxX; i++)
            {
                for (int j = minY; j <= maxY; j++)
                {
                    points = new Point[4];
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
                    if (Var.Map.Grids[i, j].SurfaceFeature == Geography.SurfaceFeatures["Sea"])
                    {
                        brush = new SolidBrush(Color.Blue);
                        g.FillPolygon(brush, points);
                    }
                    else if (Var.Map.Grids[i, j].SurfaceFeature == Geography.SurfaceFeatures["Grass"])
                    {
                        brush = new SolidBrush(Color.Green);
                        g.FillPolygon(brush, points);
                    }
                    else
                    {
                        //brush = new SolidBrush(Color.Gray);
                        g.DrawPolygon(pen, points);
                        //    //g.FillPolygon(brush, points);
                    }
                    
                    //g.DrawString(Var.Map.Grids[i, j].Altitude.ToString(), new Font("Consolas", 16),
                    //    new SolidBrush(Color.Black), points[0]);
                }
            }

            points = new Point[4];
            points[0] = new Point(Var.SelectedBlock.X, Var.SelectedBlock.Y);
            points[1] = new Point(Var.SelectedBlock.X + 1, Var.SelectedBlock.Y);
            points[2] = new Point(Var.SelectedBlock.X + 1, Var.SelectedBlock.Y + 1);
            points[3] = new Point(Var.SelectedBlock.X, Var.SelectedBlock.Y + 1);
            for (int k = 0; k < 4; k++)
            {   
                points[k] = AmplificationTransform(points[k], Setting.AmplificationFactor);
                points[k] = RotateTransform(points[k], multipierY, multipierZ1, multipierZ2);
                points[k] = TraslateTransform(points[k], transformX, transformY);

            }
            g.DrawPolygon(new Pen(Color.White, 2), points);

            //Draw Buffer
            //if(Var.bufferGraphics.Graphics.IsVisible())
            if(Var.DrawBuffer)
                Var.bufferGraphics.Render(g);

            g.Flush();
        }

        public void Redraw()
        {
            pibMain.Invalidate();
        }

        public void RotateLeft(int amount = 10)
        {
            Var.RotateAngleZ -= Math.Abs(amount);
            Redraw();
        }

        public void RotateRight(int amount = 10)
        {
            Var.RotateAngleZ += Math.Abs(amount);
            Redraw();
        }

        public void RotateUp(int amount = 10)
        {
            if (Var.RotateAngleY > -180)
                Var.RotateAngleY -= Math.Abs(amount);
            else
                return;
            if (Var.RotateAngleY < -180)
                Var.RotateAngleY = -180;
            Redraw();
        }

        public void RotateDown(int amount = 10)
        {
            if (Var.RotateAngleY < 0)
                Var.RotateAngleY += Math.Abs(amount);
            else
                return;
            if (Var.RotateAngleY > 0)
                Var.RotateAngleY = 0;
            Redraw();
        }

        public void CenterCamera()
            => CenterCamera(Var.SelectedBlock, Setting.AmplificationFactor);

        public void CenterCamera(Point p, int amplificationFactor = 50)
        {   
            double multipierY = Math.Cos((double)Var.RotateAngleY / 180);
            double multipierZ1 = Math.Cos((double)Var.RotateAngleZ / 180);
            double multipierZ2 = Math.Sin((double)Var.RotateAngleZ / 180);
            Setting.AmplificationFactor = amplificationFactor;
            Point r = AmplificationTransform(p, Setting.AmplificationFactor);
            r = new Point(r.X + Setting.AmplificationFactor / 2, r.Y + Setting.AmplificationFactor / 2);
            r = RotateTransform(r, multipierY, multipierZ1, multipierZ2);
            Var.TransformX = pibMain.Width / 2 - r.X;
            Var.TransformY = pibMain.Height / 2 - r.Y;
            pibMain.Invalidate();
        }

        private void MapForm_Load(object sender, EventArgs e)
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
                case 'x':
                    CenterCamera();
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
            if (e.Button == MouseButtons.Right)
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
            else if (e.Button == MouseButtons.Left)
            {
                if (mousePosition != Point.Empty)
                {
                    Var.TransformX += e.X - mousePosition.X;
                    Var.TransformY += e.Y - mousePosition.Y;
                    Redraw();
                }
                mousePosition = e.Location;
            }
        }

        private void pibMain_MouseUp(object sender, MouseEventArgs e)
        {
            mousePosition = Point.Empty;
        }

        private void pibMain_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                Setting.AmplificationFactor += 2;
            else
            {
                if (Setting.AmplificationFactor > 20)
                    Setting.AmplificationFactor -= 2;
            }
            Redraw();
        }

        private void pibMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (Var.Map == null)
                return;
            //計算位置
            double multipierY = Math.Cos((double)Var.RotateAngleY / 180);
            double multipierZ1 = Math.Cos((double)Var.RotateAngleZ / 180);
            double multipierZ2 = Math.Sin((double)Var.RotateAngleZ / 180);
            int transformX = Var.TransformX;
            int transformY = Var.TransformY;            
            Point p = new Point(e.X, e.Y);

            p = TraslateTransformInverse(p, transformX, transformY);
            p = RotateTransformInverse(p, multipierY, multipierZ1, multipierZ2);
            p = AmplificationTransformInverse(p, Setting.AmplificationFactor);

            if (p.X >= 0 && p.Y >= 0 && p.X < Var.Map.Grids.GetLength(0) && p.Y < Var.Map.Grids.GetLength(1))
            Var.SelectedBlock = p;
            pibMain.Invalidate();
        }
        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            pibMain.Invalidate();
            base.OnInvalidated(e);
        }
    }
}
