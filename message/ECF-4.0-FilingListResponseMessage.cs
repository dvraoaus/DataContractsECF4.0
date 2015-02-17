#region WSCF
//------------------------------------------------------------------------------
// <autogenerated code>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated code>
//------------------------------------------------------------------------------
// File time 27-11-08 03:37 PM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion


using Oasis.LegalXml.CourtFiling.v40.Ecf;
using Niem.Proxy.xsd.v20; 

namespace Oasis.LegalXml.CourtFiling.v40.Filing
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingListResponseMessage-4.0", TypeName="FilingListResponseMessageType")]
    [System.Xml.Serialization.XmlRootAttribute("FilingListResponseMessage", Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingListResponseMessage-4.0", IsNullable=false, ElementName="FilingListResponseMessageType")]
    
    public partial class FilingListResponseMessageType : QueryResponseMessageType
    {
        
        /// <remarks/>
        private System.Collections.Generic.List<MatchingFilingType> matchingFiling;
        
        public FilingListResponseMessageType()
        {
        }
        
        public FilingListResponseMessageType(System.Collections.Generic.List<MatchingFilingType> matchingFiling)
        {
            this.matchingFiling = matchingFiling;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MatchingFiling", Order=0)]
        public System.Collections.Generic.List<MatchingFilingType> MatchingFiling
        {
            get
            {
                return this.matchingFiling;
            }
            set
            {
                if ((this.matchingFiling != value))
                {
                    this.matchingFiling = value;
                    this.RaisePropertyChanged("MatchingFiling");
                }
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingListResponseMessage-4.0", TypeName="MatchingFilingType")]
    [System.Xml.Serialization.XmlRootAttribute("MatchingFiling", Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingListResponseMessage-4.0", IsNullable=false, ElementName="MatchingFilingType")]
    
    public partial class MatchingFilingType : Niem.NiemCore.v20.DocumentType
    {
        
        /// <remarks/>
        private String caseTrackingID;
        
        /// <remarks/>
        private FilingStatusType filingStatus;
        
        public MatchingFilingType()
        {
        }
        
        public MatchingFilingType(String caseTrackingID, FilingStatusType filingStatus)
        {
            this.caseTrackingID = caseTrackingID;
            this.filingStatus = filingStatus;
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
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order=1, ElementName="FilingStatus")]
        public FilingStatusType FilingStatus
        {
            get
            {
                return this.filingStatus;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("FilingStatus");
                }
                if ((this.filingStatus != value))
                {
                    this.filingStatus = value;
                    this.RaisePropertyChanged("FilingStatus");
                }
            }
        }
    }
    
   }