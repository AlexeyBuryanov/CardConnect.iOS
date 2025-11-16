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
        static extern NSString BMS_AccountTypeForIssuer(CCCCardIssuer issuer);

        // extern CCCCardIssuer BMS_CardIssuerForAccountType (NSString *accountType);
        [DllImport("__Internal")]
        static extern CCCCardIssuer BMS_CardIssuerForAccountType(NSString accountType);

        // extern BOOL BMS_LuhnCheck (NSString *number);
        [DllImport("__Internal")]
        static extern bool BMS_LuhnCheck(NSString number);

        // extern CCCCardIssuer BMS_CardIssuerFromCardNumber (NSString *cardNumber);
        [DllImport("__Internal")]
        static extern CCCCardIssuer BMS_CardIssuerFromCardNumber(NSString cardNumber);

        // extern NSInteger BMS_MaxCardNumberLengthForCardNumber (NSString *cardNumber);
        [DllImport("__Internal")]
        static extern nint BMS_MaxCardNumberLengthForCardNumber(NSString cardNumber);

        // extern BOOL BMS_ValidateCardLength (NSString *cardNumber);
        [DllImport("__Internal")]
        static extern bool BMS_ValidateCardLength(NSString cardNumber);

        // extern BOOL BMS_ValidateCardNumber (NSString *cardNumber);
        [DllImport("__Internal")]
        static extern bool BMS_ValidateCardNumber(NSString cardNumber);

        // extern NSString * BMS_MaskCardNumberWithCharacterAndFormat (NSString *cardNumber, unichar maskCharacter, CCCCardMaskFormat format, CCCCardMaskSpacing spacing);
        [DllImport("__Internal")]
        static extern NSString BMS_MaskCardNumberWithCharacterAndFormat(NSString cardNumber, ushort maskCharacter, CCCCardMaskFormat format, CCCCardMaskSpacing spacing);

        // extern BOOL BMS_ValidateCVV (NSString *CVV);
        [DllImport("__Internal")]
        static extern bool BMS_ValidateCVV(NSString CVV);

        // extern BOOL BMS_ValidateCVVForCardNumber (NSString *CVV, NSString *cardNumber);
        [DllImport("__Internal")]
        static extern bool BMS_ValidateCVVForCardNumber(NSString CVV, NSString cardNumber);

        // extern NSString * BMS_MaskCVVWithCharacter (NSString *CVV, unichar maskCharacter);
        [DllImport("__Internal")]
        static extern NSString BMS_MaskCVVWithCharacter(NSString CVV, ushort maskCharacter);

        // extern BOOL BMS_ValidateExpirationDate (NSDate *date);
        [DllImport("__Internal")]
        static extern bool BMS_ValidateExpirationDate(NSDate date);

        // extern NSString * BMS_Base64GZippedSignatureForImage (UIImage *image);
        [DllImport("__Internal")]
        static extern NSString BMS_Base64GZippedSignatureForImage(UIImage image);

        // extern UIImage * BMS_ImageFromBase64GZippedString (NSString *string);
        [DllImport("__Internal")]
        static extern UIImage BMS_ImageFromBase64GZippedString(NSString @string);

        // extern NSDateFormatter * BMS_UTCDateFormatter ();
        [DllImport("__Internal")]
        static extern NSDateFormatter BMS_UTCDateFormatter();
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
