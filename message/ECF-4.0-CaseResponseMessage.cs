/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    ECF-4.0-CaseResponseMessage.cs
	'   Created Date:   
	'   Description:    
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
 	'=======================================================================
    '   Rao     02/10/2015      Removed references to Amcad extensions
    '   Rao     04/24/2012       Moved AddNameSpaces to EcfHelper
    '   Rao     08/12/2011       Added XML Serialization options for AppellateCase 
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
// File time 27-11-08 10:30 AM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion

using Oasis.LegalXml.CourtFiling.v40.Ecf;
using Niem.NiemCore.v20;

namespace Oasis.LegalXml.CourtFiling.v40.CaseResponse
{
    
    
    /// <remarks/>
    /// 
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(Niem.NiemCore.v20.CaseType))]

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseResponseMessage-4.0", TypeName="CaseResponseMessageType")]
    [System.Xml.Serialization.XmlRootAttribute("CaseResponseMessage", Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseResponseMessage-4.0", IsNullable=false, ElementName="CaseResponseMessageType")]
    
    public partial class CaseResponseMessageType : QueryResponseMessageType
    {

        private Niem.NiemCore.v20.CaseType courtCase;
        private CaseTypeSelectionType caseTypeSelection; 

        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces = new System.Xml.Serialization.XmlSerializerNamespaces(); 

        public CaseResponseMessageType()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public CaseResponseMessageType(Niem.NiemCore.v20.CaseType courtCase, CaseTypeSelectionType caseTypeSelection)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.courtCase = courtCase;
            this.caseTypeSelection = caseTypeSelection;
        }


        [System.Xml.Serialization.XmlElementAttribute("Case", typeof(Niem.NiemCore.v20.CaseType), Order = 0, Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true)]
        [System.Xml.Serialization.XmlElementAttribute("Case", typeof(Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType), Order = 0, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", IsNullable = true)]
        [System.Xml.Serialization.XmlElementAttribute("Case", typeof(Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType), Order = 0, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0", IsNullable = true)]
        [System.Xml.Serialization.XmlElementAttribute("Case", typeof(Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType), Order = 0, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0", IsNullable = true)]
         [System.Xml.Serialization.XmlElementAttribute("Case", typeof(Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType), Order = 0, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0", IsNullable = true)]
        [System.Xml.Serialization.XmlElementAttribute("Case", typeof(Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType), Order = 0, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", IsNullable = true)]
        [System.Xml.Serialization.XmlElementAttribute("AppellateCase", typeof(Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType), Order = 0, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", IsNullable = true)]
        [System.Xml.Serialization.XmlElementAttribute("CivilCase", typeof(Arizona.Courts.Extensions.v20.CivilCaseType), Order = 0, Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = true)]

        public Niem.NiemCore.v20.CaseType Case
        {
            get
            {
                return this.courtCase;
            }
            set
            {
                if ((this.courtCase != value))
                {
                    // this.caseTypeSelection = EcfHelper.GetCaseTypeSelectionType(caseObject:value);
                    this.courtCase = value;
                }
            }
        }

        
        [System.Xml.Serialization.XmlElementAttribute("CaseTypeSelection", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CaseTypeSelectionType CaseTypeSelection
        {
            get
            {
                return this.caseTypeSelection;
            }
            set
            {
                if ((this.caseTypeSelection != value))
                {
                    this.caseTypeSelection = value;
                    this.RaisePropertyChanged("CaseTypeSelection");
                }
            }
        }
    }
    
 }
