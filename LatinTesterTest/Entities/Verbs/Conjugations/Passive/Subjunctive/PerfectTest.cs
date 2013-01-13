using LatinTester.Entities.Verbs.Conjugations.Passive.Subjunctive;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Passive.Subjunctive
{
  [TestClass]
  public class PerfectTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get1(AMO), "amatus sim, amatus sis, amatus sit, amati simus, amati sitis, amati sint");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get2(HABEO), "habitus sim, habitus sis, habitus sit, habiti simus, habiti sitis, habiti sint");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Perfect.Get3(MITTO), "missus sim, missus sis, missus sit, missi simus, missi sitis, missi sint");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Perfect.Get3(CAPIO), "captus sim, captus sis, captus sit, capti simus, capti sitis, capti sint");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get4(AUDIO), "auditus sim, auditus sis, auditus sit, auditi simus, auditi sitis, auditi sint");
    }

    #endregion
  }
}
