/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    ECF-4.0-PaymentMessage.cs
	'   Created Date:   
	'   Description:    
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
 	'=======================================================================
    '   Rao     08/13/2013       Payment element can be null
    '   Rao     04/24/2012       Moved AddNameSpaces to EcfHelper
	'=======================================================================
	*/

#region WSCF
//------------------------------------------------------------------------------
// <autogenerated code>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated code>
//------------------------------------------------------------------------------
// File time 27-11-08 04:00 PM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion

using Oasis.UniversalBusinessLanguage;
namespace Oasis.LegalXml.CourtFiling.v40.Payment
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:PaymentMessage-4.0", TypeName="PaymentMessageType")]
    [System.Xml.Serialization.XmlRootAttribute("PaymentMessage", Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:PaymentMessage-4.0", IsNullable=false, ElementName="PaymentMessageType")]
    
    public partial class PaymentMessageType : object 
    {
        
        /// <remarks/>
        private string feeExceptionReasonCode;
        
        /// <remarks/>
        private string feeExceptionSupportingText;
        
        /// <remarks/>
        private string payerName;
        
        /// <remarks/>
        private System.Collections.Generic.List<AllowanceChargeType> allowanceCharge;
        
        /// <remarks/>
        private AddressType address;
        
        /// <remarks/>
        private PaymentType payment;

        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces = new System.Xml.Serialization.XmlSerializerNamespaces(); 

        public PaymentMessageType()
        {
            Oasis.LegalXml.CourtFiling.v40.Ecf.EcfHelper. AddPaymentMessageNameSpaces(namespaces);
        }


        public PaymentMessageType(string feeExceptionReasonCode, string feeExceptionSupportingText, string payerName, System.Collections.Generic.List<AllowanceChargeType> allowanceCharge, AddressType address, PaymentType payment)
        {
            this.feeExceptionReasonCode = feeExceptionReasonCode;
            this.feeExceptionSupportingText = feeExceptionSupportingText;
            this.payerName = payerName;
            this.allowanceCharge = allowanceCharge;
            this.address = address;
            this.payment = payment;
            Oasis.LegalXml.CourtFiling.v40.Ecf.EcfHelper.AddPaymentMessageNameSpaces(namespaces);
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0, ElementName="FeeExceptionReasonCode")]
        public string FeeExceptionReasonCode
        {
            get
            {
                return this.feeExceptionReasonCode;
            }
            set
            {
                if ((this.feeExceptionReasonCode != value))
                {
                    this.feeExceptionReasonCode = value;
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1, ElementName="FeeExceptionSupportingText")]
        public string FeeExceptionSupportingText
        {
            get
            {
                return this.feeExceptionSupportingText;
            }
            set
            {
                if ((this.feeExceptionSupportingText != value))
                {
                    this.feeExceptionSupportingText = value;
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2, ElementName="PayerName")]
        public string PayerName
        {
            get
            {
                return this.payerName;
            }
            set
            {
                if ((this.payerName != value))
                {
                    this.payerName = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-1.0", Order = 3)]
        public System.Collections.Generic.List<AllowanceChargeType> AllowanceCharge
        {
            get
            {
                return this.allowanceCharge;
            }
            set
            {
                if ((this.allowanceCharge != value))
                {
                    this.allowanceCharge = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-1.0", Order = 4, ElementName = "Address")]
        public AddressType Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("Address");
                }
                if ((this.address != value))
                {
                    this.address = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-1.0", Order = 5, ElementName = "Payment")]
        public PaymentType Payment
        {
            get
            {
                return this.payment;
            }
            set
            {
                if ((this.payment != value))
                {
                    this.payment = value;
                }
            }
        }
        
    }
    
  
}
