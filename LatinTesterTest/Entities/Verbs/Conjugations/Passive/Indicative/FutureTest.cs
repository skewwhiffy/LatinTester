using LatinTester.Entities.Verbs.Conjugations.Passive.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Passive.Indicative
{
  [TestClass]
  public class FutureTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Future.Get1(AMO), "amabor, amaberis, amabitur, amabimur, amabimini, amabuntur");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Future.Get2(HABEO), "habebor, habeberis, habebitur, habebimur, habebimini, habebuntur");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Future.Get3(MITTO), "mittar, mitteris, mittetur, mittemur, mittemini, mittentur");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Future.Get3(CAPIO), "capiar, capieris, capietur, capiemur, capiemini, capientur");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Future.Get4(AUDIO), "audiar, audieris, audietur, audiemur, audiemini, audientur");
    }

    #endregion
  }
}
