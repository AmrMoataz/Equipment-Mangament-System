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
    public partial class AddItem : Form
    {
        public Competition comp;
        bool IsNumber;
        public AddItem(Competition _comp)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            comp = _comp;
        }

        private void addItemsBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(itemNametxt.Text) && !String.IsNullOrEmpty(reqQtytxt.Text) &&  !String.IsNullOrEmpty(ItemCodeTxt.Text))
            {
                item item = new item();
                item.item_Name = itemNametxt.Text;
                item.REQ_Quantity = Convert.ToInt32(reqQtytxt.Text);
                item.Note = notetxt.Text;
                item.item_Code = ItemCodeTxt.Text;
                item.Comp_Num = comp.comp_Code;
                item.additem();
                ItemCodeTxt.Clear();
                itemNametxt.Clear();
                reqQtytxt.Clear();
                notetxt.Clear();
                MessageBox.Show("تم الحفظ بنجاح");
            }

            else
                MessageBox.Show("ادخل البيانات المطلوبة ");
        }

        private void addItemsBtn_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(itemNametxt.Text) && !String.IsNullOrEmpty(reqQtytxt.Text) && !String.IsNullOrEmpty(ItemCodeTxt.Text))
            {
                item item = new item();
                item.item_Name = itemNametxt.Text;

                int Qty;
                IsNumber = int.TryParse(reqQtytxt.Text, out Qty);
                if (!IsNumber)
                    throw new Exception("برجاء إدخال رقم صحيح في الكمية المطلوبة");
                item.REQ_Quantity = Qty;

                //item.REQ_Quantity = Convert.ToInt32(reqQtytxt.Text);
                item.Note = notetxt.Text;
                item.item_Code = ItemCodeTxt.Text;
                item.Comp_Num = comp.comp_Code;
                item.additem();
                ItemCodeTxt.Clear();
                itemNametxt.Clear();
                reqQtytxt.Clear();
                notetxt.Clear();
                MessageBox.Show("تم الحفظ بنجاح");
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
