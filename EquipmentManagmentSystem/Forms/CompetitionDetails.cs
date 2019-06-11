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
    public partial class CompetitionDetails : Form
    {
        Competition Update_Comp,load;
        Helper getHelpers = new Helper();
        item GetItems = new item();
        List<string> Helpers;
        List<string> items;
        List<string> Companies;
        public string Comp_num,DecDate,meetDate,SendDate,OpenDate;
        bool IsNumber;
        int Qty;

        public CompetitionDetails(Competition Competition_Details)
        {
            InitializeComponent();
            this.Text = Competition_Details.comp_Name;
            load = Competition_Details;
            StartPosition = FormStartPosition.CenterScreen;
            CompNameTxt.Text = Competition_Details.comp_Name;
            CompStat_txt.Text = Competition_Details.comp_Stat;
            compNumTxt.Text = Competition_Details.comp_Code;
            Comp_num = Competition_Details.comp_Code;
            DecisionTxt.Text = Competition_Details.Decision;
            DecisionNumTxt.Text = Competition_Details.Decision_Num;
            compOpDtp.Text = Competition_Details.Date_Created;
            compSendDtp.Text = Competition_Details.comp_sendDate;
            DecisionDtp.Text = Competition_Details.Decision_Date;
            meetingDtp.Text = Competition_Details.meetDate;
            Helpers = getHelpers.GetAllHelpers(Competition_Details.comp_Code);
            foreach (string item in Helpers)
            {
                HelperCbox.Items.Add(item);
            }
            items =GetItems.GetAllItems(Competition_Details.comp_Code);
            Companies = GetItems.GetAllCompanies(Competition_Details.comp_Code);
            foreach (string item in items)
            {
                itemNameCbox.Items.Add(item);
                itemONameCbox.Items.Add(item);
            }
            foreach (string item in Companies)
            {
                companyNameCbox.Items.Add(item);
            }
        }

        private void editCompBtn_Click(object sender, EventArgs e)
        {
            /****************DateShowControl*********************/
            DecDateDayLBL.Visible = true;
            DecDateMonthLbl.Visible = true;
            DecDateYearLbl.Visible = true;
            DecDateDayCBox.Visible = true;
            DecDateMonthCBox.Visible = true;
            DecDateYearCBox.Visible = true;
            MeetDatDayLBL.Visible = true;
            MeetDatMonLBL.Visible = true;
            MeetDatYearLBL.Visible = true;
            OpenDatDayLBL.Visible = true;
            OpenDatMonLBL.Visible = true;
            OpenDatYearLBL.Visible = true;
            SendDatDayLBL.Visible = true;
            SendDatMonLBL.Visible = true;
            SendDatYearLBL.Visible = true;
            MeetDatDayCBox.Visible = true;
            MeetDatMonCBox.Visible = true;
            MeetDatYearCBox.Visible = true;
            OpenDatDayCBox.Visible = true;
            OpenDatMonCBox.Visible = true;
            OpenDatYearCBox.Visible = true;
            SendDatDayCbox.Visible = true;
            SendDatMonCbox.Visible = true;
            SendDatYearCBox.Visible = true;
            /***************************************/
            CompNameTxt.ReadOnly=false;
            compNumTxt.ReadOnly = false;
            DecisionTxt.ReadOnly = false;
            DecisionNumTxt.ReadOnly = false;
            fullRdb.Visible = true;
            partRdb.Visible = true;
            CompStat_txt.Text="";
            CompStat_txt.Visible = false;
            compOpDtp.Visible = false;
            compSendDtp.Visible = false;
            DecisionDtp.Visible = false;
            meetingDtp.Visible = false;
        }

        private void SaveComb_Btn_Click(object sender, EventArgs e)
        {
            Update_Comp = load;
            try
            {
                if (String.IsNullOrEmpty(CompNameTxt.Text) || String.IsNullOrEmpty(compNumTxt.Text) || String.IsNullOrEmpty(DecisionTxt.Text) || String.IsNullOrEmpty(DecisionNumTxt.Text))
                {
                    throw new Exception("برجاء ادخال البيانات المطلوبة في الصفحة  ");
                };
                Update_Comp.comp_Name = CompNameTxt.Text ;
                Update_Comp.comp_Code = compNumTxt.Text;
                Update_Comp.Decision= DecisionTxt.Text;
                if(fullRdb.Checked)
                {
                    Update_Comp.comp_Stat = fullRdb.Text;
                }
                if (partRdb.Checked)
                {
                    Update_Comp.comp_Stat = partRdb.Text;
                }
                /******************Dates**********************/

                //DecisionDate//
                if (!String.IsNullOrEmpty(DecDateDayCBox.Text) && !String.IsNullOrEmpty(DecDateMonthCBox.Text) && !String.IsNullOrEmpty(DecDateYearCBox.Text))
                {
                    DecDate = DecDateDayCBox.Text + " / " + DecDateMonthCBox.Text + " / " + DecDateYearCBox.Text;
                    Update_Comp.Decision_Date = DecDate;
                }
                //meetDate//
                if (!String.IsNullOrEmpty(MeetDatDayCBox.Text) && !String.IsNullOrEmpty(MeetDatMonCBox.Text) && !String.IsNullOrEmpty(MeetDatYearCBox.Text))
                {
                    meetDate = MeetDatDayCBox.Text + " / " + MeetDatMonCBox.Text + " / " + MeetDatYearCBox.Text;
                    Update_Comp.meetDate = meetDate;
                }
                //OpenDate//
                if (!String.IsNullOrEmpty(OpenDatDayCBox.Text) && !String.IsNullOrEmpty(OpenDatMonCBox.Text) && !String.IsNullOrEmpty(OpenDatYearCBox.Text))
                {
                    OpenDate = OpenDatDayCBox.Text + " / " + OpenDatMonCBox.Text + " / " + OpenDatYearCBox.Text;
                    Update_Comp.Date_Created = OpenDate;
                }
                //SendDate//
                if (!String.IsNullOrEmpty(SendDatDayCbox.Text) && !String.IsNullOrEmpty(SendDatMonCbox.Text) && !String.IsNullOrEmpty(SendDatYearCBox.Text))
                {
                    SendDate = SendDatDayCbox.Text + " / " + SendDatMonCbox.Text + " / " + SendDatYearCBox.Text;
                    Update_Comp.comp_sendDate = SendDate;
                }
                /*********************************************/
                Update_Comp.Decision_Num = DecisionNumTxt.Text;
                Update_Comp.Update_competition(Comp_num);
                MessageBox.Show("تمت العملية بنجاح");
                Hide();
                CompetitionDetails frm = new CompetitionDetails(Update_Comp);
                frm.Show();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("رقم المنافسة موجود مسبقا، برجاء ادخال رقم اخر");
                }
                else

                    MessageBox.Show(ex.Message);
            }

        }

        private void HelperCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            helper.getHelper(HelperCbox.SelectedItem.ToString(),load.comp_Code);
            helpDNameTxt.Text = helper.H_Name;
            helperSideTxt.Text = helper.H_Side;
            Helper_rankTxt.Text = helper.H_Rank;
            HelperTypeTxt.Text = helper.Type;
            helpDNameTxt.ReadOnly = true;
            helperSideTxt.ReadOnly = true;
            PosCbox.Visible = false;
            TypeCbox.Visible = false;
        }

        private void editHelperBtn_Click(object sender, EventArgs e)
        {
            helpDNameTxt.ReadOnly = false;
            helperSideTxt.ReadOnly = false;
            PosCbox.Visible = true;
            TypeCbox.Visible = true;
            Helper_rankTxt.Text = "";
            HelperTypeTxt.Text = "";

        }
        

        private void deleteHelperBTn_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            helper.Delete_Helper(HelperCbox.SelectedItem.ToString(),load.comp_Code);
            MessageBox.Show("تمت العملية بنجاح");
            Hide();
            CompetitionDetails frm = new CompetitionDetails(load);
            frm.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Helper Update_Helper = new Helper();
            try
            {
                if (String.IsNullOrEmpty(helpDNameTxt.Text) || String.IsNullOrEmpty(helperSideTxt.Text) || String.IsNullOrEmpty(PosCbox.Text) || String.IsNullOrEmpty(TypeCbox.Text))
                {
                    throw new Exception("برجاء ادخال البيانات المطلوبة في الصفحة  ");
                };
                Update_Helper.H_Name = helpDNameTxt.Text;
                Update_Helper.H_Rank = PosCbox.SelectedItem.ToString();
                Update_Helper.H_Side = helperSideTxt.Text;
                Update_Helper.Type = TypeCbox.SelectedItem.ToString();
                Update_Helper.Update_Helper(HelperCbox.Text,load.comp_Code);
                MessageBox.Show("تمت العملية بنجاح");
                Hide();
                CompetitionDetails frm = new CompetitionDetails(load);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void HelperTypeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemNameCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NoteTxt.ReadOnly = true;
            itemNameTxt.ReadOnly = true;
            reqQtyTxt.ReadOnly = true;
            NoteTxt.ReadOnly = true;
            ItemCodeTxt.ReadOnly = true;
            item item = new item();
            item.getItem(itemNameCbox.SelectedItem.ToString());
            itemNameTxt.Text = item.item_Name;
            reqQtyTxt.Text = item.REQ_Quantity.ToString();
            NoteTxt.Text = item.Note;
            ItemCodeTxt.Text = item.item_Code;
        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            item del = new item();
            del.Delete_Item(itemNameCbox.SelectedItem.ToString(),load.comp_Code);
            MessageBox.Show("تمت العملية بنجاح");
            Hide();
            CompetitionDetails frm = new CompetitionDetails(load);
            frm.Show();
        }

        private void editItemBtn_Click(object sender, EventArgs e)
        {
            itemNameTxt.ReadOnly = false;
            //reqQtyTxt.ReadOnly = false;
            NoteTxt.ReadOnly = false;
            ItemCodeTxt.ReadOnly = false;

        }

        private void SaveBtn3_Click(object sender, EventArgs e)
        {
            item Update_Item = new item();
            try
            {
                if ( String.IsNullOrEmpty(itemNameTxt.Text) || String.IsNullOrEmpty(reqQtyTxt.Text))
                {
                    throw new Exception("برجاء ادخال البيانات المطلوبة في الصفحة  ");
                };
                Update_Item.item_Name = itemNameTxt.Text;

                int reqQty;
                IsNumber = int.TryParse(reqQtyTxt.Text, out reqQty);
                if (!IsNumber)
                    throw new Exception("برجاء إدخال رقم صحيح في الكمية المطلوبة");
                Update_Item.REQ_Quantity = reqQty;

                Update_Item.Note = NoteTxt.Text;

                int itemCode;
                IsNumber = int.TryParse(ItemCodeTxt.Text, out itemCode);
                if (!IsNumber)
                    throw new Exception("برجاء إدخال رقم صحيح في رقم البند");
                //Update_Item.item_Code = itemCode;
                Update_Item.item_Code = ItemCodeTxt.Text;

                Update_Item.Update_Item(itemNameCbox.SelectedItem.ToString());
                MessageBox.Show("تمت العملية بنجاح");
                Hide();
                CompetitionDetails frm = new CompetitionDetails(load);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemONameCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (itemONameCbox.SelectedItem != null && companyNameCbox.SelectedItem != null)
            {
                item Item = new item();
                
                Item.getOffer(itemONameCbox.SelectedItem.ToString(), companyNameCbox.SelectedItem.ToString(),load.comp_Code);
                if (Item.offrExist)
                {
                    NoteOfferTxt.Text = Item.OfferNote;
                    ModelTxt.Text = Item.Model;
                    ManufTxt.Text = Item.Manufacturer;
                    MadeInTxt.Text = Item.madein;
                    ConditionViewtxt.Text = Item.Condition;
                    costTxt.Text = Item.Cost.ToString();
                    totalCostTxt.Text = Item.totalCost.ToString();
                    Qty = Item.Quantity;
                }
                else
                {
                    ModelTxt.Text = "";
                    ManufTxt.Text = "";
                    MadeInTxt.Text = "";
                    NoteOfferTxt.Text = "";
                    ConditionViewtxt.Text = "";
                    costTxt.Clear();
                    totalCostTxt.Clear();
                    MessageBox.Show("هذه الشركة غير مشتركة في هذا البند");
                   
                }
            }
            else
            {
                MessageBox.Show("برجاء اختيار بند و شركة  ");
            }
        }

        private void AddHelperBtn_Click(object sender, EventArgs e)
        {
            AddHelper frm = new AddHelper(load);
            frm.Show();
            Hide();

        }

        private void ItemAddBtn_Click(object sender, EventArgs e)
        {
            AddItem frm = new AddItem(load);
            frm.Show();
            Hide();
        }

        private void AdditionalOfferBtn_Click(object sender, EventArgs e)
        {
            Hide();
            item I = new item();
            AddOffer frm = new AddOffer(I.GetCompItems(load.comp_Code), load);
            frm.Show();
        }

        private void costTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(costTxt.Text))
                {
                    int qty = Qty;
                    double Cost;
                    IsNumber = Double.TryParse(costTxt.Text, out Cost);
                    
                    if (!IsNumber)
                        throw new Exception("برجاء إدخال رقم في السعر الإفرادي");

                    double totalCost = Cost* qty ;
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

        private void CompetitionDetails_Load(object sender, EventArgs e)
        {

        }

        private void deleteOfferBtn_Click(object sender, EventArgs e)
        {
            if (itemONameCbox.SelectedItem != null && companyNameCbox.SelectedItem != null)
            {
                item del = new item();
                del.Delete_Offer(itemONameCbox.SelectedItem.ToString(), companyNameCbox.SelectedItem.ToString(),load.comp_Code);
                MessageBox.Show("تمت العملية بنجاح");
                Hide();
                CompetitionDetails frm = new CompetitionDetails(load);
                frm.Show();
            }
            else
            {
                MessageBox.Show("برجاء اختيار بند و شركة  ");
            }
        }

        private void companyNameCbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TrueConditionRBtn.Visible = false;TrueConditionRBtn.Visible = false;
            ConditionViewtxt.Visible = true;
            ModelTxt.ReadOnly = true;
            ManufTxt.ReadOnly = true;
            MadeInTxt.ReadOnly = true;
            if (itemONameCbox.SelectedItem != null && companyNameCbox.SelectedItem != null)
            {
                item Item = new item();
                Item.getOffer(itemONameCbox.SelectedItem.ToString(), companyNameCbox.SelectedItem.ToString(),load.comp_Code);
                if (Item.offrExist)
                {
                    NoteOfferTxt.Text = Item.OfferNote;
                    ModelTxt.Text = Item.Model;
                    ManufTxt.Text = Item.Manufacturer;
                    MadeInTxt.Text = Item.madein;
                    ConditionViewtxt.Text = Item.Condition;
                    costTxt.Text = Item.Cost.ToString();
                    totalCostTxt.Text = Item.totalCost.ToString();
                    Qty = Item.Quantity;
                }
                else
                {
                    NoteOfferTxt.Text = "";
                    ModelTxt.Text = "";
                    ManufTxt.Text = "";
                    MadeInTxt.Text = "";
                    ConditionViewtxt.Text = "";
                    costTxt.Clear();
                    totalCostTxt.Clear();

                    MessageBox.Show("هذه الشركة غير مشتركة في هذا البند");
                }
            }
            else
            {
                MessageBox.Show("برجاء اختيار بند و شركة  ");
            }


        }

        private void editOfferBtn_Click(object sender, EventArgs e)
        {
            NoteOfferTxt.ReadOnly = false;
            FalseConditionRBtn.Visible = true;
            TrueConditionRBtn.Visible = true;
            ConditionViewtxt.Visible = false;
            ModelTxt.ReadOnly = false;
            ManufTxt.ReadOnly = false;
            MadeInTxt.ReadOnly = false;
            costTxt.ReadOnly = false;
            //totalCostlbl.Visible = true;

        }

        private void SaveBtn4_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemONameCbox.SelectedItem != null && companyNameCbox.SelectedItem != null)
                {
                    item Item = new item();
                    Item.getOffer(itemONameCbox.SelectedItem.ToString(), companyNameCbox.SelectedItem.ToString(), load.comp_Code);
                    if (Item.offrExist)
                    {
                        Item.Comp_Num = load.comp_Code;
                        Item.Company_Name = companyNameCbox.Text;
                        Item.item_Name = itemONameCbox.Text;
                        Item.Model = ModelTxt.Text;
                        Item.Manufacturer = ManufTxt.Text;
                        Item.madein = MadeInTxt.Text;
                        Item.OfferNote = NoteOfferTxt.Text;
                        if (TrueConditionRBtn.Checked)
                        {
                            Item.Condition = "مطابق";
                            ConditionViewtxt.Text = "مطابق";

                        }
                        if (FalseConditionRBtn.Checked)
                        {
                            Item.Condition = "غير مطابق";
                            ConditionViewtxt.Text = "غير مطابق";
                        }

                        double cost;
                        IsNumber = Double.TryParse(costTxt.Text, out cost);
                        if (!IsNumber)
                            throw new Exception("برجاء إدخال رقم في السعر الإفرادي");
                        Item.Cost = cost;

                        double totalCost =  cost* Qty;
                        totalCostTxt.Text = totalCost.ToString();
                        Item.totalCost = totalCost;
                        //int qty = Convert.ToInt32((Qtytxt.Text));
                        //int Cost = Convert.ToInt32(costTxt.Text);
                        //int totalCost = qty * Cost;
                        //totalCostTxt.Text = totalCost.ToString();

                        Item.Update_offer();
                        MessageBox.Show("تم الحفظ بنجاح");
                        ModelTxt.ReadOnly = true;
                        ManufTxt.ReadOnly = true;
                        MadeInTxt.ReadOnly = true;
                        FalseConditionRBtn.Visible = false;
                        TrueConditionRBtn.Visible = false;
                        ConditionViewtxt.Visible = true;
                        NoteOfferTxt.ReadOnly = true;
                        costTxt.ReadOnly = true;
                        //totalCostlbl.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("هذه العرض عير موجود");
                    }
                }
                else
                {
                    MessageBox.Show("برجاء اختيار بند و شركة  ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelCompBtn_Click(object sender, EventArgs e)
        {
            load.Delete_Competition();
            MessageBox.Show("تمت العملية بنجاح");
            Hide();
        }

    }
}
