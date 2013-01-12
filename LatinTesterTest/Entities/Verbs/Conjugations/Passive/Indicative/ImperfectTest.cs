using LatinTester.Entities.Verbs.Conjugations.Passive.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Passive.Indicative
{
  [TestClass]
  public class ImperfectTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Imperfect.Get1(AMO), "amabar, amabaris, amabatur, amabamur, amabamini, amabantur");
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Imperfect.Get2(HABEO), "habebar, habebaris, habebatur, habebamur, habebamini, habebantur");
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Imperfect.Get3(MITTO), "mittebar, mittebaris, mittebatur, mittebamur, mittebamini, mittebantur");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Imperfect.Get3(CAPIO), "capiebar, capiebaris, capiebatur, capiebamur, capiebamini, capiebantur");
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Imperfect.Get4(AUDIO), "audiebar, audiebaris, audiebatur, audiebamur, audiebamini, audiebantur");
    }

    #endregion
  }
}
