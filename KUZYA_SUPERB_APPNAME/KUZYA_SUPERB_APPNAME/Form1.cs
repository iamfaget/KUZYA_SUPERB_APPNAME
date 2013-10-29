using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
        
namespace KUZYA_SUPERB_APPNAME
{
// 1st
public partial class Form1 : Form
{
    Graphics    gr;
    Point   p1;
    Point   p2;

    List<Points> Pointslist = new List<Points>();
    private System.Drawing.Drawing2D.GraphicsPath mousePath = new System.Drawing.Drawing2D.GraphicsPath();

    public Form1()
    {   
        InitializeComponent();
        this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
        this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
        this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        Pen penselect = System.Drawing.Pens.Green;
        e.Graphics.DrawLine(penselect, p1, p2);
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        Point mouseDownLocation = new Point(e.X/*+this.Location.X*/, e.Y/*+this.Location.Y*/);
        //mousePath.Dispose();
        //mousePath = new System.Drawing.Drawing2D.GraphicsPath();
        //this.Invalidate();
        mousePath.AddLine(mouseDownLocation, mouseDownLocation);

        p1.X = e.X;
        p1.Y = e.Y;
    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
        p2.X = e.X;
        p2.Y = e.Y;

        Invalidate();

        //System.Drawing.Point mouseUpLocation = new System.Drawing.Point(e.X/*+this.Location.X*/, e.Y/*+this.Location.Y*/);
        //mousePath.AddLine(mouseUpLocation, mouseUpLocation);
    }

/*    private void Form1_MouseMove(object sender, MouseEventArgs e, PaintEventArgs f)
    {
        if (radioButton1.Checked)
        {
            this.Text = "Drawing a LINE: (" + Convert.ToString(e.X - panel1.Width) + ", " + Convert.ToString(e.Y) + ")";
            int mouseX = e.X;// + this.Location.X;
            int mouseY = e.Y;// + this.Location.Y;
            //this.Text = "X";
            mousePath.AddLine(mouseX, mouseY, mouseX, mouseY);
        }

        if (radioButton2.Checked)
        {
            this.Text = "Drawing a CROSS: (" + Convert.ToString(e.X - panel1.Width) + ", " + Convert.ToString(e.Y) + ")";
            int mouseX = e.X;// + this.Location.X;
            int mouseY = e.Y;// + this.Location.Y;
//            Cross(mouseX, mouseY, f);
        }

        if (radioButton3.Checked)
            this.Text = "Drawing a SUMFIN: ("+Convert.ToString(e.X-panel1.Width)+", "+Convert.ToString(e.Y)+")";
    }
*/

    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button1_MouseDown(object sender, MouseEventArgs e)
    {
        this.Text = "CLOSING NOW";
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        radioButton2.Checked = false;
        radioButton3.Checked = false;
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        radioButton1.Checked = false;
        radioButton3.Checked = false;
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        radioButton1.Checked = false;
        radioButton2.Checked = false;
    }

}
// 2nd
public class Point
{
    Point p1;
    Pen p = new Pen(Color.Black, 2);
    public Point(Point p1)
    {
        this.p1 = p1;
    }
    public void drawwith(Graphics e)
    {
        e.DrawLine(p, p1.X + 5, p1.Y + 5, p1.X - 5, p1.Y - 5);
    }

}

public class Cross
{
    Point p1;
    Pen p = new Pen(Color.Black, 2);
    public Cross(Point p1)
    {
        this.p1=p1;
    }
    public void drawwith(Graphics e)
    {
        e.DrawLine(p, p1.X + 5, p1.Y + 5, p1.X - 5, p1.Y - 5);
        //e.DrawLine(p, p2.X + 5, p2.Y + 5, p2.X - 5, p2.Y - 5);
    }
}

public class Line
{
    Point p1, p2;
    Pen p = new Pen(Color.Black, 2);
    public Line(Point p1, Point p2)
    {
        this.p1 = p1;
        this.p2 = p2;
    }
    public void drawwith(Graphics e)
    {
        Point p1 = new Point(100, 100);
        Point p2 = new Point(500, 100);

        e.DrawLine(p, p1, p2);
    }
}

}
