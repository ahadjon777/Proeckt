using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektDron.InTextSplit.Display
{
    public partial class TC200Status : Form
    {
        int a;
        public TC200Status()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a >= 0 && a < 20)
            {
                a++;
                count1.Text = a.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a > 0 && a < 21)
            {
                a--;
                count1.Text = a.ToString();
            }
        }
    }
}
