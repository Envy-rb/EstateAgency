using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.ProjectForm.DbForm.impl;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.OpenFormCommand
{
    class OpenClient : AbstractCommand
    {
        public OpenClient(User user) : base(user)
        {
            accessLevel = 0;
        }

        public override void execute()
        {
            Client form = new Client();
            form.ShowDialog();
        }
    }
}
