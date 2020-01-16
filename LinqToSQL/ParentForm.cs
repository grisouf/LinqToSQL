using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSQL
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();

            var form = new ManageUserForm
            {
                MdiParent = this,
                Dock = DockStyle.Fill,
                MaximizeBox = true
            };
            form.Show();
        }
    }
}
