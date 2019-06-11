using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentManagmentSystem.Forms
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                Home frm = new Home();
                frm.Show();
                this.Hide();
            }
        }
    }
}
