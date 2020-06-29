using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT;

namespace eXia_A4L_WS_SECUWCF_MIDDLEWARE.M32_CMPGE
{
    class CMPGE_people
    {
        private STC_MSG msg;

        private string rq_sql;
        private int id;
        private string nom;
        private string prenom;
        private string psw;
        private string log;

        public CMPGE_people()
        {
            this.msg = new STC_MSG();
        }
        public STC_MSG selectByLoginPsw(STC_MSG msg)
        {
            this.msg = msg;
            this.log = msg.user_login;
            this.psw = msg.user_psw;

            rq_sql = "SELECT id, nom, prenom FROM tb_personne WHERE (login = '" + log + "') AND (psw = '" + psw + "');";

            this.msg.data = new object[1] { (object)rq_sql };

            return this.msg;
        }
    }
}

