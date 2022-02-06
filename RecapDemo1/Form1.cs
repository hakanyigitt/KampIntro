using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            Button[,] butons = new Button[9,9];
            int top=0;
            int left=0;
            for (int i = 0; i < butons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < butons.GetUpperBound(1); j++)
                {
                    butons[i, j] = new Button();
                    butons[i, j].Width = 50;
                    butons[i, j].Height = 50;
                    butons[i, j].Left = left;
                    left += 50;
                    butons[i, j].Top = top;
                    this.Controls.Add(butons[i, j]);
                    if(j%2 == 1 && i%2 == 0)
                    {
                        butons[i, j].BackColor = Color.Black;
                    }
                    else if(i%2 == 1 && j%2 == 0)
                    {
                        butons[i, j].BackColor = Color.Black;
                    }
                }
                top += 50;
                left = 0;
            }
        }
    }
}
