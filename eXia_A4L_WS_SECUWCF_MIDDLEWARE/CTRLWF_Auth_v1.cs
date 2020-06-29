using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT;
using eXia_A4L_WS_SECUWCF_MIDDLEWARE.M32_CMPGE;

namespace eXia_A4L_WS_SECUWCF_MIDDLEWARE.M3_CTRLWF
{
    public class CTRLWF_Auth_V1 : iExec
    {
        private STC_MSG msg;
        private CMPGE_people sql;
        private M4_CAD.CAD cad;

        public CTRLWF_Auth_V1()
        {
            this.msg = new STC_MSG();
            this.cad = new M4_CAD.CAD();
        }
        public STC_MSG exec(STC_MSG msg)
        {
            // L'orchestration et la gestion transactionelle doivent être mise en oeuvre ici.
            int count;

            this.msg = msg;
            count = -1;

            this.sql = new CMPGE_people();
            this.msg = this.sql.selectByLoginPsw(this.msg);
            this.msg.data = new object[2] { this.msg.data[0], (object)"resultat" };
            this.msg = this.cad.getRows(this.msg);
            count = ((System.Data.DataTable)this.msg.data[0]).Rows.Count;

            if (count == 1)
            {
                this.msg.op_info = "succes";
                this.msg.op_statut = true;
                this.msg.user_token = "12345";

            }
            else
            {
                this.msg.op_info = "fail";
                this.msg.op_statut = false;
            }

            this.msg.app_name = null;
            this.msg.app_token = null;
            this.msg.app_version = null;
            this.msg.data = null;
            this.msg.op_name = null;
            this.msg.user_login = null;
            this.msg.user_psw = null;

            return this.msg;
        }
    }
}

