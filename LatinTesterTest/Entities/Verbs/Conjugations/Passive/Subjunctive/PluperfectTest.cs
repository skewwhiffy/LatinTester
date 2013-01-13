using LatinTester.Entities.Verbs.Conjugations.Passive.Subjunctive;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Passive.Subjunctive
{
  [TestClass]
  public class PluperfectTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Pluperfect.Get1(AMO), "amatus essem, amatus esses, amatus esset, amati essemus, amati essetis, amati essent");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Pluperfect.Get2(HABEO), "habitus essem, habitus esses, habitus esset, habiti essemus, habiti essetis, habiti essent");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Pluperfect.Get3(MITTO), "missus essem, missus esses, missus esset, missi essemus, missi essetis, missi essent");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Pluperfect.Get3(CAPIO), "captus essem, captus esses, captus esset, capti essemus, capti essetis, capti essent");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Pluperfect.Get4(AUDIO), "auditus essem, auditus esses, auditus esset, auditi essemus, auditi essetis, auditi essent");
    }

    #endregion
  }
}
