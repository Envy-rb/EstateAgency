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
    public partial class Client : TemplateForm
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estateAgencyDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.estateAgencyDataSet.Client);
            editAccessLevel = 2;
            spectateAccessLevel = 1;
            removeAccessLevel = 2;
            bindingSource = clientBindingSource;
            tableAdapter = tableAdapterManager;
            dataSet = estateAgencyDataSet;
            dataGrid = clientDataGridView;
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estateAgencyDataSet);

        }
    }
}
