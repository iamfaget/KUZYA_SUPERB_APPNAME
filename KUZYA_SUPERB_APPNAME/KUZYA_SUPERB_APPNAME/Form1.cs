using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
        
namespace KUZYA_SUPERB_APPNAME
{   public partial class Form1 : Form
    {   public Form1()
        {   InitializeComponent();
        }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        this.Text = "CLOSING NOW";
    }
    
    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        this.Text = "X= " + Convert.ToString(e.X) + " Y= " + Convert.ToString(e.Y);
    }

    private void Form1_MouseClick_1(object sender, MouseEventArgs e)
    {
        this.Close();
    }

    }
}
