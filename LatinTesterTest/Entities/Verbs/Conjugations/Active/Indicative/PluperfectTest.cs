using LatinTester.Entities.Verbs.Conjugations.Active.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Indicative
{
  [TestClass]
  public class PluperfectTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Pluperfect.Get1(AMO),
                                     "amaveram, amaveras, amaverat, amaveramus, amaveratis, amaverant"));
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Pluperfect.Get2(HABEO),
                                     "habueram, habueras, habuerat, habueramus, habueratis, habuerant"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      Assert.IsTrue(ConjugationWorks(Pluperfect.Get3(MITTO), "miseram, miseras, miserat, miseramus, miseratis, miserant"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      Assert.IsTrue(ConjugationWorks(Pluperfect.Get3(CAPIO), "ceperam, ceperas, ceperat, ceperamus, ceperatis, ceperant"));
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(Pluperfect.Get4(AUDIO),
                                     "audiveram, audiveras, audiverat, audiveramus, audiveratis, audiverant"));
    }
  }
}
