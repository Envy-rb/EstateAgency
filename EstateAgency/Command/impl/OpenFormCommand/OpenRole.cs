using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.ProjectForm.DbForm.impl;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.OpenFormCommand
{
    class OpenRole : AbstractCommand
    {
        public OpenRole(User user) : base(user)
        {
            accessLevel = 3;
        }

        public override void execute()
        {
            Role form = new Role();
            form.ShowDialog();
        }
    }
}
