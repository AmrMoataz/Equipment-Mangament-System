using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EquipmentManagmentSystem.Classes
{
    public class Competition
    {
        public Competition()
        {
            Items = new List<item>();
            Helpers = new List<Helper>();
            Offers = new List<item>();
        }
       public SqlConnection con = new SqlConnection("Data Source=DESKTOP-9QGGOV2\\SQLEXPRESS;Initial Catalog=EquipmentManagment.02;Integrated Security=True");
        //public SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|EquipmentManagment.02.mdf;Integrated Security = True");
        //public SqlConnection con = new SqlConnection("Data Source=AMRMOATAZ\\AMRMOATAZ;Initial Catalog=EquipmentManagment.02;Integrated Security=True");
        public string Date_Created { get; set; }
        public string Decision_Date { get; set; }
        public string comp_sendDate { get; set; }
        public string meetDate { get; set; }
        //------------------------------------//
        public string comp_Code { get; set; }
        public string comp_Name { get; set; }
        public int items_count { get; set; }
        public string comp_Stat { get; set; } // لل كلي و الجزئي من المنافسات
        public string Decision_Num { get; set; }
        public string Decision { get; set; }
        public string comp_sendCode { get; set; } //recheck
        public string codeIdentifer { get; set; }
        public List<item> Items { get; set; }
        public List<Helper> Helpers { get; set; }
        public List<item> Offers { get; set; }
        public List<string> CompanyNames;
        public item ReportItem;
        Competition viewComp;
        List<Competition> AllComps;
        public void Delete_Competition()
        {
            con.Open();
            SqlCommand delcom = new SqlCommand("delete from Competition where Comp_Num = '" + comp_Code + "'", con);
            delcom.ExecuteNonQuery();
            con.Close();
        }
        public void Update_competition(string OldNum)
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand update = new SqlCommand("update Competition set Comp_Num='" + comp_Code + "',Comp_Name='" + comp_Name + "',Date_Created='" + Date_Created + "',Items_Count='" + items_count + "',comp_Stat='" + comp_Stat + "',Decision_Num='" + Decision_Num + "',Decision_Date='" + Decision_Date + "',Decision='" + Decision + "', comp_sendCode='" + comp_sendCode + "',comp_sendDate='" + comp_sendDate + "',meetDate='" + meetDate + "' where Comp_Num='" + OldNum + "'", con);
            update.ExecuteNonQuery();
            SqlCommand update2 = new SqlCommand("update Offer set Comp_num='" + comp_Code + "' where Comp_num='" + OldNum + "'", con);
            update2.ExecuteNonQuery();
            con.Close();
        }
        public void ADD_Competiton()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand addcom = new SqlCommand("insert into Competition (Comp_Num,Comp_Name,Date_Created,comp_Stat,Decision_Num,Decision_Date,Decision,comp_sendCode,comp_sendDate,meetDate) values ('" + comp_Code + "','" + comp_Name + "','" + Date_Created + "','" + comp_Stat + "','" + Decision_Num + "','" + Decision_Date + "','" + Decision + "','" + comp_sendCode + "','" + comp_sendDate + "','" + meetDate + "')", con);
            addcom.ExecuteNonQuery();
            addhelper();
            additem();
            ADD_Details();
            con.Close();
        }
        private void ADD_Details()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand Adddet;


            foreach (item x in Offers)
            {
                foreach (item I in Items)
                {
                    if (I.item_Name == x.item_Name)
                        x.item_Id = I.item_Id;
                }
                string inserting = ("insert into Offer (Item_Name,Company_Name,Cost,Model,Manufacturer,MadeIn,Condition,Note,Quantity,Total_Cost,ItemId,Comp_num)values ('" + x.item_Name + "','" + x.Company_Name + "','" + x.Cost + "','" + x.Model + "','" + x.Manufacturer + "','" + x.madein + "','" + x.Condition + "','" + x.Note + "','" + x.Quantity + "','" + x.totalCost + "','" + x.item_Id + "','"+x.Comp_Num+"')");
                Adddet = new SqlCommand(inserting, con);
                Adddet.ExecuteNonQuery();
            }
            con.Close();
        }
        private void additem()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand addcom;
            SqlCommand GetIDcom;
            foreach (item bnd in Items)
            {
                string inserting = ("insert into Items (REQ_Qunatity,Item_Name,Note,Comp_Num,ItemCode) values ('" + bnd.REQ_Quantity + "','" + bnd.item_Name + "','" + bnd.Note + "','" + comp_Code + "','" + bnd.item_Code + "')");
                addcom = new SqlCommand(inserting, con);
                addcom.ExecuteNonQuery();
                string getId = ("SELECT TOP 1 Item_Id FROM Items ORDER BY Item_Id DESC");
                GetIDcom = new SqlCommand(getId, con);
                SqlDataReader rdr = GetIDcom.ExecuteReader();
                while (rdr.Read())
                {
                    bnd.item_Id = Convert.ToInt32(rdr["Item_Id"]);
                }
                rdr.Close();
            }


            con.Close();
        }
        private void addhelper()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand addcom;
            foreach (Helper help in Helpers)
            {
                string inserting = ("insert into Helpers(H_Name,H_Rank,H_Side,Type,Comp_Num)values('" + help.H_Name + "','" + help.H_Rank + "','" + help.H_Side + "','" + help.Type + "','" + comp_Code + "')");
                addcom = new SqlCommand(inserting, con);
                addcom.ExecuteNonQuery();

            }
            con.Close();
        }
        public List<string> GetComp_Names()
        {
            con.Open();
            CompanyNames = new List<string>();
            SqlCommand cmd = new SqlCommand("select Comp_Name from Competition", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                CompanyNames.Add(rdr["Comp_Name"].ToString());
            }
            rdr.Close();
            con.Close();
            return CompanyNames;
        }
        public Competition GetCompettion(string Comp_Name)
        {
            viewComp = new Competition();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Competition where Comp_Name = '" + Comp_Name + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                viewComp.comp_Code = (rdr["Comp_Num"].ToString());
                viewComp.comp_Name = (rdr["Comp_Name"].ToString());
                viewComp.Date_Created = (rdr["Date_Created"].ToString());
                // viewComp.comp_Stat = (rdr["Items_Count"].ToString());
                viewComp.comp_Stat = (rdr["comp_Stat"].ToString());
                viewComp.Decision_Num = (rdr["Decision_Num"].ToString());
                viewComp.Decision_Date = (rdr["Decision_Date"].ToString());
                viewComp.Decision = (rdr["Decision"].ToString());
                //   viewComp.comp_Stat = (rdr["comp_sendCode"].ToString());
                viewComp.comp_sendDate = (rdr["comp_sendDate"].ToString());
                viewComp.meetDate = (rdr["meetDate"].ToString());
            }
            rdr.Close();
            con.Close();
            return viewComp;
        }
        public List<Competition> GetAllCompettion()
        {
            AllComps = new List<Competition>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select  Comp_Name , Comp_Num from Competition ", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                viewComp = new Competition();
                viewComp.comp_Code = (rdr["Comp_Num"].ToString());
                viewComp.comp_Name = (rdr["Comp_Name"].ToString());
                AllComps.Add(viewComp);
            }
            rdr.Close();
            con.Close();

            return AllComps;
        }
        public DataTable getReport(string comp_num)
        {
            ReportItem = new item();
            con.Open();
            string Query = "SELECT I.ItemCode,I.REQ_Qunatity,O.Item_Name,O.Note,O.Condition,O.Company_Name,O.Model,O.Manufacturer,O.MadeIn,O.Cost,O.Total_Cost "
                            + "FROM Offer O INNER JOIN Items I "
                            + "ON O.ItemId = I.Item_Id "
                            + "INNER JOIN Competition C "
                            + "ON I.Comp_Num = C.Comp_Num "
                            + "WHERE I.Comp_Num = '" + comp_num + "' "
                            + "ORDER BY O.Total_Cost ASC";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            return dt;
        }

    }
}
