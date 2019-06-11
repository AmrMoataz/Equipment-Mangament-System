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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void mainLayout1_BackColorChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mainLayout1_Load(object sender, EventArgs e)
        {
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن الوصول لهذا الرابط الآن");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/0B7e11Fql-Q2Sal8zT1czYU5aU28");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ContactLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن الوصول لهذا الرابط الآن");
            }
        }

        private void ContactLink()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/0B7e11Fql-Q2Sal8zT1czYU5aU28");
        }
    }
}
