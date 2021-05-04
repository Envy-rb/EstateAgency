using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.DbCommand.impl
{
    class BsFilter : AbstractDbCommand
    {
        private String field;
        private String query;
        
        public BsFilter(User user, BindingSource bs, int accessLevel, String field, String query) : base(user, bs, accessLevel)
        {
            this.field = field;
            this.query = query;
        }

        public override void execute()
        {
            bs.Filter = "";
            bs.Filter = String.Format("{0} LIKE '%{1}%'", field, query);
        }

    }
}
