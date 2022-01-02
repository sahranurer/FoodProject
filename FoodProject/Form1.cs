using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            slidePanel.Height = button1.Height;
            slidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slidePanel.Height = button1.Height;
            slidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slidePanel.Height = button2.Height;
            slidePanel.Top = button2.Top;
            mySecondCustomControl1.BringToFront();
        }
    }
}
