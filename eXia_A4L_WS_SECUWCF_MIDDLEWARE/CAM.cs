using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT;

namespace eXia_A4L_WS_SECUWCF_MIDDLEWARE.CAM
{
    public class CL_CAM
    {
        private STC_MSG msg;
        private M3_CTRLWF.iExec exec;
        
        public CL_CAM()
        {
            this.msg = new STC_MSG();
        }
        public STC_MSG dispatching(STC_MSG msg)
        {
            this.msg = msg;
            if (msg.app_name == "Appli1")
            {
                if (msg.app_version == "10")
                {
                    if (msg.op_name == "authentifier")
                    {
                        this.exec = new M3_CTRLWF.CTRLWF_Auth_V1();
                        this.msg=this.exec.exec(this.msg);
                    }
                }
            }
            return this.msg;
        }
    }
}

