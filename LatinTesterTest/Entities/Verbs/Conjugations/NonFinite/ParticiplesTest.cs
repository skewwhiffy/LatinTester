using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Entities.Verbs.Conjugations.NonFinite;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.NonFinite
{
  [TestClass]
  public class ParticiplesTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      IParticiple inf = new Participles(AMO);
      Assert.AreEqual("amans", inf.ActivePresent);
      Assert.AreEqual("amaturus", inf.ActiveFuture);
      Assert.AreEqual("amatus", inf.PassivePerfect);
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      IParticiple inf = new Participles(HABEO);
      Assert.AreEqual("habens", inf.ActivePresent);
      Assert.AreEqual("habiturus", inf.ActiveFuture);
      Assert.AreEqual("habitus", inf.PassivePerfect);
    }

    [TestMethod]
    public void ThirdConjugationWithIStemWorks()
    {
      IParticiple inf = new Participles(MITTO);
      Assert.AreEqual("mittens", inf.ActivePresent);
      Assert.AreEqual("missurus", inf.ActiveFuture);
      Assert.AreEqual("missus", inf.PassivePerfect);
    }

    [TestMethod]
    public void ThirdConjugationWithoutIStemWorks()
    {
      IParticiple inf = new Participles(CAPIO);
      Assert.AreEqual("capiens", inf.ActivePresent);
      Assert.AreEqual("capturus", inf.ActiveFuture);
      Assert.AreEqual("captus", inf.PassivePerfect);
    }

    [TestMethod]
    public void FourthConjugationWithoutIStemWorks()
    {
      IParticiple inf = new Participles(AUDIO);
      Assert.AreEqual("audiens", inf.ActivePresent);
      Assert.AreEqual("auditurus", inf.ActiveFuture);
      Assert.AreEqual("auditus", inf.PassivePerfect);
    }
  }
}
