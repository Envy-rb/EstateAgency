using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.DbCommand
{
    abstract class AbstractDbCommand : AbstractCommand
    {
        protected BindingSource bs;

        public AbstractDbCommand(User user, BindingSource bs, int accessLevel) : base(user)
        {
            this.bs = bs;
            this.accessLevel = accessLevel;
        }

    }
}
