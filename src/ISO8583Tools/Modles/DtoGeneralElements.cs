using System;
using System.Collections.Generic;
using System.Text;

namespace ISO8583Tools.Modles
{
    public class DtoGeneralElements
    {
        /// <summary>
        /// Primary account number (PAN)
        /// </summary>
        [Element(Index = 2, ElementType = Enums.EnumElementType.N, BytesLength = 19, Fixed = false)]
        public string Pan { get; set; }

        /// <summary>
        /// Processing code
        /// </summary>
        [Element(Index = 3, ElementType = Enums.EnumElementType.N, BytesLength = 6)]
        public string ProcessingCode { get; set; }

        /// <summary>
        /// Amount, transaction
        /// </summary>
        [Element(Index = 4, ElementType = Enums.EnumElementType.N, BytesLength = 12)]
        public string TransactionAmount { get; set; }

        /// <summary>
        /// Amount, settlement
        /// </summary>
        [Element(Index = 5, ElementType = Enums.EnumElementType.N, BytesLength = 12)]
        public string SettlementAmount { get; set; }

        /// <summary>
        /// Amount, cardholder billing
        /// </summary>
        [Element(Index = 6, ElementType = Enums.EnumElementType.N, BytesLength = 12)]
        public string CardholderBillingAmount { get; set; }

        /// <summary>
        /// ransmission date & time
        /// </summary>
        [Element(Index = 7, ElementType = Enums.EnumElementType.N, BytesLength = 10)]
        public string TransmissionDateTime { get; set; }

        /// <summary>
        /// Amount, cardholder billing fee
        /// </summary>
        [Element(Index = 8, ElementType = Enums.EnumElementType.N, BytesLength = 12)]
        public string CardholderBillingFeeAmount { get; set; }

        /// <summary>
        /// Conversion rate, settlement
        /// </summary>
        [Element(Index = 9, ElementType = Enums.EnumElementType.N, BytesLength = 8)]
        public string SettlementConversionRate { get; set; }

        /// <summary>
        /// Conversion rate, cardholder billing
        /// </summary>
        [Element(Index = 10, ElementType = Enums.EnumElementType.N, BytesLength = 8)]
        public string CardholderBillingConversionRate { get; set; }

        /// <summary>
        /// System trace audit number (STAN)
        /// </summary>
        [Element(Index = 11, ElementType = Enums.EnumElementType.N, BytesLength = 6)]
        public string Stan { get; set; }

        /// <summary>
        /// Local transaction time (hhmmss)
        /// </summary>
        [Element(Index = 12, ElementType = Enums.EnumElementType.N, BytesLength = 6)]
        public string TransactionTime { get; set; }

        /// <summary>
        /// Local transaction date (MMDD)
        /// </summary>
        [Element(Index = 13, ElementType = Enums.EnumElementType.N, BytesLength = 4)]
        public string TransactionDate { get; set; }

        /// <summary>
        /// Expiration date (MMDD)
        /// </summary>
        [Element(Index = 14, ElementType = Enums.EnumElementType.N, BytesLength = 4)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Settlement date (MMDD)
        /// </summary>
        [Element(Index = 15, ElementType = Enums.EnumElementType.N, BytesLength = 4)]
        public string SettlementDate { get; set; }

        /// <summary>
        /// Currency conversion date (MMDD)
        /// </summary>
        [Element(Index = 16, ElementType = Enums.EnumElementType.N, BytesLength = 4)]
        public string CurrencyConversionDate { get; set; }

        /// <summary>
        /// Capture date(MMDD)
        /// </summary>
        [Element(Index = 17, ElementType = Enums.EnumElementType.N, BytesLength = 4)]
        public string CaptureDate { get; set; }

        /// <summary>
        /// Merchant type, or merchant category code
        /// </summary>
        [Element(Index = 18, ElementType = Enums.EnumElementType.N, BytesLength = 4)]
        public string MerchantType { get; set; }

        /// <summary>
        /// Acquiring institution (country code)
        /// </summary>
        [Element(Index = 19, ElementType = Enums.EnumElementType.N, BytesLength = 3)]
        public string AcquiringInstitutionCountryCode { get; set; }

        /// <summary>
        /// PAN extended (country code)
        /// </summary>
        [Element(Index = 20, ElementType = Enums.EnumElementType.N, BytesLength = 3)]
        public string PanCountryCode { get; set; }

        /// <summary>
        /// Forwarding institution (country code)
        /// </summary>
        [Element(Index = 21, ElementType = Enums.EnumElementType.N, BytesLength = 3)]
        public string ForwardingInstitutionCountryCode { get; set; }

        /// <summary>
        /// Point of service entry mode
        /// </summary>
        [Element(Index = 22, ElementType = Enums.EnumElementType.N, BytesLength = 3)]
        public string EntryMode { get; set; }

        /// <summary>
        /// Application PAN sequence number
        /// </summary>
        [Element(Index = 23, ElementType = Enums.EnumElementType.N, BytesLength = 3)]
        public string ApplicationPanSequenceNo { get; set; }

        /// <summary>
        /// network international identifier (NII), Function code (ISO 8583:1993)
        /// </summary>
        [Element(Index = 24, ElementType = Enums.EnumElementType.N, BytesLength = 3)]
        public string Nii { get; set; }

        /// <summary>
        /// Point of service condition code
        /// </summary>
        [Element(Index = 25, ElementType = Enums.EnumElementType.N, BytesLength = 2)]
        public string ConditionCode { get; set; }

        /// <summary>
        /// Point of service capture code
        /// </summary>
        [Element(Index = 26, ElementType = Enums.EnumElementType.N, BytesLength = 2)]
        public string CaptureCode { get; set; }

        /// <summary>
        /// Authorizing identification response length
        /// </summary>
        [Element(Index = 27, ElementType = Enums.EnumElementType.N, BytesLength = 1)]
        public string AuthorizingIdentificationResponseLength { get; set; }

        /// <summary>
        /// Amount, transaction fee
        /// </summary>
        [Element(Index = 28, ElementType = Enums.EnumElementType.XN, BytesLength = 8)]
        public string TransactionFeeAmount { get; set; }

        /// <summary>
        /// Amount, settlement fee
        /// </summary>
        [Element(Index = 29, ElementType = Enums.EnumElementType.XN, BytesLength = 8)]
        public string SettlementFeeAmount { get; set; }

        /// <summary>
        /// Amount, transaction processing fee
        /// </summary>
        [Element(Index = 30, ElementType = Enums.EnumElementType.XN, BytesLength = 8)]
        public string TransactionProcessingFeeAmount { get; set; }

        /// <summary>
        /// Amount, settlement processing fee
        /// </summary>
        [Element(Index = 31, ElementType = Enums.EnumElementType.XN, BytesLength = 8)]
        public string SettlementProcessingFeeAmount { get; set; }

        /// <summary>
        /// Acquiring institution identification code
        /// </summary>
        [Element(Index = 32, ElementType = Enums.EnumElementType.N, BytesLength = 11, Fixed = false)]
        public string AcquiringInstitutionIdentificationCode { get; set; }

        /// <summary>
        /// Forwarding institution identification code
        /// </summary>
        [Element(Index = 33, ElementType = Enums.EnumElementType.N, BytesLength = 11, Fixed = false)]
        public string ForwardingInstitutionIdentificationCode { get; set; }

        /// <summary>
        /// Primary account number, extended
        /// </summary>
        [Element(Index = 34, ElementType = Enums.EnumElementType.NS, BytesLength = 28, Fixed = false)]
        public string PanExtended { get; set; }

        /// <summary>
        /// Track 2 data
        /// </summary>
        [Element(Index = 35, ElementType = Enums.EnumElementType.Z, BytesLength = 37, Fixed = false)]
        public string Track2Data { get; set; }

        /// <summary>
        /// Track 3 data
        /// </summary>
        [Element(Index = 36, ElementType = Enums.EnumElementType.Z, BytesLength = 104, Fixed = false)]
        public string Track3Data { get; set; }

        /// <summary>
        /// Retrieval reference number
        /// </summary>
        [Element(Index = 37, ElementType = Enums.EnumElementType.AN, BytesLength = 12)]
        public string RetrievalReferenceNumber { get; set; }

        /// <summary>
        /// Authorization identification response
        /// </summary>
        [Element(Index = 38, ElementType = Enums.EnumElementType.AN, BytesLength = 6)]
        public string AuthorizationIdentificationResponse { get; set; }

        /// <summary>
        /// Response code
        /// </summary>
        [Element(Index = 39, ElementType = Enums.EnumElementType.AN, BytesLength = 2)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Service restriction code
        /// </summary>
        [Element(Index = 40, ElementType = Enums.EnumElementType.AN, BytesLength = 3)]
        public string ServiceRestrictionCode { get; set; }

        /// <summary>
        /// Card acceptor terminal identification
        /// </summary>
        [Element(Index = 41, ElementType = Enums.EnumElementType.ANS, BytesLength = 8)]
        public string CardAcceptorTerminalIdentification { get; set; }

        /// <summary>
        /// Card acceptor identification code
        /// </summary>
        [Element(Index = 42, ElementType = Enums.EnumElementType.ANS, BytesLength = 15)]
        public string CardAcceptorIdentificationCode { get; set; }

        /// <summary>
        /// Card acceptor name/location (1–23 street address, –36 city, –38 state, 39–40 country)
        /// </summary>
        [Element(Index = 43, ElementType = Enums.EnumElementType.ANS, BytesLength = 40)]
        public string CardAcceptor { get; set; }

        /// <summary>
        /// Additional response data
        /// </summary>
        [Element(Index = 44, ElementType = Enums.EnumElementType.AN, BytesLength = 25, Fixed = false)]
        public string AdditionalResponseData { get; set; }

        /// <summary>
        /// Track 1 data
        /// </summary>
        [Element(Index = 45, ElementType = Enums.EnumElementType.AN, BytesLength = 76, Fixed = false)]
        public string Track1Data { get; set; }

        /// <summary>
        /// Additional data (ISO)
        /// </summary>
        [Element(Index = 46, ElementType = Enums.EnumElementType.AN, BytesLength = 999, Fixed = false)]
        public string AdditionalDataISO { get; set; }

        /// <summary>
        /// Additional data (national)
        /// </summary>
        [Element(Index = 47, ElementType = Enums.EnumElementType.AN, BytesLength = 999, Fixed = false)]
        public string AdditionalDataNational { get; set; }

        /// <summary>
        /// Additional data (private)
        /// </summary>
        [Element(Index = 48, ElementType = Enums.EnumElementType.AN, BytesLength = 999, Fixed = false)]
        public string AdditionalDataPrivate { get; set; }

        /// <summary>
        /// Currency code, transaction
        /// </summary>
        [Element(Index = 49, ElementType = Enums.EnumElementType.A, BytesLength = 3)]
        public string TransactionCurrencyCode { get; set; }

        /// <summary>
        /// Currency code, settlement
        /// </summary>
        [Element(Index = 50, ElementType = Enums.EnumElementType.A, BytesLength = 3)]
        public string SettlementCurrencyCode { get; set; }

        /// <summary>
        /// Currency code, cardholder billing
        /// </summary>
        [Element(Index = 51, ElementType = Enums.EnumElementType.A, BytesLength = 3)]
        public string CardholderBillingCurrencyCode { get; set; }

        /// <summary>
        /// Personal identification number data
        /// </summary>
        [Element(Index = 52, ElementType = Enums.EnumElementType.B, BytesLength = 64)]
        public string PersonalIdentificationNumberData { get; set; }

        /// <summary>
        /// Security related control information
        /// </summary>
        [Element(Index = 53, ElementType = Enums.EnumElementType.N, BytesLength = 16)]
        public string SecurityRelatedControlInformation{ get; set; }

        /// <summary>
        /// Additional amounts
        /// </summary>
        [Element(Index = 54, ElementType = Enums.EnumElementType.AN, BytesLength = 120, Fixed = false)]
        public string AdditionalAmounts { get; set; }

        /// <summary>
        /// ICC data – EMV having multiple tags
        /// </summary>
        [Element(Index = 55, ElementType = Enums.EnumElementType.ANS, BytesLength = 999, Fixed = false)]
        public string ICCData { get; set; }
    }
}
