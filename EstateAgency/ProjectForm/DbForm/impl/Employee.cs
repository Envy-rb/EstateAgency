using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency.ProjectForm.DbForm.impl
{
    public partial class Employee : TemplateForm
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estateAgencyDataSet);
            
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estateAgencyDataSet.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.estateAgencyDataSet.Role);
            // TODO: This line of code loads data into the 'estateAgencyDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.estateAgencyDataSet.Employee);
            editAccessLevel = 3;
            spectateAccessLevel = 1;
            removeAccessLevel = 3;
            tableAdapter = tableAdapterManager;
            dataSet = estateAgencyDataSet;
            bindingSource = employeeBindingSource;
            dataGrid = employeeDataGridView;
        }
    }
}
