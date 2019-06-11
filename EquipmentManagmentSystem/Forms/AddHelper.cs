using EquipmentManagmentSystem.Classes;
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
    public partial class AddHelper : Form
    {
        public Competition comp;
        public AddHelper(Competition _comp)
        {
            comp = _comp;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(helperNametxt.Text) && !String.IsNullOrEmpty(rankCbox.Text) && !String.IsNullOrEmpty(sidetxt.Text))
            {
                Helper helper = new Helper();
                helper.H_Name = helperNametxt.Text;

                helper.H_Rank = rankCbox.Text;
                helper.H_Side = sidetxt.Text;
                if (memRdbtn.Checked)
                {
                    helper.Type = memRdbtn.Text;
                }
                else
                {
                    helper.Type = helpRdbtn.Text;
                }
                helper.addhelper(comp.comp_Code);
                MessageBox.Show("تم الحفظ بنجاح ");
                helperNametxt.Clear();
                rankCbox.SelectedItem = null;
                sidetxt.Clear();
                memRdbtn.Checked = false;
                helpRdbtn.Checked = false;
            }
            else
                MessageBox.Show("ادخل البيانات المطلوبة ");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CompetitionDetails frm = new CompetitionDetails(comp);
            frm.Show();
            Hide();
        }
    }
}
