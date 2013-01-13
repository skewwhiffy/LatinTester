using LatinTester.Entities.Verbs.Conjugations.Active.Subjunctive;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Subjunctive
{
  [TestClass]
  public class PluperfectTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Pluperfect.Get1(AMO),
                             "amavissem, amavisses, amavisset, amavissemus, amavissetis, amavissent");
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Pluperfect.Get2(HABEO),
                             "habuissem, habuisses, habuisset, habuissemus, habuissetis, habuissent");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Pluperfect.Get3(MITTO), "misissem, misisses, misisset, misissemus, misissetis, misissent");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Pluperfect.Get3(CAPIO), "cepissem, cepisses, cepisset, cepissemus, cepissetis, cepissent");
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Pluperfect.Get4(AUDIO),
                             "audivissem, audivisses, audivisset, audivissemus, audivissetis, audivissent");
    }
  }
}
