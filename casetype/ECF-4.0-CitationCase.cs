#region WSCF
//------------------------------------------------------------------------------
// <autogenerated code>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated code>
//------------------------------------------------------------------------------
// File time 12-01-10 09:48 AM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion

using Oasis.LegalXml.CourtFiling.v40.Ecf;
using Niem.NiemCore.v20;
using Niem.Proxy.xsd.v20;
using Niem.Structures.v20;
using Niem.Domains.Jxdm.v40;

namespace Oasis.LegalXml.CourtFiling.v40.Citation
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", TypeName = "CitationCaseType")]
    [System.Xml.Serialization.XmlRootAttribute("CitationCase", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", IsNullable = false, ElementName = "CitationCase")]
    public partial class CitationCaseType : Niem.NiemCore.v20.CaseType
    {

        
        private Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation;
        private Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType ecfCaseAugmentation;
        private CitationCaseAugmentationType citationCaseAugmentation;

        public CitationCaseType()
        {
        }

        public CitationCaseType(Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation, Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType ecfCaseAugmentation, CitationCaseAugmentationType citationCaseAugmentation)
        {
            this.caseAugmentation = caseAugmentation;
            this.ecfCaseAugmentation = ecfCaseAugmentation;
            this.citationCaseAugmentation = citationCaseAugmentation;
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
                    throw new System.ArgumentNullException("CaseAugmentation1");
                }
                if ((this.ecfCaseAugmentation != value))
                {
                    this.ecfCaseAugmentation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2, ElementName = "CitationCaseAugmentation")]
        public CitationCaseAugmentationType CitationCaseAugmentation
        {
            get
            {
                return this.citationCaseAugmentation;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CitationCaseAugmentation");
                }
                if ((this.citationCaseAugmentation != value))
                {
                    this.citationCaseAugmentation = value;
                }
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", TypeName = "CitationCaseAugmentationType")]
    [System.Xml.Serialization.XmlRootAttribute("CitationCaseAugmentation", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", IsNullable = false, ElementName = "CitationCaseAugmentation")]
    public partial class CitationCaseAugmentationType : ComplexObjectType
    {

        private Niem.Domains.Jxdm.v40.CitationType citation;
        private System.Collections.Generic.List<Niem.Domains.Jxdm.v40.ChargeType> caseCharge;
        private System.Collections.Generic.List<Niem.Domains.Jxdm.v40.ViolatedStatuteAssociationType> violatedStatuteAssociation;
        private Niem.Domains.Jxdm.v40.CourtAppearanceType courtAppearance;
        private SubjectType citationSubject;
        private Niem.NiemCore.v20.IncidentType incident; // one of driving incident of parking violation

        public CitationCaseAugmentationType()
        {
        }

        public CitationCaseAugmentationType(Niem.Domains.Jxdm.v40.CitationType citation, System.Collections.Generic.List<Niem.Domains.Jxdm.v40.ChargeType> caseCharge, System.Collections.Generic.List<Niem.Domains.Jxdm.v40.ViolatedStatuteAssociationType> violatedStatuteAssociation, Niem.Domains.Jxdm.v40.CourtAppearanceType courtAppearance, SubjectType citationSubject, Niem.NiemCore.v20.IncidentType incident)
        {
            this.citation = citation;
            this.caseCharge = caseCharge;
            this.violatedStatuteAssociation = violatedStatuteAssociation;
            this.courtAppearance = courtAppearance;
            this.citationSubject = citationSubject;
            this.incident = incident;
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", IsNullable = true, Order = 0, ElementName = "Citation")]
        public Niem.Domains.Jxdm.v40.CitationType Citation
        {
            get
            {
                return this.citation;
            }
            set
            {
                if ((this.citation != value))
                {
                    this.citation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CaseCharge", Namespace = "http://niem.gov/niem/domains/jxdm/4.0", IsNullable = true, Order = 1)]
        public System.Collections.Generic.List<Niem.Domains.Jxdm.v40.ChargeType> CaseCharge
        {
            get
            {
                return this.caseCharge;
            }
            set
            {
                if ((this.caseCharge != value))
                {
                    this.caseCharge = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ViolatedStatuteAssociation", Namespace = "http://niem.gov/niem/domains/jxdm/4.0", IsNullable = true, Order = 2)]
        public System.Collections.Generic.List<Niem.Domains.Jxdm.v40.ViolatedStatuteAssociationType> ViolatedStatuteAssociation
        {
            get
            {
                return this.violatedStatuteAssociation;
            }
            set
            {
                if ((this.violatedStatuteAssociation != value))
                {
                    this.violatedStatuteAssociation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", IsNullable = true, Order = 3, ElementName = "CourtAppearance")]
        public Niem.Domains.Jxdm.v40.CourtAppearanceType CourtAppearance
        {
            get
            {
                return this.courtAppearance;
            }
            set
            {
                if ((this.courtAppearance != value))
                {
                    this.courtAppearance = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4, ElementName = "CitationSubject")]
        public SubjectType CitationSubject
        {
            get
            {
                return this.citationSubject;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CitationSubject");
                }
                if ((this.citationSubject != value))
                {
                    this.citationSubject = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("DrivingIncident", typeof(DrivingIncidentType), Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute("ParkingViolation", typeof(ParkingViolationType), Order = 5)]
        public Niem.NiemCore.v20.IncidentType Incident 
        {
            get
            {
                return this.incident;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("Incident");
                }
                if ((this.incident != value))
                {
                    this.incident = value;
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DrivingIncidentType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0")]
    [System.Xml.Serialization.XmlRootAttribute("DrivingIncident", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", IsNullable = false, ElementName = "DrivingIncident")]
    public partial class DrivingIncidentType : Niem.Domains.Jxdm.v40.DrivingIncidentType
    {

        private System.Collections.Generic.List<Niem.NiemCore.v20.ActivityConveyanceAssociationType> incidentVehicleAssociation;
        private Boolean redLightCameraIndicator;

        public DrivingIncidentType()
        {
        }

        public DrivingIncidentType(System.Collections.Generic.List<Niem.NiemCore.v20.ActivityConveyanceAssociationType> incidentVehicleAssociation, Boolean redLightCameraIndicator)
        {
            this.incidentVehicleAssociation = incidentVehicleAssociation;
            this.redLightCameraIndicator = redLightCameraIndicator;
        }

        [System.Xml.Serialization.XmlElementAttribute("IncidentVehicleAssociation", Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 0)]
        public System.Collections.Generic.List<Niem.NiemCore.v20.ActivityConveyanceAssociationType> IncidentVehicleAssociation
        {
            get
            {
                return this.incidentVehicleAssociation;
            }
            set
            {
                if ((this.incidentVehicleAssociation != value))
                {
                    this.incidentVehicleAssociation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "RedLightCameraIndicator")]
        public Boolean RedLightCameraIndicator
        {
            get
            {
                return this.redLightCameraIndicator;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("RedLightCameraIndicator");
                }
                if ((this.redLightCameraIndicator != value))
                {
                    this.redLightCameraIndicator = value;
                }
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", TypeName = "ParkingViolationType")]
    [System.Xml.Serialization.XmlRootAttribute("ParkingViolation", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", IsNullable = false, ElementName = "ParkingViolation")]
    public partial class ParkingViolationType : Niem.NiemCore.v20.IncidentType
    {
        private Niem.Domains.Jxdm.v40.IncidentAugmentationType incidentAugmentation;
        private Niem.NiemCore.v20.ActivityConveyanceAssociationType incidentVehicleAssociation;
        private TextType parkingFacilityName;
        private NumericType parkingMeterSpaceNumber;

        public ParkingViolationType()
        {
        }

        public ParkingViolationType(Niem.Domains.Jxdm.v40.IncidentAugmentationType incidentAugmentation, Niem.NiemCore.v20.ActivityConveyanceAssociationType incidentVehicleAssociation, TextType parkingFacilityName, NumericType parkingMeterSpaceNumber)
        {
            this.incidentAugmentation = incidentAugmentation;
            this.incidentVehicleAssociation = incidentVehicleAssociation;
            this.parkingFacilityName = parkingFacilityName;
            this.parkingMeterSpaceNumber = parkingMeterSpaceNumber;
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0, ElementName = "IncidentAugmentation")]
        public Niem.Domains.Jxdm.v40.IncidentAugmentationType IncidentAugmentation
        {
            get
            {
                return this.incidentAugmentation;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("IncidentAugmentation");
                }
                if ((this.incidentAugmentation != value))
                {
                    this.incidentAugmentation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 1, ElementName = "IncidentVehicleAssociation")]
        public Niem.NiemCore.v20.ActivityConveyanceAssociationType IncidentVehicleAssociation
        {
            get
            {
                return this.incidentVehicleAssociation;
            }
            set
            {
                if ((this.incidentVehicleAssociation != value))
                {
                    this.incidentVehicleAssociation = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2, ElementName = "ParkingFacilityName")]
        public TextType ParkingFacilityName
        {
            get
            {
                return this.parkingFacilityName;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("ParkingFacilityName");
                }
                if ((this.parkingFacilityName != value))
                {
                    this.parkingFacilityName = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3, ElementName = "ParkingMeterSpaceNumber")]
        public NumericType ParkingMeterSpaceNumber
        {
            get
            {
                return this.parkingMeterSpaceNumber;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("ParkingMeterSpaceNumber");
                }
                if ((this.parkingMeterSpaceNumber != value))
                {
                    this.parkingMeterSpaceNumber = value;
                }
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SubjectType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0")]
    [System.Xml.Serialization.XmlRootAttribute("CitationSubject", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", IsNullable = false, ElementName = "SubjectType2")]
    public partial class SubjectType : Ecf.SubjectType 
    {

        /// <remarks/>
        private TextType personBloodAlcoholNumber;

        public SubjectType()
        {
        }

        public SubjectType(TextType personBloodAlcoholNumber)
        {
            this.personBloodAlcoholNumber = personBloodAlcoholNumber;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "PersonBloodAlcoholNumber")]
        public TextType PersonBloodAlcoholNumber
        {
            get
            {
                return this.personBloodAlcoholNumber;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("PersonBloodAlcoholNumber");
                }
                if ((this.personBloodAlcoholNumber != value))
                {
                    this.personBloodAlcoholNumber = value;
                }
            }
        }
    }






    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VehicleType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0")]
    [System.Xml.Serialization.XmlRootAttribute("VehicleType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", IsNullable = true, ElementName = "VehicleType")]
    public partial class VehicleType : Niem.NiemCore.v20.VehicleType
    {

        private Ecf.InsuranceType vehicleOwnerInsuranceCoverage;

        private Ecf.InsuranceType vehicleOperatorInsuranceCoverage;

        public VehicleType()
        {
        }

        public VehicleType(Ecf.InsuranceType vehicleOwnerInsuranceCoverage, Ecf.InsuranceType vehicleOperatorInsuranceCoverage)
        {
            this.vehicleOwnerInsuranceCoverage = vehicleOwnerInsuranceCoverage;
            this.vehicleOperatorInsuranceCoverage = vehicleOperatorInsuranceCoverage;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "VehicleOwnerInsuranceCoverage")]
        public Ecf.InsuranceType VehicleOwnerInsuranceCoverage
        {
            get
            {
                return this.vehicleOwnerInsuranceCoverage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("VehicleOwnerInsuranceCoverage");
                }
                if ((this.vehicleOwnerInsuranceCoverage != value))
                {
                    this.vehicleOwnerInsuranceCoverage = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "VehicleOperatorInsuranceCoverage")]
        public Ecf.InsuranceType VehicleOperatorInsuranceCoverage
        {
            get
            {
                return this.vehicleOperatorInsuranceCoverage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("VehicleOperatorInsuranceCoverage");
                }
                if ((this.vehicleOperatorInsuranceCoverage != value))
                {
                    this.vehicleOperatorInsuranceCoverage = value;
                }
            }
        }
    }



}
