using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace проект_начало
{
   
    abstract class Func

    {
        protected int znak;
        public float a, b, c;
        //protected int step, delx, dely, d, sh;
        public float y { get; set; }
         protected  SolidBrush br = new SolidBrush(Color.Red);
        public abstract void draw(Graphics canavas, Panel panel, int step);
        public float delX { get; set; }
        public float delY { get; set; }
        public bool isDrag { get; set; }
        public Func(float a, float b, float c, int znak)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.znak = znak;
        }
        public static float SCHET(float x1, float x2, float y1, float y2, int MX, int MY)
        {
            return (MX - x1) * (y2 - y1) - (MY - y1) * (x2 - x1);
        }
        public abstract bool check(int MX, int MY, Panel panel, int step);
        public abstract int dvig(int step);
    }
    
    class Line : Func
    {
        PointF[] points;
        public Line(float a, float b, float c, int znak) : base(a, b, c, znak) { }
        public override int dvig(int step)
        {
            int c1 = 0;
            if (a != 0 )
            {
                float x1 = (-b * y - c) / a+delX/step;
                float y1 = delY/step;
                c1 = Convert.ToInt32(-x1 * a - y1 * b);
            }
            else
            {
                if (b != 0)
                {
                    float x1 = 0;
                    float y1 = (- c) / b+delY / step;
                    
                    c1 = Convert.ToInt32(-x1 * a - y1 * b);
                }
            }
           
            return c1;
        }
        public override bool check(int MX, int MY, Panel panel, int step)
        {
            bool checks=false ;
            int dely = panel.Height / 25 * step;
            int delx = panel.Width / 160 * step;
            int d = panel.Width;
            int sh = panel.Height;
            float x1;
            float y1;
            float x2;
            float y2;

            
            if (a != 0 && b != 0)
            {
                x1 = 0;
                y1 = dely - ((a * delx / step - c) * step / b);
                x2 = d;
                y2 = dely - ((-a * (d - delx) / step - c) / b) * step;
                if (b > 0)
                {
                   
                        if (znak == 0 || znak == 1)
                        {
                        if (SCHET(x1, x2, y1, y2, MX, MY) <= 0)
                            checks = true;
                         }
                        else
                        {
                        if (SCHET(x1, x2, y1, y2, MX, MY) >= 0)
                            checks = true;
                    }
                    
                }
                else
                {
                    if (b < 0)
                    {
                       
                            if (znak == 0 || znak == 1)
                            {
                            if (SCHET(x1, x2, y1, y2, MX, MY) >= 0)
                                checks = true;
                        }
                            else
                            {
                            if (SCHET(x1, x2, y1, y2, MX, MY) <= 0)
                                checks = true;
                        }
                        
                    }
                }
            }
            else
            {
                if (a == 0)
                {
                    
                    y1 = dely + step * c / b;
                    
                        if (znak == 2 || znak == 3)
                        {
                        if (MY <= y1)
                            checks = true;
                        }
                        else
                        {
                        if (MY >= y1)
                            checks = true;
                        }
                    
                }
                else
                {
                    x1 = delx - (c * step) / a;
                    
                        if (znak == 0 || znak == 1)
                        {
                        if (MX <= x1)
                            checks = true;
                        }
                        else
                        {
                        if (MX >= x1)
                            checks = true;
                        }
                    
                }
          
        }
            if (checks == true)
                return true;
            else return false;
    }
        public override void draw(Graphics canavas, Panel panel, int step)
        {
            int dely = panel.Height / 25 * step;
            int delx = panel.Width / 160 * step;
            int d = panel.Width;
            int sh = panel.Height;
            float x1;
            float y1;
            float x2;
            float y2;
           
            Pen pen = new Pen(Color.Green, 1);
           
            if (a != 0 && b != 0)
            {
                x1 = 0;
                y1 = dely - ((a * delx / step - c) * step / b);
                x2 = d;
                y2 = dely - ((-a * (d - delx) / step - c) / b) * step;
                if (b > 0)
                {
                    if (znak == 5)
                    {
                        points = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, 0), new PointF(d, dely) };
                    }
                    else
                    {
                        if (znak == 0 || znak == 1)
                        {
                            points = new PointF[] { new PointF(x1, y1), new PointF(x2, y2), new PointF(x2, sh), new PointF(x1, sh) };
                        }
                        else
                        {
                            points = new PointF[] { new PointF(x1, y1), new PointF(x2, y2), new PointF(x2, 0), new PointF(x1, 0) };
                        }
                    }
                }
                else
                {
                    if (b < 0)
                    {
                        if (znak == 5)
                        {
                            points = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, 0), new PointF(d, dely) };
                        }
                        else
                        {
                            if (znak == 0 || znak == 1)
                            {
                                points = new PointF[] { new PointF(x1, y1), new PointF(x2, y2), new PointF(x2, 0), new PointF(x1, 0) };
                            }
                            else
                            {

                                points = new PointF[] { new PointF(x1, y1), new PointF(x2, y2), new PointF(x2, sh), new PointF(x1, sh) };
                            }
                        }
                    }
                }
            }
            else
            {
                if (a == 0)
                {
                    x1 = 0;
                    y1 = dely+step*c/b;
                    x2 = d;
                    y2 = y1;
                   
                        canavas.DrawLine(pen, delx, y1, d, y1);
                        if (znak == 5)
                        {
                            points = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, 0), new PointF(d, dely) };
                        }
                        else
                        {
                            if (znak == 2 || znak == 3)
                            {
                                points = new PointF[] { new PointF(delx, y1), new PointF(delx, 0), new PointF(d, 0), new PointF(d, y1) };
                            }
                            else
                            {
                                points = new PointF[] { new PointF(delx, y1), new PointF(d, y1), new PointF(d, dely), new PointF(delx, dely) };
                            }
                        }
                       
                    

                }
                else
                {
                    x1 = delx - (c* step)/a;
                    x2 = x1;
                    y1 = 0;
                    y2 = sh;
                    
                   
                        if (znak == 5)
                        {
                            points = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, 0), new PointF(d, dely) };
                        }
                        else
                        {
                            if (znak == 0 || znak == 1)
                            {
                                points = new PointF[] { new PointF(x1, dely), new PointF(x1, 0), new PointF(delx, 0), new PointF(delx, dely) };
                            }
                            else
                            {
                                points = new PointF[] { new PointF(x1, dely), new PointF(x1, 0), new PointF(d, 0), new PointF(d, dely) };
                            }
                        }
                       
                    

                }
            }
            canavas.FillPolygon(br, points);
            canavas.DrawLine(pen, x1, y1, x2, y2);
        }
    }
    class Parabolic : Func
    {
         int n;
         PointF[] points;
        PointF[] nerav;
        PointF[] nerav2;
        int l;
        public Parabolic(float a, float b, float c, int znak) : base(a, b, c, znak ) { l = 0; }
       
       
             public override int dvig(int step)
        {
            int c1 = Convert.ToInt32(c - delY / step);
            l = l +Convert.ToInt32( delX / step);
            return c1;
        }

        public override bool check(int MX, int MY, Panel panel, int step)
        {
            int dely = panel.Height / 25 * step;
            int delx = panel.Width / 160 * step + l * step;
            bool checks = false;
            if (znak == 0 || znak == 1)
            {
                if (b * (-MY + dely) / step <= -a * ((MX - delx) / step) * ((MX - delx) / step) - c)
                    checks = true;

            }
            if (znak == 2 || znak == 3)
            {
                if (b * (-MY + dely) / step >= -a * ((MX - delx) / step) * ((MX - delx) / step) - c)
                    checks = true;
            }
            if (checks == true)
                return true;
            else
                return false;
        }
        public override void draw(Graphics canavas, Panel panel, int step)
        {
            int dely = panel.Height / 25 * step;
            int delx = panel.Width / 160 * step + l * step ;
            int d = panel.Width;
            int sh = panel.Height;
            n = (d - delx) / step + 1; points = new PointF[n];  PointF[] points1 = new PointF[n];
            for (int x = 0; x < n; x++)
                {
                    y = (-c - a * x * x) / b;
                points[x] = new PointF(x*step+delx, dely-y*step);
                }

            for (int x = 0; x < n; x++)
            {
                y = (-c - a * x * x) / b;
                points1[x] = new PointF(-x * step + delx, dely - y * step);
            }
            canavas.DrawCurve(new Pen(Color.Red, 8), points1, 1f);
            if (znak == 5)
            {
                points = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, 0), new PointF(d, dely)};
            }
            else
            {
                if (znak == 0 || znak == 1)
                {
                    nerav = new PointF[n + 3];
                    nerav2 = new PointF[n + 3];
                    for (int x = 0; x < n; x++)
                    {

                        nerav[x] = points[x];
                        nerav2[x] = points1[x];
                    }
                    nerav[n + 2] = new PointF(delx, dely);
                   
                    nerav[n] = new PointF(d, 0);
                    nerav[n + 1] = new PointF(d, dely);
                    nerav2[n + 2] = new PointF(delx, dely);

                    nerav2[n] = new PointF(-d, 0);
                    nerav2[n + 1] = new PointF(-d, dely);
                }
                else
                {
                    nerav = new PointF[n +1];
                    for (int x = 0; x < n; x++)
                    {

                        nerav[x] = points[x];
                    }
                    nerav[n] = new PointF(delx, 0);
                    nerav2 = new PointF[n+1 ];
                    for (int x = 0; x < n; x++)
                    {

                        nerav2[x] = points1[x];
                    }
                    nerav2[n] = new PointF(delx, 0);
                }
            }
            canavas.FillPolygon(br, nerav);
            canavas.FillPolygon(br, nerav2);


        }
    }
    
    class Hyper : Func
    {
        int n;
        PointF[] points;
        PointF[] nerav;
        int mx1 =  1;
        int my1 ;
        public Hyper(float a, float b, float c, int znak) : base(a, b, c, znak) { my1 = -Convert.ToInt32(c); }
        public override int dvig(int step)
        {

            mx1 = Convert.ToInt32( + delX / step) + mx1;
            my1 = Convert.ToInt32( + delY / step)  + my1;

            int c1 = mx1 * my1;
            if (c1 > 0)
                return -c1;
            else
                return -8;
        }
        public override bool check(int MX, int MY, Panel panel, int step)
        {
            int dely = panel.Height / 25 * step;
            int delx = panel.Width / 160 * step;
            bool checks = false;
            if (znak == 0 || znak == 1)
            {
               if ( (-MY + dely) / step <= -c / ((MX - delx)/step))
                    checks = true;

            }
            if (znak == 2 || znak == 3)
            {
                if ((-MY + dely) / step >= -c / ((MX - delx)/step))
                    checks = true;
            }
            if (checks == true)
                return true;
            else
                return false;
        }
       
        public override void draw(Graphics canavas, Panel panel, int step)
        {
            int dely = panel.Height / 25 * step;
            int delx = panel.Width / 160 * step;
            int d = panel.Width;
            int sh = panel.Height;
            n = (d - delx) / step + 2; points = new PointF[n];
            float x1;
            for (int  x = 1; x < n; x++)
            {
            
              y= -c / (a * x);
               points[x] = new PointF(x * step + delx, dely - y * step);
            }
            x1 = -c / (a * (sh - dely)) + delx;
            points[0] = new PointF(x1, 0);

            canavas.DrawCurve(new Pen(Color.Red, 3), points, 0.09f);
            if (znak == 5)
            {
                nerav = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, 0), new PointF(d, dely) };
            }
            else
            {
                if (znak == 0 || znak == 1)
                {
                    nerav = new PointF[n + 3];
                    for (int x = 0; x < n; x++)
                    {

                        nerav[x] = points[x];
                    }
                    nerav[n ] = new PointF(d, dely);
                    nerav[n + 1] = new PointF(delx, dely);
                    nerav[n+2] = new PointF(delx, 0);

                }
                else
                {
                    nerav = new PointF[n + 1];
                    for (int x = 0; x < n; x++)

                    {

                        nerav[x] = points[x];
                    }
                    nerav[n] = new PointF(d, 0);

                }
            }
            canavas.FillPolygon(new SolidBrush(Color.Blue), nerav);
        }
    }

}
