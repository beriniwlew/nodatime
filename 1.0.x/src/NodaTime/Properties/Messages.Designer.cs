﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NodaTime.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NodaTime.Properties.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format string is missing a close quote: {0}.
        /// </summary>
        internal static string Format_BadQuote {
            get {
                return ResourceManager.GetString("Format_BadQuote", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format error..
        /// </summary>
        internal static string FormatDefaultExceptionMessage {
            get {
                return ResourceManager.GetString("FormatDefaultExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument cannot be null..
        /// </summary>
        internal static string Noda_ArgumentNull {
            get {
                return ResourceManager.GetString("Noda_ArgumentNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot change a read only object..
        /// </summary>
        internal static string Noda_CannotChangeReadOnly {
            get {
                return ResourceManager.GetString("Noda_CannotChangeReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string cannot be empty..
        /// </summary>
        internal static string Noda_StringEmpty {
            get {
                return ResourceManager.GetString("Noda_StringEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string cannot be empty or only contain white space..
        /// </summary>
        internal static string Noda_StringEmptyOrWhitespace {
            get {
                return ResourceManager.GetString("Noda_StringEmptyOrWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{0}&quot; cannot be parsed into an instance of {1} using pattern &quot;{2}&quot;.
        /// </summary>
        internal static string Parse_CannotParseValue {
            get {
                return ResourceManager.GetString("Parse_CannotParseValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string does not match a date separator in the format string..
        /// </summary>
        internal static string Parse_DateSeparatorMismatch {
            get {
                return ResourceManager.GetString("Parse_DateSeparatorMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The day {0} is out of range in month {1} of year {2}..
        /// </summary>
        internal static string Parse_DayOfMonthOutOfRange {
            get {
                return ResourceManager.GetString("Parse_DayOfMonthOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The pattern flag &apos;{0}&apos; cannot appear twice and parse different values..
        /// </summary>
        internal static string Parse_DoubleAssignment {
            get {
                return ResourceManager.GetString("Parse_DoubleAssignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The list of formats cannot be empty..
        /// </summary>
        internal static string Parse_EmptyFormatsArray {
            get {
                return ResourceManager.GetString("Parse_EmptyFormatsArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified period was empty..
        /// </summary>
        internal static string Parse_EmptyPeriod {
            get {
                return ResourceManager.GetString("Parse_EmptyPeriod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Z prefix for an Offset pattern must be followed by a custom pattern..
        /// </summary>
        internal static string Parse_EmptyZPrefixedOffsetPattern {
            get {
                return ResourceManager.GetString("Parse_EmptyZPrefixedOffsetPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input string ended unexpectedly early..
        /// </summary>
        internal static string Parse_EndOfString {
            get {
                return ResourceManager.GetString("Parse_EndOfString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &quot;era&quot; designator cannot be specificied without the &quot;year of era&quot; field..
        /// </summary>
        internal static string Parse_EraWithoutYearOfEra {
            get {
                return ResourceManager.GetString("Parse_EraWithoutYearOfEra", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format string has an escape character (backslash &apos;\&apos;) at the end of the string..
        /// </summary>
        internal static string Parse_EscapeAtEndOfString {
            get {
                return ResourceManager.GetString("Parse_EscapeAtEndOfString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string does not match an escaped character in the format string: &quot;\{0}&quot;.
        /// </summary>
        internal static string Parse_EscapedCharacterMismatch {
            get {
                return ResourceManager.GetString("Parse_EscapedCharacterMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected end of input, but more data remains..
        /// </summary>
        internal static string Parse_ExpectedEndOfString {
            get {
                return ResourceManager.GetString("Parse_ExpectedEndOfString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format matches a prefix of the value string but not the entire string. Part not matching: &quot;{0}&quot;..
        /// </summary>
        internal static string Parse_ExtraValueCharacters {
            get {
                return ResourceManager.GetString("Parse_ExtraValueCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value {0} is out range for the field &apos;{1}&apos; in the {2} type..
        /// </summary>
        internal static string Parse_FieldValueOutOfRange {
            get {
                return ResourceManager.GetString("Parse_FieldValueOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The items of the format string array cannot be null or empty..
        /// </summary>
        internal static string Parse_FormatElementInvalid {
            get {
                return ResourceManager.GetString("Parse_FormatElementInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format string is invalid: &quot;{0}&quot;.
        /// </summary>
        internal static string Parse_FormatInvalid {
            get {
                return ResourceManager.GetString("Parse_FormatInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format string is empty..
        /// </summary>
        internal static string Parse_FormatStringEmpty {
            get {
                return ResourceManager.GetString("Parse_FormatStringEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;h&apos; pattern flag (12 hour format) is not supported by the {0} type..
        /// </summary>
        internal static string Parse_Hour12PatternNotSupported {
            get {
                return ResourceManager.GetString("Parse_Hour12PatternNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified day of the week does not matched the computed value..
        /// </summary>
        internal static string Parse_InconsistentDayOfWeekTextValue {
            get {
                return ResourceManager.GetString("Parse_InconsistentDayOfWeekTextValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The month values specified as text and numbers are inconsistent..
        /// </summary>
        internal static string Parse_InconsistentMonthTextValue {
            get {
                return ResourceManager.GetString("Parse_InconsistentMonthTextValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The individual values for the fields &apos;{0}&apos; and &apos;{1}&apos; created an inconsistency in the {2} type..
        /// </summary>
        internal static string Parse_InconsistentValues2 {
            get {
                return ResourceManager.GetString("Parse_InconsistentValues2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The period unit specifier &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string Parse_InvalidUnitSpecifier {
            get {
                return ResourceManager.GetString("Parse_InvalidUnitSpecifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string does not match a simple character in the format string &quot;{0}&quot;..
        /// </summary>
        internal static string Parse_MismatchedCharacter {
            get {
                return ResourceManager.GetString("Parse_MismatchedCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string does not match the required number from the format string &quot;{0}&quot;..
        /// </summary>
        internal static string Parse_MismatchedNumber {
            get {
                return ResourceManager.GetString("Parse_MismatchedNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string does not match the text-based field &apos;{0}&apos;..
        /// </summary>
        internal static string Parse_MismatchedText {
            get {
                return ResourceManager.GetString("Parse_MismatchedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The period unit specifier &apos;{0}&apos; appears at the wrong place in the input string..
        /// </summary>
        internal static string Parse_MisplacedUnitSpecifier {
            get {
                return ResourceManager.GetString("Parse_MisplacedUnitSpecifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string does not match the AM or PM designator for the culture at the required place..
        /// </summary>
        internal static string Parse_MissingAmPmDesignator {
            get {
                return ResourceManager.GetString("Parse_MissingAmPmDesignator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format string is missing the end quote character &quot;{0}&quot;..
        /// </summary>
        internal static string Parse_MissingEndQuote {
            get {
                return ResourceManager.GetString("Parse_MissingEndQuote", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string does not include a number in the expected position..
        /// </summary>
        internal static string Parse_MissingNumber {
            get {
                return ResourceManager.GetString("Parse_MissingNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The required value sign is missing..
        /// </summary>
        internal static string Parse_MissingSign {
            get {
                return ResourceManager.GetString("Parse_MissingSign", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The month {0} is out of range in year {1}..
        /// </summary>
        internal static string Parse_MonthOutOfRange {
            get {
                return ResourceManager.GetString("Parse_MonthOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified calendar id is not recognized..
        /// </summary>
        internal static string Parse_NoMatchingCalendarSystem {
            get {
                return ResourceManager.GetString("Parse_NoMatchingCalendarSystem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to None of the specified formats matches the given value string..
        /// </summary>
        internal static string Parse_NoMatchingFormat {
            get {
                return ResourceManager.GetString("Parse_NoMatchingFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A percent sign (%) appears at the end of the format string..
        /// </summary>
        internal static string Parse_PercentAtEndOfString {
            get {
                return ResourceManager.GetString("Parse_PercentAtEndOfString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A percent sign (%) is followed by another percent sign in the format string..
        /// </summary>
        internal static string Parse_PercentDoubled {
            get {
                return ResourceManager.GetString("Parse_PercentDoubled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A positive value sign is not valid at this point..
        /// </summary>
        internal static string Parse_PositiveSignInvalid {
            get {
                return ResourceManager.GetString("Parse_PositiveSignInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The standard format &quot;{0}&quot; for type {1} does not support a precision..
        /// </summary>
        internal static string Parse_PrecisionNotSupported {
            get {
                return ResourceManager.GetString("Parse_PrecisionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string does not match a quoted string in the pattern..
        /// </summary>
        internal static string Parse_QuotedStringMismatch {
            get {
                return ResourceManager.GetString("Parse_QuotedStringMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There were more consecutive copies of the pattern character &quot;{0}&quot; than the maximum allowed ({1}) in the format string..
        /// </summary>
        internal static string Parse_RepeatCountExceeded {
            get {
                return ResourceManager.GetString("Parse_RepeatCountExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field &quot;{0}&quot; is specified multiple times in the pattern..
        /// </summary>
        internal static string Parse_RepeatedFieldInPattern {
            get {
                return ResourceManager.GetString("Parse_RepeatedFieldInPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The period unit specifier &apos;{0}&apos; appears multiple times in the input string..
        /// </summary>
        internal static string Parse_RepeatedUnitSpecifier {
            get {
                return ResourceManager.GetString("Parse_RepeatedUnitSpecifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The standard format &quot;{0}&quot; for type {1} cannot contain white space..
        /// </summary>
        internal static string Parse_StandardFormatWhitespace {
            get {
                return ResourceManager.GetString("Parse_StandardFormatWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string does not match a time separator in the format string..
        /// </summary>
        internal static string Parse_TimeSeparatorMismatch {
            get {
                return ResourceManager.GetString("Parse_TimeSeparatorMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More characters were expected in the parsable string [{0}]..
        /// </summary>
        internal static string Parse_UnexpectedEndOfString {
            get {
                return ResourceManager.GetString("Parse_UnexpectedEndOfString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string includes a negative value where only a non-negative one is allowed..
        /// </summary>
        internal static string Parse_UnexpectedNegative {
            get {
                return ResourceManager.GetString("Parse_UnexpectedNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal Error: The specified ParseFailureKind is unknown [{0}]..
        /// </summary>
        internal static string Parse_UnknownFailure {
            get {
                return ResourceManager.GetString("Parse_UnknownFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The standard format &quot;{0}&quot; is not valid for the {1} type..
        /// </summary>
        internal static string Parse_UnknownStandardFormat {
            get {
                return ResourceManager.GetString("Parse_UnknownStandardFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value {0} is out of the legal range for the {1} type..
        /// </summary>
        internal static string Parse_ValueOutOfRange {
            get {
                return ResourceManager.GetString("Parse_ValueOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value string is empty..
        /// </summary>
        internal static string Parse_ValueStringEmpty {
            get {
                return ResourceManager.GetString("Parse_ValueStringEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The year {0} is out of range for the {1} era in the {2} calendar..
        /// </summary>
        internal static string Parse_YearOfEraOutOfRange {
            get {
                return ResourceManager.GetString("Parse_YearOfEraOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Z prefix for an Offset pattern must occur at the beginning of the pattern..
        /// </summary>
        internal static string Parse_ZPrefixNotAtStartOfPattern {
            get {
                return ResourceManager.GetString("Parse_ZPrefixNotAtStartOfPattern", resourceCulture);
            }
        }
    }
}
