using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.ProjectForm.DbForm.impl;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.OpenFormCommand
{
    class OpenEmployee : AbstractCommand
    {
        public OpenEmployee(User user) : base(user)
        {
            accessLevel = 2;
        }

        public override void execute()
        {
            Employee form = new Employee();
            form.ShowDialog();
        }
    }
}
