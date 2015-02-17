/*
	'=======================================================================
	'   Author(s):      D V Rao
	'   Module/Form:    EcfHelper.cs
	'   Created Date:   
	'   Description:    ECF Helper Functions
	'
	'   Modification History:
	'=======================================================================
	'   Author(s)       Date        Control/Procedure       Change
	'=======================================================================
    '   Rao         02/10/2015  removed xmlns prefix amcadext, addded xmlsns prefix aoc , xsi
    '   Rao         10/20/2012  AddNameSpaces added xmlns prefix amcadext
    '   Rao         07/31/2012  Added PolicyConstant EPORTAL_PASSWORD , SAO_MESSAGE_ID , FLEPORTAL_FILING_ID 
    '   Rao         07/17/2012  AddNameSpaces added xmlns prefix fsrsp
    '   Rao         06/29/2012  Added PolicyConstants  FILED FOR JUDICIAL REVIEW
    '   Rao         06/25/2012  Added PolicyConstants "EMPLOYER" , "EMPLOYER_FEIN",  PARTY_ATTORNEY_ASSOCIATION_CODE, EMPLOYER_ASSOCIATION_CODE
    '   Rao         06/25/2012  Added PolicyConstants EPORTAL_USERID , EPORTAL_LOGONNAME , BAR_NUMBER 
    '   Rao         06/22/2012  Added PolicyConstants ACCEPTED_FILING_STATUS, REJECTED_FILING_STATUS , FILED_FILING_STATUS
    '   Rao         06/08/2012  AddPaymentMessageNameSpaces added xmlns prefix receipt
    '   Rao         06/08/2012  AddNameSpaces added xmlns prefix reviewcb
    '   Rao         05/01/2012  Added Constant NOT_FOUND_CASE
    '   Rao         04/25/2012  Moved ACCEPTED_DOCUMENT_STATUS , REJECTED_DOCUMENT_STATUS to Sealed Class COnstants and added constants for PENDING QUEUE
    '   Rao         04/24/2009  AddNameSpaces , AddPaymentMessageNameSpaces Added
 *  '   Rao         04/14/2009  Add/GetCaseStatus  Added
 *  '   Rao         04/14/2009  AddUniformCaseNumber    Added
 *  '   Rao         04/14/2009  GetUniformCaseNumber    only pick up with s:id
 *  '   Rao         11/04/2009  GetUniformCaseNumber    Added 
	'=======================================================================
	*/

using System;
using System.Collections.Generic;
using Niem.NiemCore.v20;
using Oasis.LegalXml.CourtFiling.v40.Core ;
using System.Linq;
namespace Oasis.LegalXml.CourtFiling.v40.Ecf
{

    public static class EcfHelper
    {
        private const string UCN_ID = "ucn";
        public static string GetCaseNumber(Niem.NiemCore.v20.CaseType niemCase)
        {
           string caseNumber = niemCase != null ? NiemStringHelper<Niem.Proxy.xsd.v20.String>.FirstValue(niemCase.CaseTrackingID) : string.Empty;
           return caseNumber;
        }

        public static string GetUniformCaseNumber(Niem.NiemCore.v20.CaseType niemCase)
        {
            string ucn = string.Empty;
            if (niemCase != null && niemCase.CaseTrackingID != null )
            {
                var matchingItem = niemCase.CaseTrackingID.FirstOrDefault
                    (ns => (!string.IsNullOrEmpty(ns.Id) &&
                              ns.Id.ToLowerInvariant().Equals(UCN_ID)
                             )
                    );
                if ( matchingItem != null && !string.IsNullOrEmpty(matchingItem.Value)) ucn = matchingItem.Value;
            }
            return (ucn);
        }

        public static void AddUniformCaseNumber(string uniformCaseNumber, Niem.NiemCore.v20.CaseType niemCase)
        {
            if (!string.IsNullOrEmpty(uniformCaseNumber) && niemCase != null)
            {
                if (niemCase.CaseTrackingID == null) niemCase.CaseTrackingID = new List<Niem.Proxy.xsd.v20.String>();
                niemCase.CaseTrackingID.Add
                  (
                     new Niem.Proxy.xsd.v20.String { Id = UCN_ID, Value = uniformCaseNumber }
                  );

            }
        }

        public static void GetCaseStatus(Niem.NiemCore.v20.CaseType niemCase , out string statusCode , out string status)
        {
            statusCode = string.Empty;
            status = string.Empty;
            if (niemCase != null && niemCase.ActivityStatus != null && niemCase.ActivityStatus.Count > 0 )
            {
                statusCode = NiemStringHelper<TextType>.FirstValue(niemCase.ActivityStatus[0].StatusText);
                status  = NiemStringHelper<TextType>.FirstValue(niemCase.ActivityStatus[0].StatusDescriptionText);
            }
        }

        public static void AddCaseStatus(Niem.NiemCore.v20.CaseType niemCase, string statusCode, string status)
        {
            if (niemCase != null && !string.IsNullOrEmpty(statusCode) && !string.IsNullOrEmpty(status))
            {
                if ( niemCase.ActivityStatus == null ) niemCase.ActivityStatus = new List<StatusType>();
                niemCase.ActivityStatus.Add
                    (
                        new StatusType
                        {
                            StatusDate = new List<DateType> { new DateType(DateTime.Now) },
                            StatusText = NiemStringHelper<TextType>.ToList(statusCode),
                            StatusDescriptionText = NiemStringHelper<TextType>.ToList(status)
                        }
                    );

            }
        }


        public static string GetCaseType(Niem.NiemCore.v20.CaseType niemCase)
        {
            string caseTypeCode = niemCase != null ? NiemStringHelper<TextType>.FirstValue(niemCase.CaseCategoryText) : string.Empty;
            return caseTypeCode;
        }
        public static string GetPortalCaseType(Niem.NiemCore.v20.CaseType niemCase)
        {
            string caseTypeCode = niemCase != null && 
                                  niemCase.CaseCategoryText != null && 
                                  niemCase.CaseCategoryText.Count > 0 && 
                                  !string.IsNullOrEmpty(niemCase.CaseCategoryText[0].Id) ?
                                  niemCase.CaseCategoryText[0].Id : string.Empty;
            return caseTypeCode;
        }

        public static string GetCaseTitle(Niem.NiemCore.v20.CaseType niemCase)
        {
            return ( niemCase != null ? NiemStringHelper<TextType>.FirstValue(niemCase.CaseTitleText) : string.Empty);
        }

        [Obsolete("Use Typed GetCaseTitle Method")]
        public static string GetCaseTitle(object filingCase)
        {
            string caseTitle = string.Empty;
            if (filingCase != null && filingCase is Niem.NiemCore.v20.CaseType)
            {
                Niem.NiemCore.v20.CaseType niemCase = filingCase as Niem.NiemCore.v20.CaseType;
                caseTitle = NiemStringHelper<TextType>.FirstValue(niemCase.CaseTitleText);
            }
            return caseTitle;
        }


        public static void GetCountyCourtId(object filingCase, ref int countyId , ref int courtId)
        {
            countyId = -1;
            courtId = -1;
            Niem.Domains.Jxdm.v40.CourtType filingCourt = GetCourt(filingCase);
            if (filingCourt != null)
            {
              IdentificationType countyIdIdentification = filingCourt.OrganizationIdentification.Find(identification => (NiemStringHelper<TextType>.FirstValue(identification.IdentificationCategories) == Niem.NiemCore.v20.Constants.EPORTAL_IDENTIFICATION_ORGANIZATION_CATEGORY_TEXT));
              if (countyIdIdentification != null)
              {
                 Int32.TryParse(NiemStringHelper<Niem.Proxy.xsd.v20.String>.FirstValue(countyIdIdentification.IdentificationID), out countyId);
              }

              IdentificationType unitIdIdentification = filingCourt.OrganizationIdentification.Find(identification => (NiemStringHelper<TextType>.FirstValue(identification.IdentificationCategories) == Niem.NiemCore.v20.Constants.EPORTAL_IDENTIFICATION_ORGANIZATION_UNIT_TEXT));
              if (unitIdIdentification != null)
              {
                  Int32.TryParse(NiemStringHelper<Niem.Proxy.xsd.v20.String>.FirstValue(unitIdIdentification.IdentificationID), out courtId);
              }

            }
        }


        public static List<EntityType> GetCaseInitiatingParties(object filingCase , bool expandReferences , CoreFilingMessageType coreFilingMessage )
        {
            List<EntityType> initiatingParties = null;
            Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation = GetCaseAugmentation(filingCase);
            if (caseAugmentation != null)
            {
               initiatingParties = expandReferences ? ExpandEntityReferences(caseAugmentation.CaseInitiatingParty , filingCase , coreFilingMessage ) : caseAugmentation.CaseInitiatingParty;
            }
            return initiatingParties;
        }



        public static List<EntityType> GetCaseRespondantParties(object filingCase, bool expandReferences ,  CoreFilingMessageType coreFilingMessage )
        {
            List<EntityType> respondantParties = null;
            Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation = GetCaseAugmentation(filingCase);
            if (caseAugmentation != null)
            {
              respondantParties = expandReferences ? ExpandEntityReferences(caseAugmentation.CaseRespondentParty, filingCase, coreFilingMessage) : caseAugmentation.CaseRespondentParty;
            }
            return respondantParties;
        }

        public static List<EntityType> GetCaseInitiatingAttorneys(object filingCase, CoreFilingMessageType coreFilingMessage, out List<Niem.Domains.Jxdm.v40.JudicialOfficialBarMembershipType> barMemberShipInformation)
        {
            List<EntityType> initiatingAttorneys = null;
            barMemberShipInformation = null;
            Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation = GetCaseAugmentation(filingCase);
            if (caseAugmentation != null)
            {
              initiatingAttorneys = ExpandCaseOfficialTypeReferences(caseAugmentation.CaseInitiatingAttorney, filingCase, coreFilingMessage, out barMemberShipInformation);
            }
            return initiatingAttorneys;
        }

        public static List<EntityType> GetCaseRespondentAttorneys(object filingCase, CoreFilingMessageType coreFilingMessage, out List<Niem.Domains.Jxdm.v40.JudicialOfficialBarMembershipType> barMemberShipInformation)
        {
            List<EntityType> respondentAttorneys = null;
            barMemberShipInformation = null;
            Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation = GetCaseAugmentation(filingCase);
            if (caseAugmentation != null)
            {
              respondentAttorneys = ExpandCaseOfficialTypeReferences(caseAugmentation.CaseRespondentAttorney, filingCase, coreFilingMessage, out barMemberShipInformation);
            }
            return respondentAttorneys;
        }


        public static List<EntityType> ExpandCaseOfficialTypeReferences(List<Niem.Domains.Jxdm.v40.CaseOfficialType> caseOfficials, object filingCase, CoreFilingMessageType coreFilingMessage , out List<Niem.Domains.Jxdm.v40.JudicialOfficialBarMembershipType> barMemberShipInformation )
        {
            List<EntityType> expandedEntities = new List<EntityType>();
            barMemberShipInformation = new List<Niem.Domains.Jxdm.v40.JudicialOfficialBarMembershipType>();
            if (caseOfficials != null && caseOfficials.Count > 0)
            {
                List<EntityType> caseOfficialsAsNiemEntities = new List<EntityType>();
                foreach (var caseOfficial in caseOfficials)
                {
                    if (caseOfficial.RoleOfPersonReference != null && caseOfficial.RoleOfPersonReference.Count > 0)
                    {
                        caseOfficialsAsNiemEntities.Add(new EntityType(caseOfficial.RoleOfPersonReference[0], EntityRepresentationTpes.EntityPersonReference));
                    }
                    if (caseOfficial.JudicialOfficialBarMembership != null && caseOfficial.JudicialOfficialBarMembership.Count > 0)
                    {
                        barMemberShipInformation.Add(caseOfficial.JudicialOfficialBarMembership[0]);
                    }
                    else
                    {
                        barMemberShipInformation.Add(new Niem.Domains.Jxdm.v40.JudicialOfficialBarMembershipType());
                    }
                }
            }
            return expandedEntities;
        }


        public static List<EntityType> ExpandEntityReferences(List<EntityType> niemEntities, object filingCase, CoreFilingMessageType coreFilingMessage)
        {
            List<EntityType> expandedEntities = new List<EntityType>();
            if (niemEntities != null && niemEntities.Count > 0 )
            {

                List<EntityType> filingSubmitters = ( coreFilingMessage != null && coreFilingMessage.DocumentSubmitter != null) ? coreFilingMessage.DocumentSubmitter :null ;
                Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType ecfCaseAugmentation = GetEcfCaseAugmentation(filingCase);
                List<CaseParticipantType> caseParticipants = ecfCaseAugmentation != null && ecfCaseAugmentation.CaseParticipant != null && ecfCaseAugmentation.CaseParticipant.Count > 0 ? ecfCaseAugmentation.CaseParticipant : null;

                foreach (var niemEntity in niemEntities)
                {
                    Niem.Structures.v20.ReferenceType entiryReference = null;
                    switch (niemEntity.EntityRepresentationType)
                    {
                        case EntityRepresentationTpes.EcfOrganization:
                        case EntityRepresentationTpes.EcfPerson:
                        case EntityRepresentationTpes.EntityPerson:
                        case EntityRepresentationTpes.EntityOrganization:
                            expandedEntities.Add(niemEntity);
                            break;
                        case EntityRepresentationTpes.EntityPersonReference:
                            entiryReference = niemEntity.EntityRepresentation as Niem.Structures.v20.ReferenceType;
                            Oasis.LegalXml.CourtFiling.v40.Ecf.PersonType ecfPerson = null;
                            if (entiryReference != null && !string.IsNullOrEmpty(entiryReference.Ref))
                            {
                                // first look under case participants
                                if (caseParticipants != null && caseParticipants.Count > 0)
                                {
                                    CaseParticipantType matchingCaseParticipant = caseParticipants.Find(cp => (cp.EntityRepresentationType == EntityRepresentationTpes.EcfPerson && ( cp.EntityRepresentation as  Oasis.LegalXml.CourtFiling.v40.Ecf.PersonType).Id.Equals(entiryReference.Ref)));
                                    if ( matchingCaseParticipant != null ) ecfPerson = matchingCaseParticipant.EntityRepresentation as Oasis.LegalXml.CourtFiling.v40.Ecf.PersonType;
                                }
                                if ( ecfPerson == null && filingSubmitters != null && filingSubmitters.Count > 0 )
                                {
                                    EntityType matchingEntity = filingSubmitters.Find(et => (et.EntityRepresentationType == EntityRepresentationTpes.EcfPerson && (et.EntityRepresentation as Oasis.LegalXml.CourtFiling.v40.Ecf.PersonType).Id.Equals(entiryReference.Ref)));
                                    if (matchingEntity != null) ecfPerson = matchingEntity.EntityRepresentation as Oasis.LegalXml.CourtFiling.v40.Ecf.PersonType;
                                }
                            }
                            if (ecfPerson != null)
                            {
                                expandedEntities.Add(new EntityType { EntityRepresentation = ecfPerson, EntityRepresentationType = EntityRepresentationTpes.EcfPerson });
                            }
                            break;
                        case EntityRepresentationTpes.EntityOrganizationReference:
                            entiryReference = niemEntity.EntityRepresentation as Niem.Structures.v20.ReferenceType;
                            Oasis.LegalXml.CourtFiling.v40.Ecf.OrganizationType ecfOrganization = null;
                            if (entiryReference != null && !string.IsNullOrEmpty(entiryReference.Ref))
                            {
                                // first look under case participants
                                if (caseParticipants != null && caseParticipants.Count > 0)
                                {
                                    CaseParticipantType matchingCaseParticipant = caseParticipants.Find(cp => (cp.EntityRepresentationType == EntityRepresentationTpes.EcfOrganization && (cp.EntityRepresentation as Oasis.LegalXml.CourtFiling.v40.Ecf.OrganizationType).Id.Equals(entiryReference.Ref)));
                                    if (matchingCaseParticipant != null) ecfOrganization = matchingCaseParticipant.EntityRepresentation as Oasis.LegalXml.CourtFiling.v40.Ecf.OrganizationType;
                                }
                                if (ecfOrganization == null && filingSubmitters != null && filingSubmitters.Count > 0)
                                {
                                    EntityType matchingEntity = filingSubmitters.Find(et => (et.EntityRepresentationType == EntityRepresentationTpes.EcfOrganization && (et.EntityRepresentation as Oasis.LegalXml.CourtFiling.v40.Ecf.OrganizationType).Id.Equals(entiryReference.Ref)));
                                    if (matchingEntity != null) ecfOrganization = matchingEntity.EntityRepresentation as Oasis.LegalXml.CourtFiling.v40.Ecf.OrganizationType;
                                }
                            }
                            if (ecfOrganization != null)
                            {
                                expandedEntities.Add(new EntityType { EntityRepresentation = ecfOrganization, EntityRepresentationType = EntityRepresentationTpes.EcfOrganization});
                            }

                            break;
                    }
                }
            }
            return expandedEntities;
        }


        public static Niem.Domains.Jxdm.v40.CourtType GetCourt(object filingCase)
        {
            Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation = GetCaseAugmentation(filingCase);
            return ( caseAugmentation != null && caseAugmentation.CaseCourt != null && caseAugmentation.CaseCourt.Count > 0 ? caseAugmentation.CaseCourt[0] : null );
        }

        public static List<ErrorType> QuerySuccessfull()
        {
            return (new List<ErrorType> { new ErrorType(Constants.ECF_SUCCESSFULL_ERROR_CODE, Constants.ECF_SUCCESSFULL_ERROR_TEXT ) });
            
        }

        public static List<ErrorType> OperationSuccessfull()
        {
            return (new List<ErrorType> { new ErrorType(Constants.ECF_SUCCESSFULL_ERROR_CODE, Constants.ECF_SUCCESSFULL_ERROR_TEXT) });

        }

        public static List<ErrorType> ErrorList(string errorCode , string errorText)
        {
            return (new List<ErrorType> { new ErrorType(errorCode , errorText) });

        }

        public static int? GetSubmitterPortalUserId(List<EntityType> submittingEntities)
        {
            int? portalUserId = null;
            if (submittingEntities != null && submittingEntities.Count > 0)
            {
                switch (submittingEntities[0].EntityRepresentationType)
                {
                    case  EntityRepresentationTpes.EcfPerson:
                    case  EntityRepresentationTpes.EntityPerson:
                        Niem.NiemCore.v20.PersonType niemPerson = submittingEntities[0].EntityRepresentation as Niem.NiemCore.v20.PersonType;
                        if (niemPerson != null) portalUserId = niemPerson.PortalUserId;
                        break;

                }
            }

            return portalUserId;
        }


        public static Oasis.LegalXml.CourtFiling.v40.Ecf.DocumentType  FindDocumentById(Oasis.LegalXml.CourtFiling.v40.Core.CoreFilingMessageType coreFilingMessage,  string documentId)
        {
            Oasis.LegalXml.CourtFiling.v40.Ecf.DocumentType matchingDocument = null;
            if (coreFilingMessage != null && !string.IsNullOrEmpty(documentId))
            {
                // First Look in Lead Document
                if (coreFilingMessage.FilingLeadDocument != null)
                {
                    matchingDocument = coreFilingMessage.FilingLeadDocument.Find(ecfDoc => ( ecfDoc.Id.Equals(documentId))) ;
                }
                if (matchingDocument == null)
                {
                    matchingDocument = coreFilingMessage.FilingConnectedDocument.Find(ecfDoc => (ecfDoc.Id.Equals(documentId)));
                }
            }

            return matchingDocument;
        }

        public static byte[]  GetDocumentImageById(Oasis.LegalXml.CourtFiling.v40.Core.CoreFilingMessageType coreFilingMessage, string documentId)
        {

            Oasis.LegalXml.CourtFiling.v40.Ecf.DocumentType matchingDocument = FindDocumentById(coreFilingMessage , documentId);
            return ( matchingDocument != null ? matchingDocument.DocumentImage : null);

        }

        
        public static Niem.Domains.Jxdm.v40.CaseAugmentationType GetCaseAugmentation(object filingCase)
        {
            Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation = null;
            if (filingCase != null && filingCase is Niem.NiemCore.v20.CaseType)
            {
                if (filingCase is Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType)
                {
                    caseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType).CaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType)
                {
                    caseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType).CaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType)
                {
                    caseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType).CaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType)
                {
                    caseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType).CaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType)
                {
                    caseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType).CaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType)
                {
                    caseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType).CaseAugmentation;
                }

            }
            return caseAugmentation;
        }

        public static Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType GetEcfCaseAugmentation(object filingCase)
        {
            Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType ecfCaseAugmentation = null;
            if (filingCase != null && filingCase is Niem.NiemCore.v20.CaseType)
            {
                if (filingCase is Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType)
                {
                    ecfCaseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType).EcfCaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType)
                {
                    ecfCaseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType).EcfCaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType)
                {
                    ecfCaseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType).EcfCaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType)
                {
                    ecfCaseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType).EcfCaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType)
                {
                    ecfCaseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType).EcfCaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType)
                {
                    ecfCaseAugmentation = (filingCase as Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType).EcfCaseAugmentation;
                }
            }
            return ecfCaseAugmentation;
        }

        public static void SetFilingCaseProperties(object filingCase, string caseTypeCode, string cmsFilingActionCode, string caseTitle, Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation, Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType ecfCaseAugmentation)
        {
            if (filingCase != null && filingCase is Niem.NiemCore.v20.CaseType)
            {
                Niem.NiemCore.v20.CaseType niemCase = filingCase as Niem.NiemCore.v20.CaseType;

                niemCase.CaseCategoryText = NiemStringHelper<Niem.NiemCore.v20.TextType>.ToList(caseTypeCode);
                niemCase.ActivityDescriptionText = NiemStringHelper<Niem.NiemCore.v20.TextType>.ToList(cmsFilingActionCode);
                niemCase.CaseTitleText = NiemStringHelper<Niem.NiemCore.v20.TextType>.ToList(caseTitle);
                SetFilingCaseAugmentation(filingCase, caseAugmentation);
                SetFilingCaseAugmentation(filingCase, ecfCaseAugmentation);

            }
        }


        public static void SetFilingCaseAugmentation(object filingCase, Niem.Domains.Jxdm.v40.CaseAugmentationType caseAugmentation)
        {
            if (filingCase != null && caseAugmentation != null )
            {
                if (filingCase is Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType citationCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType;
                    citationCase.CaseAugmentation = caseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType civilCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType;
                    civilCase.CaseAugmentation = caseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType criminalCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType;
                    criminalCase.CaseAugmentation = caseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType domesticCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType;
                    domesticCase.CaseAugmentation = caseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType juvenileCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType;
                    juvenileCase.CaseAugmentation = caseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType appellateCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType;
                    appellateCase.CaseAugmentation = caseAugmentation;
                }

            }
        }

        public static void SetFilingCaseAugmentation(object filingCase, Oasis.LegalXml.CourtFiling.v40.Ecf.CaseAugmentationType ecfCaseAugmentation)
        {
            if (filingCase != null && ecfCaseAugmentation != null)
            {
                if (filingCase is Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType citationCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType;
                    citationCase.EcfCaseAugmentation = ecfCaseAugmentation;

                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType civilCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType;
                    civilCase.EcfCaseAugmentation = ecfCaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType criminalCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType;
                    criminalCase.EcfCaseAugmentation = ecfCaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType domesticCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType;
                    domesticCase.EcfCaseAugmentation = ecfCaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType juvenileCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType;
                    juvenileCase.EcfCaseAugmentation = ecfCaseAugmentation;
                }
                else if (filingCase is Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType)
                {
                    Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType appellateCase = filingCase as Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType;
                    appellateCase.EcfCaseAugmentation = ecfCaseAugmentation;
                }

            }
        }

        public static void AddNameSpaces(System.Xml.Serialization.XmlSerializerNamespaces nameSpaces)
        {
            if (nameSpaces != null)
            {
                nameSpaces.Add("niem-xsd", "http://niem.gov/niem/proxy/xsd/2.0");
                nameSpaces.Add("i", "http://niem.gov/niem/appinfo/2.0");
                nameSpaces.Add("s", "http://niem.gov/niem/structures/2.0");
                nameSpaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");
                nameSpaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                nameSpaces.Add("nc", "http://niem.gov/niem/niem-core/2.0");
                nameSpaces.Add("ecf", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0");
                nameSpaces.Add("j", "http://niem.gov/niem/domains/jxdm/4.0");
                nameSpaces.Add("appellate", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0");
                nameSpaces.Add("citation", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0");
                nameSpaces.Add("civil", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0");
                nameSpaces.Add("criminal", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0");
                nameSpaces.Add("domestic", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0");
                nameSpaces.Add("juvenile", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0");
                nameSpaces.Add("reviewcb", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ReviewFilingCallbackMessage-4.0");
                nameSpaces.Add("statusquery", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusQueryMessage-4.0");
                nameSpaces.Add("fsrsp", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingStatusResponseMessage-4.0");
                nameSpaces.Add("aoc", "http://schema.azcourts.az.gov/courts/efiling/ecf/extension/2.0");
                
            }

        }

        public static void AddPaymentMessageNameSpaces(System.Xml.Serialization.XmlSerializerNamespaces nameSpaces)
        {
            if (nameSpaces != null)
            {
                nameSpaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");
                nameSpaces.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-1.0");
                nameSpaces.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-1.0");
                nameSpaces.Add("payment", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:PaymentMessage-4.0");
                nameSpaces.Add("receipt", "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:PaymentReceiptMessage-4.0");
            }

        }

        public static CaseTypeSelectionType GetCaseTypeSelectionType(object caseObject)
        {
            CaseTypeSelectionType caseTypeSelection = CaseTypeSelectionType.NiemCase;
            if (caseObject != null)
            {
                if (caseObject is Oasis.LegalXml.CourtFiling.v40.Appellate.AppellateCaseType)
                {
                    caseTypeSelection = CaseTypeSelectionType.Appellate;
                }
                else if (caseObject is Oasis.LegalXml.CourtFiling.v40.Citation.CitationCaseType)
                {
                    caseTypeSelection = CaseTypeSelectionType.CitationCase;
                }
                else if (caseObject is Oasis.LegalXml.CourtFiling.v40.Civil.CivilCaseType)
                {
                    caseTypeSelection = CaseTypeSelectionType.CivilCase;
                }
                else if (caseObject is Oasis.LegalXml.CourtFiling.v40.Criminal.CriminalCaseType)
                {
                    caseTypeSelection = CaseTypeSelectionType.CriminalCase;
                }
                else if (caseObject is Oasis.LegalXml.CourtFiling.v40.Domestic.DomesticCaseType)
                {
                    caseTypeSelection = CaseTypeSelectionType.DomesticCase;
                }
                else if (caseObject is Oasis.LegalXml.CourtFiling.v40.Juvenile.JuvenileCaseType)
                {
                    caseTypeSelection = CaseTypeSelectionType.JuvenileCase;
                }
            }
            return caseTypeSelection;
        }
    }

    // All Constants defined here really need to come from Policy
    public sealed class PolicyConstants
    {

        public const string PAYMENT_INTERFACE_ERROR = "-9999"; 

        public const string FILING_FEES_WAIVED_FOR_USER = "1"; 
        public const string FILING_FEES_WAIVER_REQRUESTED = "2"; 

        public const string FILING_FEES_WAIVED_FOR_USER_SUPPORTING_TEXT = "Filing Fees Waived for current User"; 
        public const string FILING_FEES_WAIVER_REQRUESTED_SUPPORTING_TEXT = "Payment Waiver Requested";

        public const string NEW_CASE = "NEW CASE";
        public const string NOT_FOUND_CASE = "NOT FOUND";

        public const string COURT_RECORD_MDE_UNKNOWN_ERROR = "-9999";
        public const string CASE_NUMBER_NOT_FOUND_ERROR = "-9998";
        public const string CASE_DOES_NOT_SUPPORT_ELECTRONIC_FILING_ERROR = "-9997";
        public const string NOT_PARTY_TO_CASE_ERROR = "-9996";

        public const string ACCEPTED_DOCUMENT_STATUS = "ACCEPTED";
        public const string REJECTED_DOCUMENT_STATUS = "REJECTED";

        public const string MOVED_TO_PENDING_QUEUE_FILING_STATUS_CODE = "PENDING QUEUE";
        public const string MOVED_FROM_PENDING_QUEUE_FILING_STATUS_CODE = "PENDING QUEUE MOVE";
        public const string FILED_FOR_JUDICIAL_REVIEW_FILING_STATUS_CODE = "FILED FOR JUDICIAL REVIEW";


        public const string ACCEPTED_FILING_STATUS = "ACCEPTED";
        public const string REJECTED_FILING_STATUS = "REJECTED";
        public const string FILED_FILING_STATUS = "FILED";

        public const string EPORTAL_USERID = "FLEPORTAL_USERID";
        public const string EPORTAL_LOGONNAME = "FLEPORTAL_LOGONNAME";
        public const string BAR_NUMBER = "BAR_NUMBER";
        public const string EPORTAL_PASSWORD = "FLEPORTAL_PASSWORD";

        public const string PARTY_ATTORNEY_ASSOCIATION_CODE = "Case Party Attorney";
        public const string EMPLOYER_ASSOCIATION_CODE = "Employer";

        public const string EMPLOYER_FEIN = "EMPLOYER_FEIN";
        public const string EMPLOYER = "EMPLOYER";

        public const string SAO_MESSAGE_ID = "SAO_MESSAGE_ID";
        public const string FLEPORTAL_FILING_ID = "FLEPORTAL_FILING_ID";

    }

}
