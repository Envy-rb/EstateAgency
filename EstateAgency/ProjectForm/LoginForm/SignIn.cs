using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.Util;
using EstateAgency.UtilForm;

namespace EstateAgency.LoginForms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estateAgencyDataSet.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.estateAgencyDataSet.Role);
            // TODO: This line of code loads data into the 'estateAgencyDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.estateAgencyDataSet.Employee);
            this.employeeBindingSource.AddNew();
            roleComboBox.SelectedIndex = 2;
            //roleComboBox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = passwordHashTextBox.Text;
            Hasher hasher = new Hasher();
            string hashedPassword = hasher.hash(password);
            passwordHashTextBox.Text = hashedPassword;
            try
            {
                employeeBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(estateAgencyDataSet);
                Close();
            }
            catch (Exception)
            {
                passwordHashTextBox.Clear();
                Error form = new Error(ErrorType.LoginExists, loginTextBox.Text);
                form.Show();
            }
        }


        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estateAgencyDataSet);

        }
    }
}
