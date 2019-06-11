using EquipmentManagmentSystem.Classes;
using EquipmentManagmentSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentManagmentSystem
{
    public partial class Competitions : Form
    {
        bool helperstb;
        bool itemstb;
        bool companytb;
        bool IsNumber; // for Parsing

        int helpersCount;
        int itemsCount;
        int companyCount;

        public string DecDate, meetDate, SendDate, OpenDate;

        List<item> itemslist = new List<item>();
        List<Helper> helpersList = new List<Helper>();
        List<item> offerslist = new List<item>();
        List<string> Companies;
        Competition comp;

        public Competitions()
        {
            InitializeComponent();
            helperstb = true;
            itemstb = true;
            companytb = true;

            StartPosition = FormStartPosition.CenterScreen;
            competitionTb.TabPages.RemoveByKey("ReqItemsTb");
            competitionTb.TabPages.RemoveByKey("HelpersTb");
            competitionTb.TabPages.RemoveByKey("CompanyTb");

            helpersCount = 0;
            itemsCount = 0;
            companyCount = 0;

        }
        private void mainLayout1_BackColorChanged(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void toHelpersBtn_Click(object sender, EventArgs e)
        {
            if (helperstb)
            {
                competitionTb.TabPages.Add(HelpersTb);
                competitionTb.SelectedTab = HelpersTb;
                helperstb = false;
            }
            else
            {
                MessageBox.Show("لقد فتحت هذه الصفحة مسبقا");
            }
        }
        void newBtn_Click(object sender, EventArgs e)
        {

            foreach (Control item in flowLayoutPanel1.Controls.OfType<Control>())
            {
                if (item.Tag == sender || item == sender)
                {

                    foreach (var h in helpersList)
                    {
                        if (h.codeIdentifer == item.Name)
                        {
                            helpersList.Remove(h);
                            helpersCount--;
                            break;
                        }
                    }
                    flowLayoutPanel1.Controls.Remove(item);
                }
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(helperNametxt.Text))
                {
                    throw new Exception("برجاء ادخال البيانات المطلوبة");
                }

                #region controls
                helpersCount++;
                Label newlable = new Label();
                Button newBtn = new Button();

                newlable.Name = "Member" + helpersCount;
                newlable.Text = helperNametxt.Text;
                newlable.AutoSize = true;
                newlable.Visible = true;
                newlable.Enabled = true;
                newlable.Tag = newBtn;

                newBtn.Name = "DeleteMember" + helpersCount;
                newBtn.Text = "-";
                newBtn.Size = new Size(26, 23);
                newBtn.BackColor = Color.SeaGreen;
                newBtn.ForeColor = Color.White;
                newBtn.FlatStyle = FlatStyle.Flat;
                newBtn.Click += new EventHandler(newBtn_Click);



                flowLayoutPanel1.Controls.Add(newlable);
                flowLayoutPanel1.Controls.Add(newBtn);



                #endregion

                Helper helper = new Helper();
                helper.H_Name = newlable.Text;

                helper.H_Rank = rankCbox.Text;
                helper.H_Side = sidetxt.Text;
                helper.codeIdentifer = newlable.Name;
                if (memRdbtn.Checked)
                {
                    helper.Type = memRdbtn.Text;
                }
                else if (helpRdbtn.Checked)
                {
                    helper.Type = helpRdbtn.Text;
                }

                helpersList.Add(helper);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            helperNametxt.Clear();
            sidetxt.Clear();
            memRdbtn.Checked = false;
            helpRdbtn.Checked = false;

        }
        private void toitemsBtn_Click(object sender, EventArgs e)
        {
            if (itemstb)
            {
                competitionTb.TabPages.Add(ReqItemsTb);
                competitionTb.SelectedTab = ReqItemsTb;
                itemstb = false;
            }
            else
            {
                MessageBox.Show("لقد فتحت هذه الصفحة مسبقا");
            }
        }
        void deleteitem_Click(object sender, EventArgs e)
        {
            foreach (Control item in itemsPanel.Controls.OfType<Control>())
            {
                if (item.Tag == sender || item == sender)
                {
                    foreach (var i in itemslist)
                    {
                        if (i.codeIdentifer == item.Name)
                        {
                            itemslist.Remove(i);
                            itemsCount--;
                            break;
                        }
                    }
                    itemsPanel.Controls.Remove(item);
                }
            }
        }
        private void addItemsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (item x in itemslist)
                {
                    if (x.item_Code == ItemCodeTxt.Text)
                    {
                        throw new Exception("هذا البند مضاف في هذه المنافسة من قبل");
                    }
                }

                if (String.IsNullOrEmpty(itemNametxt.Text) || String.IsNullOrEmpty(reqQtytxt.Text))
                {
                    throw new Exception("برجاء ادخال البيانات المطلوبة");
                }
                int reqQty;
                IsNumber = int.TryParse(reqQtytxt.Text, out reqQty);
                if (!IsNumber)
                    throw new Exception("برجاء إدخال رقم صحيح في الكمية");

                //int itemCode;
                //IsNumber = int.TryParse(ItemCodeTxt.Text, out itemCode);
                //if (!IsNumber)
                //    throw new Exception("برجاء إدخال رقم صحيح في رقم البند");
                #region controls
                helpersCount++;
                Label newlable = new Label();
                Button newBtn = new Button();

                newlable.Name = "Item" + itemsCount;
                newlable.Text = itemNametxt.Text;
                newlable.AutoSize = true;
                newlable.Visible = true;
                newlable.Enabled = true;
                newlable.Tag = newBtn;

                newBtn.Name = "deleteitem" + itemsCount;
                newBtn.Text = "-";
                newBtn.Size = new Size(26, 23);
                newBtn.BackColor = Color.SeaGreen;
                newBtn.ForeColor = Color.White;
                newBtn.FlatStyle = FlatStyle.Flat;
                newBtn.Click += new EventHandler(deleteitem_Click);



                itemsPanel.Controls.Add(newlable);
                itemsPanel.Controls.Add(newBtn);

                #endregion

                item item = new item();
                item.item_Name = newlable.Text;

               
                item.REQ_Quantity = reqQty;

                item.Note = notetxt.Text;
                item.codeIdentifer = newlable.Name;

                item.item_Code = ItemCodeTxt.Text;

                itemslist.Add(item);
                SearchItemTxt.Clear();
                ItemCodeTxt.Clear();
                itemNametxt.Clear();
                reqQtytxt.Clear();
                notetxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void toCompanyBtn_Click(object sender, EventArgs e)
        {
            if (companytb)
            {
                competitionTb.TabPages.Add(CompanyTb);
                competitionTb.SelectedTab = CompanyTb;
                companytb = false;
            }
            else
            {
                MessageBox.Show("لقد فتحت هذه الصفحة مسبقا");
            }
        }
        void deleteCompany_Click(object sender, EventArgs e)
        {
            foreach (Control item in companiesPanel.Controls.OfType<Control>())
            {
                if (item.Tag == sender || item == sender)
                {
                    foreach (var offer in offerslist)
                    {
                        if (offer.codeIdentifer == item.Name)
                        {
                            offerslist.Remove(offer);
                            companyCount--;
                            break;
                        }

                    }
                    companiesPanel.Controls.Remove(item);
                }
            }
        }
        private void addCompanyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(companyNametxt.Text) || String.IsNullOrEmpty(itemNameCbox.Text) || String.IsNullOrEmpty(totalCostTxt.Text))
                {
                    throw new Exception("برجاء ادخال البيانات المطلوبة");
                }
                double cost;
                IsNumber = Double.TryParse(costTxt.Text, out cost);
                if (!IsNumber)
                    throw new Exception("برجاء إدخال رقم في السعر الإفرادي");

                #region controls
                companyCount++;
                Label newlable = new Label();
                Button newBtn = new Button();

                newlable.Name = "Company" + itemsCount;
                newlable.Text = companyNametxt.Text;
                newlable.AutoSize = true;
                newlable.Visible = true;
                newlable.Enabled = true;
                newlable.Tag = newBtn;

                newBtn.Name = "deleteCompany" + itemsCount;
                newBtn.Text = "-";
                newBtn.Size = new Size(26, 23);
                newBtn.BackColor = Color.SeaGreen;
                newBtn.ForeColor = Color.White;
                newBtn.FlatStyle = FlatStyle.Flat;
                newBtn.Click += new EventHandler(deleteCompany_Click);



                companiesPanel.Controls.Add(newlable);
                companiesPanel.Controls.Add(newBtn);


                #endregion

                item offer = new item();
                offer.Company_Name = newlable.Text;
                offer.item_Name = itemNameCbox.Text;

                int Qty;
                IsNumber = int.TryParse(Qtytxt.Text, out Qty);
                offer.Quantity = Qty;

                offer.Cost = cost;

                double totalCost;
                IsNumber = Double.TryParse(totalCostTxt.Text, out totalCost);
                offer.totalCost = totalCost;

                offer.Comp_Num = compNumTxt.Text;
                offer.Model = modelTxt.Text;
                offer.Manufacturer = ManufTxt.Text;
                offer.madein = madeinTxt.Text;
                offer.Condition = conditionCbox.Text;
                offer.codeIdentifer = newlable.Name;
                offerslist.Add(offer);
                companyNametxt.Clear();
                Qtytxt.Clear();
                costTxt.Clear();
                totalCostTxt.Clear();
                modelTxt.Clear();
                ManufTxt.Clear();
                madeinTxt.Clear();
                itemNameCbox.SelectedItem = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
        private void CompanyTb_Enter(object sender, EventArgs e)
        {
            itemNameCbox.Items.Clear();
            foreach (var item in itemslist)
            {
                itemNameCbox.Items.Add(item.item_Name);
            }
        }
        private void CreateCompBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(compNameTxt.Text) || String.IsNullOrEmpty(compNumTxt.Text) || String.IsNullOrEmpty(DecisionTxt.Text) || String.IsNullOrEmpty(decisionNumTxt.Text))
                {
                    throw new Exception("برجاء ادخال البيانات المطلوبة في الصفجة المنافسة");
                }

                Competition newComp = new Competition();
                newComp.comp_Name = compNameTxt.Text;
                newComp.comp_Code = compNumTxt.Text;

                /******************Dates**********************/
                
                //DecisionDate//
                DecDate = DecDateDayCBox.Text + " / " + DecDateMonthCBox.Text + " / " + DecDateYearCBox.Text;
                //meetDate//
                meetDate = MeetDatDayCBox.Text + " / " + MeetDatMonCBox.Text + " / " + MeetDatYearCBox.Text;
                //OpenDate//
                OpenDate = OpenDatDayCBox.Text + " / " + OpenDatMonCBox.Text + " / " + OpenDatYearCBox.Text;
                //SendDate//
                SendDate = SendDatDayCbox.Text + " / " + SendDatMonCbox.Text + " / " + SendDatYearCBox.Text;
                /*********************************************/

                newComp.Date_Created = OpenDate;
                newComp.Decision_Date = DecDate;
                newComp.meetDate = meetDate;
                newComp.comp_sendDate = SendDate;

                newComp.items_count = itemsCount;

                if (fullRdb.Checked)
                {
                    newComp.comp_Stat = fullRdb.Text;
                }
                else if (partRdb.Checked)
                {
                    newComp.comp_Stat = partRdb.Text;
                }
                newComp.Decision_Num = decisionNumTxt.Text;
                newComp.Decision = DecisionTxt.Text;

                foreach (item item in itemslist)
                {
                    newComp.Items.Add(item); ;
                }
                foreach (Helper helper in helpersList)
                {
                    newComp.Helpers.Add(helper);
                }
                foreach (item offer in offerslist)
                {
                    newComp.Offers.Add(offer);
                }

                newComp.ADD_Competiton();
                MessageBox.Show("تمت العملية بنجاح");

                Competitions frm = new Competitions();
                frm.Show();
                this.Hide();

            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("رقم المنافسة موجود مسبقا، برجاء ادخال رقم اخر");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void itemNameCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < itemslist.Count; i++)
            {
                if (itemslist[i].item_Name == itemNameCbox.Text)
                {
                    Qtytxt.Text = itemslist[i].REQ_Quantity.ToString();
                }
            }
        }

        private void Competitions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

                    double totalCost =  Cost* qty ;
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

        private void oldCompCbox_Click(object sender, EventArgs e)
        {
                oldCompCbox.Items.Clear();
                Competition comp = new Competition();
                Companies = comp.GetComp_Names();
                foreach (string item in Companies)
                {
                    oldCompCbox.Items.Add(item);
                }

        }
        private void Competitions_Load(object sender, EventArgs e)
        {

        }

        private void oldCompCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            comp = new Competition();
            CompetitionDetails CompDetails = new CompetitionDetails(comp.GetCompettion(oldCompCbox.SelectedItem.ToString()));
            if(CompDetails.Visible==false)
            CompDetails.Show();
        }
        private void SearchItemBtn_Click(object sender, EventArgs e)
        {
            item serch = new item();
            serch.findItem(SearchItemTxt.Text);
            if (serch.item_Code != null)
            {
                ItemCodeTxt.Text = serch.item_Code;
                itemNametxt.Text = serch.item_Name;
            }
            else
            {
                MessageBox.Show("البند غير موجود");
            }
        }

        private void Competitions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
