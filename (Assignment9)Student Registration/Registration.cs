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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

       private void btn_register_Click(object sender, EventArgs e)
        {
           Model md= new Model();
            {
                md.ID = txt_id.Text;
                md.FirstName = txt_firstname.Text;
                md.LastName = txt_lastname.Text;
                md.Address = txt_adress.Text;
                md.SchoolYear = txt_schoolyear.Text;
                md.Gender = rbt_female.Text;
                md.Gender = rbt_male.Text;
                if (string.IsNullOrEmpty(txt_firstname.Text)){
                    MessageBox.Show("Add FirstNAme");
                    errorProvider1.SetError(txt_firstname, "add Firstname");
                }
                if (string.IsNullOrEmpty(txt_id.Text))
                {
                    MessageBox.Show("Add ID");
                    errorProvider1.SetError(txt_id, "add ID");
                }
                if (txt_id.Text.Length > 4)
                {
                    MessageBox.Show("ID cant be greater than 4 digits");
                    errorProvider1.SetError(txt_id, "ID cant be greater than 4 digits ");
                }
                string Gender = rbt_female.Checked ? "Female" : "Male";
             
            }
            md.save();
            MessageBox.Show("Registered");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Model.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
