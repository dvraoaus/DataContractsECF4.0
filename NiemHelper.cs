/*
	'=======================================================================
	'   Author(s):      D V Ra
	'   Module/Form:    NiemHelper.cs
	'   Created Date:   
	'   Description:    Niem Helper Functions
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
	'=======================================================================
    '  
	'=======================================================================
	*/

using System;
using System.Collections.Generic;
using Niem.Proxy.xsd.v20;

namespace Niem.NiemCore.v20
{
    public sealed class Constants
    {
        public const string EPORTAL_IDENTIFICATION_CATEGORY_TEXT = "FLEPORTAL";
        public const string EPORTAL_IDENTIFICATION_ORGANIZATION_CATEGORY_TEXT = "FLEPORTAL_ORGANIZATION";
        public const string EPORTAL_IDENTIFICATION_ORGANIZATION_UNIT_TEXT = "FLEPORTAL_ORGANIZATION_UNIT";
        public const string EPORTAL_IDENTIFICATION_ORGANIZATION_SUBUNIT_TEXT = "FLEPORTAL_ORGANIZATION_SUBUNIT";
        public const string ECF4_WEBSERVICES_SIP_CODE = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:WebServicesMessaging-2.0";
        public const string ECF_SUCCESSFULL_ERROR_CODE = "0"; // Need to take this from Policy
        public const string ECF_SUCCESSFULL_ERROR_TEXT = "No Error"; // Need to take this from Policy


    }

    public static class NiemStringHelper<NiemStringType> where NiemStringType : Niem.Proxy.xsd.v20.String, new()
    {


        public static List<NiemStringType> ToList(string value)
        {
            List<NiemStringType> list = (!string.IsNullOrEmpty(value)) ? (new List<NiemStringType>{ new NiemStringType { Value = value }}) : null ;
            return list;
        }

        public static string FirstValue(List<NiemStringType> list)
        {
            string firstValue = list != null && list.Count > 0 && !string.IsNullOrEmpty(list[0].Value) ? list[0].Value : string.Empty;
            return (firstValue);
        }

        // List Position is 0 
        public static string ValueByPosition(List<NiemStringType> list , int listPosition)
        {
            string listItemValue = list != null && list.Count > 0 && listPosition < list.Count && !string.IsNullOrEmpty(list[listPosition].Value) ? list[listPosition].Value : string.Empty;
            return (listItemValue);
        }

    }


}
