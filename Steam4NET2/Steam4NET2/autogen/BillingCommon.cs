// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum ELicenseFlags : int
	{
		k_ELicenseFlagNone = 0,
		k_ELicenseFlagRenew = 1,
		k_ELicenseFlagRenewalFailed = 2,
		k_ELicenseFlagPending = 4,
		k_ELicenseFlagExpired = 8,
		k_ELicenseFlagCancelledByUser = 16,
		k_ELicenseFlagCancelledByAdmin = 32,
		k_ELicenseFlagLowViolence = 64,
		k_ELicenseFlagImportedFromSteam2 = 128,
	};
	
	public enum EPaymentMethod : int
	{
		k_EPaymentMethodNone = 0,
		k_EPaymentMethodActivationCode = 1,
		k_EPaymentMethodCreditCard = 2,
		k_EPaymentMethodGiropay = 3,
		k_EPaymentMethodPayPal = 4,
		k_EPaymentMethodIdeal = 5,
		k_EPaymentMethodPaySafeCard = 6,
		k_EPaymentMethodSofort = 7,
		k_EPaymentMethodGuestPass = 8,
		k_EPaymentMethodWebMoney = 9,
		k_EPaymentMethodHardwarePromo = 16,
		k_EPaymentMethodClickAndBuy = 32,
		k_EPaymentMethodAutoGrant = 64,
		k_EPaymentMethodWallet = 128,
		k_EPaymentMethodOEMTicket = 256,
		k_EPaymentMethodSplit = 512,
		k_EPaymentMethodComplimentary = 1024,
	};
	
	public enum EPurchaseResultDetail : int
	{
		k_EPurchaseResultNoDetail = 0,
		k_EPurchaseResultAVSFailure = 1,
		k_EPurchaseResultInsufficientFunds = 2,
		k_EPurchaseResultContactSupport = 3,
		k_EPurchaseResultTimeout = 4,
		k_EPurchaseResultInvalidPackage = 5,
		k_EPurchaseResultInvalidPaymentMethod = 6,
		k_EPurchaseResultInvalidData = 7,
		k_EPurchaseResultOthersInProgress = 8,
		k_EPurchaseResultAlreadyPurchased = 9,
		k_EPurchaseResultWrongPrice = 10,
		k_EPurchaseResultFraudCheckFailed = 11,
		k_EPurchaseResultCancelledByUser = 12,
		k_EPurchaseResultRestrictedCountry = 13,
		k_EPurchaseResultBadActivationCode = 14,
		k_EPurchaseResultDuplicateActivationCode = 15,
		k_EPurchaseResultUseOtherPaymentMethod = 16,
		k_EPurchaseResultUseOtherFundingSource = 17,
		k_EPurchaseResultInvalidShippingAddress = 18,
		k_EPurchaseResultRegionNotSupported = 19,
		k_EPurchaseResultAcctIsBlocked = 20,
		k_EPurchaseResultAcctNotVerified = 21,
		k_EPurchaseResultInvalidAccount = 22,
		k_EPurchaseResultStoreBillingCountryMismatch = 23,
		k_EPurchaseResultDoesNotOwnRequiredApp = 24,
		k_EPurchaseResultCanceledByNewTransaction = 25,
		k_EPurchaseResultForceCanceledPending = 26,
		k_EPurchaseResultFailCurrencyTransProvider = 27,
		k_EPurchaseResultFailedCyberCafe = 28,
		k_EPurchaseResultNeedsPreApproval = 29,
		k_EPurchaseResultPreApprovalDenied = 30,
		k_EPurchaseResultWalletCurrencyMismatch = 31,
		k_EPurchaseResultEmailNotValidated = 32,
		k_EPurchaseResultExpiredCard = 33,
		k_EPurchaseResultTransactionExpired = 34,
		k_EPurchaseResultWouldExceedMaxWallet = 35,
		k_EPurchaseResultMustLoginPS3AppForPurchase = 36,
		k_EPurchaseResultCannotShipToPOBox = 37,
	};
	
	public enum EPurchaseStatus : int
	{
		k_EPurchasePending = 0,
		k_EPurchaseSucceeded = 1,
		k_EPurchaseFailed = 2,
		k_EPurchaseRefunded = 3,
		k_EPurchaseInit = 4,
		k_EPurchaseChargedback = 5,
		k_EPurchaseRevoked = 6,
		k_EPurchaseInDispute = 7,
		k_EPurchasePartialRefund = 8,
		k_EPurchaseRefundToWallet = 9,
	};
	
	public enum ECreditCardType : int
	{
		k_ECreditCardTypeUnknown = 0,
		k_ECreditCardTypeVisa = 1,
		k_ECreditCardTypeMaster = 2,
		k_ECreditCardTypeAmericanExpress = 3,
		k_ECreditCardTypeDiscover = 4,
		k_ECreditCardTypeDinersClub = 5,
		k_ECreditCardTypeJCB = 6,
		k_ECreditCardTypeCarteBleue = 7,
		k_ECreditCardTypeDankort = 8,
		k_ECreditCardTypeMaestro = 9,
		k_ECreditCardTypeSolo = 10,
		k_ECreditCardTypeLaser = 11,
	};
	
	public enum ELicenseType : int
	{
		k_ENoLicense = 0,
		k_ESinglePurchase = 1,
		k_ESinglePurchaseLimitedUse = 2,
		k_ERecurringCharge = 3,
		k_ERecurringChargeLimitedUse = 4,
		k_ERecurringChargeLimitedUseWithOverages = 5,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(401)]
	public struct FinalPriceMsg_t
	{
		public const int k_iCallback = 401;
		public UInt32 m_bSuccess;
		public UInt32 m_nBaseCost;
		public UInt32 m_nTotalDiscount;
		public UInt32 m_nTax;
		public UInt32 m_nShippingCost;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(402)]
	public struct PurchaseMsg_t
	{
		public const int k_iCallback = 402;
		public UInt32 m_bSuccess;
		public Int32 m_EPurchaseResultDetail;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(404)]
	public struct PurchaseResponse_t
	{
		public const int k_iCallback = 404;
		public EResult m_EResult;
		public Int32 m_EPurchaseResultDetail;
		public Int32 m_iReceiptIndex;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(409)]
	public struct CancelLicenseMsg_t
	{
		public const int k_iCallback = 409;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(412)]
	public struct RequestFreeLicenseResponse_t
	{
		public const int k_iCallback = 412;
		public EResult m_EResult;
		public UInt32 m_uAppId;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(414)]
	public struct OEMTicketActivationResponse_t
	{
		public const int k_iCallback = 414;
		public EResult m_EResult;
		public EPurchaseResultDetail m_EPurchaseResultDetail;
		public UInt32 m_nPackageID;
		public Int32 m_iReceiptIndex;
	};
	
}
