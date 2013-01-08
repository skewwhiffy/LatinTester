using LatinTester.Entities.Verbs.Conjugations.Active.Indicative;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Indicative
{
  [TestClass]
  public class FuturePerfectTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(FuturePerfect.Get1(AMO),
                                     "amavero, amaveris, amaverit, amaverimus, amaveritis, amaverint"));
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(FuturePerfect.Get2(HABEO),
                                     "habuero, habueris, habuerit, habuerimus, habueritis, habuerint"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      Assert.IsTrue(ConjugationWorks(FuturePerfect.Get3(MITTO),
                                     "misero, miseris, miserit, miserimus, miseritis, miserint"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      Assert.IsTrue(ConjugationWorks(FuturePerfect.Get3(CAPIO),
                                     "cepero, ceperis, ceperit, ceperimus, ceperitis, ceperint"));
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      Assert.IsTrue(ConjugationWorks(FuturePerfect.Get4(AUDIO),
                                     "audivero, audiveris, audiverit, audiverimus, audiveritis, audiverint"));
    }
  }
}
