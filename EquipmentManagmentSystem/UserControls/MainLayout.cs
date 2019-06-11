using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentManagmentSystem.Forms;

namespace EquipmentManagmentSystem
{
    public partial class MainLayout : UserControl
    {
        public MainLayout()
        {
            InitializeComponent();
            
        }

        private void InputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            Competitions frm = new Competitions();
            frm.Show();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            Home frm = new Home();
            frm.Show();           
        }

        private void Tech_analysis_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            التحليل_الفني frm = new التحليل_الفني();
            frm.Show();
        }
    }
}
