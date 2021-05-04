
namespace EstateAgency.ProjectForm.DbForm.impl
{
    partial class Contract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contract));
            System.Windows.Forms.Label _employeeIdLabel;
            System.Windows.Forms.Label _estateIdLabel;
            System.Windows.Forms.Label _buyerIdLabel;
            System.Windows.Forms.Label dateStartLabel;
            System.Windows.Forms.Label dateEndLabel;
            this.estateAgencyDataSet = new EstateAgency.EstateAgencyDataSet();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.ContractTableAdapter();
            this.tableAdapterManager = new EstateAgency.EstateAgencyDataSetTableAdapters.TableAdapterManager();
            this.contractBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contractBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emplyeeComboBox = new System.Windows.Forms.ComboBox();
            this.estateComboBox = new System.Windows.Forms.ComboBox();
            this.buyerComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.EmployeeTableAdapter();
            this.estateTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.EstateTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.ClientTableAdapter();
            this.contractDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            _employeeIdLabel = new System.Windows.Forms.Label();
            _estateIdLabel = new System.Windows.Forms.Label();
            _buyerIdLabel = new System.Windows.Forms.Label();
            dateStartLabel = new System.Windows.Forms.Label();
            dateEndLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estateAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).BeginInit();
            this.contractBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // estateAgencyDataSet
            // 
            this.estateAgencyDataSet.DataSetName = "EstateAgencyDataSet";
            this.estateAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.estateAgencyDataSet;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.ContractTableAdapter = this.contractTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.EstateTableAdapter = this.estateTableAdapter;
            this.tableAdapterManager.EstateTypeTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ServiceTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EstateAgency.EstateAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contractBindingNavigator
            // 
            this.contractBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractBindingNavigator.BindingSource = this.contractBindingSource;
            this.contractBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contractBindingNavigatorSaveItem});
            this.contractBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractBindingNavigator.Name = "contractBindingNavigator";
            this.contractBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractBindingNavigator.Size = new System.Drawing.Size(943, 25);
            this.contractBindingNavigator.TabIndex = 6;
            this.contractBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // contractBindingNavigatorSaveItem
            // 
            this.contractBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contractBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contractBindingNavigatorSaveItem.Image")));
            this.contractBindingNavigatorSaveItem.Name = "contractBindingNavigatorSaveItem";
            this.contractBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contractBindingNavigatorSaveItem.Text = "Save Data";
            this.contractBindingNavigatorSaveItem.Click += new System.EventHandler(this.contractBindingNavigatorSaveItem_Click);
            // 
            // _employeeIdLabel
            // 
            _employeeIdLabel.AutoSize = true;
            _employeeIdLabel.Location = new System.Drawing.Point(47, 286);
            _employeeIdLabel.Name = "_employeeIdLabel";
            _employeeIdLabel.Size = new System.Drawing.Size(60, 13);
            _employeeIdLabel.TabIndex = 14;
            _employeeIdLabel.Text = "Сотрудник";
            // 
            // _estateIdLabel
            // 
            _estateIdLabel.AutoSize = true;
            _estateIdLabel.Location = new System.Drawing.Point(47, 312);
            _estateIdLabel.Name = "_estateIdLabel";
            _estateIdLabel.Size = new System.Drawing.Size(90, 13);
            _estateIdLabel.TabIndex = 16;
            _estateIdLabel.Text = "Недвижимость: ";
            // 
            // _buyerIdLabel
            // 
            _buyerIdLabel.AutoSize = true;
            _buyerIdLabel.Location = new System.Drawing.Point(47, 338);
            _buyerIdLabel.Name = "_buyerIdLabel";
            _buyerIdLabel.Size = new System.Drawing.Size(70, 13);
            _buyerIdLabel.TabIndex = 18;
            _buyerIdLabel.Text = "Покупатель:";
            // 
            // dateStartLabel
            // 
            dateStartLabel.AutoSize = true;
            dateStartLabel.Location = new System.Drawing.Point(47, 365);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new System.Drawing.Size(74, 13);
            dateStartLabel.TabIndex = 20;
            dateStartLabel.Text = "Дата начала:";
            // 
            // dateStartDateTimePicker
            // 
            this.dateStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "dateStart", true));
            this.dateStartDateTimePicker.Location = new System.Drawing.Point(139, 361);
            this.dateStartDateTimePicker.Name = "dateStartDateTimePicker";
            this.dateStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateStartDateTimePicker.TabIndex = 21;
            // 
            // dateEndLabel
            // 
            dateEndLabel.AutoSize = true;
            dateEndLabel.Location = new System.Drawing.Point(47, 391);
            dateEndLabel.Name = "dateEndLabel";
            dateEndLabel.Size = new System.Drawing.Size(92, 13);
            dateEndLabel.TabIndex = 22;
            dateEndLabel.Text = "Дата окончания:";
            // 
            // dateEndDateTimePicker
            // 
            this.dateEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "dateEnd", true));
            this.dateEndDateTimePicker.Location = new System.Drawing.Point(139, 387);
            this.dateEndDateTimePicker.Name = "dateEndDateTimePicker";
            this.dateEndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateEndDateTimePicker.TabIndex = 23;
            // 
            // emplyeeComboBox
            // 
            this.emplyeeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractBindingSource, "_employeeId", true));
            this.emplyeeComboBox.DataSource = this.employeeBindingSource;
            this.emplyeeComboBox.DisplayMember = "surname";
            this.emplyeeComboBox.FormattingEnabled = true;
            this.emplyeeComboBox.Location = new System.Drawing.Point(139, 283);
            this.emplyeeComboBox.Name = "emplyeeComboBox";
            this.emplyeeComboBox.Size = new System.Drawing.Size(200, 21);
            this.emplyeeComboBox.TabIndex = 24;
            this.emplyeeComboBox.ValueMember = "employeeId";
            // 
            // estateComboBox
            // 
            this.estateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractBindingSource, "_estateId", true));
            this.estateComboBox.DataSource = this.estateBindingSource;
            this.estateComboBox.DisplayMember = "address";
            this.estateComboBox.FormattingEnabled = true;
            this.estateComboBox.Location = new System.Drawing.Point(139, 310);
            this.estateComboBox.Name = "estateComboBox";
            this.estateComboBox.Size = new System.Drawing.Size(200, 21);
            this.estateComboBox.TabIndex = 24;
            this.estateComboBox.ValueMember = "estateId";
            // 
            // buyerComboBox
            // 
            this.buyerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractBindingSource, "_buyerId", true));
            this.buyerComboBox.DataSource = this.clientBindingSource;
            this.buyerComboBox.DisplayMember = "surname";
            this.buyerComboBox.FormattingEnabled = true;
            this.buyerComboBox.Location = new System.Drawing.Point(139, 335);
            this.buyerComboBox.Name = "buyerComboBox";
            this.buyerComboBox.Size = new System.Drawing.Size(200, 21);
            this.buyerComboBox.TabIndex = 24;
            this.buyerComboBox.ValueMember = "clientId";
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
            // estateTableAdapter
            // 
            this.estateTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.estateAgencyDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // contractDataGridView
            // 
            this.contractDataGridView.AutoGenerateColumns = false;
            this.contractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.contractDataGridView.DataSource = this.contractBindingSource;
            this.contractDataGridView.Location = new System.Drawing.Point(12, 28);
            this.contractDataGridView.Name = "contractDataGridView";
            this.contractDataGridView.Size = new System.Drawing.Size(911, 220);
            this.contractDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dateStart";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата начала";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dateEnd";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата конца";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // estateBindingSource
            // 
            this.estateBindingSource.DataMember = "Estate";
            this.estateBindingSource.DataSource = this.estateAgencyDataSet;
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 541);
            this.Controls.Add(this.contractDataGridView);
            this.Controls.Add(this.buyerComboBox);
            this.Controls.Add(this.estateComboBox);
            this.Controls.Add(this.emplyeeComboBox);
            this.Controls.Add(_employeeIdLabel);
            this.Controls.Add(_estateIdLabel);
            this.Controls.Add(_buyerIdLabel);
            this.Controls.Add(dateStartLabel);
            this.Controls.Add(this.dateStartDateTimePicker);
            this.Controls.Add(dateEndLabel);
            this.Controls.Add(this.dateEndDateTimePicker);
            this.Controls.Add(this.contractBindingNavigator);
            this.Name = "Contract";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.Contract_Load);
            this.Controls.SetChildIndex(this.contractBindingNavigator, 0);
            this.Controls.SetChildIndex(this.dateEndDateTimePicker, 0);
            this.Controls.SetChildIndex(dateEndLabel, 0);
            this.Controls.SetChildIndex(this.dateStartDateTimePicker, 0);
            this.Controls.SetChildIndex(dateStartLabel, 0);
            this.Controls.SetChildIndex(_buyerIdLabel, 0);
            this.Controls.SetChildIndex(_estateIdLabel, 0);
            this.Controls.SetChildIndex(_employeeIdLabel, 0);
            this.Controls.SetChildIndex(this.emplyeeComboBox, 0);
            this.Controls.SetChildIndex(this.estateComboBox, 0);
            this.Controls.SetChildIndex(this.buyerComboBox, 0);
            this.Controls.SetChildIndex(this.contractDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.estateAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).EndInit();
            this.contractBindingNavigator.ResumeLayout(false);
            this.contractBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EstateAgencyDataSet estateAgencyDataSet;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private EstateAgencyDataSetTableAdapters.ContractTableAdapter contractTableAdapter;
        private EstateAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contractBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contractBindingNavigatorSaveItem;
        private EstateAgencyDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DateTimePicker dateStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateEndDateTimePicker;
        private System.Windows.Forms.ComboBox emplyeeComboBox;
        private System.Windows.Forms.ComboBox estateComboBox;
        private System.Windows.Forms.ComboBox buyerComboBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EstateAgencyDataSetTableAdapters.EstateTableAdapter estateTableAdapter;
        private EstateAgencyDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridView contractDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource estateBindingSource;
    }
}