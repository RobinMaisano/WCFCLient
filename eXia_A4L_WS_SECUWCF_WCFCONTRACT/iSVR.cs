using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT
{
    [ServiceContract]
    public interface iSVR
    {
        [OperationContract]
        STC_MSG m_service(STC_MSG msg);
    }

    [DataContract]
    public struct STC_MSG
    {
        [DataMember]
        public bool op_statut;
        [DataMember]
        public string op_name;
        [DataMember]
        public string op_info;
        [DataMember]
        public string app_name;
        [DataMember]
        public string app_version;
        [DataMember]
        public string app_token;
        [DataMember]
        public string user_login;
        [DataMember]
        public string user_psw;
        [DataMember]
        public string user_token;
        [DataMember]
        public object[] data;
    }
}
