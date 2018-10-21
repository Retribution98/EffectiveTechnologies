using System;
using Xunit;
using Palindrome;

namespace Palindrome.Tests
{
    public class PalindromeTests
    {
        [Fact]
        public void IsPalindrome_1BulionA_True()
        {
            string str = new string('a', 1000000000);

            bool actual = Palindrome.IsPalindrome(str);

            Assert.True(actual);
        }

        [Fact]
        public void IsPalindrome_null_Throw()
        {
            Assert.Throws<NullReferenceException>(() => Palindrome.IsPalindrome(null));
        }

        [Fact]
        public void IsPalindrome_abcb_False()
        {
            string str = "abcb";

            bool actual = Palindrome.IsPalindrome(str);

            Assert.False(actual);
        }

        [Fact]
        public void IsPalindrome_abcba_True()
        {
            string str = "abcba";

            bool actual = Palindrome.IsPalindrome(str);

            Assert.True(actual);
        }

        [Fact]
        public void IsPalindrome_abccba_True()
        {
            string str = "abccba";

            bool actual = Palindrome.IsPalindrome(str);

            Assert.True(actual);
        }

        [Fact]
        public void RemoveExtraChar_()
        {
            string str = @"`q15 +].{:z\n";

            string actual = Palindrome.RemoveExtraChar(str);
            string expected = "q15zn";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveExtraChar_1MillionSlashs_empty()
        {
            string str = new string('/', 100000);

            string actual = Palindrome.RemoveExtraChar(str);

            Assert.Empty(actual);
        }
    }
}
