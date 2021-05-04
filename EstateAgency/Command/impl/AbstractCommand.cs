using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.Util;
using EstateAgency.UtilForm;

namespace EstateAgency.Command.impl
{
    abstract class AbstractCommand : ICommand
    {
        protected int accessLevel;
        protected int userAccessLevel;

        public AbstractCommand(User user)
        {
            userAccessLevel = user.AccessLevel;
        }

        virtual public void execute()
        {
            throw new NotImplementedException();
        }

        public void invoke()
        {
            if (userAccessLevel >= accessLevel)
            {
                execute();
            }
            else
            {
                Error form = new Error(ErrorType.AccessDenied, userAccessLevel.ToString(), accessLevel.ToString());
                form.ShowDialog();
            }
        }
    }
}
