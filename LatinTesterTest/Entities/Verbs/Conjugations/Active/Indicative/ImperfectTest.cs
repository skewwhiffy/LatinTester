using LatinTester.Entities.Verbs.Conjugations.Active.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Indicative
{
  [TestClass]
  public class ImperfectTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Imperfect.Get1(AMO), "amabam, amabas, amabat, amabamus, amabatis, amabant");
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Imperfect.Get2(HABEO), "habebam, habebas, habebat, habebamus, habebatis, habebant");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Imperfect.Get3(MITTO), "mittebam, mittebas, mittebat, mittebamus, mittebatis, mittebant");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Imperfect.Get3(CAPIO), "capiebam, capiebas, capiebat, capiebamus, capiebatis, capiebant");
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Imperfect.Get4(AUDIO), "audiebam, audiebas, audiebat, audiebamus, audiebatis, audiebant");
    }
  }
}
