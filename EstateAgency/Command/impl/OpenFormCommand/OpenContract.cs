using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.ProjectForm.DbForm.impl;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.OpenFormCommand
{
    class OpenContract : AbstractCommand
    {
        public OpenContract(User user) : base(user)
        {
            accessLevel = 0;
        }

        public override void execute()
        {
            Contract form = new Contract();
            form.ShowDialog();
        }
    }
}
