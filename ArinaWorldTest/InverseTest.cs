using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;



namespace ArinaWorldTest
{
    [TestClass]
    public class InverseTest
    {
        [TestMethod]
        public void TestMethod()
        {
            double multipierY = Math.Cos((double)70 / 180);
            double multipierZ1 = Math.Cos((double)70 / 180);
            double multipierZ2 = Math.Sin((double)70 / 180);
            int transformX = 200;
            int transformY = 200;
            int amplificationFactor = 50;
            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    Point p = new Point(i, j);
                    Console.Write(p.ToString());
                    p = AmplificationTransform(p, amplificationFactor);
                    p = RotateTransform(p, multipierY, multipierZ1, multipierZ2);
                    p = TraslateTransform(p, transformX, transformY);
                    Console.Write(p.ToString());
                    p = TraslateTransformInverse(p, transformX, transformY);
                    p = RotateTransformInverse(p, multipierY, multipierZ1, multipierZ2);
                    p = AmplificationTransformInverse(p, amplificationFactor);
                    Console.Write(p.ToString());
                    Console.WriteLine();
                }
            }
           
            //for (int i = 0; i < 100; i++)
            //{

            //}
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
            r = new Point((int)((r.X * multipierZ1 + r.Y * multipierZ2) / (multipierZ1 * multipierZ1 + multipierZ2 * multipierZ2)),
                (int)((r.Y * multipierZ1 - r.X * multipierZ2) / (multipierZ1 * multipierZ1 + multipierZ2 * multipierZ2)));
            return r;
        }

        Point AmplificationTransform(Point p, int amplificationFactor)
        {
            return new Point(p.X * amplificationFactor, p.Y * amplificationFactor);
        }

        Point AmplificationTransformInverse(Point p, int amplificationFactor)
        {
            return new Point((int)Math.Round((double)p.X / amplificationFactor), (int)Math.Round((double)p.Y / amplificationFactor));
        }


    }
}
