using LatinTester.Entities.Verbs.Conjugations.Active.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Indicative
{
  [TestClass]
  public class PresentTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Present.Get1(AMO), "amo, amas, amat, amamus, amatis, amant");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Present.Get2(HABEO), "habeo, habes, habet, habemus, habetis, habent");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Present.Get3(MITTO), "mitto, mittis, mittit, mittimus, mittitis, mittunt");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Present.Get3(CAPIO), "capio, capis, capit, capimus, capitis, capiunt");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Present.Get4(AUDIO), "audio, audis, audit, audimus, auditis, audiunt");
    }

    #endregion
  }
}
