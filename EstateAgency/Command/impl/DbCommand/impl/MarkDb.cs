using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.DbCommand.impl
{
    class MarkDb : AbstractDbCommand
    {
        private DataGridView gridView;
        private String query;

        public MarkDb(User user, BindingSource bs, int accessLevel, DataGridView gridView, String query) : base(user, bs, accessLevel)
        {
            this.gridView = gridView;
            this.query = query;
        }

        public override void execute()
        {
            if (query != String.Empty)
            {
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                        {
                            continue;
                        }
                        if (cell.Value.ToString().Contains(query))
                        {
                            cell.Style.BackColor = Color.Green;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }
    }
}
