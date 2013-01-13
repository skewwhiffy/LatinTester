using LatinTester.Entities.Verbs.Conjugations.Active.Subjunctive;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Subjunctive
{
  [TestClass]
  public class PresentTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Present.Get1(AMO), "amem, ames, amet, amemus, ametis, ament");
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Present.Get2(HABEO), "habeam, habeas, habeat, habeamus, habeatis, habeant");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Present.Get3(MITTO), "mittam, mittas, mittat, mittamus, mittatis, mittant");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Present.Get3(CAPIO), "capiam, capias, capiat, capiamus, capiatis, capiant");
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Present.Get4(AUDIO), "audiam, audias, audiat, audiamus, audiatis, audiant");
    }
  }
}
