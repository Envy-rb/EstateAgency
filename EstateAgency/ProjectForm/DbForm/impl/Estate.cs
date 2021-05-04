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
    public partial class Estate : TemplateForm
    {
        public Estate()
        {
            InitializeComponent();
        }

        private void estateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estateAgencyDataSet);
        }

        private void Estate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estateAgencyDataSet.ServiceType' table. You can move, or remove it, as needed.
            this.serviceTypeTableAdapter.Fill(this.estateAgencyDataSet.ServiceType);
            // TODO: This line of code loads data into the 'estateAgencyDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.estateAgencyDataSet.Client);
            // TODO: This line of code loads data into the 'estateAgencyDataSet.EstateType' table. You can move, or remove it, as needed.
            this.estateTypeTableAdapter.Fill(this.estateAgencyDataSet.EstateType);
            editAccessLevel = 2;
            removeAccessLevel = 2;
            spectateAccessLevel = 1;
            bindingSource = estateBindingSource;
            dataSet = estateAgencyDataSet;
            tableAdapter = tableAdapterManager;
            dataGrid = estateDataGridView;
        }
    }
}
