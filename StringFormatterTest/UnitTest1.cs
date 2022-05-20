using NUnit.Framework;
using StringFormatterApp;
using System;

namespace StringFormatterTest
{
    public class Tests
    {
        private readonly StringFormatter _stringFormatter = new StringFormatter();
        private readonly StringFormatter stringFormatter = new StringFormatter();

       [Test]
        public void TestEmptyString()
        {
            string result = _stringFormatter.ShortFileString(string.Empty);
            StringAssert.AreEqualIgnoringCase(result, string.Empty);
        }

        [Test]
        public void TestNullString()
        {
            Assert.Throws<NullReferenceException>(() => _stringFormatter.ShortFileString(null));
        }

        [TestCase("C://myfiles//ref//file1.txt")]
        [TestCase("C://ref//file1.txt")]
        [TestCase("C://myfiles//ref//file1")]
        public void TestExtension(string input)
        {
            string result = _stringFormatter.ShortFileString(input);
            StringAssert.EndsWith(".TMP", result);
        }


        [TestCase("C://myfiles//ref//file1.txt","FILE1.TMP")]
        [TestCase("C://ref//file3.txt", "FILE3.TMP")]
        [TestCase("C://myfiles//ref//file2", "FILE2.TMP")]
        public void TestShortPath(string input,string expected)
        {
            string result = _stringFormatter.ShortFileString(input);
            StringAssert.Contains(result, expected);
        }
    }
}