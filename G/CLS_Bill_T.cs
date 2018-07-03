/*
 * Created by SharpDevelop.
 * User: user
 * Date: 8/9/2015
 * Time: 8:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;

namespace Library.G
{
	/// <summary>
	/// Description of CLS_Bill_T.
	/// </summary>
	public class CLS_Bill_T
	{
		public DataTable Bill_T_Select()
        {
            var DAL = new DAL.DAL();

            var Bill_T = new DataTable();
            Bill_T = DAL.SelectData("Sp_Bill_T_Select", null);

            return Bill_T;
        }
	}
}
