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
    public partial class TableLayout : Form
    {
        public TableLayout()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayout_Load(object sender, EventArgs e)

        {
tableLayoutPanel1.Controls.Clear();
            foreach (var item in Model.GetAll())
            {
                CustomCard customcard = new CustomCard();
                customcard.ID = item.ID;
                customcard.FIRSTNAME = item.FirstName;
                customcard.LASTNAME = item.LastName;
                customcard.ADDRESS = item.Address;
                customcard.SCHOOLYEAR = item.SchoolYear;
                customcard.GENDER = item.Gender;

                customcard.Click += (s, t) =>
                {
                    Registration f = new Registration();
                    f.Show();
                };
                tableLayoutPanel1.Controls.Add(customcard);
            }
        }
    }
}