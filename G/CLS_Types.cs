/*
 * Created by SharpDevelop.
 * User: user
 * Date: 8/8/2015
 * Time: 4:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;

namespace Library.G
{
	/// <summary>
	/// Description of CLS_Types.
	/// </summary>
	public class CLS_Types
	{
        public DataTable Types_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Types = new DataTable();
            Types = DAL.SelectData("Sp_Types_Select", null);

            return Types;
        }
    }
}
