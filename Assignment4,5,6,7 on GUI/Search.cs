using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_on_GUI
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = product.findOne(textBox1.Text);
            if (products == null) {

                MessageBox.Show("Enter Something");
            }
            else
            {
              label1.Text = products.objectname;
                label2.Text = products.price;
                label3.Text = products.count;
                label4.Text = products.Number;
                label5.Text = products.inventorynumber;
              label6.Text = products.date;


            }
        }
    }
}
