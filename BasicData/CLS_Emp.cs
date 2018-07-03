using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BL
{
    class CLS_Emp
    {
        public DataTable Emp_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Emp = new DataTable();
            Emp = DAL.SelectData("Sp_Emp_Select", null);

            return Emp;
        }

        public string Emp_Insert(
             string Emp_Name
           , int Job_ID
           , int Emp_Phone
           , int Emp_Mobile
           , string Emp_Address
           , int Emp_Personal_ID
           , decimal Emp_Basic_Salary
           , string Emp_Notes
           , int User_ID
           )
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@Emp_Name", SqlDbType.NVarChar, 50);
            param[0].Value = Emp_Name;

            param[1] = new SqlParameter("@Job_ID", SqlDbType.Int);
            param[1].Value = Job_ID;

            param[2] = new SqlParameter("@Emp_Phone", SqlDbType.Int);
            param[2].Value = Emp_Phone;

            param[3] = new SqlParameter("@Emp_Mobile", SqlDbType.Int);
            param[3].Value = Emp_Mobile;

            param[4] = new SqlParameter("@Emp_Address", SqlDbType.NVarChar, 50);
            param[4].Value = Emp_Address;

            param[5] = new SqlParameter("@Emp_Personal_ID", SqlDbType.Int);
            param[5].Value = Emp_Personal_ID;

            param[6] = new SqlParameter("@Emp_Basic_Salary", SqlDbType.Decimal);
            param[6].Value = Emp_Personal_ID;

            param[7] = new SqlParameter("@Emp_Notes", SqlDbType.NVarChar);
            param[7].Value = Emp_Notes;

            param[8] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[8].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("Sp_Emp_Insert", param);

            DAL.Close();

            return F;
        }

        public string Emp_Update(
             int Emp_ID
           , string Emp_Name
           , int Job_ID
           , int Emp_Phone
           , int Emp_Mobile
           , string Emp_Address
           , int Emp_Personal_ID
           , decimal Emp_Basic_Salary
           , string Emp_Notes
           , int User_ID
           )
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@Emp_ID", SqlDbType.Int);
            param[0].Value = Emp_ID;

            param[1] = new SqlParameter("@Emp_Name", SqlDbType.NVarChar, 50);
            param[1].Value = Emp_Name;

            param[2] = new SqlParameter("@Job_ID", SqlDbType.Int);
            param[2].Value = Job_ID;

            param[3] = new SqlParameter("@Emp_Phone", SqlDbType.Int);
            param[3].Value = Emp_Phone;

            param[4] = new SqlParameter("@Emp_Mobile", SqlDbType.Int);
            param[4].Value = Emp_Mobile;

            param[5] = new SqlParameter("@Emp_Address", SqlDbType.NVarChar, 50);
            param[5].Value = Emp_Address;

            param[6] = new SqlParameter("@Emp_Personal_ID", SqlDbType.Int);
            param[6].Value = Emp_Personal_ID;

            param[7] = new SqlParameter("@Emp_Basic_Salary", SqlDbType.Decimal);
            param[7].Value = Emp_Personal_ID;

            param[8] = new SqlParameter("@Emp_Notes", SqlDbType.NVarChar);
            param[8].Value = Emp_Notes;

            param[9] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[9].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("Sp_Emp_Update", param);

            DAL.Close();

            return F;
        }

        public string Emp_Delete(string Emp_ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Emp_ID", SqlDbType.Int);
            param[0].Value = Emp_ID;

            string F;
            F = DAL.ExecuteCommand("Sp_Emp_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
