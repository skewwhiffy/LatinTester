using LatinTester.Entities.Verbs.Conjugations.Active.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Indicative
{
  [TestClass]
  public class PerfectTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(Perfect.Get1(AMO),
        "amavi",
        "amavisti",
        "amavit",
        "amavimus",
        "amavistis",
        "amaverunt"));
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(Perfect.Get2(HABEO),
        "habui",
        "habuisti",
        "habuit",
        "habuimus",
        "habuistis",
        "habuerunt"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      Assert.IsTrue(
        ConjugationWorks(Perfect.Get3(MITTO),
        "misi",
        "misisti",
        "misit",
        "misimus",
        "misistis",
        "miserunt"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      Assert.IsTrue(
        ConjugationWorks(Perfect.Get3(CAPIO),
        "cepi",
        "cepisti",
        "cepit",
        "cepimus",
        "cepistis",
        "ceperunt"));
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(Perfect.Get4(AUDIO),
        "audivi",
        "audivisti",
        "audivit",
        "audivimus",
        "audivistis",
        "audiverunt"));
    }
  }
}
