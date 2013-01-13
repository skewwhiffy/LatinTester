using LatinTester.Entities.Verbs.Conjugations.Passive.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Passive.Indicative
{
  [TestClass]
  public class FuturePerfectTest: ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(FuturePerfect.Get1(AMO), "amatus ero, amatus eris, amatus erit, amati erimus, amati eritis, amati erunt");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(FuturePerfect.Get2(HABEO), "habitus ero, habitus eris, habitus erit, habiti erimus, habiti eritis, habiti erunt");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(FuturePerfect.Get3(MITTO), "missus ero, missus eris, missus erit, missi erimus, missi eritis, missi erunt");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(FuturePerfect.Get3(CAPIO), "captus ero, captus eris, captus erit, capti erimus, capti eritis, capti erunt");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(FuturePerfect.Get4(AUDIO), "auditus ero, auditus eris, auditus erit, auditi erimus, auditi eritis, auditi erunt");
    }

    #endregion
  }
}
