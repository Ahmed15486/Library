using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BL
{
    class CLS_Users
    {
        public DataTable Users_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Users = new DataTable();
            Users = DAL.SelectData("Sp_Users_Select", null);

            return Users;
        }

        public string Users_Insert(

              string Users_Name
            , string Users_Password

            )
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Users_Name", SqlDbType.NVarChar, 50);
            param[0].Value = Users_Name;

            param[1] = new SqlParameter("@Users_Password", SqlDbType.NVarChar, 50);
            param[1].Value = Users_Password;

            string F;
            F = DAL.ExecuteCommand("Sp_Users_Insert", param);

            DAL.Close();

            return F;
        }

        public string Users_Update(

              int Users_ID
            , string Users_Name
            , string Users_Password

            )
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Users_ID", SqlDbType.Int);
            param[0].Value = Users_ID;

            param[1] = new SqlParameter("@Users_Name", SqlDbType.NVarChar, 50);
            param[1].Value = Users_Name;

            param[2] = new SqlParameter("@Users_Password", SqlDbType.NVarChar, 50);
            param[2].Value = Users_Password;

            string F;
            F = DAL.ExecuteCommand("Sp_Users_Update", param);

            DAL.Close();

            return F;
        }

        public string Users_Delete(string ACC_ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Users_ID", SqlDbType.NVarChar, 50);
            param[0].Value = ACC_ID;

            string F;
            F = DAL.ExecuteCommand("Sp_Users_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
