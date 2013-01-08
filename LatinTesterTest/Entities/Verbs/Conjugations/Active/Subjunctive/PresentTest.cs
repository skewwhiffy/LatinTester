using LatinTester.Entities.Verbs.Conjugations.Active.Subjunctive;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Subjunctive
{
  [TestClass]
  public class PresentTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Present.Get1(AMO), "amem, ames, amet, amemus, ametis, ament"));
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Present.Get2(HABEO), "habeam, habeas, habeat, habeamus, habeatis, habeant"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      Assert.IsTrue(ConjugationWorks(Present.Get3(MITTO), "mittam, mittas, mittat, mittamus, mittatis, mittant"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      Assert.IsTrue(ConjugationWorks(Present.Get3(CAPIO), "capiam, capias, capiat, capiamus, capiatis, capiant"));
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Present.Get4(AUDIO), "audiam, audias, audiat, audiamus, audiatis, audiant"));
    }
  }
}
