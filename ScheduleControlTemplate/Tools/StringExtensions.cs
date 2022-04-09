using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AreasExternas
{
    public static class StringExtensions
    {
        public static bool MyMatch(this string target, string value, bool quitSpacing = false)
        {
            if (string.IsNullOrWhiteSpace(target))
                return string.IsNullOrWhiteSpace(value);

            if (string.IsNullOrWhiteSpace(value))
                return true;

            return target.RemoveDiacritics(quitSpacing).ToLower()
                .Contains(value.RemoveDiacritics(quitSpacing).ToLower());
        }

        public static string RemoveDiacritics(this string text, bool quitSpacing = false)
        {
            return string.Concat(
                text.Normalize(NormalizationForm.FormD)
                .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark && (!quitSpacing || CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.SpaceSeparator))
              ).Normalize(NormalizationForm.FormC);
        }

        public static Regex AngolanPhoneNumberRegex { get; } = new Regex(
            @"^(([\+]|([0]{2}))244([-]|[ ])?)?(([9][1-9])|[2]{2})[0-9]{7}$",
            RegexOptions.Singleline);

        public static bool IsAngolanPhoneNumber(this string target, bool emptyValid = false)
        {
            if (string.IsNullOrWhiteSpace(target))
                return emptyValid;

            return AngolanPhoneNumberRegex.IsMatch(target);
        }

        public static Regex EmailRegex { get; } = new Regex(
            @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            RegexOptions.CultureInvariant | RegexOptions.Singleline);

        public static bool IsEmail(this string target, bool emptyValid = false)
        {
            if (string.IsNullOrWhiteSpace(target))
                return emptyValid;

            return EmailRegex.IsMatch(target);
        }
    }

}
