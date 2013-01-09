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
      AssertConjugationWorks(Future.Get1(AMO), "amabo, amabis, amabit, amabimus, amabitis, amabunt");
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Future.Get2(HABEO), "habebo, habebis, habebit, habebimus, habebitis, habebunt");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Future.Get3(MITTO), "mittam, mittes, mittet, mittemus, mittetis, mittent");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Future.Get3(CAPIO), "capiam, capies, capiet, capiemus, capietis, capient");
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Future.Get4(AUDIO), "audiam, audies, audiet, audiemus, audietis, audient");
    }
  }
}
