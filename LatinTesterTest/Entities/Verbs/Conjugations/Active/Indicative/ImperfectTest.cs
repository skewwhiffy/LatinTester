using LatinTester.Entities.Verbs.Conjugations.Active.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Indicative
{
  [TestClass]
  public class ImperfectTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Imperfect.Get1(AMO), "amabam, amabas, amabat, amabamus, amabatis, amabant"));
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Imperfect.Get2(HABEO), "habebam, habebas, habebat, habebamus, habebatis, habebant"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      Assert.IsTrue(ConjugationWorks(Imperfect.Get3(MITTO),
                                     "mittebam, mittebas, mittebat, mittebamus, mittebatis, mittebant"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      Assert.IsTrue(ConjugationWorks(Imperfect.Get3(CAPIO),
                                     "capiebam, capiebas, capiebat, capiebamus, capiebatis, capiebant"));
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Imperfect.Get4(AUDIO),
                                     "audiebam, audiebas, audiebat, audiebamus, audiebatis, audiebant"));
    }
  }
}
