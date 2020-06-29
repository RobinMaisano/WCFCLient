using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT;

namespace eXia_A4L_WS_SECUWCF_MIDDLEWARE.M3_CTRLWF
{
    interface iExec
    {
        STC_MSG exec(STC_MSG msg);
    }
}
