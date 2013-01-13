using LatinTester.Entities.Verbs.Conjugations.Passive.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Passive.Indicative
{
  [TestClass]
  public class PluperfectTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Pluperfect.Get1(AMO), "amatus eram, amatus eras, amatus erat, amati eramus, amati eratis, amati erant");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Pluperfect.Get2(HABEO), "habitus eram, habitus eras, habitus erat, habiti eramus, habiti eratis, habiti erant");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Pluperfect.Get3(MITTO), "missus eram, missus eras, missus erat, missi eramus, missi eratis, missi erant");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Pluperfect.Get3(CAPIO), "captus eram, captus eras, captus erat, capti eramus, capti eratis, capti erant");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Pluperfect.Get4(AUDIO), "auditus eram, auditus eras, auditus erat, auditi eramus, auditi eratis, auditi erant");
    }

    #endregion
  }
}
