/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    ECF-4.0-JuvenileCase.cs
	'   Created Date:   
	'   Description:    
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
 	'=======================================================================
    '   Rao     01/30/2012       Removed Obsolete as this will no longer serialize
    '   Rao     01/28/2012       Marked PersonChargeAssociation as Obsolete as it is added to Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugumentationType
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
// File time 12-01-10 11:56 AM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion

using Oasis.LegalXml.CourtFiling.v40.Ecf;
using Niem.NiemCore.v20;
using Niem.Proxy.xsd.v20;
using Niem.Structures.v20;
using Niem.Domains.Jxdm.v40;

namespace Oasis.LegalXml.CourtFiling.v40.Juvenile
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", TypeName = "JuvenileCaseType")]
    [System.Xml.Serialization.XmlRootAttribute("JuvenileCase", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", IsNullable = false, ElementName = "JuvenileCase")]
    public partial class JuvenileCaseType : Niem.NiemCore.v20.CaseType
    {

        private Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation;
        private Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType ecfCaseAugmentation;
        private JuvenileType juvenileCaseJuvenile;
        private Niem.Domains.Jxdm.v40.ArrestType caseArrest;
        private System.Collections.Generic.List<DependencyAllegationType> dependencyAllegation;
        private System.Collections.Generic.List<Niem.NiemCore.v20.IncidentType> adjudicationActions;
        private System.Collections.Generic.List<PersonChargeAssociationType> personChargeAssociation;
        public JuvenileCaseType()
        {
        }

        public JuvenileCaseType(Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation, Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType ecfCaseAugmentation, JuvenileType juvenileCaseJuvenile, ArrestType caseArrest, System.Collections.Generic.List<DependencyAllegationType> dependencyAllegation, System.Collections.Generic.List<Niem.NiemCore.v20.IncidentType> adjudicationActions, System.Collections.Generic.List<PersonChargeAssociationType> personChargeAssociation)
        {
            this.caseAugmentation = caseAugmentation;
            this.ecfCaseAugmentation = ecfCaseAugmentation;
            this.juvenileCaseJuvenile = juvenileCaseJuvenile;
            this.caseArrest = caseArrest;
            this.dependencyAllegation = dependencyAllegation;
            this.adjudicationActions = adjudicationActions;
            this.personChargeAssociation = personChargeAssociation;
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0, ElementName = "CaseAugmentation")]
        public Niem.Domains.Jxdm.v40.CaseAugmentationType CaseAugmentation
        {
            get
            {
                return this.caseAugmentation;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CaseAugmentation");
                }
                if ((this.caseAugmentation != value))
                {
                    this.caseAugmentation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 1)]
        public Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType EcfCaseAugmentation
        {
            get
            {
                return this.ecfCaseAugmentation;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("EcfCaseAugmentation");
                }
                if ((this.ecfCaseAugmentation != value))
                {
                    this.ecfCaseAugmentation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2, ElementName = "JuvenileCaseJuvenile")]
        public JuvenileType JuvenileCaseJuvenile
        {
            get
            {
                return this.juvenileCaseJuvenile;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("JuvenileCaseJuvenile");
                }
                if ((this.juvenileCaseJuvenile != value))
                {
                    this.juvenileCaseJuvenile = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3, ElementName = "CaseArrest")]
        public ArrestType CaseArrest
        {
            get
            {
                return this.caseArrest;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CaseArrest");
                }
                if ((this.caseArrest != value))
                {
                    this.caseArrest = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("DependencyAllegation", Order = 4)]
        public System.Collections.Generic.List<DependencyAllegationType> DependencyAllegation
        {
            get
            {
                return this.dependencyAllegation;
            }
            set
            {
                if ((this.dependencyAllegation != value))
                {
                    this.dependencyAllegation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("DelinquentAct", typeof(DelinquentActType), Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute("StatusOffenseAct", typeof(StatusOffenseActType), Order = 5)]
        public System.Collections.Generic.List<Niem.NiemCore.v20.IncidentType> AdjudicationActions
        {
            get
            {
                return this.adjudicationActions;
            }
            set
            {
                if ((this.adjudicationActions != value))
                {
                    this.adjudicationActions = value;
                }
            }
        }

        // [System.Obsolete("Added to Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugumentationType")]
        [System.Xml.Serialization.XmlElementAttribute("PersonChargeAssociation",  Namespace = "http://niem.gov/niem/domains/jxdm/4.0" ,Order = 6)]
        public System.Collections.Generic.List<PersonChargeAssociationType> PersonChargeAssociation
        {
            get
            {
                return this.personChargeAssociation;
            }
            set
            {
                if ((this.personChargeAssociation != value))
                {
                    this.personChargeAssociation = value;
                    this.RaisePropertyChanged("PersonChargeAssociation");
                }
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", TypeName = "DelinquentActType")]
    [System.Xml.Serialization.XmlRootAttribute("DelinquentAct", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", IsNullable = false, ElementName = "DelinquentAct")]
    public partial class DelinquentActType : Niem.NiemCore.v20.IncidentType
    {

        private Niem.Domains.Jxdm.v40.StatuteType delinquentActStatute;
        private TextType delinquentActSeverityCode;
        private TextType delinquentActDegreeCode;
        private TextType delinquentActApplicabilityCode;
        private TextType delinquentActSpecialAllegationCode;

        public DelinquentActType()
        {
        }

        public DelinquentActType(Niem.Domains.Jxdm.v40.StatuteType delinquentActStatute, TextType delinquentActSeverityCode, TextType delinquentActDegreeCode, TextType delinquentActApplicabilityCode, TextType delinquentActSpecialAllegationCode)
        {
            this.delinquentActStatute = delinquentActStatute;
            this.delinquentActSeverityCode = delinquentActSeverityCode;
            this.delinquentActDegreeCode = delinquentActDegreeCode;
            this.delinquentActApplicabilityCode = delinquentActApplicabilityCode;
            this.delinquentActSpecialAllegationCode = delinquentActSpecialAllegationCode;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "DelinquentActStatute")]
        public Niem.Domains.Jxdm.v40.StatuteType DelinquentActStatute
        {
            get
            {
                return this.delinquentActStatute;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DelinquentActStatute");
                }
                if ((this.delinquentActStatute != value))
                {
                    this.delinquentActStatute = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "DelinquentActSeverityCode")]
        public TextType DelinquentActSeverityCode
        {
            get
            {
                return this.delinquentActSeverityCode;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DelinquentActSeverityCode");
                }
                if ((this.delinquentActSeverityCode != value))
                {
                    this.delinquentActSeverityCode = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2, ElementName = "DelinquentActDegreeCode")]
        public TextType DelinquentActDegreeCode
        {
            get
            {
                return this.delinquentActDegreeCode;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DelinquentActDegreeCode");
                }
                if ((this.delinquentActDegreeCode != value))
                {
                    this.delinquentActDegreeCode = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3, ElementName = "DelinquentActApplicabilityCode")]
        public TextType DelinquentActApplicabilityCode
        {
            get
            {
                return this.delinquentActApplicabilityCode;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DelinquentActApplicabilityCode");
                }
                if ((this.delinquentActApplicabilityCode != value))
                {
                    this.delinquentActApplicabilityCode = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4, ElementName = "DelinquentActSpecialAllegationCode")]
        public TextType DelinquentActSpecialAllegationCode
        {
            get
            {
                return this.delinquentActSpecialAllegationCode;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DelinquentActSpecialAllegationCode");
                }
                if ((this.delinquentActSpecialAllegationCode != value))
                {
                    this.delinquentActSpecialAllegationCode = value;
                }
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", TypeName = "DependencyAllegationType")]
    [System.Xml.Serialization.XmlRootAttribute("DependencyAllegation", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", IsNullable = false, ElementName = "DependencyAllegation")]
    public partial class DependencyAllegationType : ComplexObjectType
    {

        private TextType dependencyAllegationCode;
        private TextType dependencyAllegationText;

        public DependencyAllegationType()
        {
        }

        public DependencyAllegationType(TextType dependencyAllegationCode, TextType dependencyAllegationText)
        {
            this.dependencyAllegationCode = dependencyAllegationCode;
            this.dependencyAllegationText = dependencyAllegationText;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "DependencyAllegationCode")]
        public TextType DependencyAllegationCode
        {
            get
            {
                return this.dependencyAllegationCode;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DependencyAllegationCode");
                }
                if ((this.dependencyAllegationCode != value))
                {
                    this.dependencyAllegationCode = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "DependencyAllegationText")]
        public TextType DependencyAllegationText
        {
            get
            {
                return this.dependencyAllegationText;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DependencyAllegationText");
                }
                if ((this.dependencyAllegationText != value))
                {
                    this.dependencyAllegationText = value;
                }
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GuardianAssociationType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0")]
    [System.Xml.Serialization.XmlRootAttribute("GuardianAssociation", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", IsNullable = false, ElementName = "GuardianAssociation")]
    public partial class GuardianAssociationType : Niem.NiemCore.v20.GuardianAssociationType
    {

        private TextType guardianAssociationTypeCode;

        public GuardianAssociationType()
        {
        }

        public GuardianAssociationType(TextType guardianAssociationTypeCode)
        {
            this.guardianAssociationTypeCode = guardianAssociationTypeCode;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "GuardianAssociationTypeCode")]
        public TextType GuardianAssociationTypeCode
        {
            get
            {
                return this.guardianAssociationTypeCode;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("GuardianAssociationTypeCode");
                }
                if ((this.guardianAssociationTypeCode != value))
                {
                    this.guardianAssociationTypeCode = value;
                }
            }
        }
    }


    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", TypeName = "JuvenileType")]
    [System.Xml.Serialization.XmlRootAttribute("JuvenileCaseJuvenile", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", IsNullable = false, ElementName = "Juvenile")]
    public partial class JuvenileType : Oasis.LegalXml.CourtFiling.v40.Ecf.SubjectType
    {

        private System.Collections.Generic.List<Niem.NiemCore.v20.PersonOrganizationAssociationType> personGangAssociation;
        private Niem.Domains.Jxdm.v40.RegisteredOffenderType registeredSexOffender;
        private System.Collections.Generic.List<GuardianAssociationType> guardianAssociation;
        private Boolean personEmancipatedIndicator;
        private PlacementAssociationType placementAssociation;

        public JuvenileType()
        {
        }

        public JuvenileType(System.Collections.Generic.List<Niem.NiemCore.v20.PersonOrganizationAssociationType> personGangAssociation, Niem.Domains.Jxdm.v40.RegisteredOffenderType registeredSexOffender, System.Collections.Generic.List<GuardianAssociationType> guardianAssociation, Boolean personEmancipatedIndicator, PlacementAssociationType placementAssociation)
        {
            this.personGangAssociation = personGangAssociation;
            this.registeredSexOffender = registeredSexOffender;
            this.guardianAssociation = guardianAssociation;
            this.personEmancipatedIndicator = personEmancipatedIndicator;
            this.placementAssociation = placementAssociation;
        }

        [System.Xml.Serialization.XmlElementAttribute("PersonGangAssociation", Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 0)]
        public System.Collections.Generic.List<Niem.NiemCore.v20.PersonOrganizationAssociationType> PersonGangAssociation
        {
            get
            {
                return this.personGangAssociation;
            }
            set
            {
                if ((this.personGangAssociation != value))
                {
                    this.personGangAssociation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", IsNullable = true, Order = 1, ElementName = "RegisteredSexOffender")]
        public Niem.Domains.Jxdm.v40.RegisteredOffenderType RegisteredSexOffender
        {
            get
            {
                return this.registeredSexOffender;
            }
            set
            {
                if ((this.registeredSexOffender != value))
                {
                    this.registeredSexOffender = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("GuardianAssociation", Order = 2)]
        public System.Collections.Generic.List<GuardianAssociationType> GuardianAssociation
        {
            get
            {
                return this.guardianAssociation;
            }
            set
            {
                if ((this.guardianAssociation != value))
                {
                    this.guardianAssociation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3, ElementName = "PersonEmancipatedIndicator")]
        public Boolean PersonEmancipatedIndicator
        {
            get
            {
                return this.personEmancipatedIndicator;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("PersonEmancipatedIndicator");
                }
                if ((this.personEmancipatedIndicator != value))
                {
                    this.personEmancipatedIndicator = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4, ElementName = "PlacementAssociation")]
        public PlacementAssociationType PlacementAssociation
        {
            get
            {
                return this.placementAssociation;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("PlacementAssociation");
                }
                if ((this.placementAssociation != value))
                {
                    this.placementAssociation = value;
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", TypeName = "PlacementAssociationType")]
    [System.Xml.Serialization.XmlRootAttribute("PlacementAssociation", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", IsNullable = false, ElementName = "PlacementAssociation")]
    public  partial class PlacementAssociationType : AssociationType
    {

        private TextType placementTypeCode;
        private DateType placementStartDate;
        private Niem.NiemCore.v20.EntityType placementEntity;

        public PlacementAssociationType()
        {
        }

        public PlacementAssociationType(TextType placementTypeCode, DateType placementStartDate, Niem.NiemCore.v20.EntityType placementEntity)
        {
            this.placementTypeCode = placementTypeCode;
            this.placementStartDate = placementStartDate;
            this.placementEntity = placementEntity;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "PlacementTypeCode")]
        public TextType PlacementTypeCode
        {
            get
            {
                return this.placementTypeCode;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("PlacementTypeCode");
                }
                if ((this.placementTypeCode != value))
                {
                    this.placementTypeCode = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "PlacementStartDate")]
        public DateType PlacementStartDate
        {
            get
            {
                return this.placementStartDate;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("PlacementStartDate");
                }
                if ((this.placementStartDate != value))
                {
                    this.placementStartDate = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2, ElementName = "PlacementEntity")]
        public Niem.NiemCore.v20.EntityType PlacementEntity
        {
            get
            {
                return this.placementEntity;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("PlacementEntity");
                }
                if ((this.placementEntity != value))
                {
                    this.placementEntity = value;
                }
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", TypeName = "StatusOffenseActType")]
    [System.Xml.Serialization.XmlRootAttribute("StatusOffenseAct", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", IsNullable = false, ElementName = "StatusOffenseActType")]
    public partial class StatusOffenseActType : Niem.NiemCore.v20.IncidentType
    {

        private Niem.Domains.Jxdm.v40.StatuteType statusOffenseActStatute;

        public StatusOffenseActType()
        {
        }

        public StatusOffenseActType(Niem.Domains.Jxdm.v40.StatuteType statusOffenseActStatute)
        {
            this.statusOffenseActStatute = statusOffenseActStatute;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "StatusOffenseActStatute")]
        public Niem.Domains.Jxdm.v40.StatuteType StatusOffenseActStatute
        {
            get
            {
                return this.statusOffenseActStatute;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("StatusOffenseActStatute");
                }
                if ((this.statusOffenseActStatute != value))
                {
                    this.statusOffenseActStatute = value;
                }
            }
        }
    }

}
