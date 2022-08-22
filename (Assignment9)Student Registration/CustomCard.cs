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
    public partial class CustomCard : UserControl
    {
        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; label1.Text = value; }
        }
        private string _firstname;

        public string FIRSTNAME
        {
            get { return _firstname; }
            set { _firstname= value; label2.Text = value; }
        }
        private string _lastname;

        public string LASTNAME
        {
            get { return _lastname; }
            set { _lastname = value; label3.Text = value; }
        }
        private string _address;

        public string ADDRESS
        {
            get { return _address; }
            set { _address = value; label4.Text = value; }
        }
        private string _schoolyear;

        public string SCHOOLYEAR
        {
            get { return _schoolyear; }
            set { _schoolyear = value; label5.Text = value; }
        }
        private string _gender;

        public string GENDER
        {
            get { return _gender; }
            set { _gender = value; label6.Text = value; }
        }


        public CustomCard()
        {
            InitializeComponent();
        }

        private void CustomCard_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             dataGridView1.DataSource = null;
             dataGridView1.DataSource = Model.GetAll();
         }*/
    }
}
