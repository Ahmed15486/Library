using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Rep
{
    class CLS_ACC_REP
    {
        public struct ACC_ST
        {
            public string aCC_ID;
            public string date_From;
            public string date_To;
            public string Branche;
            public string CC1;
            public string CC2;

            public DataTable Rep_ACC_St_Select()
            {
                string where = "\r\nWHERE ";
                string where_open = "\r\nWHERE ";
                where += (aCC_ID != "-1") ? "ACC_ID = '" + aCC_ID + "'" : "";
                where_open += (aCC_ID != "-1") ? "ACC_ID = '" + aCC_ID + "'" : "";
                where += (date_From != "01/01/1753") ? " and Jor_Date >= '" + date_From + "'" : "";
                where_open += (date_From != "01/01/1753") ? " and Jor_Date < '" + date_From + "'" : " and Jor_Date < '01/01/1753'";
                where += (date_To != "12/31/9998") ? " and Jor_Date <= '" + date_To + "'" : "";
                where += (Branche != "-1") ? " and Branche = '" + Branche + "'" : "";
                where_open += (Branche != "-1") ? " and Branche = '" + Branche + "'" : "";
                where += (CC1 != "-1") ? " and CC1 LIKE '" + CC1 + "%'": "";
                where_open += (CC1 != "-1") ? " and CC1 LIKE '" + CC1 + "%'" : "";
                where += (CC2 != "-1") ? " and CC2 LIKE '" + CC2 + "%'" : "";
                where_open += (CC2 != "-1") ? " and CC2 LIKE '" + CC2 + "&'" : "";

                if (where == "\r\nWHERE ") { where = ""; }

                string open = "SELECT "
+ "sum([Debit]) as Debit, "
+ "sum([Credit]) as Credit,"
+ "'رصيد إفتتاحي' as Notes,"
+ "null as Jor_ID,"
+ "null as Jor_Date,"
+ "null as Bill_T_Name,"
+ "null as Ref_No"
+ " FROM[dbo].[ACC_St]"
+  where_open + " union all ";

                string s = open + "SELECT [Debit]"
      + ",[Credit]"
      + ",[Notes]"
      + ",[Jor_ID]"
      + ",[Jor_Date]"
      + ",[Bill_T_Name]"
      + ",[Ref_No]"
+ " FROM[dbo].[ACC_St]" + where;

                DAL.DAL DAL = new DAL.DAL();
                DataTable Rep_ACC_St = new DataTable();

                Rep_ACC_St = DAL.Selectrep(s);

                return Rep_ACC_St;
            }
        }
        public struct TB
        {
            public string aCC_ID;
            public string date_From;
            public string date_To;
            public string Branche;
            public string CC1;
            public string CC2;
            public string Level;

            public DataTable View_TB_Select()
            {
                string where = "WHERE ";
                where += (aCC_ID != "-1") ? "Parent_ID = '" + aCC_ID + "' " : "";
                where += (date_From != "01/01/1753") ? "and Jor_Date >= '" + date_From + "' " : "";
                where += (date_To != "12/31/9998") ? "and Jor_Date <= '" + date_To + "' " : "";
                where += (Branche != "-1") ? "and (Branche = '" + Branche + "' or Branche is null)" : "";
                where += (CC1 != "-1") ? "and CC1 LIKE '" + CC1 + "%'" : "";
                where += (CC2 != "-1") ? "and CC2 LIKE '" + CC2 + "%'" : "";
                where += "and ACC_level <= " + Level ;

                // if after Where is "and"
                if( where.Length >= 9)
                {
                    if (where.Substring(6,3) == "and")
                    {
                        where = where.Substring(0, 6) + where.Substring(9);
                    }
                }

                if (where == "WHERE ")
                { where = ""; }

                string s = "SELECT "
       + "[ACC_ID]"
       + ",[ACC_Name]"
       + ", isnull(sum(CASE WHEN Jor_Date < '" + date_From + "' or Is_Parent = 1 THEN[Debit] ELSE 0 END),0) AS Open_Debit"
       + ", isnull(sum(CASE WHEN Jor_Date < '" + date_From + "' or Is_Parent = 1 THEN[Credit] ELSE 0 END),0) AS Open_Credit"
       + ", isnull(sum(CASE WHEN Jor_Date >= '" + date_From + "' or Is_Parent = 1 THEN[Debit] ELSE 0 END),0) AS Debit"
       + ", isnull(sum(CASE WHEN Jor_Date >= '" + date_From + "' or Is_Parent = 1 THEN[Credit] ELSE 0 END),0) AS Credit,"
       + " max(CAST(Is_Parent as int)) AS Parent"
       + " FROM TB_Select2() " + where
       + " group by ACC_ID,ACC_Name "
       + " order by acc_id ";

                DAL.DAL DAL = new DAL.DAL();
                DataTable dt = new DataTable();
                DataTable dt_TB = new DataTable();
                dt = DAL.Selectrep(s);
                dt_TB = dt.Clone();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(Convert.ToBoolean(dt.Rows[i]["Parent"]) == true)
                    {
                        string parent_id = dt.Rows[i]["acc_id"].ToString();
                        dt_TB.Rows.Add(dt.Rows[i].ItemArray);
                        dt.Rows.RemoveAt(i);
                        i--;
                        for (int p = (i<0)?0:i; p < dt.Rows.Count - 1; p++)
                        {
                            if (dt.Rows[p]["acc_id"].ToString().StartsWith(parent_id))
                            {
                                dt_TB.Rows.Add(dt.Rows[p].ItemArray);
                                dt.Rows.RemoveAt(p);
                                p--;
                            }
                            else
                            {

                            }
                        }
                    }
                }

                return dt_TB;
            }
        }
        public struct IL
        {
            public string date_From;
            public string date_To;
            public string Branche;
            public string CC1;
            public string CC2;

            public DataTable View_IL_Select()
            {
                string where = "WHERE Sheet = 1 ";
                where += (date_From != "01/01/1753") ? "and Jor_Date >= '" + date_From + "' " : "";
                where += (date_To != "12/31/9998") ? "and Jor_Date <= '" + date_To + "' " : "";
                where += (Branche != "-1") ? "and Branche = '" + Branche + "' " : "";
                where += (CC1 != "-1") ? "and CC1 = '" + CC1 + "' " : "";
                where += (CC2 != "-1") ? "and CC2 = '" + CC2 + "' " : "";


                string s = "SELECT "
       + " [ACC_ID]"
       + ",[ACC_Name]"
       + ", sum([Debit]) AS Debit"
       + ", sum([Credit] ) AS Credit"
       + ", MAX(Sheet_Parent) AS Sheet_Parent"

+ " FROM[dbo].[ACC_St] " + where
+ " group by ACC_ID,ACC_Name ";

                DAL.DAL DAL = new DAL.DAL();
                DataTable Rep_IL = new DataTable();

                Rep_IL = DAL.Selectrep(s);

                return Rep_IL;
            }
        }
        public struct BS
        {
            public string date_From;
            public string date_To;
            public string Branche;
            public string CC1;
            public string CC2;

            public DataTable View_BS_Select()
            {
                string where = "WHERE Sheet = 0 ";
                where += (date_From != "01/01/1753") ? "and Jor_Date >= '" + date_From + "' " : "";
                where += (date_To != "12/31/9998") ? "and Jor_Date <= '" + date_To + "' " : "";
                where += (Branche != "-1") ? "and Branche = '" + Branche + "' " : "";
                where += (CC1 != "-1") ? "and CC1 = '" + CC1 + "' " : "";
                where += (CC2 != "-1") ? "and CC2 = '" + CC2 + "' " : "";


                string s = "SELECT "
       + " [ACC_ID]"
       + ",[ACC_Name]"
       + ", sum([Debit]) AS Debit"
       + ", sum([Credit] ) AS Credit"
       + ", MAX(Sheet_Parent) AS Sheet_Parent"

+ " FROM[dbo].[ACC_St] " + where
+ " group by ACC_ID,ACC_Name ";

                DAL.DAL DAL = new DAL.DAL();
                DataTable Rep_BS = new DataTable();

                Rep_BS = DAL.Selectrep(s);

                return Rep_BS;
            }
        }
    }
}
