using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.OracleClient;


namespace CollegeOfficeAutomation
{
    public class dbConnect
    {

        public OracleConnection connFunc()
        {

            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = "Data Source=XE;User ID=system;Password=nixon1333;Unicode=True";
            return conn;

        }

    }
}
