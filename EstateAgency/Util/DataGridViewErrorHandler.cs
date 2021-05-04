using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.UtilForm;

namespace EstateAgency.Util
{
    class DataGridViewErrorHandler
    {
        DataGridView gridView;
        public DataGridViewErrorHandler(DataGridView gridView)
        {
            this.gridView = gridView;
        }

        public String handle()
        {
            String result = "";
            DataGridViewCell cell = gridView.CurrentCell;
            Type type = cell.ValueType;
            gridView.EditingControl.Text = type.GetField("MinValue").GetValue(null).ToString();
            Error form = new Error(ErrorType.DataTypeError, type.Name);
            form.ShowDialog();
            return result;
        }
    }
}
