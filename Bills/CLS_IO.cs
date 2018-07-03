using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bills
{
    class CLS_IO
    {
        public DataTable IO_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable IO = new DataTable();
            IO = DAL.SelectData("Sp_IO_Select",null);

            return IO;
        }    
    }
}
