using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.Command.impl.DbCommand;
using EstateAgency.ProjectForm.DbForm;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.OpenFormCommand
{
    class AddItem : AbstractDbCommand
    {
        public AddItem(User user, BindingSource bs, int accessLevel) : base (user, bs, accessLevel)
        {

        }

        public override void execute()
        {
            bs.AddNew();
        }

    }
}
