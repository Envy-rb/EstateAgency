using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.ProjectForm.DbForm;

namespace EstateAgency.ProjectForm.DbForm.impl
{
    public partial class ServiceType : TemplateForm
    {
        public ServiceType()
        {
            InitializeComponent();
            dataSet = estateAgencyDataSet;
            tableAdapter = tableAdapterManager;
            bindingSource = serviceTypeBindingSource;
            dataGrid = serviceTypeDataGridView;
            spectateAccessLevel = 0;
            editAccessLevel = 2;
            removeAccessLevel = 2;
    }

        private void ServiceType_Load(object sender, EventArgs e)
        {
            this.serviceTypeTableAdapter.Fill(this.estateAgencyDataSet.ServiceType);
        }

        private void serviceTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estateAgencyDataSet);
        }
    }
}
