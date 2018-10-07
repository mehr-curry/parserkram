using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scanner.Tests
{
    [TestClass]
    public class AsciiByteHybridScannerTests
    {
        [TestMethod]
        public void ScanForWords()
        {
            const char argumentSeparator = (char) 130;
            var telegram = $"I00^I00:00000001{argumentSeparator}0123456789";
            
        }
    }
}