using EstateAgency.Command;
using EstateAgency.Command.impl.DbCommand.impl;
using EstateAgency.Command.impl.OpenFormCommand;
using EstateAgency.EstateAgencyDataSetTableAdapters;
using EstateAgency.Util;
using System;
using System.Windows.Forms;

namespace EstateAgency.ProjectForm.DbForm
{
    public partial class TemplateForm : Form
    {
        protected User user = User.getInstance();
        protected BindingSource bindingSource;
        protected TableAdapterManager tableAdapter;
        protected EstateAgencyDataSet dataSet;
        protected DataGridView dataGrid = new DataGridView();

        protected int spectateAccessLevel = 0;
        protected int editAccessLevel = 0;
        protected int removeAccessLevel = 0;
        public TemplateForm()
        {
            InitializeComponent();
        }

        protected void firstNavButton_Click(object sender, EventArgs e)
        {
            ICommand command = new Navigating(user, bindingSource, spectateAccessLevel, Direction.First);
            command.invoke();
        }

        protected void prevNavButton_Click(object sender, EventArgs e)
        {
            ICommand command = new Navigating(user, bindingSource, spectateAccessLevel, Direction.Prev);
            command.invoke();
        }

        protected void nextNavButton_Click(object sender, EventArgs e)
        {
            ICommand command = new Navigating(user, bindingSource, spectateAccessLevel, Direction.Next);
            command.invoke();
        }

        protected void lastNavButton_Click(object sender, EventArgs e)
        {
            ICommand command = new Navigating(user, bindingSource, spectateAccessLevel, Direction.Last);
            command.invoke();
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            ICommand command = new RemoveItem(user, bindingSource, removeAccessLevel);
            command.invoke();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            ICommand command = new SaveBs(user, bindingSource, tableAdapter, dataSet, editAccessLevel);
            command.invoke();
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            ICommand command = new AddItem(user, bindingSource, editAccessLevel);
            command.invoke();
        }

        protected void TemplateForm_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                fieldComboBox.Items.Add(column.DataPropertyName);
            }
        }

        protected void queryTextBox_TextChanged(object sender, EventArgs e)
        {
            ICommand command = new BsFilter(user, bindingSource, spectateAccessLevel, fieldComboBox.Text, queryTextBox.Text);
            command.invoke();
        }

        protected void markTextBox_TextChanged(object sender, EventArgs e)
        {
            ICommand command = new MarkDb(user, bindingSource, spectateAccessLevel, dataGrid, markTextBox.Text);
            command.invoke();
        }
    }
}
