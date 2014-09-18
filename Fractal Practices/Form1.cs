using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fractal_Practices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Clears all textboxes and pictureboxes and focuses on txtDrawLine 
        public void Clear()
        {
            txtDrawLine.Clear();
            txtDrawEllipse.Clear();
            txtDrawLineTree.Clear();
            PBFractal.Image = null; 
            txtDrawLine.Focus(); 
        } 
        public void GenerateDrawLine(int n, int color, Graphics g, Point p1, Point p2)
        {
            //If the number of recursions is less than or equal to zero
            if (n <= 0)
                return;
            else
            {
                //mypen is declared 
                //The shade of blue changes every recursion 
                Pen myPen = new Pen(Color.FromArgb(color,0,255-color));

                //Draws line according to coordinates
                g.DrawLine(myPen, p1.X, p1.Y, p2.X, p2.Y);

                //The y value of the first point shifts by down by 5 at every recursion
                p1.X = p1.X - 5;
                //The x value of the second point shifts to the right by 5 at every recursion 
                p2.Y = p2.Y + 5;

                //Recursion 
                GenerateDrawLine(n - 1, color + 1, g , p1, p2);
            }
        }

        public void GenerateDrawLineTree(int l, double distance, Graphics i, PointF p5, PointF p6)
        {
            if (l <= 0)
                return;
            else
            {
                //New points are declared
                PointF p7, p8, p9, p10, p11, p12,p13,p14,p15;

                //New points are stated as new points 
                p7 = new PointF();
                p8 = new PointF();
                p9 = new PointF();
                p10 = new PointF();
                p11 = new PointF();
                p12 = new PointF();
                p13 = new PointF();
                p14 = new PointF();
                p15 = new PointF();

                //myPenTree is declared 
                //The color of myPenTree and the thickness of the line is stated 
                Pen myPenTree = new Pen(Color.Green, 2);

                //Pairs of points are connected 
                i.DrawLine(myPenTree, p5, p6);
                i.DrawLine(myPenTree, p7, p8);
                i.DrawLine(myPenTree, p12, p13);
                i.DrawLine(myPenTree, p14, p15); 

                //Loop for the right side of the main flower
                p7 = p6; 

                //The horizontal distance of the brach is p7.X plus the one fourth of the stem distance 
                p8.X = (float)(p7.X + distance * (0.25));
                //The vertical distance of the brach is p7.Y minus the one half of the stem distance 
                p8.Y = (float)(p7.Y - distance * (0.5));

                //Loop for the left side of the main flower 
                p9 = p6;

                //The horizontal distance of the brach is p8.X minus the one fourth of the stem distance 
                p10.X = (float)(p9.X - distance * (0.25));
                //The vertical distance of the brach is p8.Y minus the one half of the stem distance 
                p10.Y = (float)(p9.Y - distance * (0.5));

                p11.X = p5.X; 
                p11.Y = (float)(distance / 2 + p6.Y);

                //Makes the right bloom 
                p12 = p11;

                //The horizontal distance of the brach is p12.X plus the one fourth of the stem distance 
                p13.X = (float)(p12.X + distance * (0.25));
                //The vertical distance of the brach is p12.Y minus the one half of the stem distance 
                p13.Y = (float)(p12.Y - distance * (0.5));

                //Makes the left bloom 
                p14 = p5;

                //The horizontal distance of the brach is p15.X plus the one fourth of the stem distance 
                p15.X = (float)(p14.X - distance * (0.25));
                //The vertical distance of the brach is p15.Y minus the one half of the stem distance 
                p15.Y = (float)(p14.Y - distance * (0.5));

                //Makes the right side of the main flower
                GenerateDrawLineTree(l - 1, distance * (0.5), i, p7, p8);
                //Makes the left side of the main flower
                GenerateDrawLineTree(l - 1, distance * (0.5), i, p9, p10);
                //Makes the right bloom
                GenerateDrawLineTree(l - 1, distance * (0.25), i, p12, p13);
                //Makes the left bloom
                GenerateDrawLineTree(l - 1, distance * (0.25), i, p14, p15); 
            }
        }

        public void GenerateDrawEllipse(int m, int iheight, int iwidth, Graphics h, Point p3, Point p4)
        {
            //If the number of recursions is less than or equal to zero
            if (m <= 0)
                return;
            else
            {
                //mypenEllipse is declared 
                //The color of myPenEllipse and the thickness of the line is stated
                Pen myPenEllipse = new Pen(Color.Chocolate, 1);

                // The circle at p3 is drawn
                h.DrawEllipse(myPenEllipse, p3.X, p3.Y, iwidth, iheight);
                // The circle at p4 is drawn
                h.DrawEllipse(myPenEllipse, p4.X, p4.Y, iwidth, iheight);

                //The y value of point p3 is increased by one fourth of the initial height 
                p3.Y = p3.Y + iheight / 4;

                // The x value of point p4 is shifted by the half the initial width
                // States that the circle starts at halfway of the bigger circle 
                p4.X = p4.X + iwidth / 2;
                //The y value of point p4 is increased by one fourth of the initial height
                p4.Y = p4.Y + iheight / 4;

                // The height is divided by 2 each time 
                iheight = iheight / 2;
                // The width is divided by 2 each time
                iwidth = iwidth / 2;

                //Method is called 
                GenerateDrawEllipse(m - 1, iheight, iwidth, h, p3, p4);
                //Method is called but the order or circles is focused at the opposite side
                GenerateDrawEllipse(m - 1, iheight, iwidth, h, p4, p3);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                //If any of the textboxes are empty
                if ((txtDrawLine.Text == "") || (txtDrawEllipse.Text == "") || (txtDrawLineTree.Text == ""))
                {
                    //Messagebox is displayed
                    MessageBox.Show("Please specify values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                    return;
                }
                //If inputs are values
                else
                {
                    //New variables are declared
                    int n, m, l, iheight, iwidth;

                    //New Points are declared
                    Point p1, p2, p3, p4;
                    PointF p5, p6, p16, p17, p18, p19, p20, p21;

                    //The variable distance for the drawlinetree method is declared
                    float distance, distance2, distance3, distance4;

                    //New points are stated as new points 
                    p1 = new Point();
                    p2 = new Point();
                    p3 = new Point();
                    p4 = new Point();

                    p5 = new PointF();
                    p6 = new PointF();
                    p16 = new PointF();
                    p17 = new PointF();
                    p18 = new PointF();
                    p19 = new PointF();
                    p20 = new PointF();
                    p21 = new PointF(); 

                    //The input of txtDrawLine is converted from a string to an int 
                    n = Convert.ToInt32(txtDrawLine.Text);
                    //The input of txtDrawEllipse is converted from a string to an int 
                    m = Convert.ToInt32(txtDrawEllipse.Text);
                    //The input of txtDrawLineTree is converted from a string to an int 
                    l = Convert.ToInt32(txtDrawLineTree.Text);

                    //The height of the ellipse is initially set as 200
                    iheight = 200;
                    //The width of the ellipse is initially set as 200
                    iwidth = 200;

                    //DrawLine
                    p1.X = 610;
                    p1.Y = 0;

                    //DrawLine
                    p2.X = 0;
                    p2.Y = 1;

                    //DrawEllipse
                    p3.X = 40;
                    p3.Y = 40;

                    //DrawEllipse
                    p4.X = 40;
                    p4.Y = 40;

                    //DrawLineTree
                    p5.X = 110;
                    p5.Y = 610;

                    //DrawLineTree
                    p6.X = 110;
                    p6.Y = 500;
                    distance = p5.Y - p6.Y;

                    //DrawLineTree2
                    p16.X = 240;
                    p16.Y = 610;

                    //DrawLineTree2 
                    p17.X = 240;
                    p17.Y = 450;
                    distance2 = p16.Y - p17.Y;

                    //DrawLineTree3
                    p18.X = 370;
                    p18.Y = 610;

                    //DrawLineTree3
                    p19.X = 370;
                    p19.Y = 400;
                    distance3 = p18.Y - p19.Y;

                    p20.X = 500;
                    p20.Y = 610;

                    p21.X = 500;
                    p21.Y = 350;
                    distance4 = p20.Y - p21.Y;
                    
                    Graphics g = Graphics.FromHwnd(PBFractal.Handle);
                    Graphics h = Graphics.FromHwnd(PBFractal.Handle);
                    Graphics i = Graphics.FromHwnd(PBFractal.Handle);

                    //The background color is set
                    g.Clear(Color.Black);

                    //DrawLine method is called
                    GenerateDrawLine(n - 1, 1, g, p1, p2);
                    //DrawEllipse method is called 
                    GenerateDrawEllipse(m, iheight, iwidth, h, p3, p4);
                    //DrawLineTree method is called 
                    GenerateDrawLineTree(l, distance, i, p5, p6);
                    //DrawLineTree method is called but with different starting positions 
                    GenerateDrawLineTree(l, distance2, i, p16, p17);
                    //DrawLineTree method is called 
                    GenerateDrawLineTree(l, distance3, i, p18, p19);
                    //DrawLineTree method is called 
                    GenerateDrawLineTree(l, distance4, i, p20, p21);
                }
            }
                //If the input is not suitable 
            catch
            {
                //Messagebox is displayed 
                MessageBox.Show("An error has occured. Please revise inputs.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Clear(); 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit(); 
        }
    }
}
