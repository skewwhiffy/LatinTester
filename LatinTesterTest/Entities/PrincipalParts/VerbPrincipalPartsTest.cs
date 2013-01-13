using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LatinTester.Enums;

namespace LatinTesterTest.Entities.PrincipalParts
{
  [TestClass]
  public class VerbPrincipalPartsTest : ConjugationTestBase
  {
    [TestMethod]
    public void ConjugationDetectionWorks()
    {
      Assert.AreEqual(Conjugation.First, AMO.Conjugation);
      Assert.AreEqual(Conjugation.Second, HABEO.Conjugation);
      Assert.AreEqual(Conjugation.Third, MITTO.Conjugation);
      Assert.AreEqual(Conjugation.Third, CAPIO.Conjugation);
      Assert.AreEqual(Conjugation.Fourth, AUDIO.Conjugation);
    }
  }
}
