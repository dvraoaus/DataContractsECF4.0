using Niem.NiemCore.v20;
using Niem.Proxy.xsd.v20;
using Niem.Structures.v20;
using Niem.Domains.Jxdm.v40;

namespace Oasis.LegalXml.CourtFiling.v40.Appellate
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", TypeName = "AppellateCaseAddedPartyType")]
    [System.Xml.Serialization.XmlRootAttribute("AppellateCaseAddedPartyType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", IsNullable = false)]
    public partial class AppellateCaseAddedPartyType : ComplexObjectType
    {

        private TextType appellateCasePartyAddedReasonTextField;

        private EntityType appellateCasePartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "AppellateCasePartyAddedReasonText")]
        public TextType AppellateCasePartyAddedReasonText
        {
            get
            {
                return this.appellateCasePartyAddedReasonTextField;
            }
            set
            {
                this.appellateCasePartyAddedReasonTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "AppellateCaseParty")]
        public EntityType AppellateCaseParty
        {
            get
            {
                return this.appellateCasePartyField;
            }
            set
            {
                this.appellateCasePartyField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", TypeName = "AppellateCaseRemovedPartyType")]
    [System.Xml.Serialization.XmlRootAttribute("AppellateCaseRemovedPartyType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", IsNullable = false)]
    public partial class AppellateCaseRemovedPartyType : ComplexObjectType
    {

        private TextType appellateCasePartyRemovedReasonTextField;

        private EntityType appellateCasePartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "AppellateCasePartyRemovedReasonText")]
        public TextType AppellateCasePartyRemovedReasonText
        {
            get
            {
                return this.appellateCasePartyRemovedReasonTextField;
            }
            set
            {
                this.appellateCasePartyRemovedReasonTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "AppellateCaseParty")]
        public EntityType AppellateCaseParty
        {
            get
            {
                return this.appellateCasePartyField;
            }
            set
            {
                this.appellateCasePartyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", TypeName = "AppellateCivilCaseType")]
    [System.Xml.Serialization.XmlRootAttribute("AppellateCivilCaseType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", IsNullable = false)]
    public partial class AppellateCivilCaseType : ComplexObjectType
    {

        private Boolean feesWaivedIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "FeesWaivedIndicator")]
        public Boolean FeesWaivedIndicator
        {
            get
            {
                return this.feesWaivedIndicatorField;
            }
            set
            {
                this.feesWaivedIndicatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", TypeName = "AppellateCourtRuleCaseType")]
    [System.Xml.Serialization.XmlRootAttribute("AppellateCourtRuleCaseType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", IsNullable = false)]
    public partial class AppellateCourtRuleCaseType : ComplexObjectType
    {

        private TextType ruleCollectionTextField;

        private System.Collections.Generic.List<NumericType> ruleCollectionNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "RuleCollectionText")]
        public TextType RuleCollectionText
        {
            get
            {
                return this.ruleCollectionTextField;
            }
            set
            {
                this.ruleCollectionTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RuleCollectionNumber", Order = 1)]
        public System.Collections.Generic.List<NumericType> RuleCollectionNumber
        {
            get
            {
                return this.ruleCollectionNumberField;
            }
            set
            {
                this.ruleCollectionNumberField = value;
            }
        }
    }



    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AppellateCaseType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0")]
    [System.Xml.Serialization.XmlRootAttribute("AppellateCaseType1", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", IsNullable = false)]
    public partial class AppellateCaseType : Niem.Domains.Jxdm.v40.AppellateCaseType
    {


        private Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation;
        
        private Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType ecfCaseAugmentation;
        private Boolean appellantInCustodyIndicatorField;

        private System.Collections.Generic.List<AppellateCaseAddedPartyType> appellateCaseAddedPartyField;

        private TextType appellateCaseJurisdictionBasisTextField;

        private TextType appellateCaseSettlementRequestTextField;

        private System.Collections.Generic.List<AppellateCaseRemovedPartyType> appellateCaseRemovedPartyField;

        private ComplexObjectType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0, ElementName = "CaseAugmentation")]
        public Niem.Domains.Jxdm.v40.CaseAugmentationType CaseAugmentation
        {
            get
            {
                return this.caseAugmentation;
            }
            set
            {
                this.caseAugmentation = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 1)]
        public Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType EcfCaseAugmentation
        {
            get
            {
                return this.ecfCaseAugmentation;
            }
            set
            {
                this.ecfCaseAugmentation = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2, ElementName = "AppellantInCustodyIndicator")]
        public Boolean AppellantInCustodyIndicator
        {
            get
            {
                return this.appellantInCustodyIndicatorField;
            }
            set
            {
                this.appellantInCustodyIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AppellateCaseAddedParty", Order = 3)]
        public System.Collections.Generic.List<AppellateCaseAddedPartyType> AppellateCaseAddedParty
        {
            get
            {
                return this.appellateCaseAddedPartyField;
            }
            set
            {
                this.appellateCaseAddedPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4, ElementName = "AppellateCaseJurisdictionBasisText")]
        public TextType AppellateCaseJurisdictionBasisText
        {
            get
            {
                return this.appellateCaseJurisdictionBasisTextField;
            }
            set
            {
                this.appellateCaseJurisdictionBasisTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5, ElementName = "AppellateCaseSettlementRequestText")]
        public TextType AppellateCaseSettlementRequestText
        {
            get
            {
                return this.appellateCaseSettlementRequestTextField;
            }
            set
            {
                this.appellateCaseSettlementRequestTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AppellateCaseRemovedParty", Order = 6)]
        public System.Collections.Generic.List<AppellateCaseRemovedPartyType> AppellateCaseRemovedParty
        {
            get
            {
                return this.appellateCaseRemovedPartyField;
            }
            set
            {
                this.appellateCaseRemovedPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item", typeof(AppellateCivilCaseType), Order = 7)]
        [System.Xml.Serialization.XmlElementAttribute("AppellateCourtRuleCase", typeof(AppellateCourtRuleCaseType), Order = 7)]
        public ComplexObjectType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }


}
