using LatinTester.Entities.Verbs.Conjugations.Active.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Indicative
{
  [TestClass]
  public class PresentIndicativeActiveTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(PresentIndicativeActive.Get1(AMO),
        "amo",
        "amas",
        "amat",
        "amamus",
        "amatis",
        "amant"));
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(PresentIndicativeActive.Get2(HABEO),
        "habeo",
        "habes",
        "habet",
        "habemus",
        "habetis",
        "habent"));
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      Assert.IsTrue(
        ConjugationWorks(PresentIndicativeActive.Get3(MITTO),
        "mitto",
        "mittis",
        "mittit",
        "mittimus",
        "mittitis",
        "mittunt"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      Assert.IsTrue(
        ConjugationWorks(PresentIndicativeActive.Get3(CAPIO),
        "capio",
        "capis",
        "capit",
        "capimus",
        "capitis",
        "capiunt"));
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(PresentIndicativeActive.Get4(AUDIO),
        "audio",
        "audis",
        "audit",
        "audimus",
        "auditis",
        "audiunt"));
    }

    #endregion
  }
}
