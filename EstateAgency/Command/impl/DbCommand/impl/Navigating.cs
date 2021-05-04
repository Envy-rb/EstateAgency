using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.Util;

namespace EstateAgency.Command.impl.DbCommand.impl
{
    class Navigating : AbstractDbCommand
    {
        Direction dir;
        public Navigating(User user, BindingSource bs, int accessLevel, Direction dir) : base(user, bs, accessLevel)
        {
            this.dir = dir;
        }

        public override void execute()
        {
            switch (dir)
            {
                case Direction.Next:
                    bs.MoveNext();
                    break;
                case Direction.Last:
                    bs.MoveLast();
                    break;
                case Direction.Prev:
                    bs.MovePrevious();
                    break;
                case Direction.First:
                    bs.MoveFirst();
                    break;
                default:
                    break;
            }
        }
    }
}
