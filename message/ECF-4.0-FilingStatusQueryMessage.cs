#region WSCF
//------------------------------------------------------------------------------
// <autogenerated code>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated code>
//------------------------------------------------------------------------------
// File time 27-11-08 03:47 PM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion


using Oasis.LegalXml.CourtFiling.v40.Ecf;
using Niem.NiemCore.v20; 
namespace Oasis.LegalXml.CourtFiling.v40.Filing
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusQueryMessage-4.0", TypeName="FilingStatusQueryMessageType")]
    [System.Xml.Serialization.XmlRootAttribute("FilingStatusQueryMessage", Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusQueryMessage-4.0", IsNullable=false, ElementName="FilingStatusQueryMessageType")]
    
    public partial class FilingStatusQueryMessageType : QueryMessageType
    {
        
        /// <remarks/>
        private IdentificationType documentIdentification;
        
        public FilingStatusQueryMessageType()
        {
        }
        
        public FilingStatusQueryMessageType(IdentificationType documentIdentification)
        {
            this.documentIdentification = documentIdentification;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=0, ElementName="DocumentIdentification")]
        public IdentificationType DocumentIdentification
        {
            get
            {
                return this.documentIdentification;
            }
            set
            {
                if ((this.documentIdentification != value))
                {
                    this.documentIdentification = value;
                    this.RaisePropertyChanged("DocumentIdentification");
                }
            }
        }
    }
    
  
}