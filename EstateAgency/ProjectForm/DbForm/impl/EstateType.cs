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
    public partial class EstateType : TemplateForm
    {
        public EstateType()
        {
            InitializeComponent();
        }

        private void estateTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estateTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estateAgencyDataSet);

        }

        private void EstateType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estateAgencyDataSet.EstateType' table. You can move, or remove it, as needed.
            this.estateTypeTableAdapter.Fill(this.estateAgencyDataSet.EstateType);
            editAccessLevel = 2;
            removeAccessLevel = 2;
            spectateAccessLevel = 1;
            dataSet = estateAgencyDataSet;
            tableAdapter = tableAdapterManager;
            bindingSource = estateTypeBindingSource;
            dataGrid = estateTypeDataGridView;
        }
    }
}
