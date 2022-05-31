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
    public partial class AqilliBatareya : Form
    {
        public AqilliBatareya()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
