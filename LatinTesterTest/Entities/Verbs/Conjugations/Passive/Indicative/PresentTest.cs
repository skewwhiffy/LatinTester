using LatinTester.Entities.Verbs.Conjugations.Passive.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Passive.Indicative
{
  [TestClass]
  public class PresentTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Present.Get1(AMO), "amor, amaris, amatur, amamur, amamini, amantur");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Present.Get2(HABEO), "habeor, haberis, habetur, habemur, habemini, habentur");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Present.Get3(MITTO), "mittor, mitteris, mittitur, mittimur, mittimini, mittuntur");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Present.Get3(CAPIO), "capior, caperis, capitur, capimur, capimini, capiuntur");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Present.Get4(AUDIO), "audior, audiris, auditur, audimur, audimini, audiuntur");
    }

    #endregion
  }
}
