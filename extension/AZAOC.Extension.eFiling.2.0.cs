/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    AZAOC.Extension.eFiling.2.0.cs
	'   Created Date:   
	'   Description:    
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
 	'=======================================================================
 *  '   Rao     02/10/2015     Creation
	'=======================================================================
	*/
using niemxsd = Niem.Proxy.xsd.v20;
using j=Niem.Domains.Jxdm.v40;
using nc=Niem.NiemCore.v20;
using scr = Niem.Domains.Screeing.v20;
using Niem.Structures.v20;
using Niem.NonauthoritativeCode.v20;
using ecf=Oasis.LegalXml.CourtFiling.v40.Ecf;
using civil = Oasis.LegalXml.CourtFiling.v40.Civil;
using  core= Oasis.LegalXml.CourtFiling.v40.Core;
using docket = Oasis.LegalXml.CourtFiling.v40.Docketing;

namespace Arizona.Courts.Extensions.v20
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ActivityRequest", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class ActivityRequestType : nc.ActivityType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GuardianAssociationType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GuardianAssociation", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class GuardianAssociationType :  Niem.NiemCore.v20.GuardianAssociationType
    {

        private nc.TextType guardianAssociationTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public nc.TextType GuardianAssociationTypeCode
        {
            get
            {
                return this.guardianAssociationTypeCodeField;
            }
            set
            {
                this.guardianAssociationTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("MarriageAssociation", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class MarriageAssociationType : nc.PersonUnionAssociationType
    {

        private scr.MarriageAssociationAugmentationType marriageAssociationAugmentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/screening/2.0", Order = 0)]
        public scr.MarriageAssociationAugmentationType MarriageAssociationAugmentation
        {
            get
            {
                return this.marriageAssociationAugmentationField;
            }
            set
            {
                this.marriageAssociationAugmentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AppellateCaseOriginalCase", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class AppellateCaseOriginalCaseType : nc.CaseType
    {

        private j.CaseAugmentationType caseAugmentationField;

        private ecf.CaseAugmentationType ecfcaseAugmentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public j.CaseAugmentationType CaseAugmentation
        {
            get
            {
                return this.caseAugmentationField;
            }
            set
            {
                this.caseAugmentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 1)]
        public ecf.CaseAugmentationType CaseAugmentation1
        {
            get
            {
                return this.ecfcaseAugmentationField;
            }
            set
            {
                this.ecfcaseAugmentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AppellateCaseType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AppellateCase", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class AppellateCaseType : Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType
    {

        private nc.TextType caseGeneralCategoryTextField;

        private nc.TextType caseSubCategoryTextField;

        private System.Collections.Generic.List<MarriageAssociationType> marriageAssociationField;

        private System.Collections.Generic.List<GuardianAssociationType> guardianAssociationField;

        private System.Collections.Generic.List<ImmediateFamilyAssociationType> immediateFamilyAssociationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public nc.TextType CaseGeneralCategoryText
        {
            get
            {
                return this.caseGeneralCategoryTextField;
            }
            set
            {
                this.caseGeneralCategoryTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public nc.TextType CaseSubCategoryText
        {
            get
            {
                return this.caseSubCategoryTextField;
            }
            set
            {
                this.caseSubCategoryTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MarriageAssociation", Order = 2)]
        public System.Collections.Generic.List<MarriageAssociationType> MarriageAssociation
        {
            get
            {
                return this.marriageAssociationField;
            }
            set
            {
                this.marriageAssociationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GuardianAssociation", Order = 3)]
        public System.Collections.Generic.List<GuardianAssociationType> GuardianAssociation
        {
            get
            {
                return this.guardianAssociationField;
            }
            set
            {
                this.guardianAssociationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImmediateFamilyAssociation", Order = 4)]
        public System.Collections.Generic.List<ImmediateFamilyAssociationType> ImmediateFamilyAssociation
        {
            get
            {
                return this.immediateFamilyAssociationField;
            }
            set
            {
                this.immediateFamilyAssociationField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ImmediateFamilyAssociation", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class ImmediateFamilyAssociationType : nc.AssociationType
    {

        private System.Collections.Generic.List<ReferenceType> personParentReferenceField;

        private System.Collections.Generic.List<ReferenceType> personChildReferenceField;

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonParentReference", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        public System.Collections.Generic.List<ReferenceType> PersonParentReference
        {
            get
            {
                return this.personParentReferenceField;
            }
            set
            {
                this.personParentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonChildReference", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 1)]
        public System.Collections.Generic.List<ReferenceType> PersonChildReference
        {
            get
            {
                return this.personChildReferenceField;
            }
            set
            {
                this.personChildReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FamilyKinshipCode", typeof(FamilyKinshipCodeType), Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute("FamilyKinshipText", typeof(nc.TextType), Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 2)]
        public object Item
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


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ItemType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Item", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class ItemType : Niem.NiemCore.v20.ItemType
    {

        private System.Collections.Generic.List<nc.EntityType> itemOwnerField;

        private System.Collections.Generic.List<ObligationType> obligationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemOwner", IsNullable = true, Order = 0)]
        public System.Collections.Generic.List<nc.EntityType> ItemOwner
        {
            get
            {
                return this.itemOwnerField;
            }
            set
            {
                this.itemOwnerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Obligation", Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 1)]
        public System.Collections.Generic.List<ObligationType> Obligation
        {
            get
            {
                return this.obligationField;
            }
            set
            {
                this.obligationField = value;
            }
        }
    }

    public partial class LitigantGroupAssociationType : ComplexObjectType
    {

        private System.Collections.Generic.List<ReferenceType> attorneyReferenceField;

        private System.Collections.Generic.List<ReferenceType> caseRepresentedPartyReferenceField;

        private System.Collections.Generic.List<IdentificationType> litigantGroupIdentificationField;

        private nc.TextType litigantGroupNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttorneyReference", Order = 0)]
        public System.Collections.Generic.List<ReferenceType> AttorneyReference
        {
            get
            {
                return this.attorneyReferenceField;
            }
            set
            {
                this.attorneyReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseRepresentedPartyReference", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 1)]
        public System.Collections.Generic.List<ReferenceType> CaseRepresentedPartyReference
        {
            get
            {
                return this.caseRepresentedPartyReferenceField;
            }
            set
            {
                this.caseRepresentedPartyReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LitigantGroupIdentification", Order = 2)]
        public System.Collections.Generic.List<IdentificationType> LitigantGroupIdentification
        {
            get
            {
                return this.litigantGroupIdentificationField;
            }
            set
            {
                this.litigantGroupIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public nc.TextType LitigantGroupName
        {
            get
            {
                return this.litigantGroupNameField;
            }
            set
            {
                this.litigantGroupNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CaseAugmentationType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CaseAugmentation", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class CaseAugmentationType :  Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType
    {

        private System.Collections.Generic.List<ItemType> item1Field;

        private System.Collections.Generic.List<LitigantGroupAssociationType> litigantGroupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item", Order = 0)]
        public System.Collections.Generic.List<ItemType> Item
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LitigantGroup", Order = 1)]
        public System.Collections.Generic.List<LitigantGroupAssociationType> LitigantGroup
        {
            get
            {
                return this.litigantGroupField;
            }
            set
            {
                this.litigantGroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CaseLineageCase", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class CaseLineageCaseType : nc.CaseType
    {

        private j.CaseAugmentationType caseAugmentationField;

        private ecf.CaseAugmentationType caseAugmentation1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public j.CaseAugmentationType CaseAugmentation
        {
            get
            {
                return this.caseAugmentationField;
            }
            set
            {
                this.caseAugmentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 1)]
        public ecf.CaseAugmentationType ECFCaseAugmentation
        {
            get
            {
                return this.caseAugmentation1Field;
            }
            set
            {
                this.caseAugmentation1Field = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CaseParticipantType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CaseParticipant", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class CaseParticipantType :  ecf.CaseParticipantType
    {
        
        private niemxsd.Boolean casePartySelfRepresentationIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public niemxsd.Boolean CasePartySelfRepresentationIndicator
        {
            get
            {
                return this.casePartySelfRepresentationIndicatorField;
            }
            set
            {
                this.casePartySelfRepresentationIndicatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CivilCaseType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CivilCase", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class CivilCaseType : civil.CivilCaseType
    {

        private nc.TextType caseGeneralCategoryTextField;

        private nc.TextType caseSubCategoryTextField;

        private nc.TextType counterClaimDescriptionField;

        private System.Collections.Generic.List<MarriageAssociationType> marriageAssociationField;

        private System.Collections.Generic.List<GuardianAssociationType> guardianAssociationField;

        private System.Collections.Generic.List<ImmediateFamilyAssociationType> immediateFamilyAssociationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public nc.TextType CaseGeneralCategoryText
        {
            get
            {
                return this.caseGeneralCategoryTextField;
            }
            set
            {
                this.caseGeneralCategoryTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public nc.TextType CaseSubCategoryText
        {
            get
            {
                return this.caseSubCategoryTextField;
            }
            set
            {
                this.caseSubCategoryTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public nc.TextType CounterClaimDescription
        {
            get
            {
                return this.counterClaimDescriptionField;
            }
            set
            {
                this.counterClaimDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MarriageAssociation", Order = 3)]
        public System.Collections.Generic.List<MarriageAssociationType> MarriageAssociation
        {
            get
            {
                return this.marriageAssociationField;
            }
            set
            {
                this.marriageAssociationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GuardianAssociation", Order = 4)]
        public System.Collections.Generic.List<GuardianAssociationType> GuardianAssociation
        {
            get
            {
                return this.guardianAssociationField;
            }
            set
            {
                this.guardianAssociationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImmediateFamilyAssociation", Order = 5)]
        public System.Collections.Generic.List<ImmediateFamilyAssociationType> ImmediateFamilyAssociation
        {
            get
            {
                return this.immediateFamilyAssociationField;
            }
            set
            {
                this.immediateFamilyAssociationField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CoreFilingMessageType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CoreFilingMessage", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class CoreFilingMessageType : core.CoreFilingMessageType
    {

        private nc.EntityType documentFilerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public nc.EntityType DocumentFiler
        {
            get
            {
                return this.documentFilerField;
            }
            set
            {
                this.documentFilerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CourtType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CourtEventCourt", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = true)]
    public partial class CourtType : j.CourtType
    {

        private nc.TextType courtDivisionTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public nc.TextType CourtDivisionText
        {
            get
            {
                return this.courtDivisionTextField;
            }
            set
            {
                this.courtDivisionTextField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CourtEventType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CaseCourtEvent", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class CourtEventType : ecf.CourtEventType
    {

        private System.Collections.Generic.List<nc.TextType> activityCategoryTextField;

        private System.Collections.Generic.List<nc.TextType> activityReasonTextField;

        private System.Collections.Generic.List<ReferenceType> courtEventDocumentReferenceField;

        private CourtType courtEventCourtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityCategoryText", IsNullable = true, Order = 0)]
        public System.Collections.Generic.List<nc.TextType> ActivityCategoryText
        {
            get
            {
                return this.activityCategoryTextField;
            }
            set
            {
                this.activityCategoryTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityReasonText", IsNullable = true, Order = 1)]
        public System.Collections.Generic.List<nc.TextType> ActivityReasonText
        {
            get
            {
                return this.activityReasonTextField;
            }
            set
            {
                this.activityReasonTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CourtEventDocumentReference", Order = 2)]
        public System.Collections.Generic.List<ReferenceType> CourtEventDocumentReference
        {
            get
            {
                return this.courtEventDocumentReferenceField;
            }
            set
            {
                this.courtEventDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public CourtType CourtEventCourt
        {
            get
            {
                return this.courtEventCourtField;
            }
            set
            {
                this.courtEventCourtField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IdentificationType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CaseOfficialCaseIdentification", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class IdentificationType :  Niem.NiemCore.v20.IdentificationType
    {

        private nc.DateType identificationEffectiveDateField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public nc.DateType IdentificationEffectiveDate
        {
            get
            {
                return this.identificationEffectiveDateField;
            }
            set
            {
                this.identificationEffectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://niem.gov/niem/structures/2.0", DataType = "IDREF", AttributeName = "ref")]
        public string Ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("FilingAttorney", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = true)]
    public partial class FilingAttorneyType : j.CaseOfficialType
    {

        private IdentificationType judicialOfficialRegistrationIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public IdentificationType JudicialOfficialRegistrationIdentification
        {
            get
            {
                return this.judicialOfficialRegistrationIdentificationField;
            }
            set
            {
                this.judicialOfficialRegistrationIdentificationField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ObligationType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Obligation", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class ObligationType : Niem.NiemCore.v20.ObligationType
    {

        private nc.NumericType obligationCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public nc.NumericType ObligationCount
        {
            get
            {
                return this.obligationCountField;
            }
            set
            {
                this.obligationCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("EntityOrganization", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class OrganizationType : ComplexObjectType
    {

        private System.Collections.Generic.List<IdentificationType> organizationIdentificationField;

        private nc.LocationType organizationLocationField;

        private nc.TextType organizationNameField;

        private nc.ContactInformationType organizationPrimaryContactInformationField;

        private nc.TextType organizationSubUnitNameField;

        private IdentificationType organizationTaxIdentificationField;

        private nc.TextType organizationUnitNameField;

        private j.OrganizationAugmentationType organizationAugmentationField;

        private ecf.OrganizationAugmentationType ecforganizationAugmentationField;

        public OrganizationType()
        {

        }

        public OrganizationType
            (
                string id,
                string eportalOrganizationId,
                string name,
                string eportalUnitId,
                string unitName,
                string eportalSubUnitId,
                string subUnitName,
                string address1,
                string address2,
                string city,
                string state,
                string zipCode,
                string phoneNumber,
                string extension,
                string emailAddress
            )
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                this.organizationNameField = new nc.TextType(name);
            }
            if (!string.IsNullOrWhiteSpace(unitName))
            {
                this.organizationUnitNameField = new nc.TextType(unitName);
            }
            if (!string.IsNullOrWhiteSpace(subUnitName))
            {
                this.organizationSubUnitNameField = new nc.TextType(subUnitName);
            }

            this.organizationPrimaryContactInformationField = new nc.ContactInformationType(address1: address1, address2: address2, city: city, state: state, zipCode: zipCode, phoneNumber: phoneNumber, extension: extension, emailAddress: emailAddress);

        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationIdentification", Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 0)]
        public System.Collections.Generic.List<IdentificationType> OrganizationIdentification
        {
            get
            {
                return this.organizationIdentificationField;
            }
            set
            {
                this.organizationIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 1)]
        public nc.LocationType OrganizationLocation
        {
            get
            {
                return this.organizationLocationField;
            }
            set
            {
                this.organizationLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 2)]
        public nc.TextType OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 3)]
        public nc.ContactInformationType OrganizationPrimaryContactInformation
        {
            get
            {
                return this.organizationPrimaryContactInformationField;
            }
            set
            {
                this.organizationPrimaryContactInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 4)]
        public nc.TextType OrganizationSubUnitName
        {
            get
            {
                return this.organizationSubUnitNameField;
            }
            set
            {
                this.organizationSubUnitNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 5)]
        public IdentificationType OrganizationTaxIdentification
        {
            get
            {
                return this.organizationTaxIdentificationField;
            }
            set
            {
                this.organizationTaxIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 6)]
        public nc.TextType OrganizationUnitName
        {
            get
            {
                return this.organizationUnitNameField;
            }
            set
            {
                this.organizationUnitNameField = value;
            }
        }

        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName="OrganizationAugmentation1" , Type=typeof(j.OrganizationAugmentationType), Namespace="http://niem.gov/niem/domains/jxdm/4.0" , Order=7, IsNullable=true)]
        public j.OrganizationAugmentationType OrganizationAugmentation
        {
            get
            {
                return this.organizationAugmentationField;
            }
            set
            {
                this.organizationAugmentationField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(ElementName= "OrganizationAugmentation", Type=typeof(ecf.OrganizationAugmentationType), Order = 8, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", IsNullable = true)]
        public ecf.OrganizationAugmentationType ECFOrganizationAugmentation
        {
            get
            {
                return this.ecforganizationAugmentationField;
            }
            set
            {
                this.ecforganizationAugmentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DocumentMetadataType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentMetadata", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class DocumentMetadataType : ecf.DocumentMetadataType
    {

        private nc.EntityType documentSignerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public nc.EntityType DocumentSigner
        {
            get
            {
                return this.documentSignerField;
            }
            set
            {
                this.documentSignerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DocumentType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("FilingConnectedDocument", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class DocumentType : ecf.DocumentType
    {

        private nc.TextType documentCategoryIDField;

        private nc.TextType documentCategoryNameField;

        private ActivityRequestType activityRequestField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public nc.TextType DocumentCategoryID
        {
            get
            {
                return this.documentCategoryIDField;
            }
            set
            {
                this.documentCategoryIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public nc.TextType DocumentCategoryName
        {
            get
            {
                return this.documentCategoryNameField;
            }
            set
            {
                this.documentCategoryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ActivityRequestType ActivityRequest
        {
            get
            {
                return this.activityRequestField;
            }
            set
            {
                this.activityRequestField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReviewedDocumentType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ReviewedConnectedDocument", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class ReviewedDocumentType : ecf.ReviewedDocumentType
    {

        private nc.TextType documentCategoryIDField;

        private nc.TextType documentCategoryNameField;

        private ActivityRequestType activityRequestField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public nc.TextType DocumentCategoryID
        {
            get
            {
                return this.documentCategoryIDField;
            }
            set
            {
                this.documentCategoryIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public nc.TextType DocumentCategoryName
        {
            get
            {
                return this.documentCategoryNameField;
            }
            set
            {
                this.documentCategoryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ActivityRequestType ActivityRequest
        {
            get
            {
                return this.activityRequestField;
            }
            set
            {
                this.activityRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://niem.gov/niem/structures/2.0", DataType = "IDREF", AttributeName = "ref")]
        public string Ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RecordDocketingMessageType", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("RecordDocketingMessage", Namespace = "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0", IsNullable = false)]
    public partial class RecordDocketingMessageType : docket.RecordDocketingMessageType
    {

        private nc.CaseType caseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 0)]
        public nc.CaseType Case
        {
            get
            {
                return this.caseField;
            }
            set
            {
                this.caseField = value;
            }
        }
    }

}
