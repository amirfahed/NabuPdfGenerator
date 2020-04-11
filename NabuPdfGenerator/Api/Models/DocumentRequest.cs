using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NabuPdfGenerator.Api
{
    public class DocumentRequest
    {
        public DocumentRequestType Type { get; set; }

        public string Date { get; set; }

        public string Inn { get; set; }

        public string Number { get; set; }

        public DocumentRequestAction Action { get; set; }

        public string Document { get; set; }
    }
}