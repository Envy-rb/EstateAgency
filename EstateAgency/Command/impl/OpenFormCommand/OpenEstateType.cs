using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.ProjectForm.DbForm.impl;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.OpenFormCommand
{
    class OpenEstateType : AbstractCommand
    {
        public OpenEstateType(User user) : base(user)
        {
            accessLevel = 0;
        }

        override public void execute()
        {            
            EstateType form = new EstateType();
            form.ShowDialog();
        }
    }
}
