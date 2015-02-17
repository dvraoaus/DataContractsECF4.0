/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    CourtRecordMessageContracts.cs
	'   Created Date:   04/1/2009
	'   Description:    Message Contracts for Court Record MDE Operations.
 *  '                    In order to match ECF wsdls we need more control 
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
	'=======================================================================
    '   Rao     04/24/2012       Moved AddNameSpaces to EcfHelper
	'=======================================================================
	*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oasis.LegalXml.CourtFiling.v40.Core;
using Oasis.LegalXml.CourtFiling.v40.Ecf;
using Oasis.LegalXml.CourtFiling.v40.Docketing;
using Oasis.LegalXml.CourtFiling.v40.Message;
using Oasis.LegalXml.CourtFiling.v40.CaseQuery;
using Oasis.LegalXml.CourtFiling.v40.CaseResponse;
using Oasis.LegalXml.CourtFiling.v40.CaseListQuery;
using Oasis.LegalXml.CourtFiling.v40.CaseListResponse;
using Oasis.LegalXml.CourtFiling.v40.ServiceQuery;
using Oasis.LegalXml.CourtFiling.v40.ServiceResponse;
using Oasis.LegalXml.CourtFiling.v40.DocumentQuery;
using Oasis.LegalXml.CourtFiling.v40.DocumentResponse;
using Oasis.LegalXml.CourtFiling.v40.Payment;



namespace Oasis.LegalXml.CourtFiling.v40.WebServiceMessagingProfile
{

    #region RecordFiling Operation
    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "RecordFilingResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "RecordFilingResponse")]
    public partial class RecordFilingResponse
    {

        private MessageReceiptMessageType messageReceiptMessage;

        public RecordFilingResponse()
        {
        }

        public RecordFilingResponse(MessageReceiptMessageType messageReceiptMessage)
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "RecordFilingRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "RecordFilingRequest")]
    public partial class RecordFilingRequest
    {


        private RecordFilingRequestMessageType recordFilingRequestMessage;

        public RecordFilingRequest()
        {
        }

        public RecordFilingRequest(RecordFilingRequestMessageType recordFilingRequestMessage)
        {
            this.recordFilingRequestMessage = recordFilingRequestMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "RecordFilingRequestMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "RecordFilingRequestMessage")]
        public RecordFilingRequestMessageType RecordFilingRequestMessage
        {
            get
            {
                return this.recordFilingRequestMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("RecordFilingRequestMessage");
                }
                if ((this.recordFilingRequestMessage != value))
                {
                    this.recordFilingRequestMessage = value;
                }
            }
        }
    }


    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "RecordFilingRequestMessageType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "RecordFilingRequestMessage")]
    public partial class RecordFilingRequestMessageType : ElectronicFilingMessageType
    {
        private CoreFilingMessageType coreFilingMessage;
        private RecordDocketingMessageType recordDocketingMessage;
        private PaymentMessageType paymentMessage;

        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces = new System.Xml.Serialization.XmlSerializerNamespaces(); 

        public RecordFilingRequestMessageType()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public RecordFilingRequestMessageType(CoreFilingMessageType coreFilingMessage, RecordDocketingMessageType recordDocketingMessage, PaymentMessageType paymentMessage)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.coreFilingMessage = coreFilingMessage;
            this.recordDocketingMessage = recordDocketingMessage;
            this.PaymentMessage = paymentMessage;
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

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "RecordDocketingMessage", Order = 1, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:RecordDocketingMessage-4.0")]
        public RecordDocketingMessageType RecordDocketingMessage
        {
            get
            {
                return this.recordDocketingMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("RecordDocketingMessage");
                }
                if ((this.recordDocketingMessage != value))
                {
                    this.recordDocketingMessage = value;
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
    #endregion RecordFiling Operation

    #region GetCase Operation
    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "GetCaseResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "GetCaseResponse")]
    public partial class GetCaseResponse
    {

        private CaseResponseMessageType caseResponseMessage;

        public GetCaseResponse()
        {
        }

        public GetCaseResponse(CaseResponseMessageType caseResponseMessage)
        {
            this.caseResponseMessage = caseResponseMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "CaseResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "CaseResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseResponseMessage-4.0")]
        public CaseResponseMessageType CaseResponseMessage
        {
            get
            {
                return this.caseResponseMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CaseResponseMessage");
                }
                if ((this.caseResponseMessage != value))
                {
                    this.caseResponseMessage = value;
                }
            }
        }
    }

    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "GetCaseRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "GetCaseRequest")]
    public partial class GetCaseRequest
    {


        private CaseQueryMessageType caseQueryMessage;

        public GetCaseRequest()
        {
        }

        public GetCaseRequest(CaseQueryMessageType caseQueryMessage)
        {
            this.caseQueryMessage = caseQueryMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "CaseQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "CaseQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseQueryMessage-4.0")]

        public CaseQueryMessageType CaseQueryMessage
        {
            get
            {
                return this.caseQueryMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CaseQueryMessage");
                }
                if ((this.caseQueryMessage != value))
                {
                    this.caseQueryMessage = value;
                }
            }
        }
    }


    #endregion GetCase Operation

    #region GetCaseList Operation
    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "GetCaseListResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "GetCaseListResponse")]
    public partial class GetCaseListResponse
    {

        private CaseListResponseMessageType caseListResponseMessage;

        public GetCaseListResponse()
        {
        }

        public GetCaseListResponse(CaseListResponseMessageType caseListResponseMessage)
        {
            this.caseListResponseMessage = caseListResponseMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "CaseListResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "CaseListResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseListResponseMessage-4.0")]
        public CaseListResponseMessageType CaseListResponseMessage
        {
            get
            {
                return this.caseListResponseMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CaseListResponseMessage");
                }
                if ((this.caseListResponseMessage != value))
                {
                    this.caseListResponseMessage = value;
                }
            }
        }
    }

    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "GetCaseListRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "GetCaseListRequest")]
    public partial class GetCaseListRequest
    {


        private CaseListQueryMessageType caseListQueryMessage;

        public GetCaseListRequest()
        {
        }

        public GetCaseListRequest(CaseListQueryMessageType caseListQueryMessage)
        {
            this.caseListQueryMessage = caseListQueryMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "CaseListQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "CaseListQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseListQueryMessage-4.0")]

        public CaseListQueryMessageType CaseListQueryMessage
        {
            get
            {
                return this.caseListQueryMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CaseListQueryMessage");
                }
                if ((this.caseListQueryMessage != value))
                {
                    this.caseListQueryMessage = value;
                }
            }
        }
    }


    #endregion GetCaseList Operation

    #region GetServiceInformation Operation
    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "GetServiceInformationResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "GetServiceInformationResponse")]
    public partial class GetServiceInformationResponse
    {

        private ServiceInformationResponseMessageType serviceInformationResponseMessage;

        public GetServiceInformationResponse()
        {
        }

        public GetServiceInformationResponse(ServiceInformationResponseMessageType serviceInformationResponseMessage)
        {
            this.serviceInformationResponseMessage = serviceInformationResponseMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "ServiceInformationResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ServiceInformationResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ServiceInformationResponseMessage-4.0")]
        public ServiceInformationResponseMessageType ServiceInformationResponseMessage
        {
            get
            {
                return this.serviceInformationResponseMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("ServiceInformationResponseMessage");
                }
                if ((this.serviceInformationResponseMessage != value))
                {
                    this.serviceInformationResponseMessage = value;
                }
            }
        }
    }

    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "GetServiceInformationRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ServiceInformationQueryMessage-4.0", IsNullable = true, ElementName = "GetServiceInformationRequest")]
    public partial class GetServiceInformationRequest
    {


        private ServiceInformationQueryMessageType serviceInformationQueryMessage;

        public GetServiceInformationRequest()
        {
        }

        public GetServiceInformationRequest(ServiceInformationQueryMessageType serviceInformationQueryMessage)
        {
            this.serviceInformationQueryMessage = serviceInformationQueryMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "ServiceInformationQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ServiceInformationQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseQueryMessage-4.0")]

        public ServiceInformationQueryMessageType ServiceInformationQueryMessage
        {
            get
            {
                return this.serviceInformationQueryMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CaseQueryMessage");
                }
                if ((this.serviceInformationQueryMessage != value))
                {
                    this.serviceInformationQueryMessage = value;
                }
            }
        }
    }


    #endregion GetServiceInformation Operation

    #region GetDocument Operation
    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "GetDocumentResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "GetDocumentResponse")]
    public partial class GetDocumentResponse
    {

        private DocumentResponseMessageType documentResponseMessage;

        public GetDocumentResponse()
        {
        }

        public GetDocumentResponse(DocumentResponseMessageType documentResponseMessage)
        {
            this.documentResponseMessage = documentResponseMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "DocumentResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "DocumentResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DocumentResponseMessage-4.0")]
        public DocumentResponseMessageType DocumentResponseMessage
        {
            get
            {
                return this.documentResponseMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DocumentResponseMessage");
                }
                if ((this.documentResponseMessage != value))
                {
                    this.documentResponseMessage = value;
                }
            }
        }
    }

    [System.ServiceModel.MessageContract(IsWrapped = false)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "GetDocumentRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "GetDocumentRequest")]
    public partial class GetDocumentRequest
    {


        private DocumentQueryMessageType documentQueryMessage;

        public GetDocumentRequest()
        {
        }

        public GetDocumentRequest(DocumentQueryMessageType documentQueryMessage)
        {
            this.documentQueryMessage = documentQueryMessage;
        }

        [System.ServiceModel.MessageBodyMember(Name = "DocumentQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "DocumentQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DocumentQueryMessage-4.0")]

        public DocumentQueryMessageType DocumentQueryMessage
        {
            get
            {
                return this.documentQueryMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DocumentQueryMessage");
                }
                if ((this.documentQueryMessage != value))
                {
                    this.documentQueryMessage = value;
                }
            }
        }
    }


    #endregion GetDocument Operation
}
