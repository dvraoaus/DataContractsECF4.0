/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    FilingReviewMessageContracts.cs
	'   Created Date:   04/1/2009
	'   Description:    Message Contracts for Filing Review Operations. In order to match ECF wsdls we need more control 
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
	'=======================================================================
    '   Rao     04/25/2012       Adding MessageContracts for NotifyFilingStatusChange Operation
    '   Rao     04/24/2012       Moved AddNameSpaces to EcfHelper
	'=======================================================================
	*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oasis.LegalXml.CourtFiling.v40.Core;
using Oasis.LegalXml.CourtFiling.v40.Ecf;
using Oasis.LegalXml.CourtFiling.v40.Payment;
using Oasis.LegalXml.CourtFiling.v40.Message;
using Oasis.LegalXml.CourtFiling.v40.Docketing;
using Oasis.LegalXml.CourtFiling.v40.Filing;

namespace Oasis.LegalXml.CourtFiling.v40.WebServiceMessagingProfile
{

    #region ReviewFiling Operation
    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "ReviewFilingResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "ReviewFilingResponse")]
    public partial class ReviewFilingResponse
    {

        /// <remarks/>
        private MessageReceiptMessageType messageReceiptMessage;

        public ReviewFilingResponse()
        {
        }

        public ReviewFilingResponse(MessageReceiptMessageType messageReceiptMessage)
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "ReviewFilingRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "ReviewFilingRequest")]
    public partial class ReviewFilingRequest
    {


        private ReviewFilingRequestMessageType reviewFilingRequestMessage;

        public ReviewFilingRequest()
        {
        }

        public ReviewFilingRequest(ReviewFilingRequestMessageType reviewFilingRequestMessage)
        {
            this.reviewFilingRequestMessage = reviewFilingRequestMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "ReviewFilingRequestMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ReviewFilingRequestMessage")]
        public ReviewFilingRequestMessageType ReviewFilingRequestMessage
        {
            get
            {
                return this.reviewFilingRequestMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("ReviewFilingRequestMessage");
                }
                if ((this.reviewFilingRequestMessage != value))
                {
                    this.reviewFilingRequestMessage = value;
                }
            }
        }
    }


    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "ReviewFilingRequestMessageType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "ReviewFilingRequestMessage")]
    public partial class ReviewFilingRequestMessageType : ElectronicFilingMessageType
    {
        private CoreFilingMessageType coreFilingMessage;
        private PaymentMessageType paymentMessage;

        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces = new System.Xml.Serialization.XmlSerializerNamespaces(); 

        public ReviewFilingRequestMessageType()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public ReviewFilingRequestMessageType(CoreFilingMessageType coreFilingMessage, PaymentMessageType paymentMessage)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.coreFilingMessage = coreFilingMessage;
            this.paymentMessage = paymentMessage;
        }


        [System.Xml.Serialization.XmlElementAttribute(ElementName = "CoreFilingMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CoreFilingMessage-4.0", Order = 0)]
        public CoreFilingMessageType CoreFilingMessage
        {
            get
            {
                return this.coreFilingMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CoreFilingMessage");
                }
                if ((this.coreFilingMessage != value))
                {
                    this.coreFilingMessage = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "PaymentMessage", Order = 2, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:PaymentMessage-4.0")]
        public PaymentMessageType PaymentMessage
        {
            get
            {
                return this.paymentMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("PaymentMessage");
                }
                if ((this.paymentMessage != value))
                {
                    this.paymentMessage = value;
                }
            }
        }

    }
    #endregion ReviewFiling Operation

    #region NotifyDocketingComplete Operation
    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "NotifyDocketingCompleteResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "NotifyDocketingCompleteResponse")]
    public partial class NotifyDocketingCompleteResponse
    {

        /// <remarks/>
        private MessageReceiptMessageType messageReceiptMessage;

        public NotifyDocketingCompleteResponse()
        {
        }

        public NotifyDocketingCompleteResponse(MessageReceiptMessageType messageReceiptMessage)
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "NotifyDocketingCompleteRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "NotifyDocketingCompleteRequest")]
    public partial class NotifyDocketingCompleteRequest
    {


        private RecordDocketingCallbackMessageType recordDocketingCallbackMessage;

        public NotifyDocketingCompleteRequest()
        {
        }

        public NotifyDocketingCompleteRequest(RecordDocketingCallbackMessageType recordDocketingCallbackMessage)
        {
            this.recordDocketingCallbackMessage = recordDocketingCallbackMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "RecordDocketingCallbackMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "RecordDocketingCallbackMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:RecordDocketingCallbackMessage-4.0")]

        public RecordDocketingCallbackMessageType RecordDocketingCallbackMessage
        {
            get
            {
                return this.recordDocketingCallbackMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("RecordDocketingCallbackMessage");
                }
                if ((this.recordDocketingCallbackMessage != value))
                {
                    this.recordDocketingCallbackMessage = value;
                }
            }
        }
    }


    #endregion NotifyDocketingComplete Operation

    #region NotifyFilingStatusChange Operation
    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "NotifyFilingStatusChangeResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "NotifyFilingStatusChangeResponse")]
    public partial class NotifyFilingStatusChangeResponse
    {

        /// <remarks/>
        private MessageReceiptMessageType messageReceiptMessage;
        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces = new System.Xml.Serialization.XmlSerializerNamespaces();


        public NotifyFilingStatusChangeResponse()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public NotifyFilingStatusChangeResponse(MessageReceiptMessageType messageReceiptMessage)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "NotifyFilingStatusChangeRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "NotifyFilingStatusChangeRequest")]
    public partial class NotifyFilingStatusChangeRequest
    {


        private FilingStatusResponseMessageType filingStatusResponseMessage;

        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces = new System.Xml.Serialization.XmlSerializerNamespaces();

        public NotifyFilingStatusChangeRequest()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public NotifyFilingStatusChangeRequest(FilingStatusResponseMessageType filingStatusResponseMessage)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.filingStatusResponseMessage = filingStatusResponseMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "FilingStatusResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "FilingStatusResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusResponseMessage-4.0")]

        public FilingStatusResponseMessageType FilingStatusResponseMessage
        {
            get
            {
                return this.filingStatusResponseMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("FilingStatusResponseMessage");
                }
                if ((this.filingStatusResponseMessage != value))
                {
                    this.filingStatusResponseMessage = value;
                }
            }
        }
    }


    #endregion NotifyFilingStatusChange Operation

    #region GetFilingStatus Operation
    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "GetFilingStatusResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "GetFilingStatusResponse")]
    public partial class GetFilingStatusResponse
    {

        /// <remarks/>
        private FilingStatusResponseMessageType filingStatusResponseMessage;
        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces = new System.Xml.Serialization.XmlSerializerNamespaces();


        public GetFilingStatusResponse()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public GetFilingStatusResponse(FilingStatusResponseMessageType filingStatusResponseMessage)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.filingStatusResponseMessage = filingStatusResponseMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "FilingStatusResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusResponseMessage-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "FilingStatusResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusResponseMessage-4.0")]
        public FilingStatusResponseMessageType FilingStatusResponseMessage
        {
            get
            {
                return this.filingStatusResponseMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("FilingStatusResponseMessage");
                }
                if ((this.filingStatusResponseMessage != value))
                {
                    this.filingStatusResponseMessage = value;
                }
            }
        }
    }


    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "GetFilingStatusRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "GetFilingStatusRequest")]
    public partial class GetFilingStatusRequest
    {


        private FilingStatusQueryMessageType filingStatusQueryMessage;

        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces = new System.Xml.Serialization.XmlSerializerNamespaces();

        public GetFilingStatusRequest()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public GetFilingStatusRequest(FilingStatusQueryMessageType filingStatusQueryMessage)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.filingStatusQueryMessage = filingStatusQueryMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "FilingStatusResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "FilingStatusQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusQueryMessage-4.0")]

        public FilingStatusQueryMessageType FilingStatusQueryMessage
        {
            get
            {
                return this.filingStatusQueryMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("FilingStatusQueryMessage");
                }
                if ((this.filingStatusQueryMessage != value))
                {
                    this.filingStatusQueryMessage = value;
                }
            }
        }
    }


    #endregion GetFilingStatus Operation
}
