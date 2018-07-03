using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.G
{
    class CLS_Side
    {
        public DataTable Side_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Side = new DataTable();
            Side = DAL.SelectData("Sp_Side_Select", null);

            return Side;
        }
    }
}
