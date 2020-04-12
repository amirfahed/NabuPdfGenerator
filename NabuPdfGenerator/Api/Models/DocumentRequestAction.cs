using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NabuPdfGenerator.Api.Models
{
    public enum DocumentRequestAction
    {
        insert = 0,

        /// <remarks/>
        update = 1,

        /// <remarks/>
        delete = 2,
    }
}