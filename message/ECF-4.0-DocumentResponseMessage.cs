#region WSCF
//------------------------------------------------------------------------------
// <autogenerated code>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated code>
//------------------------------------------------------------------------------
// File time 27-11-08 03:00 PM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion

using Oasis.LegalXml.CourtFiling.v40.Ecf; 

namespace Oasis.LegalXml.CourtFiling.v40.DocumentResponse
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DocumentResponseMessage-4.0", TypeName="DocumentResponseMessageType")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentResponseMessage", Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DocumentResponseMessage-4.0", IsNullable=false, ElementName="DocumentResponseMessageType")]
    
    public partial class DocumentResponseMessageType : QueryResponseMessageType
    {
        
        /// <remarks/>
        private Ecf.DocumentType  document;
        
        public DocumentResponseMessageType()
        {
        }

        public DocumentResponseMessageType(Ecf.DocumentType document)
        {
            this.document = document;
        }

        [System.Xml.Serialization.XmlElementAttribute("Document", typeof(Oasis.LegalXml.CourtFiling.v40.Ecf.DocumentType), Order = 0, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", IsNullable = true)]
        [System.Xml.Serialization.XmlElementAttribute("Document", typeof(Arizona.Courts.Extensions.v20.DocumentType), Order = 0, Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = true)]

        public Ecf.DocumentType Document
        {
            get
            {
                return this.document;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("Document");
                }
                if ((this.document != value))
                {
                    this.document = value;
                    this.RaisePropertyChanged("Document");
                }
            }
        }
    }
    
 }
