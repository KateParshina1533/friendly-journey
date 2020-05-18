using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проект_начало
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            input = "";
            vivod = "";
            risovat = false;
            STEP = 20;
            dely = splitContainer1.Panel1.Height / 25 * STEP;
            delx = splitContainer1.Panel1.Width / 160 * STEP;
        }
        int dely;
        int znak;
        int delx;
        int STEP;
        float a, b, c, x, y;
        int SetX0;
        int SetX1;
        int SetY0;
        int SetY1;
        string input;
        string vivod;
        List<Func> list;
        bool risovat;
        private void start()
        {
            button11.Visible = true;
            button10.Visible = true;
            button2.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button3.Visible = true;
            button7.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button6.Enabled =true;
            button11.Enabled = true;
            button10.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button23.Enabled = true;
            button22.Enabled = true;
            button17.Enabled = true;
            button15.Enabled = true;
            button14.Enabled = true;
            button16.Enabled = true;
            button13.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button21.Enabled = true;
            button20.Enabled = true;
            button12.Enabled = true;
            button26.Enabled = true;
            button25.Enabled = true;
            button27.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button24.Enabled = true;

        }
        private void numbers()//начальное положение для кнопок с цифрами
        {
            button7.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button11.Enabled = true;
            button10.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button23.Enabled = true;
            button22.Enabled = true;
            button17.Enabled = true;
            button15.Enabled = true;
            button14.Enabled = true;
            button16.Enabled = true;
            button13.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button21.Enabled = true;
            button20.Enabled = true;
            button12.Enabled = true;
            button26.Enabled = false;
            button25.Enabled = false;
            button27.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button24.Enabled = false;

        }
        private void znaki()//начальное положение для кнопок со знаками
        {
            button11.Enabled = false;
            button10.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button23.Enabled = false;
            button22.Enabled = false;
            button7.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button17.Enabled = true;
            button15.Enabled = true;
            button14.Enabled = true;
            button16.Enabled = true;
            button13.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button21.Enabled = true;
            button20.Enabled = true;
            button12.Enabled = true;
            button11.Visible = false;
            button10.Visible = false;
            button2.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button3.Visible = false;
            button26.Enabled = true;
            button25.Enabled = true;
            button27.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button24.Enabled = true;
        }
        private void plus_minus()//начальное положение для кнопок со знаками
        {
           
            button11.Enabled = false;
            button10.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button23.Enabled = false;
            button22.Enabled = false;
            button7.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button17.Enabled = true;
            button15.Enabled = true;
            button14.Enabled = true;
            button16.Enabled = true;
            button13.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button21.Enabled = true;
            button20.Enabled = true;
            button12.Enabled = true;
            button26.Enabled = true;
            button25.Enabled = true;
            button27.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button24.Enabled = true;

        }
        private void umnosh()
        {
            button11.Enabled = false;
            button10.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button23.Enabled = false;
            button22.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button26.Enabled = false;
            button25.Enabled = false;
            button27.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button24.Enabled = false;
            button17.Enabled = true;
            button15.Enabled = true;
            button14.Enabled = true;
            button16.Enabled = true;
            button13.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button21.Enabled = true;
            button20.Enabled = true;
            button12.Enabled = true;
        }
        private void neumnosh()
        {
            button11.Enabled = true;
            button10.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button23.Enabled = true;
            button22.Enabled = true;
            button5.Enabled = false;
            button4.Enabled = false;
            button6.Enabled =false;
            button7.Enabled = false;
            button17.Enabled = false;
            button15.Enabled = false;
            button14.Enabled = false;
            button16.Enabled = false;
            button13.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button21.Enabled = false;
            button20.Enabled = false;
            button12.Enabled =false;
            button26.Enabled = false;
            button25.Enabled = false;
            button27.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button24.Enabled = false;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "1";
            input = input + "1";
            numbers();
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "2";
            input = input + "2";
            numbers();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "3";
            input = input + "3";
            numbers();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "4";
            input = input + "4";
            numbers();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "5";
            input = input + "5";
            numbers();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "6";
            input = input + "6";
            numbers();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "7";
            input = input + "7";
            numbers();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "8";
            input = input + "8";
            numbers();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "9";
            input = input + "9";
            numbers();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "y";
            input = input + "y*1";
            button7.Visible = false;
            button5.Visible=false;
            b = 1;
            neumnosh();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "x";
            input = input + "x*1";
            a = 1;
            button4.Visible = false;
            button6.Visible = false;
            neumnosh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "y*";
            input = input + "y*";
            b = 1;
            button7.Visible = false;
            button5.Visible = false;
            umnosh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "x*";
            input = input + "x*";
            button4.Visible = false;
            button6.Visible = false;
            a = 1;
            umnosh();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "+";
            input = input + "+";
            plus_minus();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "-";
            input = input + "-";
            plus_minus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + ">";
            input = input + "=";
            znak = 2;
            znaki();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "<";
            input = input + "=";
            znak = 0;
            znaki();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + ">=";
            input = input + "=";
            znak = 3;
            znaki();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "=";
            input = input + "=";
            
            znaki();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "!=";
            input = input + "=";
            znak = 5;
            znaki();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "<=";
            input = input + "=";
            znak = 1;
            znaki();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (input[input.Length - 1] == '*' || input[input.Length - 1] == '+' || input[input.Length - 1] == '-' || input[input.Length - 1] == '=' || input[input.Length - 1] == '>' || input[input.Length - 1] == '<')

            {

            }
            else
            {
                OBRABOTKA_STROKI();
                risovat = true;
                if (comboBox4.SelectedIndex == 0)
                {
                    list.Add(new Parabolic(a, b, c, znak));
                    a = b = c = 0;
                }
                if (comboBox4.SelectedIndex == 1)
                {
                    list.Add(new Hyper(a, b, c, znak));

                    label6.Text += c;
                         a = b = c = 0;
                }

                if (comboBox4.SelectedIndex == 2)
                {
                    
                      
                     list.Add (new Line(a, b, c, znak));
                    a = b = c = 0;
                }
                splitContainer1.Panel1.Invalidate();
                start();
                label4.Text = c + " " + b + " " + a;
                // risovat = true;
                //splitContainer1.Panel1.Invalidate();
                button26.Visible = true;
                button25.Visible = true;
                button27.Visible = true;
                button24.Visible = true;
                button32.Visible = true;
                button33.Visible = true;
                button4.Visible = true;
                button6.Visible = true;
                button5.Visible = true;
                button7.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;

                input = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "0";
            input = input + "0";
            numbers();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = new List<Func>();
            DoubleBuffered = true;
            Refresh();
            a = b = c = 0;
            input = "";
            splitContainer1.Panel1.Invalidate();
            label4.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);//Фон
            Pen pen = new Pen(Color.Gray, 2);
            int dely = splitContainer1.Panel1.Height / 25 * STEP;
            int delx = splitContainer1.Panel1.Width / 160 * STEP;
            if (risovat)
                if (list.Any())
                {
                    foreach (Func f in list)
                    {

                        f.draw(e.Graphics, splitContainer1.Panel1, STEP);
                    }

                }
            PointF [] points = new PointF[] { new PointF(delx, 0),new PointF(delx, dely), new PointF(splitContainer1.Panel1.Width, dely), new PointF(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height),  new PointF(0, splitContainer1.Panel1.Height), new PointF(0, 0) };
            e.Graphics.FillPolygon(new SolidBrush(Color.White), points);
            //Горизонтальные линии
            for (int i = 1; i < splitContainer1.Panel1.Width /STEP; i++)
            {
                if (i == splitContainer1.Panel1.Width / 160)
                {
                    pen = new Pen(Color.Black, 3);
                }
                e.Graphics.DrawLine(pen, i *STEP, 0, i *STEP,  splitContainer1.Panel1.Height );
                pen = new Pen(Color.Gray, 2);
            }
            //Вертикальные линии
            for (int i = 1; i < splitContainer1.Panel1.Height / STEP; i++)
            {
                if (i == splitContainer1.Panel1.Height / 25)
                {
                    pen = new Pen(Color.Black, 3);
                }
                e.Graphics.DrawLine(pen, 0, i * STEP,  splitContainer1.Panel1.Width , i *STEP);
                pen = new Pen(Color.Gray, 2);
            }
           

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "y";
            input = input + "y*1";
            button26.Visible = false;
            button25.Visible = false;
            b = 1;
            neumnosh();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "y*";
            input = input + "y*";
            b = 1;
            button25.Visible = false;
            button26.Visible = false;
            umnosh();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "x*x*1";
            input = input + "x*x*1";
            button27.Visible = false;
            button24.Visible = false;
            b = 1;
            neumnosh();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "x*x*";
            input = input + "x*x*";
            b = 1;
            button27.Visible = false;
            button24.Visible = false;
            umnosh();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "xy";
            input = input + "x*y*1";
            button33.Visible = false;
            button32.Visible = false;
            b = 1;
            neumnosh();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "xy*";
            input = input + "x*y*";
            b = 1;
            button33.Visible = false;
            button32.Visible = false;
            umnosh();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            list.Clear();
            risovat = false;
            input = "";
            splitContainer1.Panel1.Invalidate();
                
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            button26.Visible = true;
            button25.Visible = true;
            button27.Visible = true;
            button24.Visible = true;
            button32.Visible = true;
            button33.Visible = true;
            button4.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
            button7.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            input = "";
            if (comboBox4.SelectedIndex == 0)
            { start(); 
                panel5.Visible = true; 
                panel4.Visible = false; panel2.Visible = false; panel3.Visible = false; }
            //list.Add(new Parabolic(a, b, c, STEP, delx, dely, splitContainer1.Panel1.Width, splitContainer1.Panel1.Height));
            if (comboBox4.SelectedIndex == 1)
            { start(); panel2.Visible = true; panel4.Visible = false; panel5.Visible = false; panel3.Visible = false; }// list.Add(new Hyper(a, b, c, STEP, delx, dely, splitContainer1.Panel1.Width, splitContainer1.Panel1.Height));

            if (comboBox4.SelectedIndex == 2)
            {
                start();
                panel3.Visible = true;
                panel4.Visible = false; panel2.Visible = false; panel5.Visible = false;
                //  OBRABOTKA_STROKI();
                // list.Add (new Line(a, b, c, STEP, delx, dely, splitContainer1.Panel1.Width, splitContainer1.Panel1.Height));
            }
        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            SetX0 = e.X;
            SetY0 = e.Y;
            foreach (Func figure in list)
            {
                if (figure.check(e.X, e.Y, splitContainer1.Panel1, STEP))
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        figure.isDrag = true;
                    }
                }
            }
        }

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //foreach (Func figure in list)
            //{
            //    if (figure.isDrag)
            //    {
            //        figure.delX = e.X -delx/*- SetX0*/;
            //        figure.delY = e.Y +dely/*- SetY0*/;
            //    }
            //}
       }

        private void splitContainer1_Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            int dely = splitContainer1.Panel1.Height / 25 * STEP;
            int delx = splitContainer1.Panel1.Width / 160 * STEP;
            for (int i=0; i<list.Count;i++)
            {

                //if (comboBox4.SelectedIndex == 0)
                //{
                //    list.Add(new Parabolic(a, b, c, znak));
                //    a = b = c = 0;
                //}
                //if (comboBox4.SelectedIndex == 1)
                //{
                //    list.Add(new Hyper(a, b, c, znak));

                //    label6.Text += c;
                //    a = b = c = 0;
                //}
                
                    
                
                if (comboBox4.SelectedIndex == 2&& list[i].isDrag)
                {
                    list[i].delX = e.X - SetX0;
                    list[i].delY = SetY0 - e.Y;
                    int c1 = list[i].dvig(STEP);
                    list[i].c = c1;
                    a = b = c = 0;
                }
                list[i].isDrag = false;
               
            }
            splitContainer1.Panel1.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
            splitContainer1.Panel1.Invalidate();
        }

        private void OBRABOTKA_STROKI()
        {
            input = input + "+0";
            string C1, A1, B1;
            int k;
            for (int i = 0; i < input.Length; i++)//найдем с
            {

                if (input[i] == '0'|| input[i] == '1' || input[i] =='2' || input[i] == '3' || input[i] == '4' || input[i] == '5' || input[i] == '6' || input[i] == '7'|| input[i] == '8' || input[i] == '9')
                {
                    k = 1;
                    if (i == 0 || (i > 0 && input[i - 1] != '*'))
                    {
                        
                            while (i < input.Length - 1&&(input[i + 1] == '0' || input[i + 1] == '1' || input[i + 1] == '2' || input[i + 1] == '3' || input[i + 1] == '4' || input[i + 1] == '5' || input[i + 1] == '6' || input[i + 1] == '7' || input[i + 1] == '8' || input[i + 1] == '9'))
                        {
                            k++;
                            i++;
                        }
                        i = i - k+1 ;
                        C1 = input.Substring(i, k);
                       
                        
                            if (i < input.IndexOf('='))
                                c = c  + int.Parse(C1);
                            else
                                c = c  - int.Parse(C1);

                        i = i - 1 + k;
                    }
                }
                else
                {
                    if (input[i] == 'x'&& comboBox4.SelectedIndex!=1)
                    {
                        k = 1;
                        if(comboBox4.SelectedIndex==2)
                        i = i + 2;
                        if (comboBox4.SelectedIndex == 0)
                            i = i + 4;
                        if (i != input.Length - 2)
                            while (input[i + 1] == '0' || input[i + 1] == '1' || input[i + 1] == '2' || input[i + 1] == '3' || input[i + 1] == '4' || input[i + 1] == '5' || input[i + 1] == '6' || input[i + 1] == '7' || input[i + 1] == '8' || input[i + 1] == '9')
                        {
                            k++;
                            i++;
                        }
                        i = i - k+1 ;
                        A1 = input.Substring(i, k);
                        if (i < input.IndexOf('='))
                            a = int.Parse(A1);
                        else
                            a = -int.Parse(A1);
                        i = i - 1 + k;
                    }
                    
                    if(input[i] == 'y' && (comboBox4.SelectedIndex == 1))
                    {
                        if (i < input.IndexOf('='))
                            b = 1;
                        else
                            b = -1;
                        k = 1;
                        i = i + 2;
                        if (i != input.Length - 2)
                            while (input[i + 1] == '0' || input[i + 1] == '1' || input[i + 1] == '2' || input[i + 1] == '3' || input[i + 1] == '4' || input[i + 1] == '5' || input[i + 1] == '6' || input[i + 1] == '7' || input[i + 1] == '8' || input[i + 1] == '9')
                            {
                                k++;
                                i++;
                            }
                        i = i - k + 1;
                        A1 = input.Substring(i, k);
                        if (i < input.IndexOf('='))
                            a = int.Parse(A1);
                        else
                            a = -int.Parse(A1);
                        i = i - 1 + k;
                    }
                    if (input[i] == 'y'&& (comboBox4.SelectedIndex==2|| comboBox4.SelectedIndex==0))
                    {
                        k = 1;
                        i = i + 2;
                        if(i!=input.Length-2)
                        while ( input[i + 1] == '0' || input[i + 1] == '1' || input[i + 1] == '2' || input[i + 1] == '3' || input[i + 1] == '4' || input[i + 1] == '5' || input[i + 1] == '6' || input[i + 1] == '7' || input[i + 1] == '8' || input[i + 1] == '9')
                        {
                            k++;
                            i++;
                        }
                        i = i - k+1 ;
                        B1 = input.Substring(i, k);
                        if (i < input.IndexOf('='))
                            b = int.Parse(B1);
                        else
                            b = -int.Parse(B1);
                        i = i - 1 + k;
                    }
                }
            }
           
            for (int i=0;i<input.Length;i++)//находим значения a, b, с
            {
                
                if (input[i] == '-')
                {
                    if (input[i + 1] == 'x')
                        a = -a;
                    else
                    {
                        if (input[i + 1] == 'y')
                            b = -b;
                        else
                            c = -c;
                    }
                }
            }
        }
        public void paint(Graphics canavas)
        {
           
            Invalidate();

        }
    }
}
