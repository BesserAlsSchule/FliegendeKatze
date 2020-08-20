using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Location = new Point(0, pictureBox2.Width);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            
            Point startPoint = p.Location;
            
        START:
            for (int i = 0; i < 10; i++)
            {
                Point point = p.Location;
                Point p1 = new Point();
                p1.X = point.X + 100;
                p1.Y = point.Y - 50;

                p.Location = p1;
                Refresh();
               
                Refresh();

                p1 = new Point();
                p1.X = point.X + 200;
                p1.Y = point.Y;
                p.Location = p1;

                //this.Refresh();
                
                this.Refresh();

                if (p1.X >= Width)
                {
                    startPoint.Y = startPoint.Y + 50;
                    p.Location = startPoint;
                    goto START;
                }
            }
        }

        
    }
}
