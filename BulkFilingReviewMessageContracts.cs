/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    BulkFilingReviewMessageContracts.cs
	'   Created Date:   
	'   Description:    Message Contracts for Bulk Filing Review Operations
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
	'=======================================================================
	'=======================================================================
	*/

using System.Collections.Generic;
using Oasis.LegalXml.CourtFiling.v40.Filing;
using Oasis.LegalXml.CourtFiling.v40.Message;
using Oasis.LegalXml.CourtFiling.v40.Ecf;

namespace Oasis.LegalXml.CourtFiling.v40.WebServiceMessagingProfile
{

    #region BulkReviewFiling Operation
    [System.ServiceModel.MessageContract(IsWrapped = true)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "BulkReviewFilingResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "BulkReviewFilingResponse")]
    public partial class BulkReviewFilingResponse
    {

        /// <remarks/>
        private List<MessageReceiptMessageType> messageReceiptMessages;
        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces; 

        public BulkReviewFilingResponse()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public BulkReviewFilingResponse(List<MessageReceiptMessageType> messageReceiptMessages)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.messageReceiptMessages = messageReceiptMessages;
        }

        [System.ServiceModel.MessageBodyMember(Name = "MessageReceiptMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElement(ElementName = "MessageReceiptMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:MessageReceiptMessage-4.0")]
        public List<MessageReceiptMessageType> MessageReceiptMessages
        {
            get
            {
                return this.messageReceiptMessages;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("MessageReceiptMessages");
                }
                if ((this.messageReceiptMessages != value))
                {
                    this.messageReceiptMessages = value;
                }
            }
        }


    }

    [System.ServiceModel.MessageContract(IsWrapped = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "BulkReviewFilingRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "BulkReviewFilingRequest")]

    public partial class BulkReviewFilingRequest
    {


        private List<ReviewFilingRequestMessageType> reviewFilingRequestMessages;

        public BulkReviewFilingRequest()
        {
        }

        public BulkReviewFilingRequest(List<ReviewFilingRequestMessageType> reviewFilingRequestMessages)
        {
            this.reviewFilingRequestMessages = reviewFilingRequestMessages;
        }

        [System.ServiceModel.MessageBodyMember(Name = "ReviewFilingRequestMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        [System.Xml.Serialization.XmlElement(ElementName = "ReviewFilingRequestMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0")]
        public List<ReviewFilingRequestMessageType> ReviewFilingRequestMessages
        {
            get
            {
                return this.reviewFilingRequestMessages;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("ReviewFilingRequestMessages");
                }
                if ((this.reviewFilingRequestMessages != value))
                {
                    this.reviewFilingRequestMessages = value;
                }
            }
        }
    }


    #endregion ReviewFiling Operation


    #region BulkGetFilingStatus Operation
    [System.ServiceModel.MessageContract(IsWrapped = true)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "BulkGetFilingStatusResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "BulkGetFilingStatusResponse")]
    public partial class BulkGetFilingStatusResponse
    {

        /// <remarks/>
        private List<FilingStatusResponseMessageType> filingStatusResponseMessages;
        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces;

        public BulkGetFilingStatusResponse()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public BulkGetFilingStatusResponse(List<FilingStatusResponseMessageType> filingStatusResponseMessages)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.filingStatusResponseMessages = filingStatusResponseMessages;
        }

        [System.ServiceModel.MessageBodyMember(Name = "FilingStatusResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusResponseMessage-4.0")]
        [System.Xml.Serialization.XmlElement(ElementName = "FilingStatusResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusResponseMessage-4.0")]
        public List<FilingStatusResponseMessageType> FilingStatusResponseMessages
        {
            get
            {
                return this.filingStatusResponseMessages;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("FilingStatusResponseMessages");
                }
                if ((this.filingStatusResponseMessages != value))
                {
                    this.filingStatusResponseMessages = value;
                }
            }
        }


    }

    [System.ServiceModel.MessageContract(IsWrapped = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "BulkGetFilingStatusRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "BulkGetFilingStatusRequest")]
    public partial class BulkGetFilingStatusRequest
    {


        private List<FilingStatusQueryMessageType> filingStatusQueryMessages;
        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces;

        public BulkGetFilingStatusRequest()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public BulkGetFilingStatusRequest(List<FilingStatusQueryMessageType> filingStatusQueryMessages)
        {
            this.filingStatusQueryMessages = filingStatusQueryMessages;
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        [System.ServiceModel.MessageBodyMember(Name = "FilingStatusQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusQueryMessage-4.0")]
        [System.Xml.Serialization.XmlElement(ElementName = "FilingStatusQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusQueryMessage-4.0")]
        public List<FilingStatusQueryMessageType> FilingStatusQueryMessage
        {
            get
            {
                return this.filingStatusQueryMessages;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("FilingStatusQueryMessage");
                }
                if ((this.filingStatusQueryMessages != value))
                {
                    this.filingStatusQueryMessages = value;
                }
            }
        }


    }



    #endregion BulkGetFilingStatus Operation


    #region BulkGetFilingReviewResult Operation
    [System.ServiceModel.MessageContract(IsWrapped = true)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "BulkGetFilingReviewResultResponse")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "BulkGetFilingReviewResultResponse")]
    public partial class BulkGetFilingReviewResultResponse
    {

        /// <remarks/>
        private List<ReviewFilingCallbackMessageType> reviewFilingCallbackMessages;
        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces;

        public BulkGetFilingReviewResultResponse()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public BulkGetFilingReviewResultResponse(List<ReviewFilingCallbackMessageType> reviewFilingCallbackMessages)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.reviewFilingCallbackMessages = reviewFilingCallbackMessages;
        }

        [System.ServiceModel.MessageBodyMember(Name = "ReviewFilingCallbackMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ReviewFilingCallbackMessage-4.0")]
        [System.Xml.Serialization.XmlElement(ElementName = "ReviewFilingCallbackMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ReviewFilingCallbackMessage-4.0")]
        public List<ReviewFilingCallbackMessageType> ReviewFilingCallbackMessages
        {
            get
            {
                return this.reviewFilingCallbackMessages;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("ReviewFilingCallbackMessages");
                }
                if ((this.reviewFilingCallbackMessages != value))
                {
                    this.reviewFilingCallbackMessages = value;
                }
            }
        }


    }

    [System.ServiceModel.MessageContract(IsWrapped = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", TypeName = "BulkGetFilingReviewResultRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", IsNullable = true, ElementName = "BulkGetFilingReviewResultRequest")]
    public partial class BulkGetFilingReviewResultRequest
    {


        private List<FilingStatusQueryMessageType> filingStatusQueryMessages;
        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces;

        public BulkGetFilingReviewResultRequest()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public BulkGetFilingReviewResultRequest(List<FilingStatusQueryMessageType> filingStatusQueryMessages)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.filingStatusQueryMessages = filingStatusQueryMessages;
        }

        [System.ServiceModel.MessageBodyMember(Name = "FilingStatusQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusQueryMessage-4.0")]
        [System.Xml.Serialization.XmlElement(ElementName = "FilingStatusQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusQueryMessage-4.0")]
        public List<FilingStatusQueryMessageType> FilingStatusQueryMessage
        {
            get
            {
                return this.filingStatusQueryMessages;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("FilingStatusQueryMessage");
                }
                if ((this.filingStatusQueryMessages != value))
                {
                    this.filingStatusQueryMessages = value;
                }
            }
        }


    }



    #endregion BulkGetFilingStatus Operation


}
