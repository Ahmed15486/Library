using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Library.BL
{
    class BL
    {
        public struct Users
        {
            #region Var
            public int ID;
            public string Name;
            public string Password;
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable Users = new DataTable();
                Users = dal.Selectrep("Select * From Users");

                return Users;
            }
            public string Insert()
            {
                DAL.DAL dal = new DAL.DAL();


                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[0].Value = Name;

                param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
                param[1].Value = Password;

                string F;
                F = dal.ExecuteCommand("Insert Into Users (Name,Password) Values (@Name , @Password)", param);

                return F;
            }
            public string Update()
            {
                DAL.DAL dal = new DAL.DAL();

                SqlParameter[] param = new SqlParameter[3];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[1].Value = Name;

                param[2] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
                param[2].Value = Password;

                string F;
                F = dal.ExecuteCommand("Update Users Set Name = @Name , Password = @Password Where ID = @ID", param);
                return F;
            }
            public string Delete()
            {
                DAL.DAL dal = new DAL.DAL();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                string f;
                f = dal.ExecuteCommand("delete from users where id = @ID", param);
                return f;
            }
        }
    }
}
