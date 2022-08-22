using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


            Registration display = new Registration();
            display.MdiParent = this;
            display.Show();
        }

        private void flowLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


        TableLayout display = new TableLayout();
            display.MdiParent = this;
            display.Show();
        }

        private void tableLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


           TableLayout display = new TableLayout();
            display.MdiParent = this;
            display.Show();
        }
    }
}
