using LatinTester.Entities.Verbs.Conjugations.Active.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Indicative
{
  [TestClass]
  public class PerfectTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get1(AMO), "amavi, amavisti, amavit, amavimus, amavistis, amaverunt");
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get2(HABEO), "habui, habuisti, habuit, habuimus, habuistis, habuerunt");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Perfect.Get3(MITTO), "misi, misisti, misit, misimus, misistis, miserunt");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Perfect.Get3(CAPIO), "cepi, cepisti, cepit, cepimus, cepistis, ceperunt");
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get4(AUDIO), "audivi, audivisti, audivit, audivimus, audivistis, audiverunt");
    }
  }
}
