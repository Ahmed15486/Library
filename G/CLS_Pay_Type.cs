using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.G
{
    class CLS_Pay_Type
    {
        public DataTable Pay_Type_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Value = new DataTable();
            Value = DAL.SelectData("Sp_Pay_Type_Select", null);

            return Value;
        }
    }
}
