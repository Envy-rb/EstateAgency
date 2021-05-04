
namespace EstateAgency.LoginForms
{
    partial class SignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label midnameLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordHashLabel;
            System.Windows.Forms.Label _roleIdLabel;
            this.signInButton = new System.Windows.Forms.Button();
            this.estateAgencyDataSet = new EstateAgency.EstateAgencyDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new EstateAgency.EstateAgencyDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.midnameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordHashTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.RoleTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            midnameLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordHashLabel = new System.Windows.Forms.Label();
            _roleIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estateAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(54, 197);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(245, 23);
            this.signInButton.TabIndex = 25;
            this.signInButton.Text = "Sign-In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // estateAgencyDataSet
            // 
            this.estateAgencyDataSet.DataSetName = "EstateAgencyDataSet";
            this.estateAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.estateAgencyDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.EstateTableAdapter = null;
            this.tableAdapterManager.EstateTypeTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = this.roleTableAdapter;
            this.tableAdapterManager.ServiceTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EstateAgency.EstateAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(51, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(35, 13);
            nameLabel.TabIndex = 28;
            nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(140, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 20);
            this.nameTextBox.TabIndex = 29;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(51, 66);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(49, 13);
            surnameLabel.TabIndex = 30;
            surnameLabel.Text = "Surname";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(140, 63);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(159, 20);
            this.surnameTextBox.TabIndex = 31;
            // 
            // midnameLabel
            // 
            midnameLabel.AutoSize = true;
            midnameLabel.Location = new System.Drawing.Point(51, 92);
            midnameLabel.Name = "midnameLabel";
            midnameLabel.Size = new System.Drawing.Size(50, 13);
            midnameLabel.TabIndex = 32;
            midnameLabel.Text = "Midname";
            // 
            // midnameTextBox
            // 
            this.midnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "midname", true));
            this.midnameTextBox.Location = new System.Drawing.Point(140, 89);
            this.midnameTextBox.Name = "midnameTextBox";
            this.midnameTextBox.Size = new System.Drawing.Size(159, 20);
            this.midnameTextBox.TabIndex = 33;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(51, 118);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(33, 13);
            loginLabel.TabIndex = 34;
            loginLabel.Text = "Login";
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(140, 115);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(159, 20);
            this.loginTextBox.TabIndex = 35;
            // 
            // passwordHashLabel
            // 
            passwordHashLabel.AutoSize = true;
            passwordHashLabel.Location = new System.Drawing.Point(51, 144);
            passwordHashLabel.Name = "passwordHashLabel";
            passwordHashLabel.Size = new System.Drawing.Size(53, 13);
            passwordHashLabel.TabIndex = 36;
            passwordHashLabel.Text = "Password";
            // 
            // passwordHashTextBox
            // 
            this.passwordHashTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "passwordHash", true));
            this.passwordHashTextBox.Location = new System.Drawing.Point(140, 141);
            this.passwordHashTextBox.Name = "passwordHashTextBox";
            this.passwordHashTextBox.PasswordChar = '$';
            this.passwordHashTextBox.Size = new System.Drawing.Size(159, 20);
            this.passwordHashTextBox.TabIndex = 37;
            // 
            // _roleIdLabel
            // 
            _roleIdLabel.AutoSize = true;
            _roleIdLabel.Location = new System.Drawing.Point(51, 170);
            _roleIdLabel.Name = "_roleIdLabel";
            _roleIdLabel.Size = new System.Drawing.Size(29, 13);
            _roleIdLabel.TabIndex = 38;
            _roleIdLabel.Text = "Role";
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "_roleId", true));
            this.roleComboBox.DataSource = this.roleBindingSource;
            this.roleComboBox.DisplayMember = "name";
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(140, 170);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(159, 21);
            this.roleComboBox.TabIndex = 40;
            this.roleComboBox.ValueMember = "roleId";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.estateAgencyDataSet;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 287);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(midnameLabel);
            this.Controls.Add(this.midnameTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passwordHashLabel);
            this.Controls.Add(this.passwordHashTextBox);
            this.Controls.Add(_roleIdLabel);
            this.Controls.Add(this.signInButton);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estateAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signInButton;
        private EstateAgencyDataSet estateAgencyDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EstateAgencyDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private EstateAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox midnameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordHashTextBox;
        private EstateAgencyDataSetTableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.BindingSource roleBindingSource;
    }
}