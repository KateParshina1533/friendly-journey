using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
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

            int x = 0; int y = 0;
            if (a != 0 && b != 0)
            {
                x1 = (-b * y - c) / a;
                y1 = (-a * x - c) / b;

                x1 = x1 * step + delx;
                y1 = dely - y1 * step;

                Pen pen = new Pen(Color.Green, 3);
                if (x1 > delx && y1 < dely)
                {
                    if (znak == 0 || znak == 1)
                    {

                        //if ((SCHET(x1, delx, dely, dely, MX, MY) >= 0 && SCHET(delx, x1, y1, dely, MX, MY) >= 0 && SCHET(delx, delx, y1, dely, MX, MY) >= 0) || (SCHET(x1, delx, dely, delx, MX, MY) <= 0 && SCHET(delx, x1, y1, dely, MX, MY) <= 0 && SCHET(delx, delx, y1, dely, MX, MY) <= 0))
                        //    checks = true;
                        //else
                        //    checks = false;
                        if (SCHET(delx, x1, y1, dely, MX, MY) <= 0)
                            checks = true;
                        else checks = false;

                    }
                    else
                    {
                        if (znak == 2|| znak==3)
                        {
                           
                            //if ((SCHET(x1, d, dely, dely, MX, MY)>=0&& SCHET(x1,delx, dely, y1, MX, MY)>=0 && SCHET(x1, delx, 0, y1, MX, MY)>=0 && SCHET(x1, d, 0, 0, MX, MY) >= 0 && SCHET(d, d, 0, dely, MX, MY) >= 0)|| (SCHET(x1, d, dely, dely, MX, MY) <= 0 && SCHET(x1, delx, dely, y1, MX, MY) <= 0 && SCHET(x1, delx, 0, y1, MX, MY) <= 0 && SCHET(x1, d, 0, 0, MX, MY) <= 0 && SCHET(d, d, 0, dely, MX, MY) <= 0))
                            //    checks=true;
                            //else checks= false;
                        }
                        if (SCHET(delx, x1, y1, dely, MX, MY) >= 0)
                            checks = true;
                        else checks = false;
                    }
                       
                }
                if (x1 >= delx && y1 >= dely)
                {
                    if (znak == 0 || znak == 1)
                    {
                        // points = new PointF[] { new PointF(x1, dely), new PointF(d, dely), new PointF(d, 0), new PointF(((-b * dely / step - c) / a) * step + delx, 0)};
                        //if ((SCHET(x1, d, dely, dely, MX, MY) >= 0 && SCHET(d, d, 0, dely, MX, MY) >= 0 && SCHET(d, ((-b * dely / step - c) / a) * step + delx, 0, 0, MX, MY) >= 0 && SCHET(x1, ((-b * dely / step - c) / a) * step + delx, dely, 0, MX, MY) >= 0) || (SCHET(x1, delx, dely, delx, MX, MY) <= 0 && SCHET(x1, delx, dely, dely, MX, MY) <= 0 && SCHET(delx, delx, y1, dely, MX, MY) <= 0 && SCHET(x1, ((-b * dely / step - c) / a) * step + delx, dely, 0, MX, MY) <= 0))
                        //    checks= true;
                        //else
                        //    checks= false;
                        if (SCHET(x1, ((-b * dely / step - c) / a) * step + delx, dely, 0, MX, MY) >= 0)
                            checks = true;
                        else checks = false;

                    }
                    else
                    {
                        if (znak == 2 || znak == 3)
                        {
                            // points = new PointF[] { new PointF(x1, dely), new PointF(delx, dely), new PointF(delx, 0),new PointF(((-b * dely / step - c) / a) * step + delx, 0) };
                            //if ((SCHET(x1, delx, dely, dely, MX, MY) >= 0 && SCHET(delx, delx, 0, dely, MX, MY) >= 0 && SCHET(((-b * dely / step - c) / a) * step + delx, delx, 0, 0, MX, MY) >= 0 && SCHET(x1, ((-b * dely / step - c) / a) * step+delx, dely, 0, MX, MY) >= 0) || (SCHET(x1, delx, dely, dely, MX, MY) <= 0 && SCHET(delx, delx, 0, dely, MX, MY) <= 0 && SCHET(((-b * dely / step - c) / a) * step + delx, delx, 0, 0, MX, MY) <= 0 && SCHET(x1, ((-b * dely / step - c) / a) * step + delx, dely, 0, MX, MY) <= 0))
                            //   checks= true;
                            //else checks=false;
                            if (SCHET(x1, ((-b * dely / step - c) / a) * step + delx, dely, 0, MX, MY) <= 0)
                                checks = true;
                            else checks = false;
                        }
                    }
                }
                if (x1 < delx && y1 < dely)
                {
                    if (znak == 0 || znak == 1)
                    {
                        //if ((SCHET(d, d, 0, dely, MX, MY) >= 0 && SCHET(((-b * dely / step - c) / a) * step + delx, d, 0, 0, MX, MY) >= 0 && SCHET(delx, ((-b * dely / step - c) / a) * step + delx, y1, 0, MX, MY) >= 0 && SCHET(delx,  delx, y1, dely, MX, MY) >= 0 &&SCHET(d, delx, dely, dely, MX, MY) >= 0 )|| (SCHET(x1, delx, dely, delx, MX, MY) <= 0 && SCHET(x1, delx, dely, dely, MX, MY) <= 0 && SCHET(delx, delx, y1, dely, MX, MY) <= 0 && SCHET(x1, ((-b * dely / step - c) / a) * step + delx, dely, 0, MX, MY) <= 0 && SCHET(d, delx, dely, dely, MX, MY) <= 0))
                        //   checks=true;
                        //else
                        //    checks = false;
                        // points = new PointF[] { new PointF(delx, y1), new PointF(((-b * dely / step - c) / a) * step + delx, 0), new PointF(d, 0), new PointF(d, dely), new PointF(delx, dely) };
                        if (SCHET(delx, ((-b * dely / step - c) / a) * step + delx, y1, 0, MX, MY) <= 0)
                            checks = true;
                        else checks = false;
                    }
                    if (znak == 2 || znak == 3)
                    {
                        //points = new PointF[] { new PointF(((-b * dely / step - c) / a) * step + delx, 0), new PointF(delx, 0), new PointF(delx, y1) };
                        //if (( SCHET(delx, delx, y1, 0, MX, MY) >= 0 && SCHET(((-b * dely / step - c) / a) * step + delx, delx,0,y1, MX, MY) >= 0 && SCHET(((-b * dely / step - c) / a) * step + delx,delx, 0,0, MX, MY)>=0) || (SCHET(delx, delx, y1, 0, MX, MY) <= 0 && SCHET(((-b * dely / step - c) / a) * step + delx, delx, 0, y1, MX, MY) <= 0 && SCHET(((-b * dely / step - c) / a) * step + delx, delx, 0, 0, MX, MY)<=0))
                        //    checks = true;
                        //else
                        //    checks = false;
                        if (SCHET(delx, ((-b * dely / step - c) / a) * step + delx, y1, 0, MX, MY) >= 0)
                            checks = true;
                        else checks = false;
                    }
                   
                }
                
            }
            else
            {
                Pen pen = new Pen(Color.Green, 5);
                if (a == 0)
                {
                    y1 = (-a * x - c) / b;
                    y1 = dely - y1 * step;
                    if (y1 < dely)
                        if (znak == 2 || znak == 3)
                        {
                            if (y1>MY)

                                checks = true;
                            else
                                checks = false;
                            
                        }
                      if(znak==1 || znak==0)
                        {

                        if (y1 < MY)

                            checks = true;
                        else
                            checks = false;
                    }

                }
                else
                {

                    x1 = (-b * y - c) / a;
                    x1 = x1 * step + delx;
                    if (x1 > delx)
                        if (znak == 2 || znak == 3)
                        {
                            if (MX >= x1)

                                checks = true;
                            else
                                checks = false;

                        }
                    if (znak == 1 || znak == 0)
                    {

                        if ((MX <= x1))

                            checks = true;
                        else
                            checks = false;
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
           // SolidBrush br = new SolidBrush(Color.Red);
            int x = 0; int y = 0;
            if (a != 0 && b != 0)
            {
                x1 = (-b * y - c) / a;
                y1 = (-a * x - c) / b;

                x1 = x1 * step + delx;
                y1 = dely - y1 * step;
                
                Pen pen = new Pen(Color.Green, 3);
                if (x1 > delx && y1 < dely)
                {
                    canavas.DrawLine(pen, x1, dely, delx, y1);
                    if (znak == 0|| znak==1)
                    {
                        points = new PointF[] { new PointF(x1, dely), new PointF(delx, y1), new PointF(delx, dely) };
                       
                    }
                    else
                    {
                        if (znak == 5)
                        {
                            points = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, 0), new PointF(d, dely) };
                        }
                        else
                        {
                            
                                points = new PointF[] { new PointF(x1, dely), new PointF(d, dely), new PointF(d, 0), new PointF(delx, 0), new PointF(delx, y1) };
                           
                        }
                    }
                    canavas.FillPolygon(br, points);
                }
                if (x1 >= delx && y1 >= dely)
                {
                    canavas.DrawLine(pen, x1, dely, ((-b * dely / step - c) / a) * step + delx, 0);
                    if (znak == 5)
                    {
                        points = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, dely), new PointF(d, 0) };
                    }
                    else
                    {
                        if (znak == 2 || znak == 3)
                        {

                                points = new PointF[] { new PointF(x1, dely), new PointF(d, dely), new PointF(d, 0), new PointF(((-b * dely / step - c) / a) * step + delx, 0)};
                           
                        }
                        else
                        {
                            points = new PointF[] { new PointF(x1, dely), new PointF(delx, dely), new PointF(delx, 0),new PointF(((-b * dely / step - c) / a) * step + delx, 0) };
                        }
                    }
                    canavas.FillPolygon(br, points);
                }
                if (x1 < delx && y1 < dely)
                {
                    canavas.DrawLine(pen, (-b * dely / step - c) / a * step + delx, 0, delx, y1);
                    if (znak == 5)
                    {
                        points = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, dely), new PointF(d, 0) };
                    }
                    else
                    {
                        if (znak == 0 || znak == 1)
                        {
                           
                                points = new PointF[] { new PointF(delx, y1), new PointF(((-b * dely / step - c) / a) * step + delx, 0), new PointF(d, 0), new PointF(d, dely), new PointF(delx, dely) };
                            
                        }
                        else
                        {
                            points = new PointF[] {  new PointF(((-b * dely / step - c) / a) * step + delx, 0), new PointF(delx, 0),new PointF(delx, y1) };
                        }
                    }
                    canavas.FillPolygon(br, points);
                }
                
            }
            else
            {
                Pen pen = new Pen(Color.Green, 5);
                if (a == 0)
                {
                    y1 = (-a * x - c) / b;
                    y1 = dely - y1 * step;
                    if (y1 < dely)
                    {
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
                        canavas.FillPolygon(br, points);
                    }

                }
                else
                {

                    x1 = (-b * y - c) / a;
                    x1 = x1 * step + delx;
                    if (x1 > delx)
                    {
                        canavas.DrawLine(pen, x1, dely, x1, 0);
                        if (znak == 5)
                        {
                            points = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, 0), new PointF(d, dely)  };
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
                        canavas.FillPolygon(br, points);
                    }

                }
            }
        }
    }
    class Parabolic : Func
    {
         int n;
         PointF[] points;
        PointF[] nerav;
        public Parabolic(float a, float b, float c, int znak) : base(a, b, c, znak ) { }
        public override int dvig(int step)
        {
            throw new NotImplementedException();
        }
        public override bool check(int MX, int MY, Panel panel, int step)
        {
            bool checks=false;
            if (znak == 0 || znak == 1)
            {
                if (b * MY + a * MX * MX + c <= 0)
                    checks = true;
            }
            if (znak == 2 || znak == 3)
            {
                if (b * MY + a * MX * MX + c == 0)
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
            n = (d - delx) / step + 1; points = new PointF[n];
            for (int x = 0; x < n; x++)
                {
                    y = (-c - a * x * x) / b;
                points[x] = new PointF(x*step+delx, dely-y*step);
                }
            canavas.DrawCurve(new Pen(Color.Red, 3), points, 1f);
            if (znak == 5)
            {
                points = new PointF[] { new PointF(delx, dely), new PointF(delx, 0), new PointF(d, 0), new PointF(d, dely)};
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
                    nerav[n + 2] = new PointF(delx, dely);
                   
                    nerav[n] = new PointF(d, 0);
                    nerav[n + 1] = new PointF(d, dely);

                }
                else
                {
                    nerav = new PointF[n + 1];
                    for (int x = 0; x < n; x++)
                    {

                        nerav[x] = points[x];
                    }
                    nerav[n ] = new PointF(delx, 0);

                }
            }
            canavas.FillPolygon(br, nerav);

           
        }
    }
    //class Ellipse: Func
    //{
    //    public Ellipse(int a, int b, int c, int step, int delx, int dely, int d, int sh) : base(a, b, c, step, delx, dely, d, sh) { }
    //    public override void draw(Graphics canavas)
    //    {

    //    }
    //}
    class Hyper : Func
    {
        int n;
        PointF[] points;
        PointF[] nerav;
        public override int dvig(int step)
        {
            throw new NotImplementedException();
        }
        public override bool check(int MX, int MY, Panel panel, int step)
        {
            bool checks = false;
            // if (znak == 0 || znak == 1)
            // {

            // }
            //if(znak==2|| znak==3)
            // {

            // }
            if (checks == true)
                return true;
            else
                return false;
        }
        public Hyper(float a, float b, float c, int znak) : base(a, b, c, znak) {  }
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
            canavas.FillPolygon(br, nerav);
        }
    }

}
