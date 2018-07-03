using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BL
{
    class Branches_Stores
    {
        #region var
        public int User_ID;
        public string Branche_ID;
        public string Branche_Name;
        public int Store_ID;
        public string Store_Name;
        #endregion

       public DataTable Select_All_Branches()
        {
            DAL.DAL DAL = new DAL.DAL();
            
            DataTable Branches = new DataTable();
            Branches = DAL.SelectData("Branches_Select", null);
            
            return Branches;
        }
       public DataTable Select_All_Stores()
       {
           DAL.DAL DAL = new DAL.DAL();
          
           DataTable Stores = new DataTable();
           Stores = DAL.SelectData("Stores_Select", null);

           return Stores;
       }

       public string Insert_Branche()
       {
           DAL.DAL DAL = new DAL.DAL();
           DAL.open();

           SqlParameter[] param=new SqlParameter[3];

           param[0] = new SqlParameter("@Branche_ID", SqlDbType.VarChar,3);
           param[0].Value = Branche_ID;

           param[1]=new SqlParameter("@Branche_Name",SqlDbType.NVarChar,50);
           param[1].Value=Branche_Name;

           param[2] = new SqlParameter("@User_ID", SqlDbType.Int);
           param[2].Value = User_ID;

           return DAL.ExecuteCommand("Branches_Insert", param);

           DAL.Close();
       }
       public string Update_Branche()
       {
           DAL.DAL DAL = new DAL.DAL();
           DAL.open();

           SqlParameter[] param = new SqlParameter[3];

           param[0] = new SqlParameter("@Branche_ID", SqlDbType.VarChar,3);
           param[0].Value = Branche_ID;

           param[1] = new SqlParameter("@Branche_Name", SqlDbType.NVarChar, 50);
           param[1].Value = Branche_Name;

           param[2] = new SqlParameter("@User_ID", SqlDbType.Int);
           param[2].Value = User_ID;

            return DAL.ExecuteCommand("Branches_Update", param);

           DAL.Close();
       }
       public string Delete_Branche()
       {
           DAL.DAL DAL = new DAL.DAL();
           DAL.open();

           SqlParameter[] param = new SqlParameter[1];

           param[0] = new SqlParameter("@Branche_ID", SqlDbType.VarChar, 3);
           param[0].Value = Branche_ID;

            return DAL.ExecuteCommand("Branches_Delete", param);

           DAL.Close();
       }

       public string Insert_Store()
       {
           DAL.DAL DAL = new DAL.DAL();
           DAL.open();

           SqlParameter[] param = new SqlParameter[3];

           param[0] = new SqlParameter("@Store_Name", SqlDbType.NVarChar, 50);
           param[0].Value = Store_Name;

           param[1] = new SqlParameter("@Branche_ID", SqlDbType.VarChar,3);
           param[1].Value = Branche_ID;

           param[2] = new SqlParameter("@User_ID", SqlDbType.Int);
           param[2].Value = User_ID;

            return DAL.ExecuteCommand("Stores_Insert", param);

           DAL.Close();
       }
       public string Update_Store()
       {
           DAL.DAL DAL = new DAL.DAL();
           DAL.open();

           SqlParameter[] param = new SqlParameter[3];

           param[0] = new SqlParameter("@Store_ID", SqlDbType.Int);
           param[0].Value = Store_ID;

           param[1] = new SqlParameter("@Store_Name", SqlDbType.NVarChar, 50);
           param[1].Value = Store_Name;

           param[2] = new SqlParameter("@User_ID", SqlDbType.Int);
           param[2].Value = User_ID;

            return DAL.ExecuteCommand("Stores_Update", param);

           DAL.Close();
       }
       public string Delete_Store()
       {
           DAL.DAL DAL = new DAL.DAL();
           DAL.open();

           SqlParameter[] param = new SqlParameter[1];

           param[0] = new SqlParameter("@Store_ID", SqlDbType.Int);
           param[0].Value = Store_ID;

            return DAL.ExecuteCommand("Stores_Delete", param);

           DAL.Close();
       } 
    }
}
