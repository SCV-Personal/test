using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework5
{
    public partial class Form1 : Form
    {

        // Customer class to object
        Customer model = new Customer();
        public Form1()
        {
            InitializeComponent();
        }
        #region UI Elements
        private void btnInsert_Click(object sender, EventArgs e)
        {
            model.FirstName = textBoxFirstName.Text.Trim();
            model.LastName = textBoxLastName.Text.Trim();
            model.Interview = textBoxInterview.Text.Trim();
            using (DB4Entities db = new DB4Entities())
            {
                db.Customers.Add(model);
                db.SaveChanges();
            }

            MessageBox.Show("Inserted Successfully");
        }
        #endregion
    }
}
