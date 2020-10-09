using FileConsole;
using NUnit.Framework;

namespace FireConsoleTest
{
    public class Tests
    {
        private FileReader _reader;
        [SetUp]
        public void Setup()
        {
            _reader = new FileReader();
        }

        [Test]
        public void GenMagicNum_WhenChoiceIs2_ResultEqualToMagic()
        {
            // Act
            double result = _reader.GenMagicNum(2, "MagicNumbers.txt");
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void GenMagicNum_WhenChoiceIs0_ResultEqualToMagic()
        {
            // Act
            double result = _reader.GenMagicNum(0, "MagicNumbers.txt");
            // Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void GenMagicNum_WhenChoiceIs100_ResultEqualToMagic()
        {
            // Act
            double result = _reader.GenMagicNum(100, "MagicNumbers.txt");
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}