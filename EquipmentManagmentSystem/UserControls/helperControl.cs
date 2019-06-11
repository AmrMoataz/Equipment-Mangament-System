using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentManagmentSystem.UserControls
{
    public partial class helperControl : UserControl
    {
        bool check;
        public helperControl()
        {
            InitializeComponent();
            check = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
             check = true;
        }
    }
}
