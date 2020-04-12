using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NabuPdfGenerator.Api.Models
{
    public enum DocumentRequestType
    {
        Act = 0,

        /// <remarks/>
        Sf = 1,

        /// <remarks/>
        Upd = 2,

        /// <remarks/>
        Verification = 3

    }
}