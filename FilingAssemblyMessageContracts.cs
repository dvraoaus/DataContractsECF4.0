/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    FilingAssemblyMessageContracts.cs
	'   Created Date:   04/1/2009
	'   Description:    Message Contracts for Filing Assembly. In order to match ECF wsdls we need more control 
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
	'=======================================================================
    '   Rao     06/23/2012       NotifyFilingReviewCompleteRequest Added Property ClientIP
    '   Rao     06/19/2012       NotifyFilingReviewCompleteRequest Added Property FilingId
	'=======================================================================
	*/

using Oasis.LegalXml.CourtFiling.v40.Filing;
using Oasis.LegalXml.CourtFiling.v40.Message;
using Oasis.LegalXml.CourtFiling.v40.Payment;

namespace Oasis.LegalXml.CourtFiling.v40.WebServiceMessagingProfile
{



    #region NotifyFilingReviewComplete Operation
    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "NotifyFilingReviewCompleteResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "NotifyFilingReviewCompleteResponse")]
    public partial class NotifyFilingReviewCompleteResponse
    {

        /// <remarks/>
        private MessageReceiptMessageType messageReceiptMessage;

        public NotifyFilingReviewCompleteResponse()
        {
        }

        public NotifyFilingReviewCompleteResponse(MessageReceiptMessageType messageReceiptMessage)
        {
            this.messageReceiptMessage = messageReceiptMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "MessageReceiptMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "MessageReceiptMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:MessageReceiptMessage-4.0")]
        public MessageReceiptMessageType MessageReceiptMessage
        {
            get
            {
                return this.messageReceiptMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("MessageReceiptMessage");
                }
                if ((this.messageReceiptMessage != value))
                {
                    this.messageReceiptMessage = value;
                }
            }
        }
    }
    

    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "NotifyFilingReviewCompleteRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "NotifyFilingReviewCompleteRequest")]
    public partial class NotifyFilingReviewCompleteRequest
    {

        private NotifyFilingReviewCompleteMessageType notifyFilingReviewCompleteMessage;

        public NotifyFilingReviewCompleteRequest()
        {
        }

        public NotifyFilingReviewCompleteRequest(NotifyFilingReviewCompleteMessageType notifyFilingReviewCompleteMessage)
        {
            this.notifyFilingReviewCompleteMessage = notifyFilingReviewCompleteMessage;
        }

        [System.ServiceModel.MessageBodyMember
            (
                Name = "NotifyFilingReviewCompleteMessage", 
                Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0"
            )
        ]
        [System.Xml.Serialization.XmlElementAttribute
            (
                ElementName = "NotifyFilingReviewCompleteMessage",
                Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0"
                )
        ]
        public NotifyFilingReviewCompleteMessageType NotifyFilingReviewCompleteMessage
        {
            get
            {
                return this.notifyFilingReviewCompleteMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("NotifyFilingReviewCompleteMessage");
                }
                if ((this.notifyFilingReviewCompleteMessage != value))
                {
                    this.notifyFilingReviewCompleteMessage = value;
                }
            }
        }

        [System.Xml.Serialization.XmlIgnore()]
        public long FilingId
        {
            get
            {
                return 
                (
                    this.notifyFilingReviewCompleteMessage != null &&
                    this.notifyFilingReviewCompleteMessage.ReviewFilingCallbackMessage != null ?
                    this.notifyFilingReviewCompleteMessage.ReviewFilingCallbackMessage.FilingId :
                    -1
                 );
            }
        }

        [System.Xml.Serialization.XmlIgnore()]
        public string ClientIP
        {
            get
            {
                return
                (
                    this.notifyFilingReviewCompleteMessage != null &&
                    this.notifyFilingReviewCompleteMessage.ReviewFilingCallbackMessage != null ?
                    this.notifyFilingReviewCompleteMessage.ReviewFilingCallbackMessage.ClientIP :
                    "NA"
                 );
            }
        }

    }



    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "NotifyFilingReviewCompleteMessageType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "NotifyFilingReviewCompleteMessageTypeMessage")]
    public class NotifyFilingReviewCompleteMessageType
    {
        private ReviewFilingCallbackMessageType reviewFilingCallbackMessage;
        private PaymentReceiptMessage paymentReceiptMessage;

        // No Need for Handling Name Spaces as each individual fields are handling their own namespaces
        public NotifyFilingReviewCompleteMessageType()
        {
            
        }

        public NotifyFilingReviewCompleteMessageType
            (
            ReviewFilingCallbackMessageType reviewFilingCallbackMessage, 
            PaymentReceiptMessage paymentReceiptMessage
            )
        {
            this.reviewFilingCallbackMessage = reviewFilingCallbackMessage;
            this.paymentReceiptMessage = paymentReceiptMessage;
        }


        [System.Xml.Serialization.XmlElementAttribute
            (
                ElementName = "ReviewFilingCallbackMessage", 
                Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ReviewFilingCallbackMessage-4.0", 
                Order = 0
            )
        ]
        public ReviewFilingCallbackMessageType ReviewFilingCallbackMessage
        {
            get
            {
                return this.reviewFilingCallbackMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("ReviewFilingCallbackMessage");
                }
                if ((this.reviewFilingCallbackMessage != value))
                {
                    this.reviewFilingCallbackMessage = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute
            (
            ElementName = "PaymentReceiptMessage", 
            Order = 1, 
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:PaymentReceiptMessage-4.0")
        ]
        public PaymentReceiptMessage PaymentReceiptMessage
        {
            get
            {
                return this.paymentReceiptMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("PaymentReceiptMessage");
                }
                if ((this.paymentReceiptMessage != value))
                {
                    this.paymentReceiptMessage = value;
                }
            }
        }


    }


    #endregion NotifyFilingReviewComplete Operation

    
}
