using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT;
using eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware;
namespace eXia_A4L_WS_SECUWCF_CLIENT.M2_CUC
{
    public class CUC
    {
        private string _tokenUser;
        private MSG msg;
        private IServerEntryPoint serverEntryPoint;

        public CUC()
        {
            _tokenUser = null;
            this.serverEntryPoint = new ServerEntryPointClient();
        }

        public MSG m_sendSVER(MSG msg)
        {
            this.msg = msg;
            this.msg.tokenApp = "4ppT0k3n";
            this.msg.appVersion = "V1";
            this.msg.info = "Demande de service de l'application 1 de version 1.0";
            this.msg.tokenUser = _tokenUser;
            //this.msg.tokenUser = "123456";

            try
            {
                this.serverEntryPoint = new ServerEntryPointClient();
                this.msg = this.serverEntryPoint.m_service(this.msg);

                if (this.msg.operationName == "Register" || this.msg.operationName == "Login")
                    _tokenUser = this.msg.tokenUser;
            }
            catch (Exception ex)
            {
                this.msg.info = ex.Message;
            }

            return this.msg;
        }
    }
}
