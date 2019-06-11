using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using EquipmentManagmentSystem.Classes;
using EquipmentManagmentSystem.Forms;
using EquipmentManagmentSystem.Report;
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
    public partial class التحليل_الفني : Form
    {
        public Competition comp = new Competition();
        public List<Competition> competitions = new List<Competition>();
        public التحليل_الفني()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            competitions = comp.GetAllCompettion();
            foreach (Competition i in competitions)
            {
                CompNameCBox.Items.Add(i.comp_Name);
            }
        }
        private void mainLayout1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void CompNameCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            RPT1 rpt = new RPT1();
            string comp_num = "";
            foreach (Competition i in competitions)
            {
                if (i.comp_Name == CompNameCBox.SelectedItem.ToString())
                {
                    comp_num = i.comp_Code;
                }
            }
            /********************************************************/
            TextObject Comp_NameTxt;
            Comp_NameTxt = (TextObject)rpt.ReportDefinition.ReportObjects["compNameTtx"];
            Comp_NameTxt.Text = CompNameCBox.SelectedItem.ToString();
            /******************************************************/
            TextObject DateTxt;
            DateTxt = (TextObject)rpt.ReportDefinition.ReportObjects["Date"];
            DateTxt.Text = DateTime.Now.ToString("yyyy/dd/MMMM",new System.Globalization.CultureInfo("ar-SA"));
            /*******************************************************/
            Competition c = new Competition();
            DataTable dt = c.getReport(comp_num);
            rpt.SetDataSource(dt);
            rpt.Refresh();
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void mainLayout1_BackColorChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void التحليل_الفني_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    }
