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
    public partial class Role : TemplateForm
    {
        public Role()
        {
            InitializeComponent();

        }

        private void roleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estateAgencyDataSet);

        }

        private void Role_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estateAgencyDataSet.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.estateAgencyDataSet.Role);
            spectateAccessLevel = 2;
            editAccessLevel = 3;
            removeAccessLevel = 3;
            dataSet = estateAgencyDataSet;
            bindingSource = roleBindingSource;
            dataGrid = roleDataGridView;
            tableAdapter = tableAdapterManager;
        }
    }
}
