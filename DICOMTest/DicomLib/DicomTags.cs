
// Copyright (c) 2012-2021 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace DICOMLib
{

    public struct DicomTags
    {
        ///<summary>(0000,0000) VR=UL VM=1 Command Group Length</summary>
        public const uint CommandGroupLength = 0x00000000;

        ///<summary>(0000,0002) VR=UI VM=1 Affected Sop Class Uid</summary>
        public const uint AffectedSopClassUid = 0x00000002;

        ///<summary>(0000,0003) VR=UI VM=1 Requested Sop Class Uid</summary>
        public const uint RequestedSopClassUid = 0x00000003;

        ///<summary>(0000,0100) VR=US VM=1 Command Field</summary>
        public const uint CommandField = 0x00000100;

        ///<summary>(0000,0110) VR=US VM=1 Message Id</summary>
        public const uint MessageId = 0x00000110;

        ///<summary>(0000,0120) VR=US VM=1 Message Id Being Responded To</summary>
        public const uint MessageIdBeingRespondedTo = 0x00000120;

        ///<summary>(0000,0600) VR=AE VM=1 Move Destination</summary>
        public const uint MoveDestination = 0x00000600;

        ///<summary>(0000,0700) VR=US VM=1 Priority</summary>
        public const uint Priority = 0x00000700;

        ///<summary>(0000,0800) VR=US VM=1 Command Data Set Type</summary>
        public const uint CommandDataSetType = 0x00000800;

        ///<summary>(0000,0900) VR=US VM=1 Status</summary>
        public const uint Status = 0x00000900;

        ///<summary>(0000,0901) VR=AT VM=1-n Offending Element</summary>
        public const uint OffendingElement = 0x00000901;

        ///<summary>(0000,0902) VR=LO VM=1 Error Comment</summary>
        public const uint ErrorComment = 0x00000902;

        ///<summary>(0000,0903) VR=US VM=1 Error Id</summary>
        public const uint ErrorId = 0x00000903;

        ///<summary>(0000,1000) VR=UI VM=1 Affected Sop Instance Uid</summary>
        public const uint AffectedSopInstanceUid = 0x00001000;

        ///<summary>(0000,1001) VR=UI VM=1 Requested Sop Instance Uid</summary>
        public const uint RequestedSopInstanceUid = 0x00001001;

        ///<summary>(0000,1002) VR=US VM=1 Event Type Id</summary>
        public const uint EventTypeId = 0x00001002;

        ///<summary>(0000,1005) VR=AT VM=1-n Attribute Identifier List</summary>
        public const uint AttributeIdentifierList = 0x00001005;

        ///<summary>(0000,1008) VR=US VM=1 Action Type Id</summary>
        public const uint ActionTypeId = 0x00001008;

        ///<summary>(0000,1020) VR=US VM=1 Number of Remaining Sub-operations</summary>
        public const uint NumberOfRemainingSuboperations = 0x00001020;

        ///<summary>(0000,1021) VR=US VM=1 Number of Completed Sub-operations</summary>
        public const uint NumberOfCompletedSuboperations = 0x00001021;

        ///<summary>(0000,1022) VR=US VM=1 Number of Failed Sub-operations</summary>
        public const uint NumberOfFailedSuboperations = 0x00001022;

        ///<summary>(0000,1023) VR=US VM=1 Number of Warning Sub-operations</summary>
        public const uint NumberOfWarningSuboperations = 0x00001023;

        ///<summary>(0000,1030) VR=AE VM=1 Move Originator Application Entity Title</summary>
        public const uint MoveOriginatorApplicationEntityTitle = 0x00001030;

        ///<summary>(0000,1031) VR=US VM=1 Move Originator Message Id</summary>
        public const uint MoveOriginatorMessageId = 0x00001031;

        ///<summary>(0000,0001) VR=UL VM=1 Command Length to End</summary>
        public const uint CommandLengthToEnd = 0x00000001;

        ///<summary>(0000,0010) VR=SH VM=1 Command Recognition Code</summary>
        public const uint CommandRecognitionCode = 0x00000010;

        ///<summary>(0000,0200) VR=AE VM=1 Initiator</summary>
        public const uint Initiator = 0x00000200;

        ///<summary>(0000,0300) VR=AE VM=1 Receiver</summary>
        public const uint Receiver = 0x00000300;

        ///<summary>(0000,0400) VR=AE VM=1 Find Location</summary>
        public const uint FindLocation = 0x00000400;

        ///<summary>(0000,0850) VR=US VM=1 Number of Matches</summary>
        public const uint NumberOfMatches = 0x00000850;

        ///<summary>(0000,0860) VR=US VM=1 Response Sequence Number</summary>
        public const uint ResponseSequenceNumber = 0x00000860;

        ///<summary>(0000,4000) VR=LT VM=1 Dialog Receiver</summary>
        public const uint DialogReceiver = 0x00004000;

        ///<summary>(0000,4010) VR=LT VM=1 Terminal Type</summary>
        public const uint TerminalType = 0x00004010;

        ///<summary>(0000,5010) VR=SH VM=1 Message Set Id</summary>
        public const uint MessageSetId = 0x00005010;

        ///<summary>(0000,5020) VR=SH VM=1 End Message Id</summary>
        public const uint EndMessageId = 0x00005020;

        ///<summary>(0000,5110) VR=LT VM=1 Display Format</summary>
        public const uint DisplayFormat = 0x00005110;

        ///<summary>(0000,5120) VR=LT VM=1 Page Position Id</summary>
        public const uint PagePositionId = 0x00005120;

        ///<summary>(0000,5130) VR=CS VM=1 Text Format Id</summary>
        public const uint TextFormatId = 0x00005130;

        ///<summary>(0000,5140) VR=CS VM=1 Normal/Reverse</summary>
        public const uint NormalReverse = 0x00005140;

        ///<summary>(0000,5150) VR=CS VM=1 Add Gray Scale</summary>
        public const uint AddGrayScale = 0x00005150;

        ///<summary>(0000,5160) VR=CS VM=1 Borders</summary>
        public const uint Borders = 0x00005160;

        ///<summary>(0000,5170) VR=IS VM=1 Copies</summary>
        public const uint Copies = 0x00005170;

        ///<summary>(0000,5180) VR=CS VM=1 Command Magnification Type</summary>
        public const uint CommandMagnificationType = 0x00005180;

        ///<summary>(0000,5190) VR=CS VM=1 Erase</summary>
        public const uint Erase = 0x00005190;

        ///<summary>(0000,51A0) VR=CS VM=1 Print</summary>
        public const uint Print = 0x000051A0;

        ///<summary>(0000,51B0) VR=US VM=1-n Overlays</summary>
        public const uint Overlays = 0x000051B0;

        ///<summary>(0002,0000) VR=UL VM=1 File Meta Information Group Length</summary>
        public const uint FileMetaInformationGroupLength = 0x00020000;

        ///<summary>(0002,0001) VR=OB VM=1 File Meta Information Version</summary>
        public const uint FileMetaInformationVersion = 0x00020001;

        ///<summary>(0002,0002) VR=UI VM=1 Media Storage Sop Class Uid</summary>
        public const uint MediaStorageSopClassUid = 0x00020002;

        ///<summary>(0002,0003) VR=UI VM=1 Media Storage Sop Instance Uid</summary>
        public const uint MediaStorageSopInstanceUid = 0x00020003;

        ///<summary>(0002,0010) VR=UI VM=1 Transfer Syntax Uid</summary>
        public const uint TransferSyntaxUid = 0x00020010;

        ///<summary>(0002,0012) VR=UI VM=1 Implementation Class Uid</summary>
        public const uint ImplementationClassUid = 0x00020012;

        ///<summary>(0002,0013) VR=SH VM=1 Implementation Version Name</summary>
        public const uint ImplementationVersionName = 0x00020013;

        ///<summary>(0002,0016) VR=AE VM=1 Source Application Entity Title</summary>
        public const uint SourceApplicationEntityTitle = 0x00020016;

        ///<summary>(0002,0017) VR=AE VM=1 Sending Application Entity Title</summary>
        public const uint SendingApplicationEntityTitle = 0x00020017;

        ///<summary>(0002,0018) VR=AE VM=1 Receiving Application Entity Title</summary>
        public const uint ReceivingApplicationEntityTitle = 0x00020018;

        ///<summary>(0002,0026) VR=UR VM=1 Source Presentation Address</summary>
        public const uint SourcePresentationAddress = 0x00020026;

        ///<summary>(0002,0027) VR=UR VM=1 Sending Presentation Address</summary>
        public const uint SendingPresentationAddress = 0x00020027;

        ///<summary>(0002,0028) VR=UR VM=1 Receiving Presentation Address</summary>
        public const uint ReceivingPresentationAddress = 0x00020028;

        ///<summary>(0002,0031) VR=OB VM=1 RTV Meta Information Version</summary>
        public const uint RTVMetaInformationVersion = 0x00020031;

        ///<summary>(0002,0032) VR=UI VM=1 RTV Communication Sop Class Uid</summary>
        public const uint RTVCommunicationSopClassUid = 0x00020032;

        ///<summary>(0002,0033) VR=UI VM=1 RTV Communication Sop Instance Uid</summary>
        public const uint RTVCommunicationSopInstanceUid = 0x00020033;

        ///<summary>(0002,0035) VR=OB VM=1 RTV Source Identifier</summary>
        public const uint RTVSourceIdentifier = 0x00020035;

        ///<summary>(0002,0036) VR=OB VM=1 RTV Flow Identifier</summary>
        public const uint RTVFlowIdentifier = 0x00020036;

        ///<summary>(0002,0037) VR=UL VM=1 RTV Flow RTP Sampling Rate</summary>
        public const uint RTVFlowRTPSamplingRate = 0x00020037;

        ///<summary>(0002,0038) VR=FD VM=1 RTV Flow Actual Frame Duration</summary>
        public const uint RTVFlowActualFrameDuration = 0x00020038;

        ///<summary>(0002,0100) VR=UI VM=1 Private Information Creator Uid</summary>
        public const uint PrivateInformationCreatorUid = 0x00020100;

        ///<summary>(0002,0102) VR=OB VM=1 Private Information</summary>
        public const uint PrivateInformation = 0x00020102;

        ///<summary>(0004,1130) VR=CS VM=1 File-set Id</summary>
        public const uint FileSetId = 0x00041130;

        ///<summary>(0004,1141) VR=CS VM=1-8 File-set Descriptor File Id</summary>
        public const uint FileSetDescriptorFileId = 0x00041141;

        ///<summary>(0004,1142) VR=CS VM=1 Specific Character Set of File-set Descriptor File</summary>
        public const uint SpecificCharacterSetOfFileSetDescriptorFile = 0x00041142;

        ///<summary>(0004,1200) VR=UL VM=1 Offset of the First Directory Record of the Root Directory Entity</summary>
        public const uint OffsetOfTheFirstDirectoryRecordOfTheRootDirectoryEntity = 0x00041200;

        ///<summary>(0004,1202) VR=UL VM=1 Offset of the Last Directory Record of the Root Directory Entity</summary>
        public const uint OffsetOfTheLastDirectoryRecordOfTheRootDirectoryEntity = 0x00041202;

        ///<summary>(0004,1212) VR=US VM=1 File-set Consistency Flag</summary>
        public const uint FileSetConsistencyFlag = 0x00041212;

        ///<summary>(0004,1220) VR=SQ VM=1 Directory Record Sequence</summary>
        public const uint DirectoryRecordSequence = 0x00041220;

        ///<summary>(0004,1400) VR=UL VM=1 Offset of the Next Directory Record</summary>
        public const uint OffsetOfTheNextDirectoryRecord = 0x00041400;

        ///<summary>(0004,1410) VR=US VM=1 Record In-use Flag</summary>
        public const uint RecordInUseFlag = 0x00041410;

        ///<summary>(0004,1420) VR=UL VM=1 Offset of Referenced Lower-Level Directory Entity</summary>
        public const uint OffsetOfReferencedLowerLevelDirectoryEntity = 0x00041420;

        ///<summary>(0004,1430) VR=CS VM=1 Directory Record Type</summary>
        public const uint DirectoryRecordType = 0x00041430;

        ///<summary>(0004,1432) VR=UI VM=1 Private Record Uid</summary>
        public const uint PrivateRecordUid = 0x00041432;

        ///<summary>(0004,1500) VR=CS VM=1-8 Referenced File Id</summary>
        public const uint ReferencedFileId = 0x00041500;

        ///<summary>(0004,1504) VR=UL VM=1 MRDR Directory Record Offset (RETIRED)</summary>
        public const uint MRDRDirectoryRecordOffsetRETIRED = 0x00041504;

        ///<summary>(0004,1510) VR=UI VM=1 Referenced Sop Class Uid in File</summary>
        public const uint ReferencedSopClassUidInFile = 0x00041510;

        ///<summary>(0004,1511) VR=UI VM=1 Referenced Sop Instance Uid in File</summary>
        public const uint ReferencedSopInstanceUidInFile = 0x00041511;

        ///<summary>(0004,1512) VR=UI VM=1 Referenced Transfer Syntax Uid in File</summary>
        public const uint ReferencedTransferSyntaxUidInFile = 0x00041512;

        ///<summary>(0004,151A) VR=UI VM=1-n Referenced Related General Sop Class Uid in File</summary>
        public const uint ReferencedRelatedGeneralSopClassUidInFile = 0x0004151A;

        ///<summary>(0004,1600) VR=UL VM=1 Number of References (RETIRED)</summary>
        public const uint NumberOfReferencesRETIRED = 0x00041600;

        ///<summary>(0008,0001) VR=UL VM=1 Length to End (RETIRED)</summary>
        public const uint LengthToEndRETIRED = 0x00080001;

        ///<summary>(0008,0005) VR=CS VM=1-n Specific Character Set</summary>
        public const uint SpecificCharacterSet = 0x00080005;

        ///<summary>(0008,0006) VR=SQ VM=1 Language Code Sequence</summary>
        public const uint LanguageCodeSequence = 0x00080006;

        ///<summary>(0008,0008) VR=CS VM=2-n Image Type</summary>
        public const uint ImageType = 0x00080008;

        ///<summary>(0008,0010) VR=SH VM=1 Recognition Code (RETIRED)</summary>
        public const uint RecognitionCodeRETIRED = 0x00080010;

        ///<summary>(0008,0012) VR=DA VM=1 Instance Creation Date</summary>
        public const uint InstanceCreationDate = 0x00080012;

        ///<summary>(0008,0013) VR=TM VM=1 Instance Creation Time</summary>
        public const uint InstanceCreationTime = 0x00080013;

        ///<summary>(0008,0014) VR=UI VM=1 Instance Creator Uid</summary>
        public const uint InstanceCreatorUid = 0x00080014;

        ///<summary>(0008,0015) VR=DT VM=1 Instance Coercion DateTime</summary>
        public const uint InstanceCoercionDateTime = 0x00080015;

        ///<summary>(0008,0016) VR=UI VM=1 Sop Class Uid</summary>
        public const uint SopClassUid = 0x00080016;

        ///<summary>(0008,0018) VR=UI VM=1 Sop Instance Uid</summary>
        public const uint SopInstanceUid = 0x00080018;

        ///<summary>(0008,001A) VR=UI VM=1-n Related General Sop Class Uid</summary>
        public const uint RelatedGeneralSopClassUid = 0x0008001A;

        ///<summary>(0008,001B) VR=UI VM=1 Original Specialized Sop Class Uid</summary>
        public const uint OriginalSpecializedSopClassUid = 0x0008001B;

        ///<summary>(0008,0020) VR=DA VM=1 Study Date</summary>
        public const uint StudyDate = 0x00080020;

        ///<summary>(0008,0021) VR=DA VM=1 Series Date</summary>
        public const uint SeriesDate = 0x00080021;

        ///<summary>(0008,0022) VR=DA VM=1 Acquisition Date</summary>
        public const uint AcquisitionDate = 0x00080022;

        ///<summary>(0008,0023) VR=DA VM=1 Content Date</summary>
        public const uint ContentDate = 0x00080023;

        ///<summary>(0008,0024) VR=DA VM=1 Overlay Date (RETIRED)</summary>
        public const uint OverlayDateRETIRED = 0x00080024;

        ///<summary>(0008,0025) VR=DA VM=1 Curve Date (RETIRED)</summary>
        public const uint CurveDateRETIRED = 0x00080025;

        ///<summary>(0008,002A) VR=DT VM=1 Acquisition DateTime</summary>
        public const uint AcquisitionDateTime = 0x0008002A;

        ///<summary>(0008,0030) VR=TM VM=1 Study Time</summary>
        public const uint StudyTime = 0x00080030;

        ///<summary>(0008,0031) VR=TM VM=1 Series Time</summary>
        public const uint SeriesTime = 0x00080031;

        ///<summary>(0008,0032) VR=TM VM=1 Acquisition Time</summary>
        public const uint AcquisitionTime = 0x00080032;

        ///<summary>(0008,0033) VR=TM VM=1 Content Time</summary>
        public const uint ContentTime = 0x00080033;

        ///<summary>(0008,0034) VR=TM VM=1 Overlay Time (RETIRED)</summary>
        public const uint OverlayTimeRETIRED = 0x00080034;

        ///<summary>(0008,0035) VR=TM VM=1 Curve Time (RETIRED)</summary>
        public const uint CurveTimeRETIRED = 0x00080035;

        ///<summary>(0008,0040) VR=US VM=1 Data Set Type (RETIRED)</summary>
        public const uint DataSetTypeRETIRED = 0x00080040;

        ///<summary>(0008,0041) VR=LO VM=1 Data Set Subtype (RETIRED)</summary>
        public const uint DataSetSubtypeRETIRED = 0x00080041;

        ///<summary>(0008,0042) VR=CS VM=1 Nuclear Medicine Series Type (RETIRED)</summary>
        public const uint NuclearMedicineSeriesTypeRETIRED = 0x00080042;

        ///<summary>(0008,0050) VR=SH VM=1 Accession Number</summary>
        public const uint AccessionNumber = 0x00080050;

        ///<summary>(0008,0051) VR=SQ VM=1 Issuer of Accession Number Sequence</summary>
        public const uint IssuerOfAccessionNumberSequence = 0x00080051;

        ///<summary>(0008,0052) VR=CS VM=1 Query/Retrieve Level</summary>
        public const uint QueryRetrieveLevel = 0x00080052;

        ///<summary>(0008,0053) VR=CS VM=1 Query/Retrieve View</summary>
        public const uint QueryRetrieveView = 0x00080053;

        ///<summary>(0008,0054) VR=AE VM=1-n Retrieve AE Title</summary>
        public const uint RetrieveAETitle = 0x00080054;

        ///<summary>(0008,0055) VR=AE VM=1 Station AE Title</summary>
        public const uint StationAETitle = 0x00080055;

        ///<summary>(0008,0056) VR=CS VM=1 Instance Availability</summary>
        public const uint InstanceAvailability = 0x00080056;

        ///<summary>(0008,0058) VR=UI VM=1-n Failed Sop Instance Uid List</summary>
        public const uint FailedSopInstanceUidList = 0x00080058;

        ///<summary>(0008,0060) VR=CS VM=1 Modality</summary>
        public const uint Modality = 0x00080060;

        ///<summary>(0008,0061) VR=CS VM=1-n Modalities in Study</summary>
        public const uint ModalitiesInStudy = 0x00080061;

        ///<summary>(0008,0062) VR=UI VM=1-n Sop Classes in Study</summary>
        public const uint SopClassesInStudy = 0x00080062;

        ///<summary>(0008,0063) VR=SQ VM=1 Anatomic Regions in Study Code Sequence</summary>
        public const uint AnatomicRegionsInStudyCodeSequence = 0x00080063;

        ///<summary>(0008,0064) VR=CS VM=1 Conversion Type</summary>
        public const uint ConversionType = 0x00080064;

        ///<summary>(0008,0068) VR=CS VM=1 Presentation Intent Type</summary>
        public const uint PresentationIntentType = 0x00080068;

        ///<summary>(0008,0070) VR=LO VM=1 Manufacturer</summary>
        public const uint Manufacturer = 0x00080070;

        ///<summary>(0008,0080) VR=LO VM=1 Institution Name</summary>
        public const uint InstitutionName = 0x00080080;

        ///<summary>(0008,0081) VR=ST VM=1 Institution Address</summary>
        public const uint InstitutionAddress = 0x00080081;

        ///<summary>(0008,0082) VR=SQ VM=1 Institution Code Sequence</summary>
        public const uint InstitutionCodeSequence = 0x00080082;

        ///<summary>(0008,0090) VR=PN VM=1 Referring Physician's Name</summary>
        public const uint ReferringPhysicianName = 0x00080090;

        ///<summary>(0008,0092) VR=ST VM=1 Referring Physician's Address</summary>
        public const uint ReferringPhysicianAddress = 0x00080092;

        ///<summary>(0008,0094) VR=SH VM=1-n Referring Physician's Telephone Numbers</summary>
        public const uint ReferringPhysicianTelephoneNumbers = 0x00080094;

        ///<summary>(0008,0096) VR=SQ VM=1 Referring Physician Identification Sequence</summary>
        public const uint ReferringPhysicianIdentificationSequence = 0x00080096;

        ///<summary>(0008,009C) VR=PN VM=1-n Consulting Physician's Name</summary>
        public const uint ConsultingPhysicianName = 0x0008009C;

        ///<summary>(0008,009D) VR=SQ VM=1 Consulting Physician Identification Sequence</summary>
        public const uint ConsultingPhysicianIdentificationSequence = 0x0008009D;

        ///<summary>(0008,0100) VR=SH VM=1 Code Value</summary>
        public const uint CodeValue = 0x00080100;

        ///<summary>(0008,0101) VR=LO VM=1 Extended Code Value</summary>
        public const uint ExtendedCodeValue = 0x00080101;

        ///<summary>(0008,0102) VR=SH VM=1 Coding Scheme Designator</summary>
        public const uint CodingSchemeDesignator = 0x00080102;

        ///<summary>(0008,0103) VR=SH VM=1 Coding Scheme Version</summary>
        public const uint CodingSchemeVersion = 0x00080103;

        ///<summary>(0008,0104) VR=LO VM=1 Code Meaning</summary>
        public const uint CodeMeaning = 0x00080104;

        ///<summary>(0008,0105) VR=CS VM=1 Mapping Resource</summary>
        public const uint MappingResource = 0x00080105;

        ///<summary>(0008,0106) VR=DT VM=1 Context Group Version</summary>
        public const uint ContextGroupVersion = 0x00080106;

        ///<summary>(0008,0107) VR=DT VM=1 Context Group Local Version</summary>
        public const uint ContextGroupLocalVersion = 0x00080107;

        ///<summary>(0008,0108) VR=LT VM=1 Extended Code Meaning</summary>
        public const uint ExtendedCodeMeaning = 0x00080108;

        ///<summary>(0008,0109) VR=SQ VM=1 Coding Scheme Resources Sequence</summary>
        public const uint CodingSchemeResourcesSequence = 0x00080109;

        ///<summary>(0008,010A) VR=CS VM=1 Coding Scheme URL Type</summary>
        public const uint CodingSchemeURLType = 0x0008010A;

        ///<summary>(0008,010B) VR=CS VM=1 Context Group Extension Flag</summary>
        public const uint ContextGroupExtensionFlag = 0x0008010B;

        ///<summary>(0008,010C) VR=UI VM=1 Coding Scheme Uid</summary>
        public const uint CodingSchemeUid = 0x0008010C;

        ///<summary>(0008,010D) VR=UI VM=1 Context Group Extension Creator Uid</summary>
        public const uint ContextGroupExtensionCreatorUid = 0x0008010D;

        ///<summary>(0008,010E) VR=UR VM=1 Coding Scheme URL</summary>
        public const uint CodingSchemeURL = 0x0008010E;

        ///<summary>(0008,010F) VR=CS VM=1 Context Identifier</summary>
        public const uint ContextIdentifier = 0x0008010F;

        ///<summary>(0008,0110) VR=SQ VM=1 Coding Scheme Identification Sequence</summary>
        public const uint CodingSchemeIdentificationSequence = 0x00080110;

        ///<summary>(0008,0112) VR=LO VM=1 Coding Scheme Registry</summary>
        public const uint CodingSchemeRegistry = 0x00080112;

        ///<summary>(0008,0114) VR=ST VM=1 Coding Scheme External Id</summary>
        public const uint CodingSchemeExternalId = 0x00080114;

        ///<summary>(0008,0115) VR=ST VM=1 Coding Scheme Name</summary>
        public const uint CodingSchemeName = 0x00080115;

        ///<summary>(0008,0116) VR=ST VM=1 Coding Scheme Responsible Organization</summary>
        public const uint CodingSchemeResponsibleOrganization = 0x00080116;

        ///<summary>(0008,0117) VR=UI VM=1 Context Uid</summary>
        public const uint ContextUid = 0x00080117;

        ///<summary>(0008,0118) VR=UI VM=1 Mapping Resource Uid</summary>
        public const uint MappingResourceUid = 0x00080118;

        ///<summary>(0008,0119) VR=UC VM=1 Long Code Value</summary>
        public const uint LongCodeValue = 0x00080119;

        ///<summary>(0008,0120) VR=UR VM=1 URN Code Value</summary>
        public const uint URNCodeValue = 0x00080120;

        ///<summary>(0008,0121) VR=SQ VM=1 Equivalent Code Sequence</summary>
        public const uint EquivalentCodeSequence = 0x00080121;

        ///<summary>(0008,0122) VR=LO VM=1 Mapping Resource Name</summary>
        public const uint MappingResourceName = 0x00080122;

        ///<summary>(0008,0123) VR=SQ VM=1 Context Group Identification Sequence</summary>
        public const uint ContextGroupIdentificationSequence = 0x00080123;

        ///<summary>(0008,0124) VR=SQ VM=1 Mapping Resource Identification Sequence</summary>
        public const uint MappingResourceIdentificationSequence = 0x00080124;

        ///<summary>(0008,0201) VR=SH VM=1 Timezone Offset From UTC</summary>
        public const uint TimezoneOffsetFromUTC = 0x00080201;

        ///<summary>(0008,0220) VR=SQ VM=1 Responsible Group Code Sequence</summary>
        public const uint ResponsibleGroupCodeSequence = 0x00080220;

        ///<summary>(0008,0221) VR=CS VM=1 Equipment Modality</summary>
        public const uint EquipmentModality = 0x00080221;

        ///<summary>(0008,0222) VR=LO VM=1 Manufacturer's Related Model Group</summary>
        public const uint ManufacturerRelatedModelGroup = 0x00080222;

        ///<summary>(0008,0300) VR=SQ VM=1 Private Data Element Characteristics Sequence</summary>
        public const uint PrivateDataElementCharacteristicsSequence = 0x00080300;

        ///<summary>(0008,0301) VR=US VM=1 Private Group Reference</summary>
        public const uint PrivateGroupReference = 0x00080301;

        ///<summary>(0008,0302) VR=LO VM=1 Private Creator Reference</summary>
        public const uint PrivateCreatorReference = 0x00080302;

        ///<summary>(0008,0303) VR=CS VM=1 Block Identifying Information Status</summary>
        public const uint BlockIdentifyingInformationStatus = 0x00080303;

        ///<summary>(0008,0304) VR=US VM=1-n Nonidentifying Private Elements</summary>
        public const uint NonidentifyingPrivateElements = 0x00080304;

        ///<summary>(0008,0306) VR=US VM=1-n Identifying Private Elements</summary>
        public const uint IdentifyingPrivateElements = 0x00080306;

        ///<summary>(0008,0305) VR=SQ VM=1 Deidentification Action Sequence</summary>
        public const uint DeidentificationActionSequence = 0x00080305;

        ///<summary>(0008,0307) VR=CS VM=1 Deidentification Action</summary>
        public const uint DeidentificationAction = 0x00080307;

        ///<summary>(0008,0308) VR=US VM=1 Private Data Element</summary>
        public const uint PrivateDataElement = 0x00080308;

        ///<summary>(0008,0309) VR=UL VM=1-3 Private Data Element Value Multiplicity</summary>
        public const uint PrivateDataElementValueMultiplicity = 0x00080309;

        ///<summary>(0008,030A) VR=CS VM=1 Private Data Element Value Representation</summary>
        public const uint PrivateDataElementValueRepresentation = 0x0008030A;

        ///<summary>(0008,030B) VR=UL VM=1-2 Private Data Element Number of Items</summary>
        public const uint PrivateDataElementNumberOfItems = 0x0008030B;

        ///<summary>(0008,030C) VR=UC VM=1 Private Data Element Name</summary>
        public const uint PrivateDataElementName = 0x0008030C;

        ///<summary>(0008,030D) VR=UC VM=1 Private Data Element Keyword</summary>
        public const uint PrivateDataElementKeyword = 0x0008030D;

        ///<summary>(0008,030E) VR=UT VM=1 Private Data Element Description</summary>
        public const uint PrivateDataElementDescription = 0x0008030E;

        ///<summary>(0008,030F) VR=UT VM=1 Private Data Element Encoding</summary>
        public const uint PrivateDataElementEncoding = 0x0008030F;

        ///<summary>(0008,0310) VR=SQ VM=1 Private Data Element Definition Sequence</summary>
        public const uint PrivateDataElementDefinitionSequence = 0x00080310;

        ///<summary>(0008,1000) VR=AE VM=1 Network Id (RETIRED)</summary>
        public const uint NetworkIdRETIRED = 0x00081000;

        ///<summary>(0008,1010) VR=SH VM=1 Station Name</summary>
        public const uint StationName = 0x00081010;

        ///<summary>(0008,1030) VR=LO VM=1 Study Description</summary>
        public const uint StudyDescription = 0x00081030;

        ///<summary>(0008,1032) VR=SQ VM=1 Procedure Code Sequence</summary>
        public const uint ProcedureCodeSequence = 0x00081032;

        ///<summary>(0008,103E) VR=LO VM=1 Series Description</summary>
        public const uint SeriesDescription = 0x0008103E;

        ///<summary>(0008,103F) VR=SQ VM=1 Series Description Code Sequence</summary>
        public const uint SeriesDescriptionCodeSequence = 0x0008103F;

        ///<summary>(0008,1040) VR=LO VM=1 Institutional Department Name</summary>
        public const uint InstitutionalDepartmentName = 0x00081040;

        ///<summary>(0008,1041) VR=SQ VM=1 Institutional Department Type Code Sequence</summary>
        public const uint InstitutionalDepartmentTypeCodeSequence = 0x00081041;

        ///<summary>(0008,1048) VR=PN VM=1-n Physician(s) of Record</summary>
        public const uint PhysiciansOfRecord = 0x00081048;

        ///<summary>(0008,1049) VR=SQ VM=1 Physician(s) of Record Identification Sequence</summary>
        public const uint PhysiciansOfRecordIdentificationSequence = 0x00081049;

        ///<summary>(0008,1050) VR=PN VM=1-n Performing Physician's Name</summary>
        public const uint PerformingPhysicianName = 0x00081050;

        ///<summary>(0008,1052) VR=SQ VM=1 Performing Physician Identification Sequence</summary>
        public const uint PerformingPhysicianIdentificationSequence = 0x00081052;

        ///<summary>(0008,1060) VR=PN VM=1-n Name of Physician(s) Reading Study</summary>
        public const uint NameOfPhysiciansReadingStudy = 0x00081060;

        ///<summary>(0008,1062) VR=SQ VM=1 Physician(s) Reading Study Identification Sequence</summary>
        public const uint PhysiciansReadingStudyIdentificationSequence = 0x00081062;

        ///<summary>(0008,1070) VR=PN VM=1-n Operators' Name</summary>
        public const uint OperatorsName = 0x00081070;

        ///<summary>(0008,1072) VR=SQ VM=1 Operator Identification Sequence</summary>
        public const uint OperatorIdentificationSequence = 0x00081072;

        ///<summary>(0008,1080) VR=LO VM=1-n Admitting Diagnoses Description</summary>
        public const uint AdmittingDiagnosesDescription = 0x00081080;

        ///<summary>(0008,1084) VR=SQ VM=1 Admitting Diagnoses Code Sequence</summary>
        public const uint AdmittingDiagnosesCodeSequence = 0x00081084;

        ///<summary>(0008,1090) VR=LO VM=1 Manufacturer's Model Name</summary>
        public const uint ManufacturerModelName = 0x00081090;

        ///<summary>(0008,1100) VR=SQ VM=1 Referenced Results Sequence (RETIRED)</summary>
        public const uint ReferencedResultsSequenceRETIRED = 0x00081100;

        ///<summary>(0008,1110) VR=SQ VM=1 Referenced Study Sequence</summary>
        public const uint ReferencedStudySequence = 0x00081110;

        ///<summary>(0008,1111) VR=SQ VM=1 Referenced Performed Procedure Step Sequence</summary>
        public const uint ReferencedPerformedProcedureStepSequence = 0x00081111;

        ///<summary>(0008,1115) VR=SQ VM=1 Referenced Series Sequence</summary>
        public const uint ReferencedSeriesSequence = 0x00081115;

        ///<summary>(0008,1120) VR=SQ VM=1 Referenced Patient Sequence</summary>
        public const uint ReferencedPatientSequence = 0x00081120;

        ///<summary>(0008,1125) VR=SQ VM=1 Referenced Visit Sequence</summary>
        public const uint ReferencedVisitSequence = 0x00081125;

        ///<summary>(0008,1130) VR=SQ VM=1 Referenced Overlay Sequence (RETIRED)</summary>
        public const uint ReferencedOverlaySequenceRETIRED = 0x00081130;

        ///<summary>(0008,1134) VR=SQ VM=1 Referenced Stereometric Instance Sequence</summary>
        public const uint ReferencedStereometricInstanceSequence = 0x00081134;

        ///<summary>(0008,113A) VR=SQ VM=1 Referenced Waveform Sequence</summary>
        public const uint ReferencedWaveformSequence = 0x0008113A;

        ///<summary>(0008,1140) VR=SQ VM=1 Referenced Image Sequence</summary>
        public const uint ReferencedImageSequence = 0x00081140;

        ///<summary>(0008,1145) VR=SQ VM=1 Referenced Curve Sequence (RETIRED)</summary>
        public const uint ReferencedCurveSequenceRETIRED = 0x00081145;

        ///<summary>(0008,114A) VR=SQ VM=1 Referenced Instance Sequence</summary>
        public const uint ReferencedInstanceSequence = 0x0008114A;

        ///<summary>(0008,114B) VR=SQ VM=1 Referenced Real World Value Mapping Instance Sequence</summary>
        public const uint ReferencedRealWorldValueMappingInstanceSequence = 0x0008114B;

        ///<summary>(0008,1150) VR=UI VM=1 Referenced Sop Class Uid</summary>
        public const uint ReferencedSopClassUid = 0x00081150;

        ///<summary>(0008,1155) VR=UI VM=1 Referenced Sop Instance Uid</summary>
        public const uint ReferencedSopInstanceUid = 0x00081155;

        ///<summary>(0008,1156) VR=SQ VM=1 Definition Source Sequence</summary>
        public const uint DefinitionSourceSequence = 0x00081156;

        ///<summary>(0008,115A) VR=UI VM=1-n Sop Classes Supported</summary>
        public const uint SopClassesSupported = 0x0008115A;

        ///<summary>(0008,1160) VR=IS VM=1-n Referenced Frame Number</summary>
        public const uint ReferencedFrameNumber = 0x00081160;

        ///<summary>(0008,1161) VR=UL VM=1-n Simple Frame List</summary>
        public const uint SimpleFrameList = 0x00081161;

        ///<summary>(0008,1162) VR=UL VM=3-3n Calculated Frame List</summary>
        public const uint CalculatedFrameList = 0x00081162;

        ///<summary>(0008,1163) VR=FD VM=2 Time Range</summary>
        public const uint TimeRange = 0x00081163;

        ///<summary>(0008,1164) VR=SQ VM=1 Frame Extraction Sequence</summary>
        public const uint FrameExtractionSequence = 0x00081164;

        ///<summary>(0008,1167) VR=UI VM=1 Multi-frame Source Sop Instance Uid</summary>
        public const uint MultiFrameSourceSopInstanceUid = 0x00081167;

        ///<summary>(0008,1190) VR=UR VM=1 Retrieve URL</summary>
        public const uint RetrieveURL = 0x00081190;

        ///<summary>(0008,1195) VR=UI VM=1 Transaction Uid</summary>
        public const uint TransactionUid = 0x00081195;

        ///<summary>(0008,1196) VR=US VM=1 Warning Reason</summary>
        public const uint WarningReason = 0x00081196;

        ///<summary>(0008,1197) VR=US VM=1 Failure Reason</summary>
        public const uint FailureReason = 0x00081197;

        ///<summary>(0008,1198) VR=SQ VM=1 Failed Sop Sequence</summary>
        public const uint FailedSopSequence = 0x00081198;

        ///<summary>(0008,1199) VR=SQ VM=1 Referenced Sop Sequence</summary>
        public const uint ReferencedSopSequence = 0x00081199;

        ///<summary>(0008,119A) VR=SQ VM=1 Other Failures Sequence</summary>
        public const uint OtherFailuresSequence = 0x0008119A;

        ///<summary>(0008,1200) VR=SQ VM=1 Studies Containing Other Referenced Instances Sequence</summary>
        public const uint StudiesContainingOtherReferencedInstancesSequence = 0x00081200;

        ///<summary>(0008,1250) VR=SQ VM=1 Related Series Sequence</summary>
        public const uint RelatedSeriesSequence = 0x00081250;

        ///<summary>(0008,2110) VR=CS VM=1 Lossy Image Compression (Retired) (RETIRED)</summary>
        public const uint LossyImageCompressionRetiredRETIRED = 0x00082110;

        ///<summary>(0008,2111) VR=ST VM=1 Derivation Description</summary>
        public const uint DerivationDescription = 0x00082111;

        ///<summary>(0008,2112) VR=SQ VM=1 Source Image Sequence</summary>
        public const uint SourceImageSequence = 0x00082112;

        ///<summary>(0008,2120) VR=SH VM=1 Stage Name</summary>
        public const uint StageName = 0x00082120;

        ///<summary>(0008,2122) VR=IS VM=1 Stage Number</summary>
        public const uint StageNumber = 0x00082122;

        ///<summary>(0008,2124) VR=IS VM=1 Number of Stages</summary>
        public const uint NumberOfStages = 0x00082124;

        ///<summary>(0008,2127) VR=SH VM=1 View Name</summary>
        public const uint ViewName = 0x00082127;

        ///<summary>(0008,2128) VR=IS VM=1 View Number</summary>
        public const uint ViewNumber = 0x00082128;

        ///<summary>(0008,2129) VR=IS VM=1 Number of Event Timers</summary>
        public const uint NumberOfEventTimers = 0x00082129;

        ///<summary>(0008,212A) VR=IS VM=1 Number of Views in Stage</summary>
        public const uint NumberOfViewsInStage = 0x0008212A;

        ///<summary>(0008,2130) VR=DS VM=1-n Event Elapsed Time(s)</summary>
        public const uint EventElapsedTimes = 0x00082130;

        ///<summary>(0008,2132) VR=LO VM=1-n Event Timer Name(s)</summary>
        public const uint EventTimerNames = 0x00082132;

        ///<summary>(0008,2133) VR=SQ VM=1 Event Timer Sequence</summary>
        public const uint EventTimerSequence = 0x00082133;

        ///<summary>(0008,2134) VR=FD VM=1 Event Time Offset</summary>
        public const uint EventTimeOffset = 0x00082134;

        ///<summary>(0008,2135) VR=SQ VM=1 Event Code Sequence</summary>
        public const uint EventCodeSequence = 0x00082135;

        ///<summary>(0008,2142) VR=IS VM=1 Start Trim</summary>
        public const uint StartTrim = 0x00082142;

        ///<summary>(0008,2143) VR=IS VM=1 Stop Trim</summary>
        public const uint StopTrim = 0x00082143;

        ///<summary>(0008,2144) VR=IS VM=1 Recommended Display Frame Rate</summary>
        public const uint RecommendedDisplayFrameRate = 0x00082144;

        ///<summary>(0008,2200) VR=CS VM=1 Transducer Position (RETIRED)</summary>
        public const uint TransducerPositionRETIRED = 0x00082200;

        ///<summary>(0008,2204) VR=CS VM=1 Transducer Orientation (RETIRED)</summary>
        public const uint TransducerOrientationRETIRED = 0x00082204;

        ///<summary>(0008,2208) VR=CS VM=1 Anatomic Structure (RETIRED)</summary>
        public const uint AnatomicStructureRETIRED = 0x00082208;

        ///<summary>(0008,2218) VR=SQ VM=1 Anatomic Region Sequence</summary>
        public const uint AnatomicRegionSequence = 0x00082218;

        ///<summary>(0008,2220) VR=SQ VM=1 Anatomic Region Modifier Sequence</summary>
        public const uint AnatomicRegionModifierSequence = 0x00082220;

        ///<summary>(0008,2228) VR=SQ VM=1 Primary Anatomic Structure Sequence</summary>
        public const uint PrimaryAnatomicStructureSequence = 0x00082228;

        ///<summary>(0008,2229) VR=SQ VM=1 Anatomic Structure, Space or Region Sequence (RETIRED)</summary>
        public const uint AnatomicStructureSpaceOrRegionSequenceRETIRED = 0x00082229;

        ///<summary>(0008,2230) VR=SQ VM=1 Primary Anatomic Structure Modifier Sequence</summary>
        public const uint PrimaryAnatomicStructureModifierSequence = 0x00082230;

        ///<summary>(0008,2240) VR=SQ VM=1 Transducer Position Sequence (RETIRED)</summary>
        public const uint TransducerPositionSequenceRETIRED = 0x00082240;

        ///<summary>(0008,2242) VR=SQ VM=1 Transducer Position Modifier Sequence (RETIRED)</summary>
        public const uint TransducerPositionModifierSequenceRETIRED = 0x00082242;

        ///<summary>(0008,2244) VR=SQ VM=1 Transducer Orientation Sequence (RETIRED)</summary>
        public const uint TransducerOrientationSequenceRETIRED = 0x00082244;

        ///<summary>(0008,2246) VR=SQ VM=1 Transducer Orientation Modifier Sequence (RETIRED)</summary>
        public const uint TransducerOrientationModifierSequenceRETIRED = 0x00082246;

        ///<summary>(0008,2251) VR=SQ VM=1 Anatomic Structure Space Or Region Code Sequence (Trial) (RETIRED)</summary>
        public const uint AnatomicStructureSpaceOrRegionCodeSequenceTrialRETIRED = 0x00082251;

        ///<summary>(0008,2253) VR=SQ VM=1 Anatomic Portal Of Entrance Code Sequence (Trial) (RETIRED)</summary>
        public const uint AnatomicPortalOfEntranceCodeSequenceTrialRETIRED = 0x00082253;

        ///<summary>(0008,2255) VR=SQ VM=1 Anatomic Approach Direction Code Sequence (Trial) (RETIRED)</summary>
        public const uint AnatomicApproachDirectionCodeSequenceTrialRETIRED = 0x00082255;

        ///<summary>(0008,2256) VR=ST VM=1 Anatomic Perspective Description (Trial) (RETIRED)</summary>
        public const uint AnatomicPerspectiveDescriptionTrialRETIRED = 0x00082256;

        ///<summary>(0008,2257) VR=SQ VM=1 Anatomic Perspective Code Sequence (Trial) (RETIRED)</summary>
        public const uint AnatomicPerspectiveCodeSequenceTrialRETIRED = 0x00082257;

        ///<summary>(0008,2258) VR=ST VM=1 Anatomic Location Of Examining Instrument Description (Trial) (RETIRED)</summary>
        public const uint AnatomicLocationOfExaminingInstrumentDescriptionTrialRETIRED = 0x00082258;

        ///<summary>(0008,2259) VR=SQ VM=1 Anatomic Location Of Examining Instrument Code Sequence (Trial) (RETIRED)</summary>
        public const uint AnatomicLocationOfExaminingInstrumentCodeSequenceTrialRETIRED = 0x00082259;

        ///<summary>(0008,225A) VR=SQ VM=1 Anatomic Structure Space Or Region Modifier Code Sequence (Trial) (RETIRED)</summary>
        public const uint AnatomicStructureSpaceOrRegionModifierCodeSequenceTrialRETIRED = 0x0008225A;

        ///<summary>(0008,225C) VR=SQ VM=1 On Axis Background Anatomic Structure Code Sequence (Trial) (RETIRED)</summary>
        public const uint OnAxisBackgroundAnatomicStructureCodeSequenceTrialRETIRED = 0x0008225C;

        ///<summary>(0008,3001) VR=SQ VM=1 Alternate Representation Sequence</summary>
        public const uint AlternateRepresentationSequence = 0x00083001;

        ///<summary>(0008,3002) VR=UI VM=1-n Available Transfer Syntax Uid</summary>
        public const uint AvailableTransferSyntaxUid = 0x00083002;

        ///<summary>(0008,3010) VR=UI VM=1-n Irradiation Event Uid</summary>
        public const uint IrradiationEventUid = 0x00083010;

        ///<summary>(0008,3011) VR=SQ VM=1 Source Irradiation Event Sequence</summary>
        public const uint SourceIrradiationEventSequence = 0x00083011;

        ///<summary>(0008,3012) VR=UI VM=1 Radiopharmaceutical Administration Event Uid</summary>
        public const uint RadiopharmaceuticalAdministrationEventUid = 0x00083012;

        ///<summary>(0008,4000) VR=LT VM=1 Identifying Comments (RETIRED)</summary>
        public const uint IdentifyingCommentsRETIRED = 0x00084000;

        ///<summary>(0008,9007) VR=CS VM=4 Frame Type</summary>
        public const uint FrameType = 0x00089007;

        ///<summary>(0008,9092) VR=SQ VM=1 Referenced Image Evidence Sequence</summary>
        public const uint ReferencedImageEvidenceSequence = 0x00089092;

        ///<summary>(0008,9121) VR=SQ VM=1 Referenced Raw Data Sequence</summary>
        public const uint ReferencedRawDataSequence = 0x00089121;

        ///<summary>(0008,9123) VR=UI VM=1 Creator-Version Uid</summary>
        public const uint CreatorVersionUid = 0x00089123;

        ///<summary>(0008,9124) VR=SQ VM=1 Derivation Image Sequence</summary>
        public const uint DerivationImageSequence = 0x00089124;

        ///<summary>(0008,9154) VR=SQ VM=1 Source Image Evidence Sequence</summary>
        public const uint SourceImageEvidenceSequence = 0x00089154;

        ///<summary>(0008,9205) VR=CS VM=1 Pixel Presentation</summary>
        public const uint PixelPresentation = 0x00089205;

        ///<summary>(0008,9206) VR=CS VM=1 Volumetric Properties</summary>
        public const uint VolumetricProperties = 0x00089206;

        ///<summary>(0008,9207) VR=CS VM=1 Volume Based Calculation Technique</summary>
        public const uint VolumeBasedCalculationTechnique = 0x00089207;

        ///<summary>(0008,9208) VR=CS VM=1 Complex Image Component</summary>
        public const uint ComplexImageComponent = 0x00089208;

        ///<summary>(0008,9209) VR=CS VM=1 Acquisition Contrast</summary>
        public const uint AcquisitionContrast = 0x00089209;

        ///<summary>(0008,9215) VR=SQ VM=1 Derivation Code Sequence</summary>
        public const uint DerivationCodeSequence = 0x00089215;

        ///<summary>(0008,9237) VR=SQ VM=1 Referenced Presentation State Sequence</summary>
        public const uint ReferencedPresentationStateSequence = 0x00089237;

        ///<summary>(0008,9410) VR=SQ VM=1 Referenced Other Plane Sequence</summary>
        public const uint ReferencedOtherPlaneSequence = 0x00089410;

        ///<summary>(0008,9458) VR=SQ VM=1 Frame Display Sequence</summary>
        public const uint FrameDisplaySequence = 0x00089458;

        ///<summary>(0008,9459) VR=FL VM=1 Recommended Display Frame Rate in Float</summary>
        public const uint RecommendedDisplayFrameRateInFloat = 0x00089459;

        ///<summary>(0008,9460) VR=CS VM=1 Skip Frame Range Flag</summary>
        public const uint SkipFrameRangeFlag = 0x00089460;

        ///<summary>(0010,0010) VR=PN VM=1 Patient's Name</summary>
        public const uint PatientsName = 0x00100010;

        ///<summary>(0010,0020) VR=LO VM=1 Patient Id</summary>
        public const uint PatientId = 0x00100020;

        ///<summary>(0010,0021) VR=LO VM=1 Issuer of Patient Id</summary>
        public const uint IssuerOfPatientId = 0x00100021;

        ///<summary>(0010,0022) VR=CS VM=1 Type of Patient Id</summary>
        public const uint TypeOfPatientId = 0x00100022;

        ///<summary>(0010,0024) VR=SQ VM=1 Issuer of Patient Id Qualifiers Sequence</summary>
        public const uint IssuerOfPatientIdQualifiersSequence = 0x00100024;

        ///<summary>(0010,0026) VR=SQ VM=1 Source Patient Group Identification Sequence</summary>
        public const uint SourcePatientGroupIdentificationSequence = 0x00100026;

        ///<summary>(0010,0027) VR=SQ VM=1 Group of Patients Identification Sequence</summary>
        public const uint GroupOfPatientsIdentificationSequence = 0x00100027;

        ///<summary>(0010,0028) VR=US VM=3 Subject Relative Position in Image</summary>
        public const uint SubjectRelativePositionInImage = 0x00100028;

        ///<summary>(0010,0030) VR=DA VM=1 Patient's Birth Date</summary>
        public const uint PatientBirthDate = 0x00100030;

        ///<summary>(0010,0032) VR=TM VM=1 Patient's Birth Time</summary>
        public const uint PatientBirthTime = 0x00100032;

        ///<summary>(0010,0033) VR=LO VM=1 Patient's Birth Date in Alternative Calendar</summary>
        public const uint PatientBirthDateInAlternativeCalendar = 0x00100033;

        ///<summary>(0010,0034) VR=LO VM=1 Patient's Death Date in Alternative Calendar</summary>
        public const uint PatientDeathDateInAlternativeCalendar = 0x00100034;

        ///<summary>(0010,0035) VR=CS VM=1 Patient's Alternative Calendar</summary>
        public const uint PatientAlternativeCalendar = 0x00100035;

        ///<summary>(0010,0040) VR=CS VM=1 Patient's Sex</summary>
        public const uint PatientSex = 0x00100040;

        ///<summary>(0010,0050) VR=SQ VM=1 Patient's Insurance Plan Code Sequence</summary>
        public const uint PatientInsurancePlanCodeSequence = 0x00100050;

        ///<summary>(0010,0101) VR=SQ VM=1 Patient's Primary Language Code Sequence</summary>
        public const uint PatientPrimaryLanguageCodeSequence = 0x00100101;

        ///<summary>(0010,0102) VR=SQ VM=1 Patient's Primary Language Modifier Code Sequence</summary>
        public const uint PatientPrimaryLanguageModifierCodeSequence = 0x00100102;

        ///<summary>(0010,0200) VR=CS VM=1 Quality Control Subject</summary>
        public const uint QualityControlSubject = 0x00100200;

        ///<summary>(0010,0201) VR=SQ VM=1 Quality Control Subject Type Code Sequence</summary>
        public const uint QualityControlSubjectTypeCodeSequence = 0x00100201;

        ///<summary>(0010,0212) VR=UC VM=1 Strain Description</summary>
        public const uint StrainDescription = 0x00100212;

        ///<summary>(0010,0213) VR=LO VM=1 Strain Nomenclature</summary>
        public const uint StrainNomenclature = 0x00100213;

        ///<summary>(0010,0214) VR=LO VM=1 Strain Stock Number</summary>
        public const uint StrainStockNumber = 0x00100214;

        ///<summary>(0010,0215) VR=SQ VM=1 Strain Source Registry Code Sequence</summary>
        public const uint StrainSourceRegistryCodeSequence = 0x00100215;

        ///<summary>(0010,0216) VR=SQ VM=1 Strain Stock Sequence</summary>
        public const uint StrainStockSequence = 0x00100216;

        ///<summary>(0010,0217) VR=LO VM=1 Strain Source</summary>
        public const uint StrainSource = 0x00100217;

        ///<summary>(0010,0218) VR=UT VM=1 Strain Additional Information</summary>
        public const uint StrainAdditionalInformation = 0x00100218;

        ///<summary>(0010,0219) VR=SQ VM=1 Strain Code Sequence</summary>
        public const uint StrainCodeSequence = 0x00100219;

        ///<summary>(0010,0221) VR=SQ VM=1 Genetic Modifications Sequence</summary>
        public const uint GeneticModificationsSequence = 0x00100221;

        ///<summary>(0010,0222) VR=UC VM=1 Genetic Modifications Description</summary>
        public const uint GeneticModificationsDescription = 0x00100222;

        ///<summary>(0010,0223) VR=LO VM=1 Genetic Modifications Nomenclature</summary>
        public const uint GeneticModificationsNomenclature = 0x00100223;

        ///<summary>(0010,0229) VR=SQ VM=1 Genetic Modifications Code Sequence</summary>
        public const uint GeneticModificationsCodeSequence = 0x00100229;

        ///<summary>(0010,1000) VR=LO VM=1-n Other Patient Ids (RETIRED)</summary>
        public const uint OtherPatientIdsRETIRED = 0x00101000;

        ///<summary>(0010,1001) VR=PN VM=1-n Other Patient Names</summary>
        public const uint OtherPatientNames = 0x00101001;

        ///<summary>(0010,1002) VR=SQ VM=1 Other Patient Ids Sequence</summary>
        public const uint OtherPatientIdsSequence = 0x00101002;

        ///<summary>(0010,1005) VR=PN VM=1 Patient's Birth Name</summary>
        public const uint PatientBirthName = 0x00101005;

        ///<summary>(0010,1010) VR=AS VM=1 Patient's Age</summary>
        public const uint PatientAge = 0x00101010;

        ///<summary>(0010,1020) VR=DS VM=1 Patient's Size</summary>
        public const uint PatientSize = 0x00101020;

        ///<summary>(0010,1021) VR=SQ VM=1 Patient's Size Code Sequence</summary>
        public const uint PatientSizeCodeSequence = 0x00101021;

        ///<summary>(0010,1022) VR=DS VM=1 Patient's Body Mass Index</summary>
        public const uint PatientBodyMassIndex = 0x00101022;

        ///<summary>(0010,1023) VR=DS VM=1 Measured AP Dimension</summary>
        public const uint MeasuredAPDimension = 0x00101023;

        ///<summary>(0010,1024) VR=DS VM=1 Measured Lateral Dimension</summary>
        public const uint MeasuredLateralDimension = 0x00101024;

        ///<summary>(0010,1030) VR=DS VM=1 Patient's Weight</summary>
        public const uint PatientWeight = 0x00101030;

        ///<summary>(0010,1040) VR=LO VM=1 Patient's Address</summary>
        public const uint PatientAddress = 0x00101040;

        ///<summary>(0010,1050) VR=LO VM=1-n Insurance Plan Identification (RETIRED)</summary>
        public const uint InsurancePlanIdentificationRETIRED = 0x00101050;

        ///<summary>(0010,1060) VR=PN VM=1 Patient's Mother's Birth Name</summary>
        public const uint PatientMotherBirthName = 0x00101060;

        ///<summary>(0010,1080) VR=LO VM=1 Military Rank</summary>
        public const uint MilitaryRank = 0x00101080;

        ///<summary>(0010,1081) VR=LO VM=1 Branch of Service</summary>
        public const uint BranchOfService = 0x00101081;

        ///<summary>(0010,1090) VR=LO VM=1 Medical Record Locator (RETIRED)</summary>
        public const uint MedicalRecordLocatorRETIRED = 0x00101090;

        ///<summary>(0010,1100) VR=SQ VM=1 Referenced Patient Photo Sequence</summary>
        public const uint ReferencedPatientPhotoSequence = 0x00101100;

        ///<summary>(0010,2000) VR=LO VM=1-n Medical Alerts</summary>
        public const uint MedicalAlerts = 0x00102000;

        ///<summary>(0010,2110) VR=LO VM=1-n Allergies</summary>
        public const uint Allergies = 0x00102110;

        ///<summary>(0010,2150) VR=LO VM=1 Country of Residence</summary>
        public const uint CountryOfResidence = 0x00102150;

        ///<summary>(0010,2152) VR=LO VM=1 Region of Residence</summary>
        public const uint RegionOfResidence = 0x00102152;

        ///<summary>(0010,2154) VR=SH VM=1-n Patient's Telephone Numbers</summary>
        public const uint PatientTelephoneNumbers = 0x00102154;

        ///<summary>(0010,2155) VR=LT VM=1 Patient's Telecom Information</summary>
        public const uint PatientTelecomInformation = 0x00102155;

        ///<summary>(0010,2160) VR=SH VM=1 Ethnic Group</summary>
        public const uint EthnicGroup = 0x00102160;

        ///<summary>(0010,2180) VR=SH VM=1 Occupation</summary>
        public const uint Occupation = 0x00102180;

        ///<summary>(0010,21A0) VR=CS VM=1 Smoking Status</summary>
        public const uint SmokingStatus = 0x001021A0;

        ///<summary>(0010,21B0) VR=LT VM=1 Additional Patient History</summary>
        public const uint AdditionalPatientHistory = 0x001021B0;

        ///<summary>(0010,21C0) VR=US VM=1 Pregnancy Status</summary>
        public const uint PregnancyStatus = 0x001021C0;

        ///<summary>(0010,21D0) VR=DA VM=1 Last Menstrual Date</summary>
        public const uint LastMenstrualDate = 0x001021D0;

        ///<summary>(0010,21F0) VR=LO VM=1 Patient's Religious Preference</summary>
        public const uint PatientReligiousPreference = 0x001021F0;

        ///<summary>(0010,2201) VR=LO VM=1 Patient Species Description</summary>
        public const uint PatientSpeciesDescription = 0x00102201;

        ///<summary>(0010,2202) VR=SQ VM=1 Patient Species Code Sequence</summary>
        public const uint PatientSpeciesCodeSequence = 0x00102202;

        ///<summary>(0010,2203) VR=CS VM=1 Patient's Sex Neutered</summary>
        public const uint PatientSexNeutered = 0x00102203;

        ///<summary>(0010,2210) VR=CS VM=1 Anatomical Orientation Type</summary>
        public const uint AnatomicalOrientationType = 0x00102210;

        ///<summary>(0010,2292) VR=LO VM=1 Patient Breed Description</summary>
        public const uint PatientBreedDescription = 0x00102292;

        ///<summary>(0010,2293) VR=SQ VM=1 Patient Breed Code Sequence</summary>
        public const uint PatientBreedCodeSequence = 0x00102293;

        ///<summary>(0010,2294) VR=SQ VM=1 Breed Registration Sequence</summary>
        public const uint BreedRegistrationSequence = 0x00102294;

        ///<summary>(0010,2295) VR=LO VM=1 Breed Registration Number</summary>
        public const uint BreedRegistrationNumber = 0x00102295;

        ///<summary>(0010,2296) VR=SQ VM=1 Breed Registry Code Sequence</summary>
        public const uint BreedRegistryCodeSequence = 0x00102296;

        ///<summary>(0010,2297) VR=PN VM=1 Responsible Person</summary>
        public const uint ResponsiblePerson = 0x00102297;

        ///<summary>(0010,2298) VR=CS VM=1 Responsible Person Role</summary>
        public const uint ResponsiblePersonRole = 0x00102298;

        ///<summary>(0010,2299) VR=LO VM=1 Responsible Organization</summary>
        public const uint ResponsibleOrganization = 0x00102299;

        ///<summary>(0010,4000) VR=LT VM=1 Patient Comments</summary>
        public const uint PatientComments = 0x00104000;

        ///<summary>(0010,9431) VR=FL VM=1 Examined Body Thickness</summary>
        public const uint ExaminedBodyThickness = 0x00109431;

        ///<summary>(0012,0010) VR=LO VM=1 Clinical Trial Sponsor Name</summary>
        public const uint ClinicalTrialSponsorName = 0x00120010;

        ///<summary>(0012,0020) VR=LO VM=1 Clinical Trial Protocol Id</summary>
        public const uint ClinicalTrialProtocolId = 0x00120020;

        ///<summary>(0012,0021) VR=LO VM=1 Clinical Trial Protocol Name</summary>
        public const uint ClinicalTrialProtocolName = 0x00120021;

        ///<summary>(0012,0030) VR=LO VM=1 Clinical Trial Site Id</summary>
        public const uint ClinicalTrialSiteId = 0x00120030;

        ///<summary>(0012,0031) VR=LO VM=1 Clinical Trial Site Name</summary>
        public const uint ClinicalTrialSiteName = 0x00120031;

        ///<summary>(0012,0040) VR=LO VM=1 Clinical Trial Subject Id</summary>
        public const uint ClinicalTrialSubjectId = 0x00120040;

        ///<summary>(0012,0042) VR=LO VM=1 Clinical Trial Subject Reading Id</summary>
        public const uint ClinicalTrialSubjectReadingId = 0x00120042;

        ///<summary>(0012,0050) VR=LO VM=1 Clinical Trial Time Point Id</summary>
        public const uint ClinicalTrialTimePointId = 0x00120050;

        ///<summary>(0012,0051) VR=ST VM=1 Clinical Trial Time Point Description</summary>
        public const uint ClinicalTrialTimePointDescription = 0x00120051;

        ///<summary>(0012,0052) VR=FD VM=1 Longitudinal Temporal Offset from Event</summary>
        public const uint LongitudinalTemporalOffsetFromEvent = 0x00120052;

        ///<summary>(0012,0053) VR=CS VM=1 Longitudinal Temporal Event Type</summary>
        public const uint LongitudinalTemporalEventType = 0x00120053;

        ///<summary>(0012,0060) VR=LO VM=1 Clinical Trial Coordinating Center Name</summary>
        public const uint ClinicalTrialCoordinatingCenterName = 0x00120060;

        ///<summary>(0012,0062) VR=CS VM=1 Patient Identity Removed</summary>
        public const uint PatientIdentityRemoved = 0x00120062;

        ///<summary>(0012,0063) VR=LO VM=1-n De-identification Method</summary>
        public const uint DeidentificationMethod = 0x00120063;

        ///<summary>(0012,0064) VR=SQ VM=1 De-identification Method Code Sequence</summary>
        public const uint DeidentificationMethodCodeSequence = 0x00120064;

        ///<summary>(0012,0071) VR=LO VM=1 Clinical Trial Series Id</summary>
        public const uint ClinicalTrialSeriesId = 0x00120071;

        ///<summary>(0012,0072) VR=LO VM=1 Clinical Trial Series Description</summary>
        public const uint ClinicalTrialSeriesDescription = 0x00120072;

        ///<summary>(0012,0081) VR=LO VM=1 Clinical Trial Protocol Ethics Committee Name</summary>
        public const uint ClinicalTrialProtocolEthicsCommitteeName = 0x00120081;

        ///<summary>(0012,0082) VR=LO VM=1 Clinical Trial Protocol Ethics Committee Approval Number</summary>
        public const uint ClinicalTrialProtocolEthicsCommitteeApprovalNumber = 0x00120082;

        ///<summary>(0012,0083) VR=SQ VM=1 Consent for Clinical Trial Use Sequence</summary>
        public const uint ConsentForClinicalTrialUseSequence = 0x00120083;

        ///<summary>(0012,0084) VR=CS VM=1 Distribution Type</summary>
        public const uint DistributionType = 0x00120084;

        ///<summary>(0012,0085) VR=CS VM=1 Consent for Distribution Flag</summary>
        public const uint ConsentForDistributionFlag = 0x00120085;

        ///<summary>(0012,0086) VR=DA VM=1 Ethics Committee Approval Effectiveness Start Date</summary>
        public const uint EthicsCommitteeApprovalEffectivenessStartDate = 0x00120086;

        ///<summary>(0012,0087) VR=DA VM=1 Ethics Committee Approval Effectiveness End Date</summary>
        public const uint EthicsCommitteeApprovalEffectivenessEndDate = 0x00120087;

        ///<summary>(0014,0023) VR=ST VM=1 CAD File Format (RETIRED)</summary>
        public const uint CADFileFormatRETIRED = 0x00140023;

        ///<summary>(0014,0024) VR=ST VM=1 Component Reference System (RETIRED)</summary>
        public const uint ComponentReferenceSystemRETIRED = 0x00140024;

        ///<summary>(0014,0025) VR=ST VM=1 Component Manufacturing Procedure</summary>
        public const uint ComponentManufacturingProcedure = 0x00140025;

        ///<summary>(0014,0028) VR=ST VM=1 Component Manufacturer</summary>
        public const uint ComponentManufacturer = 0x00140028;

        ///<summary>(0014,0030) VR=DS VM=1-n Material Thickness</summary>
        public const uint MaterialThickness = 0x00140030;

        ///<summary>(0014,0032) VR=DS VM=1-n Material Pipe Diameter</summary>
        public const uint MaterialPipeDiameter = 0x00140032;

        ///<summary>(0014,0034) VR=DS VM=1-n Material Isolation Diameter</summary>
        public const uint MaterialIsolationDiameter = 0x00140034;

        ///<summary>(0014,0042) VR=ST VM=1 Material Grade</summary>
        public const uint MaterialGrade = 0x00140042;

        ///<summary>(0014,0044) VR=ST VM=1 Material Properties Description</summary>
        public const uint MaterialPropertiesDescription = 0x00140044;

        ///<summary>(0014,0045) VR=ST VM=1 Material Properties File Format (Retired) (RETIRED)</summary>
        public const uint MaterialPropertiesFileFormatRetiredRETIRED = 0x00140045;

        ///<summary>(0014,0046) VR=LT VM=1 Material Notes</summary>
        public const uint MaterialNotes = 0x00140046;

        ///<summary>(0014,0050) VR=CS VM=1 Component Shape</summary>
        public const uint ComponentShape = 0x00140050;

        ///<summary>(0014,0052) VR=CS VM=1 Curvature Type</summary>
        public const uint CurvatureType = 0x00140052;

        ///<summary>(0014,0054) VR=DS VM=1 Outer Diameter</summary>
        public const uint OuterDiameter = 0x00140054;

        ///<summary>(0014,0056) VR=DS VM=1 Inner Diameter</summary>
        public const uint InnerDiameter = 0x00140056;

        ///<summary>(0014,0100) VR=LO VM=1-n Component Welder Ids</summary>
        public const uint ComponentWelderIds = 0x00140100;

        ///<summary>(0014,0101) VR=CS VM=1 Secondary Approval Status</summary>
        public const uint SecondaryApprovalStatus = 0x00140101;

        ///<summary>(0014,0102) VR=DA VM=1 Secondary Review Date</summary>
        public const uint SecondaryReviewDate = 0x00140102;

        ///<summary>(0014,0103) VR=TM VM=1 Secondary Review Time</summary>
        public const uint SecondaryReviewTime = 0x00140103;

        ///<summary>(0014,0104) VR=PN VM=1 Secondary Reviewer Name</summary>
        public const uint SecondaryReviewerName = 0x00140104;

        ///<summary>(0014,0105) VR=ST VM=1 Repair Id</summary>
        public const uint RepairId = 0x00140105;

        ///<summary>(0014,0106) VR=SQ VM=1 Multiple Component Approval Sequence</summary>
        public const uint MultipleComponentApprovalSequence = 0x00140106;

        ///<summary>(0014,0107) VR=CS VM=1-n Other Approval Status</summary>
        public const uint OtherApprovalStatus = 0x00140107;

        ///<summary>(0014,0108) VR=CS VM=1-n Other Secondary Approval Status</summary>
        public const uint OtherSecondaryApprovalStatus = 0x00140108;

        ///<summary>(0014,1010) VR=ST VM=1 Actual Environmental Conditions</summary>
        public const uint ActualEnvironmentalConditions = 0x00141010;

        ///<summary>(0014,1020) VR=DA VM=1 Expiry Date</summary>
        public const uint ExpiryDate = 0x00141020;

        ///<summary>(0014,1040) VR=ST VM=1 Environmental Conditions</summary>
        public const uint EnvironmentalConditions = 0x00141040;

        ///<summary>(0014,2002) VR=SQ VM=1 Evaluator Sequence</summary>
        public const uint EvaluatorSequence = 0x00142002;

        ///<summary>(0014,2004) VR=IS VM=1 Evaluator Number</summary>
        public const uint EvaluatorNumber = 0x00142004;

        ///<summary>(0014,2006) VR=PN VM=1 Evaluator Name</summary>
        public const uint EvaluatorName = 0x00142006;

        ///<summary>(0014,2008) VR=IS VM=1 Evaluation Attempt</summary>
        public const uint EvaluationAttempt = 0x00142008;

        ///<summary>(0014,2012) VR=SQ VM=1 Indication Sequence</summary>
        public const uint IndicationSequence = 0x00142012;

        ///<summary>(0014,2014) VR=IS VM=1 Indication Number</summary>
        public const uint IndicationNumber = 0x00142014;

        ///<summary>(0014,2016) VR=SH VM=1 Indication Label</summary>
        public const uint IndicationLabel = 0x00142016;

        ///<summary>(0014,2018) VR=ST VM=1 Indication Description</summary>
        public const uint IndicationDescription = 0x00142018;

        ///<summary>(0014,201A) VR=CS VM=1-n Indication Type</summary>
        public const uint IndicationType = 0x0014201A;

        ///<summary>(0014,201C) VR=CS VM=1 Indication Disposition</summary>
        public const uint IndicationDisposition = 0x0014201C;

        ///<summary>(0014,201E) VR=SQ VM=1 Indication ROI Sequence</summary>
        public const uint IndicationROISequence = 0x0014201E;

        ///<summary>(0014,2030) VR=SQ VM=1 Indication Physical Property Sequence</summary>
        public const uint IndicationPhysicalPropertySequence = 0x00142030;

        ///<summary>(0014,2032) VR=SH VM=1 Property Label</summary>
        public const uint PropertyLabel = 0x00142032;

        ///<summary>(0014,2202) VR=IS VM=1 Coordinate System Number of Axes</summary>
        public const uint CoordinateSystemNumberOfAxes = 0x00142202;

        ///<summary>(0014,2204) VR=SQ VM=1 Coordinate System Axes Sequence</summary>
        public const uint CoordinateSystemAxesSequence = 0x00142204;

        ///<summary>(0014,2206) VR=ST VM=1 Coordinate System Axis Description</summary>
        public const uint CoordinateSystemAxisDescription = 0x00142206;

        ///<summary>(0014,2208) VR=CS VM=1 Coordinate System Data Set Mapping</summary>
        public const uint CoordinateSystemDataSetMapping = 0x00142208;

        ///<summary>(0014,220A) VR=IS VM=1 Coordinate System Axis Number</summary>
        public const uint CoordinateSystemAxisNumber = 0x0014220A;

        ///<summary>(0014,220C) VR=CS VM=1 Coordinate System Axis Type</summary>
        public const uint CoordinateSystemAxisType = 0x0014220C;

        ///<summary>(0014,220E) VR=CS VM=1 Coordinate System Axis Units</summary>
        public const uint CoordinateSystemAxisUnits = 0x0014220E;

        ///<summary>(0014,2210) VR=OB VM=1 Coordinate System Axis Values</summary>
        public const uint CoordinateSystemAxisValues = 0x00142210;

        ///<summary>(0014,2220) VR=SQ VM=1 Coordinate System Transform Sequence</summary>
        public const uint CoordinateSystemTransformSequence = 0x00142220;

        ///<summary>(0014,2222) VR=ST VM=1 Transform Description</summary>
        public const uint TransformDescription = 0x00142222;

        ///<summary>(0014,2224) VR=IS VM=1 Transform Number of Axes</summary>
        public const uint TransformNumberOfAxes = 0x00142224;

        ///<summary>(0014,2226) VR=IS VM=1-n Transform Order of Axes</summary>
        public const uint TransformOrderOfAxes = 0x00142226;

        ///<summary>(0014,2228) VR=CS VM=1 Transformed Axis Units</summary>
        public const uint TransformedAxisUnits = 0x00142228;

        ///<summary>(0014,222A) VR=DS VM=1-n Coordinate System Transform Rotation and Scale Matrix</summary>
        public const uint CoordinateSystemTransformRotationAndScaleMatrix = 0x0014222A;

        ///<summary>(0014,222C) VR=DS VM=1-n Coordinate System Transform Translation Matrix</summary>
        public const uint CoordinateSystemTransformTranslationMatrix = 0x0014222C;

        ///<summary>(0014,3011) VR=DS VM=1 Internal Detector Frame Time</summary>
        public const uint InternalDetectorFrameTime = 0x00143011;

        ///<summary>(0014,3012) VR=DS VM=1 Number of Frames Integrated</summary>
        public const uint NumberOfFramesIntegrated = 0x00143012;

        ///<summary>(0014,3020) VR=SQ VM=1 Detector Temperature Sequence</summary>
        public const uint DetectorTemperatureSequence = 0x00143020;

        ///<summary>(0014,3022) VR=ST VM=1 Sensor Name</summary>
        public const uint SensorName = 0x00143022;

        ///<summary>(0014,3024) VR=DS VM=1 Horizontal Offset of Sensor</summary>
        public const uint HorizontalOffsetOfSensor = 0x00143024;

        ///<summary>(0014,3026) VR=DS VM=1 Vertical Offset of Sensor</summary>
        public const uint VerticalOffsetOfSensor = 0x00143026;

        ///<summary>(0014,3028) VR=DS VM=1 Sensor Temperature</summary>
        public const uint SensorTemperature = 0x00143028;

        ///<summary>(0014,3040) VR=SQ VM=1 Dark Current Sequence</summary>
        public const uint DarkCurrentSequence = 0x00143040;

        ///<summary>(0014,3050) VR=OB/OW VM=1 Dark Current Counts</summary>
        public const uint DarkCurrentCounts = 0x00143050;

        ///<summary>(0014,3060) VR=SQ VM=1 Gain Correction Reference Sequence</summary>
        public const uint GainCorrectionReferenceSequence = 0x00143060;

        ///<summary>(0014,3070) VR=OB/OW VM=1 Air Counts</summary>
        public const uint AirCounts = 0x00143070;

        ///<summary>(0014,3071) VR=DS VM=1 KV Used in Gain Calibration</summary>
        public const uint KVUsedInGainCalibration = 0x00143071;

        ///<summary>(0014,3072) VR=DS VM=1 MA Used in Gain Calibration</summary>
        public const uint MAUsedInGainCalibration = 0x00143072;

        ///<summary>(0014,3073) VR=DS VM=1 Number of Frames Used for Integration</summary>
        public const uint NumberOfFramesUsedForIntegration = 0x00143073;

        ///<summary>(0014,3074) VR=LO VM=1 Filter Material Used in Gain Calibration</summary>
        public const uint FilterMaterialUsedInGainCalibration = 0x00143074;

        ///<summary>(0014,3075) VR=DS VM=1 Filter Thickness Used in Gain Calibration</summary>
        public const uint FilterThicknessUsedInGainCalibration = 0x00143075;

        ///<summary>(0014,3076) VR=DA VM=1 Date of Gain Calibration</summary>
        public const uint DateOfGainCalibration = 0x00143076;

        ///<summary>(0014,3077) VR=TM VM=1 Time of Gain Calibration</summary>
        public const uint TimeOfGainCalibration = 0x00143077;

        ///<summary>(0014,3080) VR=OB VM=1 Bad Pixel Image</summary>
        public const uint BadPixelImage = 0x00143080;

        ///<summary>(0014,3099) VR=LT VM=1 Calibration Notes</summary>
        public const uint CalibrationNotes = 0x00143099;

        ///<summary>(0014,3100) VR=LT VM=1 Linearity Correction Technique</summary>
        public const uint LinearityCorrectionTechnique = 0x00143100;

        ///<summary>(0014,3101) VR=LT VM=1 Beam Hardening Correction Technique</summary>
        public const uint BeamHardeningCorrectionTechnique = 0x00143101;

        ///<summary>(0014,4002) VR=SQ VM=1 Pulser Equipment Sequence</summary>
        public const uint PulserEquipmentSequence = 0x00144002;

        ///<summary>(0014,4004) VR=CS VM=1 Pulser Type</summary>
        public const uint PulserType = 0x00144004;

        ///<summary>(0014,4006) VR=LT VM=1 Pulser Notes</summary>
        public const uint PulserNotes = 0x00144006;

        ///<summary>(0014,4008) VR=SQ VM=1 Receiver Equipment Sequence</summary>
        public const uint ReceiverEquipmentSequence = 0x00144008;

        ///<summary>(0014,400A) VR=CS VM=1 Amplifier Type</summary>
        public const uint AmplifierType = 0x0014400A;

        ///<summary>(0014,400C) VR=LT VM=1 Receiver Notes</summary>
        public const uint ReceiverNotes = 0x0014400C;

        ///<summary>(0014,400E) VR=SQ VM=1 Pre-Amplifier Equipment Sequence</summary>
        public const uint PreAmplifierEquipmentSequence = 0x0014400E;

        ///<summary>(0014,400F) VR=LT VM=1 Pre-Amplifier Notes</summary>
        public const uint PreAmplifierNotes = 0x0014400F;

        ///<summary>(0014,4010) VR=SQ VM=1 Transmit Transducer Sequence</summary>
        public const uint TransmitTransducerSequence = 0x00144010;

        ///<summary>(0014,4011) VR=SQ VM=1 Receive Transducer Sequence</summary>
        public const uint ReceiveTransducerSequence = 0x00144011;

        ///<summary>(0014,4012) VR=US VM=1 Number of Elements</summary>
        public const uint NumberOfElements = 0x00144012;

        ///<summary>(0014,4013) VR=CS VM=1 Element Shape</summary>
        public const uint ElementShape = 0x00144013;

        ///<summary>(0014,4014) VR=DS VM=1 Element Dimension A</summary>
        public const uint ElementDimensionA = 0x00144014;

        ///<summary>(0014,4015) VR=DS VM=1 Element Dimension B</summary>
        public const uint ElementDimensionB = 0x00144015;

        ///<summary>(0014,4016) VR=DS VM=1 Element Pitch A</summary>
        public const uint ElementPitchA = 0x00144016;

        ///<summary>(0014,4017) VR=DS VM=1 Measured Beam Dimension A</summary>
        public const uint MeasuredBeamDimensionA = 0x00144017;

        ///<summary>(0014,4018) VR=DS VM=1 Measured Beam Dimension B</summary>
        public const uint MeasuredBeamDimensionB = 0x00144018;

        ///<summary>(0014,4019) VR=DS VM=1 Location of Measured Beam Diameter</summary>
        public const uint LocationOfMeasuredBeamDiameter = 0x00144019;

        ///<summary>(0014,401A) VR=DS VM=1 Nominal Frequency</summary>
        public const uint NominalFrequency = 0x0014401A;

        ///<summary>(0014,401B) VR=DS VM=1 Measured Center Frequency</summary>
        public const uint MeasuredCenterFrequency = 0x0014401B;

        ///<summary>(0014,401C) VR=DS VM=1 Measured Bandwidth</summary>
        public const uint MeasuredBandwidth = 0x0014401C;

        ///<summary>(0014,401D) VR=DS VM=1 Element Pitch B</summary>
        public const uint ElementPitchB = 0x0014401D;

        ///<summary>(0014,4020) VR=SQ VM=1 Pulser Settings Sequence</summary>
        public const uint PulserSettingsSequence = 0x00144020;

        ///<summary>(0014,4022) VR=DS VM=1 Pulse Width</summary>
        public const uint PulseWidth = 0x00144022;

        ///<summary>(0014,4024) VR=DS VM=1 Excitation Frequency</summary>
        public const uint ExcitationFrequency = 0x00144024;

        ///<summary>(0014,4026) VR=CS VM=1 Modulation Type</summary>
        public const uint ModulationType = 0x00144026;

        ///<summary>(0014,4028) VR=DS VM=1 Damping</summary>
        public const uint Damping = 0x00144028;

        ///<summary>(0014,4030) VR=SQ VM=1 Receiver Settings Sequence</summary>
        public const uint ReceiverSettingsSequence = 0x00144030;

        ///<summary>(0014,4031) VR=DS VM=1 Acquired Soundpath Length</summary>
        public const uint AcquiredSoundpathLength = 0x00144031;

        ///<summary>(0014,4032) VR=CS VM=1 Acquisition Compression Type</summary>
        public const uint AcquisitionCompressionType = 0x00144032;

        ///<summary>(0014,4033) VR=IS VM=1 Acquisition Sample Size</summary>
        public const uint AcquisitionSampleSize = 0x00144033;

        ///<summary>(0014,4034) VR=DS VM=1 Rectifier Smoothing</summary>
        public const uint RectifierSmoothing = 0x00144034;

        ///<summary>(0014,4035) VR=SQ VM=1 DAC Sequence</summary>
        public const uint DACSequence = 0x00144035;

        ///<summary>(0014,4036) VR=CS VM=1 DAC Type</summary>
        public const uint DACType = 0x00144036;

        ///<summary>(0014,4038) VR=DS VM=1-n DAC Gain Points</summary>
        public const uint DACGainPoints = 0x00144038;

        ///<summary>(0014,403A) VR=DS VM=1-n DAC Time Points</summary>
        public const uint DACTimePoints = 0x0014403A;

        ///<summary>(0014,403C) VR=DS VM=1-n DAC Amplitude</summary>
        public const uint DACAmplitude = 0x0014403C;

        ///<summary>(0014,4040) VR=SQ VM=1 Pre-Amplifier Settings Sequence</summary>
        public const uint PreAmplifierSettingsSequence = 0x00144040;

        ///<summary>(0014,4050) VR=SQ VM=1 Transmit Transducer Settings Sequence</summary>
        public const uint TransmitTransducerSettingsSequence = 0x00144050;

        ///<summary>(0014,4051) VR=SQ VM=1 Receive Transducer Settings Sequence</summary>
        public const uint ReceiveTransducerSettingsSequence = 0x00144051;

        ///<summary>(0014,4052) VR=DS VM=1 Incident Angle</summary>
        public const uint IncidentAngle = 0x00144052;

        ///<summary>(0014,4054) VR=ST VM=1 Coupling Technique</summary>
        public const uint CouplingTechnique = 0x00144054;

        ///<summary>(0014,4056) VR=ST VM=1 Coupling Medium</summary>
        public const uint CouplingMedium = 0x00144056;

        ///<summary>(0014,4057) VR=DS VM=1 Coupling Velocity</summary>
        public const uint CouplingVelocity = 0x00144057;

        ///<summary>(0014,4058) VR=DS VM=1 Probe Center Location X</summary>
        public const uint ProbeCenterLocationX = 0x00144058;

        ///<summary>(0014,4059) VR=DS VM=1 Probe Center Location Z</summary>
        public const uint ProbeCenterLocationZ = 0x00144059;

        ///<summary>(0014,405A) VR=DS VM=1 Sound Path Length</summary>
        public const uint SoundPathLength = 0x0014405A;

        ///<summary>(0014,405C) VR=ST VM=1 Delay Law Identifier</summary>
        public const uint DelayLawIdentifier = 0x0014405C;

        ///<summary>(0014,4060) VR=SQ VM=1 Gate Settings Sequence</summary>
        public const uint GateSettingsSequence = 0x00144060;

        ///<summary>(0014,4062) VR=DS VM=1 Gate Threshold</summary>
        public const uint GateThreshold = 0x00144062;

        ///<summary>(0014,4064) VR=DS VM=1 Velocity of Sound</summary>
        public const uint VelocityOfSound = 0x00144064;

        ///<summary>(0014,4070) VR=SQ VM=1 Calibration Settings Sequence</summary>
        public const uint CalibrationSettingsSequence = 0x00144070;

        ///<summary>(0014,4072) VR=ST VM=1 Calibration Procedure</summary>
        public const uint CalibrationProcedure = 0x00144072;

        ///<summary>(0014,4074) VR=SH VM=1 Procedure Version</summary>
        public const uint ProcedureVersion = 0x00144074;

        ///<summary>(0014,4076) VR=DA VM=1 Procedure Creation Date</summary>
        public const uint ProcedureCreationDate = 0x00144076;

        ///<summary>(0014,4078) VR=DA VM=1 Procedure Expiration Date</summary>
        public const uint ProcedureExpirationDate = 0x00144078;

        ///<summary>(0014,407A) VR=DA VM=1 Procedure Last Modified Date</summary>
        public const uint ProcedureLastModifiedDate = 0x0014407A;

        ///<summary>(0014,407C) VR=TM VM=1-n Calibration Time</summary>
        public const uint CalibrationTime = 0x0014407C;

        ///<summary>(0014,407E) VR=DA VM=1-n Calibration Date</summary>
        public const uint CalibrationDate = 0x0014407E;

        ///<summary>(0014,4080) VR=SQ VM=1 Probe Drive Equipment Sequence</summary>
        public const uint ProbeDriveEquipmentSequence = 0x00144080;

        ///<summary>(0014,4081) VR=CS VM=1 Drive Type</summary>
        public const uint DriveType = 0x00144081;

        ///<summary>(0014,4082) VR=LT VM=1 Probe Drive Notes</summary>
        public const uint ProbeDriveNotes = 0x00144082;

        ///<summary>(0014,4083) VR=SQ VM=1 Drive Probe Sequence</summary>
        public const uint DriveProbeSequence = 0x00144083;

        ///<summary>(0014,4084) VR=DS VM=1 Probe Inductance</summary>
        public const uint ProbeInductance = 0x00144084;

        ///<summary>(0014,4085) VR=DS VM=1 Probe Resistance</summary>
        public const uint ProbeResistance = 0x00144085;

        ///<summary>(0014,4086) VR=SQ VM=1 Receive Probe Sequence</summary>
        public const uint ReceiveProbeSequence = 0x00144086;

        ///<summary>(0014,4087) VR=SQ VM=1 Probe Drive Settings Sequence</summary>
        public const uint ProbeDriveSettingsSequence = 0x00144087;

        ///<summary>(0014,4088) VR=DS VM=1 Bridge Resistors</summary>
        public const uint BridgeResistors = 0x00144088;

        ///<summary>(0014,4089) VR=DS VM=1 Probe Orientation Angle</summary>
        public const uint ProbeOrientationAngle = 0x00144089;

        ///<summary>(0014,408B) VR=DS VM=1 User Selected Gain Y</summary>
        public const uint UserSelectedGainY = 0x0014408B;

        ///<summary>(0014,408C) VR=DS VM=1 User Selected Phase</summary>
        public const uint UserSelectedPhase = 0x0014408C;

        ///<summary>(0014,408D) VR=DS VM=1 User Selected Offset X</summary>
        public const uint UserSelectedOffsetX = 0x0014408D;

        ///<summary>(0014,408E) VR=DS VM=1 User Selected Offset Y</summary>
        public const uint UserSelectedOffsetY = 0x0014408E;

        ///<summary>(0014,4091) VR=SQ VM=1 Channel Settings Sequence</summary>
        public const uint ChannelSettingsSequence = 0x00144091;

        ///<summary>(0014,4092) VR=DS VM=1 Channel Threshold</summary>
        public const uint ChannelThreshold = 0x00144092;

        ///<summary>(0014,409A) VR=SQ VM=1 Scanner Settings Sequence</summary>
        public const uint ScannerSettingsSequence = 0x0014409A;

        ///<summary>(0014,409B) VR=ST VM=1 Scan Procedure</summary>
        public const uint ScanProcedure = 0x0014409B;

        ///<summary>(0014,409C) VR=DS VM=1 Translation Rate X</summary>
        public const uint TranslationRateX = 0x0014409C;

        ///<summary>(0014,409D) VR=DS VM=1 Translation Rate Y</summary>
        public const uint TranslationRateY = 0x0014409D;

        ///<summary>(0014,409F) VR=DS VM=1 Channel Overlap</summary>
        public const uint ChannelOverlap = 0x0014409F;

        ///<summary>(0014,40A0) VR=LO VM=1-n Image Quality Indicator Type</summary>
        public const uint ImageQualityIndicatorType = 0x001440A0;

        ///<summary>(0014,40A1) VR=LO VM=1-n Image Quality Indicator Material</summary>
        public const uint ImageQualityIndicatorMaterial = 0x001440A1;

        ///<summary>(0014,40A2) VR=LO VM=1-n Image Quality Indicator Size</summary>
        public const uint ImageQualityIndicatorSize = 0x001440A2;

        ///<summary>(0014,5002) VR=IS VM=1 LINAC Energy</summary>
        public const uint LINACEnergy = 0x00145002;

        ///<summary>(0014,5004) VR=IS VM=1 LINAC Output</summary>
        public const uint LINACOutput = 0x00145004;

        ///<summary>(0014,5100) VR=US VM=1 Active Aperture</summary>
        public const uint ActiveAperture = 0x00145100;

        ///<summary>(0014,5101) VR=DS VM=1 Total Aperture</summary>
        public const uint TotalAperture = 0x00145101;

        ///<summary>(0014,5102) VR=DS VM=1 Aperture Elevation</summary>
        public const uint ApertureElevation = 0x00145102;

        ///<summary>(0014,5103) VR=DS VM=1 Main Lobe Angle</summary>
        public const uint MainLobeAngle = 0x00145103;

        ///<summary>(0014,5104) VR=DS VM=1 Main Roof Angle</summary>
        public const uint MainRoofAngle = 0x00145104;

        ///<summary>(0014,5105) VR=CS VM=1 Connector Type</summary>
        public const uint ConnectorType = 0x00145105;

        ///<summary>(0014,5106) VR=SH VM=1 Wedge Model Number</summary>
        public const uint WedgeModelNumber = 0x00145106;

        ///<summary>(0014,5107) VR=DS VM=1 Wedge Angle Float</summary>
        public const uint WedgeAngleFloat = 0x00145107;

        ///<summary>(0014,5108) VR=DS VM=1 Wedge Roof Angle</summary>
        public const uint WedgeRoofAngle = 0x00145108;

        ///<summary>(0014,5109) VR=CS VM=1 Wedge Element 1 Position</summary>
        public const uint WedgeElement1Position = 0x00145109;

        ///<summary>(0014,510A) VR=DS VM=1 Wedge Material Velocity</summary>
        public const uint WedgeMaterialVelocity = 0x0014510A;

        ///<summary>(0014,510B) VR=SH VM=1 Wedge Material</summary>
        public const uint WedgeMaterial = 0x0014510B;

        ///<summary>(0014,510C) VR=DS VM=1 Wedge Offset Z</summary>
        public const uint WedgeOffsetZ = 0x0014510C;

        ///<summary>(0014,510D) VR=DS VM=1 Wedge Origin Offset X</summary>
        public const uint WedgeOriginOffsetX = 0x0014510D;

        ///<summary>(0014,510E) VR=DS VM=1 Wedge Time Delay</summary>
        public const uint WedgeTimeDelay = 0x0014510E;

        ///<summary>(0014,510F) VR=SH VM=1 Wedge Name</summary>
        public const uint WedgeName = 0x0014510F;

        ///<summary>(0014,5110) VR=SH VM=1 Wedge Manufacturer Name</summary>
        public const uint WedgeManufacturerName = 0x00145110;

        ///<summary>(0014,5111) VR=LO VM=1 Wedge Description</summary>
        public const uint WedgeDescription = 0x00145111;

        ///<summary>(0014,5112) VR=DS VM=1 Nominal Beam Angle</summary>
        public const uint NominalBeamAngle = 0x00145112;

        ///<summary>(0014,5113) VR=DS VM=1 Wedge Offset X</summary>
        public const uint WedgeOffsetX = 0x00145113;

        ///<summary>(0014,5114) VR=DS VM=1 Wedge Offset Y</summary>
        public const uint WedgeOffsetY = 0x00145114;

        ///<summary>(0014,5115) VR=DS VM=1 Wedge Total Length</summary>
        public const uint WedgeTotalLength = 0x00145115;

        ///<summary>(0014,5116) VR=DS VM=1 Wedge In Contact Length</summary>
        public const uint WedgeInContactLength = 0x00145116;

        ///<summary>(0014,5117) VR=DS VM=1 Wedge Front Gap</summary>
        public const uint WedgeFrontGap = 0x00145117;

        ///<summary>(0014,5118) VR=DS VM=1 Wedge Total Height</summary>
        public const uint WedgeTotalHeight = 0x00145118;

        ///<summary>(0014,5119) VR=DS VM=1 Wedge Front Height</summary>
        public const uint WedgeFrontHeight = 0x00145119;

        ///<summary>(0014,511A) VR=DS VM=1 Wedge Rear Height</summary>
        public const uint WedgeRearHeight = 0x0014511A;

        ///<summary>(0014,511B) VR=DS VM=1 Wedge Total Width</summary>
        public const uint WedgeTotalWidth = 0x0014511B;

        ///<summary>(0014,511C) VR=DS VM=1 Wedge In Contact Width</summary>
        public const uint WedgeInContactWidth = 0x0014511C;

        ///<summary>(0014,511D) VR=DS VM=1 Wedge Chamfer Height</summary>
        public const uint WedgeChamferHeight = 0x0014511D;

        ///<summary>(0014,511E) VR=CS VM=1 Wedge Curve</summary>
        public const uint WedgeCurve = 0x0014511E;

        ///<summary>(0014,511F) VR=DS VM=1 Radius Along the Wedge</summary>
        public const uint RadiusAlongWedge = 0x0014511F;

        ///<summary>(0016,0001) VR=DS VM=1 White Point</summary>
        public const uint WhitePoint = 0x00160001;

        ///<summary>(0016,0002) VR=DS VM=3 Primary Chromaticities</summary>
        public const uint PrimaryChromaticities = 0x00160002;

        ///<summary>(0016,0003) VR=UT VM=1 Battery Level</summary>
        public const uint BatteryLevel = 0x00160003;

        ///<summary>(0016,0004) VR=DS VM=1 Exposure Time in Seconds</summary>
        public const uint ExposureTimeInSeconds = 0x00160004;

        ///<summary>(0016,0005) VR=DS VM=1 F-Number</summary>
        public const uint FNumber = 0x00160005;

        ///<summary>(0016,0006) VR=IS VM=1 OECF Rows</summary>
        public const uint OECFRows = 0x00160006;

        ///<summary>(0016,0007) VR=IS VM=1 OECF Columns</summary>
        public const uint OECFColumns = 0x00160007;

        ///<summary>(0016,0008) VR=UC VM=1-n OECF Column Names</summary>
        public const uint OECFColumnNames = 0x00160008;

        ///<summary>(0016,0009) VR=DS VM=1-n OECF Values</summary>
        public const uint OECFValues = 0x00160009;

        ///<summary>(0016,000A) VR=IS VM=1 Spatial Frequency Response Rows</summary>
        public const uint SpatialFrequencyResponseRows = 0x0016000A;

        ///<summary>(0016,000B) VR=IS VM=1 Spatial Frequency Response Columns</summary>
        public const uint SpatialFrequencyResponseColumns = 0x0016000B;

        ///<summary>(0016,000C) VR=UC VM=1-n Spatial Frequency Response Column Names</summary>
        public const uint SpatialFrequencyResponseColumnNames = 0x0016000C;

        ///<summary>(0016,000D) VR=DS VM=1-n Spatial Frequency Response Values</summary>
        public const uint SpatialFrequencyResponseValues = 0x0016000D;

        ///<summary>(0016,000E) VR=IS VM=1 Color Filter Array Pattern Rows</summary>
        public const uint ColorFilterArrayPatternRows = 0x0016000E;

        ///<summary>(0016,000F) VR=IS VM=1 Color Filter Array Pattern Columns</summary>
        public const uint ColorFilterArrayPatternColumns = 0x0016000F;

        ///<summary>(0016,0010) VR=DS VM=1-n Color Filter Array Pattern Values</summary>
        public const uint ColorFilterArrayPatternValues = 0x00160010;

        ///<summary>(0016,0011) VR=US VM=1 Flash Firing Status</summary>
        public const uint FlashFiringStatus = 0x00160011;

        ///<summary>(0016,0012) VR=US VM=1 Flash Return Status</summary>
        public const uint FlashReturnStatus = 0x00160012;

        ///<summary>(0016,0013) VR=US VM=1 Flash Mode</summary>
        public const uint FlashMode = 0x00160013;

        ///<summary>(0016,0014) VR=US VM=1 Flash Function Present</summary>
        public const uint FlashFunctionPresent = 0x00160014;

        ///<summary>(0016,0015) VR=US VM=1 Flash Red Eye Mode</summary>
        public const uint FlashRedEyeMode = 0x00160015;

        ///<summary>(0016,0016) VR=US VM=1 Exposure Program</summary>
        public const uint ExposureProgram = 0x00160016;

        ///<summary>(0016,0017) VR=UT VM=1 Spectral Sensitivity</summary>
        public const uint SpectralSensitivity = 0x00160017;

        ///<summary>(0016,0018) VR=IS VM=1 Photographic Sensitivity</summary>
        public const uint PhotographicSensitivity = 0x00160018;

        ///<summary>(0016,0019) VR=IS VM=1 Self Timer Mode</summary>
        public const uint SelfTimerMode = 0x00160019;

        ///<summary>(0016,001A) VR=US VM=1 Sensitivity Type</summary>
        public const uint SensitivityType = 0x0016001A;

        ///<summary>(0016,001B) VR=IS VM=1 Standard Output Sensitivity</summary>
        public const uint StandardOutputSensitivity = 0x0016001B;

        ///<summary>(0016,001C) VR=IS VM=1 Recommended Exposure Index</summary>
        public const uint RecommendedExposureIndex = 0x0016001C;

        ///<summary>(0016,001D) VR=IS VM=1 ISO Speed</summary>
        public const uint ISOSpeed = 0x0016001D;

        ///<summary>(0016,001E) VR=IS VM=1 ISO Speed Latitude yyy</summary>
        public const uint ISOSpeedLatitudeyyy = 0x0016001E;

        ///<summary>(0016,001F) VR=IS VM=1 ISO Speed Latitude zzz</summary>
        public const uint ISOSpeedLatitudezzz = 0x0016001F;

        ///<summary>(0016,0020) VR=UT VM=1 EXIF Version</summary>
        public const uint EXIFVersion = 0x00160020;

        ///<summary>(0016,0021) VR=DS VM=1 Shutter Speed Value</summary>
        public const uint ShutterSpeedValue = 0x00160021;

        ///<summary>(0016,0022) VR=DS VM=1 Aperture Value</summary>
        public const uint ApertureValue = 0x00160022;

        ///<summary>(0016,0023) VR=DS VM=1 Brightness Value</summary>
        public const uint BrightnessValue = 0x00160023;

        ///<summary>(0016,0024) VR=DS VM=1 Exposure Bias Value</summary>
        public const uint ExposureBiasValue = 0x00160024;

        ///<summary>(0016,0025) VR=DS VM=1 Max Aperture Value</summary>
        public const uint MaxApertureValue = 0x00160025;

        ///<summary>(0016,0026) VR=DS VM=1 Subject Distance</summary>
        public const uint SubjectDistance = 0x00160026;

        ///<summary>(0016,0027) VR=US VM=1 Metering Mode</summary>
        public const uint MeteringMode = 0x00160027;

        ///<summary>(0016,0028) VR=US VM=1 Light Source</summary>
        public const uint LightSource = 0x00160028;

        ///<summary>(0016,0029) VR=DS VM=1 Focal Length</summary>
        public const uint FocalLength = 0x00160029;

        ///<summary>(0016,002A) VR=IS VM=2-4 Subject Area</summary>
        public const uint SubjectArea = 0x0016002A;

        ///<summary>(0016,002B) VR=OB VM=1 Maker Note</summary>
        public const uint MakerNote = 0x0016002B;

        ///<summary>(0016,0030) VR=DS VM=1 Temperature</summary>
        public const uint Temperature = 0x00160030;

        ///<summary>(0016,0031) VR=DS VM=1 Humidity</summary>
        public const uint Humidity = 0x00160031;

        ///<summary>(0016,0032) VR=DS VM=1 Pressure</summary>
        public const uint Pressure = 0x00160032;

        ///<summary>(0016,0033) VR=DS VM=1 Water Depth</summary>
        public const uint WaterDepth = 0x00160033;

        ///<summary>(0016,0034) VR=DS VM=1 Acceleration</summary>
        public const uint Acceleration = 0x00160034;

        ///<summary>(0016,0035) VR=DS VM=1 Camera Elevation Angle</summary>
        public const uint CameraElevationAngle = 0x00160035;

        ///<summary>(0016,0036) VR=DS VM=1-2 Flash Energy</summary>
        public const uint FlashEnergy = 0x00160036;

        ///<summary>(0016,0037) VR=IS VM=2 Subject Location</summary>
        public const uint SubjectLocation = 0x00160037;

        ///<summary>(0016,0038) VR=DS VM=1 Photographic Exposure Index</summary>
        public const uint PhotographicExposureIndex = 0x00160038;

        ///<summary>(0016,0039) VR=US VM=1 Sensing Method</summary>
        public const uint SensingMethod = 0x00160039;

        ///<summary>(0016,003A) VR=US VM=1 File Source</summary>
        public const uint FileSource = 0x0016003A;

        ///<summary>(0016,003B) VR=US VM=1 Scene Type</summary>
        public const uint SceneType = 0x0016003B;

        ///<summary>(0016,0041) VR=US VM=1 Custom Rendered</summary>
        public const uint CustomRendered = 0x00160041;

        ///<summary>(0016,0042) VR=US VM=1 Exposure Mode</summary>
        public const uint ExposureMode = 0x00160042;

        ///<summary>(0016,0043) VR=US VM=1 White Balance</summary>
        public const uint WhiteBalance = 0x00160043;

        ///<summary>(0016,0044) VR=DS VM=1 Digital Zoom Ratio</summary>
        public const uint DigitalZoomRatio = 0x00160044;

        ///<summary>(0016,0045) VR=IS VM=1 Focal Length In 35mm Film</summary>
        public const uint FocalLengthIn35mmFilm = 0x00160045;

        ///<summary>(0016,0046) VR=US VM=1 Scene Capture Type</summary>
        public const uint SceneCaptureType = 0x00160046;

        ///<summary>(0016,0047) VR=US VM=1 Gain Control</summary>
        public const uint GainControl = 0x00160047;

        ///<summary>(0016,0048) VR=US VM=1 Contrast</summary>
        public const uint Contrast = 0x00160048;

        ///<summary>(0016,0049) VR=US VM=1 Saturation</summary>
        public const uint Saturation = 0x00160049;

        ///<summary>(0016,004A) VR=US VM=1 Sharpness</summary>
        public const uint Sharpness = 0x0016004A;

        ///<summary>(0016,004B) VR=OB VM=1 Device Setting Description</summary>
        public const uint DeviceSettingDescription = 0x0016004B;

        ///<summary>(0016,004C) VR=US VM=1 Subject Distance Range</summary>
        public const uint SubjectDistanceRange = 0x0016004C;

        ///<summary>(0016,004D) VR=UT VM=1 Camera Owner Name</summary>
        public const uint CameraOwnerName = 0x0016004D;

        ///<summary>(0016,004E) VR=DS VM=4 Lens Specification</summary>
        public const uint LensSpecification = 0x0016004E;

        ///<summary>(0016,004F) VR=UT VM=1 Lens Make</summary>
        public const uint LensMake = 0x0016004F;

        ///<summary>(0016,0050) VR=UT VM=1 Lens Model</summary>
        public const uint LensModel = 0x00160050;

        ///<summary>(0016,0051) VR=UT VM=1 Lens Serial Number</summary>
        public const uint LensSerialNumber = 0x00160051;

        ///<summary>(0016,0061) VR=CS VM=1 Interoperability Index</summary>
        public const uint InteroperabilityIndex = 0x00160061;

        ///<summary>(0016,0062) VR=OB VM=1 Interoperability Version</summary>
        public const uint InteroperabilityVersion = 0x00160062;

        ///<summary>(0016,0070) VR=OB VM=1 GPS Version Id</summary>
        public const uint GPSVersionId = 0x00160070;

        ///<summary>(0016,0071) VR=CS VM=1 GPS Latitude Ref</summary>
        public const uint GPSLatitudeRef = 0x00160071;

        ///<summary>(0016,0072) VR=DS VM=3 GPS Latitude</summary>
        public const uint GPSLatitude = 0x00160072;

        ///<summary>(0016,0073) VR=CS VM=1 GPS Longitude Ref</summary>
        public const uint GPSLongitudeRef = 0x00160073;

        ///<summary>(0016,0074) VR=DS VM=3 GPS Longitude</summary>
        public const uint GPSLongitude = 0x00160074;

        ///<summary>(0016,0075) VR=US VM=1 GPS Altitude Ref</summary>
        public const uint GPSAltitudeRef = 0x00160075;

        ///<summary>(0016,0076) VR=DS VM=1 GPS Altitude</summary>
        public const uint GPSAltitude = 0x00160076;

        ///<summary>(0016,0077) VR=DT VM=1 GPS Time Stamp</summary>
        public const uint GPSTimeStamp = 0x00160077;

        ///<summary>(0016,0078) VR=UT VM=1 GPS Satellites</summary>
        public const uint GPSSatellites = 0x00160078;

        ///<summary>(0016,0079) VR=CS VM=1 GPS Status</summary>
        public const uint GPSStatus = 0x00160079;

        ///<summary>(0016,007A) VR=CS VM=1 GPS Measure Mode</summary>
        public const uint GPSMeasureMode = 0x0016007A;

        ///<summary>(0016,007B) VR=DS VM=1 GPS DOP</summary>
        public const uint GPSDOP = 0x0016007B;

        ///<summary>(0016,007C) VR=CS VM=1 GPS Speed Ref</summary>
        public const uint GPSSpeedRef = 0x0016007C;

        ///<summary>(0016,007D) VR=DS VM=1 GPS Speed</summary>
        public const uint GPSSpeed = 0x0016007D;

        ///<summary>(0016,007E) VR=CS VM=1 GPS Track Ref</summary>
        public const uint GPSTrackRef = 0x0016007E;

        ///<summary>(0016,007F) VR=DS VM=1 GPS Track</summary>
        public const uint GPSTrack = 0x0016007F;

        ///<summary>(0016,0080) VR=CS VM=1 GPS Img Direction Ref</summary>
        public const uint GPSImgDirectionRef = 0x00160080;

        ///<summary>(0016,0081) VR=DS VM=1 GPS Img Direction</summary>
        public const uint GPSImgDirection = 0x00160081;

        ///<summary>(0016,0082) VR=UT VM=1 GPS Map Datum</summary>
        public const uint GPSMapDatum = 0x00160082;

        ///<summary>(0016,0083) VR=CS VM=1 GPS Dest Latitude Ref</summary>
        public const uint GPSDestLatitudeRef = 0x00160083;

        ///<summary>(0016,0084) VR=DS VM=3 GPS Dest Latitude</summary>
        public const uint GPSDestLatitude = 0x00160084;

        ///<summary>(0016,0085) VR=CS VM=1 GPS Dest Longitude Ref</summary>
        public const uint GPSDestLongitudeRef = 0x00160085;

        ///<summary>(0016,0086) VR=DS VM=3 GPS Dest Longitude</summary>
        public const uint GPSDestLongitude = 0x00160086;

        ///<summary>(0016,0087) VR=CS VM=1 GPS Dest Bearing Ref</summary>
        public const uint GPSDestBearingRef = 0x00160087;

        ///<summary>(0016,0088) VR=DS VM=1 GPS Dest Bearing</summary>
        public const uint GPSDestBearing = 0x00160088;

        ///<summary>(0016,0089) VR=CS VM=1 GPS Dest Distance Ref</summary>
        public const uint GPSDestDistanceRef = 0x00160089;

        ///<summary>(0016,008A) VR=DS VM=1 GPS Dest Distance</summary>
        public const uint GPSDestDistance = 0x0016008A;

        ///<summary>(0016,008B) VR=OB VM=1 GPS Processing Method</summary>
        public const uint GPSProcessingMethod = 0x0016008B;

        ///<summary>(0016,008C) VR=OB VM=1 GPS Area Information</summary>
        public const uint GPSAreaInformation = 0x0016008C;

        ///<summary>(0016,008D) VR=DT VM=1 GPS Date Stamp</summary>
        public const uint GPSDateStamp = 0x0016008D;

        ///<summary>(0016,008E) VR=IS VM=1 GPS Differential</summary>
        public const uint GPSDifferential = 0x0016008E;

        ///<summary>(0016,1001) VR=CS VM=1 Light Source Polarization</summary>
        public const uint LightSourcePolarization = 0x00161001;

        ///<summary>(0016,1002) VR=DS VM=1 Emitter Color Temperature</summary>
        public const uint EmitterColorTemperature = 0x00161002;

        ///<summary>(0016,1003) VR=CS VM=1 Contact Method</summary>
        public const uint ContactMethod = 0x00161003;

        ///<summary>(0016,1004) VR=CS VM=1-n Immersion Media</summary>
        public const uint ImmersionMedia = 0x00161004;

        ///<summary>(0016,1005) VR=DS VM=1 Optical Magnification Factor</summary>
        public const uint OpticalMagnificationFactor = 0x00161005;

        ///<summary>(0018,0010) VR=LO VM=1 Contrast/Bolus Agent</summary>
        public const uint ContrastBolusAgent = 0x00180010;

        ///<summary>(0018,0012) VR=SQ VM=1 Contrast/Bolus Agent Sequence</summary>
        public const uint ContrastBolusAgentSequence = 0x00180012;

        ///<summary>(0018,0013) VR=FL VM=1 Contrast/Bolus T1 Relaxivity</summary>
        public const uint ContrastBolusT1Relaxivity = 0x00180013;

        ///<summary>(0018,0014) VR=SQ VM=1 Contrast/Bolus Administration Route Sequence</summary>
        public const uint ContrastBolusAdministrationRouteSequence = 0x00180014;

        ///<summary>(0018,0015) VR=CS VM=1 Body Part Examined</summary>
        public const uint BodyPartExamined = 0x00180015;

        ///<summary>(0018,0020) VR=CS VM=1-n Scanning Sequence</summary>
        public const uint ScanningSequence = 0x00180020;

        ///<summary>(0018,0021) VR=CS VM=1-n Sequence Variant</summary>
        public const uint SequenceVariant = 0x00180021;

        ///<summary>(0018,0022) VR=CS VM=1-n Scan Options</summary>
        public const uint ScanOptions = 0x00180022;

        ///<summary>(0018,0023) VR=CS VM=1 MR Acquisition Type</summary>
        public const uint MRAcquisitionType = 0x00180023;

        ///<summary>(0018,0024) VR=SH VM=1 Sequence Name</summary>
        public const uint SequenceName = 0x00180024;

        ///<summary>(0018,0025) VR=CS VM=1 Angio Flag</summary>
        public const uint AngioFlag = 0x00180025;

        ///<summary>(0018,0026) VR=SQ VM=1 Intervention Drug Information Sequence</summary>
        public const uint InterventionDrugInformationSequence = 0x00180026;

        ///<summary>(0018,0027) VR=TM VM=1 Intervention Drug Stop Time</summary>
        public const uint InterventionDrugStopTime = 0x00180027;

        ///<summary>(0018,0028) VR=DS VM=1 Intervention Drug Dose</summary>
        public const uint InterventionDrugDose = 0x00180028;

        ///<summary>(0018,0029) VR=SQ VM=1 Intervention Drug Code Sequence</summary>
        public const uint InterventionDrugCodeSequence = 0x00180029;

        ///<summary>(0018,002A) VR=SQ VM=1 Additional Drug Sequence</summary>
        public const uint AdditionalDrugSequence = 0x0018002A;

        ///<summary>(0018,0030) VR=LO VM=1-n Radionuclide (RETIRED)</summary>
        public const uint RadionuclideRETIRED = 0x00180030;

        ///<summary>(0018,0031) VR=LO VM=1 Radiopharmaceutical</summary>
        public const uint Radiopharmaceutical = 0x00180031;

        ///<summary>(0018,0032) VR=DS VM=1 Energy Window Centerline (RETIRED)</summary>
        public const uint EnergyWindowCenterlineRETIRED = 0x00180032;

        ///<summary>(0018,0033) VR=DS VM=1-n Energy Window Total Width (RETIRED)</summary>
        public const uint EnergyWindowTotalWidthRETIRED = 0x00180033;

        ///<summary>(0018,0034) VR=LO VM=1 Intervention Drug Name</summary>
        public const uint InterventionDrugName = 0x00180034;

        ///<summary>(0018,0035) VR=TM VM=1 Intervention Drug Start Time</summary>
        public const uint InterventionDrugStartTime = 0x00180035;

        ///<summary>(0018,0036) VR=SQ VM=1 Intervention Sequence</summary>
        public const uint InterventionSequence = 0x00180036;

        ///<summary>(0018,0037) VR=CS VM=1 Therapy Type (RETIRED)</summary>
        public const uint TherapyTypeRETIRED = 0x00180037;

        ///<summary>(0018,0038) VR=CS VM=1 Intervention Status</summary>
        public const uint InterventionStatus = 0x00180038;

        ///<summary>(0018,0039) VR=CS VM=1 Therapy Description (RETIRED)</summary>
        public const uint TherapyDescriptionRETIRED = 0x00180039;

        ///<summary>(0018,003A) VR=ST VM=1 Intervention Description</summary>
        public const uint InterventionDescription = 0x0018003A;

        ///<summary>(0018,0040) VR=IS VM=1 Cine Rate</summary>
        public const uint CineRate = 0x00180040;

        ///<summary>(0018,0042) VR=CS VM=1 Initial Cine Run State</summary>
        public const uint InitialCineRunState = 0x00180042;

        ///<summary>(0018,0050) VR=DS VM=1 Slice Thickness</summary>
        public const uint SliceThickness = 0x00180050;

        ///<summary>(0018,0060) VR=DS VM=1 KVP</summary>
        public const uint KVP = 0x00180060;

        ///<summary>(0018,0070) VR=IS VM=1 Counts Accumulated</summary>
        public const uint CountsAccumulated = 0x00180070;

        ///<summary>(0018,0071) VR=CS VM=1 Acquisition Termination Condition</summary>
        public const uint AcquisitionTerminationCondition = 0x00180071;

        ///<summary>(0018,0072) VR=DS VM=1 Effective Duration</summary>
        public const uint EffectiveDuration = 0x00180072;

        ///<summary>(0018,0073) VR=CS VM=1 Acquisition Start Condition</summary>
        public const uint AcquisitionStartCondition = 0x00180073;

        ///<summary>(0018,0074) VR=IS VM=1 Acquisition Start Condition Data</summary>
        public const uint AcquisitionStartConditionData = 0x00180074;

        ///<summary>(0018,0075) VR=IS VM=1 Acquisition Termination Condition Data</summary>
        public const uint AcquisitionTerminationConditionData = 0x00180075;

        ///<summary>(0018,0080) VR=DS VM=1 Repetition Time</summary>
        public const uint RepetitionTime = 0x00180080;

        ///<summary>(0018,0081) VR=DS VM=1 Echo Time</summary>
        public const uint EchoTime = 0x00180081;

        ///<summary>(0018,0082) VR=DS VM=1 Inversion Time</summary>
        public const uint InversionTime = 0x00180082;

        ///<summary>(0018,0083) VR=DS VM=1 Number of Averages</summary>
        public const uint NumberOfAverages = 0x00180083;

        ///<summary>(0018,0084) VR=DS VM=1 Imaging Frequency</summary>
        public const uint ImagingFrequency = 0x00180084;

        ///<summary>(0018,0085) VR=SH VM=1 Imaged Nucleus</summary>
        public const uint ImagedNucleus = 0x00180085;

        ///<summary>(0018,0086) VR=IS VM=1-n Echo Number(s)</summary>
        public const uint EchoNumbers = 0x00180086;

        ///<summary>(0018,0087) VR=DS VM=1 Magnetic Field Strength</summary>
        public const uint MagneticFieldStrength = 0x00180087;

        ///<summary>(0018,0088) VR=DS VM=1 Spacing Between Slices</summary>
        public const uint SpacingBetweenSlices = 0x00180088;

        ///<summary>(0018,0089) VR=IS VM=1 Number of Phase Encoding Steps</summary>
        public const uint NumberOfPhaseEncodingSteps = 0x00180089;

        ///<summary>(0018,0090) VR=DS VM=1 Data Collection Diameter</summary>
        public const uint DataCollectionDiameter = 0x00180090;

        ///<summary>(0018,0091) VR=IS VM=1 Echo Train Length</summary>
        public const uint EchoTrainLength = 0x00180091;

        ///<summary>(0018,0093) VR=DS VM=1 Percent Sampling</summary>
        public const uint PercentSampling = 0x00180093;

        ///<summary>(0018,0094) VR=DS VM=1 Percent Phase Field of View</summary>
        public const uint PercentPhaseFieldOfView = 0x00180094;

        ///<summary>(0018,0095) VR=DS VM=1 Pixel Bandwidth</summary>
        public const uint PixelBandwidth = 0x00180095;

        ///<summary>(0018,1000) VR=LO VM=1 Device Serial Number</summary>
        public const uint DeviceSerialNumber = 0x00181000;

        ///<summary>(0018,1002) VR=UI VM=1 Device Uid</summary>
        public const uint DeviceUid = 0x00181002;

        ///<summary>(0018,1003) VR=LO VM=1 Device Id</summary>
        public const uint DeviceId = 0x00181003;

        ///<summary>(0018,1004) VR=LO VM=1 Plate Id</summary>
        public const uint PlateId = 0x00181004;

        ///<summary>(0018,1005) VR=LO VM=1 Generator Id</summary>
        public const uint GeneratorId = 0x00181005;

        ///<summary>(0018,1006) VR=LO VM=1 Grid Id</summary>
        public const uint GridId = 0x00181006;

        ///<summary>(0018,1007) VR=LO VM=1 Cassette Id</summary>
        public const uint CassetteId = 0x00181007;

        ///<summary>(0018,1008) VR=LO VM=1 Gantry Id</summary>
        public const uint GantryId = 0x00181008;

        ///<summary>(0018,1009) VR=UT VM=1 Unique Device Identifier</summary>
        public const uint UniqueDeviceIdentifier = 0x00181009;

        ///<summary>(0018,100A) VR=SQ VM=1 UDI Sequence</summary>
        public const uint UDISequence = 0x0018100A;

        ///<summary>(0018,100B) VR=UI VM=1-n Manufacturer's Device Class Uid</summary>
        public const uint ManufacturerDeviceClassUid = 0x0018100B;

        ///<summary>(0018,1010) VR=LO VM=1 Secondary Capture Device Id</summary>
        public const uint SecondaryCaptureDeviceId = 0x00181010;

        ///<summary>(0018,1011) VR=LO VM=1 Hardcopy Creation Device Id (RETIRED)</summary>
        public const uint HardcopyCreationDeviceIdRETIRED = 0x00181011;

        ///<summary>(0018,1012) VR=DA VM=1 Date of Secondary Capture</summary>
        public const uint DateOfSecondaryCapture = 0x00181012;

        ///<summary>(0018,1014) VR=TM VM=1 Time of Secondary Capture</summary>
        public const uint TimeOfSecondaryCapture = 0x00181014;

        ///<summary>(0018,1016) VR=LO VM=1 Secondary Capture Device Manufacturer</summary>
        public const uint SecondaryCaptureDeviceManufacturer = 0x00181016;

        ///<summary>(0018,1017) VR=LO VM=1 Hardcopy Device Manufacturer (RETIRED)</summary>
        public const uint HardcopyDeviceManufacturerRETIRED = 0x00181017;

        ///<summary>(0018,1018) VR=LO VM=1 Secondary Capture Device Manufacturer's Model Name</summary>
        public const uint SecondaryCaptureDeviceManufacturerModelName = 0x00181018;

        ///<summary>(0018,1019) VR=LO VM=1-n Secondary Capture Device Software Versions</summary>
        public const uint SecondaryCaptureDeviceSoftwareVersions = 0x00181019;

        ///<summary>(0018,101A) VR=LO VM=1-n Hardcopy Device Software Version (RETIRED)</summary>
        public const uint HardcopyDeviceSoftwareVersionRETIRED = 0x0018101A;

        ///<summary>(0018,101B) VR=LO VM=1 Hardcopy Device Manufacturer's Model Name (RETIRED)</summary>
        public const uint HardcopyDeviceManufacturerModelNameRETIRED = 0x0018101B;

        ///<summary>(0018,1020) VR=LO VM=1-n Software Versions</summary>
        public const uint SoftwareVersions = 0x00181020;

        ///<summary>(0018,1022) VR=SH VM=1 Video Image Format Acquired</summary>
        public const uint VideoImageFormatAcquired = 0x00181022;

        ///<summary>(0018,1023) VR=LO VM=1 Digital Image Format Acquired</summary>
        public const uint DigitalImageFormatAcquired = 0x00181023;

        ///<summary>(0018,1030) VR=LO VM=1 Protocol Name</summary>
        public const uint ProtocolName = 0x00181030;

        ///<summary>(0018,1040) VR=LO VM=1 Contrast/Bolus Route</summary>
        public const uint ContrastBolusRoute = 0x00181040;

        ///<summary>(0018,1041) VR=DS VM=1 Contrast/Bolus Volume</summary>
        public const uint ContrastBolusVolume = 0x00181041;

        ///<summary>(0018,1042) VR=TM VM=1 Contrast/Bolus Start Time</summary>
        public const uint ContrastBolusStartTime = 0x00181042;

        ///<summary>(0018,1043) VR=TM VM=1 Contrast/Bolus Stop Time</summary>
        public const uint ContrastBolusStopTime = 0x00181043;

        ///<summary>(0018,1044) VR=DS VM=1 Contrast/Bolus Total Dose</summary>
        public const uint ContrastBolusTotalDose = 0x00181044;

        ///<summary>(0018,1045) VR=IS VM=1 Syringe Counts</summary>
        public const uint SyringeCounts = 0x00181045;

        ///<summary>(0018,1046) VR=DS VM=1-n Contrast Flow Rate</summary>
        public const uint ContrastFlowRate = 0x00181046;

        ///<summary>(0018,1047) VR=DS VM=1-n Contrast Flow Duration</summary>
        public const uint ContrastFlowDuration = 0x00181047;

        ///<summary>(0018,1048) VR=CS VM=1 Contrast/Bolus Ingredient</summary>
        public const uint ContrastBolusIngredient = 0x00181048;

        ///<summary>(0018,1049) VR=DS VM=1 Contrast/Bolus Ingredient Concentration</summary>
        public const uint ContrastBolusIngredientConcentration = 0x00181049;

        ///<summary>(0018,1050) VR=DS VM=1 Spatial Resolution</summary>
        public const uint SpatialResolution = 0x00181050;

        ///<summary>(0018,1060) VR=DS VM=1 Trigger Time</summary>
        public const uint TriggerTime = 0x00181060;

        ///<summary>(0018,1061) VR=LO VM=1 Trigger Source or Type</summary>
        public const uint TriggerSourceOrType = 0x00181061;

        ///<summary>(0018,1062) VR=IS VM=1 Nominal Interval</summary>
        public const uint NominalInterval = 0x00181062;

        ///<summary>(0018,1063) VR=DS VM=1 Frame Time</summary>
        public const uint FrameTime = 0x00181063;

        ///<summary>(0018,1064) VR=LO VM=1 Cardiac Framing Type</summary>
        public const uint CardiacFramingType = 0x00181064;

        ///<summary>(0018,1065) VR=DS VM=1-n Frame Time Vector</summary>
        public const uint FrameTimeVector = 0x00181065;

        ///<summary>(0018,1066) VR=DS VM=1 Frame Delay</summary>
        public const uint FrameDelay = 0x00181066;

        ///<summary>(0018,1067) VR=DS VM=1 Image Trigger Delay</summary>
        public const uint ImageTriggerDelay = 0x00181067;

        ///<summary>(0018,1068) VR=DS VM=1 Multiplex Group Time Offset</summary>
        public const uint MultiplexGroupTimeOffset = 0x00181068;

        ///<summary>(0018,1069) VR=DS VM=1 Trigger Time Offset</summary>
        public const uint TriggerTimeOffset = 0x00181069;

        ///<summary>(0018,106A) VR=CS VM=1 Synchronization Trigger</summary>
        public const uint SynchronizationTrigger = 0x0018106A;

        ///<summary>(0018,106C) VR=US VM=2 Synchronization Channel</summary>
        public const uint SynchronizationChannel = 0x0018106C;

        ///<summary>(0018,106E) VR=UL VM=1 Trigger Sample Position</summary>
        public const uint TriggerSamplePosition = 0x0018106E;

        ///<summary>(0018,1070) VR=LO VM=1 Radiopharmaceutical Route</summary>
        public const uint RadiopharmaceuticalRoute = 0x00181070;

        ///<summary>(0018,1071) VR=DS VM=1 Radiopharmaceutical Volume</summary>
        public const uint RadiopharmaceuticalVolume = 0x00181071;

        ///<summary>(0018,1072) VR=TM VM=1 Radiopharmaceutical Start Time</summary>
        public const uint RadiopharmaceuticalStartTime = 0x00181072;

        ///<summary>(0018,1073) VR=TM VM=1 Radiopharmaceutical Stop Time</summary>
        public const uint RadiopharmaceuticalStopTime = 0x00181073;

        ///<summary>(0018,1074) VR=DS VM=1 Radionuclide Total Dose</summary>
        public const uint RadionuclideTotalDose = 0x00181074;

        ///<summary>(0018,1075) VR=DS VM=1 Radionuclide Half Life</summary>
        public const uint RadionuclideHalfLife = 0x00181075;

        ///<summary>(0018,1076) VR=DS VM=1 Radionuclide Positron Fraction</summary>
        public const uint RadionuclidePositronFraction = 0x00181076;

        ///<summary>(0018,1077) VR=DS VM=1 Radiopharmaceutical Specific Activity</summary>
        public const uint RadiopharmaceuticalSpecificActivity = 0x00181077;

        ///<summary>(0018,1078) VR=DT VM=1 Radiopharmaceutical Start DateTime</summary>
        public const uint RadiopharmaceuticalStartDateTime = 0x00181078;

        ///<summary>(0018,1079) VR=DT VM=1 Radiopharmaceutical Stop DateTime</summary>
        public const uint RadiopharmaceuticalStopDateTime = 0x00181079;

        ///<summary>(0018,1080) VR=CS VM=1 Beat Rejection Flag</summary>
        public const uint BeatRejectionFlag = 0x00181080;

        ///<summary>(0018,1081) VR=IS VM=1 Low R-R Value</summary>
        public const uint LowRRValue = 0x00181081;

        ///<summary>(0018,1082) VR=IS VM=1 High R-R Value</summary>
        public const uint HighRRValue = 0x00181082;

        ///<summary>(0018,1083) VR=IS VM=1 Intervals Acquired</summary>
        public const uint IntervalsAcquired = 0x00181083;

        ///<summary>(0018,1084) VR=IS VM=1 Intervals Rejected</summary>
        public const uint IntervalsRejected = 0x00181084;

        ///<summary>(0018,1085) VR=LO VM=1 PVC Rejection</summary>
        public const uint PVCRejection = 0x00181085;

        ///<summary>(0018,1086) VR=IS VM=1 Skip Beats</summary>
        public const uint SkipBeats = 0x00181086;

        ///<summary>(0018,1088) VR=IS VM=1 Heart Rate</summary>
        public const uint HeartRate = 0x00181088;

        ///<summary>(0018,1090) VR=IS VM=1 Cardiac Number of Images</summary>
        public const uint CardiacNumberOfImages = 0x00181090;

        ///<summary>(0018,1094) VR=IS VM=1 Trigger Window</summary>
        public const uint TriggerWindow = 0x00181094;

        ///<summary>(0018,1100) VR=DS VM=1 Reconstruction Diameter</summary>
        public const uint ReconstructionDiameter = 0x00181100;

        ///<summary>(0018,1110) VR=DS VM=1 Distance Source to Detector</summary>
        public const uint DistanceSourceToDetector = 0x00181110;

        ///<summary>(0018,1111) VR=DS VM=1 Distance Source to Patient</summary>
        public const uint DistanceSourceToPatient = 0x00181111;

        ///<summary>(0018,1114) VR=DS VM=1 Estimated Radiographic Magnification Factor</summary>
        public const uint EstimatedRadiographicMagnificationFactor = 0x00181114;

        ///<summary>(0018,1120) VR=DS VM=1 Gantry/Detector Tilt</summary>
        public const uint GantryDetectorTilt = 0x00181120;

        ///<summary>(0018,1121) VR=DS VM=1 Gantry/Detector Slew</summary>
        public const uint GantryDetectorSlew = 0x00181121;

        ///<summary>(0018,1130) VR=DS VM=1 Table Height</summary>
        public const uint TableHeight = 0x00181130;

        ///<summary>(0018,1131) VR=DS VM=1 Table Traverse</summary>
        public const uint TableTraverse = 0x00181131;

        ///<summary>(0018,1134) VR=CS VM=1 Table Motion</summary>
        public const uint TableMotion = 0x00181134;

        ///<summary>(0018,1135) VR=DS VM=1-n Table Vertical Increment</summary>
        public const uint TableVerticalIncrement = 0x00181135;

        ///<summary>(0018,1136) VR=DS VM=1-n Table Lateral Increment</summary>
        public const uint TableLateralIncrement = 0x00181136;

        ///<summary>(0018,1137) VR=DS VM=1-n Table Longitudinal Increment</summary>
        public const uint TableLongitudinalIncrement = 0x00181137;

        ///<summary>(0018,1138) VR=DS VM=1 Table Angle</summary>
        public const uint TableAngle = 0x00181138;

        ///<summary>(0018,113A) VR=CS VM=1 Table Type</summary>
        public const uint TableType = 0x0018113A;

        ///<summary>(0018,1140) VR=CS VM=1 Rotation Direction</summary>
        public const uint RotationDirection = 0x00181140;

        ///<summary>(0018,1141) VR=DS VM=1 Angular Position (RETIRED)</summary>
        public const uint AngularPositionRETIRED = 0x00181141;

        ///<summary>(0018,1142) VR=DS VM=1-n Radial Position</summary>
        public const uint RadialPosition = 0x00181142;

        ///<summary>(0018,1143) VR=DS VM=1 Scan Arc</summary>
        public const uint ScanArc = 0x00181143;

        ///<summary>(0018,1144) VR=DS VM=1 Angular Step</summary>
        public const uint AngularStep = 0x00181144;

        ///<summary>(0018,1145) VR=DS VM=1 Center of Rotation Offset</summary>
        public const uint CenterOfRotationOffset = 0x00181145;

        ///<summary>(0018,1146) VR=DS VM=1-n Rotation Offset (RETIRED)</summary>
        public const uint RotationOffsetRETIRED = 0x00181146;

        ///<summary>(0018,1147) VR=CS VM=1 Field of View Shape</summary>
        public const uint FieldOfViewShape = 0x00181147;

        ///<summary>(0018,1149) VR=IS VM=1-2 Field of View Dimension(s)</summary>
        public const uint FieldOfViewDimensions = 0x00181149;

        ///<summary>(0018,1150) VR=IS VM=1 Exposure Time</summary>
        public const uint ExposureTime = 0x00181150;

        ///<summary>(0018,1151) VR=IS VM=1 X-Ray Tube Current</summary>
        public const uint XRayTubeCurrent = 0x00181151;

        ///<summary>(0018,1152) VR=IS VM=1 Exposure</summary>
        public const uint Exposure = 0x00181152;

        ///<summary>(0018,1153) VR=IS VM=1 Exposure in µAs</summary>
        public const uint ExposureInuAs = 0x00181153;

        ///<summary>(0018,1154) VR=DS VM=1 Average Pulse Width</summary>
        public const uint AveragePulseWidth = 0x00181154;

        ///<summary>(0018,1155) VR=CS VM=1 Radiation Setting</summary>
        public const uint RadiationSetting = 0x00181155;

        ///<summary>(0018,1156) VR=CS VM=1 Rectification Type</summary>
        public const uint RectificationType = 0x00181156;

        ///<summary>(0018,115A) VR=CS VM=1 Radiation Mode</summary>
        public const uint RadiationMode = 0x0018115A;

        ///<summary>(0018,115E) VR=DS VM=1 Image and Fluoroscopy Area Dose Product</summary>
        public const uint ImageAndFluoroscopyAreaDoseProduct = 0x0018115E;

        ///<summary>(0018,1160) VR=SH VM=1 Filter Type</summary>
        public const uint FilterType = 0x00181160;

        ///<summary>(0018,1161) VR=LO VM=1-n Type of Filters</summary>
        public const uint TypeOfFilters = 0x00181161;

        ///<summary>(0018,1162) VR=DS VM=1 Intensifier Size</summary>
        public const uint IntensifierSize = 0x00181162;

        ///<summary>(0018,1164) VR=DS VM=2 Imager Pixel Spacing</summary>
        public const uint ImagerPixelSpacing = 0x00181164;

        ///<summary>(0018,1166) VR=CS VM=1-n Grid</summary>
        public const uint Grid = 0x00181166;

        ///<summary>(0018,1170) VR=IS VM=1 Generator Power</summary>
        public const uint GeneratorPower = 0x00181170;

        ///<summary>(0018,1180) VR=SH VM=1 Collimator/grid Name</summary>
        public const uint CollimatorGridName = 0x00181180;

        ///<summary>(0018,1181) VR=CS VM=1 Collimator Type</summary>
        public const uint CollimatorType = 0x00181181;

        ///<summary>(0018,1182) VR=IS VM=1-2 Focal Distance</summary>
        public const uint FocalDistance = 0x00181182;

        ///<summary>(0018,1183) VR=DS VM=1-2 X Focus Center</summary>
        public const uint XFocusCenter = 0x00181183;

        ///<summary>(0018,1184) VR=DS VM=1-2 Y Focus Center</summary>
        public const uint YFocusCenter = 0x00181184;

        ///<summary>(0018,1190) VR=DS VM=1-n Focal Spot(s)</summary>
        public const uint FocalSpots = 0x00181190;

        ///<summary>(0018,1191) VR=CS VM=1 Anode Target Material</summary>
        public const uint AnodeTargetMaterial = 0x00181191;

        ///<summary>(0018,11A0) VR=DS VM=1 Body Part Thickness</summary>
        public const uint BodyPartThickness = 0x001811A0;

        ///<summary>(0018,11A2) VR=DS VM=1 Compression Force</summary>
        public const uint CompressionForce = 0x001811A2;

        ///<summary>(0018,11A3) VR=DS VM=1 Compression Pressure</summary>
        public const uint CompressionPressure = 0x001811A3;

        ///<summary>(0018,11A4) VR=LO VM=1 Paddle Description</summary>
        public const uint PaddleDescription = 0x001811A4;

        ///<summary>(0018,11A5) VR=DS VM=1 Compression Contact Area</summary>
        public const uint CompressionContactArea = 0x001811A5;

        ///<summary>(0018,11B0) VR=LO VM=1 Acquisition Mode</summary>
        public const uint AcquisitionMode = 0x001811B0;

        ///<summary>(0018,11B1) VR=LO VM=1 Dose Mode Name</summary>
        public const uint DoseModeName = 0x001811B1;

        ///<summary>(0018,11B2) VR=CS VM=1 Acquired Subtraction Mask Flag</summary>
        public const uint AcquiredSubtractionMaskFlag = 0x001811B2;

        ///<summary>(0018,11B3) VR=CS VM=1 Fluoroscopy Persistence Flag</summary>
        public const uint FluoroscopyPersistenceFlag = 0x001811B3;

        ///<summary>(0018,11B4) VR=CS VM=1 Fluoroscopy Last Image Hold Persistence Flag</summary>
        public const uint FluoroscopyLastImageHoldPersistenceFlag = 0x001811B4;

        ///<summary>(0018,11B5) VR=IS VM=1 Upper Limit Number Of Persistent Fluoroscopy Frames</summary>
        public const uint UpperLimitNumberOfPersistentFluoroscopyFrames = 0x001811B5;

        ///<summary>(0018,11B6) VR=CS VM=1 Contrast/Bolus Auto Injection Trigger Flag</summary>
        public const uint ContrastBolusAutoInjectionTriggerFlag = 0x001811B6;

        ///<summary>(0018,11B7) VR=FD VM=1 Contrast/Bolus Injection Delay</summary>
        public const uint ContrastBolusInjectionDelay = 0x001811B7;

        ///<summary>(0018,11B8) VR=SQ VM=1 XA Acquisition Phase Details Sequence</summary>
        public const uint XAAcquisitionPhaseDetailsSequence = 0x001811B8;

        ///<summary>(0018,11B9) VR=FD VM=1 XA Acquisition Frame Rate</summary>
        public const uint XAAcquisitionFrameRate = 0x001811B9;

        ///<summary>(0018,11BA) VR=SQ VM=1 XA Plane Details Sequence</summary>
        public const uint XAPlaneDetailsSequence = 0x001811BA;

        ///<summary>(0018,11BB) VR=LO VM=1 Acquisition Field of View Label</summary>
        public const uint AcquisitionFieldOfViewLabel = 0x001811BB;

        ///<summary>(0018,11BC) VR=SQ VM=1 X-Ray Filter Details Sequence</summary>
        public const uint XRayFilterDetailsSequence = 0x001811BC;

        ///<summary>(0018,11BD) VR=FD VM=1 XA Acquisition Duration</summary>
        public const uint XAAcquisitionDuration = 0x001811BD;

        ///<summary>(0018,11BE) VR=CS VM=1 Reconstruction Pipeline Type</summary>
        public const uint ReconstructionPipelineType = 0x001811BE;

        ///<summary>(0018,11BF) VR=SQ VM=1 Image Filter Details Sequence</summary>
        public const uint ImageFilterDetailsSequence = 0x001811BF;

        ///<summary>(0018,11C0) VR=CS VM=1 Applied Mask Subtraction Flag</summary>
        public const uint AppliedMaskSubtractionFlag = 0x001811C0;

        ///<summary>(0018,11C1) VR=SQ VM=1 Requested Series Description Code Sequence</summary>
        public const uint RequestedSeriesDescriptionCodeSequence = 0x001811C1;

        ///<summary>(0018,1200) VR=DA VM=1-n Date of Last Calibration</summary>
        public const uint DateOfLastCalibration = 0x00181200;

        ///<summary>(0018,1201) VR=TM VM=1-n Time of Last Calibration</summary>
        public const uint TimeOfLastCalibration = 0x00181201;

        ///<summary>(0018,1202) VR=DT VM=1 DateTime of Last Calibration</summary>
        public const uint DateTimeOfLastCalibration = 0x00181202;

        ///<summary>(0018,1210) VR=SH VM=1-n Convolution Kernel</summary>
        public const uint ConvolutionKernel = 0x00181210;

        ///<summary>(0018,1240) VR=IS VM=1-n Upper/Lower Pixel Values (RETIRED)</summary>
        public const uint UpperLowerPixelValuesRETIRED = 0x00181240;

        ///<summary>(0018,1242) VR=IS VM=1 Actual Frame Duration</summary>
        public const uint ActualFrameDuration = 0x00181242;

        ///<summary>(0018,1243) VR=IS VM=1 Count Rate</summary>
        public const uint CountRate = 0x00181243;

        ///<summary>(0018,1244) VR=US VM=1 Preferred Playback Sequencing</summary>
        public const uint PreferredPlaybackSequencing = 0x00181244;

        ///<summary>(0018,1250) VR=SH VM=1 Receive Coil Name</summary>
        public const uint ReceiveCoilName = 0x00181250;

        ///<summary>(0018,1251) VR=SH VM=1 Transmit Coil Name</summary>
        public const uint TransmitCoilName = 0x00181251;

        ///<summary>(0018,1260) VR=SH VM=1 Plate Type</summary>
        public const uint PlateType = 0x00181260;

        ///<summary>(0018,1261) VR=LO VM=1 Phosphor Type</summary>
        public const uint PhosphorType = 0x00181261;

        ///<summary>(0018,1271) VR=FD VM=1 Water Equivalent Diameter</summary>
        public const uint WaterEquivalentDiameter = 0x00181271;

        ///<summary>(0018,1272) VR=SQ VM=1 Water Equivalent Diameter Calculation Method Code Sequence</summary>
        public const uint WaterEquivalentDiameterCalculationMethodCodeSequence = 0x00181272;

        ///<summary>(0018,1300) VR=DS VM=1 Scan Velocity</summary>
        public const uint ScanVelocity = 0x00181300;

        ///<summary>(0018,1301) VR=CS VM=1-n Whole Body Technique</summary>
        public const uint WholeBodyTechnique = 0x00181301;

        ///<summary>(0018,1302) VR=IS VM=1 Scan Length</summary>
        public const uint ScanLength = 0x00181302;

        ///<summary>(0018,1310) VR=US VM=4 Acquisition Matrix</summary>
        public const uint AcquisitionMatrix = 0x00181310;

        ///<summary>(0018,1312) VR=CS VM=1 In-plane Phase Encoding Direction</summary>
        public const uint InPlanePhaseEncodingDirection = 0x00181312;

        ///<summary>(0018,1314) VR=DS VM=1 Flip Angle</summary>
        public const uint FlipAngle = 0x00181314;

        ///<summary>(0018,1315) VR=CS VM=1 Variable Flip Angle Flag</summary>
        public const uint VariableFlipAngleFlag = 0x00181315;

        ///<summary>(0018,1316) VR=DS VM=1 SAR</summary>
        public const uint SAR = 0x00181316;

        ///<summary>(0018,1318) VR=DS VM=1 dB/dt</summary>
        public const uint dBdt = 0x00181318;

        ///<summary>(0018,1320) VR=FL VM=1 B1rms</summary>
        public const uint B1rms = 0x00181320;

        ///<summary>(0018,1400) VR=LO VM=1 Acquisition Device Processing Description</summary>
        public const uint AcquisitionDeviceProcessingDescription = 0x00181400;

        ///<summary>(0018,1401) VR=LO VM=1 Acquisition Device Processing Code</summary>
        public const uint AcquisitionDeviceProcessingCode = 0x00181401;

        ///<summary>(0018,1402) VR=CS VM=1 Cassette Orientation</summary>
        public const uint CassetteOrientation = 0x00181402;

        ///<summary>(0018,1403) VR=CS VM=1 Cassette Size</summary>
        public const uint CassetteSize = 0x00181403;

        ///<summary>(0018,1404) VR=US VM=1 Exposures on Plate</summary>
        public const uint ExposuresOnPlate = 0x00181404;

        ///<summary>(0018,1405) VR=IS VM=1 Relative X-Ray Exposure</summary>
        public const uint RelativeXRayExposure = 0x00181405;

        ///<summary>(0018,1411) VR=DS VM=1 Exposure Index</summary>
        public const uint ExposureIndex = 0x00181411;

        ///<summary>(0018,1412) VR=DS VM=1 Target Exposure Index</summary>
        public const uint TargetExposureIndex = 0x00181412;

        ///<summary>(0018,1413) VR=DS VM=1 Deviation Index</summary>
        public const uint DeviationIndex = 0x00181413;

        ///<summary>(0018,1450) VR=DS VM=1 Column Angulation</summary>
        public const uint ColumnAngulation = 0x00181450;

        ///<summary>(0018,1460) VR=DS VM=1 Tomo Layer Height</summary>
        public const uint TomoLayerHeight = 0x00181460;

        ///<summary>(0018,1470) VR=DS VM=1 Tomo Angle</summary>
        public const uint TomoAngle = 0x00181470;

        ///<summary>(0018,1480) VR=DS VM=1 Tomo Time</summary>
        public const uint TomoTime = 0x00181480;

        ///<summary>(0018,1490) VR=CS VM=1 Tomo Type</summary>
        public const uint TomoType = 0x00181490;

        ///<summary>(0018,1491) VR=CS VM=1 Tomo Class</summary>
        public const uint TomoClass = 0x00181491;

        ///<summary>(0018,1495) VR=IS VM=1 Number of Tomosynthesis Source Images</summary>
        public const uint NumberOfTomosynthesisSourceImages = 0x00181495;

        ///<summary>(0018,1500) VR=CS VM=1 Positioner Motion</summary>
        public const uint PositionerMotion = 0x00181500;

        ///<summary>(0018,1508) VR=CS VM=1 Positioner Type</summary>
        public const uint PositionerType = 0x00181508;

        ///<summary>(0018,1510) VR=DS VM=1 Positioner Primary Angle</summary>
        public const uint PositionerPrimaryAngle = 0x00181510;

        ///<summary>(0018,1511) VR=DS VM=1 Positioner Secondary Angle</summary>
        public const uint PositionerSecondaryAngle = 0x00181511;

        ///<summary>(0018,1520) VR=DS VM=1-n Positioner Primary Angle Increment</summary>
        public const uint PositionerPrimaryAngleIncrement = 0x00181520;

        ///<summary>(0018,1521) VR=DS VM=1-n Positioner Secondary Angle Increment</summary>
        public const uint PositionerSecondaryAngleIncrement = 0x00181521;

        ///<summary>(0018,1530) VR=DS VM=1 Detector Primary Angle</summary>
        public const uint DetectorPrimaryAngle = 0x00181530;

        ///<summary>(0018,1531) VR=DS VM=1 Detector Secondary Angle</summary>
        public const uint DetectorSecondaryAngle = 0x00181531;

        ///<summary>(0018,1600) VR=CS VM=1-3 Shutter Shape</summary>
        public const uint ShutterShape = 0x00181600;

        ///<summary>(0018,1602) VR=IS VM=1 Shutter Left Vertical Edge</summary>
        public const uint ShutterLeftVerticalEdge = 0x00181602;

        ///<summary>(0018,1604) VR=IS VM=1 Shutter Right Vertical Edge</summary>
        public const uint ShutterRightVerticalEdge = 0x00181604;

        ///<summary>(0018,1606) VR=IS VM=1 Shutter Upper Horizontal Edge</summary>
        public const uint ShutterUpperHorizontalEdge = 0x00181606;

        ///<summary>(0018,1608) VR=IS VM=1 Shutter Lower Horizontal Edge</summary>
        public const uint ShutterLowerHorizontalEdge = 0x00181608;

        ///<summary>(0018,1610) VR=IS VM=2 Center of Circular Shutter</summary>
        public const uint CenterOfCircularShutter = 0x00181610;

        ///<summary>(0018,1612) VR=IS VM=1 Radius of Circular Shutter</summary>
        public const uint RadiusOfCircularShutter = 0x00181612;

        ///<summary>(0018,1620) VR=IS VM=2-2n Vertices of the Polygonal Shutter</summary>
        public const uint VerticesOfThePolygonalShutter = 0x00181620;

        ///<summary>(0018,1622) VR=US VM=1 Shutter Presentation Value</summary>
        public const uint ShutterPresentationValue = 0x00181622;

        ///<summary>(0018,1623) VR=US VM=1 Shutter Overlay Group</summary>
        public const uint ShutterOverlayGroup = 0x00181623;

        ///<summary>(0018,1624) VR=US VM=3 Shutter Presentation Color CIELab Value</summary>
        public const uint ShutterPresentationColorCIELabValue = 0x00181624;

        ///<summary>(0018,1630) VR=CS VM=1 Outline Shape Type</summary>
        public const uint OutlineShapeType = 0x00181630;

        ///<summary>(0018,1631) VR=FD VM=1 Outline Left Vertical Edge</summary>
        public const uint OutlineLeftVerticalEdge = 0x00181631;

        ///<summary>(0018,1632) VR=FD VM=1 Outline Right Vertical Edge</summary>
        public const uint OutlineRightVerticalEdge = 0x00181632;

        ///<summary>(0018,1633) VR=FD VM=1 Outline Upper Horizontal Edge</summary>
        public const uint OutlineUpperHorizontalEdge = 0x00181633;

        ///<summary>(0018,1634) VR=FD VM=1 Outline Lower Horizontal Edge</summary>
        public const uint OutlineLowerHorizontalEdge = 0x00181634;

        ///<summary>(0018,1635) VR=FD VM=2 Center of Circular Outline</summary>
        public const uint CenterOfCircularOutline = 0x00181635;

        ///<summary>(0018,1636) VR=FD VM=1 Diameter of Circular Outline</summary>
        public const uint DiameterOfCircularOutline = 0x00181636;

        ///<summary>(0018,1637) VR=UL VM=1 Number of Polygonal Vertices</summary>
        public const uint NumberOfPolygonalVertices = 0x00181637;

        ///<summary>(0018,1638) VR=OF VM=1 Vertices of the Polygonal Outline</summary>
        public const uint VerticesOfThePolygonalOutline = 0x00181638;

        ///<summary>(0018,1700) VR=CS VM=1-3 Collimator Shape</summary>
        public const uint CollimatorShape = 0x00181700;

        ///<summary>(0018,1702) VR=IS VM=1 Collimator Left Vertical Edge</summary>
        public const uint CollimatorLeftVerticalEdge = 0x00181702;

        ///<summary>(0018,1704) VR=IS VM=1 Collimator Right Vertical Edge</summary>
        public const uint CollimatorRightVerticalEdge = 0x00181704;

        ///<summary>(0018,1706) VR=IS VM=1 Collimator Upper Horizontal Edge</summary>
        public const uint CollimatorUpperHorizontalEdge = 0x00181706;

        ///<summary>(0018,1708) VR=IS VM=1 Collimator Lower Horizontal Edge</summary>
        public const uint CollimatorLowerHorizontalEdge = 0x00181708;

        ///<summary>(0018,1710) VR=IS VM=2 Center of Circular Collimator</summary>
        public const uint CenterOfCircularCollimator = 0x00181710;

        ///<summary>(0018,1712) VR=IS VM=1 Radius of Circular Collimator</summary>
        public const uint RadiusOfCircularCollimator = 0x00181712;

        ///<summary>(0018,1720) VR=IS VM=2-2n Vertices of the Polygonal Collimator</summary>
        public const uint VerticesOfThePolygonalCollimator = 0x00181720;

        ///<summary>(0018,1800) VR=CS VM=1 Acquisition Time Synchronized</summary>
        public const uint AcquisitionTimeSynchronized = 0x00181800;

        ///<summary>(0018,1801) VR=SH VM=1 Time Source</summary>
        public const uint TimeSource = 0x00181801;

        ///<summary>(0018,1802) VR=CS VM=1 Time Distribution Protocol</summary>
        public const uint TimeDistributionProtocol = 0x00181802;

        ///<summary>(0018,1803) VR=LO VM=1 NTP Source Address</summary>
        public const uint NTPSourceAddress = 0x00181803;

        ///<summary>(0018,2001) VR=IS VM=1-n Page Number Vector</summary>
        public const uint PageNumberVector = 0x00182001;

        ///<summary>(0018,2002) VR=SH VM=1-n Frame Label Vector</summary>
        public const uint FrameLabelVector = 0x00182002;

        ///<summary>(0018,2003) VR=DS VM=1-n Frame Primary Angle Vector</summary>
        public const uint FramePrimaryAngleVector = 0x00182003;

        ///<summary>(0018,2004) VR=DS VM=1-n Frame Secondary Angle Vector</summary>
        public const uint FrameSecondaryAngleVector = 0x00182004;

        ///<summary>(0018,2005) VR=DS VM=1-n Slice Location Vector</summary>
        public const uint SliceLocationVector = 0x00182005;

        ///<summary>(0018,2006) VR=SH VM=1-n Display Window Label Vector</summary>
        public const uint DisplayWindowLabelVector = 0x00182006;

        ///<summary>(0018,2010) VR=DS VM=2 Nominal Scanned Pixel Spacing</summary>
        public const uint NominalScannedPixelSpacing = 0x00182010;

        ///<summary>(0018,2020) VR=CS VM=1 Digitizing Device Transport Direction</summary>
        public const uint DigitizingDeviceTransportDirection = 0x00182020;

        ///<summary>(0018,2030) VR=DS VM=1 Rotation of Scanned Film</summary>
        public const uint RotationOfScannedFilm = 0x00182030;

        ///<summary>(0018,2041) VR=SQ VM=1 Biopsy Target Sequence</summary>
        public const uint BiopsyTargetSequence = 0x00182041;

        ///<summary>(0018,2042) VR=UI VM=1 Target Uid</summary>
        public const uint TargetUid = 0x00182042;

        ///<summary>(0018,2043) VR=FL VM=2 Localizing Cursor Position</summary>
        public const uint LocalizingCursorPosition = 0x00182043;

        ///<summary>(0018,2044) VR=FL VM=3 Calculated Target Position</summary>
        public const uint CalculatedTargetPosition = 0x00182044;

        ///<summary>(0018,2045) VR=SH VM=1 Target Label</summary>
        public const uint TargetLabel = 0x00182045;

        ///<summary>(0018,2046) VR=FL VM=1 Displayed Z Value</summary>
        public const uint DisplayedZValue = 0x00182046;

        ///<summary>(0018,3100) VR=CS VM=1 IVUS Acquisition</summary>
        public const uint IVUSAcquisition = 0x00183100;

        ///<summary>(0018,3101) VR=DS VM=1 IVUS Pullback Rate</summary>
        public const uint IVUSPullbackRate = 0x00183101;

        ///<summary>(0018,3102) VR=DS VM=1 IVUS Gated Rate</summary>
        public const uint IVUSGatedRate = 0x00183102;

        ///<summary>(0018,3103) VR=IS VM=1 IVUS Pullback Start Frame Number</summary>
        public const uint IVUSPullbackStartFrameNumber = 0x00183103;

        ///<summary>(0018,3104) VR=IS VM=1 IVUS Pullback Stop Frame Number</summary>
        public const uint IVUSPullbackStopFrameNumber = 0x00183104;

        ///<summary>(0018,3105) VR=IS VM=1-n Lesion Number</summary>
        public const uint LesionNumber = 0x00183105;

        ///<summary>(0018,4000) VR=LT VM=1 Acquisition Comments (RETIRED)</summary>
        public const uint AcquisitionCommentsRETIRED = 0x00184000;

        ///<summary>(0018,5000) VR=SH VM=1-n Output Power</summary>
        public const uint OutputPower = 0x00185000;

        ///<summary>(0018,5010) VR=LO VM=1-n Transducer Data</summary>
        public const uint TransducerData = 0x00185010;

        ///<summary>(0018,5011) VR=SQ VM=1 Transducer Identification Sequence</summary>
        public const uint TransducerIdentificationSequence = 0x00185011;

        ///<summary>(0018,5012) VR=DS VM=1 Focus Depth</summary>
        public const uint FocusDepth = 0x00185012;

        ///<summary>(0018,5020) VR=LO VM=1 Processing Function</summary>
        public const uint ProcessingFunction = 0x00185020;

        ///<summary>(0018,5021) VR=LO VM=1 Postprocessing Function (RETIRED)</summary>
        public const uint PostprocessingFunctionRETIRED = 0x00185021;

        ///<summary>(0018,5022) VR=DS VM=1 Mechanical Index</summary>
        public const uint MechanicalIndex = 0x00185022;

        ///<summary>(0018,5024) VR=DS VM=1 Bone Thermal Index</summary>
        public const uint BoneThermalIndex = 0x00185024;

        ///<summary>(0018,5026) VR=DS VM=1 Cranial Thermal Index</summary>
        public const uint CranialThermalIndex = 0x00185026;

        ///<summary>(0018,5027) VR=DS VM=1 Soft Tissue Thermal Index</summary>
        public const uint SoftTissueThermalIndex = 0x00185027;

        ///<summary>(0018,5028) VR=DS VM=1 Soft Tissue-focus Thermal Index</summary>
        public const uint SoftTissueFocusThermalIndex = 0x00185028;

        ///<summary>(0018,5029) VR=DS VM=1 Soft Tissue-surface Thermal Index</summary>
        public const uint SoftTissueSurfaceThermalIndex = 0x00185029;

        ///<summary>(0018,5030) VR=DS VM=1 Dynamic Range (RETIRED)</summary>
        public const uint DynamicRangeRETIRED = 0x00185030;

        ///<summary>(0018,5040) VR=DS VM=1 Total Gain (RETIRED)</summary>
        public const uint TotalGainRETIRED = 0x00185040;

        ///<summary>(0018,5050) VR=IS VM=1 Depth of Scan Field</summary>
        public const uint DepthOfScanField = 0x00185050;

        ///<summary>(0018,5100) VR=CS VM=1 Patient Position</summary>
        public const uint PatientPosition = 0x00185100;

        ///<summary>(0018,5101) VR=CS VM=1 View Position</summary>
        public const uint ViewPosition = 0x00185101;

        ///<summary>(0018,5104) VR=SQ VM=1 Projection Eponymous Name Code Sequence</summary>
        public const uint ProjectionEponymousNameCodeSequence = 0x00185104;

        ///<summary>(0018,5210) VR=DS VM=6 Image Transformation Matrix (RETIRED)</summary>
        public const uint ImageTransformationMatrixRETIRED = 0x00185210;

        ///<summary>(0018,5212) VR=DS VM=3 Image Translation Vector (RETIRED)</summary>
        public const uint ImageTranslationVectorRETIRED = 0x00185212;

        ///<summary>(0018,6000) VR=DS VM=1 Sensitivity</summary>
        public const uint Sensitivity = 0x00186000;

        ///<summary>(0018,6011) VR=SQ VM=1 Sequence of Ultrasound Regions</summary>
        public const uint SequenceOfUltrasoundRegions = 0x00186011;

        ///<summary>(0018,6012) VR=US VM=1 Region Spatial Format</summary>
        public const uint RegionSpatialFormat = 0x00186012;

        ///<summary>(0018,6014) VR=US VM=1 Region Data Type</summary>
        public const uint RegionDataType = 0x00186014;

        ///<summary>(0018,6016) VR=UL VM=1 Region Flags</summary>
        public const uint RegionFlags = 0x00186016;

        ///<summary>(0018,6018) VR=UL VM=1 Region Location Min X0</summary>
        public const uint RegionLocationMinX0 = 0x00186018;

        ///<summary>(0018,601A) VR=UL VM=1 Region Location Min Y0</summary>
        public const uint RegionLocationMinY0 = 0x0018601A;

        ///<summary>(0018,601C) VR=UL VM=1 Region Location Max X1</summary>
        public const uint RegionLocationMaxX1 = 0x0018601C;

        ///<summary>(0018,601E) VR=UL VM=1 Region Location Max Y1</summary>
        public const uint RegionLocationMaxY1 = 0x0018601E;

        ///<summary>(0018,6020) VR=SL VM=1 Reference Pixel X0</summary>
        public const uint ReferencePixelX0 = 0x00186020;

        ///<summary>(0018,6022) VR=SL VM=1 Reference Pixel Y0</summary>
        public const uint ReferencePixelY0 = 0x00186022;

        ///<summary>(0018,6024) VR=US VM=1 Physical Units X Direction</summary>
        public const uint PhysicalUnitsXDirection = 0x00186024;

        ///<summary>(0018,6026) VR=US VM=1 Physical Units Y Direction</summary>
        public const uint PhysicalUnitsYDirection = 0x00186026;

        ///<summary>(0018,6028) VR=FD VM=1 Reference Pixel Physical Value X</summary>
        public const uint ReferencePixelPhysicalValueX = 0x00186028;

        ///<summary>(0018,602A) VR=FD VM=1 Reference Pixel Physical Value Y</summary>
        public const uint ReferencePixelPhysicalValueY = 0x0018602A;

        ///<summary>(0018,602C) VR=FD VM=1 Physical Delta X</summary>
        public const uint PhysicalDeltaX = 0x0018602C;

        ///<summary>(0018,602E) VR=FD VM=1 Physical Delta Y</summary>
        public const uint PhysicalDeltaY = 0x0018602E;

        ///<summary>(0018,6030) VR=UL VM=1 Transducer Frequency</summary>
        public const uint TransducerFrequency = 0x00186030;

        ///<summary>(0018,6031) VR=CS VM=1 Transducer Type</summary>
        public const uint TransducerType = 0x00186031;

        ///<summary>(0018,6032) VR=UL VM=1 Pulse Repetition Frequency</summary>
        public const uint PulseRepetitionFrequency = 0x00186032;

        ///<summary>(0018,6034) VR=FD VM=1 Doppler Correction Angle</summary>
        public const uint DopplerCorrectionAngle = 0x00186034;

        ///<summary>(0018,6036) VR=FD VM=1 Steering Angle</summary>
        public const uint SteeringAngle = 0x00186036;

        ///<summary>(0018,6038) VR=UL VM=1 Doppler Sample Volume X Position (Retired) (RETIRED)</summary>
        public const uint DopplerSampleVolumeXPositionRetiredRETIRED = 0x00186038;

        ///<summary>(0018,6039) VR=SL VM=1 Doppler Sample Volume X Position</summary>
        public const uint DopplerSampleVolumeXPosition = 0x00186039;

        ///<summary>(0018,603A) VR=UL VM=1 Doppler Sample Volume Y Position (Retired) (RETIRED)</summary>
        public const uint DopplerSampleVolumeYPositionRetiredRETIRED = 0x0018603A;

        ///<summary>(0018,603B) VR=SL VM=1 Doppler Sample Volume Y Position</summary>
        public const uint DopplerSampleVolumeYPosition = 0x0018603B;

        ///<summary>(0018,603C) VR=UL VM=1 TM-Line Position X0 (Retired) (RETIRED)</summary>
        public const uint TMLinePositionX0RetiredRETIRED = 0x0018603C;

        ///<summary>(0018,603D) VR=SL VM=1 TM-Line Position X0</summary>
        public const uint TMLinePositionX0 = 0x0018603D;

        ///<summary>(0018,603E) VR=UL VM=1 TM-Line Position Y0 (Retired) (RETIRED)</summary>
        public const uint TMLinePositionY0RetiredRETIRED = 0x0018603E;

        ///<summary>(0018,603F) VR=SL VM=1 TM-Line Position Y0</summary>
        public const uint TMLinePositionY0 = 0x0018603F;

        ///<summary>(0018,6040) VR=UL VM=1 TM-Line Position X1 (Retired) (RETIRED)</summary>
        public const uint TMLinePositionX1RetiredRETIRED = 0x00186040;

        ///<summary>(0018,6041) VR=SL VM=1 TM-Line Position X1</summary>
        public const uint TMLinePositionX1 = 0x00186041;

        ///<summary>(0018,6042) VR=UL VM=1 TM-Line Position Y1 (Retired) (RETIRED)</summary>
        public const uint TMLinePositionY1RetiredRETIRED = 0x00186042;

        ///<summary>(0018,6043) VR=SL VM=1 TM-Line Position Y1</summary>
        public const uint TMLinePositionY1 = 0x00186043;

        ///<summary>(0018,6044) VR=US VM=1 Pixel Component Organization</summary>
        public const uint PixelComponentOrganization = 0x00186044;

        ///<summary>(0018,6046) VR=UL VM=1 Pixel Component Mask</summary>
        public const uint PixelComponentMask = 0x00186046;

        ///<summary>(0018,6048) VR=UL VM=1 Pixel Component Range Start</summary>
        public const uint PixelComponentRangeStart = 0x00186048;

        ///<summary>(0018,604A) VR=UL VM=1 Pixel Component Range Stop</summary>
        public const uint PixelComponentRangeStop = 0x0018604A;

        ///<summary>(0018,604C) VR=US VM=1 Pixel Component Physical Units</summary>
        public const uint PixelComponentPhysicalUnits = 0x0018604C;

        ///<summary>(0018,604E) VR=US VM=1 Pixel Component Data Type</summary>
        public const uint PixelComponentDataType = 0x0018604E;

        ///<summary>(0018,6050) VR=UL VM=1 Number of Table Break Points</summary>
        public const uint NumberOfTableBreakPoints = 0x00186050;

        ///<summary>(0018,6052) VR=UL VM=1-n Table of X Break Points</summary>
        public const uint TableOfXBreakPoints = 0x00186052;

        ///<summary>(0018,6054) VR=FD VM=1-n Table of Y Break Points</summary>
        public const uint TableOfYBreakPoints = 0x00186054;

        ///<summary>(0018,6056) VR=UL VM=1 Number of Table Entries</summary>
        public const uint NumberOfTableEntries = 0x00186056;

        ///<summary>(0018,6058) VR=UL VM=1-n Table of Pixel Values</summary>
        public const uint TableOfPixelValues = 0x00186058;

        ///<summary>(0018,605A) VR=FL VM=1-n Table of Parameter Values</summary>
        public const uint TableOfParameterValues = 0x0018605A;

        ///<summary>(0018,6060) VR=FL VM=1-n R Wave Time Vector</summary>
        public const uint RWaveTimeVector = 0x00186060;

        ///<summary>(0018,6070) VR=US VM=1 Active Image Area Overlay Group</summary>
        public const uint ActiveImageAreaOverlayGroup = 0x00186070;

        ///<summary>(0018,7000) VR=CS VM=1 Detector Conditions Nominal Flag</summary>
        public const uint DetectorConditionsNominalFlag = 0x00187000;

        ///<summary>(0018,7001) VR=DS VM=1 Detector Temperature</summary>
        public const uint DetectorTemperature = 0x00187001;

        ///<summary>(0018,7004) VR=CS VM=1 Detector Type</summary>
        public const uint DetectorType = 0x00187004;

        ///<summary>(0018,7005) VR=CS VM=1 Detector Configuration</summary>
        public const uint DetectorConfiguration = 0x00187005;

        ///<summary>(0018,7006) VR=LT VM=1 Detector Description</summary>
        public const uint DetectorDescription = 0x00187006;

        ///<summary>(0018,7008) VR=LT VM=1 Detector Mode</summary>
        public const uint DetectorMode = 0x00187008;

        ///<summary>(0018,700A) VR=SH VM=1 Detector Id</summary>
        public const uint DetectorId = 0x0018700A;

        ///<summary>(0018,700C) VR=DA VM=1 Date of Last Detector Calibration</summary>
        public const uint DateOfLastDetectorCalibration = 0x0018700C;

        ///<summary>(0018,700E) VR=TM VM=1 Time of Last Detector Calibration</summary>
        public const uint TimeOfLastDetectorCalibration = 0x0018700E;

        ///<summary>(0018,7010) VR=IS VM=1 Exposures on Detector Since Last Calibration</summary>
        public const uint ExposuresOnDetectorSinceLastCalibration = 0x00187010;

        ///<summary>(0018,7011) VR=IS VM=1 Exposures on Detector Since Manufactured</summary>
        public const uint ExposuresOnDetectorSinceManufactured = 0x00187011;

        ///<summary>(0018,7012) VR=DS VM=1 Detector Time Since Last Exposure</summary>
        public const uint DetectorTimeSinceLastExposure = 0x00187012;

        ///<summary>(0018,7014) VR=DS VM=1 Detector Active Time</summary>
        public const uint DetectorActiveTime = 0x00187014;

        ///<summary>(0018,7016) VR=DS VM=1 Detector Activation Offset From Exposure</summary>
        public const uint DetectorActivationOffsetFromExposure = 0x00187016;

        ///<summary>(0018,701A) VR=DS VM=2 Detector Binning</summary>
        public const uint DetectorBinning = 0x0018701A;

        ///<summary>(0018,7020) VR=DS VM=2 Detector Element Physical Size</summary>
        public const uint DetectorElementPhysicalSize = 0x00187020;

        ///<summary>(0018,7022) VR=DS VM=2 Detector Element Spacing</summary>
        public const uint DetectorElementSpacing = 0x00187022;

        ///<summary>(0018,7024) VR=CS VM=1 Detector Active Shape</summary>
        public const uint DetectorActiveShape = 0x00187024;

        ///<summary>(0018,7026) VR=DS VM=1-2 Detector Active Dimension(s)</summary>
        public const uint DetectorActiveDimensions = 0x00187026;

        ///<summary>(0018,7028) VR=DS VM=2 Detector Active Origin</summary>
        public const uint DetectorActiveOrigin = 0x00187028;

        ///<summary>(0018,702A) VR=LO VM=1 Detector Manufacturer Name</summary>
        public const uint DetectorManufacturerName = 0x0018702A;

        ///<summary>(0018,702B) VR=LO VM=1 Detector Manufacturer's Model Name</summary>
        public const uint DetectorManufacturerModelName = 0x0018702B;

        ///<summary>(0018,7030) VR=DS VM=2 Field of View Origin</summary>
        public const uint FieldOfViewOrigin = 0x00187030;

        ///<summary>(0018,7032) VR=DS VM=1 Field of View Rotation</summary>
        public const uint FieldOfViewRotation = 0x00187032;

        ///<summary>(0018,7034) VR=CS VM=1 Field of View Horizontal Flip</summary>
        public const uint FieldOfViewHorizontalFlip = 0x00187034;

        ///<summary>(0018,7036) VR=FL VM=2 Pixel Data Area Origin Relative To FOV</summary>
        public const uint PixelDataAreaOriginRelativeToFOV = 0x00187036;

        ///<summary>(0018,7038) VR=FL VM=1 Pixel Data Area Rotation Angle Relative To FOV</summary>
        public const uint PixelDataAreaRotationAngleRelativeToFOV = 0x00187038;

        ///<summary>(0018,7040) VR=LT VM=1 Grid Absorbing Material</summary>
        public const uint GridAbsorbingMaterial = 0x00187040;

        ///<summary>(0018,7041) VR=LT VM=1 Grid Spacing Material</summary>
        public const uint GridSpacingMaterial = 0x00187041;

        ///<summary>(0018,7042) VR=DS VM=1 Grid Thickness</summary>
        public const uint GridThickness = 0x00187042;

        ///<summary>(0018,7044) VR=DS VM=1 Grid Pitch</summary>
        public const uint GridPitch = 0x00187044;

        ///<summary>(0018,7046) VR=IS VM=2 Grid Aspect Ratio</summary>
        public const uint GridAspectRatio = 0x00187046;

        ///<summary>(0018,7048) VR=DS VM=1 Grid Period</summary>
        public const uint GridPeriod = 0x00187048;

        ///<summary>(0018,704C) VR=DS VM=1 Grid Focal Distance</summary>
        public const uint GridFocalDistance = 0x0018704C;

        ///<summary>(0018,7050) VR=CS VM=1-n Filter Material</summary>
        public const uint FilterMaterial = 0x00187050;

        ///<summary>(0018,7052) VR=DS VM=1-n Filter Thickness Minimum</summary>
        public const uint FilterThicknessMinimum = 0x00187052;

        ///<summary>(0018,7054) VR=DS VM=1-n Filter Thickness Maximum</summary>
        public const uint FilterThicknessMaximum = 0x00187054;

        ///<summary>(0018,7056) VR=FL VM=1-n Filter Beam Path Length Minimum</summary>
        public const uint FilterBeamPathLengthMinimum = 0x00187056;

        ///<summary>(0018,7058) VR=FL VM=1-n Filter Beam Path Length Maximum</summary>
        public const uint FilterBeamPathLengthMaximum = 0x00187058;

        ///<summary>(0018,7060) VR=CS VM=1 Exposure Control Mode</summary>
        public const uint ExposureControlMode = 0x00187060;

        ///<summary>(0018,7062) VR=LT VM=1 Exposure Control Mode Description</summary>
        public const uint ExposureControlModeDescription = 0x00187062;

        ///<summary>(0018,7064) VR=CS VM=1 Exposure Status</summary>
        public const uint ExposureStatus = 0x00187064;

        ///<summary>(0018,7065) VR=DS VM=1 Phototimer Setting</summary>
        public const uint PhototimerSetting = 0x00187065;

        ///<summary>(0018,8150) VR=DS VM=1 Exposure Time in µS</summary>
        public const uint ExposureTimeInuS = 0x00188150;

        ///<summary>(0018,8151) VR=DS VM=1 X-Ray Tube Current in µA</summary>
        public const uint XRayTubeCurrentInuA = 0x00188151;

        ///<summary>(0018,9004) VR=CS VM=1 Content Qualification</summary>
        public const uint ContentQualification = 0x00189004;

        ///<summary>(0018,9005) VR=SH VM=1 Pulse Sequence Name</summary>
        public const uint PulseSequenceName = 0x00189005;

        ///<summary>(0018,9006) VR=SQ VM=1 MR Imaging Modifier Sequence</summary>
        public const uint MRImagingModifierSequence = 0x00189006;

        ///<summary>(0018,9008) VR=CS VM=1 Echo Pulse Sequence</summary>
        public const uint EchoPulseSequence = 0x00189008;

        ///<summary>(0018,9009) VR=CS VM=1 Inversion Recovery</summary>
        public const uint InversionRecovery = 0x00189009;

        ///<summary>(0018,9010) VR=CS VM=1 Flow Compensation</summary>
        public const uint FlowCompensation = 0x00189010;

        ///<summary>(0018,9011) VR=CS VM=1 Multiple Spin Echo</summary>
        public const uint MultipleSpinEcho = 0x00189011;

        ///<summary>(0018,9012) VR=CS VM=1 Multi-planar Excitation</summary>
        public const uint MultiPlanarExcitation = 0x00189012;

        ///<summary>(0018,9014) VR=CS VM=1 Phase Contrast</summary>
        public const uint PhaseContrast = 0x00189014;

        ///<summary>(0018,9015) VR=CS VM=1 Time of Flight Contrast</summary>
        public const uint TimeOfFlightContrast = 0x00189015;

        ///<summary>(0018,9016) VR=CS VM=1 Spoiling</summary>
        public const uint Spoiling = 0x00189016;

        ///<summary>(0018,9017) VR=CS VM=1 Steady State Pulse Sequence</summary>
        public const uint SteadyStatePulseSequence = 0x00189017;

        ///<summary>(0018,9018) VR=CS VM=1 Echo Planar Pulse Sequence</summary>
        public const uint EchoPlanarPulseSequence = 0x00189018;

        ///<summary>(0018,9019) VR=FD VM=1 Tag Angle First Axis</summary>
        public const uint TagAngleFirstAxis = 0x00189019;

        ///<summary>(0018,9020) VR=CS VM=1 Magnetization Transfer</summary>
        public const uint MagnetizationTransfer = 0x00189020;

        ///<summary>(0018,9021) VR=CS VM=1 T2 Preparation</summary>
        public const uint T2Preparation = 0x00189021;

        ///<summary>(0018,9022) VR=CS VM=1 Blood Signal Nulling</summary>
        public const uint BloodSignalNulling = 0x00189022;

        ///<summary>(0018,9024) VR=CS VM=1 Saturation Recovery</summary>
        public const uint SaturationRecovery = 0x00189024;

        ///<summary>(0018,9025) VR=CS VM=1 Spectrally Selected Suppression</summary>
        public const uint SpectrallySelectedSuppression = 0x00189025;

        ///<summary>(0018,9026) VR=CS VM=1 Spectrally Selected Excitation</summary>
        public const uint SpectrallySelectedExcitation = 0x00189026;

        ///<summary>(0018,9027) VR=CS VM=1 Spatial Pre-saturation</summary>
        public const uint SpatialPresaturation = 0x00189027;

        ///<summary>(0018,9028) VR=CS VM=1 Tagging</summary>
        public const uint Tagging = 0x00189028;

        ///<summary>(0018,9029) VR=CS VM=1 Oversampling Phase</summary>
        public const uint OversamplingPhase = 0x00189029;

        ///<summary>(0018,9030) VR=FD VM=1 Tag Spacing First Dimension</summary>
        public const uint TagSpacingFirstDimension = 0x00189030;

        ///<summary>(0018,9032) VR=CS VM=1 Geometry of k-Space Traversal</summary>
        public const uint GeometryOfKSpaceTraversal = 0x00189032;

        ///<summary>(0018,9033) VR=CS VM=1 Segmented k-Space Traversal</summary>
        public const uint SegmentedKSpaceTraversal = 0x00189033;

        ///<summary>(0018,9034) VR=CS VM=1 Rectilinear Phase Encode Reordering</summary>
        public const uint RectilinearPhaseEncodeReordering = 0x00189034;

        ///<summary>(0018,9035) VR=FD VM=1 Tag Thickness</summary>
        public const uint TagThickness = 0x00189035;

        ///<summary>(0018,9036) VR=CS VM=1 Partial Fourier Direction</summary>
        public const uint PartialFourierDirection = 0x00189036;

        ///<summary>(0018,9037) VR=CS VM=1 Cardiac Synchronization Technique</summary>
        public const uint CardiacSynchronizationTechnique = 0x00189037;

        ///<summary>(0018,9041) VR=LO VM=1 Receive Coil Manufacturer Name</summary>
        public const uint ReceiveCoilManufacturerName = 0x00189041;

        ///<summary>(0018,9042) VR=SQ VM=1 MR Receive Coil Sequence</summary>
        public const uint MRReceiveCoilSequence = 0x00189042;

        ///<summary>(0018,9043) VR=CS VM=1 Receive Coil Type</summary>
        public const uint ReceiveCoilType = 0x00189043;

        ///<summary>(0018,9044) VR=CS VM=1 Quadrature Receive Coil</summary>
        public const uint QuadratureReceiveCoil = 0x00189044;

        ///<summary>(0018,9045) VR=SQ VM=1 Multi-Coil Definition Sequence</summary>
        public const uint MultiCoilDefinitionSequence = 0x00189045;

        ///<summary>(0018,9046) VR=LO VM=1 Multi-Coil Configuration</summary>
        public const uint MultiCoilConfiguration = 0x00189046;

        ///<summary>(0018,9047) VR=SH VM=1 Multi-Coil Element Name</summary>
        public const uint MultiCoilElementName = 0x00189047;

        ///<summary>(0018,9048) VR=CS VM=1 Multi-Coil Element Used</summary>
        public const uint MultiCoilElementUsed = 0x00189048;

        ///<summary>(0018,9049) VR=SQ VM=1 MR Transmit Coil Sequence</summary>
        public const uint MRTransmitCoilSequence = 0x00189049;

        ///<summary>(0018,9050) VR=LO VM=1 Transmit Coil Manufacturer Name</summary>
        public const uint TransmitCoilManufacturerName = 0x00189050;

        ///<summary>(0018,9051) VR=CS VM=1 Transmit Coil Type</summary>
        public const uint TransmitCoilType = 0x00189051;

        ///<summary>(0018,9052) VR=FD VM=1-2 Spectral Width</summary>
        public const uint SpectralWidth = 0x00189052;

        ///<summary>(0018,9053) VR=FD VM=1-2 Chemical Shift Reference</summary>
        public const uint ChemicalShiftReference = 0x00189053;

        ///<summary>(0018,9054) VR=CS VM=1 Volume Localization Technique</summary>
        public const uint VolumeLocalizationTechnique = 0x00189054;

        ///<summary>(0018,9058) VR=US VM=1 MR Acquisition Frequency Encoding Steps</summary>
        public const uint MRAcquisitionFrequencyEncodingSteps = 0x00189058;

        ///<summary>(0018,9059) VR=CS VM=1 De-coupling</summary>
        public const uint Decoupling = 0x00189059;

        ///<summary>(0018,9060) VR=CS VM=1-2 De-coupled Nucleus</summary>
        public const uint DecoupledNucleus = 0x00189060;

        ///<summary>(0018,9061) VR=FD VM=1-2 De-coupling Frequency</summary>
        public const uint DecouplingFrequency = 0x00189061;

        ///<summary>(0018,9062) VR=CS VM=1 De-coupling Method</summary>
        public const uint DecouplingMethod = 0x00189062;

        ///<summary>(0018,9063) VR=FD VM=1-2 De-coupling Chemical Shift Reference</summary>
        public const uint DecouplingChemicalShiftReference = 0x00189063;

        ///<summary>(0018,9064) VR=CS VM=1 k-space Filtering</summary>
        public const uint KSpaceFiltering = 0x00189064;

        ///<summary>(0018,9065) VR=CS VM=1-2 Time Domain Filtering</summary>
        public const uint TimeDomainFiltering = 0x00189065;

        ///<summary>(0018,9066) VR=US VM=1-2 Number of Zero Fills</summary>
        public const uint NumberOfZeroFills = 0x00189066;

        ///<summary>(0018,9067) VR=CS VM=1 Baseline Correction</summary>
        public const uint BaselineCorrection = 0x00189067;

        ///<summary>(0018,9069) VR=FD VM=1 Parallel Reduction Factor In-plane</summary>
        public const uint ParallelReductionFactorInPlane = 0x00189069;

        ///<summary>(0018,9070) VR=FD VM=1 Cardiac R-R Interval Specified</summary>
        public const uint CardiacRRIntervalSpecified = 0x00189070;

        ///<summary>(0018,9073) VR=FD VM=1 Acquisition Duration</summary>
        public const uint AcquisitionDuration = 0x00189073;

        ///<summary>(0018,9074) VR=DT VM=1 Frame Acquisition DateTime</summary>
        public const uint FrameAcquisitionDateTime = 0x00189074;

        ///<summary>(0018,9075) VR=CS VM=1 Diffusion Directionality</summary>
        public const uint DiffusionDirectionality = 0x00189075;

        ///<summary>(0018,9076) VR=SQ VM=1 Diffusion Gradient Direction Sequence</summary>
        public const uint DiffusionGradientDirectionSequence = 0x00189076;

        ///<summary>(0018,9077) VR=CS VM=1 Parallel Acquisition</summary>
        public const uint ParallelAcquisition = 0x00189077;

        ///<summary>(0018,9078) VR=CS VM=1 Parallel Acquisition Technique</summary>
        public const uint ParallelAcquisitionTechnique = 0x00189078;

        ///<summary>(0018,9079) VR=FD VM=1-n Inversion Times</summary>
        public const uint InversionTimes = 0x00189079;

        ///<summary>(0018,9080) VR=ST VM=1 Metabolite Map Description</summary>
        public const uint MetaboliteMapDescription = 0x00189080;

        ///<summary>(0018,9081) VR=CS VM=1 Partial Fourier</summary>
        public const uint PartialFourier = 0x00189081;

        ///<summary>(0018,9082) VR=FD VM=1 Effective Echo Time</summary>
        public const uint EffectiveEchoTime = 0x00189082;

        ///<summary>(0018,9083) VR=SQ VM=1 Metabolite Map Code Sequence</summary>
        public const uint MetaboliteMapCodeSequence = 0x00189083;

        ///<summary>(0018,9084) VR=SQ VM=1 Chemical Shift Sequence</summary>
        public const uint ChemicalShiftSequence = 0x00189084;

        ///<summary>(0018,9085) VR=CS VM=1 Cardiac Signal Source</summary>
        public const uint CardiacSignalSource = 0x00189085;

        ///<summary>(0018,9087) VR=FD VM=1 Diffusion b-value</summary>
        public const uint DiffusionBValue = 0x00189087;

        ///<summary>(0018,9089) VR=FD VM=3 Diffusion Gradient Orientation</summary>
        public const uint DiffusionGradientOrientation = 0x00189089;

        ///<summary>(0018,9090) VR=FD VM=3 Velocity Encoding Direction</summary>
        public const uint VelocityEncodingDirection = 0x00189090;

        ///<summary>(0018,9091) VR=FD VM=1 Velocity Encoding Minimum Value</summary>
        public const uint VelocityEncodingMinimumValue = 0x00189091;

        ///<summary>(0018,9092) VR=SQ VM=1 Velocity Encoding Acquisition Sequence</summary>
        public const uint VelocityEncodingAcquisitionSequence = 0x00189092;

        ///<summary>(0018,9093) VR=US VM=1 Number of k-Space Trajectories</summary>
        public const uint NumberOfKSpaceTrajectories = 0x00189093;

        ///<summary>(0018,9094) VR=CS VM=1 Coverage of k-Space</summary>
        public const uint CoverageOfKSpace = 0x00189094;

        ///<summary>(0018,9095) VR=UL VM=1 Spectroscopy Acquisition Phase Rows</summary>
        public const uint SpectroscopyAcquisitionPhaseRows = 0x00189095;

        ///<summary>(0018,9096) VR=FD VM=1 Parallel Reduction Factor In-plane (Retired) (RETIRED)</summary>
        public const uint ParallelReductionFactorInPlaneRetiredRETIRED = 0x00189096;

        ///<summary>(0018,9098) VR=FD VM=1-2 Transmitter Frequency</summary>
        public const uint TransmitterFrequency = 0x00189098;

        ///<summary>(0018,9100) VR=CS VM=1-2 Resonant Nucleus</summary>
        public const uint ResonantNucleus = 0x00189100;

        ///<summary>(0018,9101) VR=CS VM=1 Frequency Correction</summary>
        public const uint FrequencyCorrection = 0x00189101;

        ///<summary>(0018,9103) VR=SQ VM=1 MR Spectroscopy FOV/Geometry Sequence</summary>
        public const uint MRSpectroscopyFOVGeometrySequence = 0x00189103;

        ///<summary>(0018,9104) VR=FD VM=1 Slab Thickness</summary>
        public const uint SlabThickness = 0x00189104;

        ///<summary>(0018,9105) VR=FD VM=3 Slab Orientation</summary>
        public const uint SlabOrientation = 0x00189105;

        ///<summary>(0018,9106) VR=FD VM=3 Mid Slab Position</summary>
        public const uint MidSlabPosition = 0x00189106;

        ///<summary>(0018,9107) VR=SQ VM=1 MR Spatial Saturation Sequence</summary>
        public const uint MRSpatialSaturationSequence = 0x00189107;

        ///<summary>(0018,9112) VR=SQ VM=1 MR Timing and Related Parameters Sequence</summary>
        public const uint MRTimingAndRelatedParametersSequence = 0x00189112;

        ///<summary>(0018,9114) VR=SQ VM=1 MR Echo Sequence</summary>
        public const uint MREchoSequence = 0x00189114;

        ///<summary>(0018,9115) VR=SQ VM=1 MR Modifier Sequence</summary>
        public const uint MRModifierSequence = 0x00189115;

        ///<summary>(0018,9117) VR=SQ VM=1 MR Diffusion Sequence</summary>
        public const uint MRDiffusionSequence = 0x00189117;

        ///<summary>(0018,9118) VR=SQ VM=1 Cardiac Synchronization Sequence</summary>
        public const uint CardiacSynchronizationSequence = 0x00189118;

        ///<summary>(0018,9119) VR=SQ VM=1 MR Averages Sequence</summary>
        public const uint MRAveragesSequence = 0x00189119;

        ///<summary>(0018,9125) VR=SQ VM=1 MR FOV/Geometry Sequence</summary>
        public const uint MRFOVGeometrySequence = 0x00189125;

        ///<summary>(0018,9126) VR=SQ VM=1 Volume Localization Sequence</summary>
        public const uint VolumeLocalizationSequence = 0x00189126;

        ///<summary>(0018,9127) VR=UL VM=1 Spectroscopy Acquisition Data Columns</summary>
        public const uint SpectroscopyAcquisitionDataColumns = 0x00189127;

        ///<summary>(0018,9147) VR=CS VM=1 Diffusion Anisotropy Type</summary>
        public const uint DiffusionAnisotropyType = 0x00189147;

        ///<summary>(0018,9151) VR=DT VM=1 Frame Reference DateTime</summary>
        public const uint FrameReferenceDateTime = 0x00189151;

        ///<summary>(0018,9152) VR=SQ VM=1 MR Metabolite Map Sequence</summary>
        public const uint MRMetaboliteMapSequence = 0x00189152;

        ///<summary>(0018,9155) VR=FD VM=1 Parallel Reduction Factor out-of-plane</summary>
        public const uint ParallelReductionFactorOutOfPlane = 0x00189155;

        ///<summary>(0018,9159) VR=UL VM=1 Spectroscopy Acquisition Out-of-plane Phase Steps</summary>
        public const uint SpectroscopyAcquisitionOutOfPlanePhaseSteps = 0x00189159;

        ///<summary>(0018,9166) VR=CS VM=1 Bulk Motion Status (RETIRED)</summary>
        public const uint BulkMotionStatusRETIRED = 0x00189166;

        ///<summary>(0018,9168) VR=FD VM=1 Parallel Reduction Factor Second In-plane</summary>
        public const uint ParallelReductionFactorSecondInPlane = 0x00189168;

        ///<summary>(0018,9169) VR=CS VM=1 Cardiac Beat Rejection Technique</summary>
        public const uint CardiacBeatRejectionTechnique = 0x00189169;

        ///<summary>(0018,9170) VR=CS VM=1 Respiratory Motion Compensation Technique</summary>
        public const uint RespiratoryMotionCompensationTechnique = 0x00189170;

        ///<summary>(0018,9171) VR=CS VM=1 Respiratory Signal Source</summary>
        public const uint RespiratorySignalSource = 0x00189171;

        ///<summary>(0018,9172) VR=CS VM=1 Bulk Motion Compensation Technique</summary>
        public const uint BulkMotionCompensationTechnique = 0x00189172;

        ///<summary>(0018,9173) VR=CS VM=1 Bulk Motion Signal Source</summary>
        public const uint BulkMotionSignalSource = 0x00189173;

        ///<summary>(0018,9174) VR=CS VM=1 Applicable Safety Standard Agency</summary>
        public const uint ApplicableSafetyStandardAgency = 0x00189174;

        ///<summary>(0018,9175) VR=LO VM=1 Applicable Safety Standard Description</summary>
        public const uint ApplicableSafetyStandardDescription = 0x00189175;

        ///<summary>(0018,9176) VR=SQ VM=1 Operating Mode Sequence</summary>
        public const uint OperatingModeSequence = 0x00189176;

        ///<summary>(0018,9177) VR=CS VM=1 Operating Mode Type</summary>
        public const uint OperatingModeType = 0x00189177;

        ///<summary>(0018,9178) VR=CS VM=1 Operating Mode</summary>
        public const uint OperatingMode = 0x00189178;

        ///<summary>(0018,9179) VR=CS VM=1 Specific Absorption Rate Definition</summary>
        public const uint SpecificAbsorptionRateDefinition = 0x00189179;

        ///<summary>(0018,9180) VR=CS VM=1 Gradient Output Type</summary>
        public const uint GradientOutputType = 0x00189180;

        ///<summary>(0018,9181) VR=FD VM=1 Specific Absorption Rate Value</summary>
        public const uint SpecificAbsorptionRateValue = 0x00189181;

        ///<summary>(0018,9182) VR=FD VM=1 Gradient Output</summary>
        public const uint GradientOutput = 0x00189182;

        ///<summary>(0018,9183) VR=CS VM=1 Flow Compensation Direction</summary>
        public const uint FlowCompensationDirection = 0x00189183;

        ///<summary>(0018,9184) VR=FD VM=1 Tagging Delay</summary>
        public const uint TaggingDelay = 0x00189184;

        ///<summary>(0018,9185) VR=ST VM=1 Respiratory Motion Compensation Technique Description</summary>
        public const uint RespiratoryMotionCompensationTechniqueDescription = 0x00189185;

        ///<summary>(0018,9186) VR=SH VM=1 Respiratory Signal Source Id</summary>
        public const uint RespiratorySignalSourceId = 0x00189186;

        ///<summary>(0018,9195) VR=FD VM=1 Chemical Shift Minimum Integration Limit in Hz (RETIRED)</summary>
        public const uint ChemicalShiftMinimumIntegrationLimitInHzRETIRED = 0x00189195;

        ///<summary>(0018,9196) VR=FD VM=1 Chemical Shift Maximum Integration Limit in Hz (RETIRED)</summary>
        public const uint ChemicalShiftMaximumIntegrationLimitInHzRETIRED = 0x00189196;

        ///<summary>(0018,9197) VR=SQ VM=1 MR Velocity Encoding Sequence</summary>
        public const uint MRVelocityEncodingSequence = 0x00189197;

        ///<summary>(0018,9198) VR=CS VM=1 First Order Phase Correction</summary>
        public const uint FirstOrderPhaseCorrection = 0x00189198;

        ///<summary>(0018,9199) VR=CS VM=1 Water Referenced Phase Correction</summary>
        public const uint WaterReferencedPhaseCorrection = 0x00189199;

        ///<summary>(0018,9200) VR=CS VM=1 MR Spectroscopy Acquisition Type</summary>
        public const uint MRSpectroscopyAcquisitionType = 0x00189200;

        ///<summary>(0018,9214) VR=CS VM=1 Respiratory Cycle Position</summary>
        public const uint RespiratoryCyclePosition = 0x00189214;

        ///<summary>(0018,9217) VR=FD VM=1 Velocity Encoding Maximum Value</summary>
        public const uint VelocityEncodingMaximumValue = 0x00189217;

        ///<summary>(0018,9218) VR=FD VM=1 Tag Spacing Second Dimension</summary>
        public const uint TagSpacingSecondDimension = 0x00189218;

        ///<summary>(0018,9219) VR=SS VM=1 Tag Angle Second Axis</summary>
        public const uint TagAngleSecondAxis = 0x00189219;

        ///<summary>(0018,9220) VR=FD VM=1 Frame Acquisition Duration</summary>
        public const uint FrameAcquisitionDuration = 0x00189220;

        ///<summary>(0018,9226) VR=SQ VM=1 MR Image Frame Type Sequence</summary>
        public const uint MRImageFrameTypeSequence = 0x00189226;

        ///<summary>(0018,9227) VR=SQ VM=1 MR Spectroscopy Frame Type Sequence</summary>
        public const uint MRSpectroscopyFrameTypeSequence = 0x00189227;

        ///<summary>(0018,9231) VR=US VM=1 MR Acquisition Phase Encoding Steps in-plane</summary>
        public const uint MRAcquisitionPhaseEncodingStepsInPlane = 0x00189231;

        ///<summary>(0018,9232) VR=US VM=1 MR Acquisition Phase Encoding Steps out-of-plane</summary>
        public const uint MRAcquisitionPhaseEncodingStepsOutOfPlane = 0x00189232;

        ///<summary>(0018,9234) VR=UL VM=1 Spectroscopy Acquisition Phase Columns</summary>
        public const uint SpectroscopyAcquisitionPhaseColumns = 0x00189234;

        ///<summary>(0018,9236) VR=CS VM=1 Cardiac Cycle Position</summary>
        public const uint CardiacCyclePosition = 0x00189236;

        ///<summary>(0018,9239) VR=SQ VM=1 Specific Absorption Rate Sequence</summary>
        public const uint SpecificAbsorptionRateSequence = 0x00189239;

        ///<summary>(0018,9240) VR=US VM=1 RF Echo Train Length</summary>
        public const uint RFEchoTrainLength = 0x00189240;

        ///<summary>(0018,9241) VR=US VM=1 Gradient Echo Train Length</summary>
        public const uint GradientEchoTrainLength = 0x00189241;

        ///<summary>(0018,9250) VR=CS VM=1 Arterial Spin Labeling Contrast</summary>
        public const uint ArterialSpinLabelingContrast = 0x00189250;

        ///<summary>(0018,9251) VR=SQ VM=1 MR Arterial Spin Labeling Sequence</summary>
        public const uint MRArterialSpinLabelingSequence = 0x00189251;

        ///<summary>(0018,9252) VR=LO VM=1 ASL Technique Description</summary>
        public const uint ASLTechniqueDescription = 0x00189252;

        ///<summary>(0018,9253) VR=US VM=1 ASL Slab Number</summary>
        public const uint ASLSlabNumber = 0x00189253;

        ///<summary>(0018,9254) VR=FD VM=1 ASL Slab Thickness</summary>
        public const uint ASLSlabThickness = 0x00189254;

        ///<summary>(0018,9255) VR=FD VM=3 ASL Slab Orientation</summary>
        public const uint ASLSlabOrientation = 0x00189255;

        ///<summary>(0018,9256) VR=FD VM=3 ASL Mid Slab Position</summary>
        public const uint ASLMidSlabPosition = 0x00189256;

        ///<summary>(0018,9257) VR=CS VM=1 ASL Context</summary>
        public const uint ASLContext = 0x00189257;

        ///<summary>(0018,9258) VR=UL VM=1 ASL Pulse Train Duration</summary>
        public const uint ASLPulseTrainDuration = 0x00189258;

        ///<summary>(0018,9259) VR=CS VM=1 ASL Crusher Flag</summary>
        public const uint ASLCrusherFlag = 0x00189259;

        ///<summary>(0018,925A) VR=FD VM=1 ASL Crusher Flow Limit</summary>
        public const uint ASLCrusherFlowLimit = 0x0018925A;

        ///<summary>(0018,925B) VR=LO VM=1 ASL Crusher Description</summary>
        public const uint ASLCrusherDescription = 0x0018925B;

        ///<summary>(0018,925C) VR=CS VM=1 ASL Bolus Cut-off Flag</summary>
        public const uint ASLBolusCutoffFlag = 0x0018925C;

        ///<summary>(0018,925D) VR=SQ VM=1 ASL Bolus Cut-off Timing Sequence</summary>
        public const uint ASLBolusCutoffTimingSequence = 0x0018925D;

        ///<summary>(0018,925E) VR=LO VM=1 ASL Bolus Cut-off Technique</summary>
        public const uint ASLBolusCutoffTechnique = 0x0018925E;

        ///<summary>(0018,925F) VR=UL VM=1 ASL Bolus Cut-off Delay Time</summary>
        public const uint ASLBolusCutoffDelayTime = 0x0018925F;

        ///<summary>(0018,9260) VR=SQ VM=1 ASL Slab Sequence</summary>
        public const uint ASLSlabSequence = 0x00189260;

        ///<summary>(0018,9295) VR=FD VM=1 Chemical Shift Minimum Integration Limit in ppm</summary>
        public const uint ChemicalShiftMinimumIntegrationLimitInppm = 0x00189295;

        ///<summary>(0018,9296) VR=FD VM=1 Chemical Shift Maximum Integration Limit in ppm</summary>
        public const uint ChemicalShiftMaximumIntegrationLimitInppm = 0x00189296;

        ///<summary>(0018,9297) VR=CS VM=1 Water Reference Acquisition</summary>
        public const uint WaterReferenceAcquisition = 0x00189297;

        ///<summary>(0018,9298) VR=IS VM=1 Echo Peak Position</summary>
        public const uint EchoPeakPosition = 0x00189298;

        ///<summary>(0018,9301) VR=SQ VM=1 CT Acquisition Type Sequence</summary>
        public const uint CTAcquisitionTypeSequence = 0x00189301;

        ///<summary>(0018,9302) VR=CS VM=1 Acquisition Type</summary>
        public const uint AcquisitionType = 0x00189302;

        ///<summary>(0018,9303) VR=FD VM=1 Tube Angle</summary>
        public const uint TubeAngle = 0x00189303;

        ///<summary>(0018,9304) VR=SQ VM=1 CT Acquisition Details Sequence</summary>
        public const uint CTAcquisitionDetailsSequence = 0x00189304;

        ///<summary>(0018,9305) VR=FD VM=1 Revolution Time</summary>
        public const uint RevolutionTime = 0x00189305;

        ///<summary>(0018,9306) VR=FD VM=1 Single Collimation Width</summary>
        public const uint SingleCollimationWidth = 0x00189306;

        ///<summary>(0018,9307) VR=FD VM=1 Total Collimation Width</summary>
        public const uint TotalCollimationWidth = 0x00189307;

        ///<summary>(0018,9308) VR=SQ VM=1 CT Table Dynamics Sequence</summary>
        public const uint CTTableDynamicsSequence = 0x00189308;

        ///<summary>(0018,9309) VR=FD VM=1 Table Speed</summary>
        public const uint TableSpeed = 0x00189309;

        ///<summary>(0018,9310) VR=FD VM=1 Table Feed per Rotation</summary>
        public const uint TableFeedPerRotation = 0x00189310;

        ///<summary>(0018,9311) VR=FD VM=1 Spiral Pitch Factor</summary>
        public const uint SpiralPitchFactor = 0x00189311;

        ///<summary>(0018,9312) VR=SQ VM=1 CT Geometry Sequence</summary>
        public const uint CTGeometrySequence = 0x00189312;

        ///<summary>(0018,9313) VR=FD VM=3 Data Collection Center (Patient)</summary>
        public const uint DataCollectionCenterPatient = 0x00189313;

        ///<summary>(0018,9314) VR=SQ VM=1 CT Reconstruction Sequence</summary>
        public const uint CTReconstructionSequence = 0x00189314;

        ///<summary>(0018,9315) VR=CS VM=1 Reconstruction Algorithm</summary>
        public const uint ReconstructionAlgorithm = 0x00189315;

        ///<summary>(0018,9316) VR=CS VM=1 Convolution Kernel Group</summary>
        public const uint ConvolutionKernelGroup = 0x00189316;

        ///<summary>(0018,9317) VR=FD VM=2 Reconstruction Field of View</summary>
        public const uint ReconstructionFieldOfView = 0x00189317;

        ///<summary>(0018,9318) VR=FD VM=3 Reconstruction Target Center (Patient)</summary>
        public const uint ReconstructionTargetCenterPatient = 0x00189318;

        ///<summary>(0018,9319) VR=FD VM=1 Reconstruction Angle</summary>
        public const uint ReconstructionAngle = 0x00189319;

        ///<summary>(0018,9320) VR=SH VM=1 Image Filter</summary>
        public const uint ImageFilter = 0x00189320;

        ///<summary>(0018,9321) VR=SQ VM=1 CT Exposure Sequence</summary>
        public const uint CTExposureSequence = 0x00189321;

        ///<summary>(0018,9322) VR=FD VM=2 Reconstruction Pixel Spacing</summary>
        public const uint ReconstructionPixelSpacing = 0x00189322;

        ///<summary>(0018,9323) VR=CS VM=1-n Exposure Modulation Type</summary>
        public const uint ExposureModulationType = 0x00189323;

        ///<summary>(0018,9324) VR=FD VM=1 Estimated Dose Saving (RETIRED)</summary>
        public const uint EstimatedDoseSavingRETIRED = 0x00189324;

        ///<summary>(0018,9325) VR=SQ VM=1 CT X-Ray Details Sequence</summary>
        public const uint CTXRayDetailsSequence = 0x00189325;

        ///<summary>(0018,9326) VR=SQ VM=1 CT Position Sequence</summary>
        public const uint CTPositionSequence = 0x00189326;

        ///<summary>(0018,9327) VR=FD VM=1 Table Position</summary>
        public const uint TablePosition = 0x00189327;

        ///<summary>(0018,9328) VR=FD VM=1 Exposure Time in ms</summary>
        public const uint ExposureTimeInms = 0x00189328;

        ///<summary>(0018,9329) VR=SQ VM=1 CT Image Frame Type Sequence</summary>
        public const uint CTImageFrameTypeSequence = 0x00189329;

        ///<summary>(0018,9330) VR=FD VM=1 X-Ray Tube Current in mA</summary>
        public const uint XRayTubeCurrentInmA = 0x00189330;

        ///<summary>(0018,9332) VR=FD VM=1 Exposure in mAs</summary>
        public const uint ExposureInmAs = 0x00189332;

        ///<summary>(0018,9333) VR=CS VM=1 Constant Volume Flag</summary>
        public const uint ConstantVolumeFlag = 0x00189333;

        ///<summary>(0018,9334) VR=CS VM=1 Fluoroscopy Flag</summary>
        public const uint FluoroscopyFlag = 0x00189334;

        ///<summary>(0018,9335) VR=FD VM=1 Distance Source to Data Collection Center</summary>
        public const uint DistanceSourceToDataCollectionCenter = 0x00189335;

        ///<summary>(0018,9337) VR=US VM=1 Contrast/Bolus Agent Number</summary>
        public const uint ContrastBolusAgentNumber = 0x00189337;

        ///<summary>(0018,9338) VR=SQ VM=1 Contrast/Bolus Ingredient Code Sequence</summary>
        public const uint ContrastBolusIngredientCodeSequence = 0x00189338;

        ///<summary>(0018,9340) VR=SQ VM=1 Contrast Administration Profile Sequence</summary>
        public const uint ContrastAdministrationProfileSequence = 0x00189340;

        ///<summary>(0018,9341) VR=SQ VM=1 Contrast/Bolus Usage Sequence</summary>
        public const uint ContrastBolusUsageSequence = 0x00189341;

        ///<summary>(0018,9342) VR=CS VM=1 Contrast/Bolus Agent Administered</summary>
        public const uint ContrastBolusAgentAdministered = 0x00189342;

        ///<summary>(0018,9343) VR=CS VM=1 Contrast/Bolus Agent Detected</summary>
        public const uint ContrastBolusAgentDetected = 0x00189343;

        ///<summary>(0018,9344) VR=CS VM=1 Contrast/Bolus Agent Phase</summary>
        public const uint ContrastBolusAgentPhase = 0x00189344;

        ///<summary>(0018,9345) VR=FD VM=1 CTDIvol</summary>
        public const uint CTDIvol = 0x00189345;

        ///<summary>(0018,9346) VR=SQ VM=1 CTDI Phantom Type Code Sequence</summary>
        public const uint CTDIPhantomTypeCodeSequence = 0x00189346;

        ///<summary>(0018,9351) VR=FL VM=1 Calcium Scoring Mass Factor Patient</summary>
        public const uint CalciumScoringMassFactorPatient = 0x00189351;

        ///<summary>(0018,9352) VR=FL VM=3 Calcium Scoring Mass Factor Device</summary>
        public const uint CalciumScoringMassFactorDevice = 0x00189352;

        ///<summary>(0018,9353) VR=FL VM=1 Energy Weighting Factor</summary>
        public const uint EnergyWeightingFactor = 0x00189353;

        ///<summary>(0018,9360) VR=SQ VM=1 CT Additional X-Ray Source Sequence</summary>
        public const uint CTAdditionalXRaySourceSequence = 0x00189360;

        ///<summary>(0018,9361) VR=CS VM=1 Multi-energy CT Acquisition</summary>
        public const uint MultienergyCTAcquisition = 0x00189361;

        ///<summary>(0018,9362) VR=SQ VM=1 Multi-energy CT Acquisition Sequence</summary>
        public const uint MultienergyCTAcquisitionSequence = 0x00189362;

        ///<summary>(0018,9363) VR=SQ VM=1 Multi-energy CT Processing Sequence</summary>
        public const uint MultienergyCTProcessingSequence = 0x00189363;

        ///<summary>(0018,9364) VR=SQ VM=1 Multi-energy CT Characteristics Sequence</summary>
        public const uint MultienergyCTCharacteristicsSequence = 0x00189364;

        ///<summary>(0018,9365) VR=SQ VM=1 Multi-energy CT X-Ray Source Sequence</summary>
        public const uint MultienergyCTXRaySourceSequence = 0x00189365;

        ///<summary>(0018,9366) VR=US VM=1 X-Ray Source Index</summary>
        public const uint XRaySourceIndex = 0x00189366;

        ///<summary>(0018,9367) VR=UC VM=1 X-Ray Source Id</summary>
        public const uint XRaySourceId = 0x00189367;

        ///<summary>(0018,9368) VR=CS VM=1 Multi-energy Source Technique</summary>
        public const uint MultienergySourceTechnique = 0x00189368;

        ///<summary>(0018,9369) VR=DT VM=1 Source Start DateTime</summary>
        public const uint SourceStartDateTime = 0x00189369;

        ///<summary>(0018,936A) VR=DT VM=1 Source End DateTime</summary>
        public const uint SourceEndDateTime = 0x0018936A;

        ///<summary>(0018,936B) VR=US VM=1 Switching Phase Number</summary>
        public const uint SwitchingPhaseNumber = 0x0018936B;

        ///<summary>(0018,936C) VR=DS VM=1 Switching Phase Nominal Duration</summary>
        public const uint SwitchingPhaseNominalDuration = 0x0018936C;

        ///<summary>(0018,936D) VR=DS VM=1 Switching Phase Transition Duration</summary>
        public const uint SwitchingPhaseTransitionDuration = 0x0018936D;

        ///<summary>(0018,936E) VR=DS VM=1 Effective Bin Energy</summary>
        public const uint EffectiveBinEnergy = 0x0018936E;

        ///<summary>(0018,936F) VR=SQ VM=1 Multi-energy CT X-Ray Detector Sequence</summary>
        public const uint MultienergyCTXRayDetectorSequence = 0x0018936F;

        ///<summary>(0018,9370) VR=US VM=1 X-Ray Detector Index</summary>
        public const uint XRayDetectorIndex = 0x00189370;

        ///<summary>(0018,9371) VR=UC VM=1 X-Ray Detector Id</summary>
        public const uint XRayDetectorId = 0x00189371;

        ///<summary>(0018,9372) VR=CS VM=1 Multi-energy Detector Type</summary>
        public const uint MultienergyDetectorType = 0x00189372;

        ///<summary>(0018,9373) VR=ST VM=1 X-Ray Detector Label</summary>
        public const uint XRayDetectorLabel = 0x00189373;

        ///<summary>(0018,9374) VR=DS VM=1 Nominal Max Energy</summary>
        public const uint NominalMaxEnergy = 0x00189374;

        ///<summary>(0018,9375) VR=DS VM=1 Nominal Min Energy</summary>
        public const uint NominalMinEnergy = 0x00189375;

        ///<summary>(0018,9376) VR=US VM=1-n Referenced X-Ray Detector Index</summary>
        public const uint ReferencedXRayDetectorIndex = 0x00189376;

        ///<summary>(0018,9377) VR=US VM=1-n Referenced X-Ray Source Index</summary>
        public const uint ReferencedXRaySourceIndex = 0x00189377;

        ///<summary>(0018,9378) VR=US VM=1-n Referenced Path Index</summary>
        public const uint ReferencedPathIndex = 0x00189378;

        ///<summary>(0018,9379) VR=SQ VM=1 Multi-energy CT Path Sequence</summary>
        public const uint MultienergyCTPathSequence = 0x00189379;

        ///<summary>(0018,937A) VR=US VM=1 Multi-energy CT Path Index</summary>
        public const uint MultienergyCTPathIndex = 0x0018937A;

        ///<summary>(0018,937B) VR=UT VM=1 Multi-energy Acquisition Description</summary>
        public const uint MultienergyAcquisitionDescription = 0x0018937B;

        ///<summary>(0018,937C) VR=FD VM=1 Monoenergetic Energy Equivalent</summary>
        public const uint MonoenergeticEnergyEquivalent = 0x0018937C;

        ///<summary>(0018,937D) VR=SQ VM=1 Material Code Sequence</summary>
        public const uint MaterialCodeSequence = 0x0018937D;

        ///<summary>(0018,937E) VR=CS VM=1 Decomposition Method</summary>
        public const uint DecompositionMethod = 0x0018937E;

        ///<summary>(0018,937F) VR=UT VM=1 Decomposition Description</summary>
        public const uint DecompositionDescription = 0x0018937F;

        ///<summary>(0018,9380) VR=SQ VM=1 Decomposition Algorithm Identification Sequence</summary>
        public const uint DecompositionAlgorithmIdentificationSequence = 0x00189380;

        ///<summary>(0018,9381) VR=SQ VM=1 Decomposition Material Sequence</summary>
        public const uint DecompositionMaterialSequence = 0x00189381;

        ///<summary>(0018,9382) VR=SQ VM=1 Material Attenuation Sequence</summary>
        public const uint MaterialAttenuationSequence = 0x00189382;

        ///<summary>(0018,9383) VR=DS VM=1 Photon Energy</summary>
        public const uint PhotonEnergy = 0x00189383;

        ///<summary>(0018,9384) VR=DS VM=1 X-Ray Mass Attenuation Coefficient</summary>
        public const uint XRayMassAttenuationCoefficient = 0x00189384;

        ///<summary>(0018,9401) VR=SQ VM=1 Projection Pixel Calibration Sequence</summary>
        public const uint ProjectionPixelCalibrationSequence = 0x00189401;

        ///<summary>(0018,9402) VR=FL VM=1 Distance Source to Isocenter</summary>
        public const uint DistanceSourceToIsocenter = 0x00189402;

        ///<summary>(0018,9403) VR=FL VM=1 Distance Object to Table Top</summary>
        public const uint DistanceObjectToTableTop = 0x00189403;

        ///<summary>(0018,9404) VR=FL VM=2 Object Pixel Spacing in Center of Beam</summary>
        public const uint ObjectPixelSpacingInCenterOfBeam = 0x00189404;

        ///<summary>(0018,9405) VR=SQ VM=1 Positioner Position Sequence</summary>
        public const uint PositionerPositionSequence = 0x00189405;

        ///<summary>(0018,9406) VR=SQ VM=1 Table Position Sequence</summary>
        public const uint TablePositionSequence = 0x00189406;

        ///<summary>(0018,9407) VR=SQ VM=1 Collimator Shape Sequence</summary>
        public const uint CollimatorShapeSequence = 0x00189407;

        ///<summary>(0018,9410) VR=CS VM=1 Planes in Acquisition</summary>
        public const uint PlanesInAcquisition = 0x00189410;

        ///<summary>(0018,9412) VR=SQ VM=1 XA/XRF Frame Characteristics Sequence</summary>
        public const uint XAXRFFrameCharacteristicsSequence = 0x00189412;

        ///<summary>(0018,9417) VR=SQ VM=1 Frame Acquisition Sequence</summary>
        public const uint FrameAcquisitionSequence = 0x00189417;

        ///<summary>(0018,9420) VR=CS VM=1 X-Ray Receptor Type</summary>
        public const uint XRayReceptorType = 0x00189420;

        ///<summary>(0018,9423) VR=LO VM=1 Acquisition Protocol Name</summary>
        public const uint AcquisitionProtocolName = 0x00189423;

        ///<summary>(0018,9424) VR=LT VM=1 Acquisition Protocol Description</summary>
        public const uint AcquisitionProtocolDescription = 0x00189424;

        ///<summary>(0018,9425) VR=CS VM=1 Contrast/Bolus Ingredient Opaque</summary>
        public const uint ContrastBolusIngredientOpaque = 0x00189425;

        ///<summary>(0018,9426) VR=FL VM=1 Distance Receptor Plane to Detector Housing</summary>
        public const uint DistanceReceptorPlaneToDetectorHousing = 0x00189426;

        ///<summary>(0018,9427) VR=CS VM=1 Intensifier Active Shape</summary>
        public const uint IntensifierActiveShape = 0x00189427;

        ///<summary>(0018,9428) VR=FL VM=1-2 Intensifier Active Dimension(s)</summary>
        public const uint IntensifierActiveDimensions = 0x00189428;

        ///<summary>(0018,9429) VR=FL VM=2 Physical Detector Size</summary>
        public const uint PhysicalDetectorSize = 0x00189429;

        ///<summary>(0018,9430) VR=FL VM=2 Position of Isocenter Projection</summary>
        public const uint PositionOfIsocenterProjection = 0x00189430;

        ///<summary>(0018,9432) VR=SQ VM=1 Field of View Sequence</summary>
        public const uint FieldOfViewSequence = 0x00189432;

        ///<summary>(0018,9433) VR=LO VM=1 Field of View Description</summary>
        public const uint FieldOfViewDescription = 0x00189433;

        ///<summary>(0018,9434) VR=SQ VM=1 Exposure Control Sensing Regions Sequence</summary>
        public const uint ExposureControlSensingRegionsSequence = 0x00189434;

        ///<summary>(0018,9435) VR=CS VM=1 Exposure Control Sensing Region Shape</summary>
        public const uint ExposureControlSensingRegionShape = 0x00189435;

        ///<summary>(0018,9436) VR=SS VM=1 Exposure Control Sensing Region Left Vertical Edge</summary>
        public const uint ExposureControlSensingRegionLeftVerticalEdge = 0x00189436;

        ///<summary>(0018,9437) VR=SS VM=1 Exposure Control Sensing Region Right Vertical Edge</summary>
        public const uint ExposureControlSensingRegionRightVerticalEdge = 0x00189437;

        ///<summary>(0018,9438) VR=SS VM=1 Exposure Control Sensing Region Upper Horizontal Edge</summary>
        public const uint ExposureControlSensingRegionUpperHorizontalEdge = 0x00189438;

        ///<summary>(0018,9439) VR=SS VM=1 Exposure Control Sensing Region Lower Horizontal Edge</summary>
        public const uint ExposureControlSensingRegionLowerHorizontalEdge = 0x00189439;

        ///<summary>(0018,9440) VR=SS VM=2 Center of Circular Exposure Control Sensing Region</summary>
        public const uint CenterOfCircularExposureControlSensingRegion = 0x00189440;

        ///<summary>(0018,9441) VR=US VM=1 Radius of Circular Exposure Control Sensing Region</summary>
        public const uint RadiusOfCircularExposureControlSensingRegion = 0x00189441;

        ///<summary>(0018,9442) VR=SS VM=2-n Vertices of the Polygonal Exposure Control Sensing Region</summary>
        public const uint VerticesOfThePolygonalExposureControlSensingRegion = 0x00189442;

        ///<summary>(0018,9447) VR=FL VM=1 Column Angulation (Patient)</summary>
        public const uint ColumnAngulationPatient = 0x00189447;

        ///<summary>(0018,9449) VR=FL VM=1 Beam Angle</summary>
        public const uint BeamAngle = 0x00189449;

        ///<summary>(0018,9451) VR=SQ VM=1 Frame Detector Parameters Sequence</summary>
        public const uint FrameDetectorParametersSequence = 0x00189451;

        ///<summary>(0018,9452) VR=FL VM=1 Calculated Anatomy Thickness</summary>
        public const uint CalculatedAnatomyThickness = 0x00189452;

        ///<summary>(0018,9455) VR=SQ VM=1 Calibration Sequence</summary>
        public const uint CalibrationSequence = 0x00189455;

        ///<summary>(0018,9456) VR=SQ VM=1 Object Thickness Sequence</summary>
        public const uint ObjectThicknessSequence = 0x00189456;

        ///<summary>(0018,9457) VR=CS VM=1 Plane Identification</summary>
        public const uint PlaneIdentification = 0x00189457;

        ///<summary>(0018,9461) VR=FL VM=1-2 Field of View Dimension(s) in Float</summary>
        public const uint FieldOfViewDimensionsInFloat = 0x00189461;

        ///<summary>(0018,9462) VR=SQ VM=1 Isocenter Reference System Sequence</summary>
        public const uint IsocenterReferenceSystemSequence = 0x00189462;

        ///<summary>(0018,9463) VR=FL VM=1 Positioner Isocenter Primary Angle</summary>
        public const uint PositionerIsocenterPrimaryAngle = 0x00189463;

        ///<summary>(0018,9464) VR=FL VM=1 Positioner Isocenter Secondary Angle</summary>
        public const uint PositionerIsocenterSecondaryAngle = 0x00189464;

        ///<summary>(0018,9465) VR=FL VM=1 Positioner Isocenter Detector Rotation Angle</summary>
        public const uint PositionerIsocenterDetectorRotationAngle = 0x00189465;

        ///<summary>(0018,9466) VR=FL VM=1 Table X Position to Isocenter</summary>
        public const uint TableXPositionToIsocenter = 0x00189466;

        ///<summary>(0018,9467) VR=FL VM=1 Table Y Position to Isocenter</summary>
        public const uint TableYPositionToIsocenter = 0x00189467;

        ///<summary>(0018,9468) VR=FL VM=1 Table Z Position to Isocenter</summary>
        public const uint TableZPositionToIsocenter = 0x00189468;

        ///<summary>(0018,9469) VR=FL VM=1 Table Horizontal Rotation Angle</summary>
        public const uint TableHorizontalRotationAngle = 0x00189469;

        ///<summary>(0018,9470) VR=FL VM=1 Table Head Tilt Angle</summary>
        public const uint TableHeadTiltAngle = 0x00189470;

        ///<summary>(0018,9471) VR=FL VM=1 Table Cradle Tilt Angle</summary>
        public const uint TableCradleTiltAngle = 0x00189471;

        ///<summary>(0018,9472) VR=SQ VM=1 Frame Display Shutter Sequence</summary>
        public const uint FrameDisplayShutterSequence = 0x00189472;

        ///<summary>(0018,9473) VR=FL VM=1 Acquired Image Area Dose Product</summary>
        public const uint AcquiredImageAreaDoseProduct = 0x00189473;

        ///<summary>(0018,9474) VR=CS VM=1 C-arm Positioner Tabletop Relationship</summary>
        public const uint CArmPositionerTabletopRelationship = 0x00189474;

        ///<summary>(0018,9476) VR=SQ VM=1 X-Ray Geometry Sequence</summary>
        public const uint XRayGeometrySequence = 0x00189476;

        ///<summary>(0018,9477) VR=SQ VM=1 Irradiation Event Identification Sequence</summary>
        public const uint IrradiationEventIdentificationSequence = 0x00189477;

        ///<summary>(0018,9504) VR=SQ VM=1 X-Ray 3D Frame Type Sequence</summary>
        public const uint XRay3DFrameTypeSequence = 0x00189504;

        ///<summary>(0018,9506) VR=SQ VM=1 Contributing Sources Sequence</summary>
        public const uint ContributingSourcesSequence = 0x00189506;

        ///<summary>(0018,9507) VR=SQ VM=1 X-Ray 3D Acquisition Sequence</summary>
        public const uint XRay3DAcquisitionSequence = 0x00189507;

        ///<summary>(0018,9508) VR=FL VM=1 Primary Positioner Scan Arc</summary>
        public const uint PrimaryPositionerScanArc = 0x00189508;

        ///<summary>(0018,9509) VR=FL VM=1 Secondary Positioner Scan Arc</summary>
        public const uint SecondaryPositionerScanArc = 0x00189509;

        ///<summary>(0018,9510) VR=FL VM=1 Primary Positioner Scan Start Angle</summary>
        public const uint PrimaryPositionerScanStartAngle = 0x00189510;

        ///<summary>(0018,9511) VR=FL VM=1 Secondary Positioner Scan Start Angle</summary>
        public const uint SecondaryPositionerScanStartAngle = 0x00189511;

        ///<summary>(0018,9514) VR=FL VM=1 Primary Positioner Increment</summary>
        public const uint PrimaryPositionerIncrement = 0x00189514;

        ///<summary>(0018,9515) VR=FL VM=1 Secondary Positioner Increment</summary>
        public const uint SecondaryPositionerIncrement = 0x00189515;

        ///<summary>(0018,9516) VR=DT VM=1 Start Acquisition DateTime</summary>
        public const uint StartAcquisitionDateTime = 0x00189516;

        ///<summary>(0018,9517) VR=DT VM=1 End Acquisition DateTime</summary>
        public const uint EndAcquisitionDateTime = 0x00189517;

        ///<summary>(0018,9518) VR=SS VM=1 Primary Positioner Increment Sign</summary>
        public const uint PrimaryPositionerIncrementSign = 0x00189518;

        ///<summary>(0018,9519) VR=SS VM=1 Secondary Positioner Increment Sign</summary>
        public const uint SecondaryPositionerIncrementSign = 0x00189519;

        ///<summary>(0018,9524) VR=LO VM=1 Application Name</summary>
        public const uint ApplicationName = 0x00189524;

        ///<summary>(0018,9525) VR=LO VM=1 Application Version</summary>
        public const uint ApplicationVersion = 0x00189525;

        ///<summary>(0018,9526) VR=LO VM=1 Application Manufacturer</summary>
        public const uint ApplicationManufacturer = 0x00189526;

        ///<summary>(0018,9527) VR=CS VM=1 Algorithm Type</summary>
        public const uint AlgorithmType = 0x00189527;

        ///<summary>(0018,9528) VR=LO VM=1 Algorithm Description</summary>
        public const uint AlgorithmDescription = 0x00189528;

        ///<summary>(0018,9530) VR=SQ VM=1 X-Ray 3D Reconstruction Sequence</summary>
        public const uint XRay3DReconstructionSequence = 0x00189530;

        ///<summary>(0018,9531) VR=LO VM=1 Reconstruction Description</summary>
        public const uint ReconstructionDescription = 0x00189531;

        ///<summary>(0018,9538) VR=SQ VM=1 Per Projection Acquisition Sequence</summary>
        public const uint PerProjectionAcquisitionSequence = 0x00189538;

        ///<summary>(0018,9541) VR=SQ VM=1 Detector Position Sequence</summary>
        public const uint DetectorPositionSequence = 0x00189541;

        ///<summary>(0018,9542) VR=SQ VM=1 X-Ray Acquisition Dose Sequence</summary>
        public const uint XRayAcquisitionDoseSequence = 0x00189542;

        ///<summary>(0018,9543) VR=FD VM=1 X-Ray Source Isocenter Primary Angle</summary>
        public const uint XRaySourceIsocenterPrimaryAngle = 0x00189543;

        ///<summary>(0018,9544) VR=FD VM=1 X-Ray Source Isocenter Secondary Angle</summary>
        public const uint XRaySourceIsocenterSecondaryAngle = 0x00189544;

        ///<summary>(0018,9545) VR=FD VM=1 Breast Support Isocenter Primary Angle</summary>
        public const uint BreastSupportIsocenterPrimaryAngle = 0x00189545;

        ///<summary>(0018,9546) VR=FD VM=1 Breast Support Isocenter Secondary Angle</summary>
        public const uint BreastSupportIsocenterSecondaryAngle = 0x00189546;

        ///<summary>(0018,9547) VR=FD VM=1 Breast Support X Position to Isocenter</summary>
        public const uint BreastSupportXPositionToIsocenter = 0x00189547;

        ///<summary>(0018,9548) VR=FD VM=1 Breast Support Y Position to Isocenter</summary>
        public const uint BreastSupportYPositionToIsocenter = 0x00189548;

        ///<summary>(0018,9549) VR=FD VM=1 Breast Support Z Position to Isocenter</summary>
        public const uint BreastSupportZPositionToIsocenter = 0x00189549;

        ///<summary>(0018,9550) VR=FD VM=1 Detector Isocenter Primary Angle</summary>
        public const uint DetectorIsocenterPrimaryAngle = 0x00189550;

        ///<summary>(0018,9551) VR=FD VM=1 Detector Isocenter Secondary Angle</summary>
        public const uint DetectorIsocenterSecondaryAngle = 0x00189551;

        ///<summary>(0018,9552) VR=FD VM=1 Detector X Position to Isocenter</summary>
        public const uint DetectorXPositionToIsocenter = 0x00189552;

        ///<summary>(0018,9553) VR=FD VM=1 Detector Y Position to Isocenter</summary>
        public const uint DetectorYPositionToIsocenter = 0x00189553;

        ///<summary>(0018,9554) VR=FD VM=1 Detector Z Position to Isocenter</summary>
        public const uint DetectorZPositionToIsocenter = 0x00189554;

        ///<summary>(0018,9555) VR=SQ VM=1 X-Ray Grid Sequence</summary>
        public const uint XRayGridSequence = 0x00189555;

        ///<summary>(0018,9556) VR=SQ VM=1 X-Ray Filter Sequence</summary>
        public const uint XRayFilterSequence = 0x00189556;

        ///<summary>(0018,9557) VR=FD VM=3 Detector Active Area TLHC Position</summary>
        public const uint DetectorActiveAreaTLHCPosition = 0x00189557;

        ///<summary>(0018,9558) VR=FD VM=6 Detector Active Area Orientation</summary>
        public const uint DetectorActiveAreaOrientation = 0x00189558;

        ///<summary>(0018,9559) VR=CS VM=1 Positioner Primary Angle Direction</summary>
        public const uint PositionerPrimaryAngleDirection = 0x00189559;

        ///<summary>(0018,9601) VR=SQ VM=1 Diffusion b-matrix Sequence</summary>
        public const uint DiffusionBMatrixSequence = 0x00189601;

        ///<summary>(0018,9602) VR=FD VM=1 Diffusion b-value XX</summary>
        public const uint DiffusionBValueXX = 0x00189602;

        ///<summary>(0018,9603) VR=FD VM=1 Diffusion b-value XY</summary>
        public const uint DiffusionBValueXY = 0x00189603;

        ///<summary>(0018,9604) VR=FD VM=1 Diffusion b-value XZ</summary>
        public const uint DiffusionBValueXZ = 0x00189604;

        ///<summary>(0018,9605) VR=FD VM=1 Diffusion b-value YY</summary>
        public const uint DiffusionBValueYY = 0x00189605;

        ///<summary>(0018,9606) VR=FD VM=1 Diffusion b-value YZ</summary>
        public const uint DiffusionBValueYZ = 0x00189606;

        ///<summary>(0018,9607) VR=FD VM=1 Diffusion b-value ZZ</summary>
        public const uint DiffusionBValueZZ = 0x00189607;

        ///<summary>(0018,9621) VR=SQ VM=1 Functional MR Sequence</summary>
        public const uint FunctionalMRSequence = 0x00189621;

        ///<summary>(0018,9622) VR=CS VM=1 Functional Settling Phase Frames Present</summary>
        public const uint FunctionalSettlingPhaseFramesPresent = 0x00189622;

        ///<summary>(0018,9623) VR=DT VM=1 Functional Sync Pulse</summary>
        public const uint FunctionalSyncPulse = 0x00189623;

        ///<summary>(0018,9624) VR=CS VM=1 Settling Phase Frame</summary>
        public const uint SettlingPhaseFrame = 0x00189624;

        ///<summary>(0018,9701) VR=DT VM=1 Decay Correction DateTime</summary>
        public const uint DecayCorrectionDateTime = 0x00189701;

        ///<summary>(0018,9715) VR=FD VM=1 Start Density Threshold</summary>
        public const uint StartDensityThreshold = 0x00189715;

        ///<summary>(0018,9716) VR=FD VM=1 Start Relative Density Difference Threshold</summary>
        public const uint StartRelativeDensityDifferenceThreshold = 0x00189716;

        ///<summary>(0018,9717) VR=FD VM=1 Start Cardiac Trigger Count Threshold</summary>
        public const uint StartCardiacTriggerCountThreshold = 0x00189717;

        ///<summary>(0018,9718) VR=FD VM=1 Start Respiratory Trigger Count Threshold</summary>
        public const uint StartRespiratoryTriggerCountThreshold = 0x00189718;

        ///<summary>(0018,9719) VR=FD VM=1 Termination Counts Threshold</summary>
        public const uint TerminationCountsThreshold = 0x00189719;

        ///<summary>(0018,9720) VR=FD VM=1 Termination Density Threshold</summary>
        public const uint TerminationDensityThreshold = 0x00189720;

        ///<summary>(0018,9721) VR=FD VM=1 Termination Relative Density Threshold</summary>
        public const uint TerminationRelativeDensityThreshold = 0x00189721;

        ///<summary>(0018,9722) VR=FD VM=1 Termination Time Threshold</summary>
        public const uint TerminationTimeThreshold = 0x00189722;

        ///<summary>(0018,9723) VR=FD VM=1 Termination Cardiac Trigger Count Threshold</summary>
        public const uint TerminationCardiacTriggerCountThreshold = 0x00189723;

        ///<summary>(0018,9724) VR=FD VM=1 Termination Respiratory Trigger Count Threshold</summary>
        public const uint TerminationRespiratoryTriggerCountThreshold = 0x00189724;

        ///<summary>(0018,9725) VR=CS VM=1 Detector Geometry</summary>
        public const uint DetectorGeometry = 0x00189725;

        ///<summary>(0018,9726) VR=FD VM=1 Transverse Detector Separation</summary>
        public const uint TransverseDetectorSeparation = 0x00189726;

        ///<summary>(0018,9727) VR=FD VM=1 Axial Detector Dimension</summary>
        public const uint AxialDetectorDimension = 0x00189727;

        ///<summary>(0018,9729) VR=US VM=1 Radiopharmaceutical Agent Number</summary>
        public const uint RadiopharmaceuticalAgentNumber = 0x00189729;

        ///<summary>(0018,9732) VR=SQ VM=1 PET Frame Acquisition Sequence</summary>
        public const uint PETFrameAcquisitionSequence = 0x00189732;

        ///<summary>(0018,9733) VR=SQ VM=1 PET Detector Motion Details Sequence</summary>
        public const uint PETDetectorMotionDetailsSequence = 0x00189733;

        ///<summary>(0018,9734) VR=SQ VM=1 PET Table Dynamics Sequence</summary>
        public const uint PETTableDynamicsSequence = 0x00189734;

        ///<summary>(0018,9735) VR=SQ VM=1 PET Position Sequence</summary>
        public const uint PETPositionSequence = 0x00189735;

        ///<summary>(0018,9736) VR=SQ VM=1 PET Frame Correction Factors Sequence</summary>
        public const uint PETFrameCorrectionFactorsSequence = 0x00189736;

        ///<summary>(0018,9737) VR=SQ VM=1 Radiopharmaceutical Usage Sequence</summary>
        public const uint RadiopharmaceuticalUsageSequence = 0x00189737;

        ///<summary>(0018,9738) VR=CS VM=1 Attenuation Correction Source</summary>
        public const uint AttenuationCorrectionSource = 0x00189738;

        ///<summary>(0018,9739) VR=US VM=1 Number of Iterations</summary>
        public const uint NumberOfIterations = 0x00189739;

        ///<summary>(0018,9740) VR=US VM=1 Number of Subsets</summary>
        public const uint NumberOfSubsets = 0x00189740;

        ///<summary>(0018,9749) VR=SQ VM=1 PET Reconstruction Sequence</summary>
        public const uint PETReconstructionSequence = 0x00189749;

        ///<summary>(0018,9751) VR=SQ VM=1 PET Frame Type Sequence</summary>
        public const uint PETFrameTypeSequence = 0x00189751;

        ///<summary>(0018,9755) VR=CS VM=1 Time of Flight Information Used</summary>
        public const uint TimeOfFlightInformationUsed = 0x00189755;

        ///<summary>(0018,9756) VR=CS VM=1 Reconstruction Type</summary>
        public const uint ReconstructionType = 0x00189756;

        ///<summary>(0018,9758) VR=CS VM=1 Decay Corrected</summary>
        public const uint DecayCorrected = 0x00189758;

        ///<summary>(0018,9759) VR=CS VM=1 Attenuation Corrected</summary>
        public const uint AttenuationCorrected = 0x00189759;

        ///<summary>(0018,9760) VR=CS VM=1 Scatter Corrected</summary>
        public const uint ScatterCorrected = 0x00189760;

        ///<summary>(0018,9761) VR=CS VM=1 Dead Time Corrected</summary>
        public const uint DeadTimeCorrected = 0x00189761;

        ///<summary>(0018,9762) VR=CS VM=1 Gantry Motion Corrected</summary>
        public const uint GantryMotionCorrected = 0x00189762;

        ///<summary>(0018,9763) VR=CS VM=1 Patient Motion Corrected</summary>
        public const uint PatientMotionCorrected = 0x00189763;

        ///<summary>(0018,9764) VR=CS VM=1 Count Loss Normalization Corrected</summary>
        public const uint CountLossNormalizationCorrected = 0x00189764;

        ///<summary>(0018,9765) VR=CS VM=1 Randoms Corrected</summary>
        public const uint RandomsCorrected = 0x00189765;

        ///<summary>(0018,9766) VR=CS VM=1 Non-uniform Radial Sampling Corrected</summary>
        public const uint NonUniformRadialSamplingCorrected = 0x00189766;

        ///<summary>(0018,9767) VR=CS VM=1 Sensitivity Calibrated</summary>
        public const uint SensitivityCalibrated = 0x00189767;

        ///<summary>(0018,9768) VR=CS VM=1 Detector Normalization Correction</summary>
        public const uint DetectorNormalizationCorrection = 0x00189768;

        ///<summary>(0018,9769) VR=CS VM=1 Iterative Reconstruction Method</summary>
        public const uint IterativeReconstructionMethod = 0x00189769;

        ///<summary>(0018,9770) VR=CS VM=1 Attenuation Correction Temporal Relationship</summary>
        public const uint AttenuationCorrectionTemporalRelationship = 0x00189770;

        ///<summary>(0018,9771) VR=SQ VM=1 Patient Physiological State Sequence</summary>
        public const uint PatientPhysiologicalStateSequence = 0x00189771;

        ///<summary>(0018,9772) VR=SQ VM=1 Patient Physiological State Code Sequence</summary>
        public const uint PatientPhysiologicalStateCodeSequence = 0x00189772;

        ///<summary>(0018,9801) VR=FD VM=1-n Depth(s) of Focus</summary>
        public const uint DepthsOfFocus = 0x00189801;

        ///<summary>(0018,9803) VR=SQ VM=1 Excluded Intervals Sequence</summary>
        public const uint ExcludedIntervalsSequence = 0x00189803;

        ///<summary>(0018,9804) VR=DT VM=1 Exclusion Start DateTime</summary>
        public const uint ExclusionStartDateTime = 0x00189804;

        ///<summary>(0018,9805) VR=FD VM=1 Exclusion Duration</summary>
        public const uint ExclusionDuration = 0x00189805;

        ///<summary>(0018,9806) VR=SQ VM=1 US Image Description Sequence</summary>
        public const uint USImageDescriptionSequence = 0x00189806;

        ///<summary>(0018,9807) VR=SQ VM=1 Image Data Type Sequence</summary>
        public const uint ImageDataTypeSequence = 0x00189807;

        ///<summary>(0018,9808) VR=CS VM=1 Data Type</summary>
        public const uint DataType = 0x00189808;

        ///<summary>(0018,9809) VR=SQ VM=1 Transducer Scan Pattern Code Sequence</summary>
        public const uint TransducerScanPatternCodeSequence = 0x00189809;

        ///<summary>(0018,980B) VR=CS VM=1 Aliased Data Type</summary>
        public const uint AliasedDataType = 0x0018980B;

        ///<summary>(0018,980C) VR=CS VM=1 Position Measuring Device Used</summary>
        public const uint PositionMeasuringDeviceUsed = 0x0018980C;

        ///<summary>(0018,980D) VR=SQ VM=1 Transducer Geometry Code Sequence</summary>
        public const uint TransducerGeometryCodeSequence = 0x0018980D;

        ///<summary>(0018,980E) VR=SQ VM=1 Transducer Beam Steering Code Sequence</summary>
        public const uint TransducerBeamSteeringCodeSequence = 0x0018980E;

        ///<summary>(0018,980F) VR=SQ VM=1 Transducer Application Code Sequence</summary>
        public const uint TransducerApplicationCodeSequence = 0x0018980F;

        ///<summary>(0018,9810) VR=US/SS VM=1 Zero Velocity Pixel Value</summary>
        public const uint ZeroVelocityPixelValue = 0x00189810;

        ///<summary>(0018,9900) VR=LO VM=1 Reference Location Label</summary>
        public const uint ReferenceLocationLabel = 0x00189900;

        ///<summary>(0018,9901) VR=UT VM=1 Reference Location Description</summary>
        public const uint ReferenceLocationDescription = 0x00189901;

        ///<summary>(0018,9902) VR=SQ VM=1 Reference Basis Code Sequence</summary>
        public const uint ReferenceBasisCodeSequence = 0x00189902;

        ///<summary>(0018,9903) VR=SQ VM=1 Reference Geometry Code Sequence</summary>
        public const uint ReferenceGeometryCodeSequence = 0x00189903;

        ///<summary>(0018,9904) VR=DS VM=1 Offset Distance</summary>
        public const uint OffsetDistance = 0x00189904;

        ///<summary>(0018,9905) VR=CS VM=1 Offset Direction</summary>
        public const uint OffsetDirection = 0x00189905;

        ///<summary>(0018,9906) VR=SQ VM=1 Potential Scheduled Protocol Code Sequence</summary>
        public const uint PotentialScheduledProtocolCodeSequence = 0x00189906;

        ///<summary>(0018,9907) VR=SQ VM=1 Potential Requested Procedure Code Sequence</summary>
        public const uint PotentialRequestedProcedureCodeSequence = 0x00189907;

        ///<summary>(0018,9908) VR=UC VM=1-n Potential Reasons for Procedure</summary>
        public const uint PotentialReasonsForProcedure = 0x00189908;

        ///<summary>(0018,9909) VR=SQ VM=1 Potential Reasons for Procedure Code Sequence</summary>
        public const uint PotentialReasonsForProcedureCodeSequence = 0x00189909;

        ///<summary>(0018,990A) VR=UC VM=1-n Potential Diagnostic Tasks</summary>
        public const uint PotentialDiagnosticTasks = 0x0018990A;

        ///<summary>(0018,990B) VR=SQ VM=1 Contraindications Code Sequence</summary>
        public const uint ContraindicationsCodeSequence = 0x0018990B;

        ///<summary>(0018,990C) VR=SQ VM=1 Referenced Defined Protocol Sequence</summary>
        public const uint ReferencedDefinedProtocolSequence = 0x0018990C;

        ///<summary>(0018,990D) VR=SQ VM=1 Referenced Performed Protocol Sequence</summary>
        public const uint ReferencedPerformedProtocolSequence = 0x0018990D;

        ///<summary>(0018,990E) VR=SQ VM=1 Predecessor Protocol Sequence</summary>
        public const uint PredecessorProtocolSequence = 0x0018990E;

        ///<summary>(0018,990F) VR=UT VM=1 Protocol Planning Information</summary>
        public const uint ProtocolPlanningInformation = 0x0018990F;

        ///<summary>(0018,9910) VR=UT VM=1 Protocol Design Rationale</summary>
        public const uint ProtocolDesignRationale = 0x00189910;

        ///<summary>(0018,9911) VR=SQ VM=1 Patient Specification Sequence</summary>
        public const uint PatientSpecificationSequence = 0x00189911;

        ///<summary>(0018,9912) VR=SQ VM=1 Model Specification Sequence</summary>
        public const uint ModelSpecificationSequence = 0x00189912;

        ///<summary>(0018,9913) VR=SQ VM=1 Parameters Specification Sequence</summary>
        public const uint ParametersSpecificationSequence = 0x00189913;

        ///<summary>(0018,9914) VR=SQ VM=1 Instruction Sequence</summary>
        public const uint InstructionSequence = 0x00189914;

        ///<summary>(0018,9915) VR=US VM=1 Instruction Index</summary>
        public const uint InstructionIndex = 0x00189915;

        ///<summary>(0018,9916) VR=LO VM=1 Instruction Text</summary>
        public const uint InstructionText = 0x00189916;

        ///<summary>(0018,9917) VR=UT VM=1 Instruction Description</summary>
        public const uint InstructionDescription = 0x00189917;

        ///<summary>(0018,9918) VR=CS VM=1 Instruction Performed Flag</summary>
        public const uint InstructionPerformedFlag = 0x00189918;

        ///<summary>(0018,9919) VR=DT VM=1 Instruction Performed DateTime</summary>
        public const uint InstructionPerformedDateTime = 0x00189919;

        ///<summary>(0018,991A) VR=UT VM=1 Instruction Performance Comment</summary>
        public const uint InstructionPerformanceComment = 0x0018991A;

        ///<summary>(0018,991B) VR=SQ VM=1 Patient Positioning Instruction Sequence</summary>
        public const uint PatientPositioningInstructionSequence = 0x0018991B;

        ///<summary>(0018,991C) VR=SQ VM=1 Positioning Method Code Sequence</summary>
        public const uint PositioningMethodCodeSequence = 0x0018991C;

        ///<summary>(0018,991D) VR=SQ VM=1 Positioning Landmark Sequence</summary>
        public const uint PositioningLandmarkSequence = 0x0018991D;

        ///<summary>(0018,991E) VR=UI VM=1 Target Frame of Reference Uid</summary>
        public const uint TargetFrameOfReferenceUid = 0x0018991E;

        ///<summary>(0018,991F) VR=SQ VM=1 Acquisition Protocol Element Specification Sequence</summary>
        public const uint AcquisitionProtocolElementSpecificationSequence = 0x0018991F;

        ///<summary>(0018,9920) VR=SQ VM=1 Acquisition Protocol Element Sequence</summary>
        public const uint AcquisitionProtocolElementSequence = 0x00189920;

        ///<summary>(0018,9921) VR=US VM=1 Protocol Element Number</summary>
        public const uint ProtocolElementNumber = 0x00189921;

        ///<summary>(0018,9922) VR=LO VM=1 Protocol Element Name</summary>
        public const uint ProtocolElementName = 0x00189922;

        ///<summary>(0018,9923) VR=UT VM=1 Protocol Element Characteristics Summary</summary>
        public const uint ProtocolElementCharacteristicsSummary = 0x00189923;

        ///<summary>(0018,9924) VR=UT VM=1 Protocol Element Purpose</summary>
        public const uint ProtocolElementPurpose = 0x00189924;

        ///<summary>(0018,9930) VR=CS VM=1 Acquisition Motion</summary>
        public const uint AcquisitionMotion = 0x00189930;

        ///<summary>(0018,9931) VR=SQ VM=1 Acquisition Start Location Sequence</summary>
        public const uint AcquisitionStartLocationSequence = 0x00189931;

        ///<summary>(0018,9932) VR=SQ VM=1 Acquisition End Location Sequence</summary>
        public const uint AcquisitionEndLocationSequence = 0x00189932;

        ///<summary>(0018,9933) VR=SQ VM=1 Reconstruction Protocol Element Specification Sequence</summary>
        public const uint ReconstructionProtocolElementSpecificationSequence = 0x00189933;

        ///<summary>(0018,9934) VR=SQ VM=1 Reconstruction Protocol Element Sequence</summary>
        public const uint ReconstructionProtocolElementSequence = 0x00189934;

        ///<summary>(0018,9935) VR=SQ VM=1 Storage Protocol Element Specification Sequence</summary>
        public const uint StorageProtocolElementSpecificationSequence = 0x00189935;

        ///<summary>(0018,9936) VR=SQ VM=1 Storage Protocol Element Sequence</summary>
        public const uint StorageProtocolElementSequence = 0x00189936;

        ///<summary>(0018,9937) VR=LO VM=1 Requested Series Description</summary>
        public const uint RequestedSeriesDescription = 0x00189937;

        ///<summary>(0018,9938) VR=US VM=1-n Source Acquisition Protocol Element Number</summary>
        public const uint SourceAcquisitionProtocolElementNumber = 0x00189938;

        ///<summary>(0018,9939) VR=US VM=1-n Source Acquisition Beam Number</summary>
        public const uint SourceAcquisitionBeamNumber = 0x00189939;

        ///<summary>(0018,993A) VR=US VM=1-n Source Reconstruction Protocol Element Number</summary>
        public const uint SourceReconstructionProtocolElementNumber = 0x0018993A;

        ///<summary>(0018,993B) VR=SQ VM=1 Reconstruction Start Location Sequence</summary>
        public const uint ReconstructionStartLocationSequence = 0x0018993B;

        ///<summary>(0018,993C) VR=SQ VM=1 Reconstruction End Location Sequence</summary>
        public const uint ReconstructionEndLocationSequence = 0x0018993C;

        ///<summary>(0018,993D) VR=SQ VM=1 Reconstruction Algorithm Sequence</summary>
        public const uint ReconstructionAlgorithmSequence = 0x0018993D;

        ///<summary>(0018,993E) VR=SQ VM=1 Reconstruction Target Center Location Sequence</summary>
        public const uint ReconstructionTargetCenterLocationSequence = 0x0018993E;

        ///<summary>(0018,9941) VR=UT VM=1 Image Filter Description</summary>
        public const uint ImageFilterDescription = 0x00189941;

        ///<summary>(0018,9942) VR=FD VM=1 CTDIvol Notification Trigger</summary>
        public const uint CTDIvolNotificationTrigger = 0x00189942;

        ///<summary>(0018,9943) VR=FD VM=1 DLP Notification Trigger</summary>
        public const uint DLPNotificationTrigger = 0x00189943;

        ///<summary>(0018,9944) VR=CS VM=1 Auto KVP Selection Type</summary>
        public const uint AutoKVPSelectionType = 0x00189944;

        ///<summary>(0018,9945) VR=FD VM=1 Auto KVP Upper Bound</summary>
        public const uint AutoKVPUpperBound = 0x00189945;

        ///<summary>(0018,9946) VR=FD VM=1 Auto KVP Lower Bound</summary>
        public const uint AutoKVPLowerBound = 0x00189946;

        ///<summary>(0018,9947) VR=CS VM=1 Protocol Defined Patient Position</summary>
        public const uint ProtocolDefinedPatientPosition = 0x00189947;

        ///<summary>(0018,A001) VR=SQ VM=1 Contributing Equipment Sequence</summary>
        public const uint ContributingEquipmentSequence = 0x0018A001;

        ///<summary>(0018,A002) VR=DT VM=1 Contribution DateTime</summary>
        public const uint ContributionDateTime = 0x0018A002;

        ///<summary>(0018,A003) VR=ST VM=1 Contribution Description</summary>
        public const uint ContributionDescription = 0x0018A003;

        ///<summary>(0020,000D) VR=UI VM=1 Study Instance Uid</summary>
        public const uint StudyInstanceUid = 0x0020000D;

        ///<summary>(0020,000E) VR=UI VM=1 Series Instance Uid</summary>
        public const uint SeriesInstanceUid = 0x0020000E;

        ///<summary>(0020,0010) VR=SH VM=1 Study Id</summary>
        public const uint StudyId = 0x00200010;

        ///<summary>(0020,0011) VR=IS VM=1 Series Number</summary>
        public const uint SeriesNumber = 0x00200011;

        ///<summary>(0020,0012) VR=IS VM=1 Acquisition Number</summary>
        public const uint AcquisitionNumber = 0x00200012;

        ///<summary>(0020,0013) VR=IS VM=1 Instance Number</summary>
        public const uint InstanceNumber = 0x00200013;

        ///<summary>(0020,0014) VR=IS VM=1 Isotope Number (RETIRED)</summary>
        public const uint IsotopeNumberRETIRED = 0x00200014;

        ///<summary>(0020,0015) VR=IS VM=1 Phase Number (RETIRED)</summary>
        public const uint PhaseNumberRETIRED = 0x00200015;

        ///<summary>(0020,0016) VR=IS VM=1 Interval Number (RETIRED)</summary>
        public const uint IntervalNumberRETIRED = 0x00200016;

        ///<summary>(0020,0017) VR=IS VM=1 Time Slot Number (RETIRED)</summary>
        public const uint TimeSlotNumberRETIRED = 0x00200017;

        ///<summary>(0020,0018) VR=IS VM=1 Angle Number (RETIRED)</summary>
        public const uint AngleNumberRETIRED = 0x00200018;

        ///<summary>(0020,0019) VR=IS VM=1 Item Number</summary>
        public const uint ItemNumber = 0x00200019;

        ///<summary>(0020,0020) VR=CS VM=2 Patient Orientation</summary>
        public const uint PatientOrientation = 0x00200020;

        ///<summary>(0020,0022) VR=IS VM=1 Overlay Number (RETIRED)</summary>
        public const uint OverlayNumberRETIRED = 0x00200022;

        ///<summary>(0020,0024) VR=IS VM=1 Curve Number (RETIRED)</summary>
        public const uint CurveNumberRETIRED = 0x00200024;

        ///<summary>(0020,0026) VR=IS VM=1 LUT Number (RETIRED)</summary>
        public const uint LUTNumberRETIRED = 0x00200026;

        ///<summary>(0020,0030) VR=DS VM=3 Image Position (RETIRED)</summary>
        public const uint ImagePositionRETIRED = 0x00200030;

        ///<summary>(0020,0032) VR=DS VM=3 Image Position (Patient)</summary>
        public const uint ImagePositionPatient = 0x00200032;

        ///<summary>(0020,0035) VR=DS VM=6 Image Orientation (RETIRED)</summary>
        public const uint ImageOrientationRETIRED = 0x00200035;

        ///<summary>(0020,0037) VR=DS VM=6 Image Orientation (Patient)</summary>
        public const uint ImageOrientationPatient = 0x00200037;

        ///<summary>(0020,0050) VR=DS VM=1 Location (RETIRED)</summary>
        public const uint LocationRETIRED = 0x00200050;

        ///<summary>(0020,0052) VR=UI VM=1 Frame of Reference Uid</summary>
        public const uint FrameOfReferenceUid = 0x00200052;

        ///<summary>(0020,0060) VR=CS VM=1 Laterality</summary>
        public const uint Laterality = 0x00200060;

        ///<summary>(0020,0062) VR=CS VM=1 Image Laterality</summary>
        public const uint ImageLaterality = 0x00200062;

        ///<summary>(0020,0070) VR=LO VM=1 Image Geometry Type (RETIRED)</summary>
        public const uint ImageGeometryTypeRETIRED = 0x00200070;

        ///<summary>(0020,0080) VR=CS VM=1-n Masking Image (RETIRED)</summary>
        public const uint MaskingImageRETIRED = 0x00200080;

        ///<summary>(0020,00AA) VR=IS VM=1 Report Number (RETIRED)</summary>
        public const uint ReportNumberRETIRED = 0x002000AA;

        ///<summary>(0020,0100) VR=IS VM=1 Temporal Position Identifier</summary>
        public const uint TemporalPositionIdentifier = 0x00200100;

        ///<summary>(0020,0105) VR=IS VM=1 Number of Temporal Positions</summary>
        public const uint NumberOfTemporalPositions = 0x00200105;

        ///<summary>(0020,0110) VR=DS VM=1 Temporal Resolution</summary>
        public const uint TemporalResolution = 0x00200110;

        ///<summary>(0020,0200) VR=UI VM=1 Synchronization Frame of Reference Uid</summary>
        public const uint SynchronizationFrameOfReferenceUid = 0x00200200;

        ///<summary>(0020,0242) VR=UI VM=1 Sop Instance Uid of Concatenation Source</summary>
        public const uint SopInstanceUidOfConcatenationSource = 0x00200242;

        ///<summary>(0020,1000) VR=IS VM=1 Series in Study (RETIRED)</summary>
        public const uint SeriesInStudyRETIRED = 0x00201000;

        ///<summary>(0020,1001) VR=IS VM=1 Acquisitions in Series (RETIRED)</summary>
        public const uint AcquisitionsInSeriesRETIRED = 0x00201001;

        ///<summary>(0020,1002) VR=IS VM=1 Images in Acquisition</summary>
        public const uint ImagesInAcquisition = 0x00201002;

        ///<summary>(0020,1003) VR=IS VM=1 Images in Series (RETIRED)</summary>
        public const uint ImagesInSeriesRETIRED = 0x00201003;

        ///<summary>(0020,1004) VR=IS VM=1 Acquisitions in Study (RETIRED)</summary>
        public const uint AcquisitionsInStudyRETIRED = 0x00201004;

        ///<summary>(0020,1005) VR=IS VM=1 Images in Study (RETIRED)</summary>
        public const uint ImagesInStudyRETIRED = 0x00201005;

        ///<summary>(0020,1020) VR=LO VM=1-n Reference (RETIRED)</summary>
        public const uint ReferenceRETIRED = 0x00201020;

        ///<summary>(0020,103F) VR=LO VM=1 Target Position Reference Indicator</summary>
        public const uint TargetPositionReferenceIndicator = 0x0020103F;

        ///<summary>(0020,1040) VR=LO VM=1 Position Reference Indicator</summary>
        public const uint PositionReferenceIndicator = 0x00201040;

        ///<summary>(0020,1041) VR=DS VM=1 Slice Location</summary>
        public const uint SliceLocation = 0x00201041;

        ///<summary>(0020,1070) VR=IS VM=1-n Other Study Numbers (RETIRED)</summary>
        public const uint OtherStudyNumbersRETIRED = 0x00201070;

        ///<summary>(0020,1200) VR=IS VM=1 Number of Patient Related Studies</summary>
        public const uint NumberOfPatientRelatedStudies = 0x00201200;

        ///<summary>(0020,1202) VR=IS VM=1 Number of Patient Related Series</summary>
        public const uint NumberOfPatientRelatedSeries = 0x00201202;

        ///<summary>(0020,1204) VR=IS VM=1 Number of Patient Related Instances</summary>
        public const uint NumberOfPatientRelatedInstances = 0x00201204;

        ///<summary>(0020,1206) VR=IS VM=1 Number of Study Related Series</summary>
        public const uint NumberOfStudyRelatedSeries = 0x00201206;

        ///<summary>(0020,1208) VR=IS VM=1 Number of Study Related Instances</summary>
        public const uint NumberOfStudyRelatedInstances = 0x00201208;

        ///<summary>(0020,1209) VR=IS VM=1 Number of Series Related Instances</summary>
        public const uint NumberOfSeriesRelatedInstances = 0x00201209;

        ///<summary>(0020,31xx) VR=CS VM=1-n Source Image Ids (RETIRED)</summary>
        public const uint SourceImageIdsRETIRED = 0x00203100;

        ///<summary>(0020,3401) VR=CS VM=1 Modifying Device Id (RETIRED)</summary>
        public const uint ModifyingDeviceIdRETIRED = 0x00203401;

        ///<summary>(0020,3402) VR=CS VM=1 Modified Image Id (RETIRED)</summary>
        public const uint ModifiedImageIdRETIRED = 0x00203402;

        ///<summary>(0020,3403) VR=DA VM=1 Modified Image Date (RETIRED)</summary>
        public const uint ModifiedImageDateRETIRED = 0x00203403;

        ///<summary>(0020,3404) VR=LO VM=1 Modifying Device Manufacturer (RETIRED)</summary>
        public const uint ModifyingDeviceManufacturerRETIRED = 0x00203404;

        ///<summary>(0020,3405) VR=TM VM=1 Modified Image Time (RETIRED)</summary>
        public const uint ModifiedImageTimeRETIRED = 0x00203405;

        ///<summary>(0020,3406) VR=LO VM=1 Modified Image Description (RETIRED)</summary>
        public const uint ModifiedImageDescriptionRETIRED = 0x00203406;

        ///<summary>(0020,4000) VR=LT VM=1 Image Comments</summary>
        public const uint ImageComments = 0x00204000;

        ///<summary>(0020,5000) VR=AT VM=1-n Original Image Identification (RETIRED)</summary>
        public const uint OriginalImageIdentificationRETIRED = 0x00205000;

        ///<summary>(0020,5002) VR=LO VM=1-n Original Image Identification Nomenclature (RETIRED)</summary>
        public const uint OriginalImageIdentificationNomenclatureRETIRED = 0x00205002;

        ///<summary>(0020,9056) VR=SH VM=1 Stack Id</summary>
        public const uint StackId = 0x00209056;

        ///<summary>(0020,9057) VR=UL VM=1 In-Stack Position Number</summary>
        public const uint InStackPositionNumber = 0x00209057;

        ///<summary>(0020,9071) VR=SQ VM=1 Frame Anatomy Sequence</summary>
        public const uint FrameAnatomySequence = 0x00209071;

        ///<summary>(0020,9072) VR=CS VM=1 Frame Laterality</summary>
        public const uint FrameLaterality = 0x00209072;

        ///<summary>(0020,9111) VR=SQ VM=1 Frame Content Sequence</summary>
        public const uint FrameContentSequence = 0x00209111;

        ///<summary>(0020,9113) VR=SQ VM=1 Plane Position Sequence</summary>
        public const uint PlanePositionSequence = 0x00209113;

        ///<summary>(0020,9116) VR=SQ VM=1 Plane Orientation Sequence</summary>
        public const uint PlaneOrientationSequence = 0x00209116;

        ///<summary>(0020,9128) VR=UL VM=1 Temporal Position Index</summary>
        public const uint TemporalPositionIndex = 0x00209128;

        ///<summary>(0020,9153) VR=FD VM=1 Nominal Cardiac Trigger Delay Time</summary>
        public const uint NominalCardiacTriggerDelayTime = 0x00209153;

        ///<summary>(0020,9154) VR=FL VM=1 Nominal Cardiac Trigger Time Prior To R-Peak</summary>
        public const uint NominalCardiacTriggerTimePriorToRPeak = 0x00209154;

        ///<summary>(0020,9155) VR=FL VM=1 Actual Cardiac Trigger Time Prior To R-Peak</summary>
        public const uint ActualCardiacTriggerTimePriorToRPeak = 0x00209155;

        ///<summary>(0020,9156) VR=US VM=1 Frame Acquisition Number</summary>
        public const uint FrameAcquisitionNumber = 0x00209156;

        ///<summary>(0020,9157) VR=UL VM=1-n Dimension Index Values</summary>
        public const uint DimensionIndexValues = 0x00209157;

        ///<summary>(0020,9158) VR=LT VM=1 Frame Comments</summary>
        public const uint FrameComments = 0x00209158;

        ///<summary>(0020,9161) VR=UI VM=1 Concatenation Uid</summary>
        public const uint ConcatenationUid = 0x00209161;

        ///<summary>(0020,9162) VR=US VM=1 In-concatenation Number</summary>
        public const uint InConcatenationNumber = 0x00209162;

        ///<summary>(0020,9163) VR=US VM=1 In-concatenation Total Number</summary>
        public const uint InConcatenationTotalNumber = 0x00209163;

        ///<summary>(0020,9164) VR=UI VM=1 Dimension Organization Uid</summary>
        public const uint DimensionOrganizationUid = 0x00209164;

        ///<summary>(0020,9165) VR=AT VM=1 Dimension Index Pointer</summary>
        public const uint DimensionIndexPointer = 0x00209165;

        ///<summary>(0020,9167) VR=AT VM=1 Functional Group Pointer</summary>
        public const uint FunctionalGroupPointer = 0x00209167;

        ///<summary>(0020,9170) VR=SQ VM=1 Unassigned Shared Converted Attributes Sequence</summary>
        public const uint UnassignedSharedConvertedAttributesSequence = 0x00209170;

        ///<summary>(0020,9171) VR=SQ VM=1 Unassigned Per-Frame Converted Attributes Sequence</summary>
        public const uint UnassignedPerFrameConvertedAttributesSequence = 0x00209171;

        ///<summary>(0020,9172) VR=SQ VM=1 Conversion Source Attributes Sequence</summary>
        public const uint ConversionSourceAttributesSequence = 0x00209172;

        ///<summary>(0020,9213) VR=LO VM=1 Dimension Index Private Creator</summary>
        public const uint DimensionIndexPrivateCreator = 0x00209213;

        ///<summary>(0020,9221) VR=SQ VM=1 Dimension Organization Sequence</summary>
        public const uint DimensionOrganizationSequence = 0x00209221;

        ///<summary>(0020,9222) VR=SQ VM=1 Dimension Index Sequence</summary>
        public const uint DimensionIndexSequence = 0x00209222;

        ///<summary>(0020,9228) VR=UL VM=1 Concatenation Frame Offset Number</summary>
        public const uint ConcatenationFrameOffsetNumber = 0x00209228;

        ///<summary>(0020,9238) VR=LO VM=1 Functional Group Private Creator</summary>
        public const uint FunctionalGroupPrivateCreator = 0x00209238;

        ///<summary>(0020,9241) VR=FL VM=1 Nominal Percentage of Cardiac Phase</summary>
        public const uint NominalPercentageOfCardiacPhase = 0x00209241;

        ///<summary>(0020,9245) VR=FL VM=1 Nominal Percentage of Respiratory Phase</summary>
        public const uint NominalPercentageOfRespiratoryPhase = 0x00209245;

        ///<summary>(0020,9246) VR=FL VM=1 Starting Respiratory Amplitude</summary>
        public const uint StartingRespiratoryAmplitude = 0x00209246;

        ///<summary>(0020,9247) VR=CS VM=1 Starting Respiratory Phase</summary>
        public const uint StartingRespiratoryPhase = 0x00209247;

        ///<summary>(0020,9248) VR=FL VM=1 Ending Respiratory Amplitude</summary>
        public const uint EndingRespiratoryAmplitude = 0x00209248;

        ///<summary>(0020,9249) VR=CS VM=1 Ending Respiratory Phase</summary>
        public const uint EndingRespiratoryPhase = 0x00209249;

        ///<summary>(0020,9250) VR=CS VM=1 Respiratory Trigger Type</summary>
        public const uint RespiratoryTriggerType = 0x00209250;

        ///<summary>(0020,9251) VR=FD VM=1 R-R Interval Time Nominal</summary>
        public const uint RRIntervalTimeNominal = 0x00209251;

        ///<summary>(0020,9252) VR=FD VM=1 Actual Cardiac Trigger Delay Time</summary>
        public const uint ActualCardiacTriggerDelayTime = 0x00209252;

        ///<summary>(0020,9253) VR=SQ VM=1 Respiratory Synchronization Sequence</summary>
        public const uint RespiratorySynchronizationSequence = 0x00209253;

        ///<summary>(0020,9254) VR=FD VM=1 Respiratory Interval Time</summary>
        public const uint RespiratoryIntervalTime = 0x00209254;

        ///<summary>(0020,9255) VR=FD VM=1 Nominal Respiratory Trigger Delay Time</summary>
        public const uint NominalRespiratoryTriggerDelayTime = 0x00209255;

        ///<summary>(0020,9256) VR=FD VM=1 Respiratory Trigger Delay Threshold</summary>
        public const uint RespiratoryTriggerDelayThreshold = 0x00209256;

        ///<summary>(0020,9257) VR=FD VM=1 Actual Respiratory Trigger Delay Time</summary>
        public const uint ActualRespiratoryTriggerDelayTime = 0x00209257;

        ///<summary>(0020,9301) VR=FD VM=3 Image Position (Volume)</summary>
        public const uint ImagePositionVolume = 0x00209301;

        ///<summary>(0020,9302) VR=FD VM=6 Image Orientation (Volume)</summary>
        public const uint ImageOrientationVolume = 0x00209302;

        ///<summary>(0020,9307) VR=CS VM=1 Ultrasound Acquisition Geometry</summary>
        public const uint UltrasoundAcquisitionGeometry = 0x00209307;

        ///<summary>(0020,9308) VR=FD VM=3 Apex Position</summary>
        public const uint ApexPosition = 0x00209308;

        ///<summary>(0020,9309) VR=FD VM=16 Volume to Transducer Mapping Matrix</summary>
        public const uint VolumeToTransducerMappingMatrix = 0x00209309;

        ///<summary>(0020,930A) VR=FD VM=16 Volume to Table Mapping Matrix</summary>
        public const uint VolumeToTableMappingMatrix = 0x0020930A;

        ///<summary>(0020,930B) VR=CS VM=1 Volume to Transducer Relationship</summary>
        public const uint VolumeToTransducerRelationship = 0x0020930B;

        ///<summary>(0020,930C) VR=CS VM=1 Patient Frame of Reference Source</summary>
        public const uint PatientFrameOfReferenceSource = 0x0020930C;

        ///<summary>(0020,930D) VR=FD VM=1 Temporal Position Time Offset</summary>
        public const uint TemporalPositionTimeOffset = 0x0020930D;

        ///<summary>(0020,930E) VR=SQ VM=1 Plane Position (Volume) Sequence</summary>
        public const uint PlanePositionVolumeSequence = 0x0020930E;

        ///<summary>(0020,930F) VR=SQ VM=1 Plane Orientation (Volume) Sequence</summary>
        public const uint PlaneOrientationVolumeSequence = 0x0020930F;

        ///<summary>(0020,9310) VR=SQ VM=1 Temporal Position Sequence</summary>
        public const uint TemporalPositionSequence = 0x00209310;

        ///<summary>(0020,9311) VR=CS VM=1 Dimension Organization Type</summary>
        public const uint DimensionOrganizationType = 0x00209311;

        ///<summary>(0020,9312) VR=UI VM=1 Volume Frame of Reference Uid</summary>
        public const uint VolumeFrameOfReferenceUid = 0x00209312;

        ///<summary>(0020,9313) VR=UI VM=1 Table Frame of Reference Uid</summary>
        public const uint TableFrameOfReferenceUid = 0x00209313;

        ///<summary>(0020,9421) VR=LO VM=1 Dimension Description Label</summary>
        public const uint DimensionDescriptionLabel = 0x00209421;

        ///<summary>(0020,9450) VR=SQ VM=1 Patient Orientation in Frame Sequence</summary>
        public const uint PatientOrientationInFrameSequence = 0x00209450;

        ///<summary>(0020,9453) VR=LO VM=1 Frame Label</summary>
        public const uint FrameLabel = 0x00209453;

        ///<summary>(0020,9518) VR=US VM=1-n Acquisition Index</summary>
        public const uint AcquisitionIndex = 0x00209518;

        ///<summary>(0020,9529) VR=SQ VM=1 Contributing Sop Instances Reference Sequence</summary>
        public const uint ContributingSopInstancesReferenceSequence = 0x00209529;

        ///<summary>(0020,9536) VR=US VM=1 Reconstruction Index</summary>
        public const uint ReconstructionIndex = 0x00209536;

        ///<summary>(0022,0001) VR=US VM=1 Light Path Filter Pass-Through Wavelength</summary>
        public const uint LightPathFilterPassThroughWavelength = 0x00220001;

        ///<summary>(0022,0002) VR=US VM=2 Light Path Filter Pass Band</summary>
        public const uint LightPathFilterPassBand = 0x00220002;

        ///<summary>(0022,0003) VR=US VM=1 Image Path Filter Pass-Through Wavelength</summary>
        public const uint ImagePathFilterPassThroughWavelength = 0x00220003;

        ///<summary>(0022,0004) VR=US VM=2 Image Path Filter Pass Band</summary>
        public const uint ImagePathFilterPassBand = 0x00220004;

        ///<summary>(0022,0005) VR=CS VM=1 Patient Eye Movement Commanded</summary>
        public const uint PatientEyeMovementCommanded = 0x00220005;

        ///<summary>(0022,0006) VR=SQ VM=1 Patient Eye Movement Command Code Sequence</summary>
        public const uint PatientEyeMovementCommandCodeSequence = 0x00220006;

        ///<summary>(0022,0007) VR=FL VM=1 Spherical Lens Power</summary>
        public const uint SphericalLensPower = 0x00220007;

        ///<summary>(0022,0008) VR=FL VM=1 Cylinder Lens Power</summary>
        public const uint CylinderLensPower = 0x00220008;

        ///<summary>(0022,0009) VR=FL VM=1 Cylinder Axis</summary>
        public const uint CylinderAxis = 0x00220009;

        ///<summary>(0022,000A) VR=FL VM=1 Emmetropic Magnification</summary>
        public const uint EmmetropicMagnification = 0x0022000A;

        ///<summary>(0022,000B) VR=FL VM=1 Intra Ocular Pressure</summary>
        public const uint IntraOcularPressure = 0x0022000B;

        ///<summary>(0022,000C) VR=FL VM=1 Horizontal Field of View</summary>
        public const uint HorizontalFieldOfView = 0x0022000C;

        ///<summary>(0022,000D) VR=CS VM=1 Pupil Dilated</summary>
        public const uint PupilDilated = 0x0022000D;

        ///<summary>(0022,000E) VR=FL VM=1 Degree of Dilation</summary>
        public const uint DegreeOfDilation = 0x0022000E;

        ///<summary>(0022,0010) VR=FL VM=1 Stereo Baseline Angle</summary>
        public const uint StereoBaselineAngle = 0x00220010;

        ///<summary>(0022,0011) VR=FL VM=1 Stereo Baseline Displacement</summary>
        public const uint StereoBaselineDisplacement = 0x00220011;

        ///<summary>(0022,0012) VR=FL VM=1 Stereo Horizontal Pixel Offset</summary>
        public const uint StereoHorizontalPixelOffset = 0x00220012;

        ///<summary>(0022,0013) VR=FL VM=1 Stereo Vertical Pixel Offset</summary>
        public const uint StereoVerticalPixelOffset = 0x00220013;

        ///<summary>(0022,0014) VR=FL VM=1 Stereo Rotation</summary>
        public const uint StereoRotation = 0x00220014;

        ///<summary>(0022,0015) VR=SQ VM=1 Acquisition Device Type Code Sequence</summary>
        public const uint AcquisitionDeviceTypeCodeSequence = 0x00220015;

        ///<summary>(0022,0016) VR=SQ VM=1 Illumination Type Code Sequence</summary>
        public const uint IlluminationTypeCodeSequence = 0x00220016;

        ///<summary>(0022,0017) VR=SQ VM=1 Light Path Filter Type Stack Code Sequence</summary>
        public const uint LightPathFilterTypeStackCodeSequence = 0x00220017;

        ///<summary>(0022,0018) VR=SQ VM=1 Image Path Filter Type Stack Code Sequence</summary>
        public const uint ImagePathFilterTypeStackCodeSequence = 0x00220018;

        ///<summary>(0022,0019) VR=SQ VM=1 Lenses Code Sequence</summary>
        public const uint LensesCodeSequence = 0x00220019;

        ///<summary>(0022,001A) VR=SQ VM=1 Channel Description Code Sequence</summary>
        public const uint ChannelDescriptionCodeSequence = 0x0022001A;

        ///<summary>(0022,001B) VR=SQ VM=1 Refractive State Sequence</summary>
        public const uint RefractiveStateSequence = 0x0022001B;

        ///<summary>(0022,001C) VR=SQ VM=1 Mydriatic Agent Code Sequence</summary>
        public const uint MydriaticAgentCodeSequence = 0x0022001C;

        ///<summary>(0022,001D) VR=SQ VM=1 Relative Image Position Code Sequence</summary>
        public const uint RelativeImagePositionCodeSequence = 0x0022001D;

        ///<summary>(0022,001E) VR=FL VM=1 Camera Angle of View</summary>
        public const uint CameraAngleOfView = 0x0022001E;

        ///<summary>(0022,0020) VR=SQ VM=1 Stereo Pairs Sequence</summary>
        public const uint StereoPairsSequence = 0x00220020;

        ///<summary>(0022,0021) VR=SQ VM=1 Left Image Sequence</summary>
        public const uint LeftImageSequence = 0x00220021;

        ///<summary>(0022,0022) VR=SQ VM=1 Right Image Sequence</summary>
        public const uint RightImageSequence = 0x00220022;

        ///<summary>(0022,0028) VR=CS VM=1 Stereo Pairs Present</summary>
        public const uint StereoPairsPresent = 0x00220028;

        ///<summary>(0022,0030) VR=FL VM=1 Axial Length of the Eye</summary>
        public const uint AxialLengthOfTheEye = 0x00220030;

        ///<summary>(0022,0031) VR=SQ VM=1 Ophthalmic Frame Location Sequence</summary>
        public const uint OphthalmicFrameLocationSequence = 0x00220031;

        ///<summary>(0022,0032) VR=FL VM=2-2n Reference Coordinates</summary>
        public const uint ReferenceCoordinates = 0x00220032;

        ///<summary>(0022,0035) VR=FL VM=1 Depth Spatial Resolution</summary>
        public const uint DepthSpatialResolution = 0x00220035;

        ///<summary>(0022,0036) VR=FL VM=1 Maximum Depth Distortion</summary>
        public const uint MaximumDepthDistortion = 0x00220036;

        ///<summary>(0022,0037) VR=FL VM=1 Along-scan Spatial Resolution</summary>
        public const uint AlongScanSpatialResolution = 0x00220037;

        ///<summary>(0022,0038) VR=FL VM=1 Maximum Along-scan Distortion</summary>
        public const uint MaximumAlongScanDistortion = 0x00220038;

        ///<summary>(0022,0039) VR=CS VM=1 Ophthalmic Image Orientation</summary>
        public const uint OphthalmicImageOrientation = 0x00220039;

        ///<summary>(0022,0041) VR=FL VM=1 Depth of Transverse Image</summary>
        public const uint DepthOfTransverseImage = 0x00220041;

        ///<summary>(0022,0042) VR=SQ VM=1 Mydriatic Agent Concentration Units Sequence</summary>
        public const uint MydriaticAgentConcentrationUnitsSequence = 0x00220042;

        ///<summary>(0022,0048) VR=FL VM=1 Across-scan Spatial Resolution</summary>
        public const uint AcrossScanSpatialResolution = 0x00220048;

        ///<summary>(0022,0049) VR=FL VM=1 Maximum Across-scan Distortion</summary>
        public const uint MaximumAcrossScanDistortion = 0x00220049;

        ///<summary>(0022,004E) VR=DS VM=1 Mydriatic Agent Concentration</summary>
        public const uint MydriaticAgentConcentration = 0x0022004E;

        ///<summary>(0022,0055) VR=FL VM=1 Illumination Wave Length</summary>
        public const uint IlluminationWaveLength = 0x00220055;

        ///<summary>(0022,0056) VR=FL VM=1 Illumination Power</summary>
        public const uint IlluminationPower = 0x00220056;

        ///<summary>(0022,0057) VR=FL VM=1 Illumination Bandwidth</summary>
        public const uint IlluminationBandwidth = 0x00220057;

        ///<summary>(0022,0058) VR=SQ VM=1 Mydriatic Agent Sequence</summary>
        public const uint MydriaticAgentSequence = 0x00220058;

        ///<summary>(0022,1007) VR=SQ VM=1 Ophthalmic Axial Measurements Right Eye Sequence</summary>
        public const uint OphthalmicAxialMeasurementsRightEyeSequence = 0x00221007;

        ///<summary>(0022,1008) VR=SQ VM=1 Ophthalmic Axial Measurements Left Eye Sequence</summary>
        public const uint OphthalmicAxialMeasurementsLeftEyeSequence = 0x00221008;

        ///<summary>(0022,1009) VR=CS VM=1 Ophthalmic Axial Measurements Device Type</summary>
        public const uint OphthalmicAxialMeasurementsDeviceType = 0x00221009;

        ///<summary>(0022,1010) VR=CS VM=1 Ophthalmic Axial Length Measurements Type</summary>
        public const uint OphthalmicAxialLengthMeasurementsType = 0x00221010;

        ///<summary>(0022,1012) VR=SQ VM=1 Ophthalmic Axial Length Sequence</summary>
        public const uint OphthalmicAxialLengthSequence = 0x00221012;

        ///<summary>(0022,1019) VR=FL VM=1 Ophthalmic Axial Length</summary>
        public const uint OphthalmicAxialLength = 0x00221019;

        ///<summary>(0022,1024) VR=SQ VM=1 Lens Status Code Sequence</summary>
        public const uint LensStatusCodeSequence = 0x00221024;

        ///<summary>(0022,1025) VR=SQ VM=1 Vitreous Status Code Sequence</summary>
        public const uint VitreousStatusCodeSequence = 0x00221025;

        ///<summary>(0022,1028) VR=SQ VM=1 IOL Formula Code Sequence</summary>
        public const uint IOLFormulaCodeSequence = 0x00221028;

        ///<summary>(0022,1029) VR=LO VM=1 IOL Formula Detail</summary>
        public const uint IOLFormulaDetail = 0x00221029;

        ///<summary>(0022,1033) VR=FL VM=1 Keratometer Index</summary>
        public const uint KeratometerIndex = 0x00221033;

        ///<summary>(0022,1035) VR=SQ VM=1 Source of Ophthalmic Axial Length Code Sequence</summary>
        public const uint SourceOfOphthalmicAxialLengthCodeSequence = 0x00221035;

        ///<summary>(0022,1036) VR=SQ VM=1 Source of Corneal Size Data Code Sequence</summary>
        public const uint SourceOfCornealSizeDataCodeSequence = 0x00221036;

        ///<summary>(0022,1037) VR=FL VM=1 Target Refraction</summary>
        public const uint TargetRefraction = 0x00221037;

        ///<summary>(0022,1039) VR=CS VM=1 Refractive Procedure Occurred</summary>
        public const uint RefractiveProcedureOccurred = 0x00221039;

        ///<summary>(0022,1040) VR=SQ VM=1 Refractive Surgery Type Code Sequence</summary>
        public const uint RefractiveSurgeryTypeCodeSequence = 0x00221040;

        ///<summary>(0022,1044) VR=SQ VM=1 Ophthalmic Ultrasound Method Code Sequence</summary>
        public const uint OphthalmicUltrasoundMethodCodeSequence = 0x00221044;

        ///<summary>(0022,1045) VR=SQ VM=1 Surgically Induced Astigmatism Sequence</summary>
        public const uint SurgicallyInducedAstigmatismSequence = 0x00221045;

        ///<summary>(0022,1046) VR=CS VM=1 Type of Optical Correction</summary>
        public const uint TypeOfOpticalCorrection = 0x00221046;

        ///<summary>(0022,1047) VR=SQ VM=1 Toric IOL Power Sequence</summary>
        public const uint ToricIOLPowerSequence = 0x00221047;

        ///<summary>(0022,1048) VR=SQ VM=1 Predicted Toric Error Sequence</summary>
        public const uint PredictedToricErrorSequence = 0x00221048;

        ///<summary>(0022,1049) VR=CS VM=1 Pre-Selected for Implantation</summary>
        public const uint PreSelectedForImplantation = 0x00221049;

        ///<summary>(0022,104A) VR=SQ VM=1 Toric IOL Power for Exact Emmetropia Sequence</summary>
        public const uint ToricIOLPowerForExactEmmetropiaSequence = 0x0022104A;

        ///<summary>(0022,104B) VR=SQ VM=1 Toric IOL Power for Exact Target Refraction Sequence</summary>
        public const uint ToricIOLPowerForExactTargetRefractionSequence = 0x0022104B;

        ///<summary>(0022,1050) VR=SQ VM=1 Ophthalmic Axial Length Measurements Sequence</summary>
        public const uint OphthalmicAxialLengthMeasurementsSequence = 0x00221050;

        ///<summary>(0022,1053) VR=FL VM=1 IOL Power</summary>
        public const uint IOLPower = 0x00221053;

        ///<summary>(0022,1054) VR=FL VM=1 Predicted Refractive Error</summary>
        public const uint PredictedRefractiveError = 0x00221054;

        ///<summary>(0022,1059) VR=FL VM=1 Ophthalmic Axial Length Velocity</summary>
        public const uint OphthalmicAxialLengthVelocity = 0x00221059;

        ///<summary>(0022,1065) VR=LO VM=1 Lens Status Description</summary>
        public const uint LensStatusDescription = 0x00221065;

        ///<summary>(0022,1066) VR=LO VM=1 Vitreous Status Description</summary>
        public const uint VitreousStatusDescription = 0x00221066;

        ///<summary>(0022,1090) VR=SQ VM=1 IOL Power Sequence</summary>
        public const uint IOLPowerSequence = 0x00221090;

        ///<summary>(0022,1092) VR=SQ VM=1 Lens Constant Sequence</summary>
        public const uint LensConstantSequence = 0x00221092;

        ///<summary>(0022,1093) VR=LO VM=1 IOL Manufacturer</summary>
        public const uint IOLManufacturer = 0x00221093;

        ///<summary>(0022,1094) VR=LO VM=1 Lens Constant Description (RETIRED)</summary>
        public const uint LensConstantDescriptionRETIRED = 0x00221094;

        ///<summary>(0022,1095) VR=LO VM=1 Implant Name</summary>
        public const uint ImplantName = 0x00221095;

        ///<summary>(0022,1096) VR=SQ VM=1 Keratometry Measurement Type Code Sequence</summary>
        public const uint KeratometryMeasurementTypeCodeSequence = 0x00221096;

        ///<summary>(0022,1097) VR=LO VM=1 Implant Part Number</summary>
        public const uint ImplantPartNumber = 0x00221097;

        ///<summary>(0022,1100) VR=SQ VM=1 Referenced Ophthalmic Axial Measurements Sequence</summary>
        public const uint ReferencedOphthalmicAxialMeasurementsSequence = 0x00221100;

        ///<summary>(0022,1101) VR=SQ VM=1 Ophthalmic Axial Length Measurements Segment Name Code Sequence</summary>
        public const uint OphthalmicAxialLengthMeasurementsSegmentNameCodeSequence = 0x00221101;

        ///<summary>(0022,1103) VR=SQ VM=1 Refractive Error Before Refractive Surgery Code Sequence</summary>
        public const uint RefractiveErrorBeforeRefractiveSurgeryCodeSequence = 0x00221103;

        ///<summary>(0022,1121) VR=FL VM=1 IOL Power For Exact Emmetropia</summary>
        public const uint IOLPowerForExactEmmetropia = 0x00221121;

        ///<summary>(0022,1122) VR=FL VM=1 IOL Power For Exact Target Refraction</summary>
        public const uint IOLPowerForExactTargetRefraction = 0x00221122;

        ///<summary>(0022,1125) VR=SQ VM=1 Anterior Chamber Depth Definition Code Sequence</summary>
        public const uint AnteriorChamberDepthDefinitionCodeSequence = 0x00221125;

        ///<summary>(0022,1127) VR=SQ VM=1 Lens Thickness Sequence</summary>
        public const uint LensThicknessSequence = 0x00221127;

        ///<summary>(0022,1128) VR=SQ VM=1 Anterior Chamber Depth Sequence</summary>
        public const uint AnteriorChamberDepthSequence = 0x00221128;

        ///<summary>(0022,112A) VR=SQ VM=1 Calculation Comment Sequence</summary>
        public const uint CalculationCommentSequence = 0x0022112A;

        ///<summary>(0022,112B) VR=CS VM=1 Calculation Comment Type</summary>
        public const uint CalculationCommentType = 0x0022112B;

        ///<summary>(0022,112C) VR=LT VM=1 Calculation Comment</summary>
        public const uint CalculationComment = 0x0022112C;

        ///<summary>(0022,1130) VR=FL VM=1 Lens Thickness</summary>
        public const uint LensThickness = 0x00221130;

        ///<summary>(0022,1131) VR=FL VM=1 Anterior Chamber Depth</summary>
        public const uint AnteriorChamberDepth = 0x00221131;

        ///<summary>(0022,1132) VR=SQ VM=1 Source of Lens Thickness Data Code Sequence</summary>
        public const uint SourceOfLensThicknessDataCodeSequence = 0x00221132;

        ///<summary>(0022,1133) VR=SQ VM=1 Source of Anterior Chamber Depth Data Code Sequence</summary>
        public const uint SourceOfAnteriorChamberDepthDataCodeSequence = 0x00221133;

        ///<summary>(0022,1134) VR=SQ VM=1 Source of Refractive Measurements Sequence</summary>
        public const uint SourceOfRefractiveMeasurementsSequence = 0x00221134;

        ///<summary>(0022,1135) VR=SQ VM=1 Source of Refractive Measurements Code Sequence</summary>
        public const uint SourceOfRefractiveMeasurementsCodeSequence = 0x00221135;

        ///<summary>(0022,1140) VR=CS VM=1 Ophthalmic Axial Length Measurement Modified</summary>
        public const uint OphthalmicAxialLengthMeasurementModified = 0x00221140;

        ///<summary>(0022,1150) VR=SQ VM=1 Ophthalmic Axial Length Data Source Code Sequence</summary>
        public const uint OphthalmicAxialLengthDataSourceCodeSequence = 0x00221150;

        ///<summary>(0022,1153) VR=SQ VM=1 Ophthalmic Axial Length Acquisition Method Code Sequence (RETIRED)</summary>
        public const uint OphthalmicAxialLengthAcquisitionMethodCodeSequenceRETIRED = 0x00221153;

        ///<summary>(0022,1155) VR=FL VM=1 Signal to Noise Ratio</summary>
        public const uint SignalToNoiseRatio = 0x00221155;

        ///<summary>(0022,1159) VR=LO VM=1 Ophthalmic Axial Length Data Source Description</summary>
        public const uint OphthalmicAxialLengthDataSourceDescription = 0x00221159;

        ///<summary>(0022,1210) VR=SQ VM=1 Ophthalmic Axial Length Measurements Total Length Sequence</summary>
        public const uint OphthalmicAxialLengthMeasurementsTotalLengthSequence = 0x00221210;

        ///<summary>(0022,1211) VR=SQ VM=1 Ophthalmic Axial Length Measurements Segmental Length Sequence</summary>
        public const uint OphthalmicAxialLengthMeasurementsSegmentalLengthSequence = 0x00221211;

        ///<summary>(0022,1212) VR=SQ VM=1 Ophthalmic Axial Length Measurements Length Summation Sequence</summary>
        public const uint OphthalmicAxialLengthMeasurementsLengthSummationSequence = 0x00221212;

        ///<summary>(0022,1220) VR=SQ VM=1 Ultrasound Ophthalmic Axial Length Measurements Sequence</summary>
        public const uint UltrasoundOphthalmicAxialLengthMeasurementsSequence = 0x00221220;

        ///<summary>(0022,1225) VR=SQ VM=1 Optical Ophthalmic Axial Length Measurements Sequence</summary>
        public const uint OpticalOphthalmicAxialLengthMeasurementsSequence = 0x00221225;

        ///<summary>(0022,1230) VR=SQ VM=1 Ultrasound Selected Ophthalmic Axial Length Sequence</summary>
        public const uint UltrasoundSelectedOphthalmicAxialLengthSequence = 0x00221230;

        ///<summary>(0022,1250) VR=SQ VM=1 Ophthalmic Axial Length Selection Method Code Sequence</summary>
        public const uint OphthalmicAxialLengthSelectionMethodCodeSequence = 0x00221250;

        ///<summary>(0022,1255) VR=SQ VM=1 Optical Selected Ophthalmic Axial Length Sequence</summary>
        public const uint OpticalSelectedOphthalmicAxialLengthSequence = 0x00221255;

        ///<summary>(0022,1257) VR=SQ VM=1 Selected Segmental Ophthalmic Axial Length Sequence</summary>
        public const uint SelectedSegmentalOphthalmicAxialLengthSequence = 0x00221257;

        ///<summary>(0022,1260) VR=SQ VM=1 Selected Total Ophthalmic Axial Length Sequence</summary>
        public const uint SelectedTotalOphthalmicAxialLengthSequence = 0x00221260;

        ///<summary>(0022,1262) VR=SQ VM=1 Ophthalmic Axial Length Quality Metric Sequence</summary>
        public const uint OphthalmicAxialLengthQualityMetricSequence = 0x00221262;

        ///<summary>(0022,1265) VR=SQ VM=1 Ophthalmic Axial Length Quality Metric Type Code Sequence (RETIRED)</summary>
        public const uint OphthalmicAxialLengthQualityMetricTypeCodeSequenceRETIRED = 0x00221265;

        ///<summary>(0022,1273) VR=LO VM=1 Ophthalmic Axial Length Quality Metric Type Description (RETIRED)</summary>
        public const uint OphthalmicAxialLengthQualityMetricTypeDescriptionRETIRED = 0x00221273;

        ///<summary>(0022,1300) VR=SQ VM=1 Intraocular Lens Calculations Right Eye Sequence</summary>
        public const uint IntraocularLensCalculationsRightEyeSequence = 0x00221300;

        ///<summary>(0022,1310) VR=SQ VM=1 Intraocular Lens Calculations Left Eye Sequence</summary>
        public const uint IntraocularLensCalculationsLeftEyeSequence = 0x00221310;

        ///<summary>(0022,1330) VR=SQ VM=1 Referenced Ophthalmic Axial Length Measurement QC Image Sequence</summary>
        public const uint ReferencedOphthalmicAxialLengthMeasurementQCImageSequence = 0x00221330;

        ///<summary>(0022,1415) VR=CS VM=1 Ophthalmic Mapping Device Type</summary>
        public const uint OphthalmicMappingDeviceType = 0x00221415;

        ///<summary>(0022,1420) VR=SQ VM=1 Acquisition Method Code Sequence</summary>
        public const uint AcquisitionMethodCodeSequence = 0x00221420;

        ///<summary>(0022,1423) VR=SQ VM=1 Acquisition Method Algorithm Sequence</summary>
        public const uint AcquisitionMethodAlgorithmSequence = 0x00221423;

        ///<summary>(0022,1436) VR=SQ VM=1 Ophthalmic Thickness Map Type Code Sequence</summary>
        public const uint OphthalmicThicknessMapTypeCodeSequence = 0x00221436;

        ///<summary>(0022,1443) VR=SQ VM=1 Ophthalmic Thickness Mapping Normals Sequence</summary>
        public const uint OphthalmicThicknessMappingNormalsSequence = 0x00221443;

        ///<summary>(0022,1445) VR=SQ VM=1 Retinal Thickness Definition Code Sequence</summary>
        public const uint RetinalThicknessDefinitionCodeSequence = 0x00221445;

        ///<summary>(0022,1450) VR=SQ VM=1 Pixel Value Mapping to Coded Concept Sequence</summary>
        public const uint PixelValueMappingToCodedConceptSequence = 0x00221450;

        ///<summary>(0022,1452) VR=US/SS VM=1 Mapped Pixel Value</summary>
        public const uint MappedPixelValue = 0x00221452;

        ///<summary>(0022,1454) VR=LO VM=1 Pixel Value Mapping Explanation</summary>
        public const uint PixelValueMappingExplanation = 0x00221454;

        ///<summary>(0022,1458) VR=SQ VM=1 Ophthalmic Thickness Map Quality Threshold Sequence</summary>
        public const uint OphthalmicThicknessMapQualityThresholdSequence = 0x00221458;

        ///<summary>(0022,1460) VR=FL VM=1 Ophthalmic Thickness Map Threshold Quality Rating</summary>
        public const uint OphthalmicThicknessMapThresholdQualityRating = 0x00221460;

        ///<summary>(0022,1463) VR=FL VM=2 Anatomic Structure Reference Point</summary>
        public const uint AnatomicStructureReferencePoint = 0x00221463;

        ///<summary>(0022,1465) VR=SQ VM=1 Registration to Localizer Sequence</summary>
        public const uint RegistrationToLocalizerSequence = 0x00221465;

        ///<summary>(0022,1466) VR=CS VM=1 Registered Localizer Units</summary>
        public const uint RegisteredLocalizerUnits = 0x00221466;

        ///<summary>(0022,1467) VR=FL VM=2 Registered Localizer Top Left Hand Corner</summary>
        public const uint RegisteredLocalizerTopLeftHandCorner = 0x00221467;

        ///<summary>(0022,1468) VR=FL VM=2 Registered Localizer Bottom Right Hand Corner</summary>
        public const uint RegisteredLocalizerBottomRightHandCorner = 0x00221468;

        ///<summary>(0022,1470) VR=SQ VM=1 Ophthalmic Thickness Map Quality Rating Sequence</summary>
        public const uint OphthalmicThicknessMapQualityRatingSequence = 0x00221470;

        ///<summary>(0022,1472) VR=SQ VM=1 Relevant OPT Attributes Sequence</summary>
        public const uint RelevantOPTAttributesSequence = 0x00221472;

        ///<summary>(0022,1512) VR=SQ VM=1 Transformation Method Code Sequence</summary>
        public const uint TransformationMethodCodeSequence = 0x00221512;

        ///<summary>(0022,1513) VR=SQ VM=1 Transformation Algorithm Sequence</summary>
        public const uint TransformationAlgorithmSequence = 0x00221513;

        ///<summary>(0022,1515) VR=CS VM=1 Ophthalmic Axial Length Method</summary>
        public const uint OphthalmicAxialLengthMethod = 0x00221515;

        ///<summary>(0022,1517) VR=FL VM=1 Ophthalmic FOV</summary>
        public const uint OphthalmicFOV = 0x00221517;

        ///<summary>(0022,1518) VR=SQ VM=1 Two Dimensional to Three Dimensional Map Sequence</summary>
        public const uint TwoDimensionalToThreeDimensionalMapSequence = 0x00221518;

        ///<summary>(0022,1525) VR=SQ VM=1 Wide Field Ophthalmic Photography Quality Rating Sequence</summary>
        public const uint WideFieldOphthalmicPhotographyQualityRatingSequence = 0x00221525;

        ///<summary>(0022,1526) VR=SQ VM=1 Wide Field Ophthalmic Photography Quality Threshold Sequence</summary>
        public const uint WideFieldOphthalmicPhotographyQualityThresholdSequence = 0x00221526;

        ///<summary>(0022,1527) VR=FL VM=1 Wide Field Ophthalmic Photography Threshold Quality Rating</summary>
        public const uint WideFieldOphthalmicPhotographyThresholdQualityRating = 0x00221527;

        ///<summary>(0022,1528) VR=FL VM=1 X Coordinates Center Pixel View Angle</summary>
        public const uint XCoordinatesCenterPixelViewAngle = 0x00221528;

        ///<summary>(0022,1529) VR=FL VM=1 Y Coordinates Center Pixel View Angle</summary>
        public const uint YCoordinatesCenterPixelViewAngle = 0x00221529;

        ///<summary>(0022,1530) VR=UL VM=1 Number of Map Points</summary>
        public const uint NumberOfMapPoints = 0x00221530;

        ///<summary>(0022,1531) VR=OF VM=1 Two Dimensional to Three Dimensional Map Data</summary>
        public const uint TwoDimensionalToThreeDimensionalMapData = 0x00221531;

        ///<summary>(0022,1612) VR=SQ VM=1 Derivation Algorithm Sequence</summary>
        public const uint DerivationAlgorithmSequence = 0x00221612;

        ///<summary>(0022,1615) VR=SQ VM=1 Ophthalmic Image Type Code Sequence</summary>
        public const uint OphthalmicImageTypeCodeSequence = 0x00221615;

        ///<summary>(0022,1616) VR=LO VM=1 Ophthalmic Image Type Description</summary>
        public const uint OphthalmicImageTypeDescription = 0x00221616;

        ///<summary>(0022,1618) VR=SQ VM=1 Scan Pattern Type Code Sequence</summary>
        public const uint ScanPatternTypeCodeSequence = 0x00221618;

        ///<summary>(0022,1620) VR=SQ VM=1 Referenced Surface Mesh Identification Sequence</summary>
        public const uint ReferencedSurfaceMeshIdentificationSequence = 0x00221620;

        ///<summary>(0022,1622) VR=CS VM=1 Ophthalmic Volumetric Properties Flag</summary>
        public const uint OphthalmicVolumetricPropertiesFlag = 0x00221622;

        ///<summary>(0022,1624) VR=FL VM=1 Ophthalmic Anatomic Reference Point X-Coordinate</summary>
        public const uint OphthalmicAnatomicReferencePointXCoordinate = 0x00221624;

        ///<summary>(0022,1626) VR=FL VM=1 Ophthalmic Anatomic Reference Point Y-Coordinate</summary>
        public const uint OphthalmicAnatomicReferencePointYCoordinate = 0x00221626;

        ///<summary>(0022,1628) VR=SQ VM=1 Ophthalmic En Face Image Quality Rating Sequence</summary>
        public const uint OphthalmicEnFaceImageQualityRatingSequence = 0x00221628;

        ///<summary>(0022,1630) VR=DS VM=1 Quality Threshold</summary>
        public const uint QualityThreshold = 0x00221630;

        ///<summary>(0022,1640) VR=SQ VM=1 OCT B-scan Analysis Acquisition Parameters Sequence</summary>
        public const uint OCTBscanAnalysisAcquisitionParametersSequence = 0x00221640;

        ///<summary>(0022,1642) VR=UL VM=1 Number of B-scans Per Frame</summary>
        public const uint NumberOfBscansPerFrame = 0x00221642;

        ///<summary>(0022,1643) VR=FL VM=1 B-scan Slab Thickness</summary>
        public const uint BscanSlabThickness = 0x00221643;

        ///<summary>(0022,1644) VR=FL VM=1 Distance Between B-scan Slabs</summary>
        public const uint DistanceBetweenBscanSlabs = 0x00221644;

        ///<summary>(0022,1645) VR=FL VM=1 B-scan Cycle Time</summary>
        public const uint BscanCycleTime = 0x00221645;

        ///<summary>(0022,1646) VR=FL VM=1-n B-scan Cycle Time Vector</summary>
        public const uint BscanCycleTimeVector = 0x00221646;

        ///<summary>(0022,1649) VR=FL VM=1 A-scan Rate</summary>
        public const uint AscanRate = 0x00221649;

        ///<summary>(0022,1650) VR=FL VM=1 B-scan Rate</summary>
        public const uint BscanRate = 0x00221650;

        ///<summary>(0022,1658) VR=UL VM=1 Surface Mesh Z-Pixel Offset</summary>
        public const uint SurfaceMeshZPixelOffset = 0x00221658;

        ///<summary>(0024,0010) VR=FL VM=1 Visual Field Horizontal Extent</summary>
        public const uint VisualFieldHorizontalExtent = 0x00240010;

        ///<summary>(0024,0011) VR=FL VM=1 Visual Field Vertical Extent</summary>
        public const uint VisualFieldVerticalExtent = 0x00240011;

        ///<summary>(0024,0012) VR=CS VM=1 Visual Field Shape</summary>
        public const uint VisualFieldShape = 0x00240012;

        ///<summary>(0024,0016) VR=SQ VM=1 Screening Test Mode Code Sequence</summary>
        public const uint ScreeningTestModeCodeSequence = 0x00240016;

        ///<summary>(0024,0018) VR=FL VM=1 Maximum Stimulus Luminance</summary>
        public const uint MaximumStimulusLuminance = 0x00240018;

        ///<summary>(0024,0020) VR=FL VM=1 Background Luminance</summary>
        public const uint BackgroundLuminance = 0x00240020;

        ///<summary>(0024,0021) VR=SQ VM=1 Stimulus Color Code Sequence</summary>
        public const uint StimulusColorCodeSequence = 0x00240021;

        ///<summary>(0024,0024) VR=SQ VM=1 Background Illumination Color Code Sequence</summary>
        public const uint BackgroundIlluminationColorCodeSequence = 0x00240024;

        ///<summary>(0024,0025) VR=FL VM=1 Stimulus Area</summary>
        public const uint StimulusArea = 0x00240025;

        ///<summary>(0024,0028) VR=FL VM=1 Stimulus Presentation Time</summary>
        public const uint StimulusPresentationTime = 0x00240028;

        ///<summary>(0024,0032) VR=SQ VM=1 Fixation Sequence</summary>
        public const uint FixationSequence = 0x00240032;

        ///<summary>(0024,0033) VR=SQ VM=1 Fixation Monitoring Code Sequence</summary>
        public const uint FixationMonitoringCodeSequence = 0x00240033;

        ///<summary>(0024,0034) VR=SQ VM=1 Visual Field Catch Trial Sequence</summary>
        public const uint VisualFieldCatchTrialSequence = 0x00240034;

        ///<summary>(0024,0035) VR=US VM=1 Fixation Checked Quantity</summary>
        public const uint FixationCheckedQuantity = 0x00240035;

        ///<summary>(0024,0036) VR=US VM=1 Patient Not Properly Fixated Quantity</summary>
        public const uint PatientNotProperlyFixatedQuantity = 0x00240036;

        ///<summary>(0024,0037) VR=CS VM=1 Presented Visual Stimuli Data Flag</summary>
        public const uint PresentedVisualStimuliDataFlag = 0x00240037;

        ///<summary>(0024,0038) VR=US VM=1 Number of Visual Stimuli</summary>
        public const uint NumberOfVisualStimuli = 0x00240038;

        ///<summary>(0024,0039) VR=CS VM=1 Excessive Fixation Losses Data Flag</summary>
        public const uint ExcessiveFixationLossesDataFlag = 0x00240039;

        ///<summary>(0024,0040) VR=CS VM=1 Excessive Fixation Losses</summary>
        public const uint ExcessiveFixationLosses = 0x00240040;

        ///<summary>(0024,0042) VR=US VM=1 Stimuli Retesting Quantity</summary>
        public const uint StimuliRetestingQuantity = 0x00240042;

        ///<summary>(0024,0044) VR=LT VM=1 Comments on Patient's Performance of Visual Field</summary>
        public const uint CommentsOnPatientPerformanceOfVisualField = 0x00240044;

        ///<summary>(0024,0045) VR=CS VM=1 False Negatives Estimate Flag</summary>
        public const uint FalseNegativesEstimateFlag = 0x00240045;

        ///<summary>(0024,0046) VR=FL VM=1 False Negatives Estimate</summary>
        public const uint FalseNegativesEstimate = 0x00240046;

        ///<summary>(0024,0048) VR=US VM=1 Negative Catch Trials Quantity</summary>
        public const uint NegativeCatchTrialsQuantity = 0x00240048;

        ///<summary>(0024,0050) VR=US VM=1 False Negatives Quantity</summary>
        public const uint FalseNegativesQuantity = 0x00240050;

        ///<summary>(0024,0051) VR=CS VM=1 Excessive False Negatives Data Flag</summary>
        public const uint ExcessiveFalseNegativesDataFlag = 0x00240051;

        ///<summary>(0024,0052) VR=CS VM=1 Excessive False Negatives</summary>
        public const uint ExcessiveFalseNegatives = 0x00240052;

        ///<summary>(0024,0053) VR=CS VM=1 False Positives Estimate Flag</summary>
        public const uint FalsePositivesEstimateFlag = 0x00240053;

        ///<summary>(0024,0054) VR=FL VM=1 False Positives Estimate</summary>
        public const uint FalsePositivesEstimate = 0x00240054;

        ///<summary>(0024,0055) VR=CS VM=1 Catch Trials Data Flag</summary>
        public const uint CatchTrialsDataFlag = 0x00240055;

        ///<summary>(0024,0056) VR=US VM=1 Positive Catch Trials Quantity</summary>
        public const uint PositiveCatchTrialsQuantity = 0x00240056;

        ///<summary>(0024,0057) VR=CS VM=1 Test Point Normals Data Flag</summary>
        public const uint TestPointNormalsDataFlag = 0x00240057;

        ///<summary>(0024,0058) VR=SQ VM=1 Test Point Normals Sequence</summary>
        public const uint TestPointNormalsSequence = 0x00240058;

        ///<summary>(0024,0059) VR=CS VM=1 Global Deviation Probability Normals Flag</summary>
        public const uint GlobalDeviationProbabilityNormalsFlag = 0x00240059;

        ///<summary>(0024,0060) VR=US VM=1 False Positives Quantity</summary>
        public const uint FalsePositivesQuantity = 0x00240060;

        ///<summary>(0024,0061) VR=CS VM=1 Excessive False Positives Data Flag</summary>
        public const uint ExcessiveFalsePositivesDataFlag = 0x00240061;

        ///<summary>(0024,0062) VR=CS VM=1 Excessive False Positives</summary>
        public const uint ExcessiveFalsePositives = 0x00240062;

        ///<summary>(0024,0063) VR=CS VM=1 Visual Field Test Normals Flag</summary>
        public const uint VisualFieldTestNormalsFlag = 0x00240063;

        ///<summary>(0024,0064) VR=SQ VM=1 Results Normals Sequence</summary>
        public const uint ResultsNormalsSequence = 0x00240064;

        ///<summary>(0024,0065) VR=SQ VM=1 Age Corrected Sensitivity Deviation Algorithm Sequence</summary>
        public const uint AgeCorrectedSensitivityDeviationAlgorithmSequence = 0x00240065;

        ///<summary>(0024,0066) VR=FL VM=1 Global Deviation From Normal</summary>
        public const uint GlobalDeviationFromNormal = 0x00240066;

        ///<summary>(0024,0067) VR=SQ VM=1 Generalized Defect Sensitivity Deviation Algorithm Sequence</summary>
        public const uint GeneralizedDefectSensitivityDeviationAlgorithmSequence = 0x00240067;

        ///<summary>(0024,0068) VR=FL VM=1 Localized Deviation From Normal</summary>
        public const uint LocalizedDeviationFromNormal = 0x00240068;

        ///<summary>(0024,0069) VR=LO VM=1 Patient Reliability Indicator</summary>
        public const uint PatientReliabilityIndicator = 0x00240069;

        ///<summary>(0024,0070) VR=FL VM=1 Visual Field Mean Sensitivity</summary>
        public const uint VisualFieldMeanSensitivity = 0x00240070;

        ///<summary>(0024,0071) VR=FL VM=1 Global Deviation Probability</summary>
        public const uint GlobalDeviationProbability = 0x00240071;

        ///<summary>(0024,0072) VR=CS VM=1 Local Deviation Probability Normals Flag</summary>
        public const uint LocalDeviationProbabilityNormalsFlag = 0x00240072;

        ///<summary>(0024,0073) VR=FL VM=1 Localized Deviation Probability</summary>
        public const uint LocalizedDeviationProbability = 0x00240073;

        ///<summary>(0024,0074) VR=CS VM=1 Short Term Fluctuation Calculated</summary>
        public const uint ShortTermFluctuationCalculated = 0x00240074;

        ///<summary>(0024,0075) VR=FL VM=1 Short Term Fluctuation</summary>
        public const uint ShortTermFluctuation = 0x00240075;

        ///<summary>(0024,0076) VR=CS VM=1 Short Term Fluctuation Probability Calculated</summary>
        public const uint ShortTermFluctuationProbabilityCalculated = 0x00240076;

        ///<summary>(0024,0077) VR=FL VM=1 Short Term Fluctuation Probability</summary>
        public const uint ShortTermFluctuationProbability = 0x00240077;

        ///<summary>(0024,0078) VR=CS VM=1 Corrected Localized Deviation From Normal Calculated</summary>
        public const uint CorrectedLocalizedDeviationFromNormalCalculated = 0x00240078;

        ///<summary>(0024,0079) VR=FL VM=1 Corrected Localized Deviation From Normal</summary>
        public const uint CorrectedLocalizedDeviationFromNormal = 0x00240079;

        ///<summary>(0024,0080) VR=CS VM=1 Corrected Localized Deviation From Normal Probability Calculated</summary>
        public const uint CorrectedLocalizedDeviationFromNormalProbabilityCalculated = 0x00240080;

        ///<summary>(0024,0081) VR=FL VM=1 Corrected Localized Deviation From Normal Probability</summary>
        public const uint CorrectedLocalizedDeviationFromNormalProbability = 0x00240081;

        ///<summary>(0024,0083) VR=SQ VM=1 Global Deviation Probability Sequence</summary>
        public const uint GlobalDeviationProbabilitySequence = 0x00240083;

        ///<summary>(0024,0085) VR=SQ VM=1 Localized Deviation Probability Sequence</summary>
        public const uint LocalizedDeviationProbabilitySequence = 0x00240085;

        ///<summary>(0024,0086) VR=CS VM=1 Foveal Sensitivity Measured</summary>
        public const uint FovealSensitivityMeasured = 0x00240086;

        ///<summary>(0024,0087) VR=FL VM=1 Foveal Sensitivity</summary>
        public const uint FovealSensitivity = 0x00240087;

        ///<summary>(0024,0088) VR=FL VM=1 Visual Field Test Duration</summary>
        public const uint VisualFieldTestDuration = 0x00240088;

        ///<summary>(0024,0089) VR=SQ VM=1 Visual Field Test Point Sequence</summary>
        public const uint VisualFieldTestPointSequence = 0x00240089;

        ///<summary>(0024,0090) VR=FL VM=1 Visual Field Test Point X-Coordinate</summary>
        public const uint VisualFieldTestPointXCoordinate = 0x00240090;

        ///<summary>(0024,0091) VR=FL VM=1 Visual Field Test Point Y-Coordinate</summary>
        public const uint VisualFieldTestPointYCoordinate = 0x00240091;

        ///<summary>(0024,0092) VR=FL VM=1 Age Corrected Sensitivity Deviation Value</summary>
        public const uint AgeCorrectedSensitivityDeviationValue = 0x00240092;

        ///<summary>(0024,0093) VR=CS VM=1 Stimulus Results</summary>
        public const uint StimulusResults = 0x00240093;

        ///<summary>(0024,0094) VR=FL VM=1 Sensitivity Value</summary>
        public const uint SensitivityValue = 0x00240094;

        ///<summary>(0024,0095) VR=CS VM=1 Retest Stimulus Seen</summary>
        public const uint RetestStimulusSeen = 0x00240095;

        ///<summary>(0024,0096) VR=FL VM=1 Retest Sensitivity Value</summary>
        public const uint RetestSensitivityValue = 0x00240096;

        ///<summary>(0024,0097) VR=SQ VM=1 Visual Field Test Point Normals Sequence</summary>
        public const uint VisualFieldTestPointNormalsSequence = 0x00240097;

        ///<summary>(0024,0098) VR=FL VM=1 Quantified Defect</summary>
        public const uint QuantifiedDefect = 0x00240098;

        ///<summary>(0024,0100) VR=FL VM=1 Age Corrected Sensitivity Deviation Probability Value</summary>
        public const uint AgeCorrectedSensitivityDeviationProbabilityValue = 0x00240100;

        ///<summary>(0024,0102) VR=CS VM=1 Generalized Defect Corrected Sensitivity Deviation Flag</summary>
        public const uint GeneralizedDefectCorrectedSensitivityDeviationFlag = 0x00240102;

        ///<summary>(0024,0103) VR=FL VM=1 Generalized Defect Corrected Sensitivity Deviation Value</summary>
        public const uint GeneralizedDefectCorrectedSensitivityDeviationValue = 0x00240103;

        ///<summary>(0024,0104) VR=FL VM=1 Generalized Defect Corrected Sensitivity Deviation Probability Value</summary>
        public const uint GeneralizedDefectCorrectedSensitivityDeviationProbabilityValue = 0x00240104;

        ///<summary>(0024,0105) VR=FL VM=1 Minimum Sensitivity Value</summary>
        public const uint MinimumSensitivityValue = 0x00240105;

        ///<summary>(0024,0106) VR=CS VM=1 Blind Spot Localized</summary>
        public const uint BlindSpotLocalized = 0x00240106;

        ///<summary>(0024,0107) VR=FL VM=1 Blind Spot X-Coordinate</summary>
        public const uint BlindSpotXCoordinate = 0x00240107;

        ///<summary>(0024,0108) VR=FL VM=1 Blind Spot Y-Coordinate</summary>
        public const uint BlindSpotYCoordinate = 0x00240108;

        ///<summary>(0024,0110) VR=SQ VM=1 Visual Acuity Measurement Sequence</summary>
        public const uint VisualAcuityMeasurementSequence = 0x00240110;

        ///<summary>(0024,0112) VR=SQ VM=1 Refractive Parameters Used on Patient Sequence</summary>
        public const uint RefractiveParametersUsedOnPatientSequence = 0x00240112;

        ///<summary>(0024,0113) VR=CS VM=1 Measurement Laterality</summary>
        public const uint MeasurementLaterality = 0x00240113;

        ///<summary>(0024,0114) VR=SQ VM=1 Ophthalmic Patient Clinical Information Left Eye Sequence</summary>
        public const uint OphthalmicPatientClinicalInformationLeftEyeSequence = 0x00240114;

        ///<summary>(0024,0115) VR=SQ VM=1 Ophthalmic Patient Clinical Information Right Eye Sequence</summary>
        public const uint OphthalmicPatientClinicalInformationRightEyeSequence = 0x00240115;

        ///<summary>(0024,0117) VR=CS VM=1 Foveal Point Normative Data Flag</summary>
        public const uint FovealPointNormativeDataFlag = 0x00240117;

        ///<summary>(0024,0118) VR=FL VM=1 Foveal Point Probability Value</summary>
        public const uint FovealPointProbabilityValue = 0x00240118;

        ///<summary>(0024,0120) VR=CS VM=1 Screening Baseline Measured</summary>
        public const uint ScreeningBaselineMeasured = 0x00240120;

        ///<summary>(0024,0122) VR=SQ VM=1 Screening Baseline Measured Sequence</summary>
        public const uint ScreeningBaselineMeasuredSequence = 0x00240122;

        ///<summary>(0024,0124) VR=CS VM=1 Screening Baseline Type</summary>
        public const uint ScreeningBaselineType = 0x00240124;

        ///<summary>(0024,0126) VR=FL VM=1 Screening Baseline Value</summary>
        public const uint ScreeningBaselineValue = 0x00240126;

        ///<summary>(0024,0202) VR=LO VM=1 Algorithm Source</summary>
        public const uint AlgorithmSource = 0x00240202;

        ///<summary>(0024,0306) VR=LO VM=1 Data Set Name</summary>
        public const uint DataSetName = 0x00240306;

        ///<summary>(0024,0307) VR=LO VM=1 Data Set Version</summary>
        public const uint DataSetVersion = 0x00240307;

        ///<summary>(0024,0308) VR=LO VM=1 Data Set Source</summary>
        public const uint DataSetSource = 0x00240308;

        ///<summary>(0024,0309) VR=LO VM=1 Data Set Description</summary>
        public const uint DataSetDescription = 0x00240309;

        ///<summary>(0024,0317) VR=SQ VM=1 Visual Field Test Reliability Global Index Sequence</summary>
        public const uint VisualFieldTestReliabilityGlobalIndexSequence = 0x00240317;

        ///<summary>(0024,0320) VR=SQ VM=1 Visual Field Global Results Index Sequence</summary>
        public const uint VisualFieldGlobalResultsIndexSequence = 0x00240320;

        ///<summary>(0024,0325) VR=SQ VM=1 Data Observation Sequence</summary>
        public const uint DataObservationSequence = 0x00240325;

        ///<summary>(0024,0338) VR=CS VM=1 Index Normals Flag</summary>
        public const uint IndexNormalsFlag = 0x00240338;

        ///<summary>(0024,0341) VR=FL VM=1 Index Probability</summary>
        public const uint IndexProbability = 0x00240341;

        ///<summary>(0024,0344) VR=SQ VM=1 Index Probability Sequence</summary>
        public const uint IndexProbabilitySequence = 0x00240344;

        ///<summary>(0028,0002) VR=US VM=1 Samples per Pixel</summary>
        public const uint SamplesPerPixel = 0x00280002;

        ///<summary>(0028,0003) VR=US VM=1 Samples per Pixel Used</summary>
        public const uint SamplesPerPixelUsed = 0x00280003;

        ///<summary>(0028,0004) VR=CS VM=1 Photometric Interpretation</summary>
        public const uint PhotometricInterpretation = 0x00280004;

        ///<summary>(0028,0005) VR=US VM=1 Image Dimensions (RETIRED)</summary>
        public const uint ImageDimensionsRETIRED = 0x00280005;

        ///<summary>(0028,0006) VR=US VM=1 Planar Configuration</summary>
        public const uint PlanarConfiguration = 0x00280006;

        ///<summary>(0028,0008) VR=IS VM=1 Number of Frames</summary>
        public const uint NumberOfFrames = 0x00280008;

        ///<summary>(0028,0009) VR=AT VM=1-n Frame Increment Pointer</summary>
        public const uint FrameIncrementPointer = 0x00280009;

        ///<summary>(0028,000A) VR=AT VM=1-n Frame Dimension Pointer</summary>
        public const uint FrameDimensionPointer = 0x0028000A;

        ///<summary>(0028,0010) VR=US VM=1 Rows</summary>
        public const uint Rows = 0x00280010;

        ///<summary>(0028,0011) VR=US VM=1 Columns</summary>
        public const uint Columns = 0x00280011;

        ///<summary>(0028,0012) VR=US VM=1 Planes (RETIRED)</summary>
        public const uint PlanesRETIRED = 0x00280012;

        ///<summary>(0028,0014) VR=US VM=1 Ultrasound Color Data Present</summary>
        public const uint UltrasoundColorDataPresent = 0x00280014;

        ///<summary>(0028,0030) VR=DS VM=2 Pixel Spacing</summary>
        public const uint PixelSpacing = 0x00280030;

        ///<summary>(0028,0031) VR=DS VM=2 Zoom Factor</summary>
        public const uint ZoomFactor = 0x00280031;

        ///<summary>(0028,0032) VR=DS VM=2 Zoom Center</summary>
        public const uint ZoomCenter = 0x00280032;

        ///<summary>(0028,0034) VR=IS VM=2 Pixel Aspect Ratio</summary>
        public const uint PixelAspectRatio = 0x00280034;

        ///<summary>(0028,0040) VR=CS VM=1 Image Format (RETIRED)</summary>
        public const uint ImageFormatRETIRED = 0x00280040;

        ///<summary>(0028,0050) VR=LO VM=1-n Manipulated Image (RETIRED)</summary>
        public const uint ManipulatedImageRETIRED = 0x00280050;

        ///<summary>(0028,0051) VR=CS VM=1-n Corrected Image</summary>
        public const uint CorrectedImage = 0x00280051;

        ///<summary>(0028,005F) VR=LO VM=1 Compression Recognition Code (RETIRED)</summary>
        public const uint CompressionRecognitionCodeRETIRED = 0x0028005F;

        ///<summary>(0028,0060) VR=CS VM=1 Compression Code (RETIRED)</summary>
        public const uint CompressionCodeRETIRED = 0x00280060;

        ///<summary>(0028,0061) VR=SH VM=1 Compression Originator (RETIRED)</summary>
        public const uint CompressionOriginatorRETIRED = 0x00280061;

        ///<summary>(0028,0062) VR=LO VM=1 Compression Label (RETIRED)</summary>
        public const uint CompressionLabelRETIRED = 0x00280062;

        ///<summary>(0028,0063) VR=SH VM=1 Compression Description (RETIRED)</summary>
        public const uint CompressionDescriptionRETIRED = 0x00280063;

        ///<summary>(0028,0065) VR=CS VM=1-n Compression Sequence (RETIRED)</summary>
        public const uint CompressionSequenceRETIRED = 0x00280065;

        ///<summary>(0028,0066) VR=AT VM=1-n Compression Step Pointers (RETIRED)</summary>
        public const uint CompressionStepPointersRETIRED = 0x00280066;

        ///<summary>(0028,0068) VR=US VM=1 Repeat Interval (RETIRED)</summary>
        public const uint RepeatIntervalRETIRED = 0x00280068;

        ///<summary>(0028,0069) VR=US VM=1 Bits Grouped (RETIRED)</summary>
        public const uint BitsGroupedRETIRED = 0x00280069;

        ///<summary>(0028,0070) VR=US VM=1-n Perimeter Table (RETIRED)</summary>
        public const uint PerimeterTableRETIRED = 0x00280070;

        ///<summary>(0028,0071) VR=US/SS VM=1 Perimeter Value (RETIRED)</summary>
        public const uint PerimeterValueRETIRED = 0x00280071;

        ///<summary>(0028,0080) VR=US VM=1 Predictor Rows (RETIRED)</summary>
        public const uint PredictorRowsRETIRED = 0x00280080;

        ///<summary>(0028,0081) VR=US VM=1 Predictor Columns (RETIRED)</summary>
        public const uint PredictorColumnsRETIRED = 0x00280081;

        ///<summary>(0028,0082) VR=US VM=1-n Predictor Constants (RETIRED)</summary>
        public const uint PredictorConstantsRETIRED = 0x00280082;

        ///<summary>(0028,0090) VR=CS VM=1 Blocked Pixels (RETIRED)</summary>
        public const uint BlockedPixelsRETIRED = 0x00280090;

        ///<summary>(0028,0091) VR=US VM=1 Block Rows (RETIRED)</summary>
        public const uint BlockRowsRETIRED = 0x00280091;

        ///<summary>(0028,0092) VR=US VM=1 Block Columns (RETIRED)</summary>
        public const uint BlockColumnsRETIRED = 0x00280092;

        ///<summary>(0028,0093) VR=US VM=1 Row Overlap (RETIRED)</summary>
        public const uint RowOverlapRETIRED = 0x00280093;

        ///<summary>(0028,0094) VR=US VM=1 Column Overlap (RETIRED)</summary>
        public const uint ColumnOverlapRETIRED = 0x00280094;

        ///<summary>(0028,0100) VR=US VM=1 Bits Allocated</summary>
        public const uint BitsAllocated = 0x00280100;

        ///<summary>(0028,0101) VR=US VM=1 Bits Stored</summary>
        public const uint BitsStored = 0x00280101;

        ///<summary>(0028,0102) VR=US VM=1 High Bit</summary>
        public const uint HighBit = 0x00280102;

        ///<summary>(0028,0103) VR=US VM=1 Pixel Representation</summary>
        public const uint PixelRepresentation = 0x00280103;

        ///<summary>(0028,0104) VR=US/SS VM=1 Smallest Valid Pixel Value (RETIRED)</summary>
        public const uint SmallestValidPixelValueRETIRED = 0x00280104;

        ///<summary>(0028,0105) VR=US/SS VM=1 Largest Valid Pixel Value (RETIRED)</summary>
        public const uint LargestValidPixelValueRETIRED = 0x00280105;

        ///<summary>(0028,0106) VR=US/SS VM=1 Smallest Image Pixel Value</summary>
        public const uint SmallestImagePixelValue = 0x00280106;

        ///<summary>(0028,0107) VR=US/SS VM=1 Largest Image Pixel Value</summary>
        public const uint LargestImagePixelValue = 0x00280107;

        ///<summary>(0028,0108) VR=US/SS VM=1 Smallest Pixel Value in Series</summary>
        public const uint SmallestPixelValueInSeries = 0x00280108;

        ///<summary>(0028,0109) VR=US/SS VM=1 Largest Pixel Value in Series</summary>
        public const uint LargestPixelValueInSeries = 0x00280109;

        ///<summary>(0028,0110) VR=US/SS VM=1 Smallest Image Pixel Value in Plane (RETIRED)</summary>
        public const uint SmallestImagePixelValueInPlaneRETIRED = 0x00280110;

        ///<summary>(0028,0111) VR=US/SS VM=1 Largest Image Pixel Value in Plane (RETIRED)</summary>
        public const uint LargestImagePixelValueInPlaneRETIRED = 0x00280111;

        ///<summary>(0028,0120) VR=US/SS VM=1 Pixel Padding Value</summary>
        public const uint PixelPaddingValue = 0x00280120;

        ///<summary>(0028,0121) VR=US/SS VM=1 Pixel Padding Range Limit</summary>
        public const uint PixelPaddingRangeLimit = 0x00280121;

        ///<summary>(0028,0122) VR=FL VM=1 Float Pixel Padding Value</summary>
        public const uint FloatPixelPaddingValue = 0x00280122;

        ///<summary>(0028,0123) VR=FD VM=1 Double Float Pixel Padding Value</summary>
        public const uint DoubleFloatPixelPaddingValue = 0x00280123;

        ///<summary>(0028,0124) VR=FL VM=1 Float Pixel Padding Range Limit</summary>
        public const uint FloatPixelPaddingRangeLimit = 0x00280124;

        ///<summary>(0028,0125) VR=FD VM=1 Double Float Pixel Padding Range Limit</summary>
        public const uint DoubleFloatPixelPaddingRangeLimit = 0x00280125;

        ///<summary>(0028,0200) VR=US VM=1 Image Location (RETIRED)</summary>
        public const uint ImageLocationRETIRED = 0x00280200;

        ///<summary>(0028,0300) VR=CS VM=1 Quality Control Image</summary>
        public const uint QualityControlImage = 0x00280300;

        ///<summary>(0028,0301) VR=CS VM=1 Burned In Annotation</summary>
        public const uint BurnedInAnnotation = 0x00280301;

        ///<summary>(0028,0302) VR=CS VM=1 Recognizable Visual Features</summary>
        public const uint RecognizableVisualFeatures = 0x00280302;

        ///<summary>(0028,0303) VR=CS VM=1 Longitudinal Temporal Information Modified</summary>
        public const uint LongitudinalTemporalInformationModified = 0x00280303;

        ///<summary>(0028,0304) VR=UI VM=1 Referenced Color Palette Instance Uid</summary>
        public const uint ReferencedColorPaletteInstanceUid = 0x00280304;

        ///<summary>(0028,0400) VR=LO VM=1 Transform Label (RETIRED)</summary>
        public const uint TransformLabelRETIRED = 0x00280400;

        ///<summary>(0028,0401) VR=LO VM=1 Transform Version Number (RETIRED)</summary>
        public const uint TransformVersionNumberRETIRED = 0x00280401;

        ///<summary>(0028,0402) VR=US VM=1 Number of Transform Steps (RETIRED)</summary>
        public const uint NumberOfTransformStepsRETIRED = 0x00280402;

        ///<summary>(0028,0403) VR=LO VM=1-n Sequence of Compressed Data (RETIRED)</summary>
        public const uint SequenceOfCompressedDataRETIRED = 0x00280403;

        ///<summary>(0028,0404) VR=AT VM=1-n Details of Coefficients (RETIRED)</summary>
        public const uint DetailsOfCoefficientsRETIRED = 0x00280404;

        ///<summary>(0028,04x0) VR=US VM=1 Rows For Nth Order Coefficients (RETIRED)</summary>
        public const uint RowsForNthOrderCoefficientsRETIRED = 0x00280400;

        ///<summary>(0028,04x1) VR=US VM=1 Columns For Nth Order Coefficients (RETIRED)</summary>
        public const uint ColumnsForNthOrderCoefficientsRETIRED = 0x00280401;

        ///<summary>(0028,04x2) VR=LO VM=1-n Coefficient Coding (RETIRED)</summary>
        public const uint CoefficientCodingRETIRED = 0x00280402;

        ///<summary>(0028,04x3) VR=AT VM=1-n Coefficient Coding Pointers (RETIRED)</summary>
        public const uint CoefficientCodingPointersRETIRED = 0x00280403;

        ///<summary>(0028,0700) VR=LO VM=1 DCT Label (RETIRED)</summary>
        public const uint DCTLabelRETIRED = 0x00280700;

        ///<summary>(0028,0701) VR=CS VM=1-n Data Block Description (RETIRED)</summary>
        public const uint DataBlockDescriptionRETIRED = 0x00280701;

        ///<summary>(0028,0702) VR=AT VM=1-n Data Block (RETIRED)</summary>
        public const uint DataBlockRETIRED = 0x00280702;

        ///<summary>(0028,0710) VR=US VM=1 Normalization Factor Format (RETIRED)</summary>
        public const uint NormalizationFactorFormatRETIRED = 0x00280710;

        ///<summary>(0028,0720) VR=US VM=1 Zonal Map Number Format (RETIRED)</summary>
        public const uint ZonalMapNumberFormatRETIRED = 0x00280720;

        ///<summary>(0028,0721) VR=AT VM=1-n Zonal Map Location (RETIRED)</summary>
        public const uint ZonalMapLocationRETIRED = 0x00280721;

        ///<summary>(0028,0722) VR=US VM=1 Zonal Map Format (RETIRED)</summary>
        public const uint ZonalMapFormatRETIRED = 0x00280722;

        ///<summary>(0028,0730) VR=US VM=1 Adaptive Map Format (RETIRED)</summary>
        public const uint AdaptiveMapFormatRETIRED = 0x00280730;

        ///<summary>(0028,0740) VR=US VM=1 Code Number Format (RETIRED)</summary>
        public const uint CodeNumberFormatRETIRED = 0x00280740;

        ///<summary>(0028,08x0) VR=CS VM=1-n Code Label (RETIRED)</summary>
        public const uint CodeLabelRETIRED = 0x00280800;

        ///<summary>(0028,08x2) VR=US VM=1 Number of Tables (RETIRED)</summary>
        public const uint NumberOfTablesRETIRED = 0x00280802;

        ///<summary>(0028,08x3) VR=AT VM=1-n Code Table Location (RETIRED)</summary>
        public const uint CodeTableLocationRETIRED = 0x00280803;

        ///<summary>(0028,08x4) VR=US VM=1 Bits For Code Word (RETIRED)</summary>
        public const uint BitsForCodeWordRETIRED = 0x00280804;

        ///<summary>(0028,08x8) VR=AT VM=1-n Image Data Location (RETIRED)</summary>
        public const uint ImageDataLocationRETIRED = 0x00280808;

        ///<summary>(0028,0A02) VR=CS VM=1 Pixel Spacing Calibration Type</summary>
        public const uint PixelSpacingCalibrationType = 0x00280A02;

        ///<summary>(0028,0A04) VR=LO VM=1 Pixel Spacing Calibration Description</summary>
        public const uint PixelSpacingCalibrationDescription = 0x00280A04;

        ///<summary>(0028,1040) VR=CS VM=1 Pixel Intensity Relationship</summary>
        public const uint PixelIntensityRelationship = 0x00281040;

        ///<summary>(0028,1041) VR=SS VM=1 Pixel Intensity Relationship Sign</summary>
        public const uint PixelIntensityRelationshipSign = 0x00281041;

        ///<summary>(0028,1050) VR=DS VM=1-n Window Center</summary>
        public const uint WindowCenter = 0x00281050;

        ///<summary>(0028,1051) VR=DS VM=1-n Window Width</summary>
        public const uint WindowWidth = 0x00281051;

        ///<summary>(0028,1052) VR=DS VM=1 Rescale Intercept</summary>
        public const uint RescaleIntercept = 0x00281052;

        ///<summary>(0028,1053) VR=DS VM=1 Rescale Slope</summary>
        public const uint RescaleSlope = 0x00281053;

        ///<summary>(0028,1054) VR=LO VM=1 Rescale Type</summary>
        public const uint RescaleType = 0x00281054;

        ///<summary>(0028,1055) VR=LO VM=1-n Window Center &amp; Width Explanation</summary>
        public const uint WindowCenterWidthExplanation = 0x00281055;

        ///<summary>(0028,1056) VR=CS VM=1 VOI LUT Function</summary>
        public const uint VOILUTFunction = 0x00281056;

        ///<summary>(0028,1080) VR=CS VM=1 Gray Scale (RETIRED)</summary>
        public const uint GrayScaleRETIRED = 0x00281080;

        ///<summary>(0028,1090) VR=CS VM=1 Recommended Viewing Mode</summary>
        public const uint RecommendedViewingMode = 0x00281090;

        ///<summary>(0028,1100) VR=US/SS VM=3 Gray Lookup Table Descriptor (RETIRED)</summary>
        public const uint GrayLookupTableDescriptorRETIRED = 0x00281100;

        ///<summary>(0028,1101) VR=US/SS VM=3 Red Palette Color Lookup Table Descriptor</summary>
        public const uint RedPaletteColorLookupTableDescriptor = 0x00281101;

        ///<summary>(0028,1102) VR=US/SS VM=3 Green Palette Color Lookup Table Descriptor</summary>
        public const uint GreenPaletteColorLookupTableDescriptor = 0x00281102;

        ///<summary>(0028,1103) VR=US/SS VM=3 Blue Palette Color Lookup Table Descriptor</summary>
        public const uint BluePaletteColorLookupTableDescriptor = 0x00281103;

        ///<summary>(0028,1104) VR=US VM=3 Alpha Palette Color Lookup Table Descriptor</summary>
        public const uint AlphaPaletteColorLookupTableDescriptor = 0x00281104;

        ///<summary>(0028,1111) VR=US/SS VM=4 Large Red Palette Color Lookup Table Descriptor (RETIRED)</summary>
        public const uint LargeRedPaletteColorLookupTableDescriptorRETIRED = 0x00281111;

        ///<summary>(0028,1112) VR=US/SS VM=4 Large Green Palette Color Lookup Table Descriptor (RETIRED)</summary>
        public const uint LargeGreenPaletteColorLookupTableDescriptorRETIRED = 0x00281112;

        ///<summary>(0028,1113) VR=US/SS VM=4 Large Blue Palette Color Lookup Table Descriptor (RETIRED)</summary>
        public const uint LargeBluePaletteColorLookupTableDescriptorRETIRED = 0x00281113;

        ///<summary>(0028,1199) VR=UI VM=1 Palette Color Lookup Table Uid</summary>
        public const uint PaletteColorLookupTableUid = 0x00281199;

        ///<summary>(0028,1200) VR=US/SS/OW VM=1-n or 1 Gray Lookup Table Data (RETIRED)</summary>
        public const uint GrayLookupTableDataRETIRED = 0x00281200;

        ///<summary>(0028,1201) VR=OW VM=1 Red Palette Color Lookup Table Data</summary>
        public const uint RedPaletteColorLookupTableData = 0x00281201;

        ///<summary>(0028,1202) VR=OW VM=1 Green Palette Color Lookup Table Data</summary>
        public const uint GreenPaletteColorLookupTableData = 0x00281202;

        ///<summary>(0028,1203) VR=OW VM=1 Blue Palette Color Lookup Table Data</summary>
        public const uint BluePaletteColorLookupTableData = 0x00281203;

        ///<summary>(0028,1204) VR=OW VM=1 Alpha Palette Color Lookup Table Data</summary>
        public const uint AlphaPaletteColorLookupTableData = 0x00281204;

        ///<summary>(0028,1211) VR=OW VM=1 Large Red Palette Color Lookup Table Data (RETIRED)</summary>
        public const uint LargeRedPaletteColorLookupTableDataRETIRED = 0x00281211;

        ///<summary>(0028,1212) VR=OW VM=1 Large Green Palette Color Lookup Table Data (RETIRED)</summary>
        public const uint LargeGreenPaletteColorLookupTableDataRETIRED = 0x00281212;

        ///<summary>(0028,1213) VR=OW VM=1 Large Blue Palette Color Lookup Table Data (RETIRED)</summary>
        public const uint LargeBluePaletteColorLookupTableDataRETIRED = 0x00281213;

        ///<summary>(0028,1214) VR=UI VM=1 Large Palette Color Lookup Table Uid (RETIRED)</summary>
        public const uint LargePaletteColorLookupTableUidRETIRED = 0x00281214;

        ///<summary>(0028,1221) VR=OW VM=1 Segmented Red Palette Color Lookup Table Data</summary>
        public const uint SegmentedRedPaletteColorLookupTableData = 0x00281221;

        ///<summary>(0028,1222) VR=OW VM=1 Segmented Green Palette Color Lookup Table Data</summary>
        public const uint SegmentedGreenPaletteColorLookupTableData = 0x00281222;

        ///<summary>(0028,1223) VR=OW VM=1 Segmented Blue Palette Color Lookup Table Data</summary>
        public const uint SegmentedBluePaletteColorLookupTableData = 0x00281223;

        ///<summary>(0028,1224) VR=OW VM=1 Segmented Alpha Palette Color Lookup Table Data</summary>
        public const uint SegmentedAlphaPaletteColorLookupTableData = 0x00281224;

        ///<summary>(0028,1230) VR=SQ VM=1 Stored Value Color Range Sequence</summary>
        public const uint StoredValueColorRangeSequence = 0x00281230;

        ///<summary>(0028,1231) VR=FD VM=1 Minimum Stored Value Mapped</summary>
        public const uint MinimumStoredValueMapped = 0x00281231;

        ///<summary>(0028,1232) VR=FD VM=1 Maximum Stored Value Mapped</summary>
        public const uint MaximumStoredValueMapped = 0x00281232;

        ///<summary>(0028,1300) VR=CS VM=1 Breast Implant Present</summary>
        public const uint BreastImplantPresent = 0x00281300;

        ///<summary>(0028,1350) VR=CS VM=1 Partial View</summary>
        public const uint PartialView = 0x00281350;

        ///<summary>(0028,1351) VR=ST VM=1 Partial View Description</summary>
        public const uint PartialViewDescription = 0x00281351;

        ///<summary>(0028,1352) VR=SQ VM=1 Partial View Code Sequence</summary>
        public const uint PartialViewCodeSequence = 0x00281352;

        ///<summary>(0028,135A) VR=CS VM=1 Spatial Locations Preserved</summary>
        public const uint SpatialLocationsPreserved = 0x0028135A;

        ///<summary>(0028,1401) VR=SQ VM=1 Data Frame Assignment Sequence</summary>
        public const uint DataFrameAssignmentSequence = 0x00281401;

        ///<summary>(0028,1402) VR=CS VM=1 Data Path Assignment</summary>
        public const uint DataPathAssignment = 0x00281402;

        ///<summary>(0028,1403) VR=US VM=1 Bits Mapped to Color Lookup Table</summary>
        public const uint BitsMappedToColorLookupTable = 0x00281403;

        ///<summary>(0028,1404) VR=SQ VM=1 Blending LUT 1 Sequence</summary>
        public const uint BlendingLUT1Sequence = 0x00281404;

        ///<summary>(0028,1405) VR=CS VM=1 Blending LUT 1 Transfer Function</summary>
        public const uint BlendingLUT1TransferFunction = 0x00281405;

        ///<summary>(0028,1406) VR=FD VM=1 Blending Weight Constant</summary>
        public const uint BlendingWeightConstant = 0x00281406;

        ///<summary>(0028,1407) VR=US VM=3 Blending Lookup Table Descriptor</summary>
        public const uint BlendingLookupTableDescriptor = 0x00281407;

        ///<summary>(0028,1408) VR=OW VM=1 Blending Lookup Table Data</summary>
        public const uint BlendingLookupTableData = 0x00281408;

        ///<summary>(0028,140B) VR=SQ VM=1 Enhanced Palette Color Lookup Table Sequence</summary>
        public const uint EnhancedPaletteColorLookupTableSequence = 0x0028140B;

        ///<summary>(0028,140C) VR=SQ VM=1 Blending LUT 2 Sequence</summary>
        public const uint BlendingLUT2Sequence = 0x0028140C;

        ///<summary>(0028,140D) VR=CS VM=1 Blending LUT 2 Transfer Function</summary>
        public const uint BlendingLUT2TransferFunction = 0x0028140D;

        ///<summary>(0028,140E) VR=CS VM=1 Data Path Id</summary>
        public const uint DataPathId = 0x0028140E;

        ///<summary>(0028,140F) VR=CS VM=1 RGB LUT Transfer Function</summary>
        public const uint RGBLUTTransferFunction = 0x0028140F;

        ///<summary>(0028,1410) VR=CS VM=1 Alpha LUT Transfer Function</summary>
        public const uint AlphaLUTTransferFunction = 0x00281410;

        ///<summary>(0028,2000) VR=OB VM=1 ICC Profile</summary>
        public const uint ICCProfile = 0x00282000;

        ///<summary>(0028,2002) VR=CS VM=1 Color Space</summary>
        public const uint ColorSpace = 0x00282002;

        ///<summary>(0028,2110) VR=CS VM=1 Lossy Image Compression</summary>
        public const uint LossyImageCompression = 0x00282110;

        ///<summary>(0028,2112) VR=DS VM=1-n Lossy Image Compression Ratio</summary>
        public const uint LossyImageCompressionRatio = 0x00282112;

        ///<summary>(0028,2114) VR=CS VM=1-n Lossy Image Compression Method</summary>
        public const uint LossyImageCompressionMethod = 0x00282114;

        ///<summary>(0028,3000) VR=SQ VM=1 Modality LUT Sequence</summary>
        public const uint ModalityLUTSequence = 0x00283000;

        ///<summary>(0028,3002) VR=US/SS VM=3 LUT Descriptor</summary>
        public const uint LUTDescriptor = 0x00283002;

        ///<summary>(0028,3003) VR=LO VM=1 LUT Explanation</summary>
        public const uint LUTExplanation = 0x00283003;

        ///<summary>(0028,3004) VR=LO VM=1 Modality LUT Type</summary>
        public const uint ModalityLUTType = 0x00283004;

        ///<summary>(0028,3006) VR=US/OW VM=1-n or 1 LUT Data</summary>
        public const uint LUTData = 0x00283006;

        ///<summary>(0028,3010) VR=SQ VM=1 VOI LUT Sequence</summary>
        public const uint VOILUTSequence = 0x00283010;

        ///<summary>(0028,3110) VR=SQ VM=1 Softcopy VOI LUT Sequence</summary>
        public const uint SoftcopyVOILUTSequence = 0x00283110;

        ///<summary>(0028,4000) VR=LT VM=1 Image Presentation Comments (RETIRED)</summary>
        public const uint ImagePresentationCommentsRETIRED = 0x00284000;

        ///<summary>(0028,5000) VR=SQ VM=1 Bi-Plane Acquisition Sequence (RETIRED)</summary>
        public const uint BiPlaneAcquisitionSequenceRETIRED = 0x00285000;

        ///<summary>(0028,6010) VR=US VM=1 Representative Frame Number</summary>
        public const uint RepresentativeFrameNumber = 0x00286010;

        ///<summary>(0028,6020) VR=US VM=1-n Frame Numbers of Interest (FOI)</summary>
        public const uint FrameNumbersOfInterest = 0x00286020;

        ///<summary>(0028,6022) VR=LO VM=1-n Frame of Interest Description</summary>
        public const uint FrameOfInterestDescription = 0x00286022;

        ///<summary>(0028,6023) VR=CS VM=1-n Frame of Interest Type</summary>
        public const uint FrameOfInterestType = 0x00286023;

        ///<summary>(0028,6030) VR=US VM=1-n Mask Pointer(s) (RETIRED)</summary>
        public const uint MaskPointersRETIRED = 0x00286030;

        ///<summary>(0028,6040) VR=US VM=1-n R Wave Pointer</summary>
        public const uint RWavePointer = 0x00286040;

        ///<summary>(0028,6100) VR=SQ VM=1 Mask Subtraction Sequence</summary>
        public const uint MaskSubtractionSequence = 0x00286100;

        ///<summary>(0028,6101) VR=CS VM=1 Mask Operation</summary>
        public const uint MaskOperation = 0x00286101;

        ///<summary>(0028,6102) VR=US VM=2-2n Applicable Frame Range</summary>
        public const uint ApplicableFrameRange = 0x00286102;

        ///<summary>(0028,6110) VR=US VM=1-n Mask Frame Numbers</summary>
        public const uint MaskFrameNumbers = 0x00286110;

        ///<summary>(0028,6112) VR=US VM=1 Contrast Frame Averaging</summary>
        public const uint ContrastFrameAveraging = 0x00286112;

        ///<summary>(0028,6114) VR=FL VM=2 Mask Sub-pixel Shift</summary>
        public const uint MaskSubPixelShift = 0x00286114;

        ///<summary>(0028,6120) VR=SS VM=1 TId Offset</summary>
        public const uint TIdOffset = 0x00286120;

        ///<summary>(0028,6190) VR=ST VM=1 Mask Operation Explanation</summary>
        public const uint MaskOperationExplanation = 0x00286190;

        ///<summary>(0028,7000) VR=SQ VM=1 Equipment Administrator Sequence</summary>
        public const uint EquipmentAdministratorSequence = 0x00287000;

        ///<summary>(0028,7001) VR=US VM=1 Number of Display Subsystems</summary>
        public const uint NumberOfDisplaySubsystems = 0x00287001;

        ///<summary>(0028,7002) VR=US VM=1 Current Configuration Id</summary>
        public const uint CurrentConfigurationId = 0x00287002;

        ///<summary>(0028,7003) VR=US VM=1 Display Subsystem Id</summary>
        public const uint DisplaySubsystemId = 0x00287003;

        ///<summary>(0028,7004) VR=SH VM=1 Display Subsystem Name</summary>
        public const uint DisplaySubsystemName = 0x00287004;

        ///<summary>(0028,7005) VR=LO VM=1 Display Subsystem Description</summary>
        public const uint DisplaySubsystemDescription = 0x00287005;

        ///<summary>(0028,7006) VR=CS VM=1 System Status</summary>
        public const uint SystemStatus = 0x00287006;

        ///<summary>(0028,7007) VR=LO VM=1 System Status Comment</summary>
        public const uint SystemStatusComment = 0x00287007;

        ///<summary>(0028,7008) VR=SQ VM=1 Target Luminance Characteristics Sequence</summary>
        public const uint TargetLuminanceCharacteristicsSequence = 0x00287008;

        ///<summary>(0028,7009) VR=US VM=1 Luminance Characteristics Id</summary>
        public const uint LuminanceCharacteristicsId = 0x00287009;

        ///<summary>(0028,700A) VR=SQ VM=1 Display Subsystem Configuration Sequence</summary>
        public const uint DisplaySubsystemConfigurationSequence = 0x0028700A;

        ///<summary>(0028,700B) VR=US VM=1 Configuration Id</summary>
        public const uint ConfigurationId = 0x0028700B;

        ///<summary>(0028,700C) VR=SH VM=1 Configuration Name</summary>
        public const uint ConfigurationName = 0x0028700C;

        ///<summary>(0028,700D) VR=LO VM=1 Configuration Description</summary>
        public const uint ConfigurationDescription = 0x0028700D;

        ///<summary>(0028,700E) VR=US VM=1 Referenced Target Luminance Characteristics Id</summary>
        public const uint ReferencedTargetLuminanceCharacteristicsId = 0x0028700E;

        ///<summary>(0028,700F) VR=SQ VM=1 QA Results Sequence</summary>
        public const uint QAResultsSequence = 0x0028700F;

        ///<summary>(0028,7010) VR=SQ VM=1 Display Subsystem QA Results Sequence</summary>
        public const uint DisplaySubsystemQAResultsSequence = 0x00287010;

        ///<summary>(0028,7011) VR=SQ VM=1 Configuration QA Results Sequence</summary>
        public const uint ConfigurationQAResultsSequence = 0x00287011;

        ///<summary>(0028,7012) VR=SQ VM=1 Measurement Equipment Sequence</summary>
        public const uint MeasurementEquipmentSequence = 0x00287012;

        ///<summary>(0028,7013) VR=CS VM=1-n Measurement Functions</summary>
        public const uint MeasurementFunctions = 0x00287013;

        ///<summary>(0028,7014) VR=CS VM=1 Measurement Equipment Type</summary>
        public const uint MeasurementEquipmentType = 0x00287014;

        ///<summary>(0028,7015) VR=SQ VM=1 Visual Evaluation Result Sequence</summary>
        public const uint VisualEvaluationResultSequence = 0x00287015;

        ///<summary>(0028,7016) VR=SQ VM=1 Display Calibration Result Sequence</summary>
        public const uint DisplayCalibrationResultSequence = 0x00287016;

        ///<summary>(0028,7017) VR=US VM=1 DDL Value</summary>
        public const uint DDLValue = 0x00287017;

        ///<summary>(0028,7018) VR=FL VM=2 CIExy White Point</summary>
        public const uint CIExyWhitePoint = 0x00287018;

        ///<summary>(0028,7019) VR=CS VM=1 Display Function Type</summary>
        public const uint DisplayFunctionType = 0x00287019;

        ///<summary>(0028,701A) VR=FL VM=1 Gamma Value</summary>
        public const uint GammaValue = 0x0028701A;

        ///<summary>(0028,701B) VR=US VM=1 Number of Luminance Points</summary>
        public const uint NumberOfLuminancePoints = 0x0028701B;

        ///<summary>(0028,701C) VR=SQ VM=1 Luminance Response Sequence</summary>
        public const uint LuminanceResponseSequence = 0x0028701C;

        ///<summary>(0028,701D) VR=FL VM=1 Target Minimum Luminance</summary>
        public const uint TargetMinimumLuminance = 0x0028701D;

        ///<summary>(0028,701E) VR=FL VM=1 Target Maximum Luminance</summary>
        public const uint TargetMaximumLuminance = 0x0028701E;

        ///<summary>(0028,701F) VR=FL VM=1 Luminance Value</summary>
        public const uint LuminanceValue = 0x0028701F;

        ///<summary>(0028,7020) VR=LO VM=1 Luminance Response Description</summary>
        public const uint LuminanceResponseDescription = 0x00287020;

        ///<summary>(0028,7021) VR=CS VM=1 White Point Flag</summary>
        public const uint WhitePointFlag = 0x00287021;

        ///<summary>(0028,7022) VR=SQ VM=1 Display Device Type Code Sequence</summary>
        public const uint DisplayDeviceTypeCodeSequence = 0x00287022;

        ///<summary>(0028,7023) VR=SQ VM=1 Display Subsystem Sequence</summary>
        public const uint DisplaySubsystemSequence = 0x00287023;

        ///<summary>(0028,7024) VR=SQ VM=1 Luminance Result Sequence</summary>
        public const uint LuminanceResultSequence = 0x00287024;

        ///<summary>(0028,7025) VR=CS VM=1 Ambient Light Value Source</summary>
        public const uint AmbientLightValueSource = 0x00287025;

        ///<summary>(0028,7026) VR=CS VM=1-n Measured Characteristics</summary>
        public const uint MeasuredCharacteristics = 0x00287026;

        ///<summary>(0028,7027) VR=SQ VM=1 Luminance Uniformity Result Sequence</summary>
        public const uint LuminanceUniformityResultSequence = 0x00287027;

        ///<summary>(0028,7028) VR=SQ VM=1 Visual Evaluation Test Sequence</summary>
        public const uint VisualEvaluationTestSequence = 0x00287028;

        ///<summary>(0028,7029) VR=CS VM=1 Test Result</summary>
        public const uint TestResult = 0x00287029;

        ///<summary>(0028,702A) VR=LO VM=1 Test Result Comment</summary>
        public const uint TestResultComment = 0x0028702A;

        ///<summary>(0028,702B) VR=CS VM=1 Test Image Validation</summary>
        public const uint TestImageValidation = 0x0028702B;

        ///<summary>(0028,702C) VR=SQ VM=1 Test Pattern Code Sequence</summary>
        public const uint TestPatternCodeSequence = 0x0028702C;

        ///<summary>(0028,702D) VR=SQ VM=1 Measurement Pattern Code Sequence</summary>
        public const uint MeasurementPatternCodeSequence = 0x0028702D;

        ///<summary>(0028,702E) VR=SQ VM=1 Visual Evaluation Method Code Sequence</summary>
        public const uint VisualEvaluationMethodCodeSequence = 0x0028702E;

        ///<summary>(0028,7FE0) VR=UR VM=1 Pixel Data Provider URL</summary>
        public const uint PixelDataProviderURL = 0x00287FE0;

        ///<summary>(0028,9001) VR=UL VM=1 Data Point Rows</summary>
        public const uint DataPointRows = 0x00289001;

        ///<summary>(0028,9002) VR=UL VM=1 Data Point Columns</summary>
        public const uint DataPointColumns = 0x00289002;

        ///<summary>(0028,9003) VR=CS VM=1 Signal Domain Columns</summary>
        public const uint SignalDomainColumns = 0x00289003;

        ///<summary>(0028,9099) VR=US VM=1 Largest Monochrome Pixel Value (RETIRED)</summary>
        public const uint LargestMonochromePixelValueRETIRED = 0x00289099;

        ///<summary>(0028,9108) VR=CS VM=1 Data Representation</summary>
        public const uint DataRepresentation = 0x00289108;

        ///<summary>(0028,9110) VR=SQ VM=1 Pixel Measures Sequence</summary>
        public const uint PixelMeasuresSequence = 0x00289110;

        ///<summary>(0028,9132) VR=SQ VM=1 Frame VOI LUT Sequence</summary>
        public const uint FrameVOILUTSequence = 0x00289132;

        ///<summary>(0028,9145) VR=SQ VM=1 Pixel Value Transformation Sequence</summary>
        public const uint PixelValueTransformationSequence = 0x00289145;

        ///<summary>(0028,9235) VR=CS VM=1 Signal Domain Rows</summary>
        public const uint SignalDomainRows = 0x00289235;

        ///<summary>(0028,9411) VR=FL VM=1 Display Filter Percentage</summary>
        public const uint DisplayFilterPercentage = 0x00289411;

        ///<summary>(0028,9415) VR=SQ VM=1 Frame Pixel Shift Sequence</summary>
        public const uint FramePixelShiftSequence = 0x00289415;

        ///<summary>(0028,9416) VR=US VM=1 Subtraction Item Id</summary>
        public const uint SubtractionItemId = 0x00289416;

        ///<summary>(0028,9422) VR=SQ VM=1 Pixel Intensity Relationship LUT Sequence</summary>
        public const uint PixelIntensityRelationshipLUTSequence = 0x00289422;

        ///<summary>(0028,9443) VR=SQ VM=1 Frame Pixel Data Properties Sequence</summary>
        public const uint FramePixelDataPropertiesSequence = 0x00289443;

        ///<summary>(0028,9444) VR=CS VM=1 Geometrical Properties</summary>
        public const uint GeometricalProperties = 0x00289444;

        ///<summary>(0028,9445) VR=FL VM=1 Geometric Maximum Distortion</summary>
        public const uint GeometricMaximumDistortion = 0x00289445;

        ///<summary>(0028,9446) VR=CS VM=1-n Image Processing Applied</summary>
        public const uint ImageProcessingApplied = 0x00289446;

        ///<summary>(0028,9454) VR=CS VM=1 Mask Selection Mode</summary>
        public const uint MaskSelectionMode = 0x00289454;

        ///<summary>(0028,9474) VR=CS VM=1 LUT Function</summary>
        public const uint LUTFunction = 0x00289474;

        ///<summary>(0028,9478) VR=FL VM=1 Mask Visibility Percentage</summary>
        public const uint MaskVisibilityPercentage = 0x00289478;

        ///<summary>(0028,9501) VR=SQ VM=1 Pixel Shift Sequence</summary>
        public const uint PixelShiftSequence = 0x00289501;

        ///<summary>(0028,9502) VR=SQ VM=1 Region Pixel Shift Sequence</summary>
        public const uint RegionPixelShiftSequence = 0x00289502;

        ///<summary>(0028,9503) VR=SS VM=2-2n Vertices of the Region</summary>
        public const uint VerticesOfTheRegion = 0x00289503;

        ///<summary>(0028,9505) VR=SQ VM=1 Multi-frame Presentation Sequence</summary>
        public const uint MultiFramePresentationSequence = 0x00289505;

        ///<summary>(0028,9506) VR=US VM=2-2n Pixel Shift Frame Range</summary>
        public const uint PixelShiftFrameRange = 0x00289506;

        ///<summary>(0028,9507) VR=US VM=2-2n LUT Frame Range</summary>
        public const uint LUTFrameRange = 0x00289507;

        ///<summary>(0028,9520) VR=DS VM=16 Image to Equipment Mapping Matrix</summary>
        public const uint ImageToEquipmentMappingMatrix = 0x00289520;

        ///<summary>(0028,9537) VR=CS VM=1 Equipment Coordinate System Identification</summary>
        public const uint EquipmentCoordinateSystemIdentification = 0x00289537;

        ///<summary>(0032,000A) VR=CS VM=1 Study Status Id (RETIRED)</summary>
        public const uint StudyStatusIdRETIRED = 0x0032000A;

        ///<summary>(0032,000C) VR=CS VM=1 Study Priority Id (RETIRED)</summary>
        public const uint StudyPriorityIdRETIRED = 0x0032000C;

        ///<summary>(0032,0012) VR=LO VM=1 Study Id Issuer (RETIRED)</summary>
        public const uint StudyIdIssuerRETIRED = 0x00320012;

        ///<summary>(0032,0032) VR=DA VM=1 Study Verified Date (RETIRED)</summary>
        public const uint StudyVerifiedDateRETIRED = 0x00320032;

        ///<summary>(0032,0033) VR=TM VM=1 Study Verified Time (RETIRED)</summary>
        public const uint StudyVerifiedTimeRETIRED = 0x00320033;

        ///<summary>(0032,0034) VR=DA VM=1 Study Read Date (RETIRED)</summary>
        public const uint StudyReadDateRETIRED = 0x00320034;

        ///<summary>(0032,0035) VR=TM VM=1 Study Read Time (RETIRED)</summary>
        public const uint StudyReadTimeRETIRED = 0x00320035;

        ///<summary>(0032,1000) VR=DA VM=1 Scheduled Study Start Date (RETIRED)</summary>
        public const uint ScheduledStudyStartDateRETIRED = 0x00321000;

        ///<summary>(0032,1001) VR=TM VM=1 Scheduled Study Start Time (RETIRED)</summary>
        public const uint ScheduledStudyStartTimeRETIRED = 0x00321001;

        ///<summary>(0032,1010) VR=DA VM=1 Scheduled Study Stop Date (RETIRED)</summary>
        public const uint ScheduledStudyStopDateRETIRED = 0x00321010;

        ///<summary>(0032,1011) VR=TM VM=1 Scheduled Study Stop Time (RETIRED)</summary>
        public const uint ScheduledStudyStopTimeRETIRED = 0x00321011;

        ///<summary>(0032,1020) VR=LO VM=1 Scheduled Study Location (RETIRED)</summary>
        public const uint ScheduledStudyLocationRETIRED = 0x00321020;

        ///<summary>(0032,1021) VR=AE VM=1-n Scheduled Study Location AE Title (RETIRED)</summary>
        public const uint ScheduledStudyLocationAETitleRETIRED = 0x00321021;

        ///<summary>(0032,1030) VR=LO VM=1 Reason for Study (RETIRED)</summary>
        public const uint ReasonForStudyRETIRED = 0x00321030;

        ///<summary>(0032,1031) VR=SQ VM=1 Requesting Physician Identification Sequence</summary>
        public const uint RequestingPhysicianIdentificationSequence = 0x00321031;

        ///<summary>(0032,1032) VR=PN VM=1 Requesting Physician</summary>
        public const uint RequestingPhysician = 0x00321032;

        ///<summary>(0032,1033) VR=LO VM=1 Requesting Service</summary>
        public const uint RequestingService = 0x00321033;

        ///<summary>(0032,1034) VR=SQ VM=1 Requesting Service Code Sequence</summary>
        public const uint RequestingServiceCodeSequence = 0x00321034;

        ///<summary>(0032,1040) VR=DA VM=1 Study Arrival Date (RETIRED)</summary>
        public const uint StudyArrivalDateRETIRED = 0x00321040;

        ///<summary>(0032,1041) VR=TM VM=1 Study Arrival Time (RETIRED)</summary>
        public const uint StudyArrivalTimeRETIRED = 0x00321041;

        ///<summary>(0032,1050) VR=DA VM=1 Study Completion Date (RETIRED)</summary>
        public const uint StudyCompletionDateRETIRED = 0x00321050;

        ///<summary>(0032,1051) VR=TM VM=1 Study Completion Time (RETIRED)</summary>
        public const uint StudyCompletionTimeRETIRED = 0x00321051;

        ///<summary>(0032,1055) VR=CS VM=1 Study Component Status Id (RETIRED)</summary>
        public const uint StudyComponentStatusIdRETIRED = 0x00321055;

        ///<summary>(0032,1060) VR=LO VM=1 Requested Procedure Description</summary>
        public const uint RequestedProcedureDescription = 0x00321060;

        ///<summary>(0032,1064) VR=SQ VM=1 Requested Procedure Code Sequence</summary>
        public const uint RequestedProcedureCodeSequence = 0x00321064;

        ///<summary>(0032,1066) VR=UT VM=1 Reason for Visit</summary>
        public const uint ReasonForVisit = 0x00321066;

        ///<summary>(0032,1067) VR=SQ VM=1 Reason for Visit Code Sequence</summary>
        public const uint ReasonForVisitCodeSequence = 0x00321067;

        ///<summary>(0032,1070) VR=LO VM=1 Requested Contrast Agent</summary>
        public const uint RequestedContrastAgent = 0x00321070;

        ///<summary>(0032,4000) VR=LT VM=1 Study Comments (RETIRED)</summary>
        public const uint StudyCommentsRETIRED = 0x00324000;

        ///<summary>(0034,0001) VR=SQ VM=1 Flow Identifier Sequence</summary>
        public const uint FlowIdentifierSequence = 0x00340001;

        ///<summary>(0034,0002) VR=OB VM=1 Flow Identifier</summary>
        public const uint FlowIdentifier = 0x00340002;

        ///<summary>(0034,0003) VR=UI VM=1 Flow Transfer Syntax Uid</summary>
        public const uint FlowTransferSyntaxUid = 0x00340003;

        ///<summary>(0034,0004) VR=UL VM=1 Flow RTP Sampling Rate</summary>
        public const uint FlowRTPSamplingRate = 0x00340004;

        ///<summary>(0034,0005) VR=OB VM=1 Source Identifier</summary>
        public const uint SourceIdentifier = 0x00340005;

        ///<summary>(0034,0007) VR=OB VM=1 Frame Origin Timestamp</summary>
        public const uint FrameOriginTimestamp = 0x00340007;

        ///<summary>(0034,0008) VR=CS VM=1 Includes Imaging Subject</summary>
        public const uint IncludesImagingSubject = 0x00340008;

        ///<summary>(0034,0009) VR=SQ VM=1 Frame Usefulness Group Sequence</summary>
        public const uint FrameUsefulnessGroupSequence = 0x00340009;

        ///<summary>(0034,000A) VR=SQ VM=1 Real-Time Bulk Data Flow Sequence</summary>
        public const uint RealTimeBulkDataFlowSequence = 0x0034000A;

        ///<summary>(0034,000B) VR=SQ VM=1 Camera Position Group Sequence</summary>
        public const uint CameraPositionGroupSequence = 0x0034000B;

        ///<summary>(0034,000C) VR=CS VM=1 Includes Information</summary>
        public const uint IncludesInformation = 0x0034000C;

        ///<summary>(0034,000D) VR=SQ VM=1 Time of Frame Group Sequence</summary>
        public const uint TimeOfFrameGroupSequence = 0x0034000D;

        ///<summary>(0038,0004) VR=SQ VM=1 Referenced Patient Alias Sequence</summary>
        public const uint ReferencedPatientAliasSequence = 0x00380004;

        ///<summary>(0038,0008) VR=CS VM=1 Visit Status Id</summary>
        public const uint VisitStatusId = 0x00380008;

        ///<summary>(0038,0010) VR=LO VM=1 Admission Id</summary>
        public const uint AdmissionId = 0x00380010;

        ///<summary>(0038,0011) VR=LO VM=1 Issuer of Admission Id (RETIRED)</summary>
        public const uint IssuerOfAdmissionIdRETIRED = 0x00380011;

        ///<summary>(0038,0014) VR=SQ VM=1 Issuer of Admission Id Sequence</summary>
        public const uint IssuerOfAdmissionIdSequence = 0x00380014;

        ///<summary>(0038,0016) VR=LO VM=1 Route of Admissions</summary>
        public const uint RouteOfAdmissions = 0x00380016;

        ///<summary>(0038,001A) VR=DA VM=1 Scheduled Admission Date (RETIRED)</summary>
        public const uint ScheduledAdmissionDateRETIRED = 0x0038001A;

        ///<summary>(0038,001B) VR=TM VM=1 Scheduled Admission Time (RETIRED)</summary>
        public const uint ScheduledAdmissionTimeRETIRED = 0x0038001B;

        ///<summary>(0038,001C) VR=DA VM=1 Scheduled Discharge Date (RETIRED)</summary>
        public const uint ScheduledDischargeDateRETIRED = 0x0038001C;

        ///<summary>(0038,001D) VR=TM VM=1 Scheduled Discharge Time (RETIRED)</summary>
        public const uint ScheduledDischargeTimeRETIRED = 0x0038001D;

        ///<summary>(0038,001E) VR=LO VM=1 Scheduled Patient Institution Residence (RETIRED)</summary>
        public const uint ScheduledPatientInstitutionResidenceRETIRED = 0x0038001E;

        ///<summary>(0038,0020) VR=DA VM=1 Admitting Date</summary>
        public const uint AdmittingDate = 0x00380020;

        ///<summary>(0038,0021) VR=TM VM=1 Admitting Time</summary>
        public const uint AdmittingTime = 0x00380021;

        ///<summary>(0038,0030) VR=DA VM=1 Discharge Date (RETIRED)</summary>
        public const uint DischargeDateRETIRED = 0x00380030;

        ///<summary>(0038,0032) VR=TM VM=1 Discharge Time (RETIRED)</summary>
        public const uint DischargeTimeRETIRED = 0x00380032;

        ///<summary>(0038,0040) VR=LO VM=1 Discharge Diagnosis Description (RETIRED)</summary>
        public const uint DischargeDiagnosisDescriptionRETIRED = 0x00380040;

        ///<summary>(0038,0044) VR=SQ VM=1 Discharge Diagnosis Code Sequence (RETIRED)</summary>
        public const uint DischargeDiagnosisCodeSequenceRETIRED = 0x00380044;

        ///<summary>(0038,0050) VR=LO VM=1 Special Needs</summary>
        public const uint SpecialNeeds = 0x00380050;

        ///<summary>(0038,0060) VR=LO VM=1 Service Episode Id</summary>
        public const uint ServiceEpisodeId = 0x00380060;

        ///<summary>(0038,0061) VR=LO VM=1 Issuer of Service Episode Id (RETIRED)</summary>
        public const uint IssuerOfServiceEpisodeIdRETIRED = 0x00380061;

        ///<summary>(0038,0062) VR=LO VM=1 Service Episode Description</summary>
        public const uint ServiceEpisodeDescription = 0x00380062;

        ///<summary>(0038,0064) VR=SQ VM=1 Issuer of Service Episode Id Sequence</summary>
        public const uint IssuerOfServiceEpisodeIdSequence = 0x00380064;

        ///<summary>(0038,0100) VR=SQ VM=1 Pertinent Documents Sequence</summary>
        public const uint PertinentDocumentsSequence = 0x00380100;

        ///<summary>(0038,0101) VR=SQ VM=1 Pertinent Resources Sequence</summary>
        public const uint PertinentResourcesSequence = 0x00380101;

        ///<summary>(0038,0102) VR=LO VM=1 Resource Description</summary>
        public const uint ResourceDescription = 0x00380102;

        ///<summary>(0038,0300) VR=LO VM=1 Current Patient Location</summary>
        public const uint CurrentPatientLocation = 0x00380300;

        ///<summary>(0038,0400) VR=LO VM=1 Patient's Institution Residence</summary>
        public const uint PatientInstitutionResidence = 0x00380400;

        ///<summary>(0038,0500) VR=LO VM=1 Patient State</summary>
        public const uint PatientState = 0x00380500;

        ///<summary>(0038,0502) VR=SQ VM=1 Patient Clinical Trial Participation Sequence</summary>
        public const uint PatientClinicalTrialParticipationSequence = 0x00380502;

        ///<summary>(0038,4000) VR=LT VM=1 Visit Comments</summary>
        public const uint VisitComments = 0x00384000;

        ///<summary>(003A,0004) VR=CS VM=1 Waveform Originality</summary>
        public const uint WaveformOriginality = 0x003A0004;

        ///<summary>(003A,0005) VR=US VM=1 Number of Waveform Channels</summary>
        public const uint NumberOfWaveformChannels = 0x003A0005;

        ///<summary>(003A,0010) VR=UL VM=1 Number of Waveform Samples</summary>
        public const uint NumberOfWaveformSamples = 0x003A0010;

        ///<summary>(003A,001A) VR=DS VM=1 Sampling Frequency</summary>
        public const uint SamplingFrequency = 0x003A001A;

        ///<summary>(003A,0020) VR=SH VM=1 Multiplex Group Label</summary>
        public const uint MultiplexGroupLabel = 0x003A0020;

        ///<summary>(003A,0200) VR=SQ VM=1 Channel Definition Sequence</summary>
        public const uint ChannelDefinitionSequence = 0x003A0200;

        ///<summary>(003A,0202) VR=IS VM=1 Waveform Channel Number</summary>
        public const uint WaveformChannelNumber = 0x003A0202;

        ///<summary>(003A,0203) VR=SH VM=1 Channel Label</summary>
        public const uint ChannelLabel = 0x003A0203;

        ///<summary>(003A,0205) VR=CS VM=1-n Channel Status</summary>
        public const uint ChannelStatus = 0x003A0205;

        ///<summary>(003A,0208) VR=SQ VM=1 Channel Source Sequence</summary>
        public const uint ChannelSourceSequence = 0x003A0208;

        ///<summary>(003A,0209) VR=SQ VM=1 Channel Source Modifiers Sequence</summary>
        public const uint ChannelSourceModifiersSequence = 0x003A0209;

        ///<summary>(003A,020A) VR=SQ VM=1 Source Waveform Sequence</summary>
        public const uint SourceWaveformSequence = 0x003A020A;

        ///<summary>(003A,020C) VR=LO VM=1 Channel Derivation Description</summary>
        public const uint ChannelDerivationDescription = 0x003A020C;

        ///<summary>(003A,0210) VR=DS VM=1 Channel Sensitivity</summary>
        public const uint ChannelSensitivity = 0x003A0210;

        ///<summary>(003A,0211) VR=SQ VM=1 Channel Sensitivity Units Sequence</summary>
        public const uint ChannelSensitivityUnitsSequence = 0x003A0211;

        ///<summary>(003A,0212) VR=DS VM=1 Channel Sensitivity Correction Factor</summary>
        public const uint ChannelSensitivityCorrectionFactor = 0x003A0212;

        ///<summary>(003A,0213) VR=DS VM=1 Channel Baseline</summary>
        public const uint ChannelBaseline = 0x003A0213;

        ///<summary>(003A,0214) VR=DS VM=1 Channel Time Skew</summary>
        public const uint ChannelTimeSkew = 0x003A0214;

        ///<summary>(003A,0215) VR=DS VM=1 Channel Sample Skew</summary>
        public const uint ChannelSampleSkew = 0x003A0215;

        ///<summary>(003A,0218) VR=DS VM=1 Channel Offset</summary>
        public const uint ChannelOffset = 0x003A0218;

        ///<summary>(003A,021A) VR=US VM=1 Waveform Bits Stored</summary>
        public const uint WaveformBitsStored = 0x003A021A;

        ///<summary>(003A,0220) VR=DS VM=1 Filter Low Frequency</summary>
        public const uint FilterLowFrequency = 0x003A0220;

        ///<summary>(003A,0221) VR=DS VM=1 Filter High Frequency</summary>
        public const uint FilterHighFrequency = 0x003A0221;

        ///<summary>(003A,0222) VR=DS VM=1 Notch Filter Frequency</summary>
        public const uint NotchFilterFrequency = 0x003A0222;

        ///<summary>(003A,0223) VR=DS VM=1 Notch Filter Bandwidth</summary>
        public const uint NotchFilterBandwidth = 0x003A0223;

        ///<summary>(003A,0230) VR=FL VM=1 Waveform Data Display Scale</summary>
        public const uint WaveformDataDisplayScale = 0x003A0230;

        ///<summary>(003A,0231) VR=US VM=3 Waveform Display Background CIELab Value</summary>
        public const uint WaveformDisplayBackgroundCIELabValue = 0x003A0231;

        ///<summary>(003A,0240) VR=SQ VM=1 Waveform Presentation Group Sequence</summary>
        public const uint WaveformPresentationGroupSequence = 0x003A0240;

        ///<summary>(003A,0241) VR=US VM=1 Presentation Group Number</summary>
        public const uint PresentationGroupNumber = 0x003A0241;

        ///<summary>(003A,0242) VR=SQ VM=1 Channel Display Sequence</summary>
        public const uint ChannelDisplaySequence = 0x003A0242;

        ///<summary>(003A,0244) VR=US VM=3 Channel Recommended Display CIELab Value</summary>
        public const uint ChannelRecommendedDisplayCIELabValue = 0x003A0244;

        ///<summary>(003A,0245) VR=FL VM=1 Channel Position</summary>
        public const uint ChannelPosition = 0x003A0245;

        ///<summary>(003A,0246) VR=CS VM=1 Display Shading Flag</summary>
        public const uint DisplayShadingFlag = 0x003A0246;

        ///<summary>(003A,0247) VR=FL VM=1 Fractional Channel Display Scale</summary>
        public const uint FractionalChannelDisplayScale = 0x003A0247;

        ///<summary>(003A,0248) VR=FL VM=1 Absolute Channel Display Scale</summary>
        public const uint AbsoluteChannelDisplayScale = 0x003A0248;

        ///<summary>(003A,0300) VR=SQ VM=1 Multiplexed Audio Channels Description Code Sequence</summary>
        public const uint MultiplexedAudioChannelsDescriptionCodeSequence = 0x003A0300;

        ///<summary>(003A,0301) VR=IS VM=1 Channel Identification Code</summary>
        public const uint ChannelIdentificationCode = 0x003A0301;

        ///<summary>(003A,0302) VR=CS VM=1 Channel Mode</summary>
        public const uint ChannelMode = 0x003A0302;

        ///<summary>(003A,0310) VR=UI VM=1 Multiplex Group Uid</summary>
        public const uint MultiplexGroupUid = 0x003A0310;

        ///<summary>(003A,0311) VR=DS VM=1 Powerline Frequency</summary>
        public const uint PowerlineFrequency = 0x003A0311;

        ///<summary>(003A,0312) VR=SQ VM=1 Channel Impedance Sequence</summary>
        public const uint ChannelImpedanceSequence = 0x003A0312;

        ///<summary>(003A,0313) VR=DS VM=1 Impedance Value</summary>
        public const uint ImpedanceValue = 0x003A0313;

        ///<summary>(003A,0314) VR=DT VM=1 Impedance Measurement DateTime</summary>
        public const uint ImpedanceMeasurementDateTime = 0x003A0314;

        ///<summary>(003A,0315) VR=DS VM=1 Impedance Measurement Frequency</summary>
        public const uint ImpedanceMeasurementFrequency = 0x003A0315;

        ///<summary>(003A,0316) VR=CS VM=1 Impedance Measurement Current Type</summary>
        public const uint ImpedanceMeasurementCurrentType = 0x003A0316;

        ///<summary>(0040,0001) VR=AE VM=1-n Scheduled Station AE Title</summary>
        public const uint ScheduledStationAETitle = 0x00400001;

        ///<summary>(0040,0002) VR=DA VM=1 Scheduled Procedure Step Start Date</summary>
        public const uint ScheduledProcedureStepStartDate = 0x00400002;

        ///<summary>(0040,0003) VR=TM VM=1 Scheduled Procedure Step Start Time</summary>
        public const uint ScheduledProcedureStepStartTime = 0x00400003;

        ///<summary>(0040,0004) VR=DA VM=1 Scheduled Procedure Step End Date</summary>
        public const uint ScheduledProcedureStepEndDate = 0x00400004;

        ///<summary>(0040,0005) VR=TM VM=1 Scheduled Procedure Step End Time</summary>
        public const uint ScheduledProcedureStepEndTime = 0x00400005;

        ///<summary>(0040,0006) VR=PN VM=1 Scheduled Performing Physician's Name</summary>
        public const uint ScheduledPerformingPhysicianName = 0x00400006;

        ///<summary>(0040,0007) VR=LO VM=1 Scheduled Procedure Step Description</summary>
        public const uint ScheduledProcedureStepDescription = 0x00400007;

        ///<summary>(0040,0008) VR=SQ VM=1 Scheduled Protocol Code Sequence</summary>
        public const uint ScheduledProtocolCodeSequence = 0x00400008;

        ///<summary>(0040,0009) VR=SH VM=1 Scheduled Procedure Step Id</summary>
        public const uint ScheduledProcedureStepId = 0x00400009;

        ///<summary>(0040,000A) VR=SQ VM=1 Stage Code Sequence</summary>
        public const uint StageCodeSequence = 0x0040000A;

        ///<summary>(0040,000B) VR=SQ VM=1 Scheduled Performing Physician Identification Sequence</summary>
        public const uint ScheduledPerformingPhysicianIdentificationSequence = 0x0040000B;

        ///<summary>(0040,0010) VR=SH VM=1-n Scheduled Station Name</summary>
        public const uint ScheduledStationName = 0x00400010;

        ///<summary>(0040,0011) VR=SH VM=1 Scheduled Procedure Step Location</summary>
        public const uint ScheduledProcedureStepLocation = 0x00400011;

        ///<summary>(0040,0012) VR=LO VM=1 Pre-Medication</summary>
        public const uint PreMedication = 0x00400012;

        ///<summary>(0040,0020) VR=CS VM=1 Scheduled Procedure Step Status</summary>
        public const uint ScheduledProcedureStepStatus = 0x00400020;

        ///<summary>(0040,0026) VR=SQ VM=1 Order Placer Identifier Sequence</summary>
        public const uint OrderPlacerIdentifierSequence = 0x00400026;

        ///<summary>(0040,0027) VR=SQ VM=1 Order Filler Identifier Sequence</summary>
        public const uint OrderFillerIdentifierSequence = 0x00400027;

        ///<summary>(0040,0031) VR=UT VM=1 Local Namespace Entity Id</summary>
        public const uint LocalNamespaceEntityId = 0x00400031;

        ///<summary>(0040,0032) VR=UT VM=1 Universal Entity Id</summary>
        public const uint UniversalEntityId = 0x00400032;

        ///<summary>(0040,0033) VR=CS VM=1 Universal Entity Id Type</summary>
        public const uint UniversalEntityIdType = 0x00400033;

        ///<summary>(0040,0035) VR=CS VM=1 Identifier Type Code</summary>
        public const uint IdentifierTypeCode = 0x00400035;

        ///<summary>(0040,0036) VR=SQ VM=1 Assigning Facility Sequence</summary>
        public const uint AssigningFacilitySequence = 0x00400036;

        ///<summary>(0040,0039) VR=SQ VM=1 Assigning Jurisdiction Code Sequence</summary>
        public const uint AssigningJurisdictionCodeSequence = 0x00400039;

        ///<summary>(0040,003A) VR=SQ VM=1 Assigning Agency or Department Code Sequence</summary>
        public const uint AssigningAgencyOrDepartmentCodeSequence = 0x0040003A;

        ///<summary>(0040,0100) VR=SQ VM=1 Scheduled Procedure Step Sequence</summary>
        public const uint ScheduledProcedureStepSequence = 0x00400100;

        ///<summary>(0040,0220) VR=SQ VM=1 Referenced Non-Image Composite Sop Instance Sequence</summary>
        public const uint ReferencedNonImageCompositeSopInstanceSequence = 0x00400220;

        ///<summary>(0040,0241) VR=AE VM=1 Performed Station AE Title</summary>
        public const uint PerformedStationAETitle = 0x00400241;

        ///<summary>(0040,0242) VR=SH VM=1 Performed Station Name</summary>
        public const uint PerformedStationName = 0x00400242;

        ///<summary>(0040,0243) VR=SH VM=1 Performed Location</summary>
        public const uint PerformedLocation = 0x00400243;

        ///<summary>(0040,0244) VR=DA VM=1 Performed Procedure Step Start Date</summary>
        public const uint PerformedProcedureStepStartDate = 0x00400244;

        ///<summary>(0040,0245) VR=TM VM=1 Performed Procedure Step Start Time</summary>
        public const uint PerformedProcedureStepStartTime = 0x00400245;

        ///<summary>(0040,0250) VR=DA VM=1 Performed Procedure Step End Date</summary>
        public const uint PerformedProcedureStepEndDate = 0x00400250;

        ///<summary>(0040,0251) VR=TM VM=1 Performed Procedure Step End Time</summary>
        public const uint PerformedProcedureStepEndTime = 0x00400251;

        ///<summary>(0040,0252) VR=CS VM=1 Performed Procedure Step Status</summary>
        public const uint PerformedProcedureStepStatus = 0x00400252;

        ///<summary>(0040,0253) VR=SH VM=1 Performed Procedure Step Id</summary>
        public const uint PerformedProcedureStepId = 0x00400253;

        ///<summary>(0040,0254) VR=LO VM=1 Performed Procedure Step Description</summary>
        public const uint PerformedProcedureStepDescription = 0x00400254;

        ///<summary>(0040,0255) VR=LO VM=1 Performed Procedure Type Description</summary>
        public const uint PerformedProcedureTypeDescription = 0x00400255;

        ///<summary>(0040,0260) VR=SQ VM=1 Performed Protocol Code Sequence</summary>
        public const uint PerformedProtocolCodeSequence = 0x00400260;

        ///<summary>(0040,0261) VR=CS VM=1 Performed Protocol Type</summary>
        public const uint PerformedProtocolType = 0x00400261;

        ///<summary>(0040,0270) VR=SQ VM=1 Scheduled Step Attributes Sequence</summary>
        public const uint ScheduledStepAttributesSequence = 0x00400270;

        ///<summary>(0040,0275) VR=SQ VM=1 Request Attributes Sequence</summary>
        public const uint RequestAttributesSequence = 0x00400275;

        ///<summary>(0040,0280) VR=ST VM=1 Comments on the Performed Procedure Step</summary>
        public const uint CommentsOnThePerformedProcedureStep = 0x00400280;

        ///<summary>(0040,0281) VR=SQ VM=1 Performed Procedure Step Discontinuation Reason Code Sequence</summary>
        public const uint PerformedProcedureStepDiscontinuationReasonCodeSequence = 0x00400281;

        ///<summary>(0040,0293) VR=SQ VM=1 Quantity Sequence</summary>
        public const uint QuantitySequence = 0x00400293;

        ///<summary>(0040,0294) VR=DS VM=1 Quantity</summary>
        public const uint Quantity = 0x00400294;

        ///<summary>(0040,0295) VR=SQ VM=1 Measuring Units Sequence</summary>
        public const uint MeasuringUnitsSequence = 0x00400295;

        ///<summary>(0040,0296) VR=SQ VM=1 Billing Item Sequence</summary>
        public const uint BillingItemSequence = 0x00400296;

        ///<summary>(0040,0300) VR=US VM=1 Total Time of Fluoroscopy (RETIRED)</summary>
        public const uint TotalTimeOfFluoroscopyRETIRED = 0x00400300;

        ///<summary>(0040,0301) VR=US VM=1 Total Number of Exposures (RETIRED)</summary>
        public const uint TotalNumberOfExposuresRETIRED = 0x00400301;

        ///<summary>(0040,0302) VR=US VM=1 Entrance Dose</summary>
        public const uint EntranceDose = 0x00400302;

        ///<summary>(0040,0303) VR=US VM=1-2 Exposed Area</summary>
        public const uint ExposedArea = 0x00400303;

        ///<summary>(0040,0306) VR=DS VM=1 Distance Source to Entrance</summary>
        public const uint DistanceSourceToEntrance = 0x00400306;

        ///<summary>(0040,0307) VR=DS VM=1 Distance Source to Support (RETIRED)</summary>
        public const uint DistanceSourceToSupportRETIRED = 0x00400307;

        ///<summary>(0040,030E) VR=SQ VM=1 Exposure Dose Sequence (RETIRED)</summary>
        public const uint ExposureDoseSequenceRETIRED = 0x0040030E;

        ///<summary>(0040,0310) VR=ST VM=1 Comments on Radiation Dose</summary>
        public const uint CommentsOnRadiationDose = 0x00400310;

        ///<summary>(0040,0312) VR=DS VM=1 X-Ray Output</summary>
        public const uint XRayOutput = 0x00400312;

        ///<summary>(0040,0314) VR=DS VM=1 Half Value Layer</summary>
        public const uint HalfValueLayer = 0x00400314;

        ///<summary>(0040,0316) VR=DS VM=1 Organ Dose</summary>
        public const uint OrganDose = 0x00400316;

        ///<summary>(0040,0318) VR=CS VM=1 Organ Exposed</summary>
        public const uint OrganExposed = 0x00400318;

        ///<summary>(0040,0320) VR=SQ VM=1 Billing Procedure Step Sequence</summary>
        public const uint BillingProcedureStepSequence = 0x00400320;

        ///<summary>(0040,0321) VR=SQ VM=1 Film Consumption Sequence</summary>
        public const uint FilmConsumptionSequence = 0x00400321;

        ///<summary>(0040,0324) VR=SQ VM=1 Billing Supplies and Devices Sequence</summary>
        public const uint BillingSuppliesAndDevicesSequence = 0x00400324;

        ///<summary>(0040,0330) VR=SQ VM=1 Referenced Procedure Step Sequence (RETIRED)</summary>
        public const uint ReferencedProcedureStepSequenceRETIRED = 0x00400330;

        ///<summary>(0040,0340) VR=SQ VM=1 Performed Series Sequence</summary>
        public const uint PerformedSeriesSequence = 0x00400340;

        ///<summary>(0040,0400) VR=LT VM=1 Comments on the Scheduled Procedure Step</summary>
        public const uint CommentsOnTheScheduledProcedureStep = 0x00400400;

        ///<summary>(0040,0440) VR=SQ VM=1 Protocol Context Sequence</summary>
        public const uint ProtocolContextSequence = 0x00400440;

        ///<summary>(0040,0441) VR=SQ VM=1 Content Item Modifier Sequence</summary>
        public const uint ContentItemModifierSequence = 0x00400441;

        ///<summary>(0040,0500) VR=SQ VM=1 Scheduled Specimen Sequence</summary>
        public const uint ScheduledSpecimenSequence = 0x00400500;

        ///<summary>(0040,050A) VR=LO VM=1 Specimen Accession Number (RETIRED)</summary>
        public const uint SpecimenAccessionNumberRETIRED = 0x0040050A;

        ///<summary>(0040,0512) VR=LO VM=1 Container Identifier</summary>
        public const uint ContainerIdentifier = 0x00400512;

        ///<summary>(0040,0513) VR=SQ VM=1 Issuer of the Container Identifier Sequence</summary>
        public const uint IssuerOfTheContainerIdentifierSequence = 0x00400513;

        ///<summary>(0040,0515) VR=SQ VM=1 Alternate Container Identifier Sequence</summary>
        public const uint AlternateContainerIdentifierSequence = 0x00400515;

        ///<summary>(0040,0518) VR=SQ VM=1 Container Type Code Sequence</summary>
        public const uint ContainerTypeCodeSequence = 0x00400518;

        ///<summary>(0040,051A) VR=LO VM=1 Container Description</summary>
        public const uint ContainerDescription = 0x0040051A;

        ///<summary>(0040,0520) VR=SQ VM=1 Container Component Sequence</summary>
        public const uint ContainerComponentSequence = 0x00400520;

        ///<summary>(0040,0550) VR=SQ VM=1 Specimen Sequence (RETIRED)</summary>
        public const uint SpecimenSequenceRETIRED = 0x00400550;

        ///<summary>(0040,0551) VR=LO VM=1 Specimen Identifier</summary>
        public const uint SpecimenIdentifier = 0x00400551;

        ///<summary>(0040,0552) VR=SQ VM=1 Specimen Description Sequence (Trial) (RETIRED)</summary>
        public const uint SpecimenDescriptionSequenceTrialRETIRED = 0x00400552;

        ///<summary>(0040,0553) VR=ST VM=1 Specimen Description (Trial) (RETIRED)</summary>
        public const uint SpecimenDescriptionTrialRETIRED = 0x00400553;

        ///<summary>(0040,0554) VR=UI VM=1 Specimen Uid</summary>
        public const uint SpecimenUid = 0x00400554;

        ///<summary>(0040,0555) VR=SQ VM=1 Acquisition Context Sequence</summary>
        public const uint AcquisitionContextSequence = 0x00400555;

        ///<summary>(0040,0556) VR=ST VM=1 Acquisition Context Description</summary>
        public const uint AcquisitionContextDescription = 0x00400556;

        ///<summary>(0040,059A) VR=SQ VM=1 Specimen Type Code Sequence</summary>
        public const uint SpecimenTypeCodeSequence = 0x0040059A;

        ///<summary>(0040,0560) VR=SQ VM=1 Specimen Description Sequence</summary>
        public const uint SpecimenDescriptionSequence = 0x00400560;

        ///<summary>(0040,0562) VR=SQ VM=1 Issuer of the Specimen Identifier Sequence</summary>
        public const uint IssuerOfTheSpecimenIdentifierSequence = 0x00400562;

        ///<summary>(0040,0600) VR=LO VM=1 Specimen Short Description</summary>
        public const uint SpecimenShortDescription = 0x00400600;

        ///<summary>(0040,0602) VR=UT VM=1 Specimen Detailed Description</summary>
        public const uint SpecimenDetailedDescription = 0x00400602;

        ///<summary>(0040,0610) VR=SQ VM=1 Specimen Preparation Sequence</summary>
        public const uint SpecimenPreparationSequence = 0x00400610;

        ///<summary>(0040,0612) VR=SQ VM=1 Specimen Preparation Step Content Item Sequence</summary>
        public const uint SpecimenPreparationStepContentItemSequence = 0x00400612;

        ///<summary>(0040,0620) VR=SQ VM=1 Specimen Localization Content Item Sequence</summary>
        public const uint SpecimenLocalizationContentItemSequence = 0x00400620;

        ///<summary>(0040,06FA) VR=LO VM=1 Slide Identifier (RETIRED)</summary>
        public const uint SlideIdentifierRETIRED = 0x004006FA;

        ///<summary>(0040,0710) VR=SQ VM=1 Whole Slide Microscopy Image Frame Type Sequence</summary>
        public const uint WholeSlideMicroscopyImageFrameTypeSequence = 0x00400710;

        ///<summary>(0040,071A) VR=SQ VM=1 Image Center Point Coordinates Sequence</summary>
        public const uint ImageCenterPointCoordinatesSequence = 0x0040071A;

        ///<summary>(0040,072A) VR=DS VM=1 X Offset in Slide Coordinate System</summary>
        public const uint XOffsetInSlideCoordinateSystem = 0x0040072A;

        ///<summary>(0040,073A) VR=DS VM=1 Y Offset in Slide Coordinate System</summary>
        public const uint YOffsetInSlideCoordinateSystem = 0x0040073A;

        ///<summary>(0040,074A) VR=DS VM=1 Z Offset in Slide Coordinate System</summary>
        public const uint ZOffsetInSlideCoordinateSystem = 0x0040074A;

        ///<summary>(0040,08D8) VR=SQ VM=1 Pixel Spacing Sequence (RETIRED)</summary>
        public const uint PixelSpacingSequenceRETIRED = 0x004008D8;

        ///<summary>(0040,08DA) VR=SQ VM=1 Coordinate System Axis Code Sequence (RETIRED)</summary>
        public const uint CoordinateSystemAxisCodeSequenceRETIRED = 0x004008DA;

        ///<summary>(0040,08EA) VR=SQ VM=1 Measurement Units Code Sequence</summary>
        public const uint MeasurementUnitsCodeSequence = 0x004008EA;

        ///<summary>(0040,09F8) VR=SQ VM=1 Vital Stain Code Sequence (Trial) (RETIRED)</summary>
        public const uint VitalStainCodeSequenceTrialRETIRED = 0x004009F8;

        ///<summary>(0040,1001) VR=SH VM=1 Requested Procedure Id</summary>
        public const uint RequestedProcedureId = 0x00401001;

        ///<summary>(0040,1002) VR=LO VM=1 Reason for the Requested Procedure</summary>
        public const uint ReasonForTheRequestedProcedure = 0x00401002;

        ///<summary>(0040,1003) VR=SH VM=1 Requested Procedure Priority</summary>
        public const uint RequestedProcedurePriority = 0x00401003;

        ///<summary>(0040,1004) VR=LO VM=1 Patient Transport Arrangements</summary>
        public const uint PatientTransportArrangements = 0x00401004;

        ///<summary>(0040,1005) VR=LO VM=1 Requested Procedure Location</summary>
        public const uint RequestedProcedureLocation = 0x00401005;

        ///<summary>(0040,1006) VR=SH VM=1 Placer Order Number / Procedure (RETIRED)</summary>
        public const uint PlacerOrderNumberProcedureRETIRED = 0x00401006;

        ///<summary>(0040,1007) VR=SH VM=1 Filler Order Number / Procedure (RETIRED)</summary>
        public const uint FillerOrderNumberProcedureRETIRED = 0x00401007;

        ///<summary>(0040,1008) VR=LO VM=1 Confidentiality Code</summary>
        public const uint ConfidentialityCode = 0x00401008;

        ///<summary>(0040,1009) VR=SH VM=1 Reporting Priority</summary>
        public const uint ReportingPriority = 0x00401009;

        ///<summary>(0040,100A) VR=SQ VM=1 Reason for Requested Procedure Code Sequence</summary>
        public const uint ReasonForRequestedProcedureCodeSequence = 0x0040100A;

        ///<summary>(0040,1010) VR=PN VM=1-n Names of Intended Recipients of Results</summary>
        public const uint NamesOfIntendedRecipientsOfResults = 0x00401010;

        ///<summary>(0040,1011) VR=SQ VM=1 Intended Recipients of Results Identification Sequence</summary>
        public const uint IntendedRecipientsOfResultsIdentificationSequence = 0x00401011;

        ///<summary>(0040,1012) VR=SQ VM=1 Reason For Performed Procedure Code Sequence</summary>
        public const uint ReasonForPerformedProcedureCodeSequence = 0x00401012;

        ///<summary>(0040,1060) VR=LO VM=1 Requested Procedure Description (Trial) (RETIRED)</summary>
        public const uint RequestedProcedureDescriptionTrialRETIRED = 0x00401060;

        ///<summary>(0040,1101) VR=SQ VM=1 Person Identification Code Sequence</summary>
        public const uint PersonIdentificationCodeSequence = 0x00401101;

        ///<summary>(0040,1102) VR=ST VM=1 Person's Address</summary>
        public const uint PersonAddress = 0x00401102;

        ///<summary>(0040,1103) VR=LO VM=1-n Person's Telephone Numbers</summary>
        public const uint PersonTelephoneNumbers = 0x00401103;

        ///<summary>(0040,1104) VR=LT VM=1 Person's Telecom Information</summary>
        public const uint PersonTelecomInformation = 0x00401104;

        ///<summary>(0040,1400) VR=LT VM=1 Requested Procedure Comments</summary>
        public const uint RequestedProcedureComments = 0x00401400;

        ///<summary>(0040,2001) VR=LO VM=1 Reason for the Imaging Service Request (RETIRED)</summary>
        public const uint ReasonForTheImagingServiceRequestRETIRED = 0x00402001;

        ///<summary>(0040,2004) VR=DA VM=1 Issue Date of Imaging Service Request</summary>
        public const uint IssueDateOfImagingServiceRequest = 0x00402004;

        ///<summary>(0040,2005) VR=TM VM=1 Issue Time of Imaging Service Request</summary>
        public const uint IssueTimeOfImagingServiceRequest = 0x00402005;

        ///<summary>(0040,2006) VR=SH VM=1 Placer Order Number / Imaging Service Request (Retired) (RETIRED)</summary>
        public const uint PlacerOrderNumberImagingServiceRequestRetiredRETIRED = 0x00402006;

        ///<summary>(0040,2007) VR=SH VM=1 Filler Order Number / Imaging Service Request (Retired) (RETIRED)</summary>
        public const uint FillerOrderNumberImagingServiceRequestRetiredRETIRED = 0x00402007;

        ///<summary>(0040,2008) VR=PN VM=1 Order Entered By</summary>
        public const uint OrderEnteredBy = 0x00402008;

        ///<summary>(0040,2009) VR=SH VM=1 Order Enterer's Location</summary>
        public const uint OrderEntererLocation = 0x00402009;

        ///<summary>(0040,2010) VR=SH VM=1 Order Callback Phone Number</summary>
        public const uint OrderCallbackPhoneNumber = 0x00402010;

        ///<summary>(0040,2011) VR=LT VM=1 Order Callback Telecom Information</summary>
        public const uint OrderCallbackTelecomInformation = 0x00402011;

        ///<summary>(0040,2016) VR=LO VM=1 Placer Order Number / Imaging Service Request</summary>
        public const uint PlacerOrderNumberImagingServiceRequest = 0x00402016;

        ///<summary>(0040,2017) VR=LO VM=1 Filler Order Number / Imaging Service Request</summary>
        public const uint FillerOrderNumberImagingServiceRequest = 0x00402017;

        ///<summary>(0040,2400) VR=LT VM=1 Imaging Service Request Comments</summary>
        public const uint ImagingServiceRequestComments = 0x00402400;

        ///<summary>(0040,3001) VR=LO VM=1 Confidentiality Constraint on Patient Data Description</summary>
        public const uint ConfidentialityConstraintOnPatientDataDescription = 0x00403001;

        ///<summary>(0040,4001) VR=CS VM=1 General Purpose Scheduled Procedure Step Status (RETIRED)</summary>
        public const uint GeneralPurposeScheduledProcedureStepStatusRETIRED = 0x00404001;

        ///<summary>(0040,4002) VR=CS VM=1 General Purpose Performed Procedure Step Status (RETIRED)</summary>
        public const uint GeneralPurposePerformedProcedureStepStatusRETIRED = 0x00404002;

        ///<summary>(0040,4003) VR=CS VM=1 General Purpose Scheduled Procedure Step Priority (RETIRED)</summary>
        public const uint GeneralPurposeScheduledProcedureStepPriorityRETIRED = 0x00404003;

        ///<summary>(0040,4004) VR=SQ VM=1 Scheduled Processing Applications Code Sequence (RETIRED)</summary>
        public const uint ScheduledProcessingApplicationsCodeSequenceRETIRED = 0x00404004;

        ///<summary>(0040,4005) VR=DT VM=1 Scheduled Procedure Step Start DateTime</summary>
        public const uint ScheduledProcedureStepStartDateTime = 0x00404005;

        ///<summary>(0040,4006) VR=CS VM=1 Multiple Copies Flag (RETIRED)</summary>
        public const uint MultipleCopiesFlagRETIRED = 0x00404006;

        ///<summary>(0040,4007) VR=SQ VM=1 Performed Processing Applications Code Sequence (RETIRED)</summary>
        public const uint PerformedProcessingApplicationsCodeSequenceRETIRED = 0x00404007;

        ///<summary>(0040,4008) VR=DT VM=1 Scheduled Procedure Step Expiration DateTime</summary>
        public const uint ScheduledProcedureStepExpirationDateTime = 0x00404008;

        ///<summary>(0040,4009) VR=SQ VM=1 Human Performer Code Sequence</summary>
        public const uint HumanPerformerCodeSequence = 0x00404009;

        ///<summary>(0040,4010) VR=DT VM=1 Scheduled Procedure Step Modification DateTime</summary>
        public const uint ScheduledProcedureStepModificationDateTime = 0x00404010;

        ///<summary>(0040,4011) VR=DT VM=1 Expected Completion DateTime</summary>
        public const uint ExpectedCompletionDateTime = 0x00404011;

        ///<summary>(0040,4015) VR=SQ VM=1 Resulting General Purpose Performed Procedure Steps Sequence (RETIRED)</summary>
        public const uint ResultingGeneralPurposePerformedProcedureStepsSequenceRETIRED = 0x00404015;

        ///<summary>(0040,4016) VR=SQ VM=1 Referenced General Purpose Scheduled Procedure Step Sequence (RETIRED)</summary>
        public const uint ReferencedGeneralPurposeScheduledProcedureStepSequenceRETIRED = 0x00404016;

        ///<summary>(0040,4018) VR=SQ VM=1 Scheduled Workitem Code Sequence</summary>
        public const uint ScheduledWorkitemCodeSequence = 0x00404018;

        ///<summary>(0040,4019) VR=SQ VM=1 Performed Workitem Code Sequence</summary>
        public const uint PerformedWorkitemCodeSequence = 0x00404019;

        ///<summary>(0040,4020) VR=CS VM=1 Input Availability Flag (RETIRED)</summary>
        public const uint InputAvailabilityFlagRETIRED = 0x00404020;

        ///<summary>(0040,4021) VR=SQ VM=1 Input Information Sequence</summary>
        public const uint InputInformationSequence = 0x00404021;

        ///<summary>(0040,4022) VR=SQ VM=1 Relevant Information Sequence (RETIRED)</summary>
        public const uint RelevantInformationSequenceRETIRED = 0x00404022;

        ///<summary>(0040,4023) VR=UI VM=1 Referenced General Purpose Scheduled Procedure Step Transaction Uid (RETIRED)</summary>
        public const uint ReferencedGeneralPurposeScheduledProcedureStepTransactionUidRETIRED = 0x00404023;

        ///<summary>(0040,4025) VR=SQ VM=1 Scheduled Station Name Code Sequence</summary>
        public const uint ScheduledStationNameCodeSequence = 0x00404025;

        ///<summary>(0040,4026) VR=SQ VM=1 Scheduled Station Class Code Sequence</summary>
        public const uint ScheduledStationClassCodeSequence = 0x00404026;

        ///<summary>(0040,4027) VR=SQ VM=1 Scheduled Station Geographic Location Code Sequence</summary>
        public const uint ScheduledStationGeographicLocationCodeSequence = 0x00404027;

        ///<summary>(0040,4028) VR=SQ VM=1 Performed Station Name Code Sequence</summary>
        public const uint PerformedStationNameCodeSequence = 0x00404028;

        ///<summary>(0040,4029) VR=SQ VM=1 Performed Station Class Code Sequence</summary>
        public const uint PerformedStationClassCodeSequence = 0x00404029;

        ///<summary>(0040,4030) VR=SQ VM=1 Performed Station Geographic Location Code Sequence</summary>
        public const uint PerformedStationGeographicLocationCodeSequence = 0x00404030;

        ///<summary>(0040,4031) VR=SQ VM=1 Requested Subsequent Workitem Code Sequence (RETIRED)</summary>
        public const uint RequestedSubsequentWorkitemCodeSequenceRETIRED = 0x00404031;

        ///<summary>(0040,4032) VR=SQ VM=1 Non-DICOM Output Code Sequence (RETIRED)</summary>
        public const uint NonDICOMOutputCodeSequenceRETIRED = 0x00404032;

        ///<summary>(0040,4033) VR=SQ VM=1 Output Information Sequence</summary>
        public const uint OutputInformationSequence = 0x00404033;

        ///<summary>(0040,4034) VR=SQ VM=1 Scheduled Human Performers Sequence</summary>
        public const uint ScheduledHumanPerformersSequence = 0x00404034;

        ///<summary>(0040,4035) VR=SQ VM=1 Actual Human Performers Sequence</summary>
        public const uint ActualHumanPerformersSequence = 0x00404035;

        ///<summary>(0040,4036) VR=LO VM=1 Human Performer's Organization</summary>
        public const uint HumanPerformerOrganization = 0x00404036;

        ///<summary>(0040,4037) VR=PN VM=1 Human Performer's Name</summary>
        public const uint HumanPerformerName = 0x00404037;

        ///<summary>(0040,4040) VR=CS VM=1 Raw Data Handling</summary>
        public const uint RawDataHandling = 0x00404040;

        ///<summary>(0040,4041) VR=CS VM=1 Input Readiness State</summary>
        public const uint InputReadinessState = 0x00404041;

        ///<summary>(0040,4050) VR=DT VM=1 Performed Procedure Step Start DateTime</summary>
        public const uint PerformedProcedureStepStartDateTime = 0x00404050;

        ///<summary>(0040,4051) VR=DT VM=1 Performed Procedure Step End DateTime</summary>
        public const uint PerformedProcedureStepEndDateTime = 0x00404051;

        ///<summary>(0040,4052) VR=DT VM=1 Procedure Step Cancellation DateTime</summary>
        public const uint ProcedureStepCancellationDateTime = 0x00404052;

        ///<summary>(0040,4070) VR=SQ VM=1 Output Destination Sequence</summary>
        public const uint OutputDestinationSequence = 0x00404070;

        ///<summary>(0040,4071) VR=SQ VM=1 DICOM Storage Sequence</summary>
        public const uint DICOMStorageSequence = 0x00404071;

        ///<summary>(0040,4072) VR=SQ VM=1 STOW-RS Storage Sequence</summary>
        public const uint STOWRSStorageSequence = 0x00404072;

        ///<summary>(0040,4073) VR=UR VM=1 Storage URL</summary>
        public const uint StorageURL = 0x00404073;

        ///<summary>(0040,4074) VR=SQ VM=1 XDS Storage Sequence</summary>
        public const uint XDSStorageSequence = 0x00404074;

        ///<summary>(0040,8302) VR=DS VM=1 Entrance Dose in mGy</summary>
        public const uint EntranceDoseInmGy = 0x00408302;

        ///<summary>(0040,8303) VR=CS VM=1 Entrance Dose Derivation</summary>
        public const uint EntranceDoseDerivation = 0x00408303;

        ///<summary>(0040,9092) VR=SQ VM=1 Parametric Map Frame Type Sequence</summary>
        public const uint ParametricMapFrameTypeSequence = 0x00409092;

        ///<summary>(0040,9094) VR=SQ VM=1 Referenced Image Real World Value Mapping Sequence</summary>
        public const uint ReferencedImageRealWorldValueMappingSequence = 0x00409094;

        ///<summary>(0040,9096) VR=SQ VM=1 Real World Value Mapping Sequence</summary>
        public const uint RealWorldValueMappingSequence = 0x00409096;

        ///<summary>(0040,9098) VR=SQ VM=1 Pixel Value Mapping Code Sequence</summary>
        public const uint PixelValueMappingCodeSequence = 0x00409098;

        ///<summary>(0040,9210) VR=SH VM=1 LUT Label</summary>
        public const uint LUTLabel = 0x00409210;

        ///<summary>(0040,9211) VR=US/SS VM=1 Real World Value Last Value Mapped</summary>
        public const uint RealWorldValueLastValueMapped = 0x00409211;

        ///<summary>(0040,9212) VR=FD VM=1-n Real World Value LUT Data</summary>
        public const uint RealWorldValueLUTData = 0x00409212;

        ///<summary>(0040,9213) VR=FD VM=1 Double Float Real World Value Last Value Mapped</summary>
        public const uint DoubleFloatRealWorldValueLastValueMapped = 0x00409213;

        ///<summary>(0040,9214) VR=FD VM=1 Double Float Real World Value First Value Mapped</summary>
        public const uint DoubleFloatRealWorldValueFirstValueMapped = 0x00409214;

        ///<summary>(0040,9216) VR=US/SS VM=1 Real World Value First Value Mapped</summary>
        public const uint RealWorldValueFirstValueMapped = 0x00409216;

        ///<summary>(0040,9220) VR=SQ VM=1 Quantity Definition Sequence</summary>
        public const uint QuantityDefinitionSequence = 0x00409220;

        ///<summary>(0040,9224) VR=FD VM=1 Real World Value Intercept</summary>
        public const uint RealWorldValueIntercept = 0x00409224;

        ///<summary>(0040,9225) VR=FD VM=1 Real World Value Slope</summary>
        public const uint RealWorldValueSlope = 0x00409225;

        ///<summary>(0040,A007) VR=CS VM=1 Findings Flag (Trial) (RETIRED)</summary>
        public const uint FindingsFlagTrialRETIRED = 0x0040A007;

        ///<summary>(0040,A010) VR=CS VM=1 Relationship Type</summary>
        public const uint RelationshipType = 0x0040A010;

        ///<summary>(0040,A020) VR=SQ VM=1 Findings Sequence (Trial) (RETIRED)</summary>
        public const uint FindingsSequenceTrialRETIRED = 0x0040A020;

        ///<summary>(0040,A021) VR=UI VM=1 Findings Group Uid (Trial) (RETIRED)</summary>
        public const uint FindingsGroupUidTrialRETIRED = 0x0040A021;

        ///<summary>(0040,A022) VR=UI VM=1 Referenced Findings Group Uid (Trial) (RETIRED)</summary>
        public const uint ReferencedFindingsGroupUidTrialRETIRED = 0x0040A022;

        ///<summary>(0040,A023) VR=DA VM=1 Findings Group Recording Date (Trial) (RETIRED)</summary>
        public const uint FindingsGroupRecordingDateTrialRETIRED = 0x0040A023;

        ///<summary>(0040,A024) VR=TM VM=1 Findings Group Recording Time (Trial) (RETIRED)</summary>
        public const uint FindingsGroupRecordingTimeTrialRETIRED = 0x0040A024;

        ///<summary>(0040,A026) VR=SQ VM=1 Findings Source Category Code Sequence (Trial) (RETIRED)</summary>
        public const uint FindingsSourceCategoryCodeSequenceTrialRETIRED = 0x0040A026;

        ///<summary>(0040,A027) VR=LO VM=1 Verifying Organization</summary>
        public const uint VerifyingOrganization = 0x0040A027;

        ///<summary>(0040,A028) VR=SQ VM=1 Documenting Organization Identifier Code Sequence (Trial) (RETIRED)</summary>
        public const uint DocumentingOrganizationIdentifierCodeSequenceTrialRETIRED = 0x0040A028;

        ///<summary>(0040,A030) VR=DT VM=1 Verification DateTime</summary>
        public const uint VerificationDateTime = 0x0040A030;

        ///<summary>(0040,A032) VR=DT VM=1 Observation DateTime</summary>
        public const uint ObservationDateTime = 0x0040A032;

        ///<summary>(0040,A033) VR=DT VM=1 Observation Start DateTime</summary>
        public const uint ObservationStartDateTime = 0x0040A033;

        ///<summary>(0040,A040) VR=CS VM=1 Value Type</summary>
        public const uint ValueType = 0x0040A040;

        ///<summary>(0040,A043) VR=SQ VM=1 Concept Name Code Sequence</summary>
        public const uint ConceptNameCodeSequence = 0x0040A043;

        ///<summary>(0040,A047) VR=LO VM=1 Measurement Precision Description (Trial) (RETIRED)</summary>
        public const uint MeasurementPrecisionDescriptionTrialRETIRED = 0x0040A047;

        ///<summary>(0040,A050) VR=CS VM=1 Continuity Of Content</summary>
        public const uint ContinuityOfContent = 0x0040A050;

        ///<summary>(0040,A057) VR=CS VM=1-n Urgency or Priority Alerts (Trial) (RETIRED)</summary>
        public const uint UrgencyOrPriorityAlertsTrialRETIRED = 0x0040A057;

        ///<summary>(0040,A060) VR=LO VM=1 Sequencing Indicator (Trial) (RETIRED)</summary>
        public const uint SequencingIndicatorTrialRETIRED = 0x0040A060;

        ///<summary>(0040,A066) VR=SQ VM=1 Document Identifier Code Sequence (Trial) (RETIRED)</summary>
        public const uint DocumentIdentifierCodeSequenceTrialRETIRED = 0x0040A066;

        ///<summary>(0040,A067) VR=PN VM=1 Document Author (Trial) (RETIRED)</summary>
        public const uint DocumentAuthorTrialRETIRED = 0x0040A067;

        ///<summary>(0040,A068) VR=SQ VM=1 Document Author Identifier Code Sequence (Trial) (RETIRED)</summary>
        public const uint DocumentAuthorIdentifierCodeSequenceTrialRETIRED = 0x0040A068;

        ///<summary>(0040,A070) VR=SQ VM=1 Identifier Code Sequence (Trial) (RETIRED)</summary>
        public const uint IdentifierCodeSequenceTrialRETIRED = 0x0040A070;

        ///<summary>(0040,A073) VR=SQ VM=1 Verifying Observer Sequence</summary>
        public const uint VerifyingObserverSequence = 0x0040A073;

        ///<summary>(0040,A074) VR=OB VM=1 Object Binary Identifier (Trial) (RETIRED)</summary>
        public const uint ObjectBinaryIdentifierTrialRETIRED = 0x0040A074;

        ///<summary>(0040,A075) VR=PN VM=1 Verifying Observer Name</summary>
        public const uint VerifyingObserverName = 0x0040A075;

        ///<summary>(0040,A076) VR=SQ VM=1 Documenting Observer Identifier Code Sequence (Trial) (RETIRED)</summary>
        public const uint DocumentingObserverIdentifierCodeSequenceTrialRETIRED = 0x0040A076;

        ///<summary>(0040,A078) VR=SQ VM=1 Author Observer Sequence</summary>
        public const uint AuthorObserverSequence = 0x0040A078;

        ///<summary>(0040,A07A) VR=SQ VM=1 Participant Sequence</summary>
        public const uint ParticipantSequence = 0x0040A07A;

        ///<summary>(0040,A07C) VR=SQ VM=1 Custodial Organization Sequence</summary>
        public const uint CustodialOrganizationSequence = 0x0040A07C;

        ///<summary>(0040,A080) VR=CS VM=1 Participation Type</summary>
        public const uint ParticipationType = 0x0040A080;

        ///<summary>(0040,A082) VR=DT VM=1 Participation DateTime</summary>
        public const uint ParticipationDateTime = 0x0040A082;

        ///<summary>(0040,A084) VR=CS VM=1 Observer Type</summary>
        public const uint ObserverType = 0x0040A084;

        ///<summary>(0040,A085) VR=SQ VM=1 Procedure Identifier Code Sequence (Trial) (RETIRED)</summary>
        public const uint ProcedureIdentifierCodeSequenceTrialRETIRED = 0x0040A085;

        ///<summary>(0040,A088) VR=SQ VM=1 Verifying Observer Identification Code Sequence</summary>
        public const uint VerifyingObserverIdentificationCodeSequence = 0x0040A088;

        ///<summary>(0040,A089) VR=OB VM=1 Object Directory Binary Identifier (Trial) (RETIRED)</summary>
        public const uint ObjectDirectoryBinaryIdentifierTrialRETIRED = 0x0040A089;

        ///<summary>(0040,A090) VR=SQ VM=1 Equivalent CDA Document Sequence (RETIRED)</summary>
        public const uint EquivalentCDADocumentSequenceRETIRED = 0x0040A090;

        ///<summary>(0040,A0B0) VR=US VM=2-2n Referenced Waveform Channels</summary>
        public const uint ReferencedWaveformChannels = 0x0040A0B0;

        ///<summary>(0040,A110) VR=DA VM=1 Date of Document or Verbal Transaction (Trial) (RETIRED)</summary>
        public const uint DateOfDocumentOrVerbalTransactionTrialRETIRED = 0x0040A110;

        ///<summary>(0040,A112) VR=TM VM=1 Time of Document Creation or Verbal Transaction (Trial) (RETIRED)</summary>
        public const uint TimeOfDocumentCreationOrVerbalTransactionTrialRETIRED = 0x0040A112;

        ///<summary>(0040,A120) VR=DT VM=1 DateTime</summary>
        public const uint DateTime = 0x0040A120;

        ///<summary>(0040,A121) VR=DA VM=1 Date</summary>
        public const uint Date = 0x0040A121;

        ///<summary>(0040,A122) VR=TM VM=1 Time</summary>
        public const uint Time = 0x0040A122;

        ///<summary>(0040,A123) VR=PN VM=1 Person Name</summary>
        public const uint PersonName = 0x0040A123;

        ///<summary>(0040,A124) VR=UI VM=1 Uid</summary>
        public const uint Uid = 0x0040A124;

        ///<summary>(0040,A125) VR=CS VM=2 Report Status Id (Trial) (RETIRED)</summary>
        public const uint ReportStatusIdTrialRETIRED = 0x0040A125;

        ///<summary>(0040,A130) VR=CS VM=1 Temporal Range Type</summary>
        public const uint TemporalRangeType = 0x0040A130;

        ///<summary>(0040,A132) VR=UL VM=1-n Referenced Sample Positions</summary>
        public const uint ReferencedSamplePositions = 0x0040A132;

        ///<summary>(0040,A136) VR=US VM=1-n Referenced Frame Numbers (RETIRED)</summary>
        public const uint ReferencedFrameNumbersRETIRED = 0x0040A136;

        ///<summary>(0040,A138) VR=DS VM=1-n Referenced Time Offsets</summary>
        public const uint ReferencedTimeOffsets = 0x0040A138;

        ///<summary>(0040,A13A) VR=DT VM=1-n Referenced DateTime</summary>
        public const uint ReferencedDateTime = 0x0040A13A;

        ///<summary>(0040,A160) VR=UT VM=1 Text Value</summary>
        public const uint TextValue = 0x0040A160;

        ///<summary>(0040,A161) VR=FD VM=1-n Floating Point Value</summary>
        public const uint FloatingPointValue = 0x0040A161;

        ///<summary>(0040,A162) VR=SL VM=1-n Rational Numerator Value</summary>
        public const uint RationalNumeratorValue = 0x0040A162;

        ///<summary>(0040,A163) VR=UL VM=1-n Rational Denominator Value</summary>
        public const uint RationalDenominatorValue = 0x0040A163;

        ///<summary>(0040,A167) VR=SQ VM=1 Observation Category Code Sequence (Trial) (RETIRED)</summary>
        public const uint ObservationCategoryCodeSequenceTrialRETIRED = 0x0040A167;

        ///<summary>(0040,A168) VR=SQ VM=1 Concept Code Sequence</summary>
        public const uint ConceptCodeSequence = 0x0040A168;

        ///<summary>(0040,A16A) VR=ST VM=1 Bibliographic Citation (Trial) (RETIRED)</summary>
        public const uint BibliographicCitationTrialRETIRED = 0x0040A16A;

        ///<summary>(0040,A170) VR=SQ VM=1 Purpose of Reference Code Sequence</summary>
        public const uint PurposeOfReferenceCodeSequence = 0x0040A170;

        ///<summary>(0040,A171) VR=UI VM=1 Observation Uid</summary>
        public const uint ObservationUid = 0x0040A171;

        ///<summary>(0040,A172) VR=UI VM=1 Referenced Observation Uid (Trial) (RETIRED)</summary>
        public const uint ReferencedObservationUidTrialRETIRED = 0x0040A172;

        ///<summary>(0040,A173) VR=CS VM=1 Referenced Observation Class (Trial) (RETIRED)</summary>
        public const uint ReferencedObservationClassTrialRETIRED = 0x0040A173;

        ///<summary>(0040,A174) VR=CS VM=1 Referenced Object Observation Class (Trial) (RETIRED)</summary>
        public const uint ReferencedObjectObservationClassTrialRETIRED = 0x0040A174;

        ///<summary>(0040,A180) VR=US VM=1 Annotation Group Number</summary>
        public const uint AnnotationGroupNumber = 0x0040A180;

        ///<summary>(0040,A192) VR=DA VM=1 Observation Date (Trial) (RETIRED)</summary>
        public const uint ObservationDateTrialRETIRED = 0x0040A192;

        ///<summary>(0040,A193) VR=TM VM=1 Observation Time (Trial) (RETIRED)</summary>
        public const uint ObservationTimeTrialRETIRED = 0x0040A193;

        ///<summary>(0040,A194) VR=CS VM=1 Measurement Automation (Trial) (RETIRED)</summary>
        public const uint MeasurementAutomationTrialRETIRED = 0x0040A194;

        ///<summary>(0040,A195) VR=SQ VM=1 Modifier Code Sequence</summary>
        public const uint ModifierCodeSequence = 0x0040A195;

        ///<summary>(0040,A224) VR=ST VM=1 Identification Description (Trial) (RETIRED)</summary>
        public const uint IdentificationDescriptionTrialRETIRED = 0x0040A224;

        ///<summary>(0040,A290) VR=CS VM=1 Coordinates Set Geometric Type (Trial) (RETIRED)</summary>
        public const uint CoordinatesSetGeometricTypeTrialRETIRED = 0x0040A290;

        ///<summary>(0040,A296) VR=SQ VM=1 Algorithm Code Sequence (Trial) (RETIRED)</summary>
        public const uint AlgorithmCodeSequenceTrialRETIRED = 0x0040A296;

        ///<summary>(0040,A297) VR=ST VM=1 Algorithm Description (Trial) (RETIRED)</summary>
        public const uint AlgorithmDescriptionTrialRETIRED = 0x0040A297;

        ///<summary>(0040,A29A) VR=SL VM=2-2n Pixel Coordinates Set (Trial) (RETIRED)</summary>
        public const uint PixelCoordinatesSetTrialRETIRED = 0x0040A29A;

        ///<summary>(0040,A300) VR=SQ VM=1 Measured Value Sequence</summary>
        public const uint MeasuredValueSequence = 0x0040A300;

        ///<summary>(0040,A301) VR=SQ VM=1 Numeric Value Qualifier Code Sequence</summary>
        public const uint NumericValueQualifierCodeSequence = 0x0040A301;

        ///<summary>(0040,A307) VR=PN VM=1 Current Observer (Trial) (RETIRED)</summary>
        public const uint CurrentObserverTrialRETIRED = 0x0040A307;

        ///<summary>(0040,A30A) VR=DS VM=1-n Numeric Value</summary>
        public const uint NumericValue = 0x0040A30A;

        ///<summary>(0040,A313) VR=SQ VM=1 Referenced Accession Sequence (Trial) (RETIRED)</summary>
        public const uint ReferencedAccessionSequenceTrialRETIRED = 0x0040A313;

        ///<summary>(0040,A33A) VR=ST VM=1 Report Status Comment (Trial) (RETIRED)</summary>
        public const uint ReportStatusCommentTrialRETIRED = 0x0040A33A;

        ///<summary>(0040,A340) VR=SQ VM=1 Procedure Context Sequence (Trial) (RETIRED)</summary>
        public const uint ProcedureContextSequenceTrialRETIRED = 0x0040A340;

        ///<summary>(0040,A352) VR=PN VM=1 Verbal Source (Trial) (RETIRED)</summary>
        public const uint VerbalSourceTrialRETIRED = 0x0040A352;

        ///<summary>(0040,A353) VR=ST VM=1 Address (Trial) (RETIRED)</summary>
        public const uint AddressTrialRETIRED = 0x0040A353;

        ///<summary>(0040,A354) VR=LO VM=1 Telephone Number (Trial) (RETIRED)</summary>
        public const uint TelephoneNumberTrialRETIRED = 0x0040A354;

        ///<summary>(0040,A358) VR=SQ VM=1 Verbal Source Identifier Code Sequence (Trial) (RETIRED)</summary>
        public const uint VerbalSourceIdentifierCodeSequenceTrialRETIRED = 0x0040A358;

        ///<summary>(0040,A360) VR=SQ VM=1 Predecessor Documents Sequence</summary>
        public const uint PredecessorDocumentsSequence = 0x0040A360;

        ///<summary>(0040,A370) VR=SQ VM=1 Referenced Request Sequence</summary>
        public const uint ReferencedRequestSequence = 0x0040A370;

        ///<summary>(0040,A372) VR=SQ VM=1 Performed Procedure Code Sequence</summary>
        public const uint PerformedProcedureCodeSequence = 0x0040A372;

        ///<summary>(0040,A375) VR=SQ VM=1 Current Requested Procedure Evidence Sequence</summary>
        public const uint CurrentRequestedProcedureEvidenceSequence = 0x0040A375;

        ///<summary>(0040,A380) VR=SQ VM=1 Report Detail Sequence (Trial) (RETIRED)</summary>
        public const uint ReportDetailSequenceTrialRETIRED = 0x0040A380;

        ///<summary>(0040,A385) VR=SQ VM=1 Pertinent Other Evidence Sequence</summary>
        public const uint PertinentOtherEvidenceSequence = 0x0040A385;

        ///<summary>(0040,A390) VR=SQ VM=1 HL7 Structured Document Reference Sequence</summary>
        public const uint HL7StructuredDocumentReferenceSequence = 0x0040A390;

        ///<summary>(0040,A402) VR=UI VM=1 Observation Subject Uid (Trial) (RETIRED)</summary>
        public const uint ObservationSubjectUidTrialRETIRED = 0x0040A402;

        ///<summary>(0040,A403) VR=CS VM=1 Observation Subject Class (Trial) (RETIRED)</summary>
        public const uint ObservationSubjectClassTrialRETIRED = 0x0040A403;

        ///<summary>(0040,A404) VR=SQ VM=1 Observation Subject Type Code Sequence (Trial) (RETIRED)</summary>
        public const uint ObservationSubjectTypeCodeSequenceTrialRETIRED = 0x0040A404;

        ///<summary>(0040,A491) VR=CS VM=1 Completion Flag</summary>
        public const uint CompletionFlag = 0x0040A491;

        ///<summary>(0040,A492) VR=LO VM=1 Completion Flag Description</summary>
        public const uint CompletionFlagDescription = 0x0040A492;

        ///<summary>(0040,A493) VR=CS VM=1 Verification Flag</summary>
        public const uint VerificationFlag = 0x0040A493;

        ///<summary>(0040,A494) VR=CS VM=1 Archive Requested</summary>
        public const uint ArchiveRequested = 0x0040A494;

        ///<summary>(0040,A496) VR=CS VM=1 Preliminary Flag</summary>
        public const uint PreliminaryFlag = 0x0040A496;

        ///<summary>(0040,A504) VR=SQ VM=1 Content Template Sequence</summary>
        public const uint ContentTemplateSequence = 0x0040A504;

        ///<summary>(0040,A525) VR=SQ VM=1 Identical Documents Sequence</summary>
        public const uint IdenticalDocumentsSequence = 0x0040A525;

        ///<summary>(0040,A600) VR=CS VM=1 Observation Subject Context Flag (Trial) (RETIRED)</summary>
        public const uint ObservationSubjectContextFlagTrialRETIRED = 0x0040A600;

        ///<summary>(0040,A601) VR=CS VM=1 Observer Context Flag (Trial) (RETIRED)</summary>
        public const uint ObserverContextFlagTrialRETIRED = 0x0040A601;

        ///<summary>(0040,A603) VR=CS VM=1 Procedure Context Flag (Trial) (RETIRED)</summary>
        public const uint ProcedureContextFlagTrialRETIRED = 0x0040A603;

        ///<summary>(0040,A730) VR=SQ VM=1 Content Sequence</summary>
        public const uint ContentSequence = 0x0040A730;

        ///<summary>(0040,A731) VR=SQ VM=1 Relationship Sequence (Trial) (RETIRED)</summary>
        public const uint RelationshipSequenceTrialRETIRED = 0x0040A731;

        ///<summary>(0040,A732) VR=SQ VM=1 Relationship Type Code Sequence (Trial) (RETIRED)</summary>
        public const uint RelationshipTypeCodeSequenceTrialRETIRED = 0x0040A732;

        ///<summary>(0040,A744) VR=SQ VM=1 Language Code Sequence (Trial) (RETIRED)</summary>
        public const uint LanguageCodeSequenceTrialRETIRED = 0x0040A744;

        ///<summary>(0040,A801) VR=SQ VM=1 Tabulated Values Sequence</summary>
        public const uint TabulatedValuesSequence = 0x0040A801;

        ///<summary>(0040,A802) VR=UL VM=1 Number of Table Rows</summary>
        public const uint NumberOfTableRows = 0x0040A802;

        ///<summary>(0040,A803) VR=UL VM=1 Number of Table Columns</summary>
        public const uint NumberOfTableColumns = 0x0040A803;

        ///<summary>(0040,A804) VR=UL VM=1 Table Row Number</summary>
        public const uint TableRowNumber = 0x0040A804;

        ///<summary>(0040,A805) VR=UL VM=1 Table Column Number</summary>
        public const uint TableColumnNumber = 0x0040A805;

        ///<summary>(0040,A806) VR=SQ VM=1 Table Row Definition Sequence</summary>
        public const uint TableRowDefinitionSequence = 0x0040A806;

        ///<summary>(0040,A807) VR=SQ VM=1 Table Column Definition Sequence</summary>
        public const uint TableColumnDefinitionSequence = 0x0040A807;

        ///<summary>(0040,A808) VR=SQ VM=1 Cell Values Sequence</summary>
        public const uint CellValuesSequence = 0x0040A808;

        ///<summary>(0040,A992) VR=ST VM=1 Uniform Resource Locator (Trial) (RETIRED)</summary>
        public const uint UniformResourceLocatorTrialRETIRED = 0x0040A992;

        ///<summary>(0040,B020) VR=SQ VM=1 Waveform Annotation Sequence</summary>
        public const uint WaveformAnnotationSequence = 0x0040B020;

        ///<summary>(0040,DB00) VR=CS VM=1 Template Identifier</summary>
        public const uint TemplateIdentifier = 0x0040DB00;

        ///<summary>(0040,DB06) VR=DT VM=1 Template Version (RETIRED)</summary>
        public const uint TemplateVersionRETIRED = 0x0040DB06;

        ///<summary>(0040,DB07) VR=DT VM=1 Template Local Version (RETIRED)</summary>
        public const uint TemplateLocalVersionRETIRED = 0x0040DB07;

        ///<summary>(0040,DB0B) VR=CS VM=1 Template Extension Flag (RETIRED)</summary>
        public const uint TemplateExtensionFlagRETIRED = 0x0040DB0B;

        ///<summary>(0040,DB0C) VR=UI VM=1 Template Extension Organization Uid (RETIRED)</summary>
        public const uint TemplateExtensionOrganizationUidRETIRED = 0x0040DB0C;

        ///<summary>(0040,DB0D) VR=UI VM=1 Template Extension Creator Uid (RETIRED)</summary>
        public const uint TemplateExtensionCreatorUidRETIRED = 0x0040DB0D;

        ///<summary>(0040,DB73) VR=UL VM=1-n Referenced Content Item Identifier</summary>
        public const uint ReferencedContentItemIdentifier = 0x0040DB73;

        ///<summary>(0040,E001) VR=ST VM=1 HL7 Instance Identifier</summary>
        public const uint HL7InstanceIdentifier = 0x0040E001;

        ///<summary>(0040,E004) VR=DT VM=1 HL7 Document Effective Time</summary>
        public const uint HL7DocumentEffectiveTime = 0x0040E004;

        ///<summary>(0040,E006) VR=SQ VM=1 HL7 Document Type Code Sequence</summary>
        public const uint HL7DocumentTypeCodeSequence = 0x0040E006;

        ///<summary>(0040,E008) VR=SQ VM=1 Document Class Code Sequence</summary>
        public const uint DocumentClassCodeSequence = 0x0040E008;

        ///<summary>(0040,E010) VR=UR VM=1 Retrieve URI</summary>
        public const uint RetrieveURI = 0x0040E010;

        ///<summary>(0040,E011) VR=UI VM=1 Retrieve Location Uid</summary>
        public const uint RetrieveLocationUid = 0x0040E011;

        ///<summary>(0040,E020) VR=CS VM=1 Type of Instances</summary>
        public const uint TypeOfInstances = 0x0040E020;

        ///<summary>(0040,E021) VR=SQ VM=1 DICOM Retrieval Sequence</summary>
        public const uint DICOMRetrievalSequence = 0x0040E021;

        ///<summary>(0040,E022) VR=SQ VM=1 DICOM Media Retrieval Sequence</summary>
        public const uint DICOMMediaRetrievalSequence = 0x0040E022;

        ///<summary>(0040,E023) VR=SQ VM=1 WADO Retrieval Sequence</summary>
        public const uint WADORetrievalSequence = 0x0040E023;

        ///<summary>(0040,E024) VR=SQ VM=1 XDS Retrieval Sequence</summary>
        public const uint XDSRetrievalSequence = 0x0040E024;

        ///<summary>(0040,E025) VR=SQ VM=1 WADO-RS Retrieval Sequence</summary>
        public const uint WADORSRetrievalSequence = 0x0040E025;

        ///<summary>(0040,E030) VR=UI VM=1 Repository Unique Id</summary>
        public const uint RepositoryUniqueId = 0x0040E030;

        ///<summary>(0040,E031) VR=UI VM=1 Home Community Id</summary>
        public const uint HomeCommunityId = 0x0040E031;

        ///<summary>(0042,0010) VR=ST VM=1 Document Title</summary>
        public const uint DocumentTitle = 0x00420010;

        ///<summary>(0042,0011) VR=OB VM=1 Encapsulated Document</summary>
        public const uint EncapsulatedDocument = 0x00420011;

        ///<summary>(0042,0012) VR=LO VM=1 MIME Type of Encapsulated Document</summary>
        public const uint MIMETypeOfEncapsulatedDocument = 0x00420012;

        ///<summary>(0042,0013) VR=SQ VM=1 Source Instance Sequence</summary>
        public const uint SourceInstanceSequence = 0x00420013;

        ///<summary>(0042,0014) VR=LO VM=1-n List of MIME Types</summary>
        public const uint ListOfMIMETypes = 0x00420014;

        ///<summary>(0042,0015) VR=UL VM=1 Encapsulated Document Length</summary>
        public const uint EncapsulatedDocumentLength = 0x00420015;

        ///<summary>(0044,0001) VR=ST VM=1 Product Package Identifier</summary>
        public const uint ProductPackageIdentifier = 0x00440001;

        ///<summary>(0044,0002) VR=CS VM=1 Substance Administration Approval</summary>
        public const uint SubstanceAdministrationApproval = 0x00440002;

        ///<summary>(0044,0003) VR=LT VM=1 Approval Status Further Description</summary>
        public const uint ApprovalStatusFurtherDescription = 0x00440003;

        ///<summary>(0044,0004) VR=DT VM=1 Approval Status DateTime</summary>
        public const uint ApprovalStatusDateTime = 0x00440004;

        ///<summary>(0044,0007) VR=SQ VM=1 Product Type Code Sequence</summary>
        public const uint ProductTypeCodeSequence = 0x00440007;

        ///<summary>(0044,0008) VR=LO VM=1-n Product Name</summary>
        public const uint ProductName = 0x00440008;

        ///<summary>(0044,0009) VR=LT VM=1 Product Description</summary>
        public const uint ProductDescription = 0x00440009;

        ///<summary>(0044,000A) VR=LO VM=1 Product Lot Identifier</summary>
        public const uint ProductLotIdentifier = 0x0044000A;

        ///<summary>(0044,000B) VR=DT VM=1 Product Expiration DateTime</summary>
        public const uint ProductExpirationDateTime = 0x0044000B;

        ///<summary>(0044,0010) VR=DT VM=1 Substance Administration DateTime</summary>
        public const uint SubstanceAdministrationDateTime = 0x00440010;

        ///<summary>(0044,0011) VR=LO VM=1 Substance Administration Notes</summary>
        public const uint SubstanceAdministrationNotes = 0x00440011;

        ///<summary>(0044,0012) VR=LO VM=1 Substance Administration Device Id</summary>
        public const uint SubstanceAdministrationDeviceId = 0x00440012;

        ///<summary>(0044,0013) VR=SQ VM=1 Product Parameter Sequence</summary>
        public const uint ProductParameterSequence = 0x00440013;

        ///<summary>(0044,0019) VR=SQ VM=1 Substance Administration Parameter Sequence</summary>
        public const uint SubstanceAdministrationParameterSequence = 0x00440019;

        ///<summary>(0044,0100) VR=SQ VM=1 Approval Sequence</summary>
        public const uint ApprovalSequence = 0x00440100;

        ///<summary>(0044,0101) VR=SQ VM=1 Assertion Code Sequence</summary>
        public const uint AssertionCodeSequence = 0x00440101;

        ///<summary>(0044,0102) VR=UI VM=1 Assertion Uid</summary>
        public const uint AssertionUid = 0x00440102;

        ///<summary>(0044,0103) VR=SQ VM=1 Asserter Identification Sequence</summary>
        public const uint AsserterIdentificationSequence = 0x00440103;

        ///<summary>(0044,0104) VR=DT VM=1 Assertion DateTime</summary>
        public const uint AssertionDateTime = 0x00440104;

        ///<summary>(0044,0105) VR=DT VM=1 Assertion Expiration DateTime</summary>
        public const uint AssertionExpirationDateTime = 0x00440105;

        ///<summary>(0044,0106) VR=UT VM=1 Assertion Comments</summary>
        public const uint AssertionComments = 0x00440106;

        ///<summary>(0044,0107) VR=SQ VM=1 Related Assertion Sequence</summary>
        public const uint RelatedAssertionSequence = 0x00440107;

        ///<summary>(0044,0108) VR=UI VM=1 Referenced Assertion Uid</summary>
        public const uint ReferencedAssertionUid = 0x00440108;

        ///<summary>(0044,0109) VR=SQ VM=1 Approval Subject Sequence</summary>
        public const uint ApprovalSubjectSequence = 0x00440109;

        ///<summary>(0044,010A) VR=SQ VM=1 Organizational Role Code Sequence</summary>
        public const uint OrganizationalRoleCodeSequence = 0x0044010A;

        ///<summary>(0046,0012) VR=LO VM=1 Lens Description</summary>
        public const uint LensDescription = 0x00460012;

        ///<summary>(0046,0014) VR=SQ VM=1 Right Lens Sequence</summary>
        public const uint RightLensSequence = 0x00460014;

        ///<summary>(0046,0015) VR=SQ VM=1 Left Lens Sequence</summary>
        public const uint LeftLensSequence = 0x00460015;

        ///<summary>(0046,0016) VR=SQ VM=1 Unspecified Laterality Lens Sequence</summary>
        public const uint UnspecifiedLateralityLensSequence = 0x00460016;

        ///<summary>(0046,0018) VR=SQ VM=1 Cylinder Sequence</summary>
        public const uint CylinderSequence = 0x00460018;

        ///<summary>(0046,0028) VR=SQ VM=1 Prism Sequence</summary>
        public const uint PrismSequence = 0x00460028;

        ///<summary>(0046,0030) VR=FD VM=1 Horizontal Prism Power</summary>
        public const uint HorizontalPrismPower = 0x00460030;

        ///<summary>(0046,0032) VR=CS VM=1 Horizontal Prism Base</summary>
        public const uint HorizontalPrismBase = 0x00460032;

        ///<summary>(0046,0034) VR=FD VM=1 Vertical Prism Power</summary>
        public const uint VerticalPrismPower = 0x00460034;

        ///<summary>(0046,0036) VR=CS VM=1 Vertical Prism Base</summary>
        public const uint VerticalPrismBase = 0x00460036;

        ///<summary>(0046,0038) VR=CS VM=1 Lens Segment Type</summary>
        public const uint LensSegmentType = 0x00460038;

        ///<summary>(0046,0040) VR=FD VM=1 Optical Transmittance</summary>
        public const uint OpticalTransmittance = 0x00460040;

        ///<summary>(0046,0042) VR=FD VM=1 Channel Width</summary>
        public const uint ChannelWidth = 0x00460042;

        ///<summary>(0046,0044) VR=FD VM=1 Pupil Size</summary>
        public const uint PupilSize = 0x00460044;

        ///<summary>(0046,0046) VR=FD VM=1 Corneal Size</summary>
        public const uint CornealSize = 0x00460046;

        ///<summary>(0046,0047) VR=SQ VM=1 Corneal Size Sequence</summary>
        public const uint CornealSizeSequence = 0x00460047;

        ///<summary>(0046,0050) VR=SQ VM=1 Autorefraction Right Eye Sequence</summary>
        public const uint AutorefractionRightEyeSequence = 0x00460050;

        ///<summary>(0046,0052) VR=SQ VM=1 Autorefraction Left Eye Sequence</summary>
        public const uint AutorefractionLeftEyeSequence = 0x00460052;

        ///<summary>(0046,0060) VR=FD VM=1 Distance Pupillary Distance</summary>
        public const uint DistancePupillaryDistance = 0x00460060;

        ///<summary>(0046,0062) VR=FD VM=1 Near Pupillary Distance</summary>
        public const uint NearPupillaryDistance = 0x00460062;

        ///<summary>(0046,0063) VR=FD VM=1 Intermediate Pupillary Distance</summary>
        public const uint IntermediatePupillaryDistance = 0x00460063;

        ///<summary>(0046,0064) VR=FD VM=1 Other Pupillary Distance</summary>
        public const uint OtherPupillaryDistance = 0x00460064;

        ///<summary>(0046,0070) VR=SQ VM=1 Keratometry Right Eye Sequence</summary>
        public const uint KeratometryRightEyeSequence = 0x00460070;

        ///<summary>(0046,0071) VR=SQ VM=1 Keratometry Left Eye Sequence</summary>
        public const uint KeratometryLeftEyeSequence = 0x00460071;

        ///<summary>(0046,0074) VR=SQ VM=1 Steep Keratometric Axis Sequence</summary>
        public const uint SteepKeratometricAxisSequence = 0x00460074;

        ///<summary>(0046,0075) VR=FD VM=1 Radius of Curvature</summary>
        public const uint RadiusOfCurvature = 0x00460075;

        ///<summary>(0046,0076) VR=FD VM=1 Keratometric Power</summary>
        public const uint KeratometricPower = 0x00460076;

        ///<summary>(0046,0077) VR=FD VM=1 Keratometric Axis</summary>
        public const uint KeratometricAxis = 0x00460077;

        ///<summary>(0046,0080) VR=SQ VM=1 Flat Keratometric Axis Sequence</summary>
        public const uint FlatKeratometricAxisSequence = 0x00460080;

        ///<summary>(0046,0092) VR=CS VM=1 Background Color</summary>
        public const uint BackgroundColor = 0x00460092;

        ///<summary>(0046,0094) VR=CS VM=1 Optotype</summary>
        public const uint Optotype = 0x00460094;

        ///<summary>(0046,0095) VR=CS VM=1 Optotype Presentation</summary>
        public const uint OptotypePresentation = 0x00460095;

        ///<summary>(0046,0097) VR=SQ VM=1 Subjective Refraction Right Eye Sequence</summary>
        public const uint SubjectiveRefractionRightEyeSequence = 0x00460097;

        ///<summary>(0046,0098) VR=SQ VM=1 Subjective Refraction Left Eye Sequence</summary>
        public const uint SubjectiveRefractionLeftEyeSequence = 0x00460098;

        ///<summary>(0046,0100) VR=SQ VM=1 Add Near Sequence</summary>
        public const uint AddNearSequence = 0x00460100;

        ///<summary>(0046,0101) VR=SQ VM=1 Add Intermediate Sequence</summary>
        public const uint AddIntermediateSequence = 0x00460101;

        ///<summary>(0046,0102) VR=SQ VM=1 Add Other Sequence</summary>
        public const uint AddOtherSequence = 0x00460102;

        ///<summary>(0046,0104) VR=FD VM=1 Add Power</summary>
        public const uint AddPower = 0x00460104;

        ///<summary>(0046,0106) VR=FD VM=1 Viewing Distance</summary>
        public const uint ViewingDistance = 0x00460106;

        ///<summary>(0046,0110) VR=SQ VM=1 Cornea Measurements Sequence</summary>
        public const uint CorneaMeasurementsSequence = 0x00460110;

        ///<summary>(0046,0111) VR=SQ VM=1 Source of Cornea Measurement Data Code Sequence</summary>
        public const uint SourceOfCorneaMeasurementDataCodeSequence = 0x00460111;

        ///<summary>(0046,0112) VR=SQ VM=1 Steep Corneal Axis Sequence</summary>
        public const uint SteepCornealAxisSequence = 0x00460112;

        ///<summary>(0046,0113) VR=SQ VM=1 Flat Corneal Axis Sequence</summary>
        public const uint FlatCornealAxisSequence = 0x00460113;

        ///<summary>(0046,0114) VR=FD VM=1 Corneal Power</summary>
        public const uint CornealPower = 0x00460114;

        ///<summary>(0046,0115) VR=FD VM=1 Corneal Axis</summary>
        public const uint CornealAxis = 0x00460115;

        ///<summary>(0046,0116) VR=SQ VM=1 Cornea Measurement Method Code Sequence</summary>
        public const uint CorneaMeasurementMethodCodeSequence = 0x00460116;

        ///<summary>(0046,0117) VR=FL VM=1 Refractive Index of Cornea</summary>
        public const uint RefractiveIndexOfCornea = 0x00460117;

        ///<summary>(0046,0118) VR=FL VM=1 Refractive Index of Aqueous Humor</summary>
        public const uint RefractiveIndexOfAqueousHumor = 0x00460118;

        ///<summary>(0046,0121) VR=SQ VM=1 Visual Acuity Type Code Sequence</summary>
        public const uint VisualAcuityTypeCodeSequence = 0x00460121;

        ///<summary>(0046,0122) VR=SQ VM=1 Visual Acuity Right Eye Sequence</summary>
        public const uint VisualAcuityRightEyeSequence = 0x00460122;

        ///<summary>(0046,0123) VR=SQ VM=1 Visual Acuity Left Eye Sequence</summary>
        public const uint VisualAcuityLeftEyeSequence = 0x00460123;

        ///<summary>(0046,0124) VR=SQ VM=1 Visual Acuity Both Eyes Open Sequence</summary>
        public const uint VisualAcuityBothEyesOpenSequence = 0x00460124;

        ///<summary>(0046,0125) VR=CS VM=1 Viewing Distance Type</summary>
        public const uint ViewingDistanceType = 0x00460125;

        ///<summary>(0046,0135) VR=SS VM=2 Visual Acuity Modifiers</summary>
        public const uint VisualAcuityModifiers = 0x00460135;

        ///<summary>(0046,0137) VR=FD VM=1 Decimal Visual Acuity</summary>
        public const uint DecimalVisualAcuity = 0x00460137;

        ///<summary>(0046,0139) VR=LO VM=1 Optotype Detailed Definition</summary>
        public const uint OptotypeDetailedDefinition = 0x00460139;

        ///<summary>(0046,0145) VR=SQ VM=1 Referenced Refractive Measurements Sequence</summary>
        public const uint ReferencedRefractiveMeasurementsSequence = 0x00460145;

        ///<summary>(0046,0146) VR=FD VM=1 Sphere Power</summary>
        public const uint SpherePower = 0x00460146;

        ///<summary>(0046,0147) VR=FD VM=1 Cylinder Power</summary>
        public const uint CylinderPower = 0x00460147;

        ///<summary>(0046,0201) VR=CS VM=1 Corneal Topography Surface</summary>
        public const uint CornealTopographySurface = 0x00460201;

        ///<summary>(0046,0202) VR=FL VM=2 Corneal Vertex Location</summary>
        public const uint CornealVertexLocation = 0x00460202;

        ///<summary>(0046,0203) VR=FL VM=1 Pupil Centroid X-Coordinate</summary>
        public const uint PupilCentroidXCoordinate = 0x00460203;

        ///<summary>(0046,0204) VR=FL VM=1 Pupil Centroid Y-Coordinate</summary>
        public const uint PupilCentroidYCoordinate = 0x00460204;

        ///<summary>(0046,0205) VR=FL VM=1 Equivalent Pupil Radius</summary>
        public const uint EquivalentPupilRadius = 0x00460205;

        ///<summary>(0046,0207) VR=SQ VM=1 Corneal Topography Map Type Code Sequence</summary>
        public const uint CornealTopographyMapTypeCodeSequence = 0x00460207;

        ///<summary>(0046,0208) VR=IS VM=2-2n Vertices of the Outline of Pupil</summary>
        public const uint VerticesOfTheOutlineOfPupil = 0x00460208;

        ///<summary>(0046,0210) VR=SQ VM=1 Corneal Topography Mapping Normals Sequence</summary>
        public const uint CornealTopographyMappingNormalsSequence = 0x00460210;

        ///<summary>(0046,0211) VR=SQ VM=1 Maximum Corneal Curvature Sequence</summary>
        public const uint MaximumCornealCurvatureSequence = 0x00460211;

        ///<summary>(0046,0212) VR=FL VM=1 Maximum Corneal Curvature</summary>
        public const uint MaximumCornealCurvature = 0x00460212;

        ///<summary>(0046,0213) VR=FL VM=2 Maximum Corneal Curvature Location</summary>
        public const uint MaximumCornealCurvatureLocation = 0x00460213;

        ///<summary>(0046,0215) VR=SQ VM=1 Minimum Keratometric Sequence</summary>
        public const uint MinimumKeratometricSequence = 0x00460215;

        ///<summary>(0046,0218) VR=SQ VM=1 Simulated Keratometric Cylinder Sequence</summary>
        public const uint SimulatedKeratometricCylinderSequence = 0x00460218;

        ///<summary>(0046,0220) VR=FL VM=1 Average Corneal Power</summary>
        public const uint AverageCornealPower = 0x00460220;

        ///<summary>(0046,0224) VR=FL VM=1 Corneal I-S Value</summary>
        public const uint CornealISValue = 0x00460224;

        ///<summary>(0046,0227) VR=FL VM=1 Analyzed Area</summary>
        public const uint AnalyzedArea = 0x00460227;

        ///<summary>(0046,0230) VR=FL VM=1 Surface Regularity Index</summary>
        public const uint SurfaceRegularityIndex = 0x00460230;

        ///<summary>(0046,0232) VR=FL VM=1 Surface Asymmetry Index</summary>
        public const uint SurfaceAsymmetryIndex = 0x00460232;

        ///<summary>(0046,0234) VR=FL VM=1 Corneal Eccentricity Index</summary>
        public const uint CornealEccentricityIndex = 0x00460234;

        ///<summary>(0046,0236) VR=FL VM=1 Keratoconus Prediction Index</summary>
        public const uint KeratoconusPredictionIndex = 0x00460236;

        ///<summary>(0046,0238) VR=FL VM=1 Decimal Potential Visual Acuity</summary>
        public const uint DecimalPotentialVisualAcuity = 0x00460238;

        ///<summary>(0046,0242) VR=CS VM=1 Corneal Topography Map Quality Evaluation</summary>
        public const uint CornealTopographyMapQualityEvaluation = 0x00460242;

        ///<summary>(0046,0244) VR=SQ VM=1 Source Image Corneal Processed Data Sequence</summary>
        public const uint SourceImageCornealProcessedDataSequence = 0x00460244;

        ///<summary>(0046,0247) VR=FL VM=3 Corneal Point Location</summary>
        public const uint CornealPointLocation = 0x00460247;

        ///<summary>(0046,0248) VR=CS VM=1 Corneal Point Estimated</summary>
        public const uint CornealPointEstimated = 0x00460248;

        ///<summary>(0046,0249) VR=FL VM=1 Axial Power</summary>
        public const uint AxialPower = 0x00460249;

        ///<summary>(0046,0250) VR=FL VM=1 Tangential Power</summary>
        public const uint TangentialPower = 0x00460250;

        ///<summary>(0046,0251) VR=FL VM=1 Refractive Power</summary>
        public const uint RefractivePower = 0x00460251;

        ///<summary>(0046,0252) VR=FL VM=1 Relative Elevation</summary>
        public const uint RelativeElevation = 0x00460252;

        ///<summary>(0046,0253) VR=FL VM=1 Corneal Wavefront</summary>
        public const uint CornealWavefront = 0x00460253;

        ///<summary>(0048,0001) VR=FL VM=1 Imaged Volume Width</summary>
        public const uint ImagedVolumeWidth = 0x00480001;

        ///<summary>(0048,0002) VR=FL VM=1 Imaged Volume Height</summary>
        public const uint ImagedVolumeHeight = 0x00480002;

        ///<summary>(0048,0003) VR=FL VM=1 Imaged Volume Depth</summary>
        public const uint ImagedVolumeDepth = 0x00480003;

        ///<summary>(0048,0006) VR=UL VM=1 Total Pixel Matrix Columns</summary>
        public const uint TotalPixelMatrixColumns = 0x00480006;

        ///<summary>(0048,0007) VR=UL VM=1 Total Pixel Matrix Rows</summary>
        public const uint TotalPixelMatrixRows = 0x00480007;

        ///<summary>(0048,0008) VR=SQ VM=1 Total Pixel Matrix Origin Sequence</summary>
        public const uint TotalPixelMatrixOriginSequence = 0x00480008;

        ///<summary>(0048,0010) VR=CS VM=1 Specimen Label in Image</summary>
        public const uint SpecimenLabelInImage = 0x00480010;

        ///<summary>(0048,0011) VR=CS VM=1 Focus Method</summary>
        public const uint FocusMethod = 0x00480011;

        ///<summary>(0048,0012) VR=CS VM=1 Extended Depth of Field</summary>
        public const uint ExtendedDepthOfField = 0x00480012;

        ///<summary>(0048,0013) VR=US VM=1 Number of Focal Planes</summary>
        public const uint NumberOfFocalPlanes = 0x00480013;

        ///<summary>(0048,0014) VR=FL VM=1 Distance Between Focal Planes</summary>
        public const uint DistanceBetweenFocalPlanes = 0x00480014;

        ///<summary>(0048,0015) VR=US VM=3 Recommended Absent Pixel CIELab Value</summary>
        public const uint RecommendedAbsentPixelCIELabValue = 0x00480015;

        ///<summary>(0048,0100) VR=SQ VM=1 Illuminator Type Code Sequence</summary>
        public const uint IlluminatorTypeCodeSequence = 0x00480100;

        ///<summary>(0048,0102) VR=DS VM=6 Image Orientation (Slide)</summary>
        public const uint ImageOrientationSlide = 0x00480102;

        ///<summary>(0048,0105) VR=SQ VM=1 Optical Path Sequence</summary>
        public const uint OpticalPathSequence = 0x00480105;

        ///<summary>(0048,0106) VR=SH VM=1 Optical Path Identifier</summary>
        public const uint OpticalPathIdentifier = 0x00480106;

        ///<summary>(0048,0107) VR=ST VM=1 Optical Path Description</summary>
        public const uint OpticalPathDescription = 0x00480107;

        ///<summary>(0048,0108) VR=SQ VM=1 Illumination Color Code Sequence</summary>
        public const uint IlluminationColorCodeSequence = 0x00480108;

        ///<summary>(0048,0110) VR=SQ VM=1 Specimen Reference Sequence</summary>
        public const uint SpecimenReferenceSequence = 0x00480110;

        ///<summary>(0048,0111) VR=DS VM=1 Condenser Lens Power</summary>
        public const uint CondenserLensPower = 0x00480111;

        ///<summary>(0048,0112) VR=DS VM=1 Objective Lens Power</summary>
        public const uint ObjectiveLensPower = 0x00480112;

        ///<summary>(0048,0113) VR=DS VM=1 Objective Lens Numerical Aperture</summary>
        public const uint ObjectiveLensNumericalAperture = 0x00480113;

        ///<summary>(0048,0120) VR=SQ VM=1 Palette Color Lookup Table Sequence</summary>
        public const uint PaletteColorLookupTableSequence = 0x00480120;

        ///<summary>(0048,0200) VR=SQ VM=1 Referenced Image Navigation Sequence (RETIRED)</summary>
        public const uint ReferencedImageNavigationSequenceRETIRED = 0x00480200;

        ///<summary>(0048,0201) VR=US VM=2 Top Left Hand Corner of Localizer Area (RETIRED)</summary>
        public const uint TopLeftHandCornerOfLocalizerAreaRETIRED = 0x00480201;

        ///<summary>(0048,0202) VR=US VM=2 Bottom Right Hand Corner of Localizer Area (RETIRED)</summary>
        public const uint BottomRightHandCornerOfLocalizerAreaRETIRED = 0x00480202;

        ///<summary>(0048,0207) VR=SQ VM=1 Optical Path Identification Sequence</summary>
        public const uint OpticalPathIdentificationSequence = 0x00480207;

        ///<summary>(0048,021A) VR=SQ VM=1 Plane Position (Slide) Sequence</summary>
        public const uint PlanePositionSlideSequence = 0x0048021A;

        ///<summary>(0048,021E) VR=SL VM=1 Column Position In Total Image Pixel Matrix</summary>
        public const uint ColumnPositionInTotalImagePixelMatrix = 0x0048021E;

        ///<summary>(0048,021F) VR=SL VM=1 Row Position In Total Image Pixel Matrix</summary>
        public const uint RowPositionInTotalImagePixelMatrix = 0x0048021F;

        ///<summary>(0048,0301) VR=CS VM=1 Pixel Origin Interpretation</summary>
        public const uint PixelOriginInterpretation = 0x00480301;

        ///<summary>(0048,0302) VR=UL VM=1 Number of Optical Paths</summary>
        public const uint NumberOfOpticalPaths = 0x00480302;

        ///<summary>(0048,0303) VR=UL VM=1 Total Pixel Matrix Focal Planes</summary>
        public const uint TotalPixelMatrixFocalPlanes = 0x00480303;

        ///<summary>(0050,0004) VR=CS VM=1 Calibration Image</summary>
        public const uint CalibrationImage = 0x00500004;

        ///<summary>(0050,0010) VR=SQ VM=1 Device Sequence</summary>
        public const uint DeviceSequence = 0x00500010;

        ///<summary>(0050,0012) VR=SQ VM=1 Container Component Type Code Sequence</summary>
        public const uint ContainerComponentTypeCodeSequence = 0x00500012;

        ///<summary>(0050,0013) VR=FD VM=1 Container Component Thickness</summary>
        public const uint ContainerComponentThickness = 0x00500013;

        ///<summary>(0050,0014) VR=DS VM=1 Device Length</summary>
        public const uint DeviceLength = 0x00500014;

        ///<summary>(0050,0015) VR=FD VM=1 Container Component Width</summary>
        public const uint ContainerComponentWidth = 0x00500015;

        ///<summary>(0050,0016) VR=DS VM=1 Device Diameter</summary>
        public const uint DeviceDiameter = 0x00500016;

        ///<summary>(0050,0017) VR=CS VM=1 Device Diameter Units</summary>
        public const uint DeviceDiameterUnits = 0x00500017;

        ///<summary>(0050,0018) VR=DS VM=1 Device Volume</summary>
        public const uint DeviceVolume = 0x00500018;

        ///<summary>(0050,0019) VR=DS VM=1 Inter-Marker Distance</summary>
        public const uint InterMarkerDistance = 0x00500019;

        ///<summary>(0050,001A) VR=CS VM=1 Container Component Material</summary>
        public const uint ContainerComponentMaterial = 0x0050001A;

        ///<summary>(0050,001B) VR=LO VM=1 Container Component Id</summary>
        public const uint ContainerComponentId = 0x0050001B;

        ///<summary>(0050,001C) VR=FD VM=1 Container Component Length</summary>
        public const uint ContainerComponentLength = 0x0050001C;

        ///<summary>(0050,001D) VR=FD VM=1 Container Component Diameter</summary>
        public const uint ContainerComponentDiameter = 0x0050001D;

        ///<summary>(0050,001E) VR=LO VM=1 Container Component Description</summary>
        public const uint ContainerComponentDescription = 0x0050001E;

        ///<summary>(0050,0020) VR=LO VM=1 Device Description</summary>
        public const uint DeviceDescription = 0x00500020;

        ///<summary>(0050,0021) VR=ST VM=1 Long Device Description</summary>
        public const uint LongDeviceDescription = 0x00500021;

        ///<summary>(0052,0001) VR=FL VM=1 Contrast/Bolus Ingredient Percent by Volume</summary>
        public const uint ContrastBolusIngredientPercentByVolume = 0x00520001;

        ///<summary>(0052,0002) VR=FD VM=1 OCT Focal Distance</summary>
        public const uint OCTFocalDistance = 0x00520002;

        ///<summary>(0052,0003) VR=FD VM=1 Beam Spot Size</summary>
        public const uint BeamSpotSize = 0x00520003;

        ///<summary>(0052,0004) VR=FD VM=1 Effective Refractive Index</summary>
        public const uint EffectiveRefractiveIndex = 0x00520004;

        ///<summary>(0052,0006) VR=CS VM=1 OCT Acquisition Domain</summary>
        public const uint OCTAcquisitionDomain = 0x00520006;

        ///<summary>(0052,0007) VR=FD VM=1 OCT Optical Center Wavelength</summary>
        public const uint OCTOpticalCenterWavelength = 0x00520007;

        ///<summary>(0052,0008) VR=FD VM=1 Axial Resolution</summary>
        public const uint AxialResolution = 0x00520008;

        ///<summary>(0052,0009) VR=FD VM=1 Ranging Depth</summary>
        public const uint RangingDepth = 0x00520009;

        ///<summary>(0052,0011) VR=FD VM=1 A-line Rate</summary>
        public const uint ALineRate = 0x00520011;

        ///<summary>(0052,0012) VR=US VM=1 A-lines Per Frame</summary>
        public const uint ALinesPerFrame = 0x00520012;

        ///<summary>(0052,0013) VR=FD VM=1 Catheter Rotational Rate</summary>
        public const uint CatheterRotationalRate = 0x00520013;

        ///<summary>(0052,0014) VR=FD VM=1 A-line Pixel Spacing</summary>
        public const uint ALinePixelSpacing = 0x00520014;

        ///<summary>(0052,0016) VR=SQ VM=1 Mode of Percutaneous Access Sequence</summary>
        public const uint ModeOfPercutaneousAccessSequence = 0x00520016;

        ///<summary>(0052,0025) VR=SQ VM=1 Intravascular OCT Frame Type Sequence</summary>
        public const uint IntravascularOCTFrameTypeSequence = 0x00520025;

        ///<summary>(0052,0026) VR=CS VM=1 OCT Z Offset Applied</summary>
        public const uint OCTZOffsetApplied = 0x00520026;

        ///<summary>(0052,0027) VR=SQ VM=1 Intravascular Frame Content Sequence</summary>
        public const uint IntravascularFrameContentSequence = 0x00520027;

        ///<summary>(0052,0028) VR=FD VM=1 Intravascular Longitudinal Distance</summary>
        public const uint IntravascularLongitudinalDistance = 0x00520028;

        ///<summary>(0052,0029) VR=SQ VM=1 Intravascular OCT Frame Content Sequence</summary>
        public const uint IntravascularOCTFrameContentSequence = 0x00520029;

        ///<summary>(0052,0030) VR=SS VM=1 OCT Z Offset Correction</summary>
        public const uint OCTZOffsetCorrection = 0x00520030;

        ///<summary>(0052,0031) VR=CS VM=1 Catheter Direction of Rotation</summary>
        public const uint CatheterDirectionOfRotation = 0x00520031;

        ///<summary>(0052,0033) VR=FD VM=1 Seam Line Location</summary>
        public const uint SeamLineLocation = 0x00520033;

        ///<summary>(0052,0034) VR=FD VM=1 First A-line Location</summary>
        public const uint FirstALineLocation = 0x00520034;

        ///<summary>(0052,0036) VR=US VM=1 Seam Line Index</summary>
        public const uint SeamLineIndex = 0x00520036;

        ///<summary>(0052,0038) VR=US VM=1 Number of Padded A-lines</summary>
        public const uint NumberOfPaddedALines = 0x00520038;

        ///<summary>(0052,0039) VR=CS VM=1 Interpolation Type</summary>
        public const uint InterpolationType = 0x00520039;

        ///<summary>(0052,003A) VR=CS VM=1 Refractive Index Applied</summary>
        public const uint RefractiveIndexApplied = 0x0052003A;

        ///<summary>(0054,0010) VR=US VM=1-n Energy Window Vector</summary>
        public const uint EnergyWindowVector = 0x00540010;

        ///<summary>(0054,0011) VR=US VM=1 Number of Energy Windows</summary>
        public const uint NumberOfEnergyWindows = 0x00540011;

        ///<summary>(0054,0012) VR=SQ VM=1 Energy Window Information Sequence</summary>
        public const uint EnergyWindowInformationSequence = 0x00540012;

        ///<summary>(0054,0013) VR=SQ VM=1 Energy Window Range Sequence</summary>
        public const uint EnergyWindowRangeSequence = 0x00540013;

        ///<summary>(0054,0014) VR=DS VM=1 Energy Window Lower Limit</summary>
        public const uint EnergyWindowLowerLimit = 0x00540014;

        ///<summary>(0054,0015) VR=DS VM=1 Energy Window Upper Limit</summary>
        public const uint EnergyWindowUpperLimit = 0x00540015;

        ///<summary>(0054,0016) VR=SQ VM=1 Radiopharmaceutical Information Sequence</summary>
        public const uint RadiopharmaceuticalInformationSequence = 0x00540016;

        ///<summary>(0054,0017) VR=IS VM=1 Residual Syringe Counts</summary>
        public const uint ResidualSyringeCounts = 0x00540017;

        ///<summary>(0054,0018) VR=SH VM=1 Energy Window Name</summary>
        public const uint EnergyWindowName = 0x00540018;

        ///<summary>(0054,0020) VR=US VM=1-n Detector Vector</summary>
        public const uint DetectorVector = 0x00540020;

        ///<summary>(0054,0021) VR=US VM=1 Number of Detectors</summary>
        public const uint NumberOfDetectors = 0x00540021;

        ///<summary>(0054,0022) VR=SQ VM=1 Detector Information Sequence</summary>
        public const uint DetectorInformationSequence = 0x00540022;

        ///<summary>(0054,0030) VR=US VM=1-n Phase Vector</summary>
        public const uint PhaseVector = 0x00540030;

        ///<summary>(0054,0031) VR=US VM=1 Number of Phases</summary>
        public const uint NumberOfPhases = 0x00540031;

        ///<summary>(0054,0032) VR=SQ VM=1 Phase Information Sequence</summary>
        public const uint PhaseInformationSequence = 0x00540032;

        ///<summary>(0054,0033) VR=US VM=1 Number of Frames in Phase</summary>
        public const uint NumberOfFramesInPhase = 0x00540033;

        ///<summary>(0054,0036) VR=IS VM=1 Phase Delay</summary>
        public const uint PhaseDelay = 0x00540036;

        ///<summary>(0054,0038) VR=IS VM=1 Pause Between Frames</summary>
        public const uint PauseBetweenFrames = 0x00540038;

        ///<summary>(0054,0039) VR=CS VM=1 Phase Description</summary>
        public const uint PhaseDescription = 0x00540039;

        ///<summary>(0054,0050) VR=US VM=1-n Rotation Vector</summary>
        public const uint RotationVector = 0x00540050;

        ///<summary>(0054,0051) VR=US VM=1 Number of Rotations</summary>
        public const uint NumberOfRotations = 0x00540051;

        ///<summary>(0054,0052) VR=SQ VM=1 Rotation Information Sequence</summary>
        public const uint RotationInformationSequence = 0x00540052;

        ///<summary>(0054,0053) VR=US VM=1 Number of Frames in Rotation</summary>
        public const uint NumberOfFramesInRotation = 0x00540053;

        ///<summary>(0054,0060) VR=US VM=1-n R-R Interval Vector</summary>
        public const uint RRIntervalVector = 0x00540060;

        ///<summary>(0054,0061) VR=US VM=1 Number of R-R Intervals</summary>
        public const uint NumberOfRRIntervals = 0x00540061;

        ///<summary>(0054,0062) VR=SQ VM=1 Gated Information Sequence</summary>
        public const uint GatedInformationSequence = 0x00540062;

        ///<summary>(0054,0063) VR=SQ VM=1 Data Information Sequence</summary>
        public const uint DataInformationSequence = 0x00540063;

        ///<summary>(0054,0070) VR=US VM=1-n Time Slot Vector</summary>
        public const uint TimeSlotVector = 0x00540070;

        ///<summary>(0054,0071) VR=US VM=1 Number of Time Slots</summary>
        public const uint NumberOfTimeSlots = 0x00540071;

        ///<summary>(0054,0072) VR=SQ VM=1 Time Slot Information Sequence</summary>
        public const uint TimeSlotInformationSequence = 0x00540072;

        ///<summary>(0054,0073) VR=DS VM=1 Time Slot Time</summary>
        public const uint TimeSlotTime = 0x00540073;

        ///<summary>(0054,0080) VR=US VM=1-n Slice Vector</summary>
        public const uint SliceVector = 0x00540080;

        ///<summary>(0054,0081) VR=US VM=1 Number of Slices</summary>
        public const uint NumberOfSlices = 0x00540081;

        ///<summary>(0054,0090) VR=US VM=1-n Angular View Vector</summary>
        public const uint AngularViewVector = 0x00540090;

        ///<summary>(0054,0100) VR=US VM=1-n Time Slice Vector</summary>
        public const uint TimeSliceVector = 0x00540100;

        ///<summary>(0054,0101) VR=US VM=1 Number of Time Slices</summary>
        public const uint NumberOfTimeSlices = 0x00540101;

        ///<summary>(0054,0200) VR=DS VM=1 Start Angle</summary>
        public const uint StartAngle = 0x00540200;

        ///<summary>(0054,0202) VR=CS VM=1 Type of Detector Motion</summary>
        public const uint TypeOfDetectorMotion = 0x00540202;

        ///<summary>(0054,0210) VR=IS VM=1-n Trigger Vector</summary>
        public const uint TriggerVector = 0x00540210;

        ///<summary>(0054,0211) VR=US VM=1 Number of Triggers in Phase</summary>
        public const uint NumberOfTriggersInPhase = 0x00540211;

        ///<summary>(0054,0220) VR=SQ VM=1 View Code Sequence</summary>
        public const uint ViewCodeSequence = 0x00540220;

        ///<summary>(0054,0222) VR=SQ VM=1 View Modifier Code Sequence</summary>
        public const uint ViewModifierCodeSequence = 0x00540222;

        ///<summary>(0054,0300) VR=SQ VM=1 Radionuclide Code Sequence</summary>
        public const uint RadionuclideCodeSequence = 0x00540300;

        ///<summary>(0054,0302) VR=SQ VM=1 Administration Route Code Sequence</summary>
        public const uint AdministrationRouteCodeSequence = 0x00540302;

        ///<summary>(0054,0304) VR=SQ VM=1 Radiopharmaceutical Code Sequence</summary>
        public const uint RadiopharmaceuticalCodeSequence = 0x00540304;

        ///<summary>(0054,0306) VR=SQ VM=1 Calibration Data Sequence</summary>
        public const uint CalibrationDataSequence = 0x00540306;

        ///<summary>(0054,0308) VR=US VM=1 Energy Window Number</summary>
        public const uint EnergyWindowNumber = 0x00540308;

        ///<summary>(0054,0400) VR=SH VM=1 Image Id</summary>
        public const uint ImageId = 0x00540400;

        ///<summary>(0054,0410) VR=SQ VM=1 Patient Orientation Code Sequence</summary>
        public const uint PatientOrientationCodeSequence = 0x00540410;

        ///<summary>(0054,0412) VR=SQ VM=1 Patient Orientation Modifier Code Sequence</summary>
        public const uint PatientOrientationModifierCodeSequence = 0x00540412;

        ///<summary>(0054,0414) VR=SQ VM=1 Patient Gantry Relationship Code Sequence</summary>
        public const uint PatientGantryRelationshipCodeSequence = 0x00540414;

        ///<summary>(0054,0500) VR=CS VM=1 Slice Progression Direction</summary>
        public const uint SliceProgressionDirection = 0x00540500;

        ///<summary>(0054,0501) VR=CS VM=1 Scan Progression Direction</summary>
        public const uint ScanProgressionDirection = 0x00540501;

        ///<summary>(0054,1000) VR=CS VM=2 Series Type</summary>
        public const uint SeriesType = 0x00541000;

        ///<summary>(0054,1001) VR=CS VM=1 Units</summary>
        public const uint Units = 0x00541001;

        ///<summary>(0054,1002) VR=CS VM=1 Counts Source</summary>
        public const uint CountsSource = 0x00541002;

        ///<summary>(0054,1004) VR=CS VM=1 Reprojection Method</summary>
        public const uint ReprojectionMethod = 0x00541004;

        ///<summary>(0054,1006) VR=CS VM=1 SUV Type</summary>
        public const uint SUVType = 0x00541006;

        ///<summary>(0054,1100) VR=CS VM=1 Randoms Correction Method</summary>
        public const uint RandomsCorrectionMethod = 0x00541100;

        ///<summary>(0054,1101) VR=LO VM=1 Attenuation Correction Method</summary>
        public const uint AttenuationCorrectionMethod = 0x00541101;

        ///<summary>(0054,1102) VR=CS VM=1 Decay Correction</summary>
        public const uint DecayCorrection = 0x00541102;

        ///<summary>(0054,1103) VR=LO VM=1 Reconstruction Method</summary>
        public const uint ReconstructionMethod = 0x00541103;

        ///<summary>(0054,1104) VR=LO VM=1 Detector Lines of Response Used</summary>
        public const uint DetectorLinesOfResponseUsed = 0x00541104;

        ///<summary>(0054,1105) VR=LO VM=1 Scatter Correction Method</summary>
        public const uint ScatterCorrectionMethod = 0x00541105;

        ///<summary>(0054,1200) VR=DS VM=1 Axial Acceptance</summary>
        public const uint AxialAcceptance = 0x00541200;

        ///<summary>(0054,1201) VR=IS VM=2 Axial Mash</summary>
        public const uint AxialMash = 0x00541201;

        ///<summary>(0054,1202) VR=IS VM=1 Transverse Mash</summary>
        public const uint TransverseMash = 0x00541202;

        ///<summary>(0054,1203) VR=DS VM=2 Detector Element Size</summary>
        public const uint DetectorElementSize = 0x00541203;

        ///<summary>(0054,1210) VR=DS VM=1 Coincidence Window Width</summary>
        public const uint CoincidenceWindowWidth = 0x00541210;

        ///<summary>(0054,1220) VR=CS VM=1-n Secondary Counts Type</summary>
        public const uint SecondaryCountsType = 0x00541220;

        ///<summary>(0054,1300) VR=DS VM=1 Frame Reference Time</summary>
        public const uint FrameReferenceTime = 0x00541300;

        ///<summary>(0054,1310) VR=IS VM=1 Primary (Prompts) Counts Accumulated</summary>
        public const uint PrimaryPromptsCountsAccumulated = 0x00541310;

        ///<summary>(0054,1311) VR=IS VM=1-n Secondary Counts Accumulated</summary>
        public const uint SecondaryCountsAccumulated = 0x00541311;

        ///<summary>(0054,1320) VR=DS VM=1 Slice Sensitivity Factor</summary>
        public const uint SliceSensitivityFactor = 0x00541320;

        ///<summary>(0054,1321) VR=DS VM=1 Decay Factor</summary>
        public const uint DecayFactor = 0x00541321;

        ///<summary>(0054,1322) VR=DS VM=1 Dose Calibration Factor</summary>
        public const uint DoseCalibrationFactor = 0x00541322;

        ///<summary>(0054,1323) VR=DS VM=1 Scatter Fraction Factor</summary>
        public const uint ScatterFractionFactor = 0x00541323;

        ///<summary>(0054,1324) VR=DS VM=1 Dead Time Factor</summary>
        public const uint DeadTimeFactor = 0x00541324;

        ///<summary>(0054,1330) VR=US VM=1 Image Index</summary>
        public const uint ImageIndex = 0x00541330;

        ///<summary>(0054,1400) VR=CS VM=1-n Counts Included (RETIRED)</summary>
        public const uint CountsIncludedRETIRED = 0x00541400;

        ///<summary>(0054,1401) VR=CS VM=1 Dead Time Correction Flag (RETIRED)</summary>
        public const uint DeadTimeCorrectionFlagRETIRED = 0x00541401;

        ///<summary>(0060,3000) VR=SQ VM=1 Histogram Sequence</summary>
        public const uint HistogramSequence = 0x00603000;

        ///<summary>(0060,3002) VR=US VM=1 Histogram Number of Bins</summary>
        public const uint HistogramNumberOfBins = 0x00603002;

        ///<summary>(0060,3004) VR=US/SS VM=1 Histogram First Bin Value</summary>
        public const uint HistogramFirstBinValue = 0x00603004;

        ///<summary>(0060,3006) VR=US/SS VM=1 Histogram Last Bin Value</summary>
        public const uint HistogramLastBinValue = 0x00603006;

        ///<summary>(0060,3008) VR=US VM=1 Histogram Bin Width</summary>
        public const uint HistogramBinWidth = 0x00603008;

        ///<summary>(0060,3010) VR=LO VM=1 Histogram Explanation</summary>
        public const uint HistogramExplanation = 0x00603010;

        ///<summary>(0060,3020) VR=UL VM=1-n Histogram Data</summary>
        public const uint HistogramData = 0x00603020;

        ///<summary>(0062,0001) VR=CS VM=1 Segmentation Type</summary>
        public const uint SegmentationType = 0x00620001;

        ///<summary>(0062,0002) VR=SQ VM=1 Segment Sequence</summary>
        public const uint SegmentSequence = 0x00620002;

        ///<summary>(0062,0003) VR=SQ VM=1 Segmented Property Category Code Sequence</summary>
        public const uint SegmentedPropertyCategoryCodeSequence = 0x00620003;

        ///<summary>(0062,0004) VR=US VM=1 Segment Number</summary>
        public const uint SegmentNumber = 0x00620004;

        ///<summary>(0062,0005) VR=LO VM=1 Segment Label</summary>
        public const uint SegmentLabel = 0x00620005;

        ///<summary>(0062,0006) VR=ST VM=1 Segment Description</summary>
        public const uint SegmentDescription = 0x00620006;

        ///<summary>(0062,0007) VR=SQ VM=1 Segmentation Algorithm Identification Sequence</summary>
        public const uint SegmentationAlgorithmIdentificationSequence = 0x00620007;

        ///<summary>(0062,0008) VR=CS VM=1 Segment Algorithm Type</summary>
        public const uint SegmentAlgorithmType = 0x00620008;

        ///<summary>(0062,0009) VR=LO VM=1-n Segment Algorithm Name</summary>
        public const uint SegmentAlgorithmName = 0x00620009;

        ///<summary>(0062,000A) VR=SQ VM=1 Segment Identification Sequence</summary>
        public const uint SegmentIdentificationSequence = 0x0062000A;

        ///<summary>(0062,000B) VR=US VM=1-n Referenced Segment Number</summary>
        public const uint ReferencedSegmentNumber = 0x0062000B;

        ///<summary>(0062,000C) VR=US VM=1 Recommended Display Grayscale Value</summary>
        public const uint RecommendedDisplayGrayscaleValue = 0x0062000C;

        ///<summary>(0062,000D) VR=US VM=3 Recommended Display CIELab Value</summary>
        public const uint RecommendedDisplayCIELabValue = 0x0062000D;

        ///<summary>(0062,000E) VR=US VM=1 Maximum Fractional Value</summary>
        public const uint MaximumFractionalValue = 0x0062000E;

        ///<summary>(0062,000F) VR=SQ VM=1 Segmented Property Type Code Sequence</summary>
        public const uint SegmentedPropertyTypeCodeSequence = 0x0062000F;

        ///<summary>(0062,0010) VR=CS VM=1 Segmentation Fractional Type</summary>
        public const uint SegmentationFractionalType = 0x00620010;

        ///<summary>(0062,0011) VR=SQ VM=1 Segmented Property Type Modifier Code Sequence</summary>
        public const uint SegmentedPropertyTypeModifierCodeSequence = 0x00620011;

        ///<summary>(0062,0012) VR=SQ VM=1 Used Segments Sequence</summary>
        public const uint UsedSegmentsSequence = 0x00620012;

        ///<summary>(0062,0013) VR=CS VM=1 Segments Overlap</summary>
        public const uint SegmentsOverlap = 0x00620013;

        ///<summary>(0062,0020) VR=UT VM=1 Tracking Id</summary>
        public const uint TrackingId = 0x00620020;

        ///<summary>(0062,0021) VR=UI VM=1 Tracking Uid</summary>
        public const uint TrackingUid = 0x00620021;

        ///<summary>(0064,0002) VR=SQ VM=1 Deformable Registration Sequence</summary>
        public const uint DeformableRegistrationSequence = 0x00640002;

        ///<summary>(0064,0003) VR=UI VM=1 Source Frame of Reference Uid</summary>
        public const uint SourceFrameOfReferenceUid = 0x00640003;

        ///<summary>(0064,0005) VR=SQ VM=1 Deformable Registration Grid Sequence</summary>
        public const uint DeformableRegistrationGridSequence = 0x00640005;

        ///<summary>(0064,0007) VR=UL VM=3 Grid Dimensions</summary>
        public const uint GridDimensions = 0x00640007;

        ///<summary>(0064,0008) VR=FD VM=3 Grid Resolution</summary>
        public const uint GridResolution = 0x00640008;

        ///<summary>(0064,0009) VR=OF VM=1 Vector Grid Data</summary>
        public const uint VectorGridData = 0x00640009;

        ///<summary>(0064,000F) VR=SQ VM=1 Pre Deformation Matrix Registration Sequence</summary>
        public const uint PreDeformationMatrixRegistrationSequence = 0x0064000F;

        ///<summary>(0064,0010) VR=SQ VM=1 Post Deformation Matrix Registration Sequence</summary>
        public const uint PostDeformationMatrixRegistrationSequence = 0x00640010;

        ///<summary>(0066,0001) VR=UL VM=1 Number of Surfaces</summary>
        public const uint NumberOfSurfaces = 0x00660001;

        ///<summary>(0066,0002) VR=SQ VM=1 Surface Sequence</summary>
        public const uint SurfaceSequence = 0x00660002;

        ///<summary>(0066,0003) VR=UL VM=1 Surface Number</summary>
        public const uint SurfaceNumber = 0x00660003;

        ///<summary>(0066,0004) VR=LT VM=1 Surface Comments</summary>
        public const uint SurfaceComments = 0x00660004;

        ///<summary>(0066,0009) VR=CS VM=1 Surface Processing</summary>
        public const uint SurfaceProcessing = 0x00660009;

        ///<summary>(0066,000A) VR=FL VM=1 Surface Processing Ratio</summary>
        public const uint SurfaceProcessingRatio = 0x0066000A;

        ///<summary>(0066,000B) VR=LO VM=1 Surface Processing Description</summary>
        public const uint SurfaceProcessingDescription = 0x0066000B;

        ///<summary>(0066,000C) VR=FL VM=1 Recommended Presentation Opacity</summary>
        public const uint RecommendedPresentationOpacity = 0x0066000C;

        ///<summary>(0066,000D) VR=CS VM=1 Recommended Presentation Type</summary>
        public const uint RecommendedPresentationType = 0x0066000D;

        ///<summary>(0066,000E) VR=CS VM=1 Finite Volume</summary>
        public const uint FiniteVolume = 0x0066000E;

        ///<summary>(0066,0010) VR=CS VM=1 Manifold</summary>
        public const uint Manifold = 0x00660010;

        ///<summary>(0066,0011) VR=SQ VM=1 Surface Points Sequence</summary>
        public const uint SurfacePointsSequence = 0x00660011;

        ///<summary>(0066,0012) VR=SQ VM=1 Surface Points Normals Sequence</summary>
        public const uint SurfacePointsNormalsSequence = 0x00660012;

        ///<summary>(0066,0013) VR=SQ VM=1 Surface Mesh Primitives Sequence</summary>
        public const uint SurfaceMeshPrimitivesSequence = 0x00660013;

        ///<summary>(0066,0015) VR=UL VM=1 Number of Surface Points</summary>
        public const uint NumberOfSurfacePoints = 0x00660015;

        ///<summary>(0066,0016) VR=OF VM=1 Point Coordinates Data</summary>
        public const uint PointCoordinatesData = 0x00660016;

        ///<summary>(0066,0017) VR=FL VM=3 Point Position Accuracy</summary>
        public const uint PointPositionAccuracy = 0x00660017;

        ///<summary>(0066,0018) VR=FL VM=1 Mean Point Distance</summary>
        public const uint MeanPointDistance = 0x00660018;

        ///<summary>(0066,0019) VR=FL VM=1 Maximum Point Distance</summary>
        public const uint MaximumPointDistance = 0x00660019;

        ///<summary>(0066,001A) VR=FL VM=6 Points Bounding Box Coordinates</summary>
        public const uint PointsBoundingBoxCoordinates = 0x0066001A;

        ///<summary>(0066,001B) VR=FL VM=3 Axis of Rotation</summary>
        public const uint AxisOfRotation = 0x0066001B;

        ///<summary>(0066,001C) VR=FL VM=3 Center of Rotation</summary>
        public const uint CenterOfRotation = 0x0066001C;

        ///<summary>(0066,001E) VR=UL VM=1 Number of Vectors</summary>
        public const uint NumberOfVectors = 0x0066001E;

        ///<summary>(0066,001F) VR=US VM=1 Vector Dimensionality</summary>
        public const uint VectorDimensionality = 0x0066001F;

        ///<summary>(0066,0020) VR=FL VM=1-n Vector Accuracy</summary>
        public const uint VectorAccuracy = 0x00660020;

        ///<summary>(0066,0021) VR=OF VM=1 Vector Coordinate Data</summary>
        public const uint VectorCoordinateData = 0x00660021;

        ///<summary>(0066,0022) VR=OD VM=1 Double Point Coordinates Data</summary>
        public const uint DoublePointCoordinatesData = 0x00660022;

        ///<summary>(0066,0023) VR=OW VM=1 Triangle Point Index List (RETIRED)</summary>
        public const uint TrianglePointIndexListRETIRED = 0x00660023;

        ///<summary>(0066,0024) VR=OW VM=1 Edge Point Index List (RETIRED)</summary>
        public const uint EdgePointIndexListRETIRED = 0x00660024;

        ///<summary>(0066,0025) VR=OW VM=1 Vertex Point Index List (RETIRED)</summary>
        public const uint VertexPointIndexListRETIRED = 0x00660025;

        ///<summary>(0066,0026) VR=SQ VM=1 Triangle Strip Sequence</summary>
        public const uint TriangleStripSequence = 0x00660026;

        ///<summary>(0066,0027) VR=SQ VM=1 Triangle Fan Sequence</summary>
        public const uint TriangleFanSequence = 0x00660027;

        ///<summary>(0066,0028) VR=SQ VM=1 Line Sequence</summary>
        public const uint LineSequence = 0x00660028;

        ///<summary>(0066,0029) VR=OW VM=1 Primitive Point Index List (RETIRED)</summary>
        public const uint PrimitivePointIndexListRETIRED = 0x00660029;

        ///<summary>(0066,002A) VR=UL VM=1 Surface Count</summary>
        public const uint SurfaceCount = 0x0066002A;

        ///<summary>(0066,002B) VR=SQ VM=1 Referenced Surface Sequence</summary>
        public const uint ReferencedSurfaceSequence = 0x0066002B;

        ///<summary>(0066,002C) VR=UL VM=1 Referenced Surface Number</summary>
        public const uint ReferencedSurfaceNumber = 0x0066002C;

        ///<summary>(0066,002D) VR=SQ VM=1 Segment Surface Generation Algorithm Identification Sequence</summary>
        public const uint SegmentSurfaceGenerationAlgorithmIdentificationSequence = 0x0066002D;

        ///<summary>(0066,002E) VR=SQ VM=1 Segment Surface Source Instance Sequence</summary>
        public const uint SegmentSurfaceSourceInstanceSequence = 0x0066002E;

        ///<summary>(0066,002F) VR=SQ VM=1 Algorithm Family Code Sequence</summary>
        public const uint AlgorithmFamilyCodeSequence = 0x0066002F;

        ///<summary>(0066,0030) VR=SQ VM=1 Algorithm Name Code Sequence</summary>
        public const uint AlgorithmNameCodeSequence = 0x00660030;

        ///<summary>(0066,0031) VR=LO VM=1 Algorithm Version</summary>
        public const uint AlgorithmVersion = 0x00660031;

        ///<summary>(0066,0032) VR=LT VM=1 Algorithm Parameters</summary>
        public const uint AlgorithmParameters = 0x00660032;

        ///<summary>(0066,0034) VR=SQ VM=1 Facet Sequence</summary>
        public const uint FacetSequence = 0x00660034;

        ///<summary>(0066,0035) VR=SQ VM=1 Surface Processing Algorithm Identification Sequence</summary>
        public const uint SurfaceProcessingAlgorithmIdentificationSequence = 0x00660035;

        ///<summary>(0066,0036) VR=LO VM=1 Algorithm Name</summary>
        public const uint AlgorithmName = 0x00660036;

        ///<summary>(0066,0037) VR=FL VM=1 Recommended Point Radius</summary>
        public const uint RecommendedPointRadius = 0x00660037;

        ///<summary>(0066,0038) VR=FL VM=1 Recommended Line Thickness</summary>
        public const uint RecommendedLineThickness = 0x00660038;

        ///<summary>(0066,0040) VR=OL VM=1 Long Primitive Point Index List</summary>
        public const uint LongPrimitivePointIndexList = 0x00660040;

        ///<summary>(0066,0041) VR=OL VM=1 Long Triangle Point Index List</summary>
        public const uint LongTrianglePointIndexList = 0x00660041;

        ///<summary>(0066,0042) VR=OL VM=1 Long Edge Point Index List</summary>
        public const uint LongEdgePointIndexList = 0x00660042;

        ///<summary>(0066,0043) VR=OL VM=1 Long Vertex Point Index List</summary>
        public const uint LongVertexPointIndexList = 0x00660043;

        ///<summary>(0066,0101) VR=SQ VM=1 Track Set Sequence</summary>
        public const uint TrackSetSequence = 0x00660101;

        ///<summary>(0066,0102) VR=SQ VM=1 Track Sequence</summary>
        public const uint TrackSequence = 0x00660102;

        ///<summary>(0066,0103) VR=OW VM=1 Recommended Display CIELab Value List</summary>
        public const uint RecommendedDisplayCIELabValueList = 0x00660103;

        ///<summary>(0066,0104) VR=SQ VM=1 Tracking Algorithm Identification Sequence</summary>
        public const uint TrackingAlgorithmIdentificationSequence = 0x00660104;

        ///<summary>(0066,0105) VR=UL VM=1 Track Set Number</summary>
        public const uint TrackSetNumber = 0x00660105;

        ///<summary>(0066,0106) VR=LO VM=1 Track Set Label</summary>
        public const uint TrackSetLabel = 0x00660106;

        ///<summary>(0066,0107) VR=UT VM=1 Track Set Description</summary>
        public const uint TrackSetDescription = 0x00660107;

        ///<summary>(0066,0108) VR=SQ VM=1 Track Set Anatomical Type Code Sequence</summary>
        public const uint TrackSetAnatomicalTypeCodeSequence = 0x00660108;

        ///<summary>(0066,0121) VR=SQ VM=1 Measurements Sequence</summary>
        public const uint MeasurementsSequence = 0x00660121;

        ///<summary>(0066,0124) VR=SQ VM=1 Track Set Statistics Sequence</summary>
        public const uint TrackSetStatisticsSequence = 0x00660124;

        ///<summary>(0066,0125) VR=OF VM=1 Floating Point Values</summary>
        public const uint FloatingPointValues = 0x00660125;

        ///<summary>(0066,0129) VR=OL VM=1 Track Point Index List</summary>
        public const uint TrackPointIndexList = 0x00660129;

        ///<summary>(0066,0130) VR=SQ VM=1 Track Statistics Sequence</summary>
        public const uint TrackStatisticsSequence = 0x00660130;

        ///<summary>(0066,0132) VR=SQ VM=1 Measurement Values Sequence</summary>
        public const uint MeasurementValuesSequence = 0x00660132;

        ///<summary>(0066,0133) VR=SQ VM=1 Diffusion Acquisition Code Sequence</summary>
        public const uint DiffusionAcquisitionCodeSequence = 0x00660133;

        ///<summary>(0066,0134) VR=SQ VM=1 Diffusion Model Code Sequence</summary>
        public const uint DiffusionModelCodeSequence = 0x00660134;

        ///<summary>(0068,6210) VR=LO VM=1 Implant Size</summary>
        public const uint ImplantSize = 0x00686210;

        ///<summary>(0068,6221) VR=LO VM=1 Implant Template Version</summary>
        public const uint ImplantTemplateVersion = 0x00686221;

        ///<summary>(0068,6222) VR=SQ VM=1 Replaced Implant Template Sequence</summary>
        public const uint ReplacedImplantTemplateSequence = 0x00686222;

        ///<summary>(0068,6223) VR=CS VM=1 Implant Type</summary>
        public const uint ImplantType = 0x00686223;

        ///<summary>(0068,6224) VR=SQ VM=1 Derivation Implant Template Sequence</summary>
        public const uint DerivationImplantTemplateSequence = 0x00686224;

        ///<summary>(0068,6225) VR=SQ VM=1 Original Implant Template Sequence</summary>
        public const uint OriginalImplantTemplateSequence = 0x00686225;

        ///<summary>(0068,6226) VR=DT VM=1 Effective DateTime</summary>
        public const uint EffectiveDateTime = 0x00686226;

        ///<summary>(0068,6230) VR=SQ VM=1 Implant Target Anatomy Sequence</summary>
        public const uint ImplantTargetAnatomySequence = 0x00686230;

        ///<summary>(0068,6260) VR=SQ VM=1 Information From Manufacturer Sequence</summary>
        public const uint InformationFromManufacturerSequence = 0x00686260;

        ///<summary>(0068,6265) VR=SQ VM=1 Notification From Manufacturer Sequence</summary>
        public const uint NotificationFromManufacturerSequence = 0x00686265;

        ///<summary>(0068,6270) VR=DT VM=1 Information Issue DateTime</summary>
        public const uint InformationIssueDateTime = 0x00686270;

        ///<summary>(0068,6280) VR=ST VM=1 Information Summary</summary>
        public const uint InformationSummary = 0x00686280;

        ///<summary>(0068,62A0) VR=SQ VM=1 Implant Regulatory Disapproval Code Sequence</summary>
        public const uint ImplantRegulatoryDisapprovalCodeSequence = 0x006862A0;

        ///<summary>(0068,62A5) VR=FD VM=1 Overall Template Spatial Tolerance</summary>
        public const uint OverallTemplateSpatialTolerance = 0x006862A5;

        ///<summary>(0068,62C0) VR=SQ VM=1 HPGL Document Sequence</summary>
        public const uint HPGLDocumentSequence = 0x006862C0;

        ///<summary>(0068,62D0) VR=US VM=1 HPGL Document Id</summary>
        public const uint HPGLDocumentId = 0x006862D0;

        ///<summary>(0068,62D5) VR=LO VM=1 HPGL Document Label</summary>
        public const uint HPGLDocumentLabel = 0x006862D5;

        ///<summary>(0068,62E0) VR=SQ VM=1 View Orientation Code Sequence</summary>
        public const uint ViewOrientationCodeSequence = 0x006862E0;

        ///<summary>(0068,62F0) VR=SQ VM=1 View Orientation Modifier Code Sequence</summary>
        public const uint ViewOrientationModifierCodeSequence = 0x006862F0;

        ///<summary>(0068,62F2) VR=FD VM=1 HPGL Document Scaling</summary>
        public const uint HPGLDocumentScaling = 0x006862F2;

        ///<summary>(0068,6300) VR=OB VM=1 HPGL Document</summary>
        public const uint HPGLDocument = 0x00686300;

        ///<summary>(0068,6310) VR=US VM=1 HPGL Contour Pen Number</summary>
        public const uint HPGLContourPenNumber = 0x00686310;

        ///<summary>(0068,6320) VR=SQ VM=1 HPGL Pen Sequence</summary>
        public const uint HPGLPenSequence = 0x00686320;

        ///<summary>(0068,6330) VR=US VM=1 HPGL Pen Number</summary>
        public const uint HPGLPenNumber = 0x00686330;

        ///<summary>(0068,6340) VR=LO VM=1 HPGL Pen Label</summary>
        public const uint HPGLPenLabel = 0x00686340;

        ///<summary>(0068,6345) VR=ST VM=1 HPGL Pen Description</summary>
        public const uint HPGLPenDescription = 0x00686345;

        ///<summary>(0068,6346) VR=FD VM=2 Recommended Rotation Point</summary>
        public const uint RecommendedRotationPoint = 0x00686346;

        ///<summary>(0068,6347) VR=FD VM=4 Bounding Rectangle</summary>
        public const uint BoundingRectangle = 0x00686347;

        ///<summary>(0068,6350) VR=US VM=1-n Implant Template 3D Model Surface Number</summary>
        public const uint ImplantTemplate3DModelSurfaceNumber = 0x00686350;

        ///<summary>(0068,6360) VR=SQ VM=1 Surface Model Description Sequence</summary>
        public const uint SurfaceModelDescriptionSequence = 0x00686360;

        ///<summary>(0068,6380) VR=LO VM=1 Surface Model Label</summary>
        public const uint SurfaceModelLabel = 0x00686380;

        ///<summary>(0068,6390) VR=FD VM=1 Surface Model Scaling Factor</summary>
        public const uint SurfaceModelScalingFactor = 0x00686390;

        ///<summary>(0068,63A0) VR=SQ VM=1 Materials Code Sequence</summary>
        public const uint MaterialsCodeSequence = 0x006863A0;

        ///<summary>(0068,63A4) VR=SQ VM=1 Coating Materials Code Sequence</summary>
        public const uint CoatingMaterialsCodeSequence = 0x006863A4;

        ///<summary>(0068,63A8) VR=SQ VM=1 Implant Type Code Sequence</summary>
        public const uint ImplantTypeCodeSequence = 0x006863A8;

        ///<summary>(0068,63AC) VR=SQ VM=1 Fixation Method Code Sequence</summary>
        public const uint FixationMethodCodeSequence = 0x006863AC;

        ///<summary>(0068,63B0) VR=SQ VM=1 Mating Feature Sets Sequence</summary>
        public const uint MatingFeatureSetsSequence = 0x006863B0;

        ///<summary>(0068,63C0) VR=US VM=1 Mating Feature Set Id</summary>
        public const uint MatingFeatureSetId = 0x006863C0;

        ///<summary>(0068,63D0) VR=LO VM=1 Mating Feature Set Label</summary>
        public const uint MatingFeatureSetLabel = 0x006863D0;

        ///<summary>(0068,63E0) VR=SQ VM=1 Mating Feature Sequence</summary>
        public const uint MatingFeatureSequence = 0x006863E0;

        ///<summary>(0068,63F0) VR=US VM=1 Mating Feature Id</summary>
        public const uint MatingFeatureId = 0x006863F0;

        ///<summary>(0068,6400) VR=SQ VM=1 Mating Feature Degree of Freedom Sequence</summary>
        public const uint MatingFeatureDegreeOfFreedomSequence = 0x00686400;

        ///<summary>(0068,6410) VR=US VM=1 Degree of Freedom Id</summary>
        public const uint DegreeOfFreedomId = 0x00686410;

        ///<summary>(0068,6420) VR=CS VM=1 Degree of Freedom Type</summary>
        public const uint DegreeOfFreedomType = 0x00686420;

        ///<summary>(0068,6430) VR=SQ VM=1 2D Mating Feature Coordinates Sequence</summary>
        public const uint TwoDMatingFeatureCoordinatesSequence = 0x00686430;

        ///<summary>(0068,6440) VR=US VM=1 Referenced HPGL Document Id</summary>
        public const uint ReferencedHPGLDocumentId = 0x00686440;

        ///<summary>(0068,6450) VR=FD VM=2 2D Mating Point</summary>
        public const uint TwoDMatingPoint = 0x00686450;

        ///<summary>(0068,6460) VR=FD VM=4 2D Mating Axes</summary>
        public const uint TwoDMatingAxes = 0x00686460;

        ///<summary>(0068,6470) VR=SQ VM=1 2D Degree of Freedom Sequence</summary>
        public const uint TwoDDegreeOfFreedomSequence = 0x00686470;

        ///<summary>(0068,6490) VR=FD VM=3 3D Degree of Freedom Axis</summary>
        public const uint ThreeDDegreeOfFreedomAxis = 0x00686490;

        ///<summary>(0068,64A0) VR=FD VM=2 Range of Freedom</summary>
        public const uint RangeOfFreedom = 0x006864A0;

        ///<summary>(0068,64C0) VR=FD VM=3 3D Mating Point</summary>
        public const uint ThreeDMatingPoint = 0x006864C0;

        ///<summary>(0068,64D0) VR=FD VM=9 3D Mating Axes</summary>
        public const uint ThreeDMatingAxes = 0x006864D0;

        ///<summary>(0068,64F0) VR=FD VM=3 2D Degree of Freedom Axis</summary>
        public const uint TwoDDegreeOfFreedomAxis = 0x006864F0;

        ///<summary>(0068,6500) VR=SQ VM=1 Planning Landmark Point Sequence</summary>
        public const uint PlanningLandmarkPointSequence = 0x00686500;

        ///<summary>(0068,6510) VR=SQ VM=1 Planning Landmark Line Sequence</summary>
        public const uint PlanningLandmarkLineSequence = 0x00686510;

        ///<summary>(0068,6520) VR=SQ VM=1 Planning Landmark Plane Sequence</summary>
        public const uint PlanningLandmarkPlaneSequence = 0x00686520;

        ///<summary>(0068,6530) VR=US VM=1 Planning Landmark Id</summary>
        public const uint PlanningLandmarkId = 0x00686530;

        ///<summary>(0068,6540) VR=LO VM=1 Planning Landmark Description</summary>
        public const uint PlanningLandmarkDescription = 0x00686540;

        ///<summary>(0068,6545) VR=SQ VM=1 Planning Landmark Identification Code Sequence</summary>
        public const uint PlanningLandmarkIdentificationCodeSequence = 0x00686545;

        ///<summary>(0068,6550) VR=SQ VM=1 2D Point Coordinates Sequence</summary>
        public const uint TwoDPointCoordinatesSequence = 0x00686550;

        ///<summary>(0068,6560) VR=FD VM=2 2D Point Coordinates</summary>
        public const uint TwoDPointCoordinates = 0x00686560;

        ///<summary>(0068,6590) VR=FD VM=3 3D Point Coordinates</summary>
        public const uint ThreeDPointCoordinates = 0x00686590;

        ///<summary>(0068,65A0) VR=SQ VM=1 2D Line Coordinates Sequence</summary>
        public const uint TwoDLineCoordinatesSequence = 0x006865A0;

        ///<summary>(0068,65B0) VR=FD VM=4 2D Line Coordinates</summary>
        public const uint TwoDLineCoordinates = 0x006865B0;

        ///<summary>(0068,65D0) VR=FD VM=6 3D Line Coordinates</summary>
        public const uint ThreeDLineCoordinates = 0x006865D0;

        ///<summary>(0068,65E0) VR=SQ VM=1 2D Plane Coordinates Sequence</summary>
        public const uint TwoDPlaneCoordinatesSequence = 0x006865E0;

        ///<summary>(0068,65F0) VR=FD VM=4 2D Plane Intersection</summary>
        public const uint TwoDPlaneIntersection = 0x006865F0;

        ///<summary>(0068,6610) VR=FD VM=3 3D Plane Origin</summary>
        public const uint ThreeDPlaneOrigin = 0x00686610;

        ///<summary>(0068,6620) VR=FD VM=3 3D Plane Normal</summary>
        public const uint ThreeDPlaneNormal = 0x00686620;

        ///<summary>(0068,7001) VR=CS VM=1 Model Modification</summary>
        public const uint ModelModification = 0x00687001;

        ///<summary>(0068,7002) VR=CS VM=1 Model Mirroring</summary>
        public const uint ModelMirroring = 0x00687002;

        ///<summary>(0068,7003) VR=SQ VM=1 Model Usage Code Sequence</summary>
        public const uint ModelUsageCodeSequence = 0x00687003;

        ///<summary>(0068,7004) VR=UI VM=1 Model Group Uid</summary>
        public const uint ModelGroupUid = 0x00687004;

        ///<summary>(0068,7005) VR=UR VM=1 Relative URI Reference Within Encapsulated Document</summary>
        public const uint RelativeURIReferenceWithinEncapsulatedDocument = 0x00687005;

        ///<summary>(006A,0001) VR=CS VM=1 Annotation Coordinate Type</summary>
        public const uint AnnotationCoordinateType = 0x006A0001;

        ///<summary>(006A,0002) VR=SQ VM=1 Annotation Group Sequence</summary>
        public const uint AnnotationGroupSequence = 0x006A0002;

        ///<summary>(006A,0003) VR=UI VM=1 Annotation Group Uid</summary>
        public const uint AnnotationGroupUid = 0x006A0003;

        ///<summary>(006A,0005) VR=LO VM=1 Annotation Group Label</summary>
        public const uint AnnotationGroupLabel = 0x006A0005;

        ///<summary>(006A,0006) VR=UT VM=1 Annotation Group Description</summary>
        public const uint AnnotationGroupDescription = 0x006A0006;

        ///<summary>(006A,0007) VR=CS VM=1 Annotation Group Generation Type</summary>
        public const uint AnnotationGroupGenerationType = 0x006A0007;

        ///<summary>(006A,0008) VR=SQ VM=1 Annotation Group Algorithm Identification Sequence</summary>
        public const uint AnnotationGroupAlgorithmIdentificationSequence = 0x006A0008;

        ///<summary>(006A,0009) VR=SQ VM=1 Annotation Property Category Code Sequence</summary>
        public const uint AnnotationPropertyCategoryCodeSequence = 0x006A0009;

        ///<summary>(006A,000A) VR=SQ VM=1 Annotation Property Type Code Sequence</summary>
        public const uint AnnotationPropertyTypeCodeSequence = 0x006A000A;

        ///<summary>(006A,000B) VR=SQ VM=1 Annotation Property Type Modifier Code Sequence</summary>
        public const uint AnnotationPropertyTypeModifierCodeSequence = 0x006A000B;

        ///<summary>(006A,000C) VR=UL VM=1 Number of Annotations</summary>
        public const uint NumberOfAnnotations = 0x006A000C;

        ///<summary>(006A,000D) VR=CS VM=1 Annotation Applies to All Optical Paths</summary>
        public const uint AnnotationAppliesToAllOpticalPaths = 0x006A000D;

        ///<summary>(006A,000E) VR=SH VM=1-n Referenced Optical Path Identifier</summary>
        public const uint ReferencedOpticalPathIdentifier = 0x006A000E;

        ///<summary>(006A,000F) VR=CS VM=1 Annotation Applies to All Z Planes</summary>
        public const uint AnnotationAppliesToAllZPlanes = 0x006A000F;

        ///<summary>(006A,0010) VR=FD VM=1-n Common Z Coordinate Value</summary>
        public const uint CommonZCoordinateValue = 0x006A0010;

        ///<summary>(006A,0011) VR=OL VM=1 Annotation Index List</summary>
        public const uint AnnotationIndexList = 0x006A0011;

        ///<summary>(0070,0001) VR=SQ VM=1 Graphic Annotation Sequence</summary>
        public const uint GraphicAnnotationSequence = 0x00700001;

        ///<summary>(0070,0002) VR=CS VM=1 Graphic Layer</summary>
        public const uint GraphicLayer = 0x00700002;

        ///<summary>(0070,0003) VR=CS VM=1 Bounding Box Annotation Units</summary>
        public const uint BoundingBoxAnnotationUnits = 0x00700003;

        ///<summary>(0070,0004) VR=CS VM=1 Anchor Point Annotation Units</summary>
        public const uint AnchorPointAnnotationUnits = 0x00700004;

        ///<summary>(0070,0005) VR=CS VM=1 Graphic Annotation Units</summary>
        public const uint GraphicAnnotationUnits = 0x00700005;

        ///<summary>(0070,0006) VR=ST VM=1 Unformatted Text Value</summary>
        public const uint UnformattedTextValue = 0x00700006;

        ///<summary>(0070,0008) VR=SQ VM=1 Text Object Sequence</summary>
        public const uint TextObjectSequence = 0x00700008;

        ///<summary>(0070,0009) VR=SQ VM=1 Graphic Object Sequence</summary>
        public const uint GraphicObjectSequence = 0x00700009;

        ///<summary>(0070,0010) VR=FL VM=2 Bounding Box Top Left Hand Corner</summary>
        public const uint BoundingBoxTopLeftHandCorner = 0x00700010;

        ///<summary>(0070,0011) VR=FL VM=2 Bounding Box Bottom Right Hand Corner</summary>
        public const uint BoundingBoxBottomRightHandCorner = 0x00700011;

        ///<summary>(0070,0012) VR=CS VM=1 Bounding Box Text Horizontal Justification</summary>
        public const uint BoundingBoxTextHorizontalJustification = 0x00700012;

        ///<summary>(0070,0014) VR=FL VM=2 Anchor Point</summary>
        public const uint AnchorPoint = 0x00700014;

        ///<summary>(0070,0015) VR=CS VM=1 Anchor Point Visibility</summary>
        public const uint AnchorPointVisibility = 0x00700015;

        ///<summary>(0070,0020) VR=US VM=1 Graphic Dimensions</summary>
        public const uint GraphicDimensions = 0x00700020;

        ///<summary>(0070,0021) VR=US VM=1 Number of Graphic Points</summary>
        public const uint NumberOfGraphicPoints = 0x00700021;

        ///<summary>(0070,0022) VR=FL VM=2-n Graphic Data</summary>
        public const uint GraphicData = 0x00700022;

        ///<summary>(0070,0023) VR=CS VM=1 Graphic Type</summary>
        public const uint GraphicType = 0x00700023;

        ///<summary>(0070,0024) VR=CS VM=1 Graphic Filled</summary>
        public const uint GraphicFilled = 0x00700024;

        ///<summary>(0070,0040) VR=IS VM=1 Image Rotation (Retired) (RETIRED)</summary>
        public const uint ImageRotationRetiredRETIRED = 0x00700040;

        ///<summary>(0070,0041) VR=CS VM=1 Image Horizontal Flip</summary>
        public const uint ImageHorizontalFlip = 0x00700041;

        ///<summary>(0070,0042) VR=US VM=1 Image Rotation</summary>
        public const uint ImageRotation = 0x00700042;

        ///<summary>(0070,0050) VR=US VM=2 Displayed Area Top Left Hand Corner (Trial) (RETIRED)</summary>
        public const uint DisplayedAreaTopLeftHandCornerTrialRETIRED = 0x00700050;

        ///<summary>(0070,0051) VR=US VM=2 Displayed Area Bottom Right Hand Corner (Trial) (RETIRED)</summary>
        public const uint DisplayedAreaBottomRightHandCornerTrialRETIRED = 0x00700051;

        ///<summary>(0070,0052) VR=SL VM=2 Displayed Area Top Left Hand Corner</summary>
        public const uint DisplayedAreaTopLeftHandCorner = 0x00700052;

        ///<summary>(0070,0053) VR=SL VM=2 Displayed Area Bottom Right Hand Corner</summary>
        public const uint DisplayedAreaBottomRightHandCorner = 0x00700053;

        ///<summary>(0070,005A) VR=SQ VM=1 Displayed Area Selection Sequence</summary>
        public const uint DisplayedAreaSelectionSequence = 0x0070005A;

        ///<summary>(0070,0060) VR=SQ VM=1 Graphic Layer Sequence</summary>
        public const uint GraphicLayerSequence = 0x00700060;

        ///<summary>(0070,0062) VR=IS VM=1 Graphic Layer Order</summary>
        public const uint GraphicLayerOrder = 0x00700062;

        ///<summary>(0070,0066) VR=US VM=1 Graphic Layer Recommended Display Grayscale Value</summary>
        public const uint GraphicLayerRecommendedDisplayGrayscaleValue = 0x00700066;

        ///<summary>(0070,0067) VR=US VM=3 Graphic Layer Recommended Display RGB Value (RETIRED)</summary>
        public const uint GraphicLayerRecommendedDisplayRGBValueRETIRED = 0x00700067;

        ///<summary>(0070,0068) VR=LO VM=1 Graphic Layer Description</summary>
        public const uint GraphicLayerDescription = 0x00700068;

        ///<summary>(0070,0080) VR=CS VM=1 Content Label</summary>
        public const uint ContentLabel = 0x00700080;

        ///<summary>(0070,0081) VR=LO VM=1 Content Description</summary>
        public const uint ContentDescription = 0x00700081;

        ///<summary>(0070,0082) VR=DA VM=1 Presentation Creation Date</summary>
        public const uint PresentationCreationDate = 0x00700082;

        ///<summary>(0070,0083) VR=TM VM=1 Presentation Creation Time</summary>
        public const uint PresentationCreationTime = 0x00700083;

        ///<summary>(0070,0084) VR=PN VM=1 Content Creator's Name</summary>
        public const uint ContentCreatorName = 0x00700084;

        ///<summary>(0070,0086) VR=SQ VM=1 Content Creator's Identification Code Sequence</summary>
        public const uint ContentCreatorIdentificationCodeSequence = 0x00700086;

        ///<summary>(0070,0087) VR=SQ VM=1 Alternate Content Description Sequence</summary>
        public const uint AlternateContentDescriptionSequence = 0x00700087;

        ///<summary>(0070,0100) VR=CS VM=1 Presentation Size Mode</summary>
        public const uint PresentationSizeMode = 0x00700100;

        ///<summary>(0070,0101) VR=DS VM=2 Presentation Pixel Spacing</summary>
        public const uint PresentationPixelSpacing = 0x00700101;

        ///<summary>(0070,0102) VR=IS VM=2 Presentation Pixel Aspect Ratio</summary>
        public const uint PresentationPixelAspectRatio = 0x00700102;

        ///<summary>(0070,0103) VR=FL VM=1 Presentation Pixel Magnification Ratio</summary>
        public const uint PresentationPixelMagnificationRatio = 0x00700103;

        ///<summary>(0070,0207) VR=LO VM=1 Graphic Group Label</summary>
        public const uint GraphicGroupLabel = 0x00700207;

        ///<summary>(0070,0208) VR=ST VM=1 Graphic Group Description</summary>
        public const uint GraphicGroupDescription = 0x00700208;

        ///<summary>(0070,0209) VR=SQ VM=1 Compound Graphic Sequence</summary>
        public const uint CompoundGraphicSequence = 0x00700209;

        ///<summary>(0070,0226) VR=UL VM=1 Compound Graphic Instance Id</summary>
        public const uint CompoundGraphicInstanceId = 0x00700226;

        ///<summary>(0070,0227) VR=LO VM=1 Font Name</summary>
        public const uint FontName = 0x00700227;

        ///<summary>(0070,0228) VR=CS VM=1 Font Name Type</summary>
        public const uint FontNameType = 0x00700228;

        ///<summary>(0070,0229) VR=LO VM=1 CSS Font Name</summary>
        public const uint CSSFontName = 0x00700229;

        ///<summary>(0070,0230) VR=FD VM=1 Rotation Angle</summary>
        public const uint RotationAngle = 0x00700230;

        ///<summary>(0070,0231) VR=SQ VM=1 Text Style Sequence</summary>
        public const uint TextStyleSequence = 0x00700231;

        ///<summary>(0070,0232) VR=SQ VM=1 Line Style Sequence</summary>
        public const uint LineStyleSequence = 0x00700232;

        ///<summary>(0070,0233) VR=SQ VM=1 Fill Style Sequence</summary>
        public const uint FillStyleSequence = 0x00700233;

        ///<summary>(0070,0234) VR=SQ VM=1 Graphic Group Sequence</summary>
        public const uint GraphicGroupSequence = 0x00700234;

        ///<summary>(0070,0241) VR=US VM=3 Text Color CIELab Value</summary>
        public const uint TextColorCIELabValue = 0x00700241;

        ///<summary>(0070,0242) VR=CS VM=1 Horizontal Alignment</summary>
        public const uint HorizontalAlignment = 0x00700242;

        ///<summary>(0070,0243) VR=CS VM=1 Vertical Alignment</summary>
        public const uint VerticalAlignment = 0x00700243;

        ///<summary>(0070,0244) VR=CS VM=1 Shadow Style</summary>
        public const uint ShadowStyle = 0x00700244;

        ///<summary>(0070,0245) VR=FL VM=1 Shadow Offset X</summary>
        public const uint ShadowOffsetX = 0x00700245;

        ///<summary>(0070,0246) VR=FL VM=1 Shadow Offset Y</summary>
        public const uint ShadowOffsetY = 0x00700246;

        ///<summary>(0070,0247) VR=US VM=3 Shadow Color CIELab Value</summary>
        public const uint ShadowColorCIELabValue = 0x00700247;

        ///<summary>(0070,0248) VR=CS VM=1 Underlined</summary>
        public const uint Underlined = 0x00700248;

        ///<summary>(0070,0249) VR=CS VM=1 Bold</summary>
        public const uint Bold = 0x00700249;

        ///<summary>(0070,0250) VR=CS VM=1 Italic</summary>
        public const uint Italic = 0x00700250;

        ///<summary>(0070,0251) VR=US VM=3 Pattern On Color CIELab Value</summary>
        public const uint PatternOnColorCIELabValue = 0x00700251;

        ///<summary>(0070,0252) VR=US VM=3 Pattern Off Color CIELab Value</summary>
        public const uint PatternOffColorCIELabValue = 0x00700252;

        ///<summary>(0070,0253) VR=FL VM=1 Line Thickness</summary>
        public const uint LineThickness = 0x00700253;

        ///<summary>(0070,0254) VR=CS VM=1 Line Dashing Style</summary>
        public const uint LineDashingStyle = 0x00700254;

        ///<summary>(0070,0255) VR=UL VM=1 Line Pattern</summary>
        public const uint LinePattern = 0x00700255;

        ///<summary>(0070,0256) VR=OB VM=1 Fill Pattern</summary>
        public const uint FillPattern = 0x00700256;

        ///<summary>(0070,0257) VR=CS VM=1 Fill Mode</summary>
        public const uint FillMode = 0x00700257;

        ///<summary>(0070,0258) VR=FL VM=1 Shadow Opacity</summary>
        public const uint ShadowOpacity = 0x00700258;

        ///<summary>(0070,0261) VR=FL VM=1 Gap Length</summary>
        public const uint GapLength = 0x00700261;

        ///<summary>(0070,0262) VR=FL VM=1 Diameter of Visibility</summary>
        public const uint DiameterOfVisibility = 0x00700262;

        ///<summary>(0070,0273) VR=FL VM=2 Rotation Point</summary>
        public const uint RotationPoint = 0x00700273;

        ///<summary>(0070,0274) VR=CS VM=1 Tick Alignment</summary>
        public const uint TickAlignment = 0x00700274;

        ///<summary>(0070,0278) VR=CS VM=1 Show Tick Label</summary>
        public const uint ShowTickLabel = 0x00700278;

        ///<summary>(0070,0279) VR=CS VM=1 Tick Label Alignment</summary>
        public const uint TickLabelAlignment = 0x00700279;

        ///<summary>(0070,0282) VR=CS VM=1 Compound Graphic Units</summary>
        public const uint CompoundGraphicUnits = 0x00700282;

        ///<summary>(0070,0284) VR=FL VM=1 Pattern On Opacity</summary>
        public const uint PatternOnOpacity = 0x00700284;

        ///<summary>(0070,0285) VR=FL VM=1 Pattern Off Opacity</summary>
        public const uint PatternOffOpacity = 0x00700285;

        ///<summary>(0070,0287) VR=SQ VM=1 Major Ticks Sequence</summary>
        public const uint MajorTicksSequence = 0x00700287;

        ///<summary>(0070,0288) VR=FL VM=1 Tick Position</summary>
        public const uint TickPosition = 0x00700288;

        ///<summary>(0070,0289) VR=SH VM=1 Tick Label</summary>
        public const uint TickLabel = 0x00700289;

        ///<summary>(0070,0294) VR=CS VM=1 Compound Graphic Type</summary>
        public const uint CompoundGraphicType = 0x00700294;

        ///<summary>(0070,0295) VR=UL VM=1 Graphic Group Id</summary>
        public const uint GraphicGroupId = 0x00700295;

        ///<summary>(0070,0306) VR=CS VM=1 Shape Type</summary>
        public const uint ShapeType = 0x00700306;

        ///<summary>(0070,0308) VR=SQ VM=1 Registration Sequence</summary>
        public const uint RegistrationSequence = 0x00700308;

        ///<summary>(0070,0309) VR=SQ VM=1 Matrix Registration Sequence</summary>
        public const uint MatrixRegistrationSequence = 0x00700309;

        ///<summary>(0070,030A) VR=SQ VM=1 Matrix Sequence</summary>
        public const uint MatrixSequence = 0x0070030A;

        ///<summary>(0070,030B) VR=FD VM=16 Frame of Reference to Displayed Coordinate System Transformation Matrix</summary>
        public const uint FrameOfReferenceToDisplayedCoordinateSystemTransformationMatrix = 0x0070030B;

        ///<summary>(0070,030C) VR=CS VM=1 Frame of Reference Transformation Matrix Type</summary>
        public const uint FrameOfReferenceTransformationMatrixType = 0x0070030C;

        ///<summary>(0070,030D) VR=SQ VM=1 Registration Type Code Sequence</summary>
        public const uint RegistrationTypeCodeSequence = 0x0070030D;

        ///<summary>(0070,030F) VR=ST VM=1 Fiducial Description</summary>
        public const uint FiducialDescription = 0x0070030F;

        ///<summary>(0070,0310) VR=SH VM=1 Fiducial Identifier</summary>
        public const uint FiducialIdentifier = 0x00700310;

        ///<summary>(0070,0311) VR=SQ VM=1 Fiducial Identifier Code Sequence</summary>
        public const uint FiducialIdentifierCodeSequence = 0x00700311;

        ///<summary>(0070,0312) VR=FD VM=1 Contour Uncertainty Radius</summary>
        public const uint ContourUncertaintyRadius = 0x00700312;

        ///<summary>(0070,0314) VR=SQ VM=1 Used Fiducials Sequence</summary>
        public const uint UsedFiducialsSequence = 0x00700314;

        ///<summary>(0070,0318) VR=SQ VM=1 Graphic Coordinates Data Sequence</summary>
        public const uint GraphicCoordinatesDataSequence = 0x00700318;

        ///<summary>(0070,031A) VR=UI VM=1 Fiducial Uid</summary>
        public const uint FiducialUid = 0x0070031A;

        ///<summary>(0070,031B) VR=UI VM=1 Referenced Fiducial Uid</summary>
        public const uint ReferencedFiducialUid = 0x0070031B;

        ///<summary>(0070,031C) VR=SQ VM=1 Fiducial Set Sequence</summary>
        public const uint FiducialSetSequence = 0x0070031C;

        ///<summary>(0070,031E) VR=SQ VM=1 Fiducial Sequence</summary>
        public const uint FiducialSequence = 0x0070031E;

        ///<summary>(0070,031F) VR=SQ VM=1 Fiducials Property Category Code Sequence</summary>
        public const uint FiducialsPropertyCategoryCodeSequence = 0x0070031F;

        ///<summary>(0070,0401) VR=US VM=3 Graphic Layer Recommended Display CIELab Value</summary>
        public const uint GraphicLayerRecommendedDisplayCIELabValue = 0x00700401;

        ///<summary>(0070,0402) VR=SQ VM=1 Blending Sequence</summary>
        public const uint BlendingSequence = 0x00700402;

        ///<summary>(0070,0403) VR=FL VM=1 Relative Opacity</summary>
        public const uint RelativeOpacity = 0x00700403;

        ///<summary>(0070,0404) VR=SQ VM=1 Referenced Spatial Registration Sequence</summary>
        public const uint ReferencedSpatialRegistrationSequence = 0x00700404;

        ///<summary>(0070,0405) VR=CS VM=1 Blending Position</summary>
        public const uint BlendingPosition = 0x00700405;

        ///<summary>(0070,1101) VR=UI VM=1 Presentation Display Collection Uid</summary>
        public const uint PresentationDisplayCollectionUid = 0x00701101;

        ///<summary>(0070,1102) VR=UI VM=1 Presentation Sequence Collection Uid</summary>
        public const uint PresentationSequenceCollectionUid = 0x00701102;

        ///<summary>(0070,1103) VR=US VM=1 Presentation Sequence Position Index</summary>
        public const uint PresentationSequencePositionIndex = 0x00701103;

        ///<summary>(0070,1104) VR=SQ VM=1 Rendered Image Reference Sequence</summary>
        public const uint RenderedImageReferenceSequence = 0x00701104;

        ///<summary>(0070,1201) VR=SQ VM=1 Volumetric Presentation State Input Sequence</summary>
        public const uint VolumetricPresentationStateInputSequence = 0x00701201;

        ///<summary>(0070,1202) VR=CS VM=1 Presentation Input Type</summary>
        public const uint PresentationInputType = 0x00701202;

        ///<summary>(0070,1203) VR=US VM=1 Input Sequence Position Index</summary>
        public const uint InputSequencePositionIndex = 0x00701203;

        ///<summary>(0070,1204) VR=CS VM=1 Crop</summary>
        public const uint Crop = 0x00701204;

        ///<summary>(0070,1205) VR=US VM=1-n Cropping Specification Index</summary>
        public const uint CroppingSpecificationIndex = 0x00701205;

        ///<summary>(0070,1206) VR=CS VM=1 Compositing Method (RETIRED)</summary>
        public const uint CompositingMethodRETIRED = 0x00701206;

        ///<summary>(0070,1207) VR=US VM=1 Volumetric Presentation Input Number</summary>
        public const uint VolumetricPresentationInputNumber = 0x00701207;

        ///<summary>(0070,1208) VR=CS VM=1 Image Volume Geometry</summary>
        public const uint ImageVolumeGeometry = 0x00701208;

        ///<summary>(0070,1209) VR=UI VM=1 Volumetric Presentation Input Set Uid</summary>
        public const uint VolumetricPresentationInputSetUid = 0x00701209;

        ///<summary>(0070,120A) VR=SQ VM=1 Volumetric Presentation Input Set Sequence</summary>
        public const uint VolumetricPresentationInputSetSequence = 0x0070120A;

        ///<summary>(0070,120B) VR=CS VM=1 Global Crop</summary>
        public const uint GlobalCrop = 0x0070120B;

        ///<summary>(0070,120C) VR=US VM=1-n Global Cropping Specification Index</summary>
        public const uint GlobalCroppingSpecificationIndex = 0x0070120C;

        ///<summary>(0070,120D) VR=CS VM=1 Rendering Method</summary>
        public const uint RenderingMethod = 0x0070120D;

        ///<summary>(0070,1301) VR=SQ VM=1 Volume Cropping Sequence</summary>
        public const uint VolumeCroppingSequence = 0x00701301;

        ///<summary>(0070,1302) VR=CS VM=1 Volume Cropping Method</summary>
        public const uint VolumeCroppingMethod = 0x00701302;

        ///<summary>(0070,1303) VR=FD VM=6 Bounding Box Crop</summary>
        public const uint BoundingBoxCrop = 0x00701303;

        ///<summary>(0070,1304) VR=SQ VM=1 Oblique Cropping Plane Sequence</summary>
        public const uint ObliqueCroppingPlaneSequence = 0x00701304;

        ///<summary>(0070,1305) VR=FD VM=4 Plane</summary>
        public const uint Plane = 0x00701305;

        ///<summary>(0070,1306) VR=FD VM=3 Plane Normal</summary>
        public const uint PlaneNormal = 0x00701306;

        ///<summary>(0070,1309) VR=US VM=1 Cropping Specification Number</summary>
        public const uint CroppingSpecificationNumber = 0x00701309;

        ///<summary>(0070,1501) VR=CS VM=1 Multi-Planar Reconstruction Style</summary>
        public const uint MultiPlanarReconstructionStyle = 0x00701501;

        ///<summary>(0070,1502) VR=CS VM=1 MPR Thickness Type</summary>
        public const uint MPRThicknessType = 0x00701502;

        ///<summary>(0070,1503) VR=FD VM=1 MPR Slab Thickness</summary>
        public const uint MPRSlabThickness = 0x00701503;

        ///<summary>(0070,1505) VR=FD VM=3 MPR Top Left Hand Corner</summary>
        public const uint MPRTopLeftHandCorner = 0x00701505;

        ///<summary>(0070,1507) VR=FD VM=3 MPR View Width Direction</summary>
        public const uint MPRViewWidthDirection = 0x00701507;

        ///<summary>(0070,1508) VR=FD VM=1 MPR View Width</summary>
        public const uint MPRViewWidth = 0x00701508;

        ///<summary>(0070,150C) VR=UL VM=1 Number of Volumetric Curve Points</summary>
        public const uint NumberOfVolumetricCurvePoints = 0x0070150C;

        ///<summary>(0070,150D) VR=OD VM=1 Volumetric Curve Points</summary>
        public const uint VolumetricCurvePoints = 0x0070150D;

        ///<summary>(0070,1511) VR=FD VM=3 MPR View Height Direction</summary>
        public const uint MPRViewHeightDirection = 0x00701511;

        ///<summary>(0070,1512) VR=FD VM=1 MPR View Height</summary>
        public const uint MPRViewHeight = 0x00701512;

        ///<summary>(0070,1602) VR=CS VM=1 Render Projection</summary>
        public const uint RenderProjection = 0x00701602;

        ///<summary>(0070,1603) VR=FD VM=3 Viewpoint Position</summary>
        public const uint ViewpointPosition = 0x00701603;

        ///<summary>(0070,1604) VR=FD VM=3 Viewpoint LookAt Point</summary>
        public const uint ViewpointLookAtPoint = 0x00701604;

        ///<summary>(0070,1605) VR=FD VM=3 Viewpoint Up Direction</summary>
        public const uint ViewpointUpDirection = 0x00701605;

        ///<summary>(0070,1606) VR=FD VM=6 Render Field of View</summary>
        public const uint RenderFieldOfView = 0x00701606;

        ///<summary>(0070,1607) VR=FD VM=1 Sampling Step Size</summary>
        public const uint SamplingStepSize = 0x00701607;

        ///<summary>(0070,1701) VR=CS VM=1 Shading Style</summary>
        public const uint ShadingStyle = 0x00701701;

        ///<summary>(0070,1702) VR=FD VM=1 Ambient Reflection Intensity</summary>
        public const uint AmbientReflectionIntensity = 0x00701702;

        ///<summary>(0070,1703) VR=FD VM=3 Light Direction</summary>
        public const uint LightDirection = 0x00701703;

        ///<summary>(0070,1704) VR=FD VM=1 Diffuse Reflection Intensity</summary>
        public const uint DiffuseReflectionIntensity = 0x00701704;

        ///<summary>(0070,1705) VR=FD VM=1 Specular Reflection Intensity</summary>
        public const uint SpecularReflectionIntensity = 0x00701705;

        ///<summary>(0070,1706) VR=FD VM=1 Shininess</summary>
        public const uint Shininess = 0x00701706;

        ///<summary>(0070,1801) VR=SQ VM=1 Presentation State Classification Component Sequence</summary>
        public const uint PresentationStateClassificationComponentSequence = 0x00701801;

        ///<summary>(0070,1802) VR=CS VM=1 Component Type</summary>
        public const uint ComponentType = 0x00701802;

        ///<summary>(0070,1803) VR=SQ VM=1 Component Input Sequence</summary>
        public const uint ComponentInputSequence = 0x00701803;

        ///<summary>(0070,1804) VR=US VM=1 Volumetric Presentation Input Index</summary>
        public const uint VolumetricPresentationInputIndex = 0x00701804;

        ///<summary>(0070,1805) VR=SQ VM=1 Presentation State Compositor Component Sequence</summary>
        public const uint PresentationStateCompositorComponentSequence = 0x00701805;

        ///<summary>(0070,1806) VR=SQ VM=1 Weighting Transfer Function Sequence</summary>
        public const uint WeightingTransferFunctionSequence = 0x00701806;

        ///<summary>(0070,1807) VR=US VM=3 Weighting Lookup Table Descriptor</summary>
        public const uint WeightingLookupTableDescriptor = 0x00701807;

        ///<summary>(0070,1808) VR=OB VM=1 Weighting Lookup Table Data</summary>
        public const uint WeightingLookupTableData = 0x00701808;

        ///<summary>(0070,1901) VR=SQ VM=1 Volumetric Annotation Sequence</summary>
        public const uint VolumetricAnnotationSequence = 0x00701901;

        ///<summary>(0070,1903) VR=SQ VM=1 Referenced Structured Context Sequence</summary>
        public const uint ReferencedStructuredContextSequence = 0x00701903;

        ///<summary>(0070,1904) VR=UI VM=1 Referenced Content Item</summary>
        public const uint ReferencedContentItem = 0x00701904;

        ///<summary>(0070,1905) VR=SQ VM=1 Volumetric Presentation Input Annotation Sequence</summary>
        public const uint VolumetricPresentationInputAnnotationSequence = 0x00701905;

        ///<summary>(0070,1907) VR=CS VM=1 Annotation Clipping</summary>
        public const uint AnnotationClipping = 0x00701907;

        ///<summary>(0070,1A01) VR=CS VM=1 Presentation Animation Style</summary>
        public const uint PresentationAnimationStyle = 0x00701A01;

        ///<summary>(0070,1A03) VR=FD VM=1 Recommended Animation Rate</summary>
        public const uint RecommendedAnimationRate = 0x00701A03;

        ///<summary>(0070,1A04) VR=SQ VM=1 Animation Curve Sequence</summary>
        public const uint AnimationCurveSequence = 0x00701A04;

        ///<summary>(0070,1A05) VR=FD VM=1 Animation Step Size</summary>
        public const uint AnimationStepSize = 0x00701A05;

        ///<summary>(0070,1A06) VR=FD VM=1 Swivel Range</summary>
        public const uint SwivelRange = 0x00701A06;

        ///<summary>(0070,1A07) VR=OD VM=1 Volumetric Curve Up Directions</summary>
        public const uint VolumetricCurveUpDirections = 0x00701A07;

        ///<summary>(0070,1A08) VR=SQ VM=1 Volume Stream Sequence</summary>
        public const uint VolumeStreamSequence = 0x00701A08;

        ///<summary>(0070,1A09) VR=LO VM=1 RGBA Transfer Function Description</summary>
        public const uint RGBATransferFunctionDescription = 0x00701A09;

        ///<summary>(0070,1B01) VR=SQ VM=1 Advanced Blending Sequence</summary>
        public const uint AdvancedBlendingSequence = 0x00701B01;

        ///<summary>(0070,1B02) VR=US VM=1 Blending Input Number</summary>
        public const uint BlendingInputNumber = 0x00701B02;

        ///<summary>(0070,1B03) VR=SQ VM=1 Blending Display Input Sequence</summary>
        public const uint BlendingDisplayInputSequence = 0x00701B03;

        ///<summary>(0070,1B04) VR=SQ VM=1 Blending Display Sequence</summary>
        public const uint BlendingDisplaySequence = 0x00701B04;

        ///<summary>(0070,1B06) VR=CS VM=1 Blending Mode</summary>
        public const uint BlendingMode = 0x00701B06;

        ///<summary>(0070,1B07) VR=CS VM=1 Time Series Blending</summary>
        public const uint TimeSeriesBlending = 0x00701B07;

        ///<summary>(0070,1B08) VR=CS VM=1 Geometry for Display</summary>
        public const uint GeometryForDisplay = 0x00701B08;

        ///<summary>(0070,1B11) VR=SQ VM=1 Threshold Sequence</summary>
        public const uint ThresholdSequence = 0x00701B11;

        ///<summary>(0070,1B12) VR=SQ VM=1 Threshold Value Sequence</summary>
        public const uint ThresholdValueSequence = 0x00701B12;

        ///<summary>(0070,1B13) VR=CS VM=1 Threshold Type</summary>
        public const uint ThresholdType = 0x00701B13;

        ///<summary>(0070,1B14) VR=FD VM=1 Threshold Value</summary>
        public const uint ThresholdValue = 0x00701B14;

        ///<summary>(0072,0002) VR=SH VM=1 Hanging Protocol Name</summary>
        public const uint HangingProtocolName = 0x00720002;

        ///<summary>(0072,0004) VR=LO VM=1 Hanging Protocol Description</summary>
        public const uint HangingProtocolDescription = 0x00720004;

        ///<summary>(0072,0006) VR=CS VM=1 Hanging Protocol Level</summary>
        public const uint HangingProtocolLevel = 0x00720006;

        ///<summary>(0072,0008) VR=LO VM=1 Hanging Protocol Creator</summary>
        public const uint HangingProtocolCreator = 0x00720008;

        ///<summary>(0072,000A) VR=DT VM=1 Hanging Protocol Creation DateTime</summary>
        public const uint HangingProtocolCreationDateTime = 0x0072000A;

        ///<summary>(0072,000C) VR=SQ VM=1 Hanging Protocol Definition Sequence</summary>
        public const uint HangingProtocolDefinitionSequence = 0x0072000C;

        ///<summary>(0072,000E) VR=SQ VM=1 Hanging Protocol User Identification Code Sequence</summary>
        public const uint HangingProtocolUserIdentificationCodeSequence = 0x0072000E;

        ///<summary>(0072,0010) VR=LO VM=1 Hanging Protocol User Group Name</summary>
        public const uint HangingProtocolUserGroupName = 0x00720010;

        ///<summary>(0072,0012) VR=SQ VM=1 Source Hanging Protocol Sequence</summary>
        public const uint SourceHangingProtocolSequence = 0x00720012;

        ///<summary>(0072,0014) VR=US VM=1 Number of Priors Referenced</summary>
        public const uint NumberOfPriorsReferenced = 0x00720014;

        ///<summary>(0072,0020) VR=SQ VM=1 Image Sets Sequence</summary>
        public const uint ImageSetsSequence = 0x00720020;

        ///<summary>(0072,0022) VR=SQ VM=1 Image Set Selector Sequence</summary>
        public const uint ImageSetSelectorSequence = 0x00720022;

        ///<summary>(0072,0024) VR=CS VM=1 Image Set Selector Usage Flag</summary>
        public const uint ImageSetSelectorUsageFlag = 0x00720024;

        ///<summary>(0072,0026) VR=AT VM=1 Selector Attribute</summary>
        public const uint SelectorAttribute = 0x00720026;

        ///<summary>(0072,0028) VR=US VM=1 Selector Value Number</summary>
        public const uint SelectorValueNumber = 0x00720028;

        ///<summary>(0072,0030) VR=SQ VM=1 Time Based Image Sets Sequence</summary>
        public const uint TimeBasedImageSetsSequence = 0x00720030;

        ///<summary>(0072,0032) VR=US VM=1 Image Set Number</summary>
        public const uint ImageSetNumber = 0x00720032;

        ///<summary>(0072,0034) VR=CS VM=1 Image Set Selector Category</summary>
        public const uint ImageSetSelectorCategory = 0x00720034;

        ///<summary>(0072,0038) VR=US VM=2 Relative Time</summary>
        public const uint RelativeTime = 0x00720038;

        ///<summary>(0072,003A) VR=CS VM=1 Relative Time Units</summary>
        public const uint RelativeTimeUnits = 0x0072003A;

        ///<summary>(0072,003C) VR=SS VM=2 Abstract Prior Value</summary>
        public const uint AbstractPriorValue = 0x0072003C;

        ///<summary>(0072,003E) VR=SQ VM=1 Abstract Prior Code Sequence</summary>
        public const uint AbstractPriorCodeSequence = 0x0072003E;

        ///<summary>(0072,0040) VR=LO VM=1 Image Set Label</summary>
        public const uint ImageSetLabel = 0x00720040;

        ///<summary>(0072,0050) VR=CS VM=1 Selector Attribute VR</summary>
        public const uint SelectorAttributeVR = 0x00720050;

        ///<summary>(0072,0052) VR=AT VM=1-n Selector Sequence Pointer</summary>
        public const uint SelectorSequencePointer = 0x00720052;

        ///<summary>(0072,0054) VR=LO VM=1-n Selector Sequence Pointer Private Creator</summary>
        public const uint SelectorSequencePointerPrivateCreator = 0x00720054;

        ///<summary>(0072,0056) VR=LO VM=1 Selector Attribute Private Creator</summary>
        public const uint SelectorAttributePrivateCreator = 0x00720056;

        ///<summary>(0072,005E) VR=AE VM=1-n Selector AE Value</summary>
        public const uint SelectorAEValue = 0x0072005E;

        ///<summary>(0072,005F) VR=AS VM=1-n Selector AS Value</summary>
        public const uint SelectorASValue = 0x0072005F;

        ///<summary>(0072,0060) VR=AT VM=1-n Selector AT Value</summary>
        public const uint SelectorATValue = 0x00720060;

        ///<summary>(0072,0061) VR=DA VM=1-n Selector DA Value</summary>
        public const uint SelectorDAValue = 0x00720061;

        ///<summary>(0072,0062) VR=CS VM=1-n Selector CS Value</summary>
        public const uint SelectorCSValue = 0x00720062;

        ///<summary>(0072,0063) VR=DT VM=1-n Selector DT Value</summary>
        public const uint SelectorDTValue = 0x00720063;

        ///<summary>(0072,0064) VR=IS VM=1-n Selector IS Value</summary>
        public const uint SelectorISValue = 0x00720064;

        ///<summary>(0072,0065) VR=OB VM=1 Selector OB Value</summary>
        public const uint SelectorOBValue = 0x00720065;

        ///<summary>(0072,0066) VR=LO VM=1-n Selector LO Value</summary>
        public const uint SelectorLOValue = 0x00720066;

        ///<summary>(0072,0067) VR=OF VM=1 Selector OF Value</summary>
        public const uint SelectorOFValue = 0x00720067;

        ///<summary>(0072,0068) VR=LT VM=1 Selector LT Value</summary>
        public const uint SelectorLTValue = 0x00720068;

        ///<summary>(0072,0069) VR=OW VM=1 Selector OW Value</summary>
        public const uint SelectorOWValue = 0x00720069;

        ///<summary>(0072,006A) VR=PN VM=1-n Selector PN Value</summary>
        public const uint SelectorPNValue = 0x0072006A;

        ///<summary>(0072,006B) VR=TM VM=1-n Selector TM Value</summary>
        public const uint SelectorTMValue = 0x0072006B;

        ///<summary>(0072,006C) VR=SH VM=1-n Selector SH Value</summary>
        public const uint SelectorSHValue = 0x0072006C;

        ///<summary>(0072,006D) VR=UN VM=1 Selector UN Value</summary>
        public const uint SelectorUNValue = 0x0072006D;

        ///<summary>(0072,006E) VR=ST VM=1 Selector ST Value</summary>
        public const uint SelectorSTValue = 0x0072006E;

        ///<summary>(0072,006F) VR=UC VM=1-n Selector UC Value</summary>
        public const uint SelectorUCValue = 0x0072006F;

        ///<summary>(0072,0070) VR=UT VM=1 Selector UT Value</summary>
        public const uint SelectorUTValue = 0x00720070;

        ///<summary>(0072,0071) VR=UR VM=1 Selector UR Value</summary>
        public const uint SelectorURValue = 0x00720071;

        ///<summary>(0072,0072) VR=DS VM=1-n Selector DS Value</summary>
        public const uint SelectorDSValue = 0x00720072;

        ///<summary>(0072,0073) VR=OD VM=1 Selector OD Value</summary>
        public const uint SelectorODValue = 0x00720073;

        ///<summary>(0072,0074) VR=FD VM=1-n Selector FD Value</summary>
        public const uint SelectorFDValue = 0x00720074;

        ///<summary>(0072,0075) VR=OL VM=1 Selector OL Value</summary>
        public const uint SelectorOLValue = 0x00720075;

        ///<summary>(0072,0076) VR=FL VM=1-n Selector FL Value</summary>
        public const uint SelectorFLValue = 0x00720076;

        ///<summary>(0072,0078) VR=UL VM=1-n Selector UL Value</summary>
        public const uint SelectorULValue = 0x00720078;

        ///<summary>(0072,007A) VR=US VM=1-n Selector US Value</summary>
        public const uint SelectorUSValue = 0x0072007A;

        ///<summary>(0072,007C) VR=SL VM=1-n Selector SL Value</summary>
        public const uint SelectorSLValue = 0x0072007C;

        ///<summary>(0072,007E) VR=SS VM=1-n Selector SS Value</summary>
        public const uint SelectorSSValue = 0x0072007E;

        ///<summary>(0072,007F) VR=UI VM=1-n Selector UI Value</summary>
        public const uint SelectorUIValue = 0x0072007F;

        ///<summary>(0072,0080) VR=SQ VM=1 Selector Code Sequence Value</summary>
        public const uint SelectorCodeSequenceValue = 0x00720080;

        ///<summary>(0072,0081) VR=OV VM=1 Selector OV Value</summary>
        public const uint SelectorOVValue = 0x00720081;

        ///<summary>(0072,0082) VR=SV VM=1-n Selector SV Value</summary>
        public const uint SelectorSVValue = 0x00720082;

        ///<summary>(0072,0083) VR=UV VM=1-n Selector UV Value</summary>
        public const uint SelectorUVValue = 0x00720083;

        ///<summary>(0072,0100) VR=US VM=1 Number of Screens</summary>
        public const uint NumberOfScreens = 0x00720100;

        ///<summary>(0072,0102) VR=SQ VM=1 Nominal Screen Definition Sequence</summary>
        public const uint NominalScreenDefinitionSequence = 0x00720102;

        ///<summary>(0072,0104) VR=US VM=1 Number of Vertical Pixels</summary>
        public const uint NumberOfVerticalPixels = 0x00720104;

        ///<summary>(0072,0106) VR=US VM=1 Number of Horizontal Pixels</summary>
        public const uint NumberOfHorizontalPixels = 0x00720106;

        ///<summary>(0072,0108) VR=FD VM=4 Display Environment Spatial Position</summary>
        public const uint DisplayEnvironmentSpatialPosition = 0x00720108;

        ///<summary>(0072,010A) VR=US VM=1 Screen Minimum Grayscale Bit Depth</summary>
        public const uint ScreenMinimumGrayscaleBitDepth = 0x0072010A;

        ///<summary>(0072,010C) VR=US VM=1 Screen Minimum Color Bit Depth</summary>
        public const uint ScreenMinimumColorBitDepth = 0x0072010C;

        ///<summary>(0072,010E) VR=US VM=1 Application Maximum Repaint Time</summary>
        public const uint ApplicationMaximumRepaintTime = 0x0072010E;

        ///<summary>(0072,0200) VR=SQ VM=1 Display Sets Sequence</summary>
        public const uint DisplaySetsSequence = 0x00720200;

        ///<summary>(0072,0202) VR=US VM=1 Display Set Number</summary>
        public const uint DisplaySetNumber = 0x00720202;

        ///<summary>(0072,0203) VR=LO VM=1 Display Set Label</summary>
        public const uint DisplaySetLabel = 0x00720203;

        ///<summary>(0072,0204) VR=US VM=1 Display Set Presentation Group</summary>
        public const uint DisplaySetPresentationGroup = 0x00720204;

        ///<summary>(0072,0206) VR=LO VM=1 Display Set Presentation Group Description</summary>
        public const uint DisplaySetPresentationGroupDescription = 0x00720206;

        ///<summary>(0072,0208) VR=CS VM=1 Partial Data Display Handling</summary>
        public const uint PartialDataDisplayHandling = 0x00720208;

        ///<summary>(0072,0210) VR=SQ VM=1 Synchronized Scrolling Sequence</summary>
        public const uint SynchronizedScrollingSequence = 0x00720210;

        ///<summary>(0072,0212) VR=US VM=2-n Display Set Scrolling Group</summary>
        public const uint DisplaySetScrollingGroup = 0x00720212;

        ///<summary>(0072,0214) VR=SQ VM=1 Navigation Indicator Sequence</summary>
        public const uint NavigationIndicatorSequence = 0x00720214;

        ///<summary>(0072,0216) VR=US VM=1 Navigation Display Set</summary>
        public const uint NavigationDisplaySet = 0x00720216;

        ///<summary>(0072,0218) VR=US VM=1-n Reference Display Sets</summary>
        public const uint ReferenceDisplaySets = 0x00720218;

        ///<summary>(0072,0300) VR=SQ VM=1 Image Boxes Sequence</summary>
        public const uint ImageBoxesSequence = 0x00720300;

        ///<summary>(0072,0302) VR=US VM=1 Image Box Number</summary>
        public const uint ImageBoxNumber = 0x00720302;

        ///<summary>(0072,0304) VR=CS VM=1 Image Box Layout Type</summary>
        public const uint ImageBoxLayoutType = 0x00720304;

        ///<summary>(0072,0306) VR=US VM=1 Image Box Tile Horizontal Dimension</summary>
        public const uint ImageBoxTileHorizontalDimension = 0x00720306;

        ///<summary>(0072,0308) VR=US VM=1 Image Box Tile Vertical Dimension</summary>
        public const uint ImageBoxTileVerticalDimension = 0x00720308;

        ///<summary>(0072,0310) VR=CS VM=1 Image Box Scroll Direction</summary>
        public const uint ImageBoxScrollDirection = 0x00720310;

        ///<summary>(0072,0312) VR=CS VM=1 Image Box Small Scroll Type</summary>
        public const uint ImageBoxSmallScrollType = 0x00720312;

        ///<summary>(0072,0314) VR=US VM=1 Image Box Small Scroll Amount</summary>
        public const uint ImageBoxSmallScrollAmount = 0x00720314;

        ///<summary>(0072,0316) VR=CS VM=1 Image Box Large Scroll Type</summary>
        public const uint ImageBoxLargeScrollType = 0x00720316;

        ///<summary>(0072,0318) VR=US VM=1 Image Box Large Scroll Amount</summary>
        public const uint ImageBoxLargeScrollAmount = 0x00720318;

        ///<summary>(0072,0320) VR=US VM=1 Image Box Overlap Priority</summary>
        public const uint ImageBoxOverlapPriority = 0x00720320;

        ///<summary>(0072,0330) VR=FD VM=1 Cine Relative to Real-Time</summary>
        public const uint CineRelativeToRealTime = 0x00720330;

        ///<summary>(0072,0400) VR=SQ VM=1 Filter Operations Sequence</summary>
        public const uint FilterOperationsSequence = 0x00720400;

        ///<summary>(0072,0402) VR=CS VM=1 Filter-by Category</summary>
        public const uint FilterByCategory = 0x00720402;

        ///<summary>(0072,0404) VR=CS VM=1 Filter-by Attribute Presence</summary>
        public const uint FilterByAttributePresence = 0x00720404;

        ///<summary>(0072,0406) VR=CS VM=1 Filter-by Operator</summary>
        public const uint FilterByOperator = 0x00720406;

        ///<summary>(0072,0420) VR=US VM=3 Structured Display Background CIELab Value</summary>
        public const uint StructuredDisplayBackgroundCIELabValue = 0x00720420;

        ///<summary>(0072,0421) VR=US VM=3 Empty Image Box CIELab Value</summary>
        public const uint EmptyImageBoxCIELabValue = 0x00720421;

        ///<summary>(0072,0422) VR=SQ VM=1 Structured Display Image Box Sequence</summary>
        public const uint StructuredDisplayImageBoxSequence = 0x00720422;

        ///<summary>(0072,0424) VR=SQ VM=1 Structured Display Text Box Sequence</summary>
        public const uint StructuredDisplayTextBoxSequence = 0x00720424;

        ///<summary>(0072,0427) VR=SQ VM=1 Referenced First Frame Sequence</summary>
        public const uint ReferencedFirstFrameSequence = 0x00720427;

        ///<summary>(0072,0430) VR=SQ VM=1 Image Box Synchronization Sequence</summary>
        public const uint ImageBoxSynchronizationSequence = 0x00720430;

        ///<summary>(0072,0432) VR=US VM=2-n Synchronized Image Box List</summary>
        public const uint SynchronizedImageBoxList = 0x00720432;

        ///<summary>(0072,0434) VR=CS VM=1 Type of Synchronization</summary>
        public const uint TypeOfSynchronization = 0x00720434;

        ///<summary>(0072,0500) VR=CS VM=1 Blending Operation Type</summary>
        public const uint BlendingOperationType = 0x00720500;

        ///<summary>(0072,0510) VR=CS VM=1 Reformatting Operation Type</summary>
        public const uint ReformattingOperationType = 0x00720510;

        ///<summary>(0072,0512) VR=FD VM=1 Reformatting Thickness</summary>
        public const uint ReformattingThickness = 0x00720512;

        ///<summary>(0072,0514) VR=FD VM=1 Reformatting Interval</summary>
        public const uint ReformattingInterval = 0x00720514;

        ///<summary>(0072,0516) VR=CS VM=1 Reformatting Operation Initial View Direction</summary>
        public const uint ReformattingOperationInitialViewDirection = 0x00720516;

        ///<summary>(0072,0520) VR=CS VM=1-n 3D Rendering Type</summary>
        public const uint ThreeDRenderingType = 0x00720520;

        ///<summary>(0072,0600) VR=SQ VM=1 Sorting Operations Sequence</summary>
        public const uint SortingOperationsSequence = 0x00720600;

        ///<summary>(0072,0602) VR=CS VM=1 Sort-by Category</summary>
        public const uint SortByCategory = 0x00720602;

        ///<summary>(0072,0604) VR=CS VM=1 Sorting Direction</summary>
        public const uint SortingDirection = 0x00720604;

        ///<summary>(0072,0700) VR=CS VM=2 Display Set Patient Orientation</summary>
        public const uint DisplaySetPatientOrientation = 0x00720700;

        ///<summary>(0072,0702) VR=CS VM=1 VOI Type</summary>
        public const uint VOIType = 0x00720702;

        ///<summary>(0072,0704) VR=CS VM=1 Pseudo-Color Type</summary>
        public const uint PseudoColorType = 0x00720704;

        ///<summary>(0072,0705) VR=SQ VM=1 Pseudo-Color Palette Instance Reference Sequence</summary>
        public const uint PseudoColorPaletteInstanceReferenceSequence = 0x00720705;

        ///<summary>(0072,0706) VR=CS VM=1 Show Grayscale Inverted</summary>
        public const uint ShowGrayscaleInverted = 0x00720706;

        ///<summary>(0072,0710) VR=CS VM=1 Show Image True Size Flag</summary>
        public const uint ShowImageTrueSizeFlag = 0x00720710;

        ///<summary>(0072,0712) VR=CS VM=1 Show Graphic Annotation Flag</summary>
        public const uint ShowGraphicAnnotationFlag = 0x00720712;

        ///<summary>(0072,0714) VR=CS VM=1 Show Patient Demographics Flag</summary>
        public const uint ShowPatientDemographicsFlag = 0x00720714;

        ///<summary>(0072,0716) VR=CS VM=1 Show Acquisition Techniques Flag</summary>
        public const uint ShowAcquisitionTechniquesFlag = 0x00720716;

        ///<summary>(0072,0717) VR=CS VM=1 Display Set Horizontal Justification</summary>
        public const uint DisplaySetHorizontalJustification = 0x00720717;

        ///<summary>(0072,0718) VR=CS VM=1 Display Set Vertical Justification</summary>
        public const uint DisplaySetVerticalJustification = 0x00720718;

        ///<summary>(0074,0120) VR=FD VM=1 Continuation Start Meterset</summary>
        public const uint ContinuationStartMeterset = 0x00740120;

        ///<summary>(0074,0121) VR=FD VM=1 Continuation End Meterset</summary>
        public const uint ContinuationEndMeterset = 0x00740121;

        ///<summary>(0074,1000) VR=CS VM=1 Procedure Step State</summary>
        public const uint ProcedureStepState = 0x00741000;

        ///<summary>(0074,1002) VR=SQ VM=1 Procedure Step Progress Information Sequence</summary>
        public const uint ProcedureStepProgressInformationSequence = 0x00741002;

        ///<summary>(0074,1004) VR=DS VM=1 Procedure Step Progress</summary>
        public const uint ProcedureStepProgress = 0x00741004;

        ///<summary>(0074,1006) VR=ST VM=1 Procedure Step Progress Description</summary>
        public const uint ProcedureStepProgressDescription = 0x00741006;

        ///<summary>(0074,1007) VR=SQ VM=1 Procedure Step Progress Parameters Sequence</summary>
        public const uint ProcedureStepProgressParametersSequence = 0x00741007;

        ///<summary>(0074,1008) VR=SQ VM=1 Procedure Step Communications URI Sequence</summary>
        public const uint ProcedureStepCommunicationsURISequence = 0x00741008;

        ///<summary>(0074,100A) VR=UR VM=1 Contact URI</summary>
        public const uint ContactURI = 0x0074100A;

        ///<summary>(0074,100C) VR=LO VM=1 Contact Display Name</summary>
        public const uint ContactDisplayName = 0x0074100C;

        ///<summary>(0074,100E) VR=SQ VM=1 Procedure Step Discontinuation Reason Code Sequence</summary>
        public const uint ProcedureStepDiscontinuationReasonCodeSequence = 0x0074100E;

        ///<summary>(0074,1020) VR=SQ VM=1 Beam Task Sequence</summary>
        public const uint BeamTaskSequence = 0x00741020;

        ///<summary>(0074,1022) VR=CS VM=1 Beam Task Type</summary>
        public const uint BeamTaskType = 0x00741022;

        ///<summary>(0074,1024) VR=IS VM=1 Beam Order Index (Trial) (RETIRED)</summary>
        public const uint BeamOrderIndexTrialRETIRED = 0x00741024;

        ///<summary>(0074,1025) VR=CS VM=1 Autosequence Flag</summary>
        public const uint AutosequenceFlag = 0x00741025;

        ///<summary>(0074,1026) VR=FD VM=1 Table Top Vertical Adjusted Position</summary>
        public const uint TableTopVerticalAdjustedPosition = 0x00741026;

        ///<summary>(0074,1027) VR=FD VM=1 Table Top Longitudinal Adjusted Position</summary>
        public const uint TableTopLongitudinalAdjustedPosition = 0x00741027;

        ///<summary>(0074,1028) VR=FD VM=1 Table Top Lateral Adjusted Position</summary>
        public const uint TableTopLateralAdjustedPosition = 0x00741028;

        ///<summary>(0074,102A) VR=FD VM=1 Patient Support Adjusted Angle</summary>
        public const uint PatientSupportAdjustedAngle = 0x0074102A;

        ///<summary>(0074,102B) VR=FD VM=1 Table Top Eccentric Adjusted Angle</summary>
        public const uint TableTopEccentricAdjustedAngle = 0x0074102B;

        ///<summary>(0074,102C) VR=FD VM=1 Table Top Pitch Adjusted Angle</summary>
        public const uint TableTopPitchAdjustedAngle = 0x0074102C;

        ///<summary>(0074,102D) VR=FD VM=1 Table Top Roll Adjusted Angle</summary>
        public const uint TableTopRollAdjustedAngle = 0x0074102D;

        ///<summary>(0074,1030) VR=SQ VM=1 Delivery Verification Image Sequence</summary>
        public const uint DeliveryVerificationImageSequence = 0x00741030;

        ///<summary>(0074,1032) VR=CS VM=1 Verification Image Timing</summary>
        public const uint VerificationImageTiming = 0x00741032;

        ///<summary>(0074,1034) VR=CS VM=1 Double Exposure Flag</summary>
        public const uint DoubleExposureFlag = 0x00741034;

        ///<summary>(0074,1036) VR=CS VM=1 Double Exposure Ordering</summary>
        public const uint DoubleExposureOrdering = 0x00741036;

        ///<summary>(0074,1038) VR=DS VM=1 Double Exposure Meterset (Trial) (RETIRED)</summary>
        public const uint DoubleExposureMetersetTrialRETIRED = 0x00741038;

        ///<summary>(0074,103A) VR=DS VM=4 Double Exposure Field Delta (Trial) (RETIRED)</summary>
        public const uint DoubleExposureFieldDeltaTrialRETIRED = 0x0074103A;

        ///<summary>(0074,1040) VR=SQ VM=1 Related Reference RT Image Sequence</summary>
        public const uint RelatedReferenceRTImageSequence = 0x00741040;

        ///<summary>(0074,1042) VR=SQ VM=1 General Machine Verification Sequence</summary>
        public const uint GeneralMachineVerificationSequence = 0x00741042;

        ///<summary>(0074,1044) VR=SQ VM=1 Conventional Machine Verification Sequence</summary>
        public const uint ConventionalMachineVerificationSequence = 0x00741044;

        ///<summary>(0074,1046) VR=SQ VM=1 Ion Machine Verification Sequence</summary>
        public const uint IonMachineVerificationSequence = 0x00741046;

        ///<summary>(0074,1048) VR=SQ VM=1 Failed Attributes Sequence</summary>
        public const uint FailedAttributesSequence = 0x00741048;

        ///<summary>(0074,104A) VR=SQ VM=1 Overridden Attributes Sequence</summary>
        public const uint OverriddenAttributesSequence = 0x0074104A;

        ///<summary>(0074,104C) VR=SQ VM=1 Conventional Control Point Verification Sequence</summary>
        public const uint ConventionalControlPointVerificationSequence = 0x0074104C;

        ///<summary>(0074,104E) VR=SQ VM=1 Ion Control Point Verification Sequence</summary>
        public const uint IonControlPointVerificationSequence = 0x0074104E;

        ///<summary>(0074,1050) VR=SQ VM=1 Attribute Occurrence Sequence</summary>
        public const uint AttributeOccurrenceSequence = 0x00741050;

        ///<summary>(0074,1052) VR=AT VM=1 Attribute Occurrence Pointer</summary>
        public const uint AttributeOccurrencePointer = 0x00741052;

        ///<summary>(0074,1054) VR=UL VM=1 Attribute Item Selector</summary>
        public const uint AttributeItemSelector = 0x00741054;

        ///<summary>(0074,1056) VR=LO VM=1 Attribute Occurrence Private Creator</summary>
        public const uint AttributeOccurrencePrivateCreator = 0x00741056;

        ///<summary>(0074,1057) VR=IS VM=1-n Selector Sequence Pointer Items</summary>
        public const uint SelectorSequencePointerItems = 0x00741057;

        ///<summary>(0074,1200) VR=CS VM=1 Scheduled Procedure Step Priority</summary>
        public const uint ScheduledProcedureStepPriority = 0x00741200;

        ///<summary>(0074,1202) VR=LO VM=1 Worklist Label</summary>
        public const uint WorklistLabel = 0x00741202;

        ///<summary>(0074,1204) VR=LO VM=1 Procedure Step Label</summary>
        public const uint ProcedureStepLabel = 0x00741204;

        ///<summary>(0074,1210) VR=SQ VM=1 Scheduled Processing Parameters Sequence</summary>
        public const uint ScheduledProcessingParametersSequence = 0x00741210;

        ///<summary>(0074,1212) VR=SQ VM=1 Performed Processing Parameters Sequence</summary>
        public const uint PerformedProcessingParametersSequence = 0x00741212;

        ///<summary>(0074,1216) VR=SQ VM=1 Unified Procedure Step Performed Procedure Sequence</summary>
        public const uint UnifiedProcedureStepPerformedProcedureSequence = 0x00741216;

        ///<summary>(0074,1220) VR=SQ VM=1 Related Procedure Step Sequence (RETIRED)</summary>
        public const uint RelatedProcedureStepSequenceRETIRED = 0x00741220;

        ///<summary>(0074,1222) VR=LO VM=1 Procedure Step Relationship Type (RETIRED)</summary>
        public const uint ProcedureStepRelationshipTypeRETIRED = 0x00741222;

        ///<summary>(0074,1224) VR=SQ VM=1 Replaced Procedure Step Sequence</summary>
        public const uint ReplacedProcedureStepSequence = 0x00741224;

        ///<summary>(0074,1230) VR=LO VM=1 Deletion Lock</summary>
        public const uint DeletionLock = 0x00741230;

        ///<summary>(0074,1234) VR=AE VM=1 Receiving AE</summary>
        public const uint ReceivingAE = 0x00741234;

        ///<summary>(0074,1236) VR=AE VM=1 Requesting AE</summary>
        public const uint RequestingAE = 0x00741236;

        ///<summary>(0074,1238) VR=LT VM=1 Reason for Cancellation</summary>
        public const uint ReasonForCancellation = 0x00741238;

        ///<summary>(0074,1242) VR=CS VM=1 SCP Status</summary>
        public const uint SCPStatus = 0x00741242;

        ///<summary>(0074,1244) VR=CS VM=1 Subscription List Status</summary>
        public const uint SubscriptionListStatus = 0x00741244;

        ///<summary>(0074,1246) VR=CS VM=1 Unified Procedure Step List Status</summary>
        public const uint UnifiedProcedureStepListStatus = 0x00741246;

        ///<summary>(0074,1324) VR=UL VM=1 Beam Order Index</summary>
        public const uint BeamOrderIndex = 0x00741324;

        ///<summary>(0074,1338) VR=FD VM=1 Double Exposure Meterset</summary>
        public const uint DoubleExposureMeterset = 0x00741338;

        ///<summary>(0074,133A) VR=FD VM=4 Double Exposure Field Delta</summary>
        public const uint DoubleExposureFieldDelta = 0x0074133A;

        ///<summary>(0074,1401) VR=SQ VM=1 Brachy Task Sequence</summary>
        public const uint BrachyTaskSequence = 0x00741401;

        ///<summary>(0074,1402) VR=DS VM=1 Continuation Start Total Reference Air Kerma</summary>
        public const uint ContinuationStartTotalReferenceAirKerma = 0x00741402;

        ///<summary>(0074,1403) VR=DS VM=1 Continuation End Total Reference Air Kerma</summary>
        public const uint ContinuationEndTotalReferenceAirKerma = 0x00741403;

        ///<summary>(0074,1404) VR=IS VM=1 Continuation Pulse Number</summary>
        public const uint ContinuationPulseNumber = 0x00741404;

        ///<summary>(0074,1405) VR=SQ VM=1 Channel Delivery Order Sequence</summary>
        public const uint ChannelDeliveryOrderSequence = 0x00741405;

        ///<summary>(0074,1406) VR=IS VM=1 Referenced Channel Number</summary>
        public const uint ReferencedChannelNumber = 0x00741406;

        ///<summary>(0074,1407) VR=DS VM=1 Start Cumulative Time Weight</summary>
        public const uint StartCumulativeTimeWeight = 0x00741407;

        ///<summary>(0074,1408) VR=DS VM=1 End Cumulative Time Weight</summary>
        public const uint EndCumulativeTimeWeight = 0x00741408;

        ///<summary>(0074,1409) VR=SQ VM=1 Omitted Channel Sequence</summary>
        public const uint OmittedChannelSequence = 0x00741409;

        ///<summary>(0074,140A) VR=CS VM=1 Reason for Channel Omission</summary>
        public const uint ReasonForChannelOmission = 0x0074140A;

        ///<summary>(0074,140B) VR=LO VM=1 Reason for Channel Omission Description</summary>
        public const uint ReasonForChannelOmissionDescription = 0x0074140B;

        ///<summary>(0074,140C) VR=IS VM=1 Channel Delivery Order Index</summary>
        public const uint ChannelDeliveryOrderIndex = 0x0074140C;

        ///<summary>(0074,140D) VR=SQ VM=1 Channel Delivery Continuation Sequence</summary>
        public const uint ChannelDeliveryContinuationSequence = 0x0074140D;

        ///<summary>(0074,140E) VR=SQ VM=1 Omitted Application Setup Sequence</summary>
        public const uint OmittedApplicationSetupSequence = 0x0074140E;

        ///<summary>(0076,0001) VR=LO VM=1 Implant Assembly Template Name</summary>
        public const uint ImplantAssemblyTemplateName = 0x00760001;

        ///<summary>(0076,0003) VR=LO VM=1 Implant Assembly Template Issuer</summary>
        public const uint ImplantAssemblyTemplateIssuer = 0x00760003;

        ///<summary>(0076,0006) VR=LO VM=1 Implant Assembly Template Version</summary>
        public const uint ImplantAssemblyTemplateVersion = 0x00760006;

        ///<summary>(0076,0008) VR=SQ VM=1 Replaced Implant Assembly Template Sequence</summary>
        public const uint ReplacedImplantAssemblyTemplateSequence = 0x00760008;

        ///<summary>(0076,000A) VR=CS VM=1 Implant Assembly Template Type</summary>
        public const uint ImplantAssemblyTemplateType = 0x0076000A;

        ///<summary>(0076,000C) VR=SQ VM=1 Original Implant Assembly Template Sequence</summary>
        public const uint OriginalImplantAssemblyTemplateSequence = 0x0076000C;

        ///<summary>(0076,000E) VR=SQ VM=1 Derivation Implant Assembly Template Sequence</summary>
        public const uint DerivationImplantAssemblyTemplateSequence = 0x0076000E;

        ///<summary>(0076,0010) VR=SQ VM=1 Implant Assembly Template Target Anatomy Sequence</summary>
        public const uint ImplantAssemblyTemplateTargetAnatomySequence = 0x00760010;

        ///<summary>(0076,0020) VR=SQ VM=1 Procedure Type Code Sequence</summary>
        public const uint ProcedureTypeCodeSequence = 0x00760020;

        ///<summary>(0076,0030) VR=LO VM=1 Surgical Technique</summary>
        public const uint SurgicalTechnique = 0x00760030;

        ///<summary>(0076,0032) VR=SQ VM=1 Component Types Sequence</summary>
        public const uint ComponentTypesSequence = 0x00760032;

        ///<summary>(0076,0034) VR=SQ VM=1 Component Type Code Sequence</summary>
        public const uint ComponentTypeCodeSequence = 0x00760034;

        ///<summary>(0076,0036) VR=CS VM=1 Exclusive Component Type</summary>
        public const uint ExclusiveComponentType = 0x00760036;

        ///<summary>(0076,0038) VR=CS VM=1 Mandatory Component Type</summary>
        public const uint MandatoryComponentType = 0x00760038;

        ///<summary>(0076,0040) VR=SQ VM=1 Component Sequence</summary>
        public const uint ComponentSequence = 0x00760040;

        ///<summary>(0076,0055) VR=US VM=1 Component Id</summary>
        public const uint ComponentId = 0x00760055;

        ///<summary>(0076,0060) VR=SQ VM=1 Component Assembly Sequence</summary>
        public const uint ComponentAssemblySequence = 0x00760060;

        ///<summary>(0076,0070) VR=US VM=1 Component 1 Referenced Id</summary>
        public const uint Component1ReferencedId = 0x00760070;

        ///<summary>(0076,0080) VR=US VM=1 Component 1 Referenced Mating Feature Set Id</summary>
        public const uint Component1ReferencedMatingFeatureSetId = 0x00760080;

        ///<summary>(0076,0090) VR=US VM=1 Component 1 Referenced Mating Feature Id</summary>
        public const uint Component1ReferencedMatingFeatureId = 0x00760090;

        ///<summary>(0076,00A0) VR=US VM=1 Component 2 Referenced Id</summary>
        public const uint Component2ReferencedId = 0x007600A0;

        ///<summary>(0076,00B0) VR=US VM=1 Component 2 Referenced Mating Feature Set Id</summary>
        public const uint Component2ReferencedMatingFeatureSetId = 0x007600B0;

        ///<summary>(0076,00C0) VR=US VM=1 Component 2 Referenced Mating Feature Id</summary>
        public const uint Component2ReferencedMatingFeatureId = 0x007600C0;

        ///<summary>(0078,0001) VR=LO VM=1 Implant Template Group Name</summary>
        public const uint ImplantTemplateGroupName = 0x00780001;

        ///<summary>(0078,0010) VR=ST VM=1 Implant Template Group Description</summary>
        public const uint ImplantTemplateGroupDescription = 0x00780010;

        ///<summary>(0078,0020) VR=LO VM=1 Implant Template Group Issuer</summary>
        public const uint ImplantTemplateGroupIssuer = 0x00780020;

        ///<summary>(0078,0024) VR=LO VM=1 Implant Template Group Version</summary>
        public const uint ImplantTemplateGroupVersion = 0x00780024;

        ///<summary>(0078,0026) VR=SQ VM=1 Replaced Implant Template Group Sequence</summary>
        public const uint ReplacedImplantTemplateGroupSequence = 0x00780026;

        ///<summary>(0078,0028) VR=SQ VM=1 Implant Template Group Target Anatomy Sequence</summary>
        public const uint ImplantTemplateGroupTargetAnatomySequence = 0x00780028;

        ///<summary>(0078,002A) VR=SQ VM=1 Implant Template Group Members Sequence</summary>
        public const uint ImplantTemplateGroupMembersSequence = 0x0078002A;

        ///<summary>(0078,002E) VR=US VM=1 Implant Template Group Member Id</summary>
        public const uint ImplantTemplateGroupMemberId = 0x0078002E;

        ///<summary>(0078,0050) VR=FD VM=3 3D Implant Template Group Member Matching Point</summary>
        public const uint ThreeDImplantTemplateGroupMemberMatchingPoint = 0x00780050;

        ///<summary>(0078,0060) VR=FD VM=9 3D Implant Template Group Member Matching Axes</summary>
        public const uint ThreeDImplantTemplateGroupMemberMatchingAxes = 0x00780060;

        ///<summary>(0078,0070) VR=SQ VM=1 Implant Template Group Member Matching 2D Coordinates Sequence</summary>
        public const uint ImplantTemplateGroupMemberMatching2DCoordinatesSequence = 0x00780070;

        ///<summary>(0078,0090) VR=FD VM=2 2D Implant Template Group Member Matching Point</summary>
        public const uint TwoDImplantTemplateGroupMemberMatchingPoint = 0x00780090;

        ///<summary>(0078,00A0) VR=FD VM=4 2D Implant Template Group Member Matching Axes</summary>
        public const uint TwoDImplantTemplateGroupMemberMatchingAxes = 0x007800A0;

        ///<summary>(0078,00B0) VR=SQ VM=1 Implant Template Group Variation Dimension Sequence</summary>
        public const uint ImplantTemplateGroupVariationDimensionSequence = 0x007800B0;

        ///<summary>(0078,00B2) VR=LO VM=1 Implant Template Group Variation Dimension Name</summary>
        public const uint ImplantTemplateGroupVariationDimensionName = 0x007800B2;

        ///<summary>(0078,00B4) VR=SQ VM=1 Implant Template Group Variation Dimension Rank Sequence</summary>
        public const uint ImplantTemplateGroupVariationDimensionRankSequence = 0x007800B4;

        ///<summary>(0078,00B6) VR=US VM=1 Referenced Implant Template Group Member Id</summary>
        public const uint ReferencedImplantTemplateGroupMemberId = 0x007800B6;

        ///<summary>(0078,00B8) VR=US VM=1 Implant Template Group Variation Dimension Rank</summary>
        public const uint ImplantTemplateGroupVariationDimensionRank = 0x007800B8;

        ///<summary>(0080,0001) VR=SQ VM=1 Surface Scan Acquisition Type Code Sequence</summary>
        public const uint SurfaceScanAcquisitionTypeCodeSequence = 0x00800001;

        ///<summary>(0080,0002) VR=SQ VM=1 Surface Scan Mode Code Sequence</summary>
        public const uint SurfaceScanModeCodeSequence = 0x00800002;

        ///<summary>(0080,0003) VR=SQ VM=1 Registration Method Code Sequence</summary>
        public const uint RegistrationMethodCodeSequence = 0x00800003;

        ///<summary>(0080,0004) VR=FD VM=1 Shot Duration Time</summary>
        public const uint ShotDurationTime = 0x00800004;

        ///<summary>(0080,0005) VR=FD VM=1 Shot Offset Time</summary>
        public const uint ShotOffsetTime = 0x00800005;

        ///<summary>(0080,0006) VR=US VM=1-n Surface Point Presentation Value Data</summary>
        public const uint SurfacePointPresentationValueData = 0x00800006;

        ///<summary>(0080,0007) VR=US VM=3-3n Surface Point Color CIELab Value Data</summary>
        public const uint SurfacePointColorCIELabValueData = 0x00800007;

        ///<summary>(0080,0008) VR=SQ VM=1 UV Mapping Sequence</summary>
        public const uint UVMappingSequence = 0x00800008;

        ///<summary>(0080,0009) VR=SH VM=1 Texture Label</summary>
        public const uint TextureLabel = 0x00800009;

        ///<summary>(0080,0010) VR=OF VM=1 U Value Data</summary>
        public const uint UValueData = 0x00800010;

        ///<summary>(0080,0011) VR=OF VM=1 V Value Data</summary>
        public const uint VValueData = 0x00800011;

        ///<summary>(0080,0012) VR=SQ VM=1 Referenced Texture Sequence</summary>
        public const uint ReferencedTextureSequence = 0x00800012;

        ///<summary>(0080,0013) VR=SQ VM=1 Referenced Surface Data Sequence</summary>
        public const uint ReferencedSurfaceDataSequence = 0x00800013;

        ///<summary>(0082,0001) VR=CS VM=1 Assessment Summary</summary>
        public const uint AssessmentSummary = 0x00820001;

        ///<summary>(0082,0003) VR=UT VM=1 Assessment Summary Description</summary>
        public const uint AssessmentSummaryDescription = 0x00820003;

        ///<summary>(0082,0004) VR=SQ VM=1 Assessed Sop Instance Sequence</summary>
        public const uint AssessedSopInstanceSequence = 0x00820004;

        ///<summary>(0082,0005) VR=SQ VM=1 Referenced Comparison Sop Instance Sequence</summary>
        public const uint ReferencedComparisonSopInstanceSequence = 0x00820005;

        ///<summary>(0082,0006) VR=UL VM=1 Number of Assessment Observations</summary>
        public const uint NumberOfAssessmentObservations = 0x00820006;

        ///<summary>(0082,0007) VR=SQ VM=1 Assessment Observations Sequence</summary>
        public const uint AssessmentObservationsSequence = 0x00820007;

        ///<summary>(0082,0008) VR=CS VM=1 Observation Significance</summary>
        public const uint ObservationSignificance = 0x00820008;

        ///<summary>(0082,000A) VR=UT VM=1 Observation Description</summary>
        public const uint ObservationDescription = 0x0082000A;

        ///<summary>(0082,000C) VR=SQ VM=1 Structured Constraint Observation Sequence</summary>
        public const uint StructuredConstraintObservationSequence = 0x0082000C;

        ///<summary>(0082,0010) VR=SQ VM=1 Assessed Attribute Value Sequence</summary>
        public const uint AssessedAttributeValueSequence = 0x00820010;

        ///<summary>(0082,0016) VR=LO VM=1 Assessment Set Id</summary>
        public const uint AssessmentSetId = 0x00820016;

        ///<summary>(0082,0017) VR=SQ VM=1 Assessment Requester Sequence</summary>
        public const uint AssessmentRequesterSequence = 0x00820017;

        ///<summary>(0082,0018) VR=LO VM=1 Selector Attribute Name</summary>
        public const uint SelectorAttributeName = 0x00820018;

        ///<summary>(0082,0019) VR=LO VM=1 Selector Attribute Keyword</summary>
        public const uint SelectorAttributeKeyword = 0x00820019;

        ///<summary>(0082,0021) VR=SQ VM=1 Assessment Type Code Sequence</summary>
        public const uint AssessmentTypeCodeSequence = 0x00820021;

        ///<summary>(0082,0022) VR=SQ VM=1 Observation Basis Code Sequence</summary>
        public const uint ObservationBasisCodeSequence = 0x00820022;

        ///<summary>(0082,0023) VR=LO VM=1 Assessment Label</summary>
        public const uint AssessmentLabel = 0x00820023;

        ///<summary>(0082,0032) VR=CS VM=1 Constraint Type</summary>
        public const uint ConstraintType = 0x00820032;

        ///<summary>(0082,0033) VR=UT VM=1 Specification Selection GUidance</summary>
        public const uint SpecificationSelectionGUidance = 0x00820033;

        ///<summary>(0082,0034) VR=SQ VM=1 Constraint Value Sequence</summary>
        public const uint ConstraintValueSequence = 0x00820034;

        ///<summary>(0082,0035) VR=SQ VM=1 Recommended Default Value Sequence</summary>
        public const uint RecommendedDefaultValueSequence = 0x00820035;

        ///<summary>(0082,0036) VR=CS VM=1 Constraint Violation Significance</summary>
        public const uint ConstraintViolationSignificance = 0x00820036;

        ///<summary>(0082,0037) VR=UT VM=1 Constraint Violation Condition</summary>
        public const uint ConstraintViolationCondition = 0x00820037;

        ///<summary>(0082,0038) VR=CS VM=1 Modifiable Constraint Flag</summary>
        public const uint ModifiableConstraintFlag = 0x00820038;

        ///<summary>(0088,0130) VR=SH VM=1 Storage Media File-set Id</summary>
        public const uint StorageMediaFileSetId = 0x00880130;

        ///<summary>(0088,0140) VR=UI VM=1 Storage Media File-set Uid</summary>
        public const uint StorageMediaFileSetUid = 0x00880140;

        ///<summary>(0088,0200) VR=SQ VM=1 Icon Image Sequence</summary>
        public const uint IconImageSequence = 0x00880200;

        ///<summary>(0088,0904) VR=LO VM=1 Topic Title (RETIRED)</summary>
        public const uint TopicTitleRETIRED = 0x00880904;

        ///<summary>(0088,0906) VR=ST VM=1 Topic Subject (RETIRED)</summary>
        public const uint TopicSubjectRETIRED = 0x00880906;

        ///<summary>(0088,0910) VR=LO VM=1 Topic Author (RETIRED)</summary>
        public const uint TopicAuthorRETIRED = 0x00880910;

        ///<summary>(0088,0912) VR=LO VM=1-32 Topic Keywords (RETIRED)</summary>
        public const uint TopicKeywordsRETIRED = 0x00880912;

        ///<summary>(0100,0410) VR=CS VM=1 Sop Instance Status</summary>
        public const uint SopInstanceStatus = 0x01000410;

        ///<summary>(0100,0420) VR=DT VM=1 Sop Authorization DateTime</summary>
        public const uint SopAuthorizationDateTime = 0x01000420;

        ///<summary>(0100,0424) VR=LT VM=1 Sop Authorization Comment</summary>
        public const uint SopAuthorizationComment = 0x01000424;

        ///<summary>(0100,0426) VR=LO VM=1 Authorization Equipment Certification Number</summary>
        public const uint AuthorizationEquipmentCertificationNumber = 0x01000426;

        ///<summary>(0400,0005) VR=US VM=1 MAC Id Number</summary>
        public const uint MACIdNumber = 0x04000005;

        ///<summary>(0400,0010) VR=UI VM=1 MAC Calculation Transfer Syntax Uid</summary>
        public const uint MACCalculationTransferSyntaxUid = 0x04000010;

        ///<summary>(0400,0015) VR=CS VM=1 MAC Algorithm</summary>
        public const uint MACAlgorithm = 0x04000015;

        ///<summary>(0400,0020) VR=AT VM=1-n Data Elements Signed</summary>
        public const uint DataElementsSigned = 0x04000020;

        ///<summary>(0400,0100) VR=UI VM=1 Digital Signature Uid</summary>
        public const uint DigitalSignatureUid = 0x04000100;

        ///<summary>(0400,0105) VR=DT VM=1 Digital Signature DateTime</summary>
        public const uint DigitalSignatureDateTime = 0x04000105;

        ///<summary>(0400,0110) VR=CS VM=1 Certificate Type</summary>
        public const uint CertificateType = 0x04000110;

        ///<summary>(0400,0115) VR=OB VM=1 Certificate of Signer</summary>
        public const uint CertificateOfSigner = 0x04000115;

        ///<summary>(0400,0120) VR=OB VM=1 Signature</summary>
        public const uint Signature = 0x04000120;

        ///<summary>(0400,0305) VR=CS VM=1 Certified Timestamp Type</summary>
        public const uint CertifiedTimestampType = 0x04000305;

        ///<summary>(0400,0310) VR=OB VM=1 Certified Timestamp</summary>
        public const uint CertifiedTimestamp = 0x04000310;

        ///<summary>(0400,0401) VR=SQ VM=1 Digital Signature Purpose Code Sequence</summary>
        public const uint DigitalSignaturePurposeCodeSequence = 0x04000401;

        ///<summary>(0400,0402) VR=SQ VM=1 Referenced Digital Signature Sequence</summary>
        public const uint ReferencedDigitalSignatureSequence = 0x04000402;

        ///<summary>(0400,0403) VR=SQ VM=1 Referenced Sop Instance MAC Sequence</summary>
        public const uint ReferencedSopInstanceMACSequence = 0x04000403;

        ///<summary>(0400,0404) VR=OB VM=1 MAC</summary>
        public const uint MAC = 0x04000404;

        ///<summary>(0400,0500) VR=SQ VM=1 Encrypted Attributes Sequence</summary>
        public const uint EncryptedAttributesSequence = 0x04000500;

        ///<summary>(0400,0510) VR=UI VM=1 Encrypted Content Transfer Syntax Uid</summary>
        public const uint EncryptedContentTransferSyntaxUid = 0x04000510;

        ///<summary>(0400,0520) VR=OB VM=1 Encrypted Content</summary>
        public const uint EncryptedContent = 0x04000520;

        ///<summary>(0400,0550) VR=SQ VM=1 Modified Attributes Sequence</summary>
        public const uint ModifiedAttributesSequence = 0x04000550;

        ///<summary>(0400,0551) VR=SQ VM=1 Nonconforming Modified Attributes Sequence</summary>
        public const uint NonconformingModifiedAttributesSequence = 0x04000551;

        ///<summary>(0400,0552) VR=OB VM=1 Nonconforming Data Element Value</summary>
        public const uint NonconformingDataElementValue = 0x04000552;

        ///<summary>(0400,0561) VR=SQ VM=1 Original Attributes Sequence</summary>
        public const uint OriginalAttributesSequence = 0x04000561;

        ///<summary>(0400,0562) VR=DT VM=1 Attribute Modification DateTime</summary>
        public const uint AttributeModificationDateTime = 0x04000562;

        ///<summary>(0400,0563) VR=LO VM=1 Modifying System</summary>
        public const uint ModifyingSystem = 0x04000563;

        ///<summary>(0400,0564) VR=LO VM=1 Source of Previous Values</summary>
        public const uint SourceOfPreviousValues = 0x04000564;

        ///<summary>(0400,0565) VR=CS VM=1 Reason for the Attribute Modification</summary>
        public const uint ReasonForTheAttributeModification = 0x04000565;

        ///<summary>(0400,0600) VR=CS VM=1 Instance Origin Status</summary>
        public const uint InstanceOriginStatus = 0x04000600;

        ///<summary>(1000,xxx0) VR=US VM=3 Escape Triplet (RETIRED)</summary>
        public const uint EscapeTripletRETIRED = 0x10000000;

        ///<summary>(1000,xxx1) VR=US VM=3 Run Length Triplet (RETIRED)</summary>
        public const uint RunLengthTripletRETIRED = 0x10000001;

        ///<summary>(1000,xxx2) VR=US VM=1 Huffman Table Size (RETIRED)</summary>
        public const uint HuffmanTableSizeRETIRED = 0x10000002;

        ///<summary>(1000,xxx3) VR=US VM=3 Huffman Table Triplet (RETIRED)</summary>
        public const uint HuffmanTableTripletRETIRED = 0x10000003;

        ///<summary>(1000,xxx4) VR=US VM=1 Shift Table Size (RETIRED)</summary>
        public const uint ShiftTableSizeRETIRED = 0x10000004;

        ///<summary>(1000,xxx5) VR=US VM=3 Shift Table Triplet (RETIRED)</summary>
        public const uint ShiftTableTripletRETIRED = 0x10000005;

        ///<summary>(1010,xxxx) VR=US VM=1-n Zonal Map (RETIRED)</summary>
        public const uint ZonalMapRETIRED = 0x10100000;

        ///<summary>(2000,0010) VR=IS VM=1 Number of Copies</summary>
        public const uint NumberOfCopies = 0x20000010;

        ///<summary>(2000,001E) VR=SQ VM=1 Printer Configuration Sequence</summary>
        public const uint PrinterConfigurationSequence = 0x2000001E;

        ///<summary>(2000,0020) VR=CS VM=1 Print Priority</summary>
        public const uint PrintPriority = 0x20000020;

        ///<summary>(2000,0030) VR=CS VM=1 Medium Type</summary>
        public const uint MediumType = 0x20000030;

        ///<summary>(2000,0040) VR=CS VM=1 Film Destination</summary>
        public const uint FilmDestination = 0x20000040;

        ///<summary>(2000,0050) VR=LO VM=1 Film Session Label</summary>
        public const uint FilmSessionLabel = 0x20000050;

        ///<summary>(2000,0060) VR=IS VM=1 Memory Allocation</summary>
        public const uint MemoryAllocation = 0x20000060;

        ///<summary>(2000,0061) VR=IS VM=1 Maximum Memory Allocation</summary>
        public const uint MaximumMemoryAllocation = 0x20000061;

        ///<summary>(2000,0062) VR=CS VM=1 Color Image Printing Flag (RETIRED)</summary>
        public const uint ColorImagePrintingFlagRETIRED = 0x20000062;

        ///<summary>(2000,0063) VR=CS VM=1 Collation Flag (RETIRED)</summary>
        public const uint CollationFlagRETIRED = 0x20000063;

        ///<summary>(2000,0065) VR=CS VM=1 Annotation Flag (RETIRED)</summary>
        public const uint AnnotationFlagRETIRED = 0x20000065;

        ///<summary>(2000,0067) VR=CS VM=1 Image Overlay Flag (RETIRED)</summary>
        public const uint ImageOverlayFlagRETIRED = 0x20000067;

        ///<summary>(2000,0069) VR=CS VM=1 Presentation LUT Flag (RETIRED)</summary>
        public const uint PresentationLUTFlagRETIRED = 0x20000069;

        ///<summary>(2000,006A) VR=CS VM=1 Image Box Presentation LUT Flag (RETIRED)</summary>
        public const uint ImageBoxPresentationLUTFlagRETIRED = 0x2000006A;

        ///<summary>(2000,00A0) VR=US VM=1 Memory Bit Depth</summary>
        public const uint MemoryBitDepth = 0x200000A0;

        ///<summary>(2000,00A1) VR=US VM=1 Printing Bit Depth</summary>
        public const uint PrintingBitDepth = 0x200000A1;

        ///<summary>(2000,00A2) VR=SQ VM=1 Media Installed Sequence</summary>
        public const uint MediaInstalledSequence = 0x200000A2;

        ///<summary>(2000,00A4) VR=SQ VM=1 Other Media Available Sequence</summary>
        public const uint OtherMediaAvailableSequence = 0x200000A4;

        ///<summary>(2000,00A8) VR=SQ VM=1 Supported Image Display Formats Sequence</summary>
        public const uint SupportedImageDisplayFormatsSequence = 0x200000A8;

        ///<summary>(2000,0500) VR=SQ VM=1 Referenced Film Box Sequence</summary>
        public const uint ReferencedFilmBoxSequence = 0x20000500;

        ///<summary>(2000,0510) VR=SQ VM=1 Referenced Stored Print Sequence (RETIRED)</summary>
        public const uint ReferencedStoredPrintSequenceRETIRED = 0x20000510;

        ///<summary>(2010,0010) VR=ST VM=1 Image Display Format</summary>
        public const uint ImageDisplayFormat = 0x20100010;

        ///<summary>(2010,0030) VR=CS VM=1 Annotation Display Format Id</summary>
        public const uint AnnotationDisplayFormatId = 0x20100030;

        ///<summary>(2010,0040) VR=CS VM=1 Film Orientation</summary>
        public const uint FilmOrientation = 0x20100040;

        ///<summary>(2010,0050) VR=CS VM=1 Film Size Id</summary>
        public const uint FilmSizeId = 0x20100050;

        ///<summary>(2010,0052) VR=CS VM=1 Printer Resolution Id</summary>
        public const uint PrinterResolutionId = 0x20100052;

        ///<summary>(2010,0054) VR=CS VM=1 Default Printer Resolution Id</summary>
        public const uint DefaultPrinterResolutionId = 0x20100054;

        ///<summary>(2010,0060) VR=CS VM=1 Magnification Type</summary>
        public const uint MagnificationType = 0x20100060;

        ///<summary>(2010,0080) VR=CS VM=1 Smoothing Type</summary>
        public const uint SmoothingType = 0x20100080;

        ///<summary>(2010,00A6) VR=CS VM=1 Default Magnification Type</summary>
        public const uint DefaultMagnificationType = 0x201000A6;

        ///<summary>(2010,00A7) VR=CS VM=1-n Other Magnification Types Available</summary>
        public const uint OtherMagnificationTypesAvailable = 0x201000A7;

        ///<summary>(2010,00A8) VR=CS VM=1 Default Smoothing Type</summary>
        public const uint DefaultSmoothingType = 0x201000A8;

        ///<summary>(2010,00A9) VR=CS VM=1-n Other Smoothing Types Available</summary>
        public const uint OtherSmoothingTypesAvailable = 0x201000A9;

        ///<summary>(2010,0100) VR=CS VM=1 Border Density</summary>
        public const uint BorderDensity = 0x20100100;

        ///<summary>(2010,0110) VR=CS VM=1 Empty Image Density</summary>
        public const uint EmptyImageDensity = 0x20100110;

        ///<summary>(2010,0120) VR=US VM=1 Min Density</summary>
        public const uint MinDensity = 0x20100120;

        ///<summary>(2010,0130) VR=US VM=1 Max Density</summary>
        public const uint MaxDensity = 0x20100130;

        ///<summary>(2010,0140) VR=CS VM=1 Trim</summary>
        public const uint Trim = 0x20100140;

        ///<summary>(2010,0150) VR=ST VM=1 Configuration Information</summary>
        public const uint ConfigurationInformation = 0x20100150;

        ///<summary>(2010,0152) VR=LT VM=1 Configuration Information Description</summary>
        public const uint ConfigurationInformationDescription = 0x20100152;

        ///<summary>(2010,0154) VR=IS VM=1 Maximum Collated Films</summary>
        public const uint MaximumCollatedFilms = 0x20100154;

        ///<summary>(2010,015E) VR=US VM=1 Illumination</summary>
        public const uint Illumination = 0x2010015E;

        ///<summary>(2010,0160) VR=US VM=1 Reflected Ambient Light</summary>
        public const uint ReflectedAmbientLight = 0x20100160;

        ///<summary>(2010,0376) VR=DS VM=2 Printer Pixel Spacing</summary>
        public const uint PrinterPixelSpacing = 0x20100376;

        ///<summary>(2010,0500) VR=SQ VM=1 Referenced Film Session Sequence</summary>
        public const uint ReferencedFilmSessionSequence = 0x20100500;

        ///<summary>(2010,0510) VR=SQ VM=1 Referenced Image Box Sequence</summary>
        public const uint ReferencedImageBoxSequence = 0x20100510;

        ///<summary>(2010,0520) VR=SQ VM=1 Referenced Basic Annotation Box Sequence</summary>
        public const uint ReferencedBasicAnnotationBoxSequence = 0x20100520;

        ///<summary>(2020,0010) VR=US VM=1 Image Box Position</summary>
        public const uint ImageBoxPosition = 0x20200010;

        ///<summary>(2020,0020) VR=CS VM=1 Polarity</summary>
        public const uint Polarity = 0x20200020;

        ///<summary>(2020,0030) VR=DS VM=1 Requested Image Size</summary>
        public const uint RequestedImageSize = 0x20200030;

        ///<summary>(2020,0040) VR=CS VM=1 Requested Decimate/Crop Behavior</summary>
        public const uint RequestedDecimateCropBehavior = 0x20200040;

        ///<summary>(2020,0050) VR=CS VM=1 Requested Resolution Id</summary>
        public const uint RequestedResolutionId = 0x20200050;

        ///<summary>(2020,00A0) VR=CS VM=1 Requested Image Size Flag</summary>
        public const uint RequestedImageSizeFlag = 0x202000A0;

        ///<summary>(2020,00A2) VR=CS VM=1 Decimate/Crop Result</summary>
        public const uint DecimateCropResult = 0x202000A2;

        ///<summary>(2020,0110) VR=SQ VM=1 Basic Grayscale Image Sequence</summary>
        public const uint BasicGrayscaleImageSequence = 0x20200110;

        ///<summary>(2020,0111) VR=SQ VM=1 Basic Color Image Sequence</summary>
        public const uint BasicColorImageSequence = 0x20200111;

        ///<summary>(2020,0130) VR=SQ VM=1 Referenced Image Overlay Box Sequence (RETIRED)</summary>
        public const uint ReferencedImageOverlayBoxSequenceRETIRED = 0x20200130;

        ///<summary>(2020,0140) VR=SQ VM=1 Referenced VOI LUT Box Sequence (RETIRED)</summary>
        public const uint ReferencedVOILUTBoxSequenceRETIRED = 0x20200140;

        ///<summary>(2030,0010) VR=US VM=1 Annotation Position</summary>
        public const uint AnnotationPosition = 0x20300010;

        ///<summary>(2030,0020) VR=LO VM=1 Text String</summary>
        public const uint TextString = 0x20300020;

        ///<summary>(2040,0010) VR=SQ VM=1 Referenced Overlay Plane Sequence (RETIRED)</summary>
        public const uint ReferencedOverlayPlaneSequenceRETIRED = 0x20400010;

        ///<summary>(2040,0011) VR=US VM=1-99 Referenced Overlay Plane Groups (RETIRED)</summary>
        public const uint ReferencedOverlayPlaneGroupsRETIRED = 0x20400011;

        ///<summary>(2040,0020) VR=SQ VM=1 Overlay Pixel Data Sequence (RETIRED)</summary>
        public const uint OverlayPixelDataSequenceRETIRED = 0x20400020;

        ///<summary>(2040,0060) VR=CS VM=1 Overlay Magnification Type (RETIRED)</summary>
        public const uint OverlayMagnificationTypeRETIRED = 0x20400060;

        ///<summary>(2040,0070) VR=CS VM=1 Overlay Smoothing Type (RETIRED)</summary>
        public const uint OverlaySmoothingTypeRETIRED = 0x20400070;

        ///<summary>(2040,0072) VR=CS VM=1 Overlay or Image Magnification (RETIRED)</summary>
        public const uint OverlayOrImageMagnificationRETIRED = 0x20400072;

        ///<summary>(2040,0074) VR=US VM=1 Magnify to Number of Columns (RETIRED)</summary>
        public const uint MagnifyToNumberOfColumnsRETIRED = 0x20400074;

        ///<summary>(2040,0080) VR=CS VM=1 Overlay Foreground Density (RETIRED)</summary>
        public const uint OverlayForegroundDensityRETIRED = 0x20400080;

        ///<summary>(2040,0082) VR=CS VM=1 Overlay Background Density (RETIRED)</summary>
        public const uint OverlayBackgroundDensityRETIRED = 0x20400082;

        ///<summary>(2040,0090) VR=CS VM=1 Overlay Mode (RETIRED)</summary>
        public const uint OverlayModeRETIRED = 0x20400090;

        ///<summary>(2040,0100) VR=CS VM=1 Threshold Density (RETIRED)</summary>
        public const uint ThresholdDensityRETIRED = 0x20400100;

        ///<summary>(2040,0500) VR=SQ VM=1 Referenced Image Box Sequence (Retired) (RETIRED)</summary>
        public const uint ReferencedImageBoxSequenceRetiredRETIRED = 0x20400500;

        ///<summary>(2050,0010) VR=SQ VM=1 Presentation LUT Sequence</summary>
        public const uint PresentationLUTSequence = 0x20500010;

        ///<summary>(2050,0020) VR=CS VM=1 Presentation LUT Shape</summary>
        public const uint PresentationLUTShape = 0x20500020;

        ///<summary>(2050,0500) VR=SQ VM=1 Referenced Presentation LUT Sequence</summary>
        public const uint ReferencedPresentationLUTSequence = 0x20500500;

        ///<summary>(2100,0010) VR=SH VM=1 Print Job Id (RETIRED)</summary>
        public const uint PrintJobIdRETIRED = 0x21000010;

        ///<summary>(2100,0020) VR=CS VM=1 Execution Status</summary>
        public const uint ExecutionStatus = 0x21000020;

        ///<summary>(2100,0030) VR=CS VM=1 Execution Status Info</summary>
        public const uint ExecutionStatusInfo = 0x21000030;

        ///<summary>(2100,0040) VR=DA VM=1 Creation Date</summary>
        public const uint CreationDate = 0x21000040;

        ///<summary>(2100,0050) VR=TM VM=1 Creation Time</summary>
        public const uint CreationTime = 0x21000050;

        ///<summary>(2100,0070) VR=AE VM=1 Originator</summary>
        public const uint Originator = 0x21000070;

        ///<summary>(2100,0140) VR=AE VM=1 Destination AE</summary>
        public const uint DestinationAE = 0x21000140;

        ///<summary>(2100,0160) VR=SH VM=1 Owner Id</summary>
        public const uint OwnerId = 0x21000160;

        ///<summary>(2100,0170) VR=IS VM=1 Number of Films</summary>
        public const uint NumberOfFilms = 0x21000170;

        ///<summary>(2100,0500) VR=SQ VM=1 Referenced Print Job Sequence (Pull Stored Print) (RETIRED)</summary>
        public const uint ReferencedPrintJobSequencePullStoredPrintRETIRED = 0x21000500;

        ///<summary>(2110,0010) VR=CS VM=1 Printer Status</summary>
        public const uint PrinterStatus = 0x21100010;

        ///<summary>(2110,0020) VR=CS VM=1 Printer Status Info</summary>
        public const uint PrinterStatusInfo = 0x21100020;

        ///<summary>(2110,0030) VR=LO VM=1 Printer Name</summary>
        public const uint PrinterName = 0x21100030;

        ///<summary>(2110,0099) VR=SH VM=1 Print Queue Id (RETIRED)</summary>
        public const uint PrintQueueIdRETIRED = 0x21100099;

        ///<summary>(2120,0010) VR=CS VM=1 Queue Status (RETIRED)</summary>
        public const uint QueueStatusRETIRED = 0x21200010;

        ///<summary>(2120,0050) VR=SQ VM=1 Print Job Description Sequence (RETIRED)</summary>
        public const uint PrintJobDescriptionSequenceRETIRED = 0x21200050;

        ///<summary>(2120,0070) VR=SQ VM=1 Referenced Print Job Sequence (RETIRED)</summary>
        public const uint ReferencedPrintJobSequenceRETIRED = 0x21200070;

        ///<summary>(2130,0010) VR=SQ VM=1 Print Management Capabilities Sequence (RETIRED)</summary>
        public const uint PrintManagementCapabilitiesSequenceRETIRED = 0x21300010;

        ///<summary>(2130,0015) VR=SQ VM=1 Printer Characteristics Sequence (RETIRED)</summary>
        public const uint PrinterCharacteristicsSequenceRETIRED = 0x21300015;

        ///<summary>(2130,0030) VR=SQ VM=1 Film Box Content Sequence (RETIRED)</summary>
        public const uint FilmBoxContentSequenceRETIRED = 0x21300030;

        ///<summary>(2130,0040) VR=SQ VM=1 Image Box Content Sequence (RETIRED)</summary>
        public const uint ImageBoxContentSequenceRETIRED = 0x21300040;

        ///<summary>(2130,0050) VR=SQ VM=1 Annotation Content Sequence (RETIRED)</summary>
        public const uint AnnotationContentSequenceRETIRED = 0x21300050;

        ///<summary>(2130,0060) VR=SQ VM=1 Image Overlay Box Content Sequence (RETIRED)</summary>
        public const uint ImageOverlayBoxContentSequenceRETIRED = 0x21300060;

        ///<summary>(2130,0080) VR=SQ VM=1 Presentation LUT Content Sequence (RETIRED)</summary>
        public const uint PresentationLUTContentSequenceRETIRED = 0x21300080;

        ///<summary>(2130,00A0) VR=SQ VM=1 Proposed Study Sequence (RETIRED)</summary>
        public const uint ProposedStudySequenceRETIRED = 0x213000A0;

        ///<summary>(2130,00C0) VR=SQ VM=1 Original Image Sequence (RETIRED)</summary>
        public const uint OriginalImageSequenceRETIRED = 0x213000C0;

        ///<summary>(2200,0001) VR=CS VM=1 Label Using Information Extracted From Instances</summary>
        public const uint LabelUsingInformationExtractedFromInstances = 0x22000001;

        ///<summary>(2200,0002) VR=UT VM=1 Label Text</summary>
        public const uint LabelText = 0x22000002;

        ///<summary>(2200,0003) VR=CS VM=1 Label Style Selection</summary>
        public const uint LabelStyleSelection = 0x22000003;

        ///<summary>(2200,0004) VR=LT VM=1 Media Disposition</summary>
        public const uint MediaDisposition = 0x22000004;

        ///<summary>(2200,0005) VR=LT VM=1 Barcode Value</summary>
        public const uint BarcodeValue = 0x22000005;

        ///<summary>(2200,0006) VR=CS VM=1 Barcode Symbology</summary>
        public const uint BarcodeSymbology = 0x22000006;

        ///<summary>(2200,0007) VR=CS VM=1 Allow Media Splitting</summary>
        public const uint AllowMediaSplitting = 0x22000007;

        ///<summary>(2200,0008) VR=CS VM=1 Include Non-DICOM Objects</summary>
        public const uint IncludeNonDICOMObjects = 0x22000008;

        ///<summary>(2200,0009) VR=CS VM=1 Include Display Application</summary>
        public const uint IncludeDisplayApplication = 0x22000009;

        ///<summary>(2200,000A) VR=CS VM=1 Preserve Composite Instances After Media Creation</summary>
        public const uint PreserveCompositeInstancesAfterMediaCreation = 0x2200000A;

        ///<summary>(2200,000B) VR=US VM=1 Total Number of Pieces of Media Created</summary>
        public const uint TotalNumberOfPiecesOfMediaCreated = 0x2200000B;

        ///<summary>(2200,000C) VR=LO VM=1 Requested Media Application Profile</summary>
        public const uint RequestedMediaApplicationProfile = 0x2200000C;

        ///<summary>(2200,000D) VR=SQ VM=1 Referenced Storage Media Sequence</summary>
        public const uint ReferencedStorageMediaSequence = 0x2200000D;

        ///<summary>(2200,000E) VR=AT VM=1-n Failure Attributes</summary>
        public const uint FailureAttributes = 0x2200000E;

        ///<summary>(2200,000F) VR=CS VM=1 Allow Lossy Compression</summary>
        public const uint AllowLossyCompression = 0x2200000F;

        ///<summary>(2200,0020) VR=CS VM=1 Request Priority</summary>
        public const uint RequestPriority = 0x22000020;

        ///<summary>(3002,0002) VR=SH VM=1 RT Image Label</summary>
        public const uint RTImageLabel = 0x30020002;

        ///<summary>(3002,0003) VR=LO VM=1 RT Image Name</summary>
        public const uint RTImageName = 0x30020003;

        ///<summary>(3002,0004) VR=ST VM=1 RT Image Description</summary>
        public const uint RTImageDescription = 0x30020004;

        ///<summary>(3002,000A) VR=CS VM=1 Reported Values Origin</summary>
        public const uint ReportedValuesOrigin = 0x3002000A;

        ///<summary>(3002,000C) VR=CS VM=1 RT Image Plane</summary>
        public const uint RTImagePlane = 0x3002000C;

        ///<summary>(3002,000D) VR=DS VM=3 X-Ray Image Receptor Translation</summary>
        public const uint XRayImageReceptorTranslation = 0x3002000D;

        ///<summary>(3002,000E) VR=DS VM=1 X-Ray Image Receptor Angle</summary>
        public const uint XRayImageReceptorAngle = 0x3002000E;

        ///<summary>(3002,0010) VR=DS VM=6 RT Image Orientation</summary>
        public const uint RTImageOrientation = 0x30020010;

        ///<summary>(3002,0011) VR=DS VM=2 Image Plane Pixel Spacing</summary>
        public const uint ImagePlanePixelSpacing = 0x30020011;

        ///<summary>(3002,0012) VR=DS VM=2 RT Image Position</summary>
        public const uint RTImagePosition = 0x30020012;

        ///<summary>(3002,0020) VR=SH VM=1 Radiation Machine Name</summary>
        public const uint RadiationMachineName = 0x30020020;

        ///<summary>(3002,0022) VR=DS VM=1 Radiation Machine SAD</summary>
        public const uint RadiationMachineSAD = 0x30020022;

        ///<summary>(3002,0024) VR=DS VM=1 Radiation Machine SSD</summary>
        public const uint RadiationMachineSSD = 0x30020024;

        ///<summary>(3002,0026) VR=DS VM=1 RT Image SId</summary>
        public const uint RTImageSId = 0x30020026;

        ///<summary>(3002,0028) VR=DS VM=1 Source to Reference Object Distance</summary>
        public const uint SourceToReferenceObjectDistance = 0x30020028;

        ///<summary>(3002,0029) VR=IS VM=1 Fraction Number</summary>
        public const uint FractionNumber = 0x30020029;

        ///<summary>(3002,0030) VR=SQ VM=1 Exposure Sequence</summary>
        public const uint ExposureSequence = 0x30020030;

        ///<summary>(3002,0032) VR=DS VM=1 Meterset Exposure</summary>
        public const uint MetersetExposure = 0x30020032;

        ///<summary>(3002,0034) VR=DS VM=4 Diaphragm Position</summary>
        public const uint DiaphragmPosition = 0x30020034;

        ///<summary>(3002,0040) VR=SQ VM=1 Fluence Map Sequence</summary>
        public const uint FluenceMapSequence = 0x30020040;

        ///<summary>(3002,0041) VR=CS VM=1 Fluence Data Source</summary>
        public const uint FluenceDataSource = 0x30020041;

        ///<summary>(3002,0042) VR=DS VM=1 Fluence Data Scale</summary>
        public const uint FluenceDataScale = 0x30020042;

        ///<summary>(3002,0050) VR=SQ VM=1 Primary Fluence Mode Sequence</summary>
        public const uint PrimaryFluenceModeSequence = 0x30020050;

        ///<summary>(3002,0051) VR=CS VM=1 Fluence Mode</summary>
        public const uint FluenceMode = 0x30020051;

        ///<summary>(3002,0052) VR=SH VM=1 Fluence Mode Id</summary>
        public const uint FluenceModeId = 0x30020052;

        ///<summary>(3004,0001) VR=CS VM=1 DVH Type</summary>
        public const uint DVHType = 0x30040001;

        ///<summary>(3004,0002) VR=CS VM=1 Dose Units</summary>
        public const uint DoseUnits = 0x30040002;

        ///<summary>(3004,0004) VR=CS VM=1 Dose Type</summary>
        public const uint DoseType = 0x30040004;

        ///<summary>(3004,0005) VR=CS VM=1 Spatial Transform of Dose</summary>
        public const uint SpatialTransformOfDose = 0x30040005;

        ///<summary>(3004,0006) VR=LO VM=1 Dose Comment</summary>
        public const uint DoseComment = 0x30040006;

        ///<summary>(3004,0008) VR=DS VM=3 Normalization Point</summary>
        public const uint NormalizationPoint = 0x30040008;

        ///<summary>(3004,000A) VR=CS VM=1 Dose Summation Type</summary>
        public const uint DoseSummationType = 0x3004000A;

        ///<summary>(3004,000C) VR=DS VM=2-n Grid Frame Offset Vector</summary>
        public const uint GridFrameOffsetVector = 0x3004000C;

        ///<summary>(3004,000E) VR=DS VM=1 Dose Grid Scaling</summary>
        public const uint DoseGridScaling = 0x3004000E;

        ///<summary>(3004,0010) VR=SQ VM=1 RT Dose ROI Sequence</summary>
        public const uint RTDoseROISequence = 0x30040010;

        ///<summary>(3004,0012) VR=DS VM=1 Dose Value</summary>
        public const uint DoseValue = 0x30040012;

        ///<summary>(3004,0014) VR=CS VM=1-3 Tissue Heterogeneity Correction</summary>
        public const uint TissueHeterogeneityCorrection = 0x30040014;

        ///<summary>(3004,0040) VR=DS VM=3 DVH Normalization Point</summary>
        public const uint DVHNormalizationPoint = 0x30040040;

        ///<summary>(3004,0042) VR=DS VM=1 DVH Normalization Dose Value</summary>
        public const uint DVHNormalizationDoseValue = 0x30040042;

        ///<summary>(3004,0050) VR=SQ VM=1 DVH Sequence</summary>
        public const uint DVHSequence = 0x30040050;

        ///<summary>(3004,0052) VR=DS VM=1 DVH Dose Scaling</summary>
        public const uint DVHDoseScaling = 0x30040052;

        ///<summary>(3004,0054) VR=CS VM=1 DVH Volume Units</summary>
        public const uint DVHVolumeUnits = 0x30040054;

        ///<summary>(3004,0056) VR=IS VM=1 DVH Number of Bins</summary>
        public const uint DVHNumberOfBins = 0x30040056;

        ///<summary>(3004,0058) VR=DS VM=2-2n DVH Data</summary>
        public const uint DVHData = 0x30040058;

        ///<summary>(3004,0060) VR=SQ VM=1 DVH Referenced ROI Sequence</summary>
        public const uint DVHReferencedROISequence = 0x30040060;

        ///<summary>(3004,0062) VR=CS VM=1 DVH ROI Contribution Type</summary>
        public const uint DVHROIContributionType = 0x30040062;

        ///<summary>(3004,0070) VR=DS VM=1 DVH Minimum Dose</summary>
        public const uint DVHMinimumDose = 0x30040070;

        ///<summary>(3004,0072) VR=DS VM=1 DVH Maximum Dose</summary>
        public const uint DVHMaximumDose = 0x30040072;

        ///<summary>(3004,0074) VR=DS VM=1 DVH Mean Dose</summary>
        public const uint DVHMeanDose = 0x30040074;

        ///<summary>(3006,0002) VR=SH VM=1 Structure Set Label</summary>
        public const uint StructureSetLabel = 0x30060002;

        ///<summary>(3006,0004) VR=LO VM=1 Structure Set Name</summary>
        public const uint StructureSetName = 0x30060004;

        ///<summary>(3006,0006) VR=ST VM=1 Structure Set Description</summary>
        public const uint StructureSetDescription = 0x30060006;

        ///<summary>(3006,0008) VR=DA VM=1 Structure Set Date</summary>
        public const uint StructureSetDate = 0x30060008;

        ///<summary>(3006,0009) VR=TM VM=1 Structure Set Time</summary>
        public const uint StructureSetTime = 0x30060009;

        ///<summary>(3006,0010) VR=SQ VM=1 Referenced Frame of Reference Sequence</summary>
        public const uint ReferencedFrameOfReferenceSequence = 0x30060010;

        ///<summary>(3006,0012) VR=SQ VM=1 RT Referenced Study Sequence</summary>
        public const uint RTReferencedStudySequence = 0x30060012;

        ///<summary>(3006,0014) VR=SQ VM=1 RT Referenced Series Sequence</summary>
        public const uint RTReferencedSeriesSequence = 0x30060014;

        ///<summary>(3006,0016) VR=SQ VM=1 Contour Image Sequence</summary>
        public const uint ContourImageSequence = 0x30060016;

        ///<summary>(3006,0018) VR=SQ VM=1 Predecessor Structure Set Sequence</summary>
        public const uint PredecessorStructureSetSequence = 0x30060018;

        ///<summary>(3006,0020) VR=SQ VM=1 Structure Set ROI Sequence</summary>
        public const uint StructureSetROISequence = 0x30060020;

        ///<summary>(3006,0022) VR=IS VM=1 ROI Number</summary>
        public const uint ROINumber = 0x30060022;

        ///<summary>(3006,0024) VR=UI VM=1 Referenced Frame of Reference Uid</summary>
        public const uint ReferencedFrameOfReferenceUid = 0x30060024;

        ///<summary>(3006,0026) VR=LO VM=1 ROI Name</summary>
        public const uint ROIName = 0x30060026;

        ///<summary>(3006,0028) VR=ST VM=1 ROI Description</summary>
        public const uint ROIdescription = 0x30060028;

        ///<summary>(3006,002A) VR=IS VM=3 ROI Display Color</summary>
        public const uint ROIdisplayColor = 0x3006002A;

        ///<summary>(3006,002C) VR=DS VM=1 ROI Volume</summary>
        public const uint ROIVolume = 0x3006002C;

        ///<summary>(3006,0030) VR=SQ VM=1 RT Related ROI Sequence</summary>
        public const uint RTRelatedROISequence = 0x30060030;

        ///<summary>(3006,0033) VR=CS VM=1 RT ROI Relationship</summary>
        public const uint RTROIRelationship = 0x30060033;

        ///<summary>(3006,0036) VR=CS VM=1 ROI Generation Algorithm</summary>
        public const uint ROIGenerationAlgorithm = 0x30060036;

        ///<summary>(3006,0037) VR=SQ VM=1 ROI Derivation Algorithm Identification Sequence</summary>
        public const uint ROIderivationAlgorithmIdentificationSequence = 0x30060037;

        ///<summary>(3006,0038) VR=LO VM=1 ROI Generation Description</summary>
        public const uint ROIGenerationDescription = 0x30060038;

        ///<summary>(3006,0039) VR=SQ VM=1 ROI Contour Sequence</summary>
        public const uint ROIContourSequence = 0x30060039;

        ///<summary>(3006,0040) VR=SQ VM=1 Contour Sequence</summary>
        public const uint ContourSequence = 0x30060040;

        ///<summary>(3006,0042) VR=CS VM=1 Contour Geometric Type</summary>
        public const uint ContourGeometricType = 0x30060042;

        ///<summary>(3006,0044) VR=DS VM=1 Contour Slab Thickness (RETIRED)</summary>
        public const uint ContourSlabThicknessRETIRED = 0x30060044;

        ///<summary>(3006,0045) VR=DS VM=3 Contour Offset Vector (RETIRED)</summary>
        public const uint ContourOffsetVectorRETIRED = 0x30060045;

        ///<summary>(3006,0046) VR=IS VM=1 Number of Contour Points</summary>
        public const uint NumberOfContourPoints = 0x30060046;

        ///<summary>(3006,0048) VR=IS VM=1 Contour Number</summary>
        public const uint ContourNumber = 0x30060048;

        ///<summary>(3006,0049) VR=IS VM=1-n Attached Contours (RETIRED)</summary>
        public const uint AttachedContoursRETIRED = 0x30060049;

        ///<summary>(3006,004A) VR=SQ VM=1 Source Pixel Planes Characteristics Sequence</summary>
        public const uint SourcePixelPlanesCharacteristicsSequence = 0x3006004A;

        ///<summary>(3006,0050) VR=DS VM=3-3n Contour Data</summary>
        public const uint ContourData = 0x30060050;

        ///<summary>(3006,0080) VR=SQ VM=1 RT ROI Observations Sequence</summary>
        public const uint RTROIObservationsSequence = 0x30060080;

        ///<summary>(3006,0082) VR=IS VM=1 Observation Number</summary>
        public const uint ObservationNumber = 0x30060082;

        ///<summary>(3006,0084) VR=IS VM=1 Referenced ROI Number</summary>
        public const uint ReferencedROINumber = 0x30060084;

        ///<summary>(3006,0085) VR=SH VM=1 ROI Observation Label</summary>
        public const uint ROIObservationLabel = 0x30060085;

        ///<summary>(3006,0086) VR=SQ VM=1 RT ROI Identification Code Sequence</summary>
        public const uint RTROIIdentificationCodeSequence = 0x30060086;

        ///<summary>(3006,0088) VR=ST VM=1 ROI Observation Description</summary>
        public const uint ROIObservationDescription = 0x30060088;

        ///<summary>(3006,00A0) VR=SQ VM=1 Related RT ROI Observations Sequence</summary>
        public const uint RelatedRTROIObservationsSequence = 0x300600A0;

        ///<summary>(3006,00A4) VR=CS VM=1 RT ROI Interpreted Type</summary>
        public const uint RTROIInterpretedType = 0x300600A4;

        ///<summary>(3006,00A6) VR=PN VM=1 ROI Interpreter</summary>
        public const uint ROIInterpreter = 0x300600A6;

        ///<summary>(3006,00B0) VR=SQ VM=1 ROI Physical Properties Sequence</summary>
        public const uint ROIPhysicalPropertiesSequence = 0x300600B0;

        ///<summary>(3006,00B2) VR=CS VM=1 ROI Physical Property</summary>
        public const uint ROIPhysicalProperty = 0x300600B2;

        ///<summary>(3006,00B4) VR=DS VM=1 ROI Physical Property Value</summary>
        public const uint ROIPhysicalPropertyValue = 0x300600B4;

        ///<summary>(3006,00B6) VR=SQ VM=1 ROI Elemental Composition Sequence</summary>
        public const uint ROIElementalCompositionSequence = 0x300600B6;

        ///<summary>(3006,00B7) VR=US VM=1 ROI Elemental Composition Atomic Number</summary>
        public const uint ROIElementalCompositionAtomicNumber = 0x300600B7;

        ///<summary>(3006,00B8) VR=FL VM=1 ROI Elemental Composition Atomic Mass Fraction</summary>
        public const uint ROIElementalCompositionAtomicMassFraction = 0x300600B8;

        ///<summary>(3006,00B9) VR=SQ VM=1 Additional RT ROI Identification Code Sequence (RETIRED)</summary>
        public const uint AdditionalRTROIIdentificationCodeSequenceRETIRED = 0x300600B9;

        ///<summary>(3006,00C0) VR=SQ VM=1 Frame of Reference Relationship Sequence (RETIRED)</summary>
        public const uint FrameOfReferenceRelationshipSequenceRETIRED = 0x300600C0;

        ///<summary>(3006,00C2) VR=UI VM=1 Related Frame of Reference Uid (RETIRED)</summary>
        public const uint RelatedFrameOfReferenceUidRETIRED = 0x300600C2;

        ///<summary>(3006,00C4) VR=CS VM=1 Frame of Reference Transformation Type (RETIRED)</summary>
        public const uint FrameOfReferenceTransformationTypeRETIRED = 0x300600C4;

        ///<summary>(3006,00C6) VR=DS VM=16 Frame of Reference Transformation Matrix</summary>
        public const uint FrameOfReferenceTransformationMatrix = 0x300600C6;

        ///<summary>(3006,00C8) VR=LO VM=1 Frame of Reference Transformation Comment</summary>
        public const uint FrameOfReferenceTransformationComment = 0x300600C8;

        ///<summary>(3006,00C9) VR=SQ VM=1 Patient Location Coordinates Sequence</summary>
        public const uint PatientLocationCoordinatesSequence = 0x300600C9;

        ///<summary>(3006,00CA) VR=SQ VM=1 Patient Location Coordinates Code Sequence</summary>
        public const uint PatientLocationCoordinatesCodeSequence = 0x300600CA;

        ///<summary>(3006,00CB) VR=SQ VM=1 Patient Support Position Sequence</summary>
        public const uint PatientSupportPositionSequence = 0x300600CB;

        ///<summary>(3008,0010) VR=SQ VM=1 Measured Dose Reference Sequence</summary>
        public const uint MeasuredDoseReferenceSequence = 0x30080010;

        ///<summary>(3008,0012) VR=ST VM=1 Measured Dose Description</summary>
        public const uint MeasuredDoseDescription = 0x30080012;

        ///<summary>(3008,0014) VR=CS VM=1 Measured Dose Type</summary>
        public const uint MeasuredDoseType = 0x30080014;

        ///<summary>(3008,0016) VR=DS VM=1 Measured Dose Value</summary>
        public const uint MeasuredDoseValue = 0x30080016;

        ///<summary>(3008,0020) VR=SQ VM=1 Treatment Session Beam Sequence</summary>
        public const uint TreatmentSessionBeamSequence = 0x30080020;

        ///<summary>(3008,0021) VR=SQ VM=1 Treatment Session Ion Beam Sequence</summary>
        public const uint TreatmentSessionIonBeamSequence = 0x30080021;

        ///<summary>(3008,0022) VR=IS VM=1 Current Fraction Number</summary>
        public const uint CurrentFractionNumber = 0x30080022;

        ///<summary>(3008,0024) VR=DA VM=1 Treatment Control Point Date</summary>
        public const uint TreatmentControlPointDate = 0x30080024;

        ///<summary>(3008,0025) VR=TM VM=1 Treatment Control Point Time</summary>
        public const uint TreatmentControlPointTime = 0x30080025;

        ///<summary>(3008,002A) VR=CS VM=1 Treatment Termination Status</summary>
        public const uint TreatmentTerminationStatus = 0x3008002A;

        ///<summary>(3008,002B) VR=SH VM=1 Treatment Termination Code</summary>
        public const uint TreatmentTerminationCode = 0x3008002B;

        ///<summary>(3008,002C) VR=CS VM=1 Treatment Verification Status</summary>
        public const uint TreatmentVerificationStatus = 0x3008002C;

        ///<summary>(3008,0030) VR=SQ VM=1 Referenced Treatment Record Sequence</summary>
        public const uint ReferencedTreatmentRecordSequence = 0x30080030;

        ///<summary>(3008,0032) VR=DS VM=1 Specified Primary Meterset</summary>
        public const uint SpecifiedPrimaryMeterset = 0x30080032;

        ///<summary>(3008,0033) VR=DS VM=1 Specified Secondary Meterset</summary>
        public const uint SpecifiedSecondaryMeterset = 0x30080033;

        ///<summary>(3008,0036) VR=DS VM=1 Delivered Primary Meterset</summary>
        public const uint DeliveredPrimaryMeterset = 0x30080036;

        ///<summary>(3008,0037) VR=DS VM=1 Delivered Secondary Meterset</summary>
        public const uint DeliveredSecondaryMeterset = 0x30080037;

        ///<summary>(3008,003A) VR=DS VM=1 Specified Treatment Time</summary>
        public const uint SpecifiedTreatmentTime = 0x3008003A;

        ///<summary>(3008,003B) VR=DS VM=1 Delivered Treatment Time</summary>
        public const uint DeliveredTreatmentTime = 0x3008003B;

        ///<summary>(3008,0040) VR=SQ VM=1 Control Point Delivery Sequence</summary>
        public const uint ControlPointDeliverySequence = 0x30080040;

        ///<summary>(3008,0041) VR=SQ VM=1 Ion Control Point Delivery Sequence</summary>
        public const uint IonControlPointDeliverySequence = 0x30080041;

        ///<summary>(3008,0042) VR=DS VM=1 Specified Meterset</summary>
        public const uint SpecifiedMeterset = 0x30080042;

        ///<summary>(3008,0044) VR=DS VM=1 Delivered Meterset</summary>
        public const uint DeliveredMeterset = 0x30080044;

        ///<summary>(3008,0045) VR=FL VM=1 Meterset Rate Set</summary>
        public const uint MetersetRateSet = 0x30080045;

        ///<summary>(3008,0046) VR=FL VM=1 Meterset Rate Delivered</summary>
        public const uint MetersetRateDelivered = 0x30080046;

        ///<summary>(3008,0047) VR=FL VM=1-n Scan Spot Metersets Delivered</summary>
        public const uint ScanSpotMetersetsDelivered = 0x30080047;

        ///<summary>(3008,0048) VR=DS VM=1 Dose Rate Delivered</summary>
        public const uint DoseRateDelivered = 0x30080048;

        ///<summary>(3008,0050) VR=SQ VM=1 Treatment Summary Calculated Dose Reference Sequence</summary>
        public const uint TreatmentSummaryCalculatedDoseReferenceSequence = 0x30080050;

        ///<summary>(3008,0052) VR=DS VM=1 Cumulative Dose to Dose Reference</summary>
        public const uint CumulativeDoseToDoseReference = 0x30080052;

        ///<summary>(3008,0054) VR=DA VM=1 First Treatment Date</summary>
        public const uint FirstTreatmentDate = 0x30080054;

        ///<summary>(3008,0056) VR=DA VM=1 Most Recent Treatment Date</summary>
        public const uint MostRecentTreatmentDate = 0x30080056;

        ///<summary>(3008,005A) VR=IS VM=1 Number of Fractions Delivered</summary>
        public const uint NumberOfFractionsDelivered = 0x3008005A;

        ///<summary>(3008,0060) VR=SQ VM=1 Override Sequence</summary>
        public const uint OverrideSequence = 0x30080060;

        ///<summary>(3008,0061) VR=AT VM=1 Parameter Sequence Pointer</summary>
        public const uint ParameterSequencePointer = 0x30080061;

        ///<summary>(3008,0062) VR=AT VM=1 Override Parameter Pointer</summary>
        public const uint OverrideParameterPointer = 0x30080062;

        ///<summary>(3008,0063) VR=IS VM=1 Parameter Item Index</summary>
        public const uint ParameterItemIndex = 0x30080063;

        ///<summary>(3008,0064) VR=IS VM=1 Measured Dose Reference Number</summary>
        public const uint MeasuredDoseReferenceNumber = 0x30080064;

        ///<summary>(3008,0065) VR=AT VM=1 Parameter Pointer</summary>
        public const uint ParameterPointer = 0x30080065;

        ///<summary>(3008,0066) VR=ST VM=1 Override Reason</summary>
        public const uint OverrideReason = 0x30080066;

        ///<summary>(3008,0067) VR=US VM=1 Parameter Value Number</summary>
        public const uint ParameterValueNumber = 0x30080067;

        ///<summary>(3008,0068) VR=SQ VM=1 Corrected Parameter Sequence</summary>
        public const uint CorrectedParameterSequence = 0x30080068;

        ///<summary>(3008,006A) VR=FL VM=1 Correction Value</summary>
        public const uint CorrectionValue = 0x3008006A;

        ///<summary>(3008,0070) VR=SQ VM=1 Calculated Dose Reference Sequence</summary>
        public const uint CalculatedDoseReferenceSequence = 0x30080070;

        ///<summary>(3008,0072) VR=IS VM=1 Calculated Dose Reference Number</summary>
        public const uint CalculatedDoseReferenceNumber = 0x30080072;

        ///<summary>(3008,0074) VR=ST VM=1 Calculated Dose Reference Description</summary>
        public const uint CalculatedDoseReferenceDescription = 0x30080074;

        ///<summary>(3008,0076) VR=DS VM=1 Calculated Dose Reference Dose Value</summary>
        public const uint CalculatedDoseReferenceDoseValue = 0x30080076;

        ///<summary>(3008,0078) VR=DS VM=1 Start Meterset</summary>
        public const uint StartMeterset = 0x30080078;

        ///<summary>(3008,007A) VR=DS VM=1 End Meterset</summary>
        public const uint EndMeterset = 0x3008007A;

        ///<summary>(3008,0080) VR=SQ VM=1 Referenced Measured Dose Reference Sequence</summary>
        public const uint ReferencedMeasuredDoseReferenceSequence = 0x30080080;

        ///<summary>(3008,0082) VR=IS VM=1 Referenced Measured Dose Reference Number</summary>
        public const uint ReferencedMeasuredDoseReferenceNumber = 0x30080082;

        ///<summary>(3008,0090) VR=SQ VM=1 Referenced Calculated Dose Reference Sequence</summary>
        public const uint ReferencedCalculatedDoseReferenceSequence = 0x30080090;

        ///<summary>(3008,0092) VR=IS VM=1 Referenced Calculated Dose Reference Number</summary>
        public const uint ReferencedCalculatedDoseReferenceNumber = 0x30080092;

        ///<summary>(3008,00A0) VR=SQ VM=1 Beam Limiting Device Leaf Pairs Sequence</summary>
        public const uint BeamLimitingDeviceLeafPairsSequence = 0x300800A0;

        ///<summary>(3008,00B0) VR=SQ VM=1 Recorded Wedge Sequence</summary>
        public const uint RecordedWedgeSequence = 0x300800B0;

        ///<summary>(3008,00C0) VR=SQ VM=1 Recorded Compensator Sequence</summary>
        public const uint RecordedCompensatorSequence = 0x300800C0;

        ///<summary>(3008,00D0) VR=SQ VM=1 Recorded Block Sequence</summary>
        public const uint RecordedBlockSequence = 0x300800D0;

        ///<summary>(3008,00E0) VR=SQ VM=1 Treatment Summary Measured Dose Reference Sequence</summary>
        public const uint TreatmentSummaryMeasuredDoseReferenceSequence = 0x300800E0;

        ///<summary>(3008,00F0) VR=SQ VM=1 Recorded Snout Sequence</summary>
        public const uint RecordedSnoutSequence = 0x300800F0;

        ///<summary>(3008,00F2) VR=SQ VM=1 Recorded Range Shifter Sequence</summary>
        public const uint RecordedRangeShifterSequence = 0x300800F2;

        ///<summary>(3008,00F4) VR=SQ VM=1 Recorded Lateral Spreading Device Sequence</summary>
        public const uint RecordedLateralSpreadingDeviceSequence = 0x300800F4;

        ///<summary>(3008,00F6) VR=SQ VM=1 Recorded Range Modulator Sequence</summary>
        public const uint RecordedRangeModulatorSequence = 0x300800F6;

        ///<summary>(3008,0100) VR=SQ VM=1 Recorded Source Sequence</summary>
        public const uint RecordedSourceSequence = 0x30080100;

        ///<summary>(3008,0105) VR=LO VM=1 Source Serial Number</summary>
        public const uint SourceSerialNumber = 0x30080105;

        ///<summary>(3008,0110) VR=SQ VM=1 Treatment Session Application Setup Sequence</summary>
        public const uint TreatmentSessionApplicationSetupSequence = 0x30080110;

        ///<summary>(3008,0116) VR=CS VM=1 Application Setup Check</summary>
        public const uint ApplicationSetupCheck = 0x30080116;

        ///<summary>(3008,0120) VR=SQ VM=1 Recorded Brachy Accessory Device Sequence</summary>
        public const uint RecordedBrachyAccessoryDeviceSequence = 0x30080120;

        ///<summary>(3008,0122) VR=IS VM=1 Referenced Brachy Accessory Device Number</summary>
        public const uint ReferencedBrachyAccessoryDeviceNumber = 0x30080122;

        ///<summary>(3008,0130) VR=SQ VM=1 Recorded Channel Sequence</summary>
        public const uint RecordedChannelSequence = 0x30080130;

        ///<summary>(3008,0132) VR=DS VM=1 Specified Channel Total Time</summary>
        public const uint SpecifiedChannelTotalTime = 0x30080132;

        ///<summary>(3008,0134) VR=DS VM=1 Delivered Channel Total Time</summary>
        public const uint DeliveredChannelTotalTime = 0x30080134;

        ///<summary>(3008,0136) VR=IS VM=1 Specified Number of Pulses</summary>
        public const uint SpecifiedNumberOfPulses = 0x30080136;

        ///<summary>(3008,0138) VR=IS VM=1 Delivered Number of Pulses</summary>
        public const uint DeliveredNumberOfPulses = 0x30080138;

        ///<summary>(3008,013A) VR=DS VM=1 Specified Pulse Repetition Interval</summary>
        public const uint SpecifiedPulseRepetitionInterval = 0x3008013A;

        ///<summary>(3008,013C) VR=DS VM=1 Delivered Pulse Repetition Interval</summary>
        public const uint DeliveredPulseRepetitionInterval = 0x3008013C;

        ///<summary>(3008,0140) VR=SQ VM=1 Recorded Source Applicator Sequence</summary>
        public const uint RecordedSourceApplicatorSequence = 0x30080140;

        ///<summary>(3008,0142) VR=IS VM=1 Referenced Source Applicator Number</summary>
        public const uint ReferencedSourceApplicatorNumber = 0x30080142;

        ///<summary>(3008,0150) VR=SQ VM=1 Recorded Channel Shield Sequence</summary>
        public const uint RecordedChannelShieldSequence = 0x30080150;

        ///<summary>(3008,0152) VR=IS VM=1 Referenced Channel Shield Number</summary>
        public const uint ReferencedChannelShieldNumber = 0x30080152;

        ///<summary>(3008,0160) VR=SQ VM=1 Brachy Control Point Delivered Sequence</summary>
        public const uint BrachyControlPointDeliveredSequence = 0x30080160;

        ///<summary>(3008,0162) VR=DA VM=1 Safe Position Exit Date</summary>
        public const uint SafePositionExitDate = 0x30080162;

        ///<summary>(3008,0164) VR=TM VM=1 Safe Position Exit Time</summary>
        public const uint SafePositionExitTime = 0x30080164;

        ///<summary>(3008,0166) VR=DA VM=1 Safe Position Return Date</summary>
        public const uint SafePositionReturnDate = 0x30080166;

        ///<summary>(3008,0168) VR=TM VM=1 Safe Position Return Time</summary>
        public const uint SafePositionReturnTime = 0x30080168;

        ///<summary>(3008,0171) VR=SQ VM=1 Pulse Specific Brachy Control Point Delivered Sequence</summary>
        public const uint PulseSpecificBrachyControlPointDeliveredSequence = 0x30080171;

        ///<summary>(3008,0172) VR=US VM=1 Pulse Number</summary>
        public const uint PulseNumber = 0x30080172;

        ///<summary>(3008,0173) VR=SQ VM=1 Brachy Pulse Control Point Delivered Sequence</summary>
        public const uint BrachyPulseControlPointDeliveredSequence = 0x30080173;

        ///<summary>(3008,0200) VR=CS VM=1 Current Treatment Status</summary>
        public const uint CurrentTreatmentStatus = 0x30080200;

        ///<summary>(3008,0202) VR=ST VM=1 Treatment Status Comment</summary>
        public const uint TreatmentStatusComment = 0x30080202;

        ///<summary>(3008,0220) VR=SQ VM=1 Fraction Group Summary Sequence</summary>
        public const uint FractionGroupSummarySequence = 0x30080220;

        ///<summary>(3008,0223) VR=IS VM=1 Referenced Fraction Number</summary>
        public const uint ReferencedFractionNumber = 0x30080223;

        ///<summary>(3008,0224) VR=CS VM=1 Fraction Group Type</summary>
        public const uint FractionGroupType = 0x30080224;

        ///<summary>(3008,0230) VR=CS VM=1 Beam Stopper Position</summary>
        public const uint BeamStopperPosition = 0x30080230;

        ///<summary>(3008,0240) VR=SQ VM=1 Fraction Status Summary Sequence</summary>
        public const uint FractionStatusSummarySequence = 0x30080240;

        ///<summary>(3008,0250) VR=DA VM=1 Treatment Date</summary>
        public const uint TreatmentDate = 0x30080250;

        ///<summary>(3008,0251) VR=TM VM=1 Treatment Time</summary>
        public const uint TreatmentTime = 0x30080251;

        ///<summary>(300A,0002) VR=SH VM=1 RT Plan Label</summary>
        public const uint RTPlanLabel = 0x300A0002;

        ///<summary>(300A,0003) VR=LO VM=1 RT Plan Name</summary>
        public const uint RTPlanName = 0x300A0003;

        ///<summary>(300A,0004) VR=ST VM=1 RT Plan Description</summary>
        public const uint RTPlanDescription = 0x300A0004;

        ///<summary>(300A,0006) VR=DA VM=1 RT Plan Date</summary>
        public const uint RTPlanDate = 0x300A0006;

        ///<summary>(300A,0007) VR=TM VM=1 RT Plan Time</summary>
        public const uint RTPlanTime = 0x300A0007;

        ///<summary>(300A,0009) VR=LO VM=1-n Treatment Protocols</summary>
        public const uint TreatmentProtocols = 0x300A0009;

        ///<summary>(300A,000A) VR=CS VM=1 Plan Intent</summary>
        public const uint PlanIntent = 0x300A000A;

        ///<summary>(300A,000B) VR=LO VM=1-n Treatment Sites</summary>
        public const uint TreatmentSites = 0x300A000B;

        ///<summary>(300A,000C) VR=CS VM=1 RT Plan Geometry</summary>
        public const uint RTPlanGeometry = 0x300A000C;

        ///<summary>(300A,000E) VR=ST VM=1 Prescription Description</summary>
        public const uint PrescriptionDescription = 0x300A000E;

        ///<summary>(300A,0010) VR=SQ VM=1 Dose Reference Sequence</summary>
        public const uint DoseReferenceSequence = 0x300A0010;

        ///<summary>(300A,0012) VR=IS VM=1 Dose Reference Number</summary>
        public const uint DoseReferenceNumber = 0x300A0012;

        ///<summary>(300A,0013) VR=UI VM=1 Dose Reference Uid</summary>
        public const uint DoseReferenceUid = 0x300A0013;

        ///<summary>(300A,0014) VR=CS VM=1 Dose Reference Structure Type</summary>
        public const uint DoseReferenceStructureType = 0x300A0014;

        ///<summary>(300A,0015) VR=CS VM=1 Nominal Beam Energy Unit</summary>
        public const uint NominalBeamEnergyUnit = 0x300A0015;

        ///<summary>(300A,0016) VR=LO VM=1 Dose Reference Description</summary>
        public const uint DoseReferenceDescription = 0x300A0016;

        ///<summary>(300A,0018) VR=DS VM=3 Dose Reference Point Coordinates</summary>
        public const uint DoseReferencePointCoordinates = 0x300A0018;

        ///<summary>(300A,001A) VR=DS VM=1 Nominal Prior Dose</summary>
        public const uint NominalPriorDose = 0x300A001A;

        ///<summary>(300A,0020) VR=CS VM=1 Dose Reference Type</summary>
        public const uint DoseReferenceType = 0x300A0020;

        ///<summary>(300A,0021) VR=DS VM=1 Constraint Weight</summary>
        public const uint ConstraintWeight = 0x300A0021;

        ///<summary>(300A,0022) VR=DS VM=1 Delivery Warning Dose</summary>
        public const uint DeliveryWarningDose = 0x300A0022;

        ///<summary>(300A,0023) VR=DS VM=1 Delivery Maximum Dose</summary>
        public const uint DeliveryMaximumDose = 0x300A0023;

        ///<summary>(300A,0025) VR=DS VM=1 Target Minimum Dose</summary>
        public const uint TargetMinimumDose = 0x300A0025;

        ///<summary>(300A,0026) VR=DS VM=1 Target Prescription Dose</summary>
        public const uint TargetPrescriptionDose = 0x300A0026;

        ///<summary>(300A,0027) VR=DS VM=1 Target Maximum Dose</summary>
        public const uint TargetMaximumDose = 0x300A0027;

        ///<summary>(300A,0028) VR=DS VM=1 Target Underdose Volume Fraction</summary>
        public const uint TargetUnderdoseVolumeFraction = 0x300A0028;

        ///<summary>(300A,002A) VR=DS VM=1 Organ at Risk Full-volume Dose</summary>
        public const uint OrganAtRiskFullVolumeDose = 0x300A002A;

        ///<summary>(300A,002B) VR=DS VM=1 Organ at Risk Limit Dose</summary>
        public const uint OrganAtRiskLimitDose = 0x300A002B;

        ///<summary>(300A,002C) VR=DS VM=1 Organ at Risk Maximum Dose</summary>
        public const uint OrganAtRiskMaximumDose = 0x300A002C;

        ///<summary>(300A,002D) VR=DS VM=1 Organ at Risk Overdose Volume Fraction</summary>
        public const uint OrganAtRiskOverdoseVolumeFraction = 0x300A002D;

        ///<summary>(300A,0040) VR=SQ VM=1 Tolerance Table Sequence</summary>
        public const uint ToleranceTableSequence = 0x300A0040;

        ///<summary>(300A,0042) VR=IS VM=1 Tolerance Table Number</summary>
        public const uint ToleranceTableNumber = 0x300A0042;

        ///<summary>(300A,0043) VR=SH VM=1 Tolerance Table Label</summary>
        public const uint ToleranceTableLabel = 0x300A0043;

        ///<summary>(300A,0044) VR=DS VM=1 Gantry Angle Tolerance</summary>
        public const uint GantryAngleTolerance = 0x300A0044;

        ///<summary>(300A,0046) VR=DS VM=1 Beam Limiting Device Angle Tolerance</summary>
        public const uint BeamLimitingDeviceAngleTolerance = 0x300A0046;

        ///<summary>(300A,0048) VR=SQ VM=1 Beam Limiting Device Tolerance Sequence</summary>
        public const uint BeamLimitingDeviceToleranceSequence = 0x300A0048;

        ///<summary>(300A,004A) VR=DS VM=1 Beam Limiting Device Position Tolerance</summary>
        public const uint BeamLimitingDevicePositionTolerance = 0x300A004A;

        ///<summary>(300A,004B) VR=FL VM=1 Snout Position Tolerance</summary>
        public const uint SnoutPositionTolerance = 0x300A004B;

        ///<summary>(300A,004C) VR=DS VM=1 Patient Support Angle Tolerance</summary>
        public const uint PatientSupportAngleTolerance = 0x300A004C;

        ///<summary>(300A,004E) VR=DS VM=1 Table Top Eccentric Angle Tolerance</summary>
        public const uint TableTopEccentricAngleTolerance = 0x300A004E;

        ///<summary>(300A,004F) VR=FL VM=1 Table Top Pitch Angle Tolerance</summary>
        public const uint TableTopPitchAngleTolerance = 0x300A004F;

        ///<summary>(300A,0050) VR=FL VM=1 Table Top Roll Angle Tolerance</summary>
        public const uint TableTopRollAngleTolerance = 0x300A0050;

        ///<summary>(300A,0051) VR=DS VM=1 Table Top Vertical Position Tolerance</summary>
        public const uint TableTopVerticalPositionTolerance = 0x300A0051;

        ///<summary>(300A,0052) VR=DS VM=1 Table Top Longitudinal Position Tolerance</summary>
        public const uint TableTopLongitudinalPositionTolerance = 0x300A0052;

        ///<summary>(300A,0053) VR=DS VM=1 Table Top Lateral Position Tolerance</summary>
        public const uint TableTopLateralPositionTolerance = 0x300A0053;

        ///<summary>(300A,0055) VR=CS VM=1 RT Plan Relationship</summary>
        public const uint RTPlanRelationship = 0x300A0055;

        ///<summary>(300A,0070) VR=SQ VM=1 Fraction Group Sequence</summary>
        public const uint FractionGroupSequence = 0x300A0070;

        ///<summary>(300A,0071) VR=IS VM=1 Fraction Group Number</summary>
        public const uint FractionGroupNumber = 0x300A0071;

        ///<summary>(300A,0072) VR=LO VM=1 Fraction Group Description</summary>
        public const uint FractionGroupDescription = 0x300A0072;

        ///<summary>(300A,0078) VR=IS VM=1 Number of Fractions Planned</summary>
        public const uint NumberOfFractionsPlanned = 0x300A0078;

        ///<summary>(300A,0079) VR=IS VM=1 Number of Fraction Pattern Digits Per Day</summary>
        public const uint NumberOfFractionPatternDigitsPerDay = 0x300A0079;

        ///<summary>(300A,007A) VR=IS VM=1 Repeat Fraction Cycle Length</summary>
        public const uint RepeatFractionCycleLength = 0x300A007A;

        ///<summary>(300A,007B) VR=LT VM=1 Fraction Pattern</summary>
        public const uint FractionPattern = 0x300A007B;

        ///<summary>(300A,0080) VR=IS VM=1 Number of Beams</summary>
        public const uint NumberOfBeams = 0x300A0080;

        ///<summary>(300A,0082) VR=DS VM=3 Beam Dose Specification Point (RETIRED)</summary>
        public const uint BeamDoseSpecificationPointRETIRED = 0x300A0082;

        ///<summary>(300A,0083) VR=UI VM=1 Referenced Dose Reference Uid</summary>
        public const uint ReferencedDoseReferenceUid = 0x300A0083;

        ///<summary>(300A,0084) VR=DS VM=1 Beam Dose</summary>
        public const uint BeamDose = 0x300A0084;

        ///<summary>(300A,0086) VR=DS VM=1 Beam Meterset</summary>
        public const uint BeamMeterset = 0x300A0086;

        ///<summary>(300A,0088) VR=FL VM=1 Beam Dose Point Depth</summary>
        public const uint BeamDosePointDepth = 0x300A0088;

        ///<summary>(300A,0089) VR=FL VM=1 Beam Dose Point Equivalent Depth</summary>
        public const uint BeamDosePointEquivalentDepth = 0x300A0089;

        ///<summary>(300A,008A) VR=FL VM=1 Beam Dose Point SSD</summary>
        public const uint BeamDosePointSSD = 0x300A008A;

        ///<summary>(300A,008B) VR=CS VM=1 Beam Dose Meaning</summary>
        public const uint BeamDoseMeaning = 0x300A008B;

        ///<summary>(300A,008C) VR=SQ VM=1 Beam Dose Verification Control Point Sequence</summary>
        public const uint BeamDoseVerificationControlPointSequence = 0x300A008C;

        ///<summary>(300A,008D) VR=FL VM=1 Average Beam Dose Point Depth (RETIRED)</summary>
        public const uint AverageBeamDosePointDepthRETIRED = 0x300A008D;

        ///<summary>(300A,008E) VR=FL VM=1 Average Beam Dose Point Equivalent Depth (RETIRED)</summary>
        public const uint AverageBeamDosePointEquivalentDepthRETIRED = 0x300A008E;

        ///<summary>(300A,008F) VR=FL VM=1 Average Beam Dose Point SSD (RETIRED)</summary>
        public const uint AverageBeamDosePointSSDRETIRED = 0x300A008F;

        ///<summary>(300A,0090) VR=CS VM=1 Beam Dose Type</summary>
        public const uint BeamDoseType = 0x300A0090;

        ///<summary>(300A,0091) VR=DS VM=1 Alternate Beam Dose</summary>
        public const uint AlternateBeamDose = 0x300A0091;

        ///<summary>(300A,0092) VR=CS VM=1 Alternate Beam Dose Type</summary>
        public const uint AlternateBeamDoseType = 0x300A0092;

        ///<summary>(300A,0093) VR=CS VM=1 Depth Value Averaging Flag</summary>
        public const uint DepthValueAveragingFlag = 0x300A0093;

        ///<summary>(300A,0094) VR=DS VM=1 Beam Dose Point Source to External Contour Distance</summary>
        public const uint BeamDosePointSourceToExternalContourDistance = 0x300A0094;

        ///<summary>(300A,00A0) VR=IS VM=1 Number of Brachy Application Setups</summary>
        public const uint NumberOfBrachyApplicationSetups = 0x300A00A0;

        ///<summary>(300A,00A2) VR=DS VM=3 Brachy Application Setup Dose Specification Point</summary>
        public const uint BrachyApplicationSetupDoseSpecificationPoint = 0x300A00A2;

        ///<summary>(300A,00A4) VR=DS VM=1 Brachy Application Setup Dose</summary>
        public const uint BrachyApplicationSetupDose = 0x300A00A4;

        ///<summary>(300A,00B0) VR=SQ VM=1 Beam Sequence</summary>
        public const uint BeamSequence = 0x300A00B0;

        ///<summary>(300A,00B2) VR=SH VM=1 Treatment Machine Name</summary>
        public const uint TreatmentMachineName = 0x300A00B2;

        ///<summary>(300A,00B3) VR=CS VM=1 Primary Dosimeter Unit</summary>
        public const uint PrimaryDosimeterUnit = 0x300A00B3;

        ///<summary>(300A,00B4) VR=DS VM=1 Source-Axis Distance</summary>
        public const uint SourceAxisDistance = 0x300A00B4;

        ///<summary>(300A,00B6) VR=SQ VM=1 Beam Limiting Device Sequence</summary>
        public const uint BeamLimitingDeviceSequence = 0x300A00B6;

        ///<summary>(300A,00B8) VR=CS VM=1 RT Beam Limiting Device Type</summary>
        public const uint RTBeamLimitingDeviceType = 0x300A00B8;

        ///<summary>(300A,00BA) VR=DS VM=1 Source to Beam Limiting Device Distance</summary>
        public const uint SourceToBeamLimitingDeviceDistance = 0x300A00BA;

        ///<summary>(300A,00BB) VR=FL VM=1 Isocenter to Beam Limiting Device Distance</summary>
        public const uint IsocenterToBeamLimitingDeviceDistance = 0x300A00BB;

        ///<summary>(300A,00BC) VR=IS VM=1 Number of Leaf/Jaw Pairs</summary>
        public const uint NumberOfLeafJawPairs = 0x300A00BC;

        ///<summary>(300A,00BE) VR=DS VM=3-n Leaf Position Boundaries</summary>
        public const uint LeafPositionBoundaries = 0x300A00BE;

        ///<summary>(300A,00C0) VR=IS VM=1 Beam Number</summary>
        public const uint BeamNumber = 0x300A00C0;

        ///<summary>(300A,00C2) VR=LO VM=1 Beam Name</summary>
        public const uint BeamName = 0x300A00C2;

        ///<summary>(300A,00C3) VR=ST VM=1 Beam Description</summary>
        public const uint BeamDescription = 0x300A00C3;

        ///<summary>(300A,00C4) VR=CS VM=1 Beam Type</summary>
        public const uint BeamType = 0x300A00C4;

        ///<summary>(300A,00C5) VR=FD VM=1 Beam Delivery Duration Limit</summary>
        public const uint BeamDeliveryDurationLimit = 0x300A00C5;

        ///<summary>(300A,00C6) VR=CS VM=1 Radiation Type</summary>
        public const uint RadiationType = 0x300A00C6;

        ///<summary>(300A,00C7) VR=CS VM=1 High-Dose Technique Type</summary>
        public const uint HighDoseTechniqueType = 0x300A00C7;

        ///<summary>(300A,00C8) VR=IS VM=1 Reference Image Number</summary>
        public const uint ReferenceImageNumber = 0x300A00C8;

        ///<summary>(300A,00CA) VR=SQ VM=1 Planned Verification Image Sequence</summary>
        public const uint PlannedVerificationImageSequence = 0x300A00CA;

        ///<summary>(300A,00CC) VR=LO VM=1-n Imaging Device-Specific Acquisition Parameters</summary>
        public const uint ImagingDeviceSpecificAcquisitionParameters = 0x300A00CC;

        ///<summary>(300A,00CE) VR=CS VM=1 Treatment Delivery Type</summary>
        public const uint TreatmentDeliveryType = 0x300A00CE;

        ///<summary>(300A,00D0) VR=IS VM=1 Number of Wedges</summary>
        public const uint NumberOfWedges = 0x300A00D0;

        ///<summary>(300A,00D1) VR=SQ VM=1 Wedge Sequence</summary>
        public const uint WedgeSequence = 0x300A00D1;

        ///<summary>(300A,00D2) VR=IS VM=1 Wedge Number</summary>
        public const uint WedgeNumber = 0x300A00D2;

        ///<summary>(300A,00D3) VR=CS VM=1 Wedge Type</summary>
        public const uint WedgeType = 0x300A00D3;

        ///<summary>(300A,00D4) VR=SH VM=1 Wedge Id</summary>
        public const uint WedgeId = 0x300A00D4;

        ///<summary>(300A,00D5) VR=IS VM=1 Wedge Angle</summary>
        public const uint WedgeAngle = 0x300A00D5;

        ///<summary>(300A,00D6) VR=DS VM=1 Wedge Factor</summary>
        public const uint WedgeFactor = 0x300A00D6;

        ///<summary>(300A,00D7) VR=FL VM=1 Total Wedge Tray Water-Equivalent Thickness</summary>
        public const uint TotalWedgeTrayWaterEquivalentThickness = 0x300A00D7;

        ///<summary>(300A,00D8) VR=DS VM=1 Wedge Orientation</summary>
        public const uint WedgeOrientation = 0x300A00D8;

        ///<summary>(300A,00D9) VR=FL VM=1 Isocenter to Wedge Tray Distance</summary>
        public const uint IsocenterToWedgeTrayDistance = 0x300A00D9;

        ///<summary>(300A,00DA) VR=DS VM=1 Source to Wedge Tray Distance</summary>
        public const uint SourceToWedgeTrayDistance = 0x300A00DA;

        ///<summary>(300A,00DB) VR=FL VM=1 Wedge Thin Edge Position</summary>
        public const uint WedgeThinEdgePosition = 0x300A00DB;

        ///<summary>(300A,00DC) VR=SH VM=1 Bolus Id</summary>
        public const uint BolusId = 0x300A00DC;

        ///<summary>(300A,00DD) VR=ST VM=1 Bolus Description</summary>
        public const uint BolusDescription = 0x300A00DD;

        ///<summary>(300A,00DE) VR=DS VM=1 Effective Wedge Angle</summary>
        public const uint EffectiveWedgeAngle = 0x300A00DE;

        ///<summary>(300A,00E0) VR=IS VM=1 Number of Compensators</summary>
        public const uint NumberOfCompensators = 0x300A00E0;

        ///<summary>(300A,00E1) VR=SH VM=1 Material Id</summary>
        public const uint MaterialId = 0x300A00E1;

        ///<summary>(300A,00E2) VR=DS VM=1 Total Compensator Tray Factor</summary>
        public const uint TotalCompensatorTrayFactor = 0x300A00E2;

        ///<summary>(300A,00E3) VR=SQ VM=1 Compensator Sequence</summary>
        public const uint CompensatorSequence = 0x300A00E3;

        ///<summary>(300A,00E4) VR=IS VM=1 Compensator Number</summary>
        public const uint CompensatorNumber = 0x300A00E4;

        ///<summary>(300A,00E5) VR=SH VM=1 Compensator Id</summary>
        public const uint CompensatorId = 0x300A00E5;

        ///<summary>(300A,00E6) VR=DS VM=1 Source to Compensator Tray Distance</summary>
        public const uint SourceToCompensatorTrayDistance = 0x300A00E6;

        ///<summary>(300A,00E7) VR=IS VM=1 Compensator Rows</summary>
        public const uint CompensatorRows = 0x300A00E7;

        ///<summary>(300A,00E8) VR=IS VM=1 Compensator Columns</summary>
        public const uint CompensatorColumns = 0x300A00E8;

        ///<summary>(300A,00E9) VR=DS VM=2 Compensator Pixel Spacing</summary>
        public const uint CompensatorPixelSpacing = 0x300A00E9;

        ///<summary>(300A,00EA) VR=DS VM=2 Compensator Position</summary>
        public const uint CompensatorPosition = 0x300A00EA;

        ///<summary>(300A,00EB) VR=DS VM=1-n Compensator Transmission Data</summary>
        public const uint CompensatorTransmissionData = 0x300A00EB;

        ///<summary>(300A,00EC) VR=DS VM=1-n Compensator Thickness Data</summary>
        public const uint CompensatorThicknessData = 0x300A00EC;

        ///<summary>(300A,00ED) VR=IS VM=1 Number of Boli</summary>
        public const uint NumberOfBoli = 0x300A00ED;

        ///<summary>(300A,00EE) VR=CS VM=1 Compensator Type</summary>
        public const uint CompensatorType = 0x300A00EE;

        ///<summary>(300A,00EF) VR=SH VM=1 Compensator Tray Id</summary>
        public const uint CompensatorTrayId = 0x300A00EF;

        ///<summary>(300A,00F0) VR=IS VM=1 Number of Blocks</summary>
        public const uint NumberOfBlocks = 0x300A00F0;

        ///<summary>(300A,00F2) VR=DS VM=1 Total Block Tray Factor</summary>
        public const uint TotalBlockTrayFactor = 0x300A00F2;

        ///<summary>(300A,00F3) VR=FL VM=1 Total Block Tray Water-Equivalent Thickness</summary>
        public const uint TotalBlockTrayWaterEquivalentThickness = 0x300A00F3;

        ///<summary>(300A,00F4) VR=SQ VM=1 Block Sequence</summary>
        public const uint BlockSequence = 0x300A00F4;

        ///<summary>(300A,00F5) VR=SH VM=1 Block Tray Id</summary>
        public const uint BlockTrayId = 0x300A00F5;

        ///<summary>(300A,00F6) VR=DS VM=1 Source to Block Tray Distance</summary>
        public const uint SourceToBlockTrayDistance = 0x300A00F6;

        ///<summary>(300A,00F7) VR=FL VM=1 Isocenter to Block Tray Distance</summary>
        public const uint IsocenterToBlockTrayDistance = 0x300A00F7;

        ///<summary>(300A,00F8) VR=CS VM=1 Block Type</summary>
        public const uint BlockType = 0x300A00F8;

        ///<summary>(300A,00F9) VR=LO VM=1 Accessory Code</summary>
        public const uint AccessoryCode = 0x300A00F9;

        ///<summary>(300A,00FA) VR=CS VM=1 Block Divergence</summary>
        public const uint BlockDivergence = 0x300A00FA;

        ///<summary>(300A,00FB) VR=CS VM=1 Block Mounting Position</summary>
        public const uint BlockMountingPosition = 0x300A00FB;

        ///<summary>(300A,00FC) VR=IS VM=1 Block Number</summary>
        public const uint BlockNumber = 0x300A00FC;

        ///<summary>(300A,00FE) VR=LO VM=1 Block Name</summary>
        public const uint BlockName = 0x300A00FE;

        ///<summary>(300A,0100) VR=DS VM=1 Block Thickness</summary>
        public const uint BlockThickness = 0x300A0100;

        ///<summary>(300A,0102) VR=DS VM=1 Block Transmission</summary>
        public const uint BlockTransmission = 0x300A0102;

        ///<summary>(300A,0104) VR=IS VM=1 Block Number of Points</summary>
        public const uint BlockNumberOfPoints = 0x300A0104;

        ///<summary>(300A,0106) VR=DS VM=2-2n Block Data</summary>
        public const uint BlockData = 0x300A0106;

        ///<summary>(300A,0107) VR=SQ VM=1 Applicator Sequence</summary>
        public const uint ApplicatorSequence = 0x300A0107;

        ///<summary>(300A,0108) VR=SH VM=1 Applicator Id</summary>
        public const uint ApplicatorId = 0x300A0108;

        ///<summary>(300A,0109) VR=CS VM=1 Applicator Type</summary>
        public const uint ApplicatorType = 0x300A0109;

        ///<summary>(300A,010A) VR=LO VM=1 Applicator Description</summary>
        public const uint ApplicatorDescription = 0x300A010A;

        ///<summary>(300A,010C) VR=DS VM=1 Cumulative Dose Reference Coefficient</summary>
        public const uint CumulativeDoseReferenceCoefficient = 0x300A010C;

        ///<summary>(300A,010E) VR=DS VM=1 Final Cumulative Meterset Weight</summary>
        public const uint FinalCumulativeMetersetWeight = 0x300A010E;

        ///<summary>(300A,0110) VR=IS VM=1 Number of Control Points</summary>
        public const uint NumberOfControlPoints = 0x300A0110;

        ///<summary>(300A,0111) VR=SQ VM=1 Control Point Sequence</summary>
        public const uint ControlPointSequence = 0x300A0111;

        ///<summary>(300A,0112) VR=IS VM=1 Control Point Index</summary>
        public const uint ControlPointIndex = 0x300A0112;

        ///<summary>(300A,0114) VR=DS VM=1 Nominal Beam Energy</summary>
        public const uint NominalBeamEnergy = 0x300A0114;

        ///<summary>(300A,0115) VR=DS VM=1 Dose Rate Set</summary>
        public const uint DoseRateSet = 0x300A0115;

        ///<summary>(300A,0116) VR=SQ VM=1 Wedge Position Sequence</summary>
        public const uint WedgePositionSequence = 0x300A0116;

        ///<summary>(300A,0118) VR=CS VM=1 Wedge Position</summary>
        public const uint WedgePosition = 0x300A0118;

        ///<summary>(300A,011A) VR=SQ VM=1 Beam Limiting Device Position Sequence</summary>
        public const uint BeamLimitingDevicePositionSequence = 0x300A011A;

        ///<summary>(300A,011C) VR=DS VM=2-2n Leaf/Jaw Positions</summary>
        public const uint LeafJawPositions = 0x300A011C;

        ///<summary>(300A,011E) VR=DS VM=1 Gantry Angle</summary>
        public const uint GantryAngle = 0x300A011E;

        ///<summary>(300A,011F) VR=CS VM=1 Gantry Rotation Direction</summary>
        public const uint GantryRotationDirection = 0x300A011F;

        ///<summary>(300A,0120) VR=DS VM=1 Beam Limiting Device Angle</summary>
        public const uint BeamLimitingDeviceAngle = 0x300A0120;

        ///<summary>(300A,0121) VR=CS VM=1 Beam Limiting Device Rotation Direction</summary>
        public const uint BeamLimitingDeviceRotationDirection = 0x300A0121;

        ///<summary>(300A,0122) VR=DS VM=1 Patient Support Angle</summary>
        public const uint PatientSupportAngle = 0x300A0122;

        ///<summary>(300A,0123) VR=CS VM=1 Patient Support Rotation Direction</summary>
        public const uint PatientSupportRotationDirection = 0x300A0123;

        ///<summary>(300A,0124) VR=DS VM=1 Table Top Eccentric Axis Distance</summary>
        public const uint TableTopEccentricAxisDistance = 0x300A0124;

        ///<summary>(300A,0125) VR=DS VM=1 Table Top Eccentric Angle</summary>
        public const uint TableTopEccentricAngle = 0x300A0125;

        ///<summary>(300A,0126) VR=CS VM=1 Table Top Eccentric Rotation Direction</summary>
        public const uint TableTopEccentricRotationDirection = 0x300A0126;

        ///<summary>(300A,0128) VR=DS VM=1 Table Top Vertical Position</summary>
        public const uint TableTopVerticalPosition = 0x300A0128;

        ///<summary>(300A,0129) VR=DS VM=1 Table Top Longitudinal Position</summary>
        public const uint TableTopLongitudinalPosition = 0x300A0129;

        ///<summary>(300A,012A) VR=DS VM=1 Table Top Lateral Position</summary>
        public const uint TableTopLateralPosition = 0x300A012A;

        ///<summary>(300A,012C) VR=DS VM=3 Isocenter Position</summary>
        public const uint IsocenterPosition = 0x300A012C;

        ///<summary>(300A,012E) VR=DS VM=3 Surface Entry Point</summary>
        public const uint SurfaceEntryPoint = 0x300A012E;

        ///<summary>(300A,0130) VR=DS VM=1 Source to Surface Distance</summary>
        public const uint SourceToSurfaceDistance = 0x300A0130;

        ///<summary>(300A,0131) VR=FL VM=1 Average Beam Dose Point Source to External Contour Distance</summary>
        public const uint AverageBeamDosePointSourceToExternalContourDistance = 0x300A0131;

        ///<summary>(300A,0132) VR=FL VM=1 Source to External Contour Distance</summary>
        public const uint SourceToExternalContourDistance = 0x300A0132;

        ///<summary>(300A,0133) VR=FL VM=3 External Contour Entry Point</summary>
        public const uint ExternalContourEntryPoint = 0x300A0133;

        ///<summary>(300A,0134) VR=DS VM=1 Cumulative Meterset Weight</summary>
        public const uint CumulativeMetersetWeight = 0x300A0134;

        ///<summary>(300A,0140) VR=FL VM=1 Table Top Pitch Angle</summary>
        public const uint TableTopPitchAngle = 0x300A0140;

        ///<summary>(300A,0142) VR=CS VM=1 Table Top Pitch Rotation Direction</summary>
        public const uint TableTopPitchRotationDirection = 0x300A0142;

        ///<summary>(300A,0144) VR=FL VM=1 Table Top Roll Angle</summary>
        public const uint TableTopRollAngle = 0x300A0144;

        ///<summary>(300A,0146) VR=CS VM=1 Table Top Roll Rotation Direction</summary>
        public const uint TableTopRollRotationDirection = 0x300A0146;

        ///<summary>(300A,0148) VR=FL VM=1 Head Fixation Angle</summary>
        public const uint HeadFixationAngle = 0x300A0148;

        ///<summary>(300A,014A) VR=FL VM=1 Gantry Pitch Angle</summary>
        public const uint GantryPitchAngle = 0x300A014A;

        ///<summary>(300A,014C) VR=CS VM=1 Gantry Pitch Rotation Direction</summary>
        public const uint GantryPitchRotationDirection = 0x300A014C;

        ///<summary>(300A,014E) VR=FL VM=1 Gantry Pitch Angle Tolerance</summary>
        public const uint GantryPitchAngleTolerance = 0x300A014E;

        ///<summary>(300A,0150) VR=CS VM=1 Fixation Eye</summary>
        public const uint FixationEye = 0x300A0150;

        ///<summary>(300A,0151) VR=DS VM=1 Chair Head Frame Position</summary>
        public const uint ChairHeadFramePosition = 0x300A0151;

        ///<summary>(300A,0152) VR=DS VM=1 Head Fixation Angle Tolerance</summary>
        public const uint HeadFixationAngleTolerance = 0x300A0152;

        ///<summary>(300A,0153) VR=DS VM=1 Chair Head Frame Position Tolerance</summary>
        public const uint ChairHeadFramePositionTolerance = 0x300A0153;

        ///<summary>(300A,0154) VR=DS VM=1 Fixation Light Azimuthal Angle Tolerance</summary>
        public const uint FixationLightAzimuthalAngleTolerance = 0x300A0154;

        ///<summary>(300A,0155) VR=DS VM=1 Fixation Light Polar Angle Tolerance</summary>
        public const uint FixationLightPolarAngleTolerance = 0x300A0155;

        ///<summary>(300A,0180) VR=SQ VM=1 Patient Setup Sequence</summary>
        public const uint PatientSetupSequence = 0x300A0180;

        ///<summary>(300A,0182) VR=IS VM=1 Patient Setup Number</summary>
        public const uint PatientSetupNumber = 0x300A0182;

        ///<summary>(300A,0183) VR=LO VM=1 Patient Setup Label</summary>
        public const uint PatientSetupLabel = 0x300A0183;

        ///<summary>(300A,0184) VR=LO VM=1 Patient Additional Position</summary>
        public const uint PatientAdditionalPosition = 0x300A0184;

        ///<summary>(300A,0190) VR=SQ VM=1 Fixation Device Sequence</summary>
        public const uint FixationDeviceSequence = 0x300A0190;

        ///<summary>(300A,0192) VR=CS VM=1 Fixation Device Type</summary>
        public const uint FixationDeviceType = 0x300A0192;

        ///<summary>(300A,0194) VR=SH VM=1 Fixation Device Label</summary>
        public const uint FixationDeviceLabel = 0x300A0194;

        ///<summary>(300A,0196) VR=ST VM=1 Fixation Device Description</summary>
        public const uint FixationDeviceDescription = 0x300A0196;

        ///<summary>(300A,0198) VR=SH VM=1 Fixation Device Position</summary>
        public const uint FixationDevicePosition = 0x300A0198;

        ///<summary>(300A,0199) VR=FL VM=1 Fixation Device Pitch Angle</summary>
        public const uint FixationDevicePitchAngle = 0x300A0199;

        ///<summary>(300A,019A) VR=FL VM=1 Fixation Device Roll Angle</summary>
        public const uint FixationDeviceRollAngle = 0x300A019A;

        ///<summary>(300A,01A0) VR=SQ VM=1 Shielding Device Sequence</summary>
        public const uint ShieldingDeviceSequence = 0x300A01A0;

        ///<summary>(300A,01A2) VR=CS VM=1 Shielding Device Type</summary>
        public const uint ShieldingDeviceType = 0x300A01A2;

        ///<summary>(300A,01A4) VR=SH VM=1 Shielding Device Label</summary>
        public const uint ShieldingDeviceLabel = 0x300A01A4;

        ///<summary>(300A,01A6) VR=ST VM=1 Shielding Device Description</summary>
        public const uint ShieldingDeviceDescription = 0x300A01A6;

        ///<summary>(300A,01A8) VR=SH VM=1 Shielding Device Position</summary>
        public const uint ShieldingDevicePosition = 0x300A01A8;

        ///<summary>(300A,01B0) VR=CS VM=1 Setup Technique</summary>
        public const uint SetupTechnique = 0x300A01B0;

        ///<summary>(300A,01B2) VR=ST VM=1 Setup Technique Description</summary>
        public const uint SetupTechniqueDescription = 0x300A01B2;

        ///<summary>(300A,01B4) VR=SQ VM=1 Setup Device Sequence</summary>
        public const uint SetupDeviceSequence = 0x300A01B4;

        ///<summary>(300A,01B6) VR=CS VM=1 Setup Device Type</summary>
        public const uint SetupDeviceType = 0x300A01B6;

        ///<summary>(300A,01B8) VR=SH VM=1 Setup Device Label</summary>
        public const uint SetupDeviceLabel = 0x300A01B8;

        ///<summary>(300A,01BA) VR=ST VM=1 Setup Device Description</summary>
        public const uint SetupDeviceDescription = 0x300A01BA;

        ///<summary>(300A,01BC) VR=DS VM=1 Setup Device Parameter</summary>
        public const uint SetupDeviceParameter = 0x300A01BC;

        ///<summary>(300A,01D0) VR=ST VM=1 Setup Reference Description</summary>
        public const uint SetupReferenceDescription = 0x300A01D0;

        ///<summary>(300A,01D2) VR=DS VM=1 Table Top Vertical Setup Displacement</summary>
        public const uint TableTopVerticalSetupDisplacement = 0x300A01D2;

        ///<summary>(300A,01D4) VR=DS VM=1 Table Top Longitudinal Setup Displacement</summary>
        public const uint TableTopLongitudinalSetupDisplacement = 0x300A01D4;

        ///<summary>(300A,01D6) VR=DS VM=1 Table Top Lateral Setup Displacement</summary>
        public const uint TableTopLateralSetupDisplacement = 0x300A01D6;

        ///<summary>(300A,0200) VR=CS VM=1 Brachy Treatment Technique</summary>
        public const uint BrachyTreatmentTechnique = 0x300A0200;

        ///<summary>(300A,0202) VR=CS VM=1 Brachy Treatment Type</summary>
        public const uint BrachyTreatmentType = 0x300A0202;

        ///<summary>(300A,0206) VR=SQ VM=1 Treatment Machine Sequence</summary>
        public const uint TreatmentMachineSequence = 0x300A0206;

        ///<summary>(300A,0210) VR=SQ VM=1 Source Sequence</summary>
        public const uint SourceSequence = 0x300A0210;

        ///<summary>(300A,0212) VR=IS VM=1 Source Number</summary>
        public const uint SourceNumber = 0x300A0212;

        ///<summary>(300A,0214) VR=CS VM=1 Source Type</summary>
        public const uint SourceType = 0x300A0214;

        ///<summary>(300A,0216) VR=LO VM=1 Source Manufacturer</summary>
        public const uint SourceManufacturer = 0x300A0216;

        ///<summary>(300A,0218) VR=DS VM=1 Active Source Diameter</summary>
        public const uint ActiveSourceDiameter = 0x300A0218;

        ///<summary>(300A,021A) VR=DS VM=1 Active Source Length</summary>
        public const uint ActiveSourceLength = 0x300A021A;

        ///<summary>(300A,021B) VR=SH VM=1 Source Model Id</summary>
        public const uint SourceModelId = 0x300A021B;

        ///<summary>(300A,021C) VR=LO VM=1 Source Description</summary>
        public const uint SourceDescription = 0x300A021C;

        ///<summary>(300A,0222) VR=DS VM=1 Source Encapsulation Nominal Thickness</summary>
        public const uint SourceEncapsulationNominalThickness = 0x300A0222;

        ///<summary>(300A,0224) VR=DS VM=1 Source Encapsulation Nominal Transmission</summary>
        public const uint SourceEncapsulationNominalTransmission = 0x300A0224;

        ///<summary>(300A,0226) VR=LO VM=1 Source Isotope Name</summary>
        public const uint SourceIsotopeName = 0x300A0226;

        ///<summary>(300A,0228) VR=DS VM=1 Source Isotope Half Life</summary>
        public const uint SourceIsotopeHalfLife = 0x300A0228;

        ///<summary>(300A,0229) VR=CS VM=1 Source Strength Units</summary>
        public const uint SourceStrengthUnits = 0x300A0229;

        ///<summary>(300A,022A) VR=DS VM=1 Reference Air Kerma Rate</summary>
        public const uint ReferenceAirKermaRate = 0x300A022A;

        ///<summary>(300A,022B) VR=DS VM=1 Source Strength</summary>
        public const uint SourceStrength = 0x300A022B;

        ///<summary>(300A,022C) VR=DA VM=1 Source Strength Reference Date</summary>
        public const uint SourceStrengthReferenceDate = 0x300A022C;

        ///<summary>(300A,022E) VR=TM VM=1 Source Strength Reference Time</summary>
        public const uint SourceStrengthReferenceTime = 0x300A022E;

        ///<summary>(300A,0230) VR=SQ VM=1 Application Setup Sequence</summary>
        public const uint ApplicationSetupSequence = 0x300A0230;

        ///<summary>(300A,0232) VR=CS VM=1 Application Setup Type</summary>
        public const uint ApplicationSetupType = 0x300A0232;

        ///<summary>(300A,0234) VR=IS VM=1 Application Setup Number</summary>
        public const uint ApplicationSetupNumber = 0x300A0234;

        ///<summary>(300A,0236) VR=LO VM=1 Application Setup Name</summary>
        public const uint ApplicationSetupName = 0x300A0236;

        ///<summary>(300A,0238) VR=LO VM=1 Application Setup Manufacturer</summary>
        public const uint ApplicationSetupManufacturer = 0x300A0238;

        ///<summary>(300A,0240) VR=IS VM=1 Template Number</summary>
        public const uint TemplateNumber = 0x300A0240;

        ///<summary>(300A,0242) VR=SH VM=1 Template Type</summary>
        public const uint TemplateType = 0x300A0242;

        ///<summary>(300A,0244) VR=LO VM=1 Template Name</summary>
        public const uint TemplateName = 0x300A0244;

        ///<summary>(300A,0250) VR=DS VM=1 Total Reference Air Kerma</summary>
        public const uint TotalReferenceAirKerma = 0x300A0250;

        ///<summary>(300A,0260) VR=SQ VM=1 Brachy Accessory Device Sequence</summary>
        public const uint BrachyAccessoryDeviceSequence = 0x300A0260;

        ///<summary>(300A,0262) VR=IS VM=1 Brachy Accessory Device Number</summary>
        public const uint BrachyAccessoryDeviceNumber = 0x300A0262;

        ///<summary>(300A,0263) VR=SH VM=1 Brachy Accessory Device Id</summary>
        public const uint BrachyAccessoryDeviceId = 0x300A0263;

        ///<summary>(300A,0264) VR=CS VM=1 Brachy Accessory Device Type</summary>
        public const uint BrachyAccessoryDeviceType = 0x300A0264;

        ///<summary>(300A,0266) VR=LO VM=1 Brachy Accessory Device Name</summary>
        public const uint BrachyAccessoryDeviceName = 0x300A0266;

        ///<summary>(300A,026A) VR=DS VM=1 Brachy Accessory Device Nominal Thickness</summary>
        public const uint BrachyAccessoryDeviceNominalThickness = 0x300A026A;

        ///<summary>(300A,026C) VR=DS VM=1 Brachy Accessory Device Nominal Transmission</summary>
        public const uint BrachyAccessoryDeviceNominalTransmission = 0x300A026C;

        ///<summary>(300A,0271) VR=DS VM=1 Channel Effective Length</summary>
        public const uint ChannelEffectiveLength = 0x300A0271;

        ///<summary>(300A,0272) VR=DS VM=1 Channel Inner Length</summary>
        public const uint ChannelInnerLength = 0x300A0272;

        ///<summary>(300A,0273) VR=SH VM=1 Afterloader Channel Id</summary>
        public const uint AfterloaderChannelId = 0x300A0273;

        ///<summary>(300A,0274) VR=DS VM=1 Source Applicator Tip Length</summary>
        public const uint SourceApplicatorTipLength = 0x300A0274;

        ///<summary>(300A,0280) VR=SQ VM=1 Channel Sequence</summary>
        public const uint ChannelSequence = 0x300A0280;

        ///<summary>(300A,0282) VR=IS VM=1 Channel Number</summary>
        public const uint ChannelNumber = 0x300A0282;

        ///<summary>(300A,0284) VR=DS VM=1 Channel Length</summary>
        public const uint ChannelLength = 0x300A0284;

        ///<summary>(300A,0286) VR=DS VM=1 Channel Total Time</summary>
        public const uint ChannelTotalTime = 0x300A0286;

        ///<summary>(300A,0288) VR=CS VM=1 Source Movement Type</summary>
        public const uint SourceMovementType = 0x300A0288;

        ///<summary>(300A,028A) VR=IS VM=1 Number of Pulses</summary>
        public const uint NumberOfPulses = 0x300A028A;

        ///<summary>(300A,028C) VR=DS VM=1 Pulse Repetition Interval</summary>
        public const uint PulseRepetitionInterval = 0x300A028C;

        ///<summary>(300A,0290) VR=IS VM=1 Source Applicator Number</summary>
        public const uint SourceApplicatorNumber = 0x300A0290;

        ///<summary>(300A,0291) VR=SH VM=1 Source Applicator Id</summary>
        public const uint SourceApplicatorId = 0x300A0291;

        ///<summary>(300A,0292) VR=CS VM=1 Source Applicator Type</summary>
        public const uint SourceApplicatorType = 0x300A0292;

        ///<summary>(300A,0294) VR=LO VM=1 Source Applicator Name</summary>
        public const uint SourceApplicatorName = 0x300A0294;

        ///<summary>(300A,0296) VR=DS VM=1 Source Applicator Length</summary>
        public const uint SourceApplicatorLength = 0x300A0296;

        ///<summary>(300A,0298) VR=LO VM=1 Source Applicator Manufacturer</summary>
        public const uint SourceApplicatorManufacturer = 0x300A0298;

        ///<summary>(300A,029C) VR=DS VM=1 Source Applicator Wall Nominal Thickness</summary>
        public const uint SourceApplicatorWallNominalThickness = 0x300A029C;

        ///<summary>(300A,029E) VR=DS VM=1 Source Applicator Wall Nominal Transmission</summary>
        public const uint SourceApplicatorWallNominalTransmission = 0x300A029E;

        ///<summary>(300A,02A0) VR=DS VM=1 Source Applicator Step Size</summary>
        public const uint SourceApplicatorStepSize = 0x300A02A0;

        ///<summary>(300A,02A1) VR=IS VM=1 Applicator Shape Referenced ROI Number</summary>
        public const uint ApplicatorShapeReferencedROINumber = 0x300A02A1;

        ///<summary>(300A,02A2) VR=IS VM=1 Transfer Tube Number</summary>
        public const uint TransferTubeNumber = 0x300A02A2;

        ///<summary>(300A,02A4) VR=DS VM=1 Transfer Tube Length</summary>
        public const uint TransferTubeLength = 0x300A02A4;

        ///<summary>(300A,02B0) VR=SQ VM=1 Channel Shield Sequence</summary>
        public const uint ChannelShieldSequence = 0x300A02B0;

        ///<summary>(300A,02B2) VR=IS VM=1 Channel Shield Number</summary>
        public const uint ChannelShieldNumber = 0x300A02B2;

        ///<summary>(300A,02B3) VR=SH VM=1 Channel Shield Id</summary>
        public const uint ChannelShieldId = 0x300A02B3;

        ///<summary>(300A,02B4) VR=LO VM=1 Channel Shield Name</summary>
        public const uint ChannelShieldName = 0x300A02B4;

        ///<summary>(300A,02B8) VR=DS VM=1 Channel Shield Nominal Thickness</summary>
        public const uint ChannelShieldNominalThickness = 0x300A02B8;

        ///<summary>(300A,02BA) VR=DS VM=1 Channel Shield Nominal Transmission</summary>
        public const uint ChannelShieldNominalTransmission = 0x300A02BA;

        ///<summary>(300A,02C8) VR=DS VM=1 Final Cumulative Time Weight</summary>
        public const uint FinalCumulativeTimeWeight = 0x300A02C8;

        ///<summary>(300A,02D0) VR=SQ VM=1 Brachy Control Point Sequence</summary>
        public const uint BrachyControlPointSequence = 0x300A02D0;

        ///<summary>(300A,02D2) VR=DS VM=1 Control Point Relative Position</summary>
        public const uint ControlPointRelativePosition = 0x300A02D2;

        ///<summary>(300A,02D4) VR=DS VM=3 Control Point 3D Position</summary>
        public const uint ControlPoint3DPosition = 0x300A02D4;

        ///<summary>(300A,02D6) VR=DS VM=1 Cumulative Time Weight</summary>
        public const uint CumulativeTimeWeight = 0x300A02D6;

        ///<summary>(300A,02E0) VR=CS VM=1 Compensator Divergence</summary>
        public const uint CompensatorDivergence = 0x300A02E0;

        ///<summary>(300A,02E1) VR=CS VM=1 Compensator Mounting Position</summary>
        public const uint CompensatorMountingPosition = 0x300A02E1;

        ///<summary>(300A,02E2) VR=DS VM=1-n Source to Compensator Distance</summary>
        public const uint SourceToCompensatorDistance = 0x300A02E2;

        ///<summary>(300A,02E3) VR=FL VM=1 Total Compensator Tray Water-Equivalent Thickness</summary>
        public const uint TotalCompensatorTrayWaterEquivalentThickness = 0x300A02E3;

        ///<summary>(300A,02E4) VR=FL VM=1 Isocenter to Compensator Tray Distance</summary>
        public const uint IsocenterToCompensatorTrayDistance = 0x300A02E4;

        ///<summary>(300A,02E5) VR=FL VM=1 Compensator Column Offset</summary>
        public const uint CompensatorColumnOffset = 0x300A02E5;

        ///<summary>(300A,02E6) VR=FL VM=1-n Isocenter to Compensator Distances</summary>
        public const uint IsocenterToCompensatorDistances = 0x300A02E6;

        ///<summary>(300A,02E7) VR=FL VM=1 Compensator Relative Stopping Power Ratio</summary>
        public const uint CompensatorRelativeStoppingPowerRatio = 0x300A02E7;

        ///<summary>(300A,02E8) VR=FL VM=1 Compensator Milling Tool Diameter</summary>
        public const uint CompensatorMillingToolDiameter = 0x300A02E8;

        ///<summary>(300A,02EA) VR=SQ VM=1 Ion Range Compensator Sequence</summary>
        public const uint IonRangeCompensatorSequence = 0x300A02EA;

        ///<summary>(300A,02EB) VR=LT VM=1 Compensator Description</summary>
        public const uint CompensatorDescription = 0x300A02EB;

        ///<summary>(300A,0302) VR=IS VM=1 Radiation Mass Number</summary>
        public const uint RadiationMassNumber = 0x300A0302;

        ///<summary>(300A,0304) VR=IS VM=1 Radiation Atomic Number</summary>
        public const uint RadiationAtomicNumber = 0x300A0304;

        ///<summary>(300A,0306) VR=SS VM=1 Radiation Charge State</summary>
        public const uint RadiationChargeState = 0x300A0306;

        ///<summary>(300A,0308) VR=CS VM=1 Scan Mode</summary>
        public const uint ScanMode = 0x300A0308;

        ///<summary>(300A,0309) VR=CS VM=1 Modulated Scan Mode Type</summary>
        public const uint ModulatedScanModeType = 0x300A0309;

        ///<summary>(300A,030A) VR=FL VM=2 Virtual Source-Axis Distances</summary>
        public const uint VirtualSourceAxisDistances = 0x300A030A;

        ///<summary>(300A,030C) VR=SQ VM=1 Snout Sequence</summary>
        public const uint SnoutSequence = 0x300A030C;

        ///<summary>(300A,030D) VR=FL VM=1 Snout Position</summary>
        public const uint SnoutPosition = 0x300A030D;

        ///<summary>(300A,030F) VR=SH VM=1 Snout Id</summary>
        public const uint SnoutId = 0x300A030F;

        ///<summary>(300A,0312) VR=IS VM=1 Number of Range Shifters</summary>
        public const uint NumberOfRangeShifters = 0x300A0312;

        ///<summary>(300A,0314) VR=SQ VM=1 Range Shifter Sequence</summary>
        public const uint RangeShifterSequence = 0x300A0314;

        ///<summary>(300A,0316) VR=IS VM=1 Range Shifter Number</summary>
        public const uint RangeShifterNumber = 0x300A0316;

        ///<summary>(300A,0318) VR=SH VM=1 Range Shifter Id</summary>
        public const uint RangeShifterId = 0x300A0318;

        ///<summary>(300A,0320) VR=CS VM=1 Range Shifter Type</summary>
        public const uint RangeShifterType = 0x300A0320;

        ///<summary>(300A,0322) VR=LO VM=1 Range Shifter Description</summary>
        public const uint RangeShifterDescription = 0x300A0322;

        ///<summary>(300A,0330) VR=IS VM=1 Number of Lateral Spreading Devices</summary>
        public const uint NumberOfLateralSpreadingDevices = 0x300A0330;

        ///<summary>(300A,0332) VR=SQ VM=1 Lateral Spreading Device Sequence</summary>
        public const uint LateralSpreadingDeviceSequence = 0x300A0332;

        ///<summary>(300A,0334) VR=IS VM=1 Lateral Spreading Device Number</summary>
        public const uint LateralSpreadingDeviceNumber = 0x300A0334;

        ///<summary>(300A,0336) VR=SH VM=1 Lateral Spreading Device Id</summary>
        public const uint LateralSpreadingDeviceId = 0x300A0336;

        ///<summary>(300A,0338) VR=CS VM=1 Lateral Spreading Device Type</summary>
        public const uint LateralSpreadingDeviceType = 0x300A0338;

        ///<summary>(300A,033A) VR=LO VM=1 Lateral Spreading Device Description</summary>
        public const uint LateralSpreadingDeviceDescription = 0x300A033A;

        ///<summary>(300A,033C) VR=FL VM=1 Lateral Spreading Device Water Equivalent Thickness</summary>
        public const uint LateralSpreadingDeviceWaterEquivalentThickness = 0x300A033C;

        ///<summary>(300A,0340) VR=IS VM=1 Number of Range Modulators</summary>
        public const uint NumberOfRangeModulators = 0x300A0340;

        ///<summary>(300A,0342) VR=SQ VM=1 Range Modulator Sequence</summary>
        public const uint RangeModulatorSequence = 0x300A0342;

        ///<summary>(300A,0344) VR=IS VM=1 Range Modulator Number</summary>
        public const uint RangeModulatorNumber = 0x300A0344;

        ///<summary>(300A,0346) VR=SH VM=1 Range Modulator Id</summary>
        public const uint RangeModulatorId = 0x300A0346;

        ///<summary>(300A,0348) VR=CS VM=1 Range Modulator Type</summary>
        public const uint RangeModulatorType = 0x300A0348;

        ///<summary>(300A,034A) VR=LO VM=1 Range Modulator Description</summary>
        public const uint RangeModulatorDescription = 0x300A034A;

        ///<summary>(300A,034C) VR=SH VM=1 Beam Current Modulation Id</summary>
        public const uint BeamCurrentModulationId = 0x300A034C;

        ///<summary>(300A,0350) VR=CS VM=1 Patient Support Type</summary>
        public const uint PatientSupportType = 0x300A0350;

        ///<summary>(300A,0352) VR=SH VM=1 Patient Support Id</summary>
        public const uint PatientSupportId = 0x300A0352;

        ///<summary>(300A,0354) VR=LO VM=1 Patient Support Accessory Code</summary>
        public const uint PatientSupportAccessoryCode = 0x300A0354;

        ///<summary>(300A,0355) VR=LO VM=1 Tray Accessory Code</summary>
        public const uint TrayAccessoryCode = 0x300A0355;

        ///<summary>(300A,0356) VR=FL VM=1 Fixation Light Azimuthal Angle</summary>
        public const uint FixationLightAzimuthalAngle = 0x300A0356;

        ///<summary>(300A,0358) VR=FL VM=1 Fixation Light Polar Angle</summary>
        public const uint FixationLightPolarAngle = 0x300A0358;

        ///<summary>(300A,035A) VR=FL VM=1 Meterset Rate</summary>
        public const uint MetersetRate = 0x300A035A;

        ///<summary>(300A,0360) VR=SQ VM=1 Range Shifter Settings Sequence</summary>
        public const uint RangeShifterSettingsSequence = 0x300A0360;

        ///<summary>(300A,0362) VR=LO VM=1 Range Shifter Setting</summary>
        public const uint RangeShifterSetting = 0x300A0362;

        ///<summary>(300A,0364) VR=FL VM=1 Isocenter to Range Shifter Distance</summary>
        public const uint IsocenterToRangeShifterDistance = 0x300A0364;

        ///<summary>(300A,0366) VR=FL VM=1 Range Shifter Water Equivalent Thickness</summary>
        public const uint RangeShifterWaterEquivalentThickness = 0x300A0366;

        ///<summary>(300A,0370) VR=SQ VM=1 Lateral Spreading Device Settings Sequence</summary>
        public const uint LateralSpreadingDeviceSettingsSequence = 0x300A0370;

        ///<summary>(300A,0372) VR=LO VM=1 Lateral Spreading Device Setting</summary>
        public const uint LateralSpreadingDeviceSetting = 0x300A0372;

        ///<summary>(300A,0374) VR=FL VM=1 Isocenter to Lateral Spreading Device Distance</summary>
        public const uint IsocenterToLateralSpreadingDeviceDistance = 0x300A0374;

        ///<summary>(300A,0380) VR=SQ VM=1 Range Modulator Settings Sequence</summary>
        public const uint RangeModulatorSettingsSequence = 0x300A0380;

        ///<summary>(300A,0382) VR=FL VM=1 Range Modulator Gating Start Value</summary>
        public const uint RangeModulatorGatingStartValue = 0x300A0382;

        ///<summary>(300A,0384) VR=FL VM=1 Range Modulator Gating Stop Value</summary>
        public const uint RangeModulatorGatingStopValue = 0x300A0384;

        ///<summary>(300A,0386) VR=FL VM=1 Range Modulator Gating Start Water Equivalent Thickness</summary>
        public const uint RangeModulatorGatingStartWaterEquivalentThickness = 0x300A0386;

        ///<summary>(300A,0388) VR=FL VM=1 Range Modulator Gating Stop Water Equivalent Thickness</summary>
        public const uint RangeModulatorGatingStopWaterEquivalentThickness = 0x300A0388;

        ///<summary>(300A,038A) VR=FL VM=1 Isocenter to Range Modulator Distance</summary>
        public const uint IsocenterToRangeModulatorDistance = 0x300A038A;

        ///<summary>(300A,038F) VR=FL VM=1-n Scan Spot Time Offset</summary>
        public const uint ScanSpotTimeOffset = 0x300A038F;

        ///<summary>(300A,0390) VR=SH VM=1 Scan Spot Tune Id</summary>
        public const uint ScanSpotTuneId = 0x300A0390;

        ///<summary>(300A,0391) VR=IS VM=1-n Scan Spot Prescribed Indices</summary>
        public const uint ScanSpotPrescribedIndices = 0x300A0391;

        ///<summary>(300A,0392) VR=IS VM=1 Number of Scan Spot Positions</summary>
        public const uint NumberOfScanSpotPositions = 0x300A0392;

        ///<summary>(300A,0393) VR=CS VM=1 Scan Spot Reordered</summary>
        public const uint ScanSpotReordered = 0x300A0393;

        ///<summary>(300A,0394) VR=FL VM=1-n Scan Spot Position Map</summary>
        public const uint ScanSpotPositionMap = 0x300A0394;

        ///<summary>(300A,0395) VR=CS VM=1 Scan Spot Reordering Allowed</summary>
        public const uint ScanSpotReorderingAllowed = 0x300A0395;

        ///<summary>(300A,0396) VR=FL VM=1-n Scan Spot Meterset Weights</summary>
        public const uint ScanSpotMetersetWeights = 0x300A0396;

        ///<summary>(300A,0398) VR=FL VM=2 Scanning Spot Size</summary>
        public const uint ScanningSpotSize = 0x300A0398;

        ///<summary>(300A,0399) VR=FL VM=2-2n Scan Spot Sizes Delivered</summary>
        public const uint ScanSpotSizesDelivered = 0x300A0399;

        ///<summary>(300A,039A) VR=IS VM=1 Number of Paintings</summary>
        public const uint NumberOfPaintings = 0x300A039A;

        ///<summary>(300A,03A0) VR=SQ VM=1 Ion Tolerance Table Sequence</summary>
        public const uint IonToleranceTableSequence = 0x300A03A0;

        ///<summary>(300A,03A2) VR=SQ VM=1 Ion Beam Sequence</summary>
        public const uint IonBeamSequence = 0x300A03A2;

        ///<summary>(300A,03A4) VR=SQ VM=1 Ion Beam Limiting Device Sequence</summary>
        public const uint IonBeamLimitingDeviceSequence = 0x300A03A4;

        ///<summary>(300A,03A6) VR=SQ VM=1 Ion Block Sequence</summary>
        public const uint IonBlockSequence = 0x300A03A6;

        ///<summary>(300A,03A8) VR=SQ VM=1 Ion Control Point Sequence</summary>
        public const uint IonControlPointSequence = 0x300A03A8;

        ///<summary>(300A,03AA) VR=SQ VM=1 Ion Wedge Sequence</summary>
        public const uint IonWedgeSequence = 0x300A03AA;

        ///<summary>(300A,03AC) VR=SQ VM=1 Ion Wedge Position Sequence</summary>
        public const uint IonWedgePositionSequence = 0x300A03AC;

        ///<summary>(300A,0401) VR=SQ VM=1 Referenced Setup Image Sequence</summary>
        public const uint ReferencedSetupImageSequence = 0x300A0401;

        ///<summary>(300A,0402) VR=ST VM=1 Setup Image Comment</summary>
        public const uint SetupImageComment = 0x300A0402;

        ///<summary>(300A,0410) VR=SQ VM=1 Motion Synchronization Sequence</summary>
        public const uint MotionSynchronizationSequence = 0x300A0410;

        ///<summary>(300A,0412) VR=FL VM=3 Control Point Orientation</summary>
        public const uint ControlPointOrientation = 0x300A0412;

        ///<summary>(300A,0420) VR=SQ VM=1 General Accessory Sequence</summary>
        public const uint GeneralAccessorySequence = 0x300A0420;

        ///<summary>(300A,0421) VR=SH VM=1 General Accessory Id</summary>
        public const uint GeneralAccessoryId = 0x300A0421;

        ///<summary>(300A,0422) VR=ST VM=1 General Accessory Description</summary>
        public const uint GeneralAccessoryDescription = 0x300A0422;

        ///<summary>(300A,0423) VR=CS VM=1 General Accessory Type</summary>
        public const uint GeneralAccessoryType = 0x300A0423;

        ///<summary>(300A,0424) VR=IS VM=1 General Accessory Number</summary>
        public const uint GeneralAccessoryNumber = 0x300A0424;

        ///<summary>(300A,0425) VR=FL VM=1 Source to General Accessory Distance</summary>
        public const uint SourceToGeneralAccessoryDistance = 0x300A0425;

        ///<summary>(300A,0426) VR=DS VM=1 Isocenter to General Accessory Distance</summary>
        public const uint IsocenterToGeneralAccessoryDistance = 0x300A0426;

        ///<summary>(300A,0431) VR=SQ VM=1 Applicator Geometry Sequence</summary>
        public const uint ApplicatorGeometrySequence = 0x300A0431;

        ///<summary>(300A,0432) VR=CS VM=1 Applicator Aperture Shape</summary>
        public const uint ApplicatorApertureShape = 0x300A0432;

        ///<summary>(300A,0433) VR=FL VM=1 Applicator Opening</summary>
        public const uint ApplicatorOpening = 0x300A0433;

        ///<summary>(300A,0434) VR=FL VM=1 Applicator Opening X</summary>
        public const uint ApplicatorOpeningX = 0x300A0434;

        ///<summary>(300A,0435) VR=FL VM=1 Applicator Opening Y</summary>
        public const uint ApplicatorOpeningY = 0x300A0435;

        ///<summary>(300A,0436) VR=FL VM=1 Source to Applicator Mounting Position Distance</summary>
        public const uint SourceToApplicatorMountingPositionDistance = 0x300A0436;

        ///<summary>(300A,0440) VR=IS VM=1 Number of Block Slab Items</summary>
        public const uint NumberOfBlockSlabItems = 0x300A0440;

        ///<summary>(300A,0441) VR=SQ VM=1 Block Slab Sequence</summary>
        public const uint BlockSlabSequence = 0x300A0441;

        ///<summary>(300A,0442) VR=DS VM=1 Block Slab Thickness</summary>
        public const uint BlockSlabThickness = 0x300A0442;

        ///<summary>(300A,0443) VR=US VM=1 Block Slab Number</summary>
        public const uint BlockSlabNumber = 0x300A0443;

        ///<summary>(300A,0450) VR=SQ VM=1 Device Motion Control Sequence</summary>
        public const uint DeviceMotionControlSequence = 0x300A0450;

        ///<summary>(300A,0451) VR=CS VM=1 Device Motion Execution Mode</summary>
        public const uint DeviceMotionExecutionMode = 0x300A0451;

        ///<summary>(300A,0452) VR=CS VM=1 Device Motion Observation Mode</summary>
        public const uint DeviceMotionObservationMode = 0x300A0452;

        ///<summary>(300A,0453) VR=SQ VM=1 Device Motion Parameter Code Sequence</summary>
        public const uint DeviceMotionParameterCodeSequence = 0x300A0453;

        ///<summary>(300A,0501) VR=FL VM=1 Distal Depth Fraction</summary>
        public const uint DistalDepthFraction = 0x300A0501;

        ///<summary>(300A,0502) VR=FL VM=1 Distal Depth</summary>
        public const uint DistalDepth = 0x300A0502;

        ///<summary>(300A,0503) VR=FL VM=2 Nominal Range Modulation Fractions</summary>
        public const uint NominalRangeModulationFractions = 0x300A0503;

        ///<summary>(300A,0504) VR=FL VM=2 Nominal Range Modulated Region Depths</summary>
        public const uint NominalRangeModulatedRegionDepths = 0x300A0504;

        ///<summary>(300A,0505) VR=SQ VM=1 Depth Dose Parameters Sequence</summary>
        public const uint DepthDoseParametersSequence = 0x300A0505;

        ///<summary>(300A,0506) VR=SQ VM=1 Delivered Depth Dose Parameters Sequence</summary>
        public const uint DeliveredDepthDoseParametersSequence = 0x300A0506;

        ///<summary>(300A,0507) VR=FL VM=1 Delivered Distal Depth Fraction</summary>
        public const uint DeliveredDistalDepthFraction = 0x300A0507;

        ///<summary>(300A,0508) VR=FL VM=1 Delivered Distal Depth</summary>
        public const uint DeliveredDistalDepth = 0x300A0508;

        ///<summary>(300A,0509) VR=FL VM=2 Delivered Nominal Range Modulation Fractions</summary>
        public const uint DeliveredNominalRangeModulationFractions = 0x300A0509;

        ///<summary>(300A,0510) VR=FL VM=2 Delivered Nominal Range Modulated Region Depths</summary>
        public const uint DeliveredNominalRangeModulatedRegionDepths = 0x300A0510;

        ///<summary>(300A,0511) VR=CS VM=1 Delivered Reference Dose Definition</summary>
        public const uint DeliveredReferenceDoseDefinition = 0x300A0511;

        ///<summary>(300A,0512) VR=CS VM=1 Reference Dose Definition</summary>
        public const uint ReferenceDoseDefinition = 0x300A0512;

        ///<summary>(300A,0600) VR=US VM=1 RT Control Point Index</summary>
        public const uint RTControlPointIndex = 0x300A0600;

        ///<summary>(300A,0601) VR=US VM=1 Radiation Generation Mode Index</summary>
        public const uint RadiationGenerationModeIndex = 0x300A0601;

        ///<summary>(300A,0602) VR=US VM=1 Referenced Defined Device Index</summary>
        public const uint ReferencedDefinedDeviceIndex = 0x300A0602;

        ///<summary>(300A,0603) VR=US VM=1 Radiation Dose Identification Index</summary>
        public const uint RadiationDoseIdentificationIndex = 0x300A0603;

        ///<summary>(300A,0604) VR=US VM=1 Number of RT Control Points</summary>
        public const uint NumberOfRTControlPoints = 0x300A0604;

        ///<summary>(300A,0605) VR=US VM=1 Referenced Radiation Generation Mode Index</summary>
        public const uint ReferencedRadiationGenerationModeIndex = 0x300A0605;

        ///<summary>(300A,0606) VR=US VM=1 Treatment Position Index</summary>
        public const uint TreatmentPositionIndex = 0x300A0606;

        ///<summary>(300A,0607) VR=US VM=1 Referenced Device Index</summary>
        public const uint ReferencedDeviceIndex = 0x300A0607;

        ///<summary>(300A,0608) VR=LO VM=1 Treatment Position Group Label</summary>
        public const uint TreatmentPositionGroupLabel = 0x300A0608;

        ///<summary>(300A,0609) VR=UI VM=1 Treatment Position Group Uid</summary>
        public const uint TreatmentPositionGroupUid = 0x300A0609;

        ///<summary>(300A,060A) VR=SQ VM=1 Treatment Position Group Sequence</summary>
        public const uint TreatmentPositionGroupSequence = 0x300A060A;

        ///<summary>(300A,060B) VR=US VM=1 Referenced Treatment Position Index</summary>
        public const uint ReferencedTreatmentPositionIndex = 0x300A060B;

        ///<summary>(300A,060C) VR=US VM=1 Referenced Radiation Dose Identification Index</summary>
        public const uint ReferencedRadiationDoseIdentificationIndex = 0x300A060C;

        ///<summary>(300A,060D) VR=FD VM=1 RT Accessory Holder Water-Equivalent Thickness</summary>
        public const uint RTAccessoryHolderWaterEquivalentThickness = 0x300A060D;

        ///<summary>(300A,060E) VR=US VM=1 Referenced RT Accessory Holder Device Index</summary>
        public const uint ReferencedRTAccessoryHolderDeviceIndex = 0x300A060E;

        ///<summary>(300A,060F) VR=CS VM=1 RT Accessory Holder Slot Existence Flag</summary>
        public const uint RTAccessoryHolderSlotExistenceFlag = 0x300A060F;

        ///<summary>(300A,0610) VR=SQ VM=1 RT Accessory Holder Slot Sequence</summary>
        public const uint RTAccessoryHolderSlotSequence = 0x300A0610;

        ///<summary>(300A,0611) VR=LO VM=1 RT Accessory Holder Slot Id</summary>
        public const uint RTAccessoryHolderSlotId = 0x300A0611;

        ///<summary>(300A,0612) VR=FD VM=1 RT Accessory Holder Slot Distance</summary>
        public const uint RTAccessoryHolderSlotDistance = 0x300A0612;

        ///<summary>(300A,0613) VR=FD VM=1 RT Accessory Slot Distance</summary>
        public const uint RTAccessorySlotDistance = 0x300A0613;

        ///<summary>(300A,0614) VR=SQ VM=1 RT Accessory Holder Definition Sequence</summary>
        public const uint RTAccessoryHolderDefinitionSequence = 0x300A0614;

        ///<summary>(300A,0615) VR=LO VM=1 RT Accessory Device Slot Id</summary>
        public const uint RTAccessoryDeviceSlotId = 0x300A0615;

        ///<summary>(300A,0616) VR=SQ VM=1 RT Radiation Sequence</summary>
        public const uint RTRadiationSequence = 0x300A0616;

        ///<summary>(300A,0617) VR=SQ VM=1 Radiation Dose Sequence</summary>
        public const uint RadiationDoseSequence = 0x300A0617;

        ///<summary>(300A,0618) VR=SQ VM=1 Radiation Dose Identification Sequence</summary>
        public const uint RadiationDoseIdentificationSequence = 0x300A0618;

        ///<summary>(300A,0619) VR=LO VM=1 Radiation Dose Identification Label</summary>
        public const uint RadiationDoseIdentificationLabel = 0x300A0619;

        ///<summary>(300A,061A) VR=CS VM=1 Reference Dose Type</summary>
        public const uint ReferenceDoseType = 0x300A061A;

        ///<summary>(300A,061B) VR=CS VM=1 Primary Dose Value Indicator</summary>
        public const uint PrimaryDoseValueIndicator = 0x300A061B;

        ///<summary>(300A,061C) VR=SQ VM=1 Dose Values Sequence</summary>
        public const uint DoseValuesSequence = 0x300A061C;

        ///<summary>(300A,061D) VR=CS VM=1-n Dose Value Purpose</summary>
        public const uint DoseValuePurpose = 0x300A061D;

        ///<summary>(300A,061E) VR=FD VM=3 Reference Dose Point Coordinates</summary>
        public const uint ReferenceDosePointCoordinates = 0x300A061E;

        ///<summary>(300A,061F) VR=SQ VM=1 Radiation Dose Values Parameters Sequence</summary>
        public const uint RadiationDoseValuesParametersSequence = 0x300A061F;

        ///<summary>(300A,0620) VR=SQ VM=1 Meterset to Dose Mapping Sequence</summary>
        public const uint MetersetToDoseMappingSequence = 0x300A0620;

        ///<summary>(300A,0621) VR=SQ VM=1 Expected In-Vivo Measurement Values Sequence</summary>
        public const uint ExpectedInVivoMeasurementValuesSequence = 0x300A0621;

        ///<summary>(300A,0622) VR=US VM=1 Expected In-Vivo Measurement Value Index</summary>
        public const uint ExpectedInVivoMeasurementValueIndex = 0x300A0622;

        ///<summary>(300A,0623) VR=LO VM=1 Radiation Dose In-Vivo Measurement Label</summary>
        public const uint RadiationDoseInVivoMeasurementLabel = 0x300A0623;

        ///<summary>(300A,0624) VR=FD VM=2 Radiation Dose Central Axis Displacement</summary>
        public const uint RadiationDoseCentralAxisDisplacement = 0x300A0624;

        ///<summary>(300A,0625) VR=FD VM=1 Radiation Dose Value</summary>
        public const uint RadiationDoseValue = 0x300A0625;

        ///<summary>(300A,0626) VR=FD VM=1 Radiation Dose Source to Skin Distance</summary>
        public const uint RadiationDoseSourceToSkinDistance = 0x300A0626;

        ///<summary>(300A,0627) VR=FD VM=3 Radiation Dose Measurement Point Coordinates</summary>
        public const uint RadiationDoseMeasurementPointCoordinates = 0x300A0627;

        ///<summary>(300A,0628) VR=FD VM=1 Radiation Dose Source to External Contour Distance</summary>
        public const uint RadiationDoseSourceToExternalContourDistance = 0x300A0628;

        ///<summary>(300A,0629) VR=SQ VM=1 RT Tolerance Set Sequence</summary>
        public const uint RTToleranceSetSequence = 0x300A0629;

        ///<summary>(300A,062A) VR=LO VM=1 RT Tolerance Set Label</summary>
        public const uint RTToleranceSetLabel = 0x300A062A;

        ///<summary>(300A,062B) VR=SQ VM=1 Attribute Tolerance Values Sequence</summary>
        public const uint AttributeToleranceValuesSequence = 0x300A062B;

        ///<summary>(300A,062C) VR=FD VM=1 Tolerance Value</summary>
        public const uint ToleranceValue = 0x300A062C;

        ///<summary>(300A,062D) VR=SQ VM=1 Patient Support Position Tolerance Sequence</summary>
        public const uint PatientSupportPositionToleranceSequence = 0x300A062D;

        ///<summary>(300A,062E) VR=FD VM=1 Treatment Time Limit</summary>
        public const uint TreatmentTimeLimit = 0x300A062E;

        ///<summary>(300A,062F) VR=SQ VM=1 C-Arm Photon-Electron Control Point Sequence</summary>
        public const uint CArmPhotonElectronControlPointSequence = 0x300A062F;

        ///<summary>(300A,0630) VR=SQ VM=1 Referenced RT Radiation Sequence</summary>
        public const uint ReferencedRTRadiationSequence = 0x300A0630;

        ///<summary>(300A,0631) VR=SQ VM=1 Referenced RT Instance Sequence</summary>
        public const uint ReferencedRTInstanceSequence = 0x300A0631;

        ///<summary>(300A,0632) VR=SQ VM=1 Referenced RT Patient Setup Sequence (RETIRED)</summary>
        public const uint ReferencedRTPatientSetupSequenceRETIRED = 0x300A0632;

        ///<summary>(300A,0634) VR=FD VM=1 Source to Patient Surface Distance</summary>
        public const uint SourceToPatientSurfaceDistance = 0x300A0634;

        ///<summary>(300A,0635) VR=SQ VM=1 Treatment Machine Special Mode Code Sequence</summary>
        public const uint TreatmentMachineSpecialModeCodeSequence = 0x300A0635;

        ///<summary>(300A,0636) VR=US VM=1 Intended Number of Fractions</summary>
        public const uint IntendedNumberOfFractions = 0x300A0636;

        ///<summary>(300A,0637) VR=CS VM=1 RT Radiation Set Intent</summary>
        public const uint RTRadiationSetIntent = 0x300A0637;

        ///<summary>(300A,0638) VR=CS VM=1 RT Radiation Physical and Geometric Content Detail Flag</summary>
        public const uint RTRadiationPhysicalAndGeometricContentDetailFlag = 0x300A0638;

        ///<summary>(300A,0639) VR=CS VM=1 RT Record Flag</summary>
        public const uint RTRecordFlag = 0x300A0639;

        ///<summary>(300A,063A) VR=SQ VM=1 Treatment Device Identification Sequence</summary>
        public const uint TreatmentDeviceIdentificationSequence = 0x300A063A;

        ///<summary>(300A,063B) VR=SQ VM=1 Referenced RT Physician Intent Sequence</summary>
        public const uint ReferencedRTPhysicianIntentSequence = 0x300A063B;

        ///<summary>(300A,063C) VR=FD VM=1 Cumulative Meterset</summary>
        public const uint CumulativeMeterset = 0x300A063C;

        ///<summary>(300A,063D) VR=FD VM=1 Delivery Rate</summary>
        public const uint DeliveryRate = 0x300A063D;

        ///<summary>(300A,063E) VR=SQ VM=1 Delivery Rate Unit Sequence</summary>
        public const uint DeliveryRateUnitSequence = 0x300A063E;

        ///<summary>(300A,063F) VR=SQ VM=1 Treatment Position Sequence</summary>
        public const uint TreatmentPositionSequence = 0x300A063F;

        ///<summary>(300A,0640) VR=FD VM=1 Radiation Source-Axis Distance</summary>
        public const uint RadiationSourceAxisDistance = 0x300A0640;

        ///<summary>(300A,0641) VR=US VM=1 Number of RT Beam Limiting Devices</summary>
        public const uint NumberOfRTBeamLimitingDevices = 0x300A0641;

        ///<summary>(300A,0642) VR=FD VM=1 RT Beam Limiting Device Proximal Distance</summary>
        public const uint RTBeamLimitingDeviceProximalDistance = 0x300A0642;

        ///<summary>(300A,0643) VR=FD VM=1 RT Beam Limiting Device Distal Distance</summary>
        public const uint RTBeamLimitingDeviceDistalDistance = 0x300A0643;

        ///<summary>(300A,0644) VR=SQ VM=1 Parallel RT Beam Delimiter Device Orientation Label Code Sequence</summary>
        public const uint ParallelRTBeamDelimiterDeviceOrientationLabelCodeSequence = 0x300A0644;

        ///<summary>(300A,0645) VR=FD VM=1 Beam Modifier Orientation Angle</summary>
        public const uint BeamModifierOrientationAngle = 0x300A0645;

        ///<summary>(300A,0646) VR=SQ VM=1 Fixed RT Beam Delimiter Device Sequence</summary>
        public const uint FixedRTBeamDelimiterDeviceSequence = 0x300A0646;

        ///<summary>(300A,0647) VR=SQ VM=1 Parallel RT Beam Delimiter Device Sequence</summary>
        public const uint ParallelRTBeamDelimiterDeviceSequence = 0x300A0647;

        ///<summary>(300A,0648) VR=US VM=1 Number of Parallel RT Beam Delimiters</summary>
        public const uint NumberOfParallelRTBeamDelimiters = 0x300A0648;

        ///<summary>(300A,0649) VR=FD VM=2-n Parallel RT Beam Delimiter Boundaries</summary>
        public const uint ParallelRTBeamDelimiterBoundaries = 0x300A0649;

        ///<summary>(300A,064A) VR=FD VM=2-n Parallel RT Beam Delimiter Positions</summary>
        public const uint ParallelRTBeamDelimiterPositions = 0x300A064A;

        ///<summary>(300A,064B) VR=FD VM=2 RT Beam Limiting Device Offset</summary>
        public const uint RTBeamLimitingDeviceOffset = 0x300A064B;

        ///<summary>(300A,064C) VR=SQ VM=1 RT Beam Delimiter Geometry Sequence</summary>
        public const uint RTBeamDelimiterGeometrySequence = 0x300A064C;

        ///<summary>(300A,064D) VR=SQ VM=1 RT Beam Limiting Device Definition Sequence</summary>
        public const uint RTBeamLimitingDeviceDefinitionSequence = 0x300A064D;

        ///<summary>(300A,064E) VR=CS VM=1 Parallel RT Beam Delimiter Opening Mode</summary>
        public const uint ParallelRTBeamDelimiterOpeningMode = 0x300A064E;

        ///<summary>(300A,064F) VR=CS VM=1-n Parallel RT Beam Delimiter Leaf Mounting Side</summary>
        public const uint ParallelRTBeamDelimiterLeafMountingSide = 0x300A064F;

        ///<summary>(300A,0650) VR=UI VM=1 Patient Setup Uid (RETIRED)</summary>
        public const uint PatientSetupUidRETIRED = 0x300A0650;

        ///<summary>(300A,0651) VR=SQ VM=1 Wedge Definition Sequence</summary>
        public const uint WedgeDefinitionSequence = 0x300A0651;

        ///<summary>(300A,0652) VR=FD VM=1 Radiation Beam Wedge Angle</summary>
        public const uint RadiationBeamWedgeAngle = 0x300A0652;

        ///<summary>(300A,0653) VR=FD VM=1 Radiation Beam Wedge Thin Edge Distance</summary>
        public const uint RadiationBeamWedgeThinEdgeDistance = 0x300A0653;

        ///<summary>(300A,0654) VR=FD VM=1 Radiation Beam Effective Wedge Angle</summary>
        public const uint RadiationBeamEffectiveWedgeAngle = 0x300A0654;

        ///<summary>(300A,0655) VR=US VM=1 Number of Wedge Positions</summary>
        public const uint NumberOfWedgePositions = 0x300A0655;

        ///<summary>(300A,0656) VR=SQ VM=1 RT Beam Limiting Device Opening Sequence</summary>
        public const uint RTBeamLimitingDeviceOpeningSequence = 0x300A0656;

        ///<summary>(300A,0657) VR=US VM=1 Number of RT Beam Limiting Device Openings</summary>
        public const uint NumberOfRTBeamLimitingDeviceOpenings = 0x300A0657;

        ///<summary>(300A,0658) VR=SQ VM=1 Radiation Dosimeter Unit Sequence</summary>
        public const uint RadiationDosimeterUnitSequence = 0x300A0658;

        ///<summary>(300A,0659) VR=SQ VM=1 RT Device Distance Reference Location Code Sequence</summary>
        public const uint RTDeviceDistanceReferenceLocationCodeSequence = 0x300A0659;

        ///<summary>(300A,065A) VR=SQ VM=1 Radiation Device Configuration and Commissioning Key Sequence</summary>
        public const uint RadiationDeviceConfigurationAndCommissioningKeySequence = 0x300A065A;

        ///<summary>(300A,065B) VR=SQ VM=1 Patient Support Position Parameter Sequence</summary>
        public const uint PatientSupportPositionParameterSequence = 0x300A065B;

        ///<summary>(300A,065C) VR=CS VM=1 Patient Support Position Specification Method</summary>
        public const uint PatientSupportPositionSpecificationMethod = 0x300A065C;

        ///<summary>(300A,065D) VR=SQ VM=1 Patient Support Position Device Parameter Sequence</summary>
        public const uint PatientSupportPositionDeviceParameterSequence = 0x300A065D;

        ///<summary>(300A,065E) VR=US VM=1 Device Order Index</summary>
        public const uint DeviceOrderIndex = 0x300A065E;

        ///<summary>(300A,065F) VR=US VM=1 Patient Support Position Parameter Order Index</summary>
        public const uint PatientSupportPositionParameterOrderIndex = 0x300A065F;

        ///<summary>(300A,0660) VR=SQ VM=1 Patient Support Position Device Tolerance Sequence</summary>
        public const uint PatientSupportPositionDeviceToleranceSequence = 0x300A0660;

        ///<summary>(300A,0661) VR=US VM=1 Patient Support Position Tolerance Order Index</summary>
        public const uint PatientSupportPositionToleranceOrderIndex = 0x300A0661;

        ///<summary>(300A,0662) VR=SQ VM=1 Compensator Definition Sequence</summary>
        public const uint CompensatorDefinitionSequence = 0x300A0662;

        ///<summary>(300A,0663) VR=CS VM=1 Compensator Map Orientation</summary>
        public const uint CompensatorMapOrientation = 0x300A0663;

        ///<summary>(300A,0664) VR=OF VM=1 Compensator Proximal Thickness Map</summary>
        public const uint CompensatorProximalThicknessMap = 0x300A0664;

        ///<summary>(300A,0665) VR=OF VM=1 Compensator Distal Thickness Map</summary>
        public const uint CompensatorDistalThicknessMap = 0x300A0665;

        ///<summary>(300A,0666) VR=FD VM=1 Compensator Base Plane Offset</summary>
        public const uint CompensatorBasePlaneOffset = 0x300A0666;

        ///<summary>(300A,0667) VR=SQ VM=1 Compensator Shape Fabrication Code Sequence</summary>
        public const uint CompensatorShapeFabricationCodeSequence = 0x300A0667;

        ///<summary>(300A,0668) VR=SQ VM=1 Compensator Shape Sequence</summary>
        public const uint CompensatorShapeSequence = 0x300A0668;

        ///<summary>(300A,0669) VR=FD VM=1 Radiation Beam Compensator Milling Tool Diameter</summary>
        public const uint RadiationBeamCompensatorMillingToolDiameter = 0x300A0669;

        ///<summary>(300A,066A) VR=SQ VM=1 Block Definition Sequence</summary>
        public const uint BlockDefinitionSequence = 0x300A066A;

        ///<summary>(300A,066B) VR=OF VM=1 Block Edge Data</summary>
        public const uint BlockEdgeData = 0x300A066B;

        ///<summary>(300A,066C) VR=CS VM=1 Block Orientation</summary>
        public const uint BlockOrientation = 0x300A066C;

        ///<summary>(300A,066D) VR=FD VM=1 Radiation Beam Block Thickness</summary>
        public const uint RadiationBeamBlockThickness = 0x300A066D;

        ///<summary>(300A,066E) VR=FD VM=1 Radiation Beam Block Slab Thickness</summary>
        public const uint RadiationBeamBlockSlabThickness = 0x300A066E;

        ///<summary>(300A,066F) VR=SQ VM=1 Block Edge Data Sequence</summary>
        public const uint BlockEdgeDataSequence = 0x300A066F;

        ///<summary>(300A,0670) VR=US VM=1 Number of RT Accessory Holders</summary>
        public const uint NumberOfRTAccessoryHolders = 0x300A0670;

        ///<summary>(300A,0671) VR=SQ VM=1 General Accessory Definition Sequence</summary>
        public const uint GeneralAccessoryDefinitionSequence = 0x300A0671;

        ///<summary>(300A,0672) VR=US VM=1 Number of General Accessories</summary>
        public const uint NumberOfGeneralAccessories = 0x300A0672;

        ///<summary>(300A,0673) VR=SQ VM=1 Bolus Definition Sequence</summary>
        public const uint BolusDefinitionSequence = 0x300A0673;

        ///<summary>(300A,0674) VR=US VM=1 Number of Boluses</summary>
        public const uint NumberOfBoluses = 0x300A0674;

        ///<summary>(300A,0675) VR=UI VM=1 Equipment Frame of Reference Uid</summary>
        public const uint EquipmentFrameOfReferenceUid = 0x300A0675;

        ///<summary>(300A,0676) VR=ST VM=1 Equipment Frame of Reference Description</summary>
        public const uint EquipmentFrameOfReferenceDescription = 0x300A0676;

        ///<summary>(300A,0677) VR=SQ VM=1 Equipment Reference Point Coordinates Sequence</summary>
        public const uint EquipmentReferencePointCoordinatesSequence = 0x300A0677;

        ///<summary>(300A,0678) VR=SQ VM=1 Equipment Reference Point Code Sequence</summary>
        public const uint EquipmentReferencePointCodeSequence = 0x300A0678;

        ///<summary>(300A,0679) VR=FD VM=1 RT Beam Limiting Device Angle</summary>
        public const uint RTBeamLimitingDeviceAngle = 0x300A0679;

        ///<summary>(300A,067A) VR=FD VM=1 Source Roll Angle</summary>
        public const uint SourceRollAngle = 0x300A067A;

        ///<summary>(300A,067B) VR=SQ VM=1 Radiation GenerationMode Sequence</summary>
        public const uint RadiationGenerationModeSequence = 0x300A067B;

        ///<summary>(300A,067C) VR=SH VM=1 Radiation GenerationMode Label</summary>
        public const uint RadiationGenerationModeLabel = 0x300A067C;

        ///<summary>(300A,067D) VR=ST VM=1 Radiation GenerationMode Description</summary>
        public const uint RadiationGenerationModeDescription = 0x300A067D;

        ///<summary>(300A,067E) VR=SQ VM=1 Radiation GenerationMode Machine Code Sequence</summary>
        public const uint RadiationGenerationModeMachineCodeSequence = 0x300A067E;

        ///<summary>(300A,067F) VR=SQ VM=1 Radiation Type Code Sequence</summary>
        public const uint RadiationTypeCodeSequence = 0x300A067F;

        ///<summary>(300A,0680) VR=DS VM=1 Nominal Energy</summary>
        public const uint NominalEnergy = 0x300A0680;

        ///<summary>(300A,0681) VR=DS VM=1 Minimum Nominal Energy</summary>
        public const uint MinimumNominalEnergy = 0x300A0681;

        ///<summary>(300A,0682) VR=DS VM=1 Maximum Nominal Energy</summary>
        public const uint MaximumNominalEnergy = 0x300A0682;

        ///<summary>(300A,0683) VR=SQ VM=1 Radiation Fluence Modifier Code Sequence</summary>
        public const uint RadiationFluenceModifierCodeSequence = 0x300A0683;

        ///<summary>(300A,0684) VR=SQ VM=1 Energy Unit Code Sequence</summary>
        public const uint EnergyUnitCodeSequence = 0x300A0684;

        ///<summary>(300A,0685) VR=US VM=1 Number of Radiation GenerationModes</summary>
        public const uint NumberOfRadiationGenerationModes = 0x300A0685;

        ///<summary>(300A,0686) VR=SQ VM=1 Patient Support Devices Sequence</summary>
        public const uint PatientSupportDevicesSequence = 0x300A0686;

        ///<summary>(300A,0687) VR=US VM=1 Number of Patient Support Devices</summary>
        public const uint NumberOfPatientSupportDevices = 0x300A0687;

        ///<summary>(300A,0688) VR=FD VM=1 RT Beam Modifier Definition Distance</summary>
        public const uint RTBeamModifierDefinitionDistance = 0x300A0688;

        ///<summary>(300A,0689) VR=SQ VM=1 Beam Area Limit Sequence</summary>
        public const uint BeamAreaLimitSequence = 0x300A0689;

        ///<summary>(300A,068A) VR=SQ VM=1 Referenced RT Prescription Sequence</summary>
        public const uint ReferencedRTPrescriptionSequence = 0x300A068A;

        ///<summary>(300A,0700) VR=UI VM=1 Treatment Session Uid</summary>
        public const uint TreatmentSessionUid = 0x300A0700;

        ///<summary>(300A,0701) VR=CS VM=1 RT Radiation Usage</summary>
        public const uint RTRadiationUsage = 0x300A0701;

        ///<summary>(300A,0702) VR=SQ VM=1 Referenced RT Radiation Set Sequence</summary>
        public const uint ReferencedRTRadiationSetSequence = 0x300A0702;

        ///<summary>(300A,0703) VR=SQ VM=1 Referenced RT Radiation Record Sequence</summary>
        public const uint ReferencedRTRadiationRecordSequence = 0x300A0703;

        ///<summary>(300A,0704) VR=US VM=1 RT Radiation Set Delivery Number</summary>
        public const uint RTRadiationSetDeliveryNumber = 0x300A0704;

        ///<summary>(300A,0705) VR=US VM=1 Clinical Fraction Number</summary>
        public const uint ClinicalFractionNumber = 0x300A0705;

        ///<summary>(300A,0706) VR=CS VM=1 RT Treatment Fraction Completion Status</summary>
        public const uint RTTreatmentFractionCompletionStatus = 0x300A0706;

        ///<summary>(300A,0707) VR=CS VM=1 RT Radiation Set Usage</summary>
        public const uint RTRadiationSetUsage = 0x300A0707;

        ///<summary>(300A,0708) VR=CS VM=1 Treatment Delivery Continuation Flag</summary>
        public const uint TreatmentDeliveryContinuationFlag = 0x300A0708;

        ///<summary>(300A,0709) VR=CS VM=1 Treatment Record Content Origin</summary>
        public const uint TreatmentRecordContentOrigin = 0x300A0709;

        ///<summary>(300A,0714) VR=CS VM=1 RT Treatment Termination Status</summary>
        public const uint RTTreatmentTerminationStatus = 0x300A0714;

        ///<summary>(300A,0715) VR=SQ VM=1 RT Treatment Termination Reason Code Sequence</summary>
        public const uint RTTreatmentTerminationReasonCodeSequence = 0x300A0715;

        ///<summary>(300A,0716) VR=SQ VM=1 Machine-Specific Treatment Termination Code Sequence</summary>
        public const uint MachineSpecificTreatmentTerminationCodeSequence = 0x300A0716;

        ///<summary>(300A,0722) VR=SQ VM=1 RT Radiation Salvage Record Control Point Sequence</summary>
        public const uint RTRadiationSalvageRecordControlPointSequence = 0x300A0722;

        ///<summary>(300A,0723) VR=CS VM=1 Starting Meterset Value Known Flag</summary>
        public const uint StartingMetersetValueKnownFlag = 0x300A0723;

        ///<summary>(300A,0730) VR=ST VM=1 Treatment Termination Description</summary>
        public const uint TreatmentTerminationDescription = 0x300A0730;

        ///<summary>(300A,0731) VR=SQ VM=1 Treatment Tolerance Violation Sequence</summary>
        public const uint TreatmentToleranceViolationSequence = 0x300A0731;

        ///<summary>(300A,0732) VR=CS VM=1 Treatment Tolerance Violation Category</summary>
        public const uint TreatmentToleranceViolationCategory = 0x300A0732;

        ///<summary>(300A,0733) VR=SQ VM=1 Treatment Tolerance Violation Attribute Sequence</summary>
        public const uint TreatmentToleranceViolationAttributeSequence = 0x300A0733;

        ///<summary>(300A,0734) VR=ST VM=1 Treatment Tolerance Violation Description</summary>
        public const uint TreatmentToleranceViolationDescription = 0x300A0734;

        ///<summary>(300A,0735) VR=ST VM=1 Treatment Tolerance Violation Identification</summary>
        public const uint TreatmentToleranceViolationIdentification = 0x300A0735;

        ///<summary>(300A,0736) VR=DT VM=1 Treatment Tolerance Violation DateTime</summary>
        public const uint TreatmentToleranceViolationDateTime = 0x300A0736;

        ///<summary>(300A,073A) VR=DT VM=1 Recorded RT Control Point DateTime</summary>
        public const uint RecordedRTControlPointDateTime = 0x300A073A;

        ///<summary>(300A,073B) VR=US VM=1 Referenced Radiation RT Control Point Index</summary>
        public const uint ReferencedRadiationRTControlPointIndex = 0x300A073B;

        ///<summary>(300A,073E) VR=SQ VM=1 Alternate Value Sequence</summary>
        public const uint AlternateValueSequence = 0x300A073E;

        ///<summary>(300A,073F) VR=SQ VM=1 Confirmation Sequence</summary>
        public const uint ConfirmationSequence = 0x300A073F;

        ///<summary>(300A,0740) VR=SQ VM=1 Interlock Sequence</summary>
        public const uint InterlockSequence = 0x300A0740;

        ///<summary>(300A,0741) VR=DT VM=1 Interlock DateTime</summary>
        public const uint InterlockDateTime = 0x300A0741;

        ///<summary>(300A,0742) VR=ST VM=1 Interlock Description</summary>
        public const uint InterlockDescription = 0x300A0742;

        ///<summary>(300A,0743) VR=SQ VM=1 Interlock Originating Device Sequence</summary>
        public const uint InterlockOriginatingDeviceSequence = 0x300A0743;

        ///<summary>(300A,0744) VR=SQ VM=1 Interlock Code Sequence</summary>
        public const uint InterlockCodeSequence = 0x300A0744;

        ///<summary>(300A,0745) VR=SQ VM=1 Interlock Resolution Code Sequence</summary>
        public const uint InterlockResolutionCodeSequence = 0x300A0745;

        ///<summary>(300A,0746) VR=SQ VM=1 Interlock Resolution User Sequence</summary>
        public const uint InterlockResolutionUserSequence = 0x300A0746;

        ///<summary>(300A,0760) VR=DT VM=1 Override DateTime</summary>
        public const uint OverrideDateTime = 0x300A0760;

        ///<summary>(300A,0761) VR=SQ VM=1 Treatment Tolerance Violation Type Code Sequence</summary>
        public const uint TreatmentToleranceViolationTypeCodeSequence = 0x300A0761;

        ///<summary>(300A,0762) VR=SQ VM=1 Treatment Tolerance Violation Cause Code Sequence</summary>
        public const uint TreatmentToleranceViolationCauseCodeSequence = 0x300A0762;

        ///<summary>(300A,0772) VR=SQ VM=1 Measured Meterset to Dose Mapping Sequence</summary>
        public const uint MeasuredMetersetToDoseMappingSequence = 0x300A0772;

        ///<summary>(300A,0773) VR=US VM=1 Referenced Expected In-Vivo Measurement Value Index</summary>
        public const uint ReferencedExpectedInVivoMeasurementValueIndex = 0x300A0773;

        ///<summary>(300A,0774) VR=SQ VM=1 Dose Measurement Device Code Sequence</summary>
        public const uint DoseMeasurementDeviceCodeSequence = 0x300A0774;

        ///<summary>(300A,0780) VR=SQ VM=1 Additional Parameter Recording Instance Sequence</summary>
        public const uint AdditionalParameterRecordingInstanceSequence = 0x300A0780;

        ///<summary>(300A,0783) VR=ST VM=1 Interlock Origin Description</summary>
        public const uint InterlockOriginDescription = 0x300A0783;

        ///<summary>(300A,0784) VR=SQ VM=1 RT Patient Position Scope Sequence</summary>
        public const uint RTPatientPositionScopeSequence = 0x300A0784;

        ///<summary>(300A,0785) VR=UI VM=1 Referenced Treatment Position Group Uid</summary>
        public const uint ReferencedTreatmentPositionGroupUid = 0x300A0785;

        ///<summary>(300A,0786) VR=US VM=1 Radiation Order Index</summary>
        public const uint RadiationOrderIndex = 0x300A0786;

        ///<summary>(300A,0787) VR=SQ VM=1 Omitted Radiation Sequence</summary>
        public const uint OmittedRadiationSequence = 0x300A0787;

        ///<summary>(300A,0788) VR=SQ VM=1 Reason for Omission Code Sequence</summary>
        public const uint ReasonForOmissionCodeSequence = 0x300A0788;

        ///<summary>(300A,0789) VR=SQ VM=1 RT Delivery Start Patient Position Sequence</summary>
        public const uint RTDeliveryStartPatientPositionSequence = 0x300A0789;

        ///<summary>(300A,078A) VR=SQ VM=1 RT Treatment Preparation Patient Position Sequence</summary>
        public const uint RTTreatmentPreparationPatientPositionSequence = 0x300A078A;

        ///<summary>(300A,078B) VR=SQ VM=1 Referenced RT Treatment Preparation Sequence</summary>
        public const uint ReferencedRTTreatmentPreparationSequence = 0x300A078B;

        ///<summary>(300A,078C) VR=SQ VM=1 Referenced Patient Setup Photo Sequence</summary>
        public const uint ReferencedPatientSetupPhotoSequence = 0x300A078C;

        ///<summary>(300A,078D) VR=SQ VM=1 Patient Treatment Preparation Method Code Sequence</summary>
        public const uint PatientTreatmentPreparationMethodCodeSequence = 0x300A078D;

        ///<summary>(300A,078E) VR=LT VM=1 Patient Treatment Preparation Procedure Parameter Description</summary>
        public const uint PatientTreatmentPreparationProcedureParameterDescription = 0x300A078E;

        ///<summary>(300A,078F) VR=SQ VM=1 Patient Treatment Preparation Device Sequence</summary>
        public const uint PatientTreatmentPreparationDeviceSequence = 0x300A078F;

        ///<summary>(300A,0790) VR=SQ VM=1 Patient Treatment Preparation Procedure Sequence </summary>
        public const uint PatientTreatmentPreparationProcedureSequence = 0x300A0790;

        ///<summary>(300A,0791) VR=SQ VM=1 Patient Treatment Preparation Procedure Code Sequence</summary>
        public const uint PatientTreatmentPreparationProcedureCodeSequence = 0x300A0791;

        ///<summary>(300A,0792) VR=LT VM=1 Patient Treatment Preparation Method Description</summary>
        public const uint PatientTreatmentPreparationMethodDescription = 0x300A0792;

        ///<summary>(300A,0793) VR=SQ VM=1 Patient Treatment Preparation Procedure Parameter Sequence</summary>
        public const uint PatientTreatmentPreparationProcedureParameterSequence = 0x300A0793;

        ///<summary>(300A,0794) VR=LT VM=1 Patient Setup Photo Description</summary>
        public const uint PatientSetupPhotoDescription = 0x300A0794;

        ///<summary>(300A,0795) VR=US VM=1 Patient Treatment Preparation Procedure Index</summary>
        public const uint PatientTreatmentPreparationProcedureIndex = 0x300A0795;

        ///<summary>(300A,0796) VR=US VM=1 Referenced Patient Setup Procedure Index</summary>
        public const uint ReferencedPatientSetupProcedureIndex = 0x300A0796;

        ///<summary>(300A,0797) VR=SQ VM=1 RT Radiation Task Sequence</summary>
        public const uint RTRadiationTaskSequence = 0x300A0797;

        ///<summary>(300A,0798) VR=SQ VM=1 RT Patient Position Displacement Sequence</summary>
        public const uint RTPatientPositionDisplacementSequence = 0x300A0798;

        ///<summary>(300A,0799) VR=SQ VM=1 RT Patient Position Sequence</summary>
        public const uint RTPatientPositionSequence = 0x300A0799;

        ///<summary>(300A,079A) VR=LO VM=1 Displacement Reference Label</summary>
        public const uint DisplacementReferenceLabel = 0x300A079A;

        ///<summary>(300A,079B) VR=FD VM=16 Displacement Matrix</summary>
        public const uint DisplacementMatrix = 0x300A079B;

        ///<summary>(300A,079C) VR=SQ VM=1 Patient Support Displacement Sequence</summary>
        public const uint PatientSupportDisplacementSequence = 0x300A079C;

        ///<summary>(300A,079D) VR=SQ VM=1 Displacement Reference Location Code Sequence</summary>
        public const uint DisplacementReferenceLocationCodeSequence = 0x300A079D;

        ///<summary>(300A,079E) VR=CS VM=1 RT Radiation Set Delivery Usage</summary>
        public const uint RTRadiationSetDeliveryUsage = 0x300A079E;

        ///<summary>(300C,0002) VR=SQ VM=1 Referenced RT Plan Sequence</summary>
        public const uint ReferencedRTPlanSequence = 0x300C0002;

        ///<summary>(300C,0004) VR=SQ VM=1 Referenced Beam Sequence</summary>
        public const uint ReferencedBeamSequence = 0x300C0004;

        ///<summary>(300C,0006) VR=IS VM=1 Referenced Beam Number</summary>
        public const uint ReferencedBeamNumber = 0x300C0006;

        ///<summary>(300C,0007) VR=IS VM=1 Referenced Reference Image Number</summary>
        public const uint ReferencedReferenceImageNumber = 0x300C0007;

        ///<summary>(300C,0008) VR=DS VM=1 Start Cumulative Meterset Weight</summary>
        public const uint StartCumulativeMetersetWeight = 0x300C0008;

        ///<summary>(300C,0009) VR=DS VM=1 End Cumulative Meterset Weight</summary>
        public const uint EndCumulativeMetersetWeight = 0x300C0009;

        ///<summary>(300C,000A) VR=SQ VM=1 Referenced Brachy Application Setup Sequence</summary>
        public const uint ReferencedBrachyApplicationSetupSequence = 0x300C000A;

        ///<summary>(300C,000C) VR=IS VM=1 Referenced Brachy Application Setup Number</summary>
        public const uint ReferencedBrachyApplicationSetupNumber = 0x300C000C;

        ///<summary>(300C,000E) VR=IS VM=1 Referenced Source Number</summary>
        public const uint ReferencedSourceNumber = 0x300C000E;

        ///<summary>(300C,0020) VR=SQ VM=1 Referenced Fraction Group Sequence</summary>
        public const uint ReferencedFractionGroupSequence = 0x300C0020;

        ///<summary>(300C,0022) VR=IS VM=1 Referenced Fraction Group Number</summary>
        public const uint ReferencedFractionGroupNumber = 0x300C0022;

        ///<summary>(300C,0040) VR=SQ VM=1 Referenced Verification Image Sequence</summary>
        public const uint ReferencedVerificationImageSequence = 0x300C0040;

        ///<summary>(300C,0042) VR=SQ VM=1 Referenced Reference Image Sequence</summary>
        public const uint ReferencedReferenceImageSequence = 0x300C0042;

        ///<summary>(300C,0050) VR=SQ VM=1 Referenced Dose Reference Sequence</summary>
        public const uint ReferencedDoseReferenceSequence = 0x300C0050;

        ///<summary>(300C,0051) VR=IS VM=1 Referenced Dose Reference Number</summary>
        public const uint ReferencedDoseReferenceNumber = 0x300C0051;

        ///<summary>(300C,0055) VR=SQ VM=1 Brachy Referenced Dose Reference Sequence</summary>
        public const uint BrachyReferencedDoseReferenceSequence = 0x300C0055;

        ///<summary>(300C,0060) VR=SQ VM=1 Referenced Structure Set Sequence</summary>
        public const uint ReferencedStructureSetSequence = 0x300C0060;

        ///<summary>(300C,006A) VR=IS VM=1 Referenced Patient Setup Number</summary>
        public const uint ReferencedPatientSetupNumber = 0x300C006A;

        ///<summary>(300C,0080) VR=SQ VM=1 Referenced Dose Sequence</summary>
        public const uint ReferencedDoseSequence = 0x300C0080;

        ///<summary>(300C,00A0) VR=IS VM=1 Referenced Tolerance Table Number</summary>
        public const uint ReferencedToleranceTableNumber = 0x300C00A0;

        ///<summary>(300C,00B0) VR=SQ VM=1 Referenced Bolus Sequence</summary>
        public const uint ReferencedBolusSequence = 0x300C00B0;

        ///<summary>(300C,00C0) VR=IS VM=1 Referenced Wedge Number</summary>
        public const uint ReferencedWedgeNumber = 0x300C00C0;

        ///<summary>(300C,00D0) VR=IS VM=1 Referenced Compensator Number</summary>
        public const uint ReferencedCompensatorNumber = 0x300C00D0;

        ///<summary>(300C,00E0) VR=IS VM=1 Referenced Block Number</summary>
        public const uint ReferencedBlockNumber = 0x300C00E0;

        ///<summary>(300C,00F0) VR=IS VM=1 Referenced Control Point Index</summary>
        public const uint ReferencedControlPointIndex = 0x300C00F0;

        ///<summary>(300C,00F2) VR=SQ VM=1 Referenced Control Point Sequence</summary>
        public const uint ReferencedControlPointSequence = 0x300C00F2;

        ///<summary>(300C,00F4) VR=IS VM=1 Referenced Start Control Point Index</summary>
        public const uint ReferencedStartControlPointIndex = 0x300C00F4;

        ///<summary>(300C,00F6) VR=IS VM=1 Referenced Stop Control Point Index</summary>
        public const uint ReferencedStopControlPointIndex = 0x300C00F6;

        ///<summary>(300C,0100) VR=IS VM=1 Referenced Range Shifter Number</summary>
        public const uint ReferencedRangeShifterNumber = 0x300C0100;

        ///<summary>(300C,0102) VR=IS VM=1 Referenced Lateral Spreading Device Number</summary>
        public const uint ReferencedLateralSpreadingDeviceNumber = 0x300C0102;

        ///<summary>(300C,0104) VR=IS VM=1 Referenced Range Modulator Number</summary>
        public const uint ReferencedRangeModulatorNumber = 0x300C0104;

        ///<summary>(300C,0111) VR=SQ VM=1 Omitted Beam Task Sequence</summary>
        public const uint OmittedBeamTaskSequence = 0x300C0111;

        ///<summary>(300C,0112) VR=CS VM=1 Reason for Omission</summary>
        public const uint ReasonForOmission = 0x300C0112;

        ///<summary>(300C,0113) VR=LO VM=1 Reason for Omission Description</summary>
        public const uint ReasonForOmissionDescription = 0x300C0113;

        ///<summary>(300E,0002) VR=CS VM=1 Approval Status</summary>
        public const uint ApprovalStatus = 0x300E0002;

        ///<summary>(300E,0004) VR=DA VM=1 Review Date</summary>
        public const uint ReviewDate = 0x300E0004;

        ///<summary>(300E,0005) VR=TM VM=1 Review Time</summary>
        public const uint ReviewTime = 0x300E0005;

        ///<summary>(300E,0008) VR=PN VM=1 Reviewer Name</summary>
        public const uint ReviewerName = 0x300E0008;

        ///<summary>(3010,0001) VR=SQ VM=1 Radiobiological Dose Effect Sequence</summary>
        public const uint RadiobiologicalDoseEffectSequence = 0x30100001;

        ///<summary>(3010,0002) VR=CS VM=1 Radiobiological Dose Effect Flag</summary>
        public const uint RadiobiologicalDoseEffectFlag = 0x30100002;

        ///<summary>(3010,0003) VR=SQ VM=1 Effective Dose Calculation Method Category Code Sequence</summary>
        public const uint EffectiveDoseCalculationMethodCategoryCodeSequence = 0x30100003;

        ///<summary>(3010,0004) VR=SQ VM=1 Effective Dose Calculation Method Code Sequence</summary>
        public const uint EffectiveDoseCalculationMethodCodeSequence = 0x30100004;

        ///<summary>(3010,0005) VR=LO VM=1 Effective Dose Calculation Method Description</summary>
        public const uint EffectiveDoseCalculationMethodDescription = 0x30100005;

        ///<summary>(3010,0006) VR=UI VM=1 Conceptual Volume Uid</summary>
        public const uint ConceptualVolumeUid = 0x30100006;

        ///<summary>(3010,0007) VR=SQ VM=1 Originating Sop Instance Reference Sequence</summary>
        public const uint OriginatingSopInstanceReferenceSequence = 0x30100007;

        ///<summary>(3010,0008) VR=SQ VM=1 Conceptual Volume Constituent Sequence</summary>
        public const uint ConceptualVolumeConstituentSequence = 0x30100008;

        ///<summary>(3010,0009) VR=SQ VM=1 Equivalent Conceptual Volume Instance Reference Sequence</summary>
        public const uint EquivalentConceptualVolumeInstanceReferenceSequence = 0x30100009;

        ///<summary>(3010,000A) VR=SQ VM=1 Equivalent Conceptual Volumes Sequence</summary>
        public const uint EquivalentConceptualVolumesSequence = 0x3010000A;

        ///<summary>(3010,000B) VR=UI VM=1 Referenced Conceptual Volume Uid</summary>
        public const uint ReferencedConceptualVolumeUid = 0x3010000B;

        ///<summary>(3010,000C) VR=UT VM=1 Conceptual Volume Combination Expression</summary>
        public const uint ConceptualVolumeCombinationExpression = 0x3010000C;

        ///<summary>(3010,000D) VR=US VM=1 Conceptual Volume Constituent Index</summary>
        public const uint ConceptualVolumeConstituentIndex = 0x3010000D;

        ///<summary>(3010,000E) VR=CS VM=1 Conceptual Volume Combination Flag</summary>
        public const uint ConceptualVolumeCombinationFlag = 0x3010000E;

        ///<summary>(3010,000F) VR=ST VM=1 Conceptual Volume Combination Description</summary>
        public const uint ConceptualVolumeCombinationDescription = 0x3010000F;

        ///<summary>(3010,0010) VR=CS VM=1 Conceptual Volume Segmentation Defined Flag</summary>
        public const uint ConceptualVolumeSegmentationDefinedFlag = 0x30100010;

        ///<summary>(3010,0011) VR=SQ VM=1 Conceptual Volume Segmentation Reference Sequence</summary>
        public const uint ConceptualVolumeSegmentationReferenceSequence = 0x30100011;

        ///<summary>(3010,0012) VR=SQ VM=1 Conceptual Volume Constituent Segmentation Reference Sequence</summary>
        public const uint ConceptualVolumeConstituentSegmentationReferenceSequence = 0x30100012;

        ///<summary>(3010,0013) VR=UI VM=1 Constituent Conceptual Volume Uid</summary>
        public const uint ConstituentConceptualVolumeUid = 0x30100013;

        ///<summary>(3010,0014) VR=SQ VM=1 Derivation Conceptual Volume Sequence</summary>
        public const uint DerivationConceptualVolumeSequence = 0x30100014;

        ///<summary>(3010,0015) VR=UI VM=1 Source Conceptual Volume Uid</summary>
        public const uint SourceConceptualVolumeUid = 0x30100015;

        ///<summary>(3010,0016) VR=SQ VM=1 Conceptual Volume Derivation Algorithm Sequence</summary>
        public const uint ConceptualVolumeDerivationAlgorithmSequence = 0x30100016;

        ///<summary>(3010,0017) VR=ST VM=1 Conceptual Volume Description</summary>
        public const uint ConceptualVolumeDescription = 0x30100017;

        ///<summary>(3010,0018) VR=SQ VM=1 Source Conceptual Volume Sequence</summary>
        public const uint SourceConceptualVolumeSequence = 0x30100018;

        ///<summary>(3010,0019) VR=SQ VM=1 Author Identification Sequence</summary>
        public const uint AuthorIdentificationSequence = 0x30100019;

        ///<summary>(3010,001A) VR=LO VM=1 Manufacturer's Model Version</summary>
        public const uint ManufacturerModelVersion = 0x3010001A;

        ///<summary>(3010,001B) VR=UC VM=1 Device Alternate Identifier</summary>
        public const uint DeviceAlternateIdentifier = 0x3010001B;

        ///<summary>(3010,001C) VR=CS VM=1 Device Alternate Identifier Type</summary>
        public const uint DeviceAlternateIdentifierType = 0x3010001C;

        ///<summary>(3010,001D) VR=LT VM=1 Device Alternate Identifier Format</summary>
        public const uint DeviceAlternateIdentifierFormat = 0x3010001D;

        ///<summary>(3010,001E) VR=LO VM=1 Segmentation Creation Template Label</summary>
        public const uint SegmentationCreationTemplateLabel = 0x3010001E;

        ///<summary>(3010,001F) VR=UI VM=1 Segmentation Template Uid</summary>
        public const uint SegmentationTemplateUid = 0x3010001F;

        ///<summary>(3010,0020) VR=US VM=1 Referenced Segment Reference Index</summary>
        public const uint ReferencedSegmentReferenceIndex = 0x30100020;

        ///<summary>(3010,0021) VR=SQ VM=1 Segment Reference Sequence</summary>
        public const uint SegmentReferenceSequence = 0x30100021;

        ///<summary>(3010,0022) VR=US VM=1 Segment Reference Index</summary>
        public const uint SegmentReferenceIndex = 0x30100022;

        ///<summary>(3010,0023) VR=SQ VM=1 Direct Segment Reference Sequence</summary>
        public const uint DirectSegmentReferenceSequence = 0x30100023;

        ///<summary>(3010,0024) VR=SQ VM=1 Combination Segment Reference Sequence</summary>
        public const uint CombinationSegmentReferenceSequence = 0x30100024;

        ///<summary>(3010,0025) VR=SQ VM=1 Conceptual Volume Sequence</summary>
        public const uint ConceptualVolumeSequence = 0x30100025;

        ///<summary>(3010,0026) VR=SQ VM=1 Segmented RT Accessory Device Sequence</summary>
        public const uint SegmentedRTAccessoryDeviceSequence = 0x30100026;

        ///<summary>(3010,0027) VR=SQ VM=1 Segment Characteristics Sequence</summary>
        public const uint SegmentCharacteristicsSequence = 0x30100027;

        ///<summary>(3010,0028) VR=SQ VM=1 Related Segment Characteristics Sequence</summary>
        public const uint RelatedSegmentCharacteristicsSequence = 0x30100028;

        ///<summary>(3010,0029) VR=US VM=1 Segment Characteristics Precedence</summary>
        public const uint SegmentCharacteristicsPrecedence = 0x30100029;

        ///<summary>(3010,002A) VR=SQ VM=1 RT Segment Annotation Sequence</summary>
        public const uint RTSegmentAnnotationSequence = 0x3010002A;

        ///<summary>(3010,002B) VR=SQ VM=1 Segment Annotation Category Code Sequence</summary>
        public const uint SegmentAnnotationCategoryCodeSequence = 0x3010002B;

        ///<summary>(3010,002C) VR=SQ VM=1 Segment Annotation Type Code Sequence</summary>
        public const uint SegmentAnnotationTypeCodeSequence = 0x3010002C;

        ///<summary>(3010,002D) VR=LO VM=1 Device Label</summary>
        public const uint DeviceLabel = 0x3010002D;

        ///<summary>(3010,002E) VR=SQ VM=1 Device Type Code Sequence</summary>
        public const uint DeviceTypeCodeSequence = 0x3010002E;

        ///<summary>(3010,002F) VR=SQ VM=1 Segment Annotation Type Modifier Code Sequence</summary>
        public const uint SegmentAnnotationTypeModifierCodeSequence = 0x3010002F;

        ///<summary>(3010,0030) VR=SQ VM=1 Patient Equipment Relationship Code Sequence</summary>
        public const uint PatientEquipmentRelationshipCodeSequence = 0x30100030;

        ///<summary>(3010,0031) VR=UI VM=1 Referenced Fiducials Uid</summary>
        public const uint ReferencedFiducialsUid = 0x30100031;

        ///<summary>(3010,0032) VR=SQ VM=1 Patient Treatment Orientation Sequence</summary>
        public const uint PatientTreatmentOrientationSequence = 0x30100032;

        ///<summary>(3010,0033) VR=SH VM=1 User Content Label</summary>
        public const uint UserContentLabel = 0x30100033;

        ///<summary>(3010,0034) VR=LO VM=1 User Content Long Label</summary>
        public const uint UserContentLongLabel = 0x30100034;

        ///<summary>(3010,0035) VR=SH VM=1 Entity Label</summary>
        public const uint EntityLabel = 0x30100035;

        ///<summary>(3010,0036) VR=LO VM=1 Entity Name</summary>
        public const uint EntityName = 0x30100036;

        ///<summary>(3010,0037) VR=ST VM=1 Entity Description</summary>
        public const uint EntityDescription = 0x30100037;

        ///<summary>(3010,0038) VR=LO VM=1 Entity Long Label</summary>
        public const uint EntityLongLabel = 0x30100038;

        ///<summary>(3010,0039) VR=US VM=1 Device Index</summary>
        public const uint DeviceIndex = 0x30100039;

        ///<summary>(3010,003A) VR=US VM=1 RT Treatment Phase Index</summary>
        public const uint RTTreatmentPhaseIndex = 0x3010003A;

        ///<summary>(3010,003B) VR=UI VM=1 RT Treatment Phase Uid</summary>
        public const uint RTTreatmentPhaseUid = 0x3010003B;

        ///<summary>(3010,003C) VR=US VM=1 RT Prescription Index</summary>
        public const uint RTPrescriptionIndex = 0x3010003C;

        ///<summary>(3010,003D) VR=US VM=1 RT Segment Annotation Index</summary>
        public const uint RTSegmentAnnotationIndex = 0x3010003D;

        ///<summary>(3010,003E) VR=US VM=1 Basis RT Treatment Phase Index</summary>
        public const uint BasisRTTreatmentPhaseIndex = 0x3010003E;

        ///<summary>(3010,003F) VR=US VM=1 Related RT Treatment Phase Index</summary>
        public const uint RelatedRTTreatmentPhaseIndex = 0x3010003F;

        ///<summary>(3010,0040) VR=US VM=1 Referenced RT Treatment Phase Index</summary>
        public const uint ReferencedRTTreatmentPhaseIndex = 0x30100040;

        ///<summary>(3010,0041) VR=US VM=1 Referenced RT Prescription Index</summary>
        public const uint ReferencedRTPrescriptionIndex = 0x30100041;

        ///<summary>(3010,0042) VR=US VM=1 Referenced Parent RT Prescription Index</summary>
        public const uint ReferencedParentRTPrescriptionIndex = 0x30100042;

        ///<summary>(3010,0043) VR=ST VM=1 Manufacturer's Device Identifier</summary>
        public const uint ManufacturerDeviceIdentifier = 0x30100043;

        ///<summary>(3010,0044) VR=SQ VM=1 Instance-Level Referenced Performed Procedure Step Sequence</summary>
        public const uint InstanceLevelReferencedPerformedProcedureStepSequence = 0x30100044;

        ///<summary>(3010,0045) VR=CS VM=1 RT Treatment Phase Intent Presence Flag</summary>
        public const uint RTTreatmentPhaseIntentPresenceFlag = 0x30100045;

        ///<summary>(3010,0046) VR=CS VM=1 Radiotherapy Treatment Type</summary>
        public const uint RadiotherapyTreatmentType = 0x30100046;

        ///<summary>(3010,0047) VR=CS VM=1-n Teletherapy Radiation Type</summary>
        public const uint TeletherapyRadiationType = 0x30100047;

        ///<summary>(3010,0048) VR=CS VM=1-n Brachytherapy Source Type</summary>
        public const uint BrachytherapySourceType = 0x30100048;

        ///<summary>(3010,0049) VR=SQ VM=1 Referenced RT Treatment Phase Sequence</summary>
        public const uint ReferencedRTTreatmentPhaseSequence = 0x30100049;

        ///<summary>(3010,004A) VR=SQ VM=1 Referenced Direct Segment Instance Sequence</summary>
        public const uint ReferencedDirectSegmentInstanceSequence = 0x3010004A;

        ///<summary>(3010,004B) VR=SQ VM=1 Intended RT Treatment Phase Sequence</summary>
        public const uint IntendedRTTreatmentPhaseSequence = 0x3010004B;

        ///<summary>(3010,004C) VR=DA VM=1 Intended Phase Start Date</summary>
        public const uint IntendedPhaseStartDate = 0x3010004C;

        ///<summary>(3010,004D) VR=DA VM=1 Intended Phase End Date</summary>
        public const uint IntendedPhaseEndDate = 0x3010004D;

        ///<summary>(3010,004E) VR=SQ VM=1 RT Treatment Phase Interval Sequence</summary>
        public const uint RTTreatmentPhaseIntervalSequence = 0x3010004E;

        ///<summary>(3010,004F) VR=CS VM=1 Temporal Relationship Interval Anchor</summary>
        public const uint TemporalRelationshipIntervalAnchor = 0x3010004F;

        ///<summary>(3010,0050) VR=FD VM=1 Minimum Number of Interval Days</summary>
        public const uint MinimumNumberOfIntervalDays = 0x30100050;

        ///<summary>(3010,0051) VR=FD VM=1 Maximum Number of Interval Days</summary>
        public const uint MaximumNumberOfIntervalDays = 0x30100051;

        ///<summary>(3010,0052) VR=UI VM=1-n Pertinent Sop Classes in Study</summary>
        public const uint PertinentSopClassesInStudy = 0x30100052;

        ///<summary>(3010,0053) VR=UI VM=1-n Pertinent Sop Classes in Series</summary>
        public const uint PertinentSopClassesInSeries = 0x30100053;

        ///<summary>(3010,0054) VR=LO VM=1 RT Prescription Label</summary>
        public const uint RTPrescriptionLabel = 0x30100054;

        ///<summary>(3010,0055) VR=SQ VM=1 RT Physician Intent Predecessor Sequence</summary>
        public const uint RTPhysicianIntentPredecessorSequence = 0x30100055;

        ///<summary>(3010,0056) VR=LO VM=1 RT Treatment Approach Label</summary>
        public const uint RTTreatmentApproachLabel = 0x30100056;

        ///<summary>(3010,0057) VR=SQ VM=1 RT Physician Intent Sequence</summary>
        public const uint RTPhysicianIntentSequence = 0x30100057;

        ///<summary>(3010,0058) VR=US VM=1 RT Physician Intent Index</summary>
        public const uint RTPhysicianIntentIndex = 0x30100058;

        ///<summary>(3010,0059) VR=CS VM=1 RT Treatment Intent Type</summary>
        public const uint RTTreatmentIntentType = 0x30100059;

        ///<summary>(3010,005A) VR=UT VM=1 RT Physician Intent Narrative</summary>
        public const uint RTPhysicianIntentNarrative = 0x3010005A;

        ///<summary>(3010,005B) VR=SQ VM=1 RT Protocol Code Sequence</summary>
        public const uint RTProtocolCodeSequence = 0x3010005B;

        ///<summary>(3010,005C) VR=ST VM=1 Reason for Superseding</summary>
        public const uint ReasonForSuperseding = 0x3010005C;

        ///<summary>(3010,005D) VR=SQ VM=1 RT Diagnosis Code Sequence</summary>
        public const uint RTDiagnosisCodeSequence = 0x3010005D;

        ///<summary>(3010,005E) VR=US VM=1 Referenced RT Physician Intent Index</summary>
        public const uint ReferencedRTPhysicianIntentIndex = 0x3010005E;

        ///<summary>(3010,005F) VR=SQ VM=1 RT Physician Intent Input Instance Sequence</summary>
        public const uint RTPhysicianIntentInputInstanceSequence = 0x3010005F;

        ///<summary>(3010,0060) VR=SQ VM=1 RT Anatomic Prescription Sequence</summary>
        public const uint RTAnatomicPrescriptionSequence = 0x30100060;

        ///<summary>(3010,0061) VR=UT VM=1 Prior Treatment Dose Description</summary>
        public const uint PriorTreatmentDoseDescription = 0x30100061;

        ///<summary>(3010,0062) VR=SQ VM=1 Prior Treatment Reference Sequence</summary>
        public const uint PriorTreatmentReferenceSequence = 0x30100062;

        ///<summary>(3010,0063) VR=CS VM=1 Dosimetric Objective Evaluation Scope</summary>
        public const uint DosimetricObjectiveEvaluationScope = 0x30100063;

        ///<summary>(3010,0064) VR=SQ VM=1 Therapeutic Role Category Code Sequence</summary>
        public const uint TherapeuticRoleCategoryCodeSequence = 0x30100064;

        ///<summary>(3010,0065) VR=SQ VM=1 Therapeutic Role Type Code Sequence</summary>
        public const uint TherapeuticRoleTypeCodeSequence = 0x30100065;

        ///<summary>(3010,0066) VR=US VM=1 Conceptual Volume Optimization Precedence</summary>
        public const uint ConceptualVolumeOptimizationPrecedence = 0x30100066;

        ///<summary>(3010,0067) VR=SQ VM=1 Conceptual Volume Category Code Sequence</summary>
        public const uint ConceptualVolumeCategoryCodeSequence = 0x30100067;

        ///<summary>(3010,0068) VR=CS VM=1 Conceptual Volume Blocking Constraint</summary>
        public const uint ConceptualVolumeBlockingConstraint = 0x30100068;

        ///<summary>(3010,0069) VR=SQ VM=1 Conceptual Volume Type Code Sequence</summary>
        public const uint ConceptualVolumeTypeCodeSequence = 0x30100069;

        ///<summary>(3010,006A) VR=SQ VM=1 Conceptual Volume Type Modifier Code Sequence</summary>
        public const uint ConceptualVolumeTypeModifierCodeSequence = 0x3010006A;

        ///<summary>(3010,006B) VR=SQ VM=1 RT Prescription Sequence</summary>
        public const uint RTPrescriptionSequence = 0x3010006B;

        ///<summary>(3010,006C) VR=SQ VM=1 Dosimetric Objective Sequence</summary>
        public const uint DosimetricObjectiveSequence = 0x3010006C;

        ///<summary>(3010,006D) VR=SQ VM=1 Dosimetric Objective Type Code Sequence</summary>
        public const uint DosimetricObjectiveTypeCodeSequence = 0x3010006D;

        ///<summary>(3010,006E) VR=UI VM=1 Dosimetric Objective Uid</summary>
        public const uint DosimetricObjectiveUid = 0x3010006E;

        ///<summary>(3010,006F) VR=UI VM=1 Referenced Dosimetric Objective Uid</summary>
        public const uint ReferencedDosimetricObjectiveUid = 0x3010006F;

        ///<summary>(3010,0070) VR=SQ VM=1 Dosimetric Objective Parameter Sequence</summary>
        public const uint DosimetricObjectiveParameterSequence = 0x30100070;

        ///<summary>(3010,0071) VR=SQ VM=1 Referenced Dosimetric Objectives Sequence</summary>
        public const uint ReferencedDosimetricObjectivesSequence = 0x30100071;

        ///<summary>(3010,0073) VR=CS VM=1 Absolute Dosimetric Objective Flag</summary>
        public const uint AbsoluteDosimetricObjectiveFlag = 0x30100073;

        ///<summary>(3010,0074) VR=FD VM=1 Dosimetric Objective Weight</summary>
        public const uint DosimetricObjectiveWeight = 0x30100074;

        ///<summary>(3010,0075) VR=CS VM=1 Dosimetric Objective Purpose</summary>
        public const uint DosimetricObjectivePurpose = 0x30100075;

        ///<summary>(3010,0076) VR=SQ VM=1 Planning Input Information Sequence</summary>
        public const uint PlanningInputInformationSequence = 0x30100076;

        ///<summary>(3010,0077) VR=LO VM=1 Treatment Site</summary>
        public const uint TreatmentSite = 0x30100077;

        ///<summary>(3010,0078) VR=SQ VM=1 Treatment Site Code Sequence</summary>
        public const uint TreatmentSiteCodeSequence = 0x30100078;

        ///<summary>(3010,0079) VR=SQ VM=1 Fraction Pattern Sequence</summary>
        public const uint FractionPatternSequence = 0x30100079;

        ///<summary>(3010,007A) VR=UT VM=1 Treatment Technique Notes</summary>
        public const uint TreatmentTechniqueNotes = 0x3010007A;

        ///<summary>(3010,007B) VR=UT VM=1 Prescription Notes</summary>
        public const uint PrescriptionNotes = 0x3010007B;

        ///<summary>(3010,007C) VR=IS VM=1 Number of Interval Fractions</summary>
        public const uint NumberOfIntervalFractions = 0x3010007C;

        ///<summary>(3010,007D) VR=US VM=1 Number of Fractions</summary>
        public const uint NumberOfFractions = 0x3010007D;

        ///<summary>(3010,007E) VR=US VM=1 Intended Delivery Duration</summary>
        public const uint IntendedDeliveryDuration = 0x3010007E;

        ///<summary>(3010,007F) VR=UT VM=1 Fractionation Notes</summary>
        public const uint FractionationNotes = 0x3010007F;

        ///<summary>(3010,0080) VR=SQ VM=1 RT Treatment Technique Code Sequence</summary>
        public const uint RTTreatmentTechniqueCodeSequence = 0x30100080;

        ///<summary>(3010,0081) VR=SQ VM=1 Prescription Notes Sequence</summary>
        public const uint PrescriptionNotesSequence = 0x30100081;

        ///<summary>(3010,0082) VR=SQ VM=1 Fraction-Based Relationship Sequence</summary>
        public const uint FractionBasedRelationshipSequence = 0x30100082;

        ///<summary>(3010,0083) VR=CS VM=1 Fraction-Based Relationship Interval Anchor</summary>
        public const uint FractionBasedRelationshipIntervalAnchor = 0x30100083;

        ///<summary>(3010,0084) VR=FD VM=1 Minimum Hours between Fractions</summary>
        public const uint MinimumHoursBetweenFractions = 0x30100084;

        ///<summary>(3010,0085) VR=TM VM=1-n Intended Fraction Start Time</summary>
        public const uint IntendedFractionStartTime = 0x30100085;

        ///<summary>(3010,0086) VR=LT VM=1 Intended Start Day of Week</summary>
        public const uint IntendedStartDayOfWeek = 0x30100086;

        ///<summary>(3010,0087) VR=SQ VM=1 Weekday Fraction Pattern Sequence</summary>
        public const uint WeekdayFractionPatternSequence = 0x30100087;

        ///<summary>(3010,0088) VR=SQ VM=1 Delivery Time Structure Code Sequence</summary>
        public const uint DeliveryTimeStructureCodeSequence = 0x30100088;

        ///<summary>(3010,0089) VR=SQ VM=1 Treatment Site Modifier Code Sequence</summary>
        public const uint TreatmentSiteModifierCodeSequence = 0x30100089;

        ///<summary>(3010,0090) VR=CS VM=1 Robotic Base Location Indicator</summary>
        public const uint RoboticBaseLocationIndicator = 0x30100090;

        ///<summary>(3010,0091) VR=SQ VM=1 Robotic Path Node Set Code Sequence</summary>
        public const uint RoboticPathNodeSetCodeSequence = 0x30100091;

        ///<summary>(3010,0092) VR=UL VM=1 Robotic Node Identifier</summary>
        public const uint RoboticNodeIdentifier = 0x30100092;

        ///<summary>(3010,0093) VR=FD VM=3 RT Treatment Source Coordinates</summary>
        public const uint RTTreatmentSourceCoordinates = 0x30100093;

        ///<summary>(3010,0094) VR=FD VM=1 Radiation Source Coordinate SystemYaw Angle</summary>
        public const uint RadiationSourceCoordinateSystemYawAngle = 0x30100094;

        ///<summary>(3010,0095) VR=FD VM=1 Radiation Source Coordinate SystemRoll Angle</summary>
        public const uint RadiationSourceCoordinateSystemRollAngle = 0x30100095;

        ///<summary>(3010,0096) VR=FD VM=1 Radiation Source Coordinate System Pitch Angle</summary>
        public const uint RadiationSourceCoordinateSystemPitchAngle = 0x30100096;

        ///<summary>(3010,0097) VR=SQ VM=1 Robotic Path Control Point Sequence</summary>
        public const uint RoboticPathControlPointSequence = 0x30100097;

        ///<summary>(3010,0098) VR=SQ VM=1 Tomotherapeutic Control Point Sequence</summary>
        public const uint TomotherapeuticControlPointSequence = 0x30100098;

        ///<summary>(3010,0099) VR=FD VM=1-n Tomotherapeutic Leaf Open Durations</summary>
        public const uint TomotherapeuticLeafOpenDurations = 0x30100099;

        ///<summary>(3010,009A) VR=FD VM=1-n Tomotherapeutic Leaf Initial Closed Durations</summary>
        public const uint TomotherapeuticLeafInitialClosedDurations = 0x3010009A;

        ///<summary>(4000,0010) VR=LT VM=1 Arbitrary (RETIRED)</summary>
        public const uint ArbitraryRETIRED = 0x40000010;

        ///<summary>(4000,4000) VR=LT VM=1 Text Comments (RETIRED)</summary>
        public const uint TextCommentsRETIRED = 0x40004000;

        ///<summary>(4008,0040) VR=SH VM=1 Results Id (RETIRED)</summary>
        public const uint ResultsIdRETIRED = 0x40080040;

        ///<summary>(4008,0042) VR=LO VM=1 Results Id Issuer (RETIRED)</summary>
        public const uint ResultsIdIssuerRETIRED = 0x40080042;

        ///<summary>(4008,0050) VR=SQ VM=1 Referenced Interpretation Sequence (RETIRED)</summary>
        public const uint ReferencedInterpretationSequenceRETIRED = 0x40080050;

        ///<summary>(4008,00FF) VR=CS VM=1 Report Production Status (Trial) (RETIRED)</summary>
        public const uint ReportProductionStatusTrialRETIRED = 0x400800FF;

        ///<summary>(4008,0100) VR=DA VM=1 Interpretation Recorded Date (RETIRED)</summary>
        public const uint InterpretationRecordedDateRETIRED = 0x40080100;

        ///<summary>(4008,0101) VR=TM VM=1 Interpretation Recorded Time (RETIRED)</summary>
        public const uint InterpretationRecordedTimeRETIRED = 0x40080101;

        ///<summary>(4008,0102) VR=PN VM=1 Interpretation Recorder (RETIRED)</summary>
        public const uint InterpretationRecorderRETIRED = 0x40080102;

        ///<summary>(4008,0103) VR=LO VM=1 Reference to Recorded Sound (RETIRED)</summary>
        public const uint ReferenceToRecordedSoundRETIRED = 0x40080103;

        ///<summary>(4008,0108) VR=DA VM=1 Interpretation Transcription Date (RETIRED)</summary>
        public const uint InterpretationTranscriptionDateRETIRED = 0x40080108;

        ///<summary>(4008,0109) VR=TM VM=1 Interpretation Transcription Time (RETIRED)</summary>
        public const uint InterpretationTranscriptionTimeRETIRED = 0x40080109;

        ///<summary>(4008,010A) VR=PN VM=1 Interpretation Transcriber (RETIRED)</summary>
        public const uint InterpretationTranscriberRETIRED = 0x4008010A;

        ///<summary>(4008,010B) VR=ST VM=1 Interpretation Text (RETIRED)</summary>
        public const uint InterpretationTextRETIRED = 0x4008010B;

        ///<summary>(4008,010C) VR=PN VM=1 Interpretation Author (RETIRED)</summary>
        public const uint InterpretationAuthorRETIRED = 0x4008010C;

        ///<summary>(4008,0111) VR=SQ VM=1 Interpretation Approver Sequence (RETIRED)</summary>
        public const uint InterpretationApproverSequenceRETIRED = 0x40080111;

        ///<summary>(4008,0112) VR=DA VM=1 Interpretation Approval Date (RETIRED)</summary>
        public const uint InterpretationApprovalDateRETIRED = 0x40080112;

        ///<summary>(4008,0113) VR=TM VM=1 Interpretation Approval Time (RETIRED)</summary>
        public const uint InterpretationApprovalTimeRETIRED = 0x40080113;

        ///<summary>(4008,0114) VR=PN VM=1 Physician Approving Interpretation (RETIRED)</summary>
        public const uint PhysicianApprovingInterpretationRETIRED = 0x40080114;

        ///<summary>(4008,0115) VR=LT VM=1 Interpretation Diagnosis Description (RETIRED)</summary>
        public const uint InterpretationDiagnosisDescriptionRETIRED = 0x40080115;

        ///<summary>(4008,0117) VR=SQ VM=1 Interpretation Diagnosis Code Sequence (RETIRED)</summary>
        public const uint InterpretationDiagnosisCodeSequenceRETIRED = 0x40080117;

        ///<summary>(4008,0118) VR=SQ VM=1 Results Distribution List Sequence (RETIRED)</summary>
        public const uint ResultsDistributionListSequenceRETIRED = 0x40080118;

        ///<summary>(4008,0119) VR=PN VM=1 Distribution Name (RETIRED)</summary>
        public const uint DistributionNameRETIRED = 0x40080119;

        ///<summary>(4008,011A) VR=LO VM=1 Distribution Address (RETIRED)</summary>
        public const uint DistributionAddressRETIRED = 0x4008011A;

        ///<summary>(4008,0200) VR=SH VM=1 Interpretation Id (RETIRED)</summary>
        public const uint InterpretationIdRETIRED = 0x40080200;

        ///<summary>(4008,0202) VR=LO VM=1 Interpretation Id Issuer (RETIRED)</summary>
        public const uint InterpretationIdIssuerRETIRED = 0x40080202;

        ///<summary>(4008,0210) VR=CS VM=1 Interpretation Type Id (RETIRED)</summary>
        public const uint InterpretationTypeIdRETIRED = 0x40080210;

        ///<summary>(4008,0212) VR=CS VM=1 Interpretation Status Id (RETIRED)</summary>
        public const uint InterpretationStatusIdRETIRED = 0x40080212;

        ///<summary>(4008,0300) VR=ST VM=1 Impressions (RETIRED)</summary>
        public const uint ImpressionsRETIRED = 0x40080300;

        ///<summary>(4008,4000) VR=ST VM=1 Results Comments (RETIRED)</summary>
        public const uint ResultsCommentsRETIRED = 0x40084000;

        ///<summary>(4010,0001) VR=CS VM=1 Low Energy Detectors</summary>
        public const uint LowEnergyDetectors = 0x40100001;

        ///<summary>(4010,0002) VR=CS VM=1 High Energy Detectors</summary>
        public const uint HighEnergyDetectors = 0x40100002;

        ///<summary>(4010,0004) VR=SQ VM=1 Detector Geometry Sequence</summary>
        public const uint DetectorGeometrySequence = 0x40100004;

        ///<summary>(4010,1001) VR=SQ VM=1 Threat ROI Voxel Sequence</summary>
        public const uint ThreatROIVoxelSequence = 0x40101001;

        ///<summary>(4010,1004) VR=FL VM=3 Threat ROI Base</summary>
        public const uint ThreatROIBase = 0x40101004;

        ///<summary>(4010,1005) VR=FL VM=3 Threat ROI Extents</summary>
        public const uint ThreatROIExtents = 0x40101005;

        ///<summary>(4010,1006) VR=OB VM=1 Threat ROI Bitmap</summary>
        public const uint ThreatROIBitmap = 0x40101006;

        ///<summary>(4010,1007) VR=SH VM=1 Route Segment Id</summary>
        public const uint RouteSegmentId = 0x40101007;

        ///<summary>(4010,1008) VR=CS VM=1 Gantry Type</summary>
        public const uint GantryType = 0x40101008;

        ///<summary>(4010,1009) VR=CS VM=1 OOI Owner Type</summary>
        public const uint OOIOwnerType = 0x40101009;

        ///<summary>(4010,100A) VR=SQ VM=1 Route Segment Sequence</summary>
        public const uint RouteSegmentSequence = 0x4010100A;

        ///<summary>(4010,1010) VR=US VM=1 Potential Threat Object Id</summary>
        public const uint PotentialThreatObjectId = 0x40101010;

        ///<summary>(4010,1011) VR=SQ VM=1 Threat Sequence</summary>
        public const uint ThreatSequence = 0x40101011;

        ///<summary>(4010,1012) VR=CS VM=1 Threat Category</summary>
        public const uint ThreatCategory = 0x40101012;

        ///<summary>(4010,1013) VR=LT VM=1 Threat Category Description</summary>
        public const uint ThreatCategoryDescription = 0x40101013;

        ///<summary>(4010,1014) VR=CS VM=1 ATD Ability Assessment</summary>
        public const uint ATDAbilityAssessment = 0x40101014;

        ///<summary>(4010,1015) VR=CS VM=1 ATD Assessment Flag</summary>
        public const uint ATDAssessmentFlag = 0x40101015;

        ///<summary>(4010,1016) VR=FL VM=1 ATD Assessment Probability</summary>
        public const uint ATDAssessmentProbability = 0x40101016;

        ///<summary>(4010,1017) VR=FL VM=1 Mass</summary>
        public const uint Mass = 0x40101017;

        ///<summary>(4010,1018) VR=FL VM=1 Density</summary>
        public const uint Density = 0x40101018;

        ///<summary>(4010,1019) VR=FL VM=1 Z Effective</summary>
        public const uint ZEffective = 0x40101019;

        ///<summary>(4010,101A) VR=SH VM=1 Boarding Pass Id</summary>
        public const uint BoardingPassId = 0x4010101A;

        ///<summary>(4010,101B) VR=FL VM=3 Center of Mass</summary>
        public const uint CenterOfMass = 0x4010101B;

        ///<summary>(4010,101C) VR=FL VM=3 Center of PTO</summary>
        public const uint CenterOfPTO = 0x4010101C;

        ///<summary>(4010,101D) VR=FL VM=6-n Bounding Polygon</summary>
        public const uint BoundingPolygon = 0x4010101D;

        ///<summary>(4010,101E) VR=SH VM=1 Route Segment Start Location Id</summary>
        public const uint RouteSegmentStartLocationId = 0x4010101E;

        ///<summary>(4010,101F) VR=SH VM=1 Route Segment End Location Id</summary>
        public const uint RouteSegmentEndLocationId = 0x4010101F;

        ///<summary>(4010,1020) VR=CS VM=1 Route Segment Location Id Type</summary>
        public const uint RouteSegmentLocationIdType = 0x40101020;

        ///<summary>(4010,1021) VR=CS VM=1-n Abort Reason</summary>
        public const uint AbortReason = 0x40101021;

        ///<summary>(4010,1023) VR=FL VM=1 Volume of PTO</summary>
        public const uint VolumeOfPTO = 0x40101023;

        ///<summary>(4010,1024) VR=CS VM=1 Abort Flag</summary>
        public const uint AbortFlag = 0x40101024;

        ///<summary>(4010,1025) VR=DT VM=1 Route Segment Start Time</summary>
        public const uint RouteSegmentStartTime = 0x40101025;

        ///<summary>(4010,1026) VR=DT VM=1 Route Segment End Time</summary>
        public const uint RouteSegmentEndTime = 0x40101026;

        ///<summary>(4010,1027) VR=CS VM=1 TDR Type</summary>
        public const uint TDRType = 0x40101027;

        ///<summary>(4010,1028) VR=CS VM=1 International Route Segment</summary>
        public const uint InternationalRouteSegment = 0x40101028;

        ///<summary>(4010,1029) VR=LO VM=1-n Threat Detection Algorithm and Version</summary>
        public const uint ThreatDetectionAlgorithmAndVersion = 0x40101029;

        ///<summary>(4010,102A) VR=SH VM=1 Assigned Location</summary>
        public const uint AssignedLocation = 0x4010102A;

        ///<summary>(4010,102B) VR=DT VM=1 Alarm Decision Time</summary>
        public const uint AlarmDecisionTime = 0x4010102B;

        ///<summary>(4010,1031) VR=CS VM=1 Alarm Decision</summary>
        public const uint AlarmDecision = 0x40101031;

        ///<summary>(4010,1033) VR=US VM=1 Number of Total Objects</summary>
        public const uint NumberOfTotalObjects = 0x40101033;

        ///<summary>(4010,1034) VR=US VM=1 Number of Alarm Objects</summary>
        public const uint NumberOfAlarmObjects = 0x40101034;

        ///<summary>(4010,1037) VR=SQ VM=1 PTO Representation Sequence</summary>
        public const uint PTORepresentationSequence = 0x40101037;

        ///<summary>(4010,1038) VR=SQ VM=1 ATD Assessment Sequence</summary>
        public const uint ATDAssessmentSequence = 0x40101038;

        ///<summary>(4010,1039) VR=CS VM=1 TIP Type</summary>
        public const uint TIPType = 0x40101039;

        ///<summary>(4010,103A) VR=CS VM=1 DICOS Version</summary>
        public const uint DICOSVersion = 0x4010103A;

        ///<summary>(4010,1041) VR=DT VM=1 OOI Owner Creation Time</summary>
        public const uint OOIOwnerCreationTime = 0x40101041;

        ///<summary>(4010,1042) VR=CS VM=1 OOI Type</summary>
        public const uint OOIType = 0x40101042;

        ///<summary>(4010,1043) VR=FL VM=3 OOI Size</summary>
        public const uint OOISize = 0x40101043;

        ///<summary>(4010,1044) VR=CS VM=1 Acquisition Status</summary>
        public const uint AcquisitionStatus = 0x40101044;

        ///<summary>(4010,1045) VR=SQ VM=1 Basis Materials Code Sequence</summary>
        public const uint BasisMaterialsCodeSequence = 0x40101045;

        ///<summary>(4010,1046) VR=CS VM=1 Phantom Type</summary>
        public const uint PhantomType = 0x40101046;

        ///<summary>(4010,1047) VR=SQ VM=1 OOI Owner Sequence</summary>
        public const uint OOIOwnerSequence = 0x40101047;

        ///<summary>(4010,1048) VR=CS VM=1 Scan Type</summary>
        public const uint ScanType = 0x40101048;

        ///<summary>(4010,1051) VR=LO VM=1 Itinerary Id</summary>
        public const uint ItineraryId = 0x40101051;

        ///<summary>(4010,1052) VR=SH VM=1 Itinerary Id Type</summary>
        public const uint ItineraryIdType = 0x40101052;

        ///<summary>(4010,1053) VR=LO VM=1 Itinerary Id Assigning Authority</summary>
        public const uint ItineraryIdAssigningAuthority = 0x40101053;

        ///<summary>(4010,1054) VR=SH VM=1 Route Id</summary>
        public const uint RouteId = 0x40101054;

        ///<summary>(4010,1055) VR=SH VM=1 Route Id Assigning Authority</summary>
        public const uint RouteIdAssigningAuthority = 0x40101055;

        ///<summary>(4010,1056) VR=CS VM=1 Inbound Arrival Type</summary>
        public const uint InboundArrivalType = 0x40101056;

        ///<summary>(4010,1058) VR=SH VM=1 Carrier Id</summary>
        public const uint CarrierId = 0x40101058;

        ///<summary>(4010,1059) VR=CS VM=1 Carrier Id Assigning Authority</summary>
        public const uint CarrierIdAssigningAuthority = 0x40101059;

        ///<summary>(4010,1060) VR=FL VM=3 Source Orientation</summary>
        public const uint SourceOrientation = 0x40101060;

        ///<summary>(4010,1061) VR=FL VM=3 Source Position</summary>
        public const uint SourcePosition = 0x40101061;

        ///<summary>(4010,1062) VR=FL VM=1 Belt Height</summary>
        public const uint BeltHeight = 0x40101062;

        ///<summary>(4010,1064) VR=SQ VM=1 Algorithm Routing Code Sequence</summary>
        public const uint AlgorithmRoutingCodeSequence = 0x40101064;

        ///<summary>(4010,1067) VR=CS VM=1 Transport Classification</summary>
        public const uint TransportClassification = 0x40101067;

        ///<summary>(4010,1068) VR=LT VM=1 OOI Type Descriptor</summary>
        public const uint OOITypeDescriptor = 0x40101068;

        ///<summary>(4010,1069) VR=FL VM=1 Total Processing Time</summary>
        public const uint TotalProcessingTime = 0x40101069;

        ///<summary>(4010,106C) VR=OB VM=1 Detector Calibration Data</summary>
        public const uint DetectorCalibrationData = 0x4010106C;

        ///<summary>(4010,106D) VR=CS VM=1 Additional Screening Performed</summary>
        public const uint AdditionalScreeningPerformed = 0x4010106D;

        ///<summary>(4010,106E) VR=CS VM=1 Additional Inspection Selection Criteria</summary>
        public const uint AdditionalInspectionSelectionCriteria = 0x4010106E;

        ///<summary>(4010,106F) VR=SQ VM=1 Additional Inspection Method Sequence</summary>
        public const uint AdditionalInspectionMethodSequence = 0x4010106F;

        ///<summary>(4010,1070) VR=CS VM=1 AIT Device Type</summary>
        public const uint AITDeviceType = 0x40101070;

        ///<summary>(4010,1071) VR=SQ VM=1 QR Measurements Sequence</summary>
        public const uint QRMeasurementsSequence = 0x40101071;

        ///<summary>(4010,1072) VR=SQ VM=1 Target Material Sequence</summary>
        public const uint TargetMaterialSequence = 0x40101072;

        ///<summary>(4010,1073) VR=FD VM=1 SNR Threshold</summary>
        public const uint SNRThreshold = 0x40101073;

        ///<summary>(4010,1075) VR=DS VM=1 Image Scale Representation</summary>
        public const uint ImageScaleRepresentation = 0x40101075;

        ///<summary>(4010,1076) VR=SQ VM=1 Referenced PTO Sequence</summary>
        public const uint ReferencedPTOSequence = 0x40101076;

        ///<summary>(4010,1077) VR=SQ VM=1 Referenced TDR Instance Sequence</summary>
        public const uint ReferencedTDRInstanceSequence = 0x40101077;

        ///<summary>(4010,1078) VR=ST VM=1 PTO Location Description</summary>
        public const uint PTOLocationDescription = 0x40101078;

        ///<summary>(4010,1079) VR=SQ VM=1 Anomaly Locator Indicator Sequence</summary>
        public const uint AnomalyLocatorIndicatorSequence = 0x40101079;

        ///<summary>(4010,107A) VR=FL VM=3 Anomaly Locator Indicator</summary>
        public const uint AnomalyLocatorIndicator = 0x4010107A;

        ///<summary>(4010,107B) VR=SQ VM=1 PTO Region Sequence</summary>
        public const uint PTORegionSequence = 0x4010107B;

        ///<summary>(4010,107C) VR=CS VM=1 Inspection Selection Criteria</summary>
        public const uint InspectionSelectionCriteria = 0x4010107C;

        ///<summary>(4010,107D) VR=SQ VM=1 Secondary Inspection Method Sequence</summary>
        public const uint SecondaryInspectionMethodSequence = 0x4010107D;

        ///<summary>(4010,107E) VR=DS VM=6 PRCS to RCS Orientation</summary>
        public const uint PRCSToRCSOrientation = 0x4010107E;

        ///<summary>(4FFE,0001) VR=SQ VM=1 MAC Parameters Sequence</summary>
        public const uint MACParametersSequence = 0x4FFE0001;

        ///<summary>(50xx,0005) VR=US VM=1 Curve Dimensions (RETIRED)</summary>
        public const uint CurveDimensionsRETIRED = 0x50000005;

        ///<summary>(50xx,0010) VR=US VM=1 Number of Points (RETIRED)</summary>
        public const uint NumberOfPointsRETIRED = 0x50000010;

        ///<summary>(50xx,0020) VR=CS VM=1 Type of Data (RETIRED)</summary>
        public const uint TypeOfDataRETIRED = 0x50000020;

        ///<summary>(50xx,0022) VR=LO VM=1 Curve Description (RETIRED)</summary>
        public const uint CurveDescriptionRETIRED = 0x50000022;

        ///<summary>(50xx,0030) VR=SH VM=1-n Axis Units (RETIRED)</summary>
        public const uint AxisUnitsRETIRED = 0x50000030;

        ///<summary>(50xx,0040) VR=SH VM=1-n Axis Labels (RETIRED)</summary>
        public const uint AxisLabelsRETIRED = 0x50000040;

        ///<summary>(50xx,0103) VR=US VM=1 Data Value Representation (RETIRED)</summary>
        public const uint DataValueRepresentationRETIRED = 0x50000103;

        ///<summary>(50xx,0104) VR=US VM=1-n Minimum Coordinate Value (RETIRED)</summary>
        public const uint MinimumCoordinateValueRETIRED = 0x50000104;

        ///<summary>(50xx,0105) VR=US VM=1-n Maximum Coordinate Value (RETIRED)</summary>
        public const uint MaximumCoordinateValueRETIRED = 0x50000105;

        ///<summary>(50xx,0106) VR=SH VM=1-n Curve Range (RETIRED)</summary>
        public const uint CurveRangeRETIRED = 0x50000106;

        ///<summary>(50xx,0110) VR=US VM=1-n Curve Data Descriptor (RETIRED)</summary>
        public const uint CurveDataDescriptorRETIRED = 0x50000110;

        ///<summary>(50xx,0112) VR=US VM=1-n Coordinate Start Value (RETIRED)</summary>
        public const uint CoordinateStartValueRETIRED = 0x50000112;

        ///<summary>(50xx,0114) VR=US VM=1-n Coordinate Step Value (RETIRED)</summary>
        public const uint CoordinateStepValueRETIRED = 0x50000114;

        ///<summary>(50xx,1001) VR=CS VM=1 Curve Activation Layer (RETIRED)</summary>
        public const uint CurveActivationLayerRETIRED = 0x50001001;

        ///<summary>(50xx,2000) VR=US VM=1 Audio Type (RETIRED)</summary>
        public const uint AudioTypeRETIRED = 0x50002000;

        ///<summary>(50xx,2002) VR=US VM=1 Audio Sample Format (RETIRED)</summary>
        public const uint AudioSampleFormatRETIRED = 0x50002002;

        ///<summary>(50xx,2004) VR=US VM=1 Number of Channels (RETIRED)</summary>
        public const uint NumberOfChannelsRETIRED = 0x50002004;

        ///<summary>(50xx,2006) VR=UL VM=1 Number of Samples (RETIRED)</summary>
        public const uint NumberOfSamplesRETIRED = 0x50002006;

        ///<summary>(50xx,2008) VR=UL VM=1 Sample Rate (RETIRED)</summary>
        public const uint SampleRateRETIRED = 0x50002008;

        ///<summary>(50xx,200A) VR=UL VM=1 Total Time (RETIRED)</summary>
        public const uint TotalTimeRETIRED = 0x5000200A;

        ///<summary>(50xx,200C) VR=OB/OW VM=1 Audio Sample Data (RETIRED)</summary>
        public const uint AudioSampleDataRETIRED = 0x5000200C;

        ///<summary>(50xx,200E) VR=LT VM=1 Audio Comments (RETIRED)</summary>
        public const uint AudioCommentsRETIRED = 0x5000200E;

        ///<summary>(50xx,2500) VR=LO VM=1 Curve Label (RETIRED)</summary>
        public const uint CurveLabelRETIRED = 0x50002500;

        ///<summary>(50xx,2600) VR=SQ VM=1 Curve Referenced Overlay Sequence (RETIRED)</summary>
        public const uint CurveReferencedOverlaySequenceRETIRED = 0x50002600;

        ///<summary>(50xx,2610) VR=US VM=1 Curve Referenced Overlay Group (RETIRED)</summary>
        public const uint CurveReferencedOverlayGroupRETIRED = 0x50002610;

        ///<summary>(50xx,3000) VR=OB/OW VM=1 Curve Data (RETIRED)</summary>
        public const uint CurveDataRETIRED = 0x50003000;

        ///<summary>(5200,9229) VR=SQ VM=1 Shared Functional Groups Sequence</summary>
        public const uint SharedFunctionalGroupsSequence = 0x52009229;

        ///<summary>(5200,9230) VR=SQ VM=1 Per-frame Functional Groups Sequence</summary>
        public const uint PerFrameFunctionalGroupsSequence = 0x52009230;

        ///<summary>(5400,0100) VR=SQ VM=1 Waveform Sequence</summary>
        public const uint WaveformSequence = 0x54000100;

        ///<summary>(5400,0110) VR=OB/OW VM=1 Channel Minimum Value</summary>
        public const uint ChannelMinimumValue = 0x54000110;

        ///<summary>(5400,0112) VR=OB/OW VM=1 Channel Maximum Value</summary>
        public const uint ChannelMaximumValue = 0x54000112;

        ///<summary>(5400,1004) VR=US VM=1 Waveform Bits Allocated</summary>
        public const uint WaveformBitsAllocated = 0x54001004;

        ///<summary>(5400,1006) VR=CS VM=1 Waveform Sample Interpretation</summary>
        public const uint WaveformSampleInterpretation = 0x54001006;

        ///<summary>(5400,100A) VR=OB/OW VM=1 Waveform Padding Value</summary>
        public const uint WaveformPaddingValue = 0x5400100A;

        ///<summary>(5400,1010) VR=OB/OW VM=1 Waveform Data</summary>
        public const uint WaveformData = 0x54001010;

        ///<summary>(5600,0010) VR=OF VM=1 First Order Phase Correction Angle</summary>
        public const uint FirstOrderPhaseCorrectionAngle = 0x56000010;

        ///<summary>(5600,0020) VR=OF VM=1 Spectroscopy Data</summary>
        public const uint SpectroscopyData = 0x56000020;

        ///<summary>(60xx,0010) VR=US VM=1 Overlay Rows</summary>
        public const uint OverlayRows = 0x60000010;

        ///<summary>(60xx,0011) VR=US VM=1 Overlay Columns</summary>
        public const uint OverlayColumns = 0x60000011;

        ///<summary>(60xx,0012) VR=US VM=1 Overlay Planes (RETIRED)</summary>
        public const uint OverlayPlanesRETIRED = 0x60000012;

        ///<summary>(60xx,0015) VR=IS VM=1 Number of Frames in Overlay</summary>
        public const uint NumberOfFramesInOverlay = 0x60000015;

        ///<summary>(60xx,0022) VR=LO VM=1 Overlay Description</summary>
        public const uint OverlayDescription = 0x60000022;

        ///<summary>(60xx,0040) VR=CS VM=1 Overlay Type</summary>
        public const uint OverlayType = 0x60000040;

        ///<summary>(60xx,0045) VR=LO VM=1 Overlay Subtype</summary>
        public const uint OverlaySubtype = 0x60000045;

        ///<summary>(60xx,0050) VR=SS VM=2 Overlay Origin</summary>
        public const uint OverlayOrigin = 0x60000050;

        ///<summary>(60xx,0051) VR=US VM=1 Image Frame Origin</summary>
        public const uint ImageFrameOrigin = 0x60000051;

        ///<summary>(60xx,0052) VR=US VM=1 Overlay Plane Origin (RETIRED)</summary>
        public const uint OverlayPlaneOriginRETIRED = 0x60000052;

        ///<summary>(60xx,0060) VR=CS VM=1 Overlay Compression Code (RETIRED)</summary>
        public const uint OverlayCompressionCodeRETIRED = 0x60000060;

        ///<summary>(60xx,0061) VR=SH VM=1 Overlay Compression Originator (RETIRED)</summary>
        public const uint OverlayCompressionOriginatorRETIRED = 0x60000061;

        ///<summary>(60xx,0062) VR=SH VM=1 Overlay Compression Label (RETIRED)</summary>
        public const uint OverlayCompressionLabelRETIRED = 0x60000062;

        ///<summary>(60xx,0063) VR=CS VM=1 Overlay Compression Description (RETIRED)</summary>
        public const uint OverlayCompressionDescriptionRETIRED = 0x60000063;

        ///<summary>(60xx,0066) VR=AT VM=1-n Overlay Compression Step Pointers (RETIRED)</summary>
        public const uint OverlayCompressionStepPointersRETIRED = 0x60000066;

        ///<summary>(60xx,0068) VR=US VM=1 Overlay Repeat Interval (RETIRED)</summary>
        public const uint OverlayRepeatIntervalRETIRED = 0x60000068;

        ///<summary>(60xx,0069) VR=US VM=1 Overlay Bits Grouped (RETIRED)</summary>
        public const uint OverlayBitsGroupedRETIRED = 0x60000069;

        ///<summary>(60xx,0100) VR=US VM=1 Overlay Bits Allocated</summary>
        public const uint OverlayBitsAllocated = 0x60000100;

        ///<summary>(60xx,0102) VR=US VM=1 Overlay Bit Position</summary>
        public const uint OverlayBitPosition = 0x60000102;

        ///<summary>(60xx,0110) VR=CS VM=1 Overlay Format (RETIRED)</summary>
        public const uint OverlayFormatRETIRED = 0x60000110;

        ///<summary>(60xx,0200) VR=US VM=1 Overlay Location (RETIRED)</summary>
        public const uint OverlayLocationRETIRED = 0x60000200;

        ///<summary>(60xx,0800) VR=CS VM=1-n Overlay Code Label (RETIRED)</summary>
        public const uint OverlayCodeLabelRETIRED = 0x60000800;

        ///<summary>(60xx,0802) VR=US VM=1 Overlay Number of Tables (RETIRED)</summary>
        public const uint OverlayNumberOfTablesRETIRED = 0x60000802;

        ///<summary>(60xx,0803) VR=AT VM=1-n Overlay Code Table Location (RETIRED)</summary>
        public const uint OverlayCodeTableLocationRETIRED = 0x60000803;

        ///<summary>(60xx,0804) VR=US VM=1 Overlay Bits For Code Word (RETIRED)</summary>
        public const uint OverlayBitsForCodeWordRETIRED = 0x60000804;

        ///<summary>(60xx,1001) VR=CS VM=1 Overlay Activation Layer</summary>
        public const uint OverlayActivationLayer = 0x60001001;

        ///<summary>(60xx,1100) VR=US VM=1 Overlay Descriptor - Gray (RETIRED)</summary>
        public const uint OverlayDescriptorGrayRETIRED = 0x60001100;

        ///<summary>(60xx,1101) VR=US VM=1 Overlay Descriptor - Red (RETIRED)</summary>
        public const uint OverlayDescriptorRedRETIRED = 0x60001101;

        ///<summary>(60xx,1102) VR=US VM=1 Overlay Descriptor - Green (RETIRED)</summary>
        public const uint OverlayDescriptorGreenRETIRED = 0x60001102;

        ///<summary>(60xx,1103) VR=US VM=1 Overlay Descriptor - Blue (RETIRED)</summary>
        public const uint OverlayDescriptorBlueRETIRED = 0x60001103;

        ///<summary>(60xx,1200) VR=US VM=1-n Overlays - Gray (RETIRED)</summary>
        public const uint OverlaysGrayRETIRED = 0x60001200;

        ///<summary>(60xx,1201) VR=US VM=1-n Overlays - Red (RETIRED)</summary>
        public const uint OverlaysRedRETIRED = 0x60001201;

        ///<summary>(60xx,1202) VR=US VM=1-n Overlays - Green (RETIRED)</summary>
        public const uint OverlaysGreenRETIRED = 0x60001202;

        ///<summary>(60xx,1203) VR=US VM=1-n Overlays - Blue (RETIRED)</summary>
        public const uint OverlaysBlueRETIRED = 0x60001203;

        ///<summary>(60xx,1301) VR=IS VM=1 ROI Area</summary>
        public const uint ROIArea = 0x60001301;

        ///<summary>(60xx,1302) VR=DS VM=1 ROI Mean</summary>
        public const uint ROIMean = 0x60001302;

        ///<summary>(60xx,1303) VR=DS VM=1 ROI Standard Deviation</summary>
        public const uint ROIStandardDeviation = 0x60001303;

        ///<summary>(60xx,1500) VR=LO VM=1 Overlay Label</summary>
        public const uint OverlayLabel = 0x60001500;

        ///<summary>(60xx,3000) VR=OB/OW VM=1 Overlay Data</summary>
        public const uint OverlayData = 0x60003000;

        ///<summary>(60xx,4000) VR=LT VM=1 Overlay Comments (RETIRED)</summary>
        public const uint OverlayCommentsRETIRED = 0x60004000;

        ///<summary>(7FE0,0001) VR=OV VM=1 Extended Offset Table</summary>
        public const uint ExtendedOffsetTable = 0x7FE00001;

        ///<summary>(7FE0,0002) VR=OV VM=1 Extended Offset Table Lengths</summary>
        public const uint ExtendedOffsetTableLengths = 0x7FE00002;

        ///<summary>(7FE0,0008) VR=OF VM=1 Float Pixel Data</summary>
        public const uint FloatPixelData = 0x7FE00008;

        ///<summary>(7FE0,0009) VR=OD VM=1 Double Float Pixel Data</summary>
        public const uint DoubleFloatPixelData = 0x7FE00009;

        ///<summary>(7FE0,0010) VR=OB/OW VM=1 Pixel Data</summary>
        public const uint PixelData = 0x7FE00010;

        ///<summary>(7FE0,0020) VR=OW VM=1 Coefficients SDVN (RETIRED)</summary>
        public const uint CoefficientsSDVNRETIRED = 0x7FE00020;

        ///<summary>(7FE0,0030) VR=OW VM=1 Coefficients SDHN (RETIRED)</summary>
        public const uint CoefficientsSDHNRETIRED = 0x7FE00030;

        ///<summary>(7FE0,0040) VR=OW VM=1 Coefficients SDDN (RETIRED)</summary>
        public const uint CoefficientsSDDNRETIRED = 0x7FE00040;

        ///<summary>(7Fxx,0010) VR=OB/OW VM=1 Variable Pixel Data (RETIRED)</summary>
        public const uint VariablePixelDataRETIRED = 0x7F000010;

        ///<summary>(7Fxx,0011) VR=US VM=1 Variable Next Data Group (RETIRED)</summary>
        public const uint VariableNextDataGroupRETIRED = 0x7F000011;

        ///<summary>(7Fxx,0020) VR=OW VM=1 Variable Coefficients SDVN (RETIRED)</summary>
        public const uint VariableCoefficientsSDVNRETIRED = 0x7F000020;

        ///<summary>(7Fxx,0030) VR=OW VM=1 Variable Coefficients SDHN (RETIRED)</summary>
        public const uint VariableCoefficientsSDHNRETIRED = 0x7F000030;

        ///<summary>(7Fxx,0040) VR=OW VM=1 Variable Coefficients SDDN (RETIRED)</summary>
        public const uint VariableCoefficientsSDDNRETIRED = 0x7F000040;

        ///<summary>(FFFA,FFFA) VR=SQ VM=1 Digital Signatures Sequence</summary>
        public const uint DigitalSignaturesSequence = 0xFFFAFFFA;

        ///<summary>(FFFC,FFFC) VR=OB VM=1 Data Set Trailing Padding</summary>
        public const uint DataSetTrailingPadding = 0xFFFCFFFC;

        ///<summary>(FFFE,E000) VR=NONE VM=1 Item</summary>
        public const uint Item = 0xFFFEE000;

        ///<summary>(FFFE,E00D) VR=NONE VM=1 Item Delimitation Item</summary>
        public const uint ItemDelimitationItem = 0xFFFEE00D;

        ///<summary>(FFFE,E0DD) VR=NONE VM=1 Sequence Delimitation Item</summary>
        public const uint SequenceDelimitationItem = 0xFFFEE0DD;

        ///<summary>(0006,0001) VR=SQ VM=1 Current Frame Functional Groups Sequence</summary>
        public const uint CurrentFrameFunctionalGroupsSequence = 0x00060001;

    }
}
