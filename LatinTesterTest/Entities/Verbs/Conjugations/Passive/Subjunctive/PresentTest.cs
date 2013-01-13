using LatinTester.Entities.Verbs.Conjugations.Passive.Subjunctive;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Passive.Subjunctive
{
  [TestClass]
  public class PresentTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Present.Get1(AMO), "amer, ameris, ametur, amemur, amemini, amentur");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Present.Get2(HABEO), "habear, habearis, habeatur, habeamur, habeamini, habeantur");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Present.Get3(MITTO), "mittar, mittaris, mittatur, mittamur, mittamini, mittantur");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Present.Get3(CAPIO), "capiar, capiaris, capiatur, capiamur, capiamini, capiantur");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Present.Get4(AUDIO), "audiar, audiaris, audiatur, audiamur, audiamini, audiantur");
    }

    #endregion
  }
}
