#region WSCF
//------------------------------------------------------------------------------
// <autogenerated code>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated code>
//------------------------------------------------------------------------------
// File time 26-11-08 02:30 PM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion


namespace Niem.NonauthoritativeCode.v20
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/nonauthoritative-code/2.0", TypeName="FamilyKinshipCodeSimpleType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/nonauthoritative-code/2.0", IsNullable=false, ElementName="FamilyKinshipCodeSimpleType")]
    public enum FamilyKinshipCodeSimpleType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="adoption")]
        Adoption,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="biological")]
        Biological,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="foster")]
        Foster,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="marriage")]
        Marriage,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/nonauthoritative-code/2.0", TypeName="FamilyKinshipCodeType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/nonauthoritative-code/2.0", IsNullable=true, ElementName="FamilyKinshipCodeType")]
    
    public partial class FamilyKinshipCodeType : object 
    {
        
        /// <remarks/>
        private string id;
        
        /// <remarks/>
        private string metadata;
        
        /// <remarks/>
        private string linkMetadata;
        
        /// <remarks/>
        private FamilyKinshipCodeSimpleType value;
        
        public FamilyKinshipCodeType()
        {
        }
        
        public FamilyKinshipCodeType(string id, string metadata, string linkMetadata, FamilyKinshipCodeSimpleType value)
        {
            this.id = id;
            this.metadata = metadata;
            this.linkMetadata = linkMetadata;
            this.value = value;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://niem.gov/niem/structures/2.0", DataType="ID", AttributeName="id")]
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if ((this.id != value))
                {
                    this.id = value;
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://niem.gov/niem/structures/2.0", DataType="IDREFS", AttributeName="metadata")]
        public string Metadata
        {
            get
            {
                return this.metadata;
            }
            set
            {
                if ((this.metadata != value))
                {
                    this.metadata = value;
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://niem.gov/niem/structures/2.0", DataType="IDREFS", AttributeName="linkMetadata")]
        public string LinkMetadata
        {
            get
            {
                return this.linkMetadata;
            }
            set
            {
                if ((this.linkMetadata != value))
                {
                    this.linkMetadata = value;
                }
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public FamilyKinshipCodeSimpleType Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if ((this.value != value))
                {
                    this.value = value;
                }
            }
        }
        
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/nonauthoritative-code/2.0", TypeName="MarriageCategoryCodeSimpleType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/nonauthoritative-code/2.0", IsNullable=false, ElementName="MarriageCategoryCodeSimpleType")]
    public enum MarriageCategoryCodeSimpleType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("civil union")]
        Civilunion,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("common law")]
        Commonlaw,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="married")]
        Married,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="unknown")]
        Unknown,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/nonauthoritative-code/2.0", TypeName="MarriageCategoryCodeType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/nonauthoritative-code/2.0", IsNullable=true, ElementName="MarriageCategoryCodeType")]
    
    public partial class MarriageCategoryCodeType : object 
    {
        
        /// <remarks/>
        private string id;
        
        /// <remarks/>
        private string metadata;
        
        /// <remarks/>
        private string linkMetadata;
        
        /// <remarks/>
        private MarriageCategoryCodeSimpleType value;
        
        public MarriageCategoryCodeType()
        {
        }
        
        public MarriageCategoryCodeType(string id, string metadata, string linkMetadata, MarriageCategoryCodeSimpleType value)
        {
            this.id = id;
            this.metadata = metadata;
            this.linkMetadata = linkMetadata;
            this.value = value;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://niem.gov/niem/structures/2.0", DataType="ID", AttributeName="id")]
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if ((this.id != value))
                {
                    this.id = value;
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://niem.gov/niem/structures/2.0", DataType="IDREFS", AttributeName="metadata")]
        public string Metadata
        {
            get
            {
                return this.metadata;
            }
            set
            {
                if ((this.metadata != value))
                {
                    this.metadata = value;
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://niem.gov/niem/structures/2.0", DataType="IDREFS", AttributeName="linkMetadata")]
        public string LinkMetadata
        {
            get
            {
                return this.linkMetadata;
            }
            set
            {
                if ((this.linkMetadata != value))
                {
                    this.linkMetadata = value;
                }
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public MarriageCategoryCodeSimpleType Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if ((this.value != value))
                {
                    this.value = value;
                }
            }
        }
        
    }
}