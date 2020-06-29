using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT;

namespace eXia_A4L_WS_SECUWCF_MIDDLEWARE.M4_CAD
{
    class CAD
    {
        private STC_MSG msg;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlConnection cnx;
        private string rq_sql;
        private string cnx_string;
        private DataSet ds;

        public CAD()
        {
            this.msg = new STC_MSG();
            this.cmd = new SqlCommand();
            this.cnx = new SqlConnection();
            this.da  = new SqlDataAdapter();
            this.ds  = new DataSet();

            this.cnx_string = @"Data Source=ROBIN\Robin;Initial Catalog=WCF2;User ID=user;Password=root";
            this.cnx.ConnectionString = this.cnx_string;
            this.cmd.CommandType = CommandType.Text;
            this.cmd.Connection = this.cnx;
        }

        public STC_MSG actionRows(STC_MSG msg)
        {
            return this.msg;
        }

        public STC_MSG getRows(STC_MSG msg)
        {
            this.msg = msg;
            this.rq_sql = (string)msg.data[0];
            this.cmd.CommandText = this.rq_sql;
            this.da.SelectCommand = this.cmd;
            this.da.Fill(this.ds, (string)msg.data[1]);
            this.msg.data = new object[1] { (object)this.ds.Tables[0] };

            return this.msg;
        }
    }

}
