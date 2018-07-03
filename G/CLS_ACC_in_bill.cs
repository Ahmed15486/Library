using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.G
{
    class CLS_ACC_in_bill
    {
        public DataTable ACC_in_bill_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable ACC_in_bill = new DataTable();
            ACC_in_bill = DAL.SelectData("Sp_ACC_in_bill_Select", null);

            return ACC_in_bill;
        }
    }
}
