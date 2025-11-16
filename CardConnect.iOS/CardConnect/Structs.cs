using System;

using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CardConnectBinding
{
    [Native]
    public enum CCCCardIssuer : long
    {
        None,
        Amex,
        Visa,
        Discover,
        MasterCard,
        Diners,
        Jcb,
        Maestro,
        Other
    }

    static class CFunctions
    {
        // extern NSString * BMS_AccountTypeForIssuer (CCCCardIssuer issuer);
        [DllImport("__Internal")]
        [EntryPoint("BMS_AccountTypeForIssuer")]
        static extern NSString CCC_AccountTypeForIssuer(CCCCardIssuer issuer);

        // extern CCCCardIssuer BMS_CardIssuerForAccountType (NSString *accountType);
        [DllImport("__Internal")]
        [EntryPoint("BMS_CardIssuerForAccountType")]
        static extern CCCCardIssuer CCC_CardIssuerForAccountType(NSString accountType);

        // extern BOOL BMS_LuhnCheck (NSString *number);
        [DllImport("__Internal")]
        [EntryPoint("BMS_LuhnCheck")]
        static extern bool CCC_LuhnCheck(NSString number);

        // extern CCCCardIssuer BMS_CardIssuerFromCardNumber (NSString *cardNumber);
        [DllImport("__Internal")]
        [EntryPoint("BMS_CardIssuerFromCardNumber")]
        static extern CCCCardIssuer CCC_CardIssuerFromCardNumber(NSString cardNumber);

        // extern NSInteger BMS_MaxCardNumberLengthForCardNumber (NSString *cardNumber);
        [DllImport("__Internal")]
        [EntryPoint("BMS_MaxCardNumberLengthForCardNumber")]
        static extern nint CCC_MaxCardNumberLengthForCardNumber(NSString cardNumber);

        // extern BOOL BMS_ValidateCardLength (NSString *cardNumber);
        [DllImport("__Internal")]
        [EntryPoint("BMS_ValidateCardLength")]
        static extern bool CCC_ValidateCardLength(NSString cardNumber);

        // extern BOOL BMS_ValidateCardNumber (NSString *cardNumber);
        [DllImport("__Internal")]
        [EntryPoint("BMS_ValidateCardNumber")]
        static extern bool CCC_ValidateCardNumber(NSString cardNumber);

        // extern NSString * BMS_MaskCardNumberWithCharacterAndFormat (NSString *cardNumber, unichar maskCharacter, CCCCardMaskFormat format, CCCCardMaskSpacing spacing);
        [DllImport("__Internal")]
        [EntryPoint("BMS_MaskCardNumberWithCharacterAndFormat")]
        static extern NSString CCC_MaskCardNumberWithCharacterAndFormat(NSString cardNumber, ushort maskCharacter, CCCCardMaskFormat format, CCCCardMaskSpacing spacing);

        // extern BOOL BMS_ValidateCVV (NSString *CVV);
        [DllImport("__Internal")]
        [EntryPoint("BMS_ValidateCVV")]
        static extern bool CCC_ValidateCVV(NSString CVV);

        // extern BOOL BMS_ValidateCVVForCardNumber (NSString *CVV, NSString *cardNumber);
        [DllImport("__Internal")]
        [EntryPoint("BMS_ValidateCVVForCardNumber")]
        static extern bool CCC_ValidateCVVForCardNumber(NSString CVV, NSString cardNumber);

        // extern NSString * BMS_MaskCVVWithCharacter (NSString *CVV, unichar maskCharacter);
        [DllImport("__Internal")]
        [EntryPoint("BMS_MaskCVVWithCharacter")]
        static extern NSString CCC_MaskCVVWithCharacter(NSString CVV, ushort maskCharacter);

        // extern BOOL BMS_ValidateExpirationDate (NSDate *date);
        [DllImport("__Internal")]
        [EntryPoint("BMS_ValidateExpirationDate")]
        static extern bool CCC_ValidateExpirationDate(NSDate date);

        // extern NSString * BMS_Base64GZippedSignatureForImage (UIImage *image);
        [DllImport("__Internal")]
        [EntryPoint("BMS_Base64GZippedSignatureForImage")]
        static extern NSString CCC_Base64GZippedSignatureForImage(UIImage image);

        // extern UIImage * BMS_ImageFromBase64GZippedString (NSString *string);
        [DllImport("__Internal")]
        [EntryPoint("BMS_ImageFromBase64GZippedString")]
        static extern UIImage CCC_ImageFromBase64GZippedString(NSString @string);

        // extern NSDateFormatter * BMS_UTCDateFormatter ();
        [DllImport("__Internal")]
        [EntryPoint("BMS_UTCDateFormatter")]
        static extern NSDateFormatter CCC_UTCDateFormatter();
    }

    [Native]
    public enum CCCCardMaskFormat : long
    {
        MaskWithLastFour,
        LastFour,
        FirstAndLastFour
    }

    [Native]
    public enum CCCCardMaskSpacing : long
    {
        None,
        EveryFour,
        EveryCharacter,
        EveryCharacterAndFour
    }

    [Native]
    public enum CCCExpirationDateInput : long
    {
        Four,
        Six
    }

    [Native]
    public enum CCCSwiperConnectionState : long
    {
        Disconnected = 0,
        Connecting = 1,
        Connected = 2
    }

    [Native]
    public enum CCCSwiperBatteryStatus : long
    {
        Low,
        Critical
    }
}
