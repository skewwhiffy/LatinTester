using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Entities.Verbs.Conjugations.NonFinite;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.NonFinite
{
  [TestClass]
  public class InfinitivesTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      IInfinitive inf = new Infinitives(AMO);
      Assert.AreEqual("amare", inf.ActivePresent);
      Assert.AreEqual("amaturus esse", inf.ActiveFuture);
      Assert.AreEqual("amavisse", inf.ActivePerfect);
      Assert.AreEqual("amari", inf.PassivePresent);
      Assert.AreEqual("amatum iri", inf.PassiveFuture);
      Assert.AreEqual("amatus esse", inf.PassivePerfect);
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      IInfinitive inf = new Infinitives(HABEO);
      Assert.AreEqual("habere", inf.ActivePresent);
      Assert.AreEqual("habiturus esse", inf.ActiveFuture);
      Assert.AreEqual("habuisse", inf.ActivePerfect);
      Assert.AreEqual("haberi", inf.PassivePresent);
      Assert.AreEqual("habitum iri", inf.PassiveFuture);
      Assert.AreEqual("habitus esse", inf.PassivePerfect);
    }

    [TestMethod]
    public void ThirdConjugationWithIStemWorks()
    {
      IInfinitive inf = new Infinitives(MITTO);
      Assert.AreEqual("mittere", inf.ActivePresent);
      Assert.AreEqual("missurus esse", inf.ActiveFuture);
      Assert.AreEqual("misisse", inf.ActivePerfect);
      Assert.AreEqual("mitti", inf.PassivePresent);
      Assert.AreEqual("missum iri", inf.PassiveFuture);
      Assert.AreEqual("missus esse", inf.PassivePerfect);
    }

    [TestMethod]
    public void ThirdConjugationWithoutIStemWorks()
    {
      IInfinitive inf = new Infinitives(CAPIO);
      Assert.AreEqual("capere", inf.ActivePresent);
      Assert.AreEqual("capturus esse", inf.ActiveFuture);
      Assert.AreEqual("cepisse", inf.ActivePerfect);
      Assert.AreEqual("capi", inf.PassivePresent);
      Assert.AreEqual("captum iri", inf.PassiveFuture);
      Assert.AreEqual("captus esse", inf.PassivePerfect);
    }

    [TestMethod]
    public void FourthConjugationWithoutIStemWorks()
    {
      IInfinitive inf = new Infinitives(AUDIO);
      Assert.AreEqual("audire", inf.ActivePresent);
      Assert.AreEqual("auditurus esse", inf.ActiveFuture);
      Assert.AreEqual("audivisse", inf.ActivePerfect);
      Assert.AreEqual("audiri", inf.PassivePresent);
      Assert.AreEqual("auditum iri", inf.PassiveFuture);
      Assert.AreEqual("auditus esse", inf.PassivePerfect);
    }
  }
}
