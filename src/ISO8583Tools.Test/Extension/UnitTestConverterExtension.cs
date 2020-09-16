using NUnit.Framework;
using ISO8583Tools.Modles;
using ISO8583Tools.Extension;

namespace ISO8583Tools.Test.Extension
{
    public class UnitTestConverterExtension
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestToHexString()
        {
            var expected = "0102040810204080FF";
            byte[] vs = new byte[9] { 1, 2, 4, 8, 16, 32, 64, 128, 255 };
            var actual = vs.ToHexString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestToByteArray()
        {
            byte[] expected = new byte[9] { 1, 2, 4, 8, 16, 32, 64, 128, 255 };
            var target = "0102040810204080FF";
            var actual = target.ToByteArray();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAsciiToByteAray()
        {
            byte[] expected = new byte[3] { 49, 65, 97 };
            var target = "1Aa";
            var actual = target.ToAscii();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAsciiToString()
        {
            var expected = "1Aa";
            byte[] target = new byte[3] { 49, 65, 97 };

            var actual = target.AsciiToString();
            Assert.AreEqual(expected, actual);
        }
    }
}