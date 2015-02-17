/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    ECFHelperTypes.cs
	'   Created Date:   
	'   Description:    
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
 	'=======================================================================
    '   Rao 03/02/2014 Added CountryCode , Country
 *  '   Rao 06/12/2013 Changed Extension to  PhoneNumberExtension , Added WorkPhoneExtension
	'=======================================================================
	*/

namespace Oasis.LegalXml.CourtFiling.v40.EcfHelperTypes
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:HelperTypes-4.0", TypeName="PersonType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:HelperTypes-4.0", IsNullable=true, ElementName="Person")]
    public partial class PersonType
    {
        
        private string idField;
        private string prefixField;
        private string surNameField;
        
        private string givenNameField;
        
        private string middleNameField;
        
        private string suffixField;
        
        private string suffixCodeField;
        
        private string fullNameField;
        
        private string eportalUserIdField;
        
        private ContactInformationType contactInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0, ElementName="Id")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "Prefix")]
        public string Prefix
        {
            get
            {
                return this.prefixField;
            }
            set
            {
                this.prefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2, ElementName = "GivenName")]
        public string GivenName
        {
            get
            {
                return this.givenNameField;
            }
            set
            {
                this.givenNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3, ElementName = "MiddleName")]
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }
        

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4, ElementName = "SurName")]
        public string SurName
        {
            get
            {
                return this.surNameField;
            }
            set
            {
                this.surNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5, ElementName="Suffix")]
        public string Suffix
        {
            get
            {
                return this.suffixField;
            }
            set
            {
                this.suffixField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6, ElementName="SuffixCode")]
        public string SuffixCode
        {
            get
            {
                return this.suffixCodeField;
            }
            set
            {
                this.suffixCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7, ElementName = "FullName")]
        public string FullName
        {
            get
            {
                return this.fullNameField;
            }
            set
            {
                this.fullNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8, ElementName="EportalUserId")]
        public string EportalUserId
        {
            get
            {
                return this.eportalUserIdField;
            }
            set
            {
                this.eportalUserIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9, ElementName="ContactInformation")]
        public ContactInformationType ContactInformation
        {
            get
            {
                return this.contactInformationField;
            }
            set
            {
                this.contactInformationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:HelperTypes-4.0", TypeName="ContactInformationType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:HelperTypes-4.0", IsNullable=true, ElementName="ContactInformation")]
    public partial class ContactInformationType
    {
        
        private string address1Field;
        
        private string address2Field;
        
        private string cityField;
        
        private string stateField;
        
        private string zipCodeField;
        
        private string primaryPhoneNumberField;
        private string phoneNumberExtensionField;

        private string emailAddressField;
        
        private string homePhoneNumberField;
        
        private string workPhoneNumberField;
        
        private string mobilePhoneNumberField;
        
        private string faxPhoneNumberField;

        private string addressFullTextField;
        private string workPhoneNumberExtensionField;

        private string countryCodeField;
        private string countryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0, ElementName="Address1")]
        public string Address1
        {
            get
            {
                return this.address1Field;
            }
            set
            {
                this.address1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1, ElementName="Address2")]
        public string Address2
        {
            get
            {
                return this.address2Field;
            }
            set
            {
                this.address2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2, ElementName="City")]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3, ElementName="State")]
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4, ElementName="ZipCode")]
        public string ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5, ElementName="PrimaryPhoneNumber")]
        public string PrimaryPhoneNumber
        {
            get
            {
                return this.primaryPhoneNumberField;
            }
            set
            {
                this.primaryPhoneNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6, ElementName = "PhoneNumberExtension")]
        public string PhoneNumberExtension
        {
            get
            {
                return this.phoneNumberExtensionField;
            }
            set
            {
                this.phoneNumberExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7, ElementName="EmailAddress")]
        public string EmailAddress
        {
            get
            {
                return this.emailAddressField;
            }
            set
            {
                this.emailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8, ElementName="HomePhoneNumber")]
        public string HomePhoneNumber
        {
            get
            {
                return this.homePhoneNumberField;
            }
            set
            {
                this.homePhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9, ElementName="WorkPhoneNumber")]
        public string WorkPhoneNumber
        {
            get
            {
                return this.workPhoneNumberField;
            }
            set
            {
                this.workPhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10, ElementName="MobilePhoneNumber")]
        public string MobilePhoneNumber
        {
            get
            {
                return this.mobilePhoneNumberField;
            }
            set
            {
                this.mobilePhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11, ElementName="FaxPhoneNumber")]
        public string FaxPhoneNumber
        {
            get
            {
                return this.faxPhoneNumberField;
            }
            set
            {
                this.faxPhoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12, ElementName = "AddressFullText")]
        public string AddressFullText
        {
            get
            {
                return this.addressFullTextField;
            }
            set
            {
                this.addressFullTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13, ElementName = "WorkPhoneNumberExtension")]
        public string WorkPhoneNumberExtension
        {
            get
            {
                return this.workPhoneNumberExtensionField;
            }
            set
            {
                this.workPhoneNumberExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14, ElementName = "CountryCode")]
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15, ElementName = "Country")]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:HelperTypes-4.0", TypeName="OrganizationType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:HelperTypes-4.0", IsNullable=true, ElementName="Organization")]
    public partial class OrganizationType
    {
        
        private string idField;
        
        private string eportalOrganizationIdField;
        
        private string nameField;
        
        private string eportalUnitIdField;
        
        private string unitNameField;
        
        private string eportalSubUnitIdField;
        
        private string subUnitNameField;
        
        private ContactInformationType contactInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0, ElementName="Id")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1, ElementName="EportalOrganizationId")]
        public string EportalOrganizationId
        {
            get
            {
                return this.eportalOrganizationIdField;
            }
            set
            {
                this.eportalOrganizationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2, ElementName="Name")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3, ElementName="EportalUnitId")]
        public string EportalUnitId
        {
            get
            {
                return this.eportalUnitIdField;
            }
            set
            {
                this.eportalUnitIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4, ElementName="UnitName")]
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5, ElementName="EportalSubUnitId")]
        public string EportalSubUnitId
        {
            get
            {
                return this.eportalSubUnitIdField;
            }
            set
            {
                this.eportalSubUnitIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6, ElementName="SubUnitName")]
        public string SubUnitName
        {
            get
            {
                return this.subUnitNameField;
            }
            set
            {
                this.subUnitNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7, ElementName="ContactInformation")]
        public ContactInformationType ContactInformation
        {
            get
            {
                return this.contactInformationField;
            }
            set
            {
                this.contactInformationField = value;
            }
        }
    }
}
