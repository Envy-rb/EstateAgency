
namespace EstateAgency.ProjectForm.DbForm
{
    partial class TemplateForm
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
            this.nextNavButton = new System.Windows.Forms.Button();
            this.lastNavButton = new System.Windows.Forms.Button();
            this.prevNavButton = new System.Windows.Forms.Button();
            this.firstNavButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.fieldComboBox = new System.Windows.Forms.ComboBox();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.markLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextNavButton
            // 
            this.nextNavButton.Location = new System.Drawing.Point(812, 392);
            this.nextNavButton.Name = "nextNavButton";
            this.nextNavButton.Size = new System.Drawing.Size(30, 30);
            this.nextNavButton.TabIndex = 0;
            this.nextNavButton.Text = ">";
            this.nextNavButton.UseVisualStyleBackColor = true;
            this.nextNavButton.Click += new System.EventHandler(this.nextNavButton_Click);
            // 
            // lastNavButton
            // 
            this.lastNavButton.Location = new System.Drawing.Point(893, 392);
            this.lastNavButton.Name = "lastNavButton";
            this.lastNavButton.Size = new System.Drawing.Size(30, 30);
            this.lastNavButton.TabIndex = 0;
            this.lastNavButton.Text = ">|";
            this.lastNavButton.UseVisualStyleBackColor = true;
            this.lastNavButton.Click += new System.EventHandler(this.lastNavButton_Click);
            // 
            // prevNavButton
            // 
            this.prevNavButton.Location = new System.Drawing.Point(731, 392);
            this.prevNavButton.Name = "prevNavButton";
            this.prevNavButton.Size = new System.Drawing.Size(30, 30);
            this.prevNavButton.TabIndex = 0;
            this.prevNavButton.Text = "<";
            this.prevNavButton.UseVisualStyleBackColor = true;
            this.prevNavButton.Click += new System.EventHandler(this.prevNavButton_Click);
            // 
            // firstNavButton
            // 
            this.firstNavButton.Location = new System.Drawing.Point(650, 392);
            this.firstNavButton.Name = "firstNavButton";
            this.firstNavButton.Size = new System.Drawing.Size(30, 30);
            this.firstNavButton.TabIndex = 0;
            this.firstNavButton.Text = "|<";
            this.firstNavButton.UseVisualStyleBackColor = true;
            this.firstNavButton.Click += new System.EventHandler(this.firstNavButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(747, 428);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(650, 428);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(848, 428);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // fieldComboBox
            // 
            this.fieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldComboBox.FormattingEnabled = true;
            this.fieldComboBox.Location = new System.Drawing.Point(650, 365);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.Size = new System.Drawing.Size(111, 21);
            this.fieldComboBox.TabIndex = 2;
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(650, 339);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(273, 20);
            this.queryTextBox.TabIndex = 3;
            this.queryTextBox.TextChanged += new System.EventHandler(this.queryTextBox_TextChanged);
            // 
            // markTextBox
            // 
            this.markTextBox.Location = new System.Drawing.Point(650, 313);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(172, 20);
            this.markTextBox.TabIndex = 4;
            this.markTextBox.TextChanged += new System.EventHandler(this.markTextBox_TextChanged);
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Location = new System.Drawing.Point(828, 316);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(70, 13);
            this.markLabel.TabIndex = 5;
            this.markLabel.Text = "Маркировка";
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 516);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.fieldComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lastNavButton);
            this.Controls.Add(this.firstNavButton);
            this.Controls.Add(this.prevNavButton);
            this.Controls.Add(this.nextNavButton);
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextNavButton;
        private System.Windows.Forms.Button lastNavButton;
        private System.Windows.Forms.Button prevNavButton;
        private System.Windows.Forms.Button firstNavButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.Label markLabel;
    }
}