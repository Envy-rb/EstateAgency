
namespace EstateAgency.ProjectForm.DbForm.impl
{
    partial class Estate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estate));
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label roomCountLabel;
            System.Windows.Forms.Label squareLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label _estateTypeIdLabel;
            System.Windows.Forms.Label _clientIdLabel;
            System.Windows.Forms.Label _serviceTypeIdLabel;
            this.estateAgencyDataSet = new EstateAgency.EstateAgencyDataSet();
            this.estateTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.EstateTableAdapter();
            this.tableAdapterManager = new EstateAgency.EstateAgencyDataSetTableAdapters.TableAdapterManager();
            this.estateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.estateBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.roomCountTextBox = new System.Windows.Forms.TextBox();
            this.squareTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.estateTypeComboBox = new System.Windows.Forms.ComboBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.serviceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.estateTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estateTypeTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.EstateTypeTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.ClientTableAdapter();
            this.serviceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTypeTableAdapter = new EstateAgency.EstateAgencyDataSetTableAdapters.ServiceTypeTableAdapter();
            this.estateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addressLabel = new System.Windows.Forms.Label();
            roomCountLabel = new System.Windows.Forms.Label();
            squareLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            _estateTypeIdLabel = new System.Windows.Forms.Label();
            _clientIdLabel = new System.Windows.Forms.Label();
            _serviceTypeIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estateAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateBindingNavigator)).BeginInit();
            this.estateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estateTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // estateAgencyDataSet
            // 
            this.estateAgencyDataSet.DataSetName = "EstateAgencyDataSet";
            this.estateAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estateTableAdapter
            // 
            this.estateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EstateTableAdapter = this.estateTableAdapter;
            this.tableAdapterManager.EstateTypeTableAdapter = this.estateTypeTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ServiceTypeTableAdapter = this.serviceTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = EstateAgency.EstateAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estateBindingNavigator
            // 
            this.estateBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estateBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.estateBindingNavigatorSaveItem});
            this.estateBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estateBindingNavigator.Name = "estateBindingNavigator";
            this.estateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estateBindingNavigator.Size = new System.Drawing.Size(951, 25);
            this.estateBindingNavigator.TabIndex = 6;
            this.estateBindingNavigator.Text = "bindingNavigator1";
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
            // estateBindingNavigatorSaveItem
            // 
            this.estateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estateBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estateBindingNavigatorSaveItem.Image")));
            this.estateBindingNavigatorSaveItem.Name = "estateBindingNavigatorSaveItem";
            this.estateBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estateBindingNavigatorSaveItem.Text = "Save Data";
            this.estateBindingNavigatorSaveItem.Click += new System.EventHandler(this.estateBindingNavigatorSaveItem_Click);
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(26, 275);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(41, 13);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Адрес:";
            // 
            // roomCountLabel
            // 
            roomCountLabel.AutoSize = true;
            roomCountLabel.Location = new System.Drawing.Point(26, 301);
            roomCountLabel.Name = "roomCountLabel";
            roomCountLabel.Size = new System.Drawing.Size(110, 13);
            roomCountLabel.TabIndex = 17;
            roomCountLabel.Text = "Количество Комнат:";
            // 
            // roomCountTextBox
            // 
            this.roomCountTextBox.Location = new System.Drawing.Point(142, 294);
            this.roomCountTextBox.Name = "roomCountTextBox";
            this.roomCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomCountTextBox.TabIndex = 18;
            // 
            // squareLabel
            // 
            squareLabel.AutoSize = true;
            squareLabel.Location = new System.Drawing.Point(26, 327);
            squareLabel.Name = "squareLabel";
            squareLabel.Size = new System.Drawing.Size(57, 13);
            squareLabel.TabIndex = 19;
            squareLabel.Text = "Площадь:";
            // 
            // squareTextBox
            // 
            this.squareTextBox.Location = new System.Drawing.Point(142, 320);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(100, 20);
            this.squareTextBox.TabIndex = 20;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(26, 353);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(65, 13);
            priceLabel.TabIndex = 21;
            priceLabel.Text = "Стоимость:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(142, 346);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 22;
            // 
            // _estateTypeIdLabel
            // 
            _estateTypeIdLabel.AutoSize = true;
            _estateTypeIdLabel.Location = new System.Drawing.Point(26, 379);
            _estateTypeIdLabel.Name = "_estateTypeIdLabel";
            _estateTypeIdLabel.Size = new System.Drawing.Size(106, 13);
            _estateTypeIdLabel.TabIndex = 23;
            _estateTypeIdLabel.Text = "Тип Недвижимости";
            // 
            // _clientIdLabel
            // 
            _clientIdLabel.AutoSize = true;
            _clientIdLabel.Location = new System.Drawing.Point(26, 405);
            _clientIdLabel.Name = "_clientIdLabel";
            _clientIdLabel.Size = new System.Drawing.Size(46, 13);
            _clientIdLabel.TabIndex = 25;
            _clientIdLabel.Text = "Клиент:";
            // 
            // _serviceTypeIdLabel
            // 
            _serviceTypeIdLabel.AutoSize = true;
            _serviceTypeIdLabel.Location = new System.Drawing.Point(26, 431);
            _serviceTypeIdLabel.Name = "_serviceTypeIdLabel";
            _serviceTypeIdLabel.Size = new System.Drawing.Size(105, 13);
            _serviceTypeIdLabel.TabIndex = 27;
            _serviceTypeIdLabel.Text = "Тип обслуживания:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(142, 268);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 16;
            // 
            // estateTypeComboBox
            // 
            this.estateTypeComboBox.DataSource = this.estateTypeBindingSource;
            this.estateTypeComboBox.DisplayMember = "name";
            this.estateTypeComboBox.FormattingEnabled = true;
            this.estateTypeComboBox.Location = new System.Drawing.Point(142, 372);
            this.estateTypeComboBox.Name = "estateTypeComboBox";
            this.estateTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.estateTypeComboBox.TabIndex = 28;
            this.estateTypeComboBox.ValueMember = "estateTypeId";
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientBindingSource;
            this.clientComboBox.DisplayMember = "name";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(142, 399);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(100, 21);
            this.clientComboBox.TabIndex = 28;
            this.clientComboBox.ValueMember = "clientId";
            // 
            // serviceTypeComboBox
            // 
            this.serviceTypeComboBox.DataSource = this.serviceTypeBindingSource;
            this.serviceTypeComboBox.DisplayMember = "name";
            this.serviceTypeComboBox.FormattingEnabled = true;
            this.serviceTypeComboBox.Location = new System.Drawing.Point(142, 426);
            this.serviceTypeComboBox.Name = "serviceTypeComboBox";
            this.serviceTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.serviceTypeComboBox.TabIndex = 28;
            this.serviceTypeComboBox.ValueMember = "serviceTypeId";
            // 
            // estateTypeBindingSource
            // 
            this.estateTypeBindingSource.DataMember = "EstateType";
            this.estateTypeBindingSource.DataSource = this.estateAgencyDataSet;
            // 
            // estateTypeTableAdapter
            // 
            this.estateTypeTableAdapter.ClearBeforeFill = true;
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
            // serviceTypeBindingSource
            // 
            this.serviceTypeBindingSource.DataMember = "ServiceType";
            this.serviceTypeBindingSource.DataSource = this.estateAgencyDataSet;
            // 
            // serviceTypeTableAdapter
            // 
            this.serviceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // estateBindingSource
            // 
            this.estateBindingSource.DataMember = "Estate";
            this.estateBindingSource.DataSource = this.estateAgencyDataSet;
            // 
            // estateDataGridView
            // 
            this.estateDataGridView.AutoGenerateColumns = false;
            this.estateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.estateDataGridView.DataSource = this.estateBindingSource;
            this.estateDataGridView.Location = new System.Drawing.Point(12, 28);
            this.estateDataGridView.Name = "estateDataGridView";
            this.estateDataGridView.Size = new System.Drawing.Size(911, 220);
            this.estateDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "roomCount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество комнат";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "square";
            this.dataGridViewTextBoxColumn4.HeaderText = "Площадь";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Estate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 476);
            this.Controls.Add(this.estateDataGridView);
            this.Controls.Add(this.serviceTypeComboBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.estateTypeComboBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(roomCountLabel);
            this.Controls.Add(this.roomCountTextBox);
            this.Controls.Add(squareLabel);
            this.Controls.Add(this.squareTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(_estateTypeIdLabel);
            this.Controls.Add(_clientIdLabel);
            this.Controls.Add(_serviceTypeIdLabel);
            this.Controls.Add(this.estateBindingNavigator);
            this.Name = "Estate";
            this.Text = "Estate";
            this.Load += new System.EventHandler(this.Estate_Load);
            this.Controls.SetChildIndex(this.estateBindingNavigator, 0);
            this.Controls.SetChildIndex(_serviceTypeIdLabel, 0);
            this.Controls.SetChildIndex(_clientIdLabel, 0);
            this.Controls.SetChildIndex(_estateTypeIdLabel, 0);
            this.Controls.SetChildIndex(this.priceTextBox, 0);
            this.Controls.SetChildIndex(priceLabel, 0);
            this.Controls.SetChildIndex(this.squareTextBox, 0);
            this.Controls.SetChildIndex(squareLabel, 0);
            this.Controls.SetChildIndex(this.roomCountTextBox, 0);
            this.Controls.SetChildIndex(roomCountLabel, 0);
            this.Controls.SetChildIndex(this.addressTextBox, 0);
            this.Controls.SetChildIndex(addressLabel, 0);
            this.Controls.SetChildIndex(this.estateTypeComboBox, 0);
            this.Controls.SetChildIndex(this.clientComboBox, 0);
            this.Controls.SetChildIndex(this.serviceTypeComboBox, 0);
            this.Controls.SetChildIndex(this.estateDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.estateAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateBindingNavigator)).EndInit();
            this.estateBindingNavigator.ResumeLayout(false);
            this.estateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estateTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EstateAgencyDataSet estateAgencyDataSet;
        private EstateAgencyDataSetTableAdapters.EstateTableAdapter estateTableAdapter;
        private EstateAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estateBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton estateBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox roomCountTextBox;
        private System.Windows.Forms.TextBox squareTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private EstateAgencyDataSetTableAdapters.EstateTypeTableAdapter estateTypeTableAdapter;
        private System.Windows.Forms.ComboBox estateTypeComboBox;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.ComboBox serviceTypeComboBox;
        private System.Windows.Forms.BindingSource estateTypeBindingSource;
        private EstateAgencyDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private EstateAgencyDataSetTableAdapters.ServiceTypeTableAdapter serviceTypeTableAdapter;
        private System.Windows.Forms.BindingSource serviceTypeBindingSource;
        private System.Windows.Forms.BindingSource estateBindingSource;
        private System.Windows.Forms.DataGridView estateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}