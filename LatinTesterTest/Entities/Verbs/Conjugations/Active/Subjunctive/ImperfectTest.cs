using LatinTester.Entities.Verbs.Conjugations.Active.Subjunctive;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Subjunctive
{
  [TestClass]
  public class ImperfectTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Imperfect.Get1(AMO), "amarem, amares, amaret, amaremus, amaretis, amarent"));
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Imperfect.Get2(HABEO), "haberem, haberes, haberet, haberemus, haberetis, haberent"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      Assert.IsTrue(ConjugationWorks(Imperfect.Get3(MITTO), "mitterem, mitteres, mitteret, mitteremus, mitteretis, mitterent"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      Assert.IsTrue(ConjugationWorks(Imperfect.Get3(CAPIO), "caperem, caperes, caperet, caperemus, caperetis, caperent"));
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Imperfect.Get4(AUDIO), "audirem, audires, audiret, audiremus, audiretis, audirent"));
    }
  }
}
