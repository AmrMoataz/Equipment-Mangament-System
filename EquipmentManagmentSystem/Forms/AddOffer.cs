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
    public partial class AddOffer : Form
    {
        public Competition comp = new Competition();
        public item add=new item();
        public bool IsNumber;
        public List<item> Itemss = new List<item>();
        public AddOffer(List <item> Items,Competition Comp)
        {
            comp = Comp;
            add.Comp_Num = Comp.comp_Code;
            Itemss = Items;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            foreach(item I in Items)
            {
                itemNameCbox.Items.Add(I.item_Name);
            }
        }

        private void itemNameCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (item I in Itemss)
            {
                if (itemNameCbox.Text == I.item_Name)

                {
                    add.item_Id = I.item_Id;
                }
            }

            for (int i = 0; i < Itemss.Count; i++)
            {
                if (Itemss[i].item_Name == itemNameCbox.Text)
                {
                    Qtytxt.Text = Itemss[i].REQ_Quantity.ToString();
                }
            }
        }

        private void addCompanyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                item offer = new item();
                if (String.IsNullOrEmpty(companyNametxt.Text) || String.IsNullOrEmpty(itemNameCbox.Text) || String.IsNullOrEmpty(Qtytxt.Text) || String.IsNullOrEmpty(costTxt.Text) || String.IsNullOrEmpty(totalCostTxt.Text))
                {
                    MessageBox.Show("برجاء ادخال البيانات المطلوبة ");
                }
                else
                {
                    offer.Company_Name = companyNametxt.Text;
                    offer.item_Name = itemNameCbox.Text;

                    int Qty;
                    IsNumber = int.TryParse(Qtytxt.Text, out Qty);
                    if (!IsNumber)
                        throw new Exception("برجاء إدخال رقم صحيح في الكمية المطلوبة");
                    offer.REQ_Quantity = Qty;
                    //offer.REQ_Quantity = Convert.ToInt32(Qtytxt.Text);

                    double cost;
                    IsNumber = Double.TryParse(costTxt.Text, out cost);
                    if (!IsNumber)
                        throw new Exception("برجاء إدخال رقم في السعر الإفرادي");
                    offer.Cost = cost;
                    //offer.Cost = Convert.ToInt32(costTxt.Text);

                    offer.totalCost = Convert.ToDouble(totalCostTxt.Text);
                    offer.Model = modelTxt.Text;
                    offer.Manufacturer = ManufTxt.Text;
                    offer.madein = madeinTxt.Text;
                    offer.item_Id = add.item_Id;
                    offer.Comp_Num = add.Comp_Num;
                    offer.Condition = conditionCbox.Text;
                    offer.OfferNote = NoteOfferTxt.Text;
                    offer.ADD_Offer();
                    MessageBox.Show("تم الحفظ بنجاح");
                    companyNametxt.Clear();
                    Qtytxt.Clear();
                    costTxt.Clear();
                    totalCostTxt.Clear();
                    modelTxt.Clear();
                    ManufTxt.Clear();
                    madeinTxt.Clear();
                    NoteOfferTxt.Clear();
                    conditionCbox.SelectedItem = null;
                    itemNameCbox.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);           
            }
           
            
        }

       

        private void costTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(costTxt.Text))
                {
                    int qty = Convert.ToInt32((Qtytxt.Text));
                    double Cost;
                    IsNumber = Double.TryParse(costTxt.Text, out Cost);
                    if (!IsNumber)
                        throw new Exception("برجاء إدخال رقم في السعر الإفرادي");

                    double totalCost = qty * Cost;
                    totalCostTxt.Text = totalCost.ToString();
                }
                else
                {
                    totalCostTxt.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                costTxt.Clear();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CompetitionDetails frm = new CompetitionDetails(comp);
            frm.Show();
            Hide();
        }
    }
}
