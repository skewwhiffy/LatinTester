using LatinTester.Entities.Verbs.Conjugations.Active.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Indicative
{
  [TestClass]
  public class FutureTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(Future.Get1(AMO),
        "amabo",
        "amabis",
        "amabit",
        "amabimus",
        "amabitis",
        "amabunt"));
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(Future.Get2(HABEO),
        "habebo",
        "habebis",
        "habebit",
        "habebimus",
        "habebitis",
        "habebunt"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      Assert.IsTrue(
        ConjugationWorks(Future.Get3(MITTO),
        "mittam",
        "mittes",
        "mittet",
        "mittemus",
        "mittetis",
        "mittent"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      Assert.IsTrue(
        ConjugationWorks(Future.Get3(CAPIO),
        "capiam",
        "capies",
        "capiet",
        "capiemus",
        "capietis",
        "capient"));
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(Future.Get4(AUDIO),
        "audiam",
        "audies",
        "audiet",
        "audiemus",
        "audietis",
        "audient"));
    }
  }
}
