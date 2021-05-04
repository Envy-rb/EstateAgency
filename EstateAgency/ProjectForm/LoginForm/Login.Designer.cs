
namespace EstateAgency
{
    partial class Login
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
            this.estateAgencyDataSet = new EstateAgency.EstateAgencyDataSet();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginDataTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.LoginDataTableAdapter();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.signinButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.testUserButton = new System.Windows.Forms.Button();
            this.accessLevelTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.estateAgencyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // estateAgencyDataSet
            // 
            this.estateAgencyDataSet.DataSetName = "EstateAgencyDataSet";
            this.estateAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(9, 11);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // loginDataTableAdapter
            // 
            this.loginDataTableAdapter.ClearBeforeFill = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 27);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(218, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 83);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '$';
            this.passwordTextBox.Size = new System.Drawing.Size(218, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(9, 67);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(34, 122);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(165, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signinButton
            // 
            this.signinButton.Location = new System.Drawing.Point(34, 178);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(100, 23);
            this.signinButton.TabIndex = 4;
            this.signinButton.Text = "Sign-In";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(31, 106);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 3;
            // 
            // testUserButton
            // 
            this.testUserButton.Location = new System.Drawing.Point(140, 178);
            this.testUserButton.Name = "testUserButton";
            this.testUserButton.Size = new System.Drawing.Size(90, 23);
            this.testUserButton.TabIndex = 4;
            this.testUserButton.Text = "TestUser";
            this.testUserButton.UseVisualStyleBackColor = true;
            this.testUserButton.Click += new System.EventHandler(this.testUserButton_Click);
            // 
            // accessLevelTextBox
            // 
            this.accessLevelTextBox.Location = new System.Drawing.Point(140, 152);
            this.accessLevelTextBox.Name = "accessLevelTextBox";
            this.accessLevelTextBox.Size = new System.Drawing.Size(90, 20);
            this.accessLevelTextBox.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 213);
            this.Controls.Add(this.accessLevelTextBox);
            this.Controls.Add(this.testUserButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estateAgencyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EstateAgencyDataSet estateAgencyDataSet;
        private System.Windows.Forms.Label loginLabel;
        private EstateAgencyDataSetTableAdapters.LoginDataTableAdapter loginDataTableAdapter;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button testUserButton;
        private System.Windows.Forms.TextBox accessLevelTextBox;
    }
}

