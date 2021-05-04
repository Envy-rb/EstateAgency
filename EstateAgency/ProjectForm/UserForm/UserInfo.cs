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
using EstateAgency.Command;
using EstateAgency.Command.impl.OpenFormCommand;


namespace EstateAgency.UserForm
{
    public partial class UserInfo : Form
    {
        User user = User.getInstance();
        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            User user = User.getInstance();

            loginLabel.Text += user.Login;
            nameLabel.Text += user.Name;
            surnameLabel.Text += user.Surname;
            midnameLabel.Text += user.Midname;
            roleLabel.Text += user.Role;
            accessLevel.Text += user.AccessLevel;
        }

        private void openFormButton_Click(object sender, EventArgs e)
        {
            ICommand command = new OpenClient(user);
            command.invoke();
        }

        private void accessLevelUpButton_Click(object sender, EventArgs e)
        {
            user.AccessLevel += 1;
            accessLevel.Text = user.AccessLevel.ToString();
        }

        private void accessLevelDownButton_Click(object sender, EventArgs e)
        {
            user.AccessLevel -= 1;
            accessLevel.Text = user.AccessLevel.ToString();
        }

        private void openEmployeeButton_Click(object sender, EventArgs e)
        {
            ICommand command = new OpenEmployee(user);
            command.invoke();
        }

        private void openEstateTypeButton_Click(object sender, EventArgs e)
        {
            ICommand command = new OpenEstateType(user);
            command.invoke();
        }

        private void openRoleButton_Click(object sender, EventArgs e)
        {
            ICommand command = new OpenRole(user);
            command.invoke();
        }

        private void openServiceTypeButton_Click(object sender, EventArgs e)
        {
            ICommand command = new OpenServiceType(user);
            command.invoke();
        }

        private void openEstateButton_Click(object sender, EventArgs e)
        {
            ICommand command = new OpenEstate(user);
            command.invoke();
        }

        private void openContractButton_Click(object sender, EventArgs e)
        {
            ICommand command = new OpenContract(user);
            command.invoke();
        }
    }
}
