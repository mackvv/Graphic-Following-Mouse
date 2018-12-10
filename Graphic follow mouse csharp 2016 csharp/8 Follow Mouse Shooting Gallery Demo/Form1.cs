using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8_Follow_Mouse_Shooting_Gallery_Demo
{
    public partial class Form1 : Form
    {
        Rectangle rect = new Rectangle(0, 0, 20, 20);
        int Click;


        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();
            

            if (Click == 1)
            {

                SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
                graphics.FillRectangle(solidBrush, Cursor.Position.X - 5, Cursor.Position.Y - 25, 20, 20);
                Click = 0;


            }
            else
            {
                graphics.FillRectangle(new SolidBrush(Color.Salmon), rect);
                rect.X = Cursor.Position.X - 5;
                rect.Y = Cursor.Position.Y - 25;

                graphics.FillRectangle(new SolidBrush(Color.RoyalBlue), rect);

            }

        
        
        }

        

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Click = 1; 
            
        }

       

     

       
    }
}
