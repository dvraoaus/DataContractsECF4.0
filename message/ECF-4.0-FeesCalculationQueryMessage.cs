/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    ECF-4.0-FeesCalculationQueryMessage.cs
	'   Created Date:   
	'   Description:    
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
 	'=======================================================================
    '   Rao     04/24/2012       Moved AddNameSpaces to EcfHelper
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
// File time 27-11-08 03:06 PM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion

using Oasis.LegalXml.CourtFiling.v40.Ecf;
using Oasis.LegalXml.CourtFiling.v40.Core;

namespace Oasis.LegalXml.CourtFiling.v40.Fees
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FeesCalculationQueryMessage-4." +
        "0", TypeName="FeesCalculationQueryMessageType")]
    [System.Xml.Serialization.XmlRootAttribute("FeesCalculationQueryMessage", Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FeesCalculationQueryMessage-4." +
        "0", IsNullable=false, ElementName="FeesCalculationQueryMessageType")]
    
    public partial class FeesCalculationQueryMessageType : QueryMessageType
    {
        
        /// <remarks/>
        private CoreFilingMessageType coreFilingMessage;

        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces = new System.Xml.Serialization.XmlSerializerNamespaces(); 

        public FeesCalculationQueryMessageType()
        {
            EcfHelper.AddNameSpaces(this.namespaces); 
        }


        
        public FeesCalculationQueryMessageType(CoreFilingMessageType coreFilingMessage)
        {
            EcfHelper.AddNameSpaces(this.namespaces); 
            this.coreFilingMessage = coreFilingMessage;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CoreFilingMessage-4.0", Order=0, ElementName="CoreFilingMessage")]
        public CoreFilingMessageType CoreFilingMessage
        {
            get
            {
                return this.coreFilingMessage;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CoreFilingMessage");
                }
                if ((this.coreFilingMessage != value))
                {
                    this.coreFilingMessage = value;
                    this.RaisePropertyChanged("CoreFilingMessage");
                }
            }
        }
    }
    
 }
