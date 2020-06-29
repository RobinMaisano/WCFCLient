using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware;
using eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT;

namespace eXia_A4L_WS_SECUWCF_CLIENT.M1_CUT
{
    public class CUT_AUTH
    {
        private MSG msg;
        private M2_CUC.CUC cuc;

        public CUT_AUTH()
        {
            this.cuc = new M2_CUC.CUC();
        }

        public MSG m_auhentifier(MSG msg)
        {
            this.msg = msg;
            //this.msg.operationName = "Login";
            this.msg = this.cuc.m_sendSVER(this.msg);

            return this.msg;
        }
    }
}
