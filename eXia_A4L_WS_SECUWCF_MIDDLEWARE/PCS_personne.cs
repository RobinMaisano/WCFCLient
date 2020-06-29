using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT;

namespace eXia_A4L_WS_SECUWCF_MIDDLEWARE
{
    public class PCS_personne
    {
        private STC_MSG msg;
        private CAM.CL_CAM cam;

        public PCS_personne()
        {
            this.msg = new STC_MSG();
            this.cam = new CAM.CL_CAM();
        }
        public STC_MSG m_authentifier(STC_MSG msg)
        {
            this.msg = msg;
            this.msg = this.cam.dispatching(this.msg);

            return this.msg;
        }
        public STC_MSG m_doc_authentifier(STC_MSG msg)
        {
            /*Construction de la documentation pour le service
             *  this.msg.app_name = "";
                this.msg.app_token = "";
                this.msg.app_version = "";
                this.msg.data = null;
                this.msg.op_info = "............................................";
                this.msg.op_name = "";
                this.msg.op_statut = true;
                this.msg.user_login="";
                this.msg.user_psw="";
                this.msg.user_token="";
            
             */
            return this.msg;
        }
    }
}

