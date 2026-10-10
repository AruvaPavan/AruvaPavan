
using System;

class Program
{
    static int passed = 0;
    static int failed = 0;

    static void Test<T>(string testName, T expected, T actual)
    {
        if (Equals(expected, actual))
        {
            Console.WriteLine($"PASS: {testName}");
            passed++;
        }
        else
        {
            Console.WriteLine(
                $"FAIL: {testName} | Expected: {expected} | Actual: {actual}");
            failed++;
        }
    }

    static void Main()
    {
        Console.WriteLine("=== PALINDROME TESTS ===");
        Test("Palindrome 1", true, StringUtils.IsPalindrome("madam"));
        Test("Palindrome 2", true, StringUtils.IsPalindrome("Race car!"));
        Test("Palindrome 3", false, StringUtils.IsPalindrome("hello"));

        Console.WriteLine("\n=== ANAGRAM TESTS ===");
        Test("Anagram 1", true, StringUtils.AreAnagrams("listen", "silent"));
        Test("Anagram 2", true, StringUtils.AreAnagrams("Dormitory", "Dirty room"));
        Test("Anagram 3", false, StringUtils.AreAnagrams("hello", "world"));

        Console.WriteLine("\n=== WORD COUNT TESTS ===");
        Test("Word count 1", 3, StringUtils.WordCount("C# is powerful"));
        Test("Word count 2", 0, StringUtils.WordCount(""));
        Test("Word count 3", 3, StringUtils.WordCount("  Learn   C# today  "));

        Console.WriteLine("\n=== TITLE CASE TESTS ===");
        Test("Title case 1", "Hello World", StringUtils.ToTitleCase("hello world"));
        Test("Title case 2", "Learn C# Today", StringUtils.ToTitleCase("LEARN c# TODAY"));
        Test("Title case 3", "", StringUtils.ToTitleCase(""));

        Console.WriteLine("\n=== REVERSE WORDS TESTS ===");
        Test("Reverse words 1", "world hello", StringUtils.ReverseWords("hello world"));
        Test("Reverse words 2", "C# love I", StringUtils.ReverseWords("I love C#"));
        Test("Reverse words 3", "three two one",
            StringUtils.ReverseWords("  one   two three  "));

        Console.WriteLine("\n=== TRUNCATE TESTS ===");
        Test("Truncate 1", "Hello...", StringUtils.TruncateWithEllipsis("Hello World", 8));
        Test("Truncate 2", "Hi", StringUtils.TruncateWithEllipsis("Hi", 5));
        Test("Truncate 3", "...", StringUtils.TruncateWithEllipsis("Hello", 3));

        Console.WriteLine("\n=== TEST SUMMARY ===");
        Console.WriteLine($"Passed: {passed}");
        Console.WriteLine($"Failed: {failed}");
        Console.WriteLine($"Total: {passed + failed}");

        Console.WriteLine(failed == 0
            ? "All tests passed!"
            : "Some tests failed.");
    }
}
