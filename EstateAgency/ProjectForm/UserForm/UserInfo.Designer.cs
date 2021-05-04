
namespace EstateAgency.UserForm
{
    partial class UserInfo
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.midnameLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.accessLevelLabel = new System.Windows.Forms.Label();
            this.openClientButton = new System.Windows.Forms.Button();
            this.accessLevelUpButton = new System.Windows.Forms.Button();
            this.accessLevelDownButton = new System.Windows.Forms.Button();
            this.accessLevel = new System.Windows.Forms.Label();
            this.openEmployeeButton = new System.Windows.Forms.Button();
            this.openEstateTypeButton = new System.Windows.Forms.Button();
            this.openRoleButton = new System.Windows.Forms.Button();
            this.openServiceTypeButton = new System.Windows.Forms.Button();
            this.openEstateButton = new System.Windows.Forms.Button();
            this.openContractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(39, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 58);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(55, 13);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "Surname: ";
            // 
            // midnameLabel
            // 
            this.midnameLabel.AutoSize = true;
            this.midnameLabel.Location = new System.Drawing.Point(12, 82);
            this.midnameLabel.Name = "midnameLabel";
            this.midnameLabel.Size = new System.Drawing.Size(56, 13);
            this.midnameLabel.TabIndex = 0;
            this.midnameLabel.Text = "Midname: ";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(11, 109);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(35, 13);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "Role: ";
            // 
            // accessLevelLabel
            // 
            this.accessLevelLabel.AutoSize = true;
            this.accessLevelLabel.Location = new System.Drawing.Point(11, 138);
            this.accessLevelLabel.Name = "accessLevelLabel";
            this.accessLevelLabel.Size = new System.Drawing.Size(73, 13);
            this.accessLevelLabel.TabIndex = 0;
            this.accessLevelLabel.Text = "accessLevel: ";
            // 
            // openClientButton
            // 
            this.openClientButton.Location = new System.Drawing.Point(192, 12);
            this.openClientButton.Name = "openClientButton";
            this.openClientButton.Size = new System.Drawing.Size(170, 29);
            this.openClientButton.TabIndex = 1;
            this.openClientButton.Text = "Клиенты";
            this.openClientButton.UseVisualStyleBackColor = true;
            this.openClientButton.Click += new System.EventHandler(this.openFormButton_Click);
            // 
            // accessLevelUpButton
            // 
            this.accessLevelUpButton.Location = new System.Drawing.Point(152, 131);
            this.accessLevelUpButton.Name = "accessLevelUpButton";
            this.accessLevelUpButton.Size = new System.Drawing.Size(20, 20);
            this.accessLevelUpButton.TabIndex = 2;
            this.accessLevelUpButton.Text = "+";
            this.accessLevelUpButton.UseVisualStyleBackColor = true;
            this.accessLevelUpButton.Click += new System.EventHandler(this.accessLevelUpButton_Click);
            // 
            // accessLevelDownButton
            // 
            this.accessLevelDownButton.Location = new System.Drawing.Point(126, 131);
            this.accessLevelDownButton.Name = "accessLevelDownButton";
            this.accessLevelDownButton.Size = new System.Drawing.Size(20, 20);
            this.accessLevelDownButton.TabIndex = 3;
            this.accessLevelDownButton.Text = "-";
            this.accessLevelDownButton.UseVisualStyleBackColor = true;
            this.accessLevelDownButton.Click += new System.EventHandler(this.accessLevelDownButton_Click);
            // 
            // accessLevel
            // 
            this.accessLevel.AutoSize = true;
            this.accessLevel.Location = new System.Drawing.Point(90, 138);
            this.accessLevel.Name = "accessLevel";
            this.accessLevel.Size = new System.Drawing.Size(0, 13);
            this.accessLevel.TabIndex = 0;
            // 
            // openEmployeeButton
            // 
            this.openEmployeeButton.Location = new System.Drawing.Point(192, 43);
            this.openEmployeeButton.Name = "openEmployeeButton";
            this.openEmployeeButton.Size = new System.Drawing.Size(170, 29);
            this.openEmployeeButton.TabIndex = 4;
            this.openEmployeeButton.Text = "Сотрудники";
            this.openEmployeeButton.UseVisualStyleBackColor = true;
            this.openEmployeeButton.Click += new System.EventHandler(this.openEmployeeButton_Click);
            // 
            // openEstateTypeButton
            // 
            this.openEstateTypeButton.Location = new System.Drawing.Point(192, 77);
            this.openEstateTypeButton.Name = "openEstateTypeButton";
            this.openEstateTypeButton.Size = new System.Drawing.Size(170, 29);
            this.openEstateTypeButton.TabIndex = 5;
            this.openEstateTypeButton.Text = "Типы недвижимости";
            this.openEstateTypeButton.UseVisualStyleBackColor = true;
            this.openEstateTypeButton.Click += new System.EventHandler(this.openEstateTypeButton_Click);
            // 
            // openRoleButton
            // 
            this.openRoleButton.Location = new System.Drawing.Point(192, 109);
            this.openRoleButton.Name = "openRoleButton";
            this.openRoleButton.Size = new System.Drawing.Size(170, 29);
            this.openRoleButton.TabIndex = 6;
            this.openRoleButton.Text = "Роли";
            this.openRoleButton.UseVisualStyleBackColor = true;
            this.openRoleButton.Click += new System.EventHandler(this.openRoleButton_Click);
            // 
            // openServiceTypeButton
            // 
            this.openServiceTypeButton.Location = new System.Drawing.Point(192, 144);
            this.openServiceTypeButton.Name = "openServiceTypeButton";
            this.openServiceTypeButton.Size = new System.Drawing.Size(170, 29);
            this.openServiceTypeButton.TabIndex = 7;
            this.openServiceTypeButton.Text = "Услуги";
            this.openServiceTypeButton.UseVisualStyleBackColor = true;
            this.openServiceTypeButton.Click += new System.EventHandler(this.openServiceTypeButton_Click);
            // 
            // openEstateButton
            // 
            this.openEstateButton.Location = new System.Drawing.Point(192, 179);
            this.openEstateButton.Name = "openEstateButton";
            this.openEstateButton.Size = new System.Drawing.Size(170, 29);
            this.openEstateButton.TabIndex = 8;
            this.openEstateButton.Text = "Недвижимость";
            this.openEstateButton.UseVisualStyleBackColor = true;
            this.openEstateButton.Click += new System.EventHandler(this.openEstateButton_Click);
            // 
            // openContractButton
            // 
            this.openContractButton.Location = new System.Drawing.Point(192, 214);
            this.openContractButton.Name = "openContractButton";
            this.openContractButton.Size = new System.Drawing.Size(170, 29);
            this.openContractButton.TabIndex = 9;
            this.openContractButton.Text = "Договоры";
            this.openContractButton.UseVisualStyleBackColor = true;
            this.openContractButton.Click += new System.EventHandler(this.openContractButton_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 336);
            this.Controls.Add(this.openContractButton);
            this.Controls.Add(this.openEstateButton);
            this.Controls.Add(this.openServiceTypeButton);
            this.Controls.Add(this.openRoleButton);
            this.Controls.Add(this.openEstateTypeButton);
            this.Controls.Add(this.openEmployeeButton);
            this.Controls.Add(this.accessLevelDownButton);
            this.Controls.Add(this.accessLevelUpButton);
            this.Controls.Add(this.openClientButton);
            this.Controls.Add(this.accessLevel);
            this.Controls.Add(this.accessLevelLabel);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.midnameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "UserInfo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label midnameLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label accessLevelLabel;
        private System.Windows.Forms.Button openClientButton;
        private System.Windows.Forms.Button accessLevelUpButton;
        private System.Windows.Forms.Button accessLevelDownButton;
        private System.Windows.Forms.Label accessLevel;
        private System.Windows.Forms.Button openEmployeeButton;
        private System.Windows.Forms.Button openEstateTypeButton;
        private System.Windows.Forms.Button openRoleButton;
        private System.Windows.Forms.Button openServiceTypeButton;
        private System.Windows.Forms.Button openEstateButton;
        private System.Windows.Forms.Button openContractButton;
    }
}