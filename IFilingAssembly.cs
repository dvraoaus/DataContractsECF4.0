/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    IFilingAssembly.cs
	'   Created Date:   
	'   Description:    
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
	'=======================================================================
    '   Rao             
	'=======================================================================
	*/

using System.ServiceModel;
using Oasis.LegalXml.CourtFiling.v40.WebServiceMessagingProfile;


namespace Oasis.LegalXml.CourtFiling.v40.Services
{
    [ServiceContract(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServiceMessagingProfile-Definitions-4.0", Name = "FilingAssemblyMDEPort")]
    [XmlSerializerFormat(Style = OperationFormatStyle.Document, Use = OperationFormatUse.Literal)]
    public interface IFilingAssemblyMDE
    {

        [OperationContract()]
        NotifyFilingReviewCompleteResponse NotifyFilingReviewComplete(NotifyFilingReviewCompleteRequest notifyFilingReviewCompleteRequest);


    }


}
