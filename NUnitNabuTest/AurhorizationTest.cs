using NabuPdfGenerator.Authorization;
using NUnit.Framework;

namespace NUnitNabuTest
{
    public class Tests
    {
        [Test]
        public void AurhorizationTest()
        {
            var at = new Authorization();
            var res = at.Authorize("admin", "pass");
        }
    }
}