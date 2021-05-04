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
    class ClearMarkDb : AbstractDbCommand
    {
        private DataGridView gridView;

        public ClearMarkDb(User user, BindingSource bs, int accessLevel, DataGridView gridView) : base(user, bs, accessLevel)
        {
            this.gridView = gridView;
        }

        public override void execute()
        {
            foreach (DataGridViewRow row in gridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
