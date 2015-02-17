#region WSCF
//------------------------------------------------------------------------------
// <autogenerated code>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated code>
//------------------------------------------------------------------------------
// File time 12-09-08 03:37 PM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion

using System;
using System.ComponentModel;
using System.Text; 

namespace Niem.Structures.v20
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/structures/2.0", TypeName="AugmentationType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/structures/2.0", IsNullable=true, ElementName="AugmentationType")]
    
    public abstract partial class AugmentationType : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        /// <remarks/>
        private string id;
        
        /// <remarks/>
        private string metadata;
        
        public AugmentationType()
        {
        }
        
        public AugmentationType(string id, string metadata)
        {
            this.id = id;
            this.metadata = metadata;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="ID", AttributeName="id")]
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
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="IDREFS", AttributeName="metadata")]
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
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [field: NonSerialized]

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/structures/2.0", TypeName="ComplexObjectType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/structures/2.0", IsNullable=true, ElementName="ComplexObjectType")]
    
    public abstract partial class ComplexObjectType : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        /// <remarks/>
        private string id;
        
        /// <remarks/>
        private string metadata;
        
        /// <remarks/>
        private string linkMetadata;
        
        public ComplexObjectType()
        {
        }
        
        public ComplexObjectType(string id, string metadata, string linkMetadata)
        {
            this.id = id;
            this.metadata = metadata;
            this.linkMetadata = linkMetadata;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="ID", AttributeName="id")]
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
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="IDREFS", AttributeName="metadata")]
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
                    this.RaisePropertyChanged("Metadata");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="IDREFS", AttributeName="linkMetadata")]
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
                    this.RaisePropertyChanged("LinkMetadata");
                }
            }
        }

        [field: NonSerialized] 

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/structures/2.0", TypeName="MetadataType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/structures/2.0", IsNullable=true, ElementName="MetadataType")]
    
    public abstract partial class MetadataType : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        /// <remarks/>
        private string id;
        
        public MetadataType()
        {
        }
        
        public MetadataType(string id)
        {
            this.id = id;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="ID", AttributeName="id")]
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
                    this.RaisePropertyChanged("LinkMetadata");
                }
            }
        }

        [field: NonSerialized]

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

    }



    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/structures/2.0", TypeName="ReferenceType")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://niem.gov/niem/structures/2.0", IsNullable=true, ElementName="ReferenceType")]
    public partial class ReferenceType : object 
    {
        
        /// <remarks/>
        private string id;
        
        /// <remarks/>
        private string @ref;
        
        /// <remarks/>
        private string linkMetadata;
        
        public ReferenceType()
        {
        }
        public ReferenceType(string @ref) : this(null , @ref , null) 
        {

        }

        
        public ReferenceType(string id, string @ref, string linkMetadata)
        {
            this.id = id;
            this.@ref = @ref;
            this.linkMetadata = linkMetadata;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="ID", AttributeName="id")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="IDREF", AttributeName="ref")]
        public string Ref
        {
            get
            {
                return this.@ref;
            }
            set
            {
                if ((this.@ref != value))
                {
                    this.@ref = value;
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="IDREFS", AttributeName="linkMetadata")]
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
        
    }
}
