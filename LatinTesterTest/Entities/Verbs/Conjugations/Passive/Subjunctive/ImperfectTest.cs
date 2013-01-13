using LatinTester.Entities.Verbs.Conjugations.Passive.Subjunctive;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Passive.Subjunctive
{
  [TestClass]
  public class ImperfectTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Imperfect.Get1(AMO), "amarer, amareris, amaretur, amaremur, amaremini, amarentur");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Imperfect.Get2(HABEO), "haberer, habereris, haberetur, haberemur, haberemini, haberentur");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Imperfect.Get3(MITTO),
                             "mitterer, mittereris, mitteretur, mitteremur, mitteremini, mitterentur");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Imperfect.Get3(CAPIO), "caperer, capereris, caperetur, caperemur, caperemini, caperentur");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Imperfect.Get4(AUDIO), "audirer, audireris, audiretur, audiremur, audiremini, audirentur");
    }

    #endregion
  }
}
