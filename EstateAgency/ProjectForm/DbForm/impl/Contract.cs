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
    public partial class Contract : TemplateForm
    {
        public Contract()
        {
            InitializeComponent();
        }

        private void contractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estateAgencyDataSet);


        }

        private void Contract_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estateAgencyDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.estateAgencyDataSet.Client);
            // TODO: This line of code loads data into the 'estateAgencyDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.estateAgencyDataSet.Employee);
            // TODO: This line of code loads data into the 'estateAgencyDataSet.Contract' table. You can move, or remove it, as needed.
            this.contractTableAdapter.Fill(this.estateAgencyDataSet.Contract);
            editAccessLevel = 2;
            removeAccessLevel = 3;
            spectateAccessLevel = 1;
            tableAdapter = tableAdapterManager;
            bindingSource = estateBindingSource;
            dataGrid = contractDataGridView;
            dataSet = estateAgencyDataSet;
        }
    }
}
