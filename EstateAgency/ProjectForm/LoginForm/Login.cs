using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using EstateAgency.Util;

namespace EstateAgency
{
    public partial class Login : Form
    {
        private DataTable loginData;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.loginDataTableAdapter.Fill(this.estateAgencyDataSet.LoginData);
            loginData = estateAgencyDataSet.LoginData;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String password = passwordTextBox.Text;

            if (validateLoginData(login, password))
            {
                infoLabel.Text = "";
                User user = User.getInstance();
                foreach (DataRow row in loginData.Rows)
                {
                    if (row["login"].ToString() == login)
                    {
                        String name = row["name"].ToString();
                        String surname = row["surname"].ToString();
                        String midname = row["midname"].ToString();
                        String role = row["roleName"].ToString();
                        int accessLevel = Int32.Parse(row["accessLevel"].ToString());
                        user.fillFields(login, name, surname, midname, role, accessLevel);
                    }
                }
                new UserForm.UserInfo().Show();
            }

            else
            {
                infoLabel.Text = "Incorrect login/password";
            }
        }

        private bool validateLoginData(String login, String password)
        {
            bool result = false;
            Hasher hasher = new Hasher();
            String hashedPassword = hasher.hash(password);

            foreach (DataRow row in loginData.Rows)
            {
                if (row["login"].ToString() == login && row["hash"].ToString() == hashedPassword)
                {
                    result = true;
                }
            }

            return result;
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            LoginForms.SignIn form = new LoginForms.SignIn();
            form.ShowDialog(this);
        }

        private void testUserButton_Click(object sender, EventArgs e)
        {
            String login = "test";
            String name = "test";
            String surname = "test";
            String midname = "test";
            String role = "test";
            int accessLevel = Int32.Parse(accessLevelTextBox.Text);
            User user = User.getInstance();
            user.fillFields(login, name, surname, midname, role, accessLevel);
            new UserForm.UserInfo().Show();
        }
    }
}
