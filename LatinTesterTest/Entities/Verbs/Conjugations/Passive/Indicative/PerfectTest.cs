using LatinTester.Entities.Verbs.Conjugations.Passive.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Passive.Indicative
{
  [TestClass]
  public class PerfectTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get1(AMO), "amatus sum, amatus es, amatus est, amati sumus, amati estis, amati sunt");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get2(HABEO), "habitus sum, habitus es, habitus est, habiti sumus, habiti estis, habiti sunt");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Perfect.Get3(MITTO), "missus sum, missus es, missus est, missi sumus, missi estis, missi sunt");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Perfect.Get3(CAPIO), "captus sum, captus es, captus est, capti sumus, capti estis, capti sunt");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get4(AUDIO), "auditus sum, auditus es, auditus est, auditi sumus, auditi estis, auditi sunt");
    }

    #endregion
  }
}
