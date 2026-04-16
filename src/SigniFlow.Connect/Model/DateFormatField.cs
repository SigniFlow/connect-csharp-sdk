using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SigniFlow.Connect.Model
{
    [DataContract(Name = "DateFormatField")]
    public class DateFormatField
    {
        [DataMember(Name = "CustomDateValuesField")]
        public List<CustomDateField> CustomDateValuesField { get; set; }
        
        [DataMember(Name = "FormatField")]
        public DateFieldFormat FormatField { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = 41;
                hashCode = this.CustomDateValuesField != null ? hashCode * 59 + this.CustomDateValuesField.GetHashCode() : hashCode;
                hashCode = this.FormatField != null ? hashCode * 59 + this.FormatField.GetHashCode() : hashCode;
                return hashCode;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is DateFormatField dateFormatField &&
                   CustomDateValuesField.Equals(dateFormatField.CustomDateValuesField) &&
                   FormatField == dateFormatField.FormatField;
        }
    }

    public enum DateFieldFormat
    {
        CUSTOM,    // 0  Specify custom date format
        COOKIE,    // 1  D, dd M yy    (Fri, 01 Jun 2022)
        ISO_8601,  // 2  yy-mm-dd      (2022-06-01)
        RFC_822,   // 3  D, d M yy      (Fri, 1 Jun 22)
        RFC_850,   // 4  DD, dd-M-y    (Friday, 01-Jun-22)
        RFC_1123,  // 5  D, d M yy     (Fri, 1 Jun 2022)
    }

    [DataContract(Name = "CustomDateValuesField")]
    public class CustomDateField
    {
        [DataMember(Name = "CustomFormatValueField")]
        public CustomDateFieldValues CustomFormatValueField { get; set; }
        
        [DataMember(Name = "CustomSplitterField")]
        public string CustomSplitterField { get; set; }

        public override int GetHashCode()
        {
            var hashCode = 41;
            hashCode = this.CustomFormatValueField != null ? hashCode * 59 + this.CustomFormatValueField.GetHashCode() : hashCode;
            hashCode = this.CustomSplitterField != null ? hashCode * 59 + this.CustomSplitterField.GetHashCode() : hashCode;
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            return obj is CustomDateField customDateField &&
                   CustomFormatValueField == customDateField.CustomFormatValueField &&
                   CustomSplitterField == customDateField.CustomSplitterField;
        }
    }

    public enum CustomDateFieldValues
    {
        DAY_OF_MONTH_NO_LEAD_0,      // 0  d
        DAY_OF_MONTH_TWO_DIGIT,      // 1  dd
        DAY_NAME_SHORT,              // 4  D
        DAY_NAME_LONG,               // 5  DD
        MONTH_OF_YEAR_NO_LEAD_0,     // 6  m
        MONTH_OF_YEAR_TWO_DIGIT,     // 7  mm
        MONTH_NAME_SHORT,            // 8  M
        MONTH_NAME_LONG,             // 9  MM
        YEAR_TWO_DIGIT,              // 10 yy
        YEAR_FOUR_DIGIT,             // 11 yyyy
        UNIX_TIMESTAMP,              // 12 @
        WINDOWS_TICKS,               // 13 !
    }
}