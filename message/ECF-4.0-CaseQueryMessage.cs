/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    ECF-4.0-CaseQueryMessage.cs
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
// File time 27-11-08 10:24 AM
//
// This source code was auto-generated by WsContractFirst, Version=0.7.6319.1
#endregion

using Oasis.LegalXml.CourtFiling.v40.Ecf;
using Niem.Proxy.xsd.v20;
using Niem.Structures.v20;
using Niem.NiemCore.v20;

namespace Oasis.LegalXml.CourtFiling.v40.CaseQuery
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseQueryMessage-4.0", TypeName = "CaseQueryMessageType")]
    [System.Xml.Serialization.XmlRootAttribute("CaseQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseQueryMessage-4.0", IsNullable = false, ElementName = "CaseQueryMessageType")]
    
    public partial class CaseQueryMessageType : QueryMessageType
    {

        /// <remarks/>
        private String caseTrackingID;

        /// <remarks/>
        private CaseQueryCriteriaType caseQueryCriteria;

        [field: System.NonSerialized]
        [System.Xml.Serialization.XmlNamespaceDeclarations]
        public System.Xml.Serialization.XmlSerializerNamespaces namespaces = new System.Xml.Serialization.XmlSerializerNamespaces(); 

        public CaseQueryMessageType()
        {
            EcfHelper.AddNameSpaces(this.namespaces);
        }

        public CaseQueryMessageType(String caseTrackingID, CaseQueryCriteriaType caseQueryCriteria)
        {
            EcfHelper.AddNameSpaces(this.namespaces);
            this.caseTrackingID = caseTrackingID;
            this.caseQueryCriteria = caseQueryCriteria;
        }


        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 0, ElementName = "CaseTrackingID")]
        public String CaseTrackingID
        {
            get
            {
                return this.caseTrackingID;
            }
            set
            {
                if ((this.caseTrackingID != value))
                {
                    this.caseTrackingID = value;
                    this.RaisePropertyChanged("CaseTrackingID");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "CaseQueryCriteria")]
        public CaseQueryCriteriaType CaseQueryCriteria
        {
            get
            {
                return this.caseQueryCriteria;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CaseQueryCriteria");
                }
                if ((this.caseQueryCriteria != value))
                {
                    this.caseQueryCriteria = value;
                    this.RaisePropertyChanged("CaseQueryCriteria");
                }
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseQueryMessage-4.0", TypeName = "CaseQueryCriteriaType")]
    [System.Xml.Serialization.XmlRootAttribute("CaseQueryCriteria", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseQueryMessage-4.0", IsNullable = false, ElementName = "CaseQueryCriteriaType")]
    
    public partial class CaseQueryCriteriaType : ComplexObjectType
    {

        /// <remarks/>
        private Boolean includeParticipantsIndicator;

        /// <remarks/>
        private Boolean includeDocketEntryIndicator;

        /// <remarks/>
        private Boolean includeCalendarEventIndicator;

        /// <remarks/>
        private TextType docketEntryTypeCodeFilterText;

        /// <remarks/>
        private TextType calendarEventTypeCodeFilterText;

        /// <remarks/>
        private DateRangeType docketEntryTimeRange;

        /// <remarks/>
        private DateRangeType calendarEventTimeRange;

        public CaseQueryCriteriaType()
        {
        }

        public CaseQueryCriteriaType(Boolean includeParticipantsIndicator, Boolean includeDocketEntryIndicator, Boolean includeCalendarEventIndicator, TextType docketEntryTypeCodeFilterText, TextType calendarEventTypeCodeFilterText, DateRangeType docketEntryTimeRange, DateRangeType calendarEventTimeRange)
        {
            this.includeParticipantsIndicator = includeParticipantsIndicator;
            this.includeDocketEntryIndicator = includeDocketEntryIndicator;
            this.includeCalendarEventIndicator = includeCalendarEventIndicator;
            this.docketEntryTypeCodeFilterText = docketEntryTypeCodeFilterText;
            this.calendarEventTypeCodeFilterText = calendarEventTypeCodeFilterText;
            this.docketEntryTimeRange = docketEntryTimeRange;
            this.calendarEventTimeRange = calendarEventTimeRange;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "IncludeParticipantsIndicator")]
        public Boolean IncludeParticipantsIndicator
        {
            get
            {
                return this.includeParticipantsIndicator;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("IncludeParticipantsIndicator");
                }
                if ((this.includeParticipantsIndicator != value))
                {
                    this.includeParticipantsIndicator = value;
                    this.RaisePropertyChanged("IncludeParticipantsIndicator");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "IncludeDocketEntryIndicator")]
        public Boolean IncludeDocketEntryIndicator
        {
            get
            {
                return this.includeDocketEntryIndicator;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("IncludeDocketEntryIndicator");
                }
                if ((this.includeDocketEntryIndicator != value))
                {
                    this.includeDocketEntryIndicator = value;
                    this.RaisePropertyChanged("IncludeDocketEntryIndicator");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2, ElementName = "IncludeCalendarEventIndicator")]
        public Boolean IncludeCalendarEventIndicator
        {
            get
            {
                return this.includeCalendarEventIndicator;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("IncludeCalendarEventIndicator");
                }
                if ((this.includeCalendarEventIndicator != value))
                {
                    this.includeCalendarEventIndicator = value;
                    this.RaisePropertyChanged("IncludeCalendarEventIndicator");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3, ElementName = "DocketEntryTypeCodeFilterText")]
        public TextType DocketEntryTypeCodeFilterText
        {
            get
            {
                return this.docketEntryTypeCodeFilterText;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DocketEntryTypeCodeFilterText");
                }
                if ((this.docketEntryTypeCodeFilterText != value))
                {
                    this.docketEntryTypeCodeFilterText = value;
                    this.RaisePropertyChanged("DocketEntryTypeCodeFilterText");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4, ElementName = "CalendarEventTypeCodeFilterText")]
        public TextType CalendarEventTypeCodeFilterText
        {
            get
            {
                return this.calendarEventTypeCodeFilterText;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CalendarEventTypeCodeFilterText");
                }
                if ((this.calendarEventTypeCodeFilterText != value))
                {
                    this.calendarEventTypeCodeFilterText = value;
                    this.RaisePropertyChanged("CalendarEventTypeCodeFilterText");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5, ElementName = "DocketEntryTimeRange")]
        public DateRangeType DocketEntryTimeRange
        {
            get
            {
                return this.docketEntryTimeRange;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("DocketEntryTimeRange");
                }
                if ((this.docketEntryTimeRange != value))
                {
                    this.docketEntryTimeRange = value;
                    this.RaisePropertyChanged("DocketEntryTimeRange");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6, ElementName = "CalendarEventTimeRange")]
        public DateRangeType CalendarEventTimeRange
        {
            get
            {
                return this.calendarEventTimeRange;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("CalendarEventTimeRange");
                }
                if ((this.calendarEventTimeRange != value))
                {
                    this.calendarEventTimeRange = value;
                    this.RaisePropertyChanged("CalendarEventTimeRange");
                }
            }
        }
    }
    

}
