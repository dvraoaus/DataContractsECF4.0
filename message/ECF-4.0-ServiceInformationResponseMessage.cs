#region WSCF
//------------------------------------------------------------------------------
// <autogenerated code>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated code>
//------------------------------------------------------------------------------
// File time 27-11-08 05:25 PM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion

using Oasis.LegalXml.CourtFiling.v40.Ecf;
using Niem.Proxy.xsd.v20;
using Niem.NiemCore.v20; 
namespace Oasis.LegalXml.CourtFiling.v40.ServiceResponse
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ServiceInformationResponseMess" +
        "age-4.0", TypeName="ServiceInformationResponseMessageType")]
    [System.Xml.Serialization.XmlRootAttribute("ServiceInformationResponseMessage", Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ServiceInformationResponseMess" +
        "age-4.0", IsNullable=false, ElementName="ServiceInformationResponseMessageType")]
    
    public partial class ServiceInformationResponseMessageType : QueryResponseMessageType
    {
        
        /// <remarks/>
        private String caseTrackingID;
        
        /// <remarks/>
        private System.Collections.Generic.List<EntityType> serviceRecipient;
        
        public ServiceInformationResponseMessageType()
        {
        }
        
        public ServiceInformationResponseMessageType(String caseTrackingID, System.Collections.Generic.List<EntityType> serviceRecipient)
        {
            this.caseTrackingID = caseTrackingID;
            this.serviceRecipient = serviceRecipient;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=0, ElementName="CaseTrackingID")]
        public String CaseTrackingID
        {
            get
            {
                return this.caseTrackingID;
            }
            set
            {
                if ((this.caseTrackingID != value))
                {
                    this.caseTrackingID = value;
                    this.RaisePropertyChanged("CaseTrackingID");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ServiceRecipient", Order=1)]
        public System.Collections.Generic.List<EntityType> ServiceRecipient
        {
            get
            {
                return this.serviceRecipient;
            }
            set
            {
                if ((this.serviceRecipient != value))
                {
                    this.serviceRecipient = value;
                    this.RaisePropertyChanged("ServiceRecipient");
                }
            }
        }
    }
    
}
