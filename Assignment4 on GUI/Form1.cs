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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_buttonclick1_Click(object sender, EventArgs e)
        {
            Model md= new Model();
            {
                md.number = txt_number.Text;
                md.date=txt_number.Text;
                md.inventorynumber = txt_inventorynumber.Text;
                md.objectname = txt_objectname.Text;
                md.price=txt_price.Text;
                md.count=txt_count.Text;
                
            }
            md.save();
            MessageBox.Show("Item Added");

            /* string number=txt_number.Text;
             string date= txt_date.Text;
             string inventory_number=txt_inventorynumber.Text;
             string object_name=txt_objectname.Text;
             string count=txt_count.Text;
             string price=txt_price.Text;
             MessageBox.Show("Item Added");*/
        }

        private void txt_buttonclick2_Click(object sender, EventArgs e)
        {
this.Close();
        }
    }
}
