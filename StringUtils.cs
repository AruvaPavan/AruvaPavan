
using System;
using System.Linq;

public static class StringUtils
{
    public static bool IsPalindrome(string text)
    {
        string cleaned = new string(
            text.Where(char.IsLetterOrDigit)
                .Select(char.ToLowerInvariant)
                .ToArray());

        return cleaned == new string(cleaned.Reverse().ToArray());
    }

    public static bool AreAnagrams(string first, string second)
    {
        string cleanedFirst = new string(
            first.Where(char.IsLetterOrDigit)
                 .Select(char.ToLowerInvariant)
                 .OrderBy(c => c)
                 .ToArray());

        string cleanedSecond = new string(
            second.Where(char.IsLetterOrDigit)
                  .Select(char.ToLowerInvariant)
                  .OrderBy(c => c)
                  .ToArray());

        return cleanedFirst == cleanedSecond;
    }

    public static int WordCount(string text)
    {
        return text.Split(
            (char[])null,
            StringSplitOptions.RemoveEmptyEntries
        ).Length;
    }

    public static string ToTitleCase(string text)
    {
        return string.Join(" ",
            text.Split((char[])null,StringSplitOptions.RemoveEmptyEntries)
                .Select(word =>
                    char.ToUpperInvariant(word[0]) +
                    word.Substring(1).ToLowerInvariant()));
    }

    public static string ReverseWords(string sentence)
    {
        string[] words = sentence.Split(
            (char[])null,
            StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        return string.Join(" ", words);
    }

    public static string TruncateWithEllipsis(
        string text, int maxLength)
    {
        if (maxLength < 0)
            throw new ArgumentOutOfRangeException(nameof(maxLength));

        if (text.Length <= maxLength)
            return text;

        if (maxLength <= 3)
            return new string('.', maxLength);

        return text.Substring(0, maxLength - 3) + "...";
    }
}
