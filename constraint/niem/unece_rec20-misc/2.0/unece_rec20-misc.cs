#region WSCF
//------------------------------------------------------------------------------
// <autogenerated code>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated code>
//------------------------------------------------------------------------------
// File time 26-11-08 02:22 PM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion


namespace Niem.UneceRec20Misc.v20
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/unece_rec20-misc/2.0", TypeName="LengthCodeSimpleType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/unece_rec20-misc/2.0", IsNullable=false, ElementName="LengthCodeSimpleType")]
    public enum LengthCodeSimpleType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4H")]
        Item4H,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("77")]
        Item77,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="A11")]
        A11,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="A12")]
        A12,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="A45")]
        A45,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="A71")]
        A71,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="AK")]
        AK,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="B57")]
        B57,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="C45")]
        C45,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="C52")]
        C52,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="C63")]
        C63,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="CMT")]
        CMT,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="DMT")]
        DMT,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="FOT")]
        FOT,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="HMT")]
        HMT,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="INH")]
        INH,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="KMT")]
        KMT,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="M7")]
        M7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="MMT")]
        MMT,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="MTR")]
        MTR,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="NMI")]
        NMI,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="SMI")]
        SMI,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="X1")]
        X1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="YRD")]
        YRD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/unece_rec20-misc/2.0", TypeName="LengthCodeType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/unece_rec20-misc/2.0", IsNullable=true, ElementName="LengthCodeType")]
    
    public partial class LengthCodeType : object 
    {
        
        /// <remarks/>
        private string id;
        
        /// <remarks/>
        private string metadata;
        
        /// <remarks/>
        private string linkMetadata;
        
        /// <remarks/>
        private LengthCodeSimpleType value;
        
        public LengthCodeType()
        {
        }
        
        public LengthCodeType(string id, string metadata, string linkMetadata, LengthCodeSimpleType value)
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
        public LengthCodeSimpleType Value
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
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/unece_rec20-misc/2.0", TypeName="MassCodeSimpleType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/unece_rec20-misc/2.0", IsNullable=false, ElementName="MassCodeSimpleType")]
    public enum MassCodeSimpleType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2U")]
        Item2U,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="APZ")]
        APZ,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="CGM")]
        CGM,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="CWA")]
        CWA,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="CWI")]
        CWI,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="DG")]
        DG,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="DJ")]
        DJ,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="DTN")]
        DTN,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="GRM")]
        GRM,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="GRN")]
        GRN,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="HGM")]
        HGM,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="KGM")]
        KGM,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="KTN")]
        KTN,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="LBR")]
        LBR,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="LTN")]
        LTN,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="MC")]
        MC,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="MGM")]
        MGM,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="Mg")]
        Mg,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="ONZ")]
        ONZ,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="STI")]
        STI,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="STN")]
        STN,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(Name="TNE")]
        TNE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/unece_rec20-misc/2.0", TypeName="MassCodeType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/unece_rec20-misc/2.0", IsNullable=true, ElementName="MassCodeType")]
    
    public partial class MassCodeType : object 
    {
        
        /// <remarks/>
        private string id;
        
        /// <remarks/>
        private string metadata;
        
        /// <remarks/>
        private string linkMetadata;
        
        /// <remarks/>
        private MassCodeSimpleType value;
        
        public MassCodeType()
        {
        }
        
        public MassCodeType(string id, string metadata, string linkMetadata, MassCodeSimpleType value)
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
        public MassCodeSimpleType Value
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
