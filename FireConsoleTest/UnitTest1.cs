using FileConsole;
using Moq;
using NUnit.Framework;

namespace FireConsoleTest
{
    public class Tests
    {
        private FileReader _reader;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _reader = new FileReader();
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
        }

        [Test]
        public void GenMagicNum_WhenChoiceIs2_ResultEqualToMagic()
        {

            // Act
            double result = _reader.GenMagicNum(1, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(84));
        }

        [Test]
        public void GenMagicNum_WhenChoiceIs0_ResultEqualToMagic()
        {
            // Act
            double result = _reader.GenMagicNum(0, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void GenMagicNum_WhenChoiceIs100_ResultEqualToMagic()
        {
            // Act
            double result = _reader.GenMagicNum(100, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}