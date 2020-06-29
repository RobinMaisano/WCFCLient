using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT;
using System.Security.Permissions;
namespace eXia_A4L_WS_SECUWCF_MIDDLEWARE
{
    public class SVC : iSVR
    {
        private STC_MSG msg;
        private object service;

        public SVC()
        {
            this.msg = new STC_MSG();
            this.service = null;
        }
        [PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Utilisateurs")]
        public STC_MSG m_service(STC_MSG msg)
        {
            int i;

            Console.ForegroundColor = ConsoleColor.Blue;

            OperationContext ctx = OperationContext.Current;
            MessageProperties msgP = ctx.IncomingMessageProperties;
            RemoteEndpointMessageProperty remP = msgP[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            ServiceSecurityContext ssc = ServiceSecurityContext.Current;

            Console.WriteLine("Demande entrante : " + "<" + ssc.WindowsIdentity.Name + ">" + ssc.WindowsIdentity.User);
            Console.WriteLine("Adresse cliente : " + remP.Address);
            Console.WriteLine("Port client : " + remP.Port);
            Console.WriteLine("Détail du message ->");
            Console.WriteLine("Application cliente : " + msg.app_name);
            Console.WriteLine("Application token : " + msg.app_token);
            Console.WriteLine("Application version : " + msg.app_version);
            Console.WriteLine("Opération info : " + msg.op_info);
            Console.WriteLine("Opération nom : " + msg.op_name);
            Console.WriteLine("Opération statut : " + msg.op_statut);
            Console.WriteLine("Utilisteur login : " + msg.user_login);
            Console.WriteLine("Utilisteur password : " + msg.user_psw);
            Console.WriteLine("Utilisteur token : " + msg.user_token);

            if (msg.data != null)
            {
                i = msg.data.Length;
                Console.WriteLine("Le message contient {0} donnée(s) spécifique(s)", i + 1);
            }
            else
            {
                Console.WriteLine("Le message ne contient pas de données spécifiques");
            }
            Console.WriteLine("");
            if (msg.app_token == "12345")
            {
                Console.WriteLine("App Token:" + msg.app_token);
                if (msg.op_name == "authentifier")
                {
                    Console.WriteLine("Operation Name:" + msg.op_name);
                    this.msg = msg;
                    this.service = new PCS_personne();
                    this.msg = ((PCS_personne)this.service).m_authentifier(this.msg);
                }
            }
            else
            {
                this.msg.app_name = "";
                this.msg.app_token = "";
                this.msg.app_version = "";
                this.msg.data = null;
                this.msg.op_info = "Cette application n'est pas prise en charge par la plateforme.";
                this.msg.op_name = "";
                this.msg.op_statut = false;
                this.msg.user_login = "";
                this.msg.user_psw = "";
                this.msg.user_token = "";
            }
            return this.msg;
        }
    }
}

