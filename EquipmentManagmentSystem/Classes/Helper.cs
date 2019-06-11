using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EquipmentManagmentSystem.Classes
{

    public class Helper
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-9QGGOV2\\SQLEXPRESS;Initial Catalog=EquipmentManagment.02;Integrated Security=True");
      //  public SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|EquipmentManagment.02.mdf;Integrated Security = True");
        //public SqlConnection con = new SqlConnection("Data Source=AMRMOATAZ\\AMRMOATAZ;Initial Catalog=EquipmentManagment.02;Integrated Security=True");
        public int Helper_Id { get; set; }
        public string H_Name { get; set; }
        public string H_Rank { get; set; }
        public string H_Side { get; set; }
        public string Type { get; set; }
        public string codeIdentifer { get; set; }
        public Competition competition { get; set; }


        public void Delete_Helper(string HelperName,string comp_num)
        {
            con.Open();
            SqlCommand delcom = new SqlCommand("delete from Helpers where H_Name = '" + HelperName + "'and Comp_Num = '" + comp_num + "'", con);
            delcom.ExecuteNonQuery();
            con.Close();
        }
        public void addhelper(string CompNum)
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand addcom;
                string inserting = ("insert into Helpers(H_Name,H_Rank,H_Side,Type,Comp_Num)values('" + H_Name + "','" + H_Rank + "','" + H_Side + "','" + Type + "','" + CompNum + "')");
                addcom = new SqlCommand(inserting, con);
                addcom.ExecuteNonQuery();
            con.Close();
        }
        public List<string> GetAllHelpers(string Comp_Num)
        {

            List<string> helpers = new List<string>();
            con.Open();
            SqlCommand readCmd = new SqlCommand("select H_Name from Helpers where Comp_Num = '" + Comp_Num + "'", con);
            SqlDataReader rdr = readCmd.ExecuteReader();
            while (rdr.Read())
            {
                helpers.Add(rdr["H_Name"].ToString());
            }
            rdr.Close();
            con.Close();
            return helpers;
        }
        public void getHelper(string helperName,string compNum)
        {
            con.Open();
            SqlCommand readCmd = new SqlCommand("select * from Helpers where H_Name = '" + helperName + "' and  Comp_Num = '" + compNum + "'", con);
            SqlDataReader rdr = readCmd.ExecuteReader();
            while (rdr.Read())
            {
                Helper_Id = Convert.ToInt32(rdr["Helper_Id"]);
                H_Name = (rdr["H_Name"].ToString());
                H_Rank = (rdr["H_Rank"].ToString());
                H_Side = (rdr["H_Side"].ToString());
                Type = (rdr["Type"].ToString());
            }
            rdr.Close();
            con.Close();
        }
        public void Update_Helper(string Name,string comp_num)
        {
            con.Open();
            SqlCommand update = new SqlCommand("update Helpers set H_Name='" + H_Name + "',H_Rank = '" + H_Rank + "',H_Side = '" + H_Side + "',Type='" + Type + "' where H_Name = '" + Name + "'  and Comp_Num = '" + comp_num + "' ", con);
            update.ExecuteNonQuery();
            con.Close();
        }
       
    }


}
