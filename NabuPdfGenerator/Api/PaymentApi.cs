using NabuPdfGenerator.Api.Models;
using System;

namespace NabuPdfGenerator.Api
{
    public class PaymentApi
    {
        private Payment.PaymentPortClient client { get; set; }
        
        public PaymentApi()
        {
            Payment.PaymentPortClient client = new Payment.PaymentPortClient("PaymentPortSoap11");
        }

        public DocumentResponse SendRequest(DocumentRequest documentRequest)
        {

            var response = client.document(new Payment.documentRequest() 
            {
                action = ConvertDocumentAction(documentRequest.Action),
                date = documentRequest.Date,
                document = documentRequest.Document,
                inn = documentRequest.Inn,
                number = documentRequest.Number,
                type = ConvertDocumentType(documentRequest.Type)
            });

            return ConvertDocumentResponse(response);
        }

        public DocumentResponse ConvertDocumentResponse(Payment.documentResponse documentResponse)
        {
            return new DocumentResponse()
            {
                Code        = documentResponse.code,
                Description = documentResponse.description
            };
        }

        public Payment.documentRequestType ConvertDocumentType(DocumentRequestType documentRequestType)
        {
            switch (documentRequestType)
            {
                case DocumentRequestType.Act:
                    return Payment.documentRequestType.act;
                case DocumentRequestType.Sf:
                    return Payment.documentRequestType.sf;
                case DocumentRequestType.Upd:
                    return Payment.documentRequestType.upd;
                case DocumentRequestType.Verification:
                    return Payment.documentRequestType.verification;
                default:
                    throw new Exception("Unknown DocumentRequestType");
            }
        }
        public Payment.documentRequestAction ConvertDocumentAction(DocumentRequestAction documentRequestAction)
        {
            switch (documentRequestAction)
            {
                case DocumentRequestAction.insert:
                    return Payment.documentRequestAction.insert;
                case DocumentRequestAction.update:
                    return Payment.documentRequestAction.update;
                case DocumentRequestAction.delete:
                    return Payment.documentRequestAction.delete;
                default:
                    throw new Exception("Unknown DocumentRequestAction");
            }
        }
    }
}