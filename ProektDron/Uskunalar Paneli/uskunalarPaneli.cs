using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProektDron.video;

namespace ProektDron.Uskunalar_Paneli
{
    public partial class uskunalarPaneli : UserControl
    {
        public uskunalarPaneli()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            Video f27 = new Video();
            f27.ShowDialog();
            /* Form2 a = new Form2();
             a.StartPosition = FormStartPosition.Manual;
             a.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - a.Width,
                                    Screen.PrimaryScreen.WorkingArea.Height - a.Height);*/

            f27.StartPosition = FormStartPosition.Manual;
            f27.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - f27.Width,
                                     Screen.PrimaryScreen.WorkingArea.Height - f27.Height);
        }
    }
}
