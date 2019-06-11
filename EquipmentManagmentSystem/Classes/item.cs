using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EquipmentManagmentSystem.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EquipmentManagmentSystem.Classes
{
    public class item
    {
        public int item_Id { get; set; }
        public int REQ_Quantity { get; set; }
        public string item_Name { get; set; }
        public string Note { get; set; }
        public string OfferNote { get; set; }
        public string item_Code { get; set; }
        public double Cost { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Condition { get; set; } //للمطابق و غير مطابق لكل شركة
        public string madein { get; set; }
        public string Comp_Num { get; set; }
        public double totalCost { get; set; }
        public int Quantity { get; set; }
        public string Company_Name { get; set; }
        public string codeIdentifer { get; set; }
        public Competition competition { get; set; }
        public bool offrExist = false;
        public List<string> Items;
        public List<item> ItemOffers = new List<item>();
        //public SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|EquipmentManagment.02.mdf;Integrated Security = True");
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-9QGGOV2\\SQLEXPRESS;Initial Catalog=EquipmentManagment.02;Integrated Security=True");
        //public SqlConnection con = new SqlConnection("Data Source=AMRMOATAZ\\AMRMOATAZ;Initial Catalog=EquipmentManagment.02;Integrated Security=True");
        public List<string> GetAllItems(string Comp_Num)
        {
            Items = new List<string>();
            con.Open();
            SqlCommand readCmd = new SqlCommand("select Item_Name from Items where Comp_Num = '" + Comp_Num + "'", con);
            SqlDataReader rdr = readCmd.ExecuteReader();
            while (rdr.Read())
            {
                Items.Add(rdr["Item_Name"].ToString());
            }
            rdr.Close();
            con.Close();
            return Items;
        }
        public void GetAllOffers()
        {
            item ex;
            foreach (string it in Items)
            {
                ex = new item();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Offer where Item_Name = '" + it + "'  ", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ex.Cost = Convert.ToDouble((rdr["Cost"]));
                    ex.Model = (rdr["Model"].ToString());
                    ex.Manufacturer = (rdr["Manufacturer"].ToString());
                    ex.madein = (rdr["MadeIn"].ToString());
                    ex.Condition = (rdr["Condition"].ToString());
                    ex.Note = (rdr["Note"].ToString());
                    ex.Quantity = Convert.ToInt32(rdr["Quantity"]);
                    ex.Company_Name = (rdr["Company_Name"].ToString());
                    ex.item_Name = (rdr["Item_Name"].ToString());
                    ex.totalCost = Convert.ToDouble((rdr["Total_Cost"]));
                    ItemOffers.Add(ex);
                }
            }
        }
        public List<string> GetAllCompanies(string Comp_Num)
        {
            List<string> Companies = new List<string>();
            con.Open();
            string Query = "SELECT distinct O.Company_Name "
                            + "FROM Offer O INNER JOIN Items I "
                            + "ON O.ItemId = I.Item_Id "
                            + "WHERE I.Comp_Num = '" + Comp_Num + "' ";

            SqlCommand readCmd = new SqlCommand(Query, con);
            SqlDataReader rdr = readCmd.ExecuteReader();
            while (rdr.Read())
            {
                Companies.Add(rdr["Company_Name"].ToString());
            }
            rdr.Close();
            con.Close();
            return Companies;
        }
        public void getItem(string name)
        {
            con.Open();
            SqlCommand readCmd = new SqlCommand("select * from Items where Item_Name='" + name + "'", con);
            SqlDataReader rdr = readCmd.ExecuteReader();
            while (rdr.Read())
            {
                item_Name = (rdr["Item_Name"].ToString());
                REQ_Quantity = Convert.ToInt32(rdr["REQ_Qunatity"]);
                Note = (rdr["Note"].ToString());
                item_Code = (rdr["ItemCode"].ToString());
            }
            rdr.Close();
            con.Close();
        }
        public void Delete_Item(string Name,string Comp_Num)
        {
            con.Open();
            SqlCommand delcom = new SqlCommand("delete from Items where Item_Name = '" + Name + "' and Comp_Num  = '"+Comp_Num+"'", con);
            delcom.ExecuteNonQuery();
            con.Close();
        }
        public void Delete_Offer(string Name, string company_name,string comp_num)
        {
            con.Open();
            SqlCommand delcom = new SqlCommand("delete from Offer where Item_Name = '" + Name + "' and Company_Name ='" + company_name + "' and Comp_num = '"+comp_num+"'", con);
            delcom.ExecuteNonQuery();
            con.Close();
        }
        public void Update_Item(string ItemName)
        {
            con.Open();
            SqlCommand update = new SqlCommand("update Items set REQ_Qunatity = '" + REQ_Quantity + "',Item_Name='" + item_Name + "', Note = '" + Note + "', ItemCode = '" + item_Code + "'  where Item_Name ='" + ItemName + "' ", con);
            update.ExecuteNonQuery();

            con.Close();
        }
        public item getOffer(string itemName, string CompanyName,string CompNum)
        {
            item It = new item();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Offer where Item_Name = '" + itemName + "' and Company_Name ='" + CompanyName + "' and Comp_num = '"+CompNum+"'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                offrExist = true;
                OfferNote = (rdr["Note"].ToString());
                Model = (rdr["Model"].ToString());
                Manufacturer = (rdr["Manufacturer"].ToString());
                madein = (rdr["MadeIn"].ToString());
                Condition = (rdr["Condition"].ToString());
                Cost = (Convert.ToDouble(rdr["Cost"]));
                totalCost = (Convert.ToDouble(rdr["Total_Cost"]));
                Quantity = (Convert.ToInt32(rdr["Quantity"]));
            }
            rdr.Close();
            con.Close();
            return It;
        }
        public void Update_offer()
        {
            con.Open();
            SqlCommand up = new SqlCommand("update Offer set Model = '" + Model + "', Manufacturer = '" + Manufacturer + "', MadeIn = '" + madein + "', Condition ='" + Condition + "', Note = '" + OfferNote + "', Cost = '" + Cost + "', Total_Cost = '" + totalCost + "' where Item_Name = '" + item_Name + "' and Company_Name ='" + Company_Name + "'  and Comp_num = '" + Comp_Num + "'", con);
            up.ExecuteNonQuery();
            con.Close();
        }
        public void findItem(string itemId)
        {
            con.Open();
            SqlCommand readCmd = new SqlCommand("select * from Items where ItemCode = '" + itemId + "'", con);
            SqlDataReader rdr = readCmd.ExecuteReader();
            while (rdr.Read())
            {
                item_Name = (rdr["Item_Name"].ToString());
                REQ_Quantity = Convert.ToInt32(rdr["REQ_Qunatity"]);
                Note = (rdr["Note"].ToString());
                item_Code = (rdr["ItemCode"].ToString());
            }
            rdr.Close();
            con.Close();
        }
        public void additem()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand addcom;
                string inserting = ("insert into Items (REQ_Qunatity,Item_Name,Note,Comp_Num,ItemCode) values ('" + REQ_Quantity + "','" + item_Name + "','" + Note + "','" + Comp_Num + "','" + item_Code + "')");
                addcom = new SqlCommand(inserting, con);
                addcom.ExecuteNonQuery();
            con.Close();
        }
        public List<item> GetCompItems(string Comp_Num)
        {
            List<item> Items = new List<item>();
            con.Open();
            SqlCommand readCmd = new SqlCommand("select * from Items where Comp_Num = '" + Comp_Num + "'", con);
            SqlDataReader rdr = readCmd.ExecuteReader();
            while (rdr.Read())
            {
                item I = new item();
                I.item_Name = (rdr["Item_Name"].ToString());
                I.item_Code = (rdr["ItemCode"].ToString());
                I.REQ_Quantity = Convert.ToInt32(rdr["REQ_Qunatity"]);
                I.Comp_Num = (rdr["Comp_Num"].ToString());
                I.Note = (rdr["Note"].ToString());
                I.item_Id = Convert.ToInt32(rdr["Item_Id"]);
                Items.Add(I);
            }
            rdr.Close();
            con.Close();
            return Items;
        }
        public void ADD_Offer()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand Adddet;

            string inserting = ("insert into Offer (Item_Name,Company_Name,Cost,Model,Manufacturer,MadeIn,Condition,Note,Quantity,Total_Cost,ItemId,Comp_num)values ('" + item_Name + "','" + Company_Name + "','" + Cost + "','" + Model + "','" + Manufacturer + "','" + madein + "','" + Condition + "','" + OfferNote + "','" + REQ_Quantity + "','" + totalCost + "','" + item_Id + "','" + Comp_Num + "')");
            Adddet = new SqlCommand(inserting, con);
            Adddet.ExecuteNonQuery();

            con.Close();
        }
    }

}
