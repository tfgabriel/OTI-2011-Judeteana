using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oti2011_judeteana_2
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            Load load = new Load();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = load.UserTable();
            dataGridView1.DataSource = bindingSource;
        }
    }
}
