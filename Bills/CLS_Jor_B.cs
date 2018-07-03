/*
 * Created by SharpDevelop.
 * User: user
 * Date: 8/9/2015
 * Time: 6:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.SqlClient;

namespace Library.Bills
{
	/// <summary>
	/// Description of CLS_Jor_B.
	/// </summary>
	public class CLS_Jor_B
	{
		
public DataTable Jor_B_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("Sp_Jor_B_Select", null);

            return dt; 
		}

 public string Jor_B_Insert(
         string Branche
        ,int Bill_Type
        , int  B_Type
       , int User_ID
       , DataTable dt_Jor_B
        )
            {
                DAL.DAL DAL = new DAL.DAL();
                DAL.open();

                SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Branche", SqlDbType.VarChar, 3);
                param[0].Value = Branche;

                param[1] = new SqlParameter("@Bill_Type", SqlDbType.Int);
                param[1].Value = Bill_Type;

                param[2] = new SqlParameter("@B_Type", SqlDbType.Int);
                param[2].Value = B_Type;

                param[3] = new SqlParameter("@User_ID", SqlDbType.Int);
                param[3].Value = User_ID;

                param[4] = new SqlParameter("@dt_Jor_B", SqlDbType.Structured);
                param[4].Value = dt_Jor_B;

                string F;
                F = DAL.ExecuteCommand("Sp_Jor_B_Insert", param);

                DAL.Close();

                return F;
            }
	}
}
