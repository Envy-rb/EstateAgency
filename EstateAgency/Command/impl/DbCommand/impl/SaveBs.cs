using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.Command.impl.DbCommand;
using EstateAgency.EstateAgencyDataSetTableAdapters;
using EstateAgency.Util;
using EstateAgency.UtilForm;

namespace EstateAgency.Command.impl.OpenFormCommand
{
    class SaveBs : AbstractDbCommand
    {
        TableAdapterManager ta;
        EstateAgencyDataSet ds;
        public SaveBs(User user, BindingSource bs, TableAdapterManager ta, EstateAgencyDataSet ds, int accessLevel) : base(user, bs, accessLevel)
        {
            this.ta = ta;
            this.ds = ds;
        }

        public override void execute()
        {
            bs.EndEdit();
            ta.UpdateAll(this.ds);   
        }
    }
}
