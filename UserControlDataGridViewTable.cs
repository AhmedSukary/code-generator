using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Generator
{
    public partial class UserControlDataGridViewTable : UserControl
    {
        public delegate void GenerateCode(object sender, DataTable dataTable);
        public event GenerateCode OnGenerateCode;
        DataTable _DataTable = new DataTable();
        public UserControlDataGridViewTable(DataTable dataTable)
        {
            InitializeComponent();
            dataGridView1.DataSource = dataTable;
            label1.Text = dataTable.TableName;
            _DataTable = dataTable;
        }

        private void buttonGenerateCode_Click(object sender, EventArgs e)
        {
            OnGenerateCode?.Invoke(this, _DataTable);
        }
    }
}
