using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.ProjectForm.DbForm.impl;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.OpenFormCommand
{
    class OpenEstate : AbstractCommand
    {
        public OpenEstate(User user) : base(user)
        {
            accessLevel = 1;
        }

        public override void execute()
        {
            Estate form = new Estate();
            form.ShowDialog();
        }
    }
}
