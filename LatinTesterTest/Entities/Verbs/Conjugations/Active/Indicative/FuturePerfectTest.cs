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
      AssertConjugationWorks(FuturePerfect.Get1(AMO), "amavero, amaveris, amaverit, amaverimus, amaveritis, amaverint");
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(FuturePerfect.Get2(HABEO), "habuero, habueris, habuerit, habuerimus, habueritis, habuerint");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(FuturePerfect.Get3(MITTO), "misero, miseris, miserit, miserimus, miseritis, miserint");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(FuturePerfect.Get3(CAPIO), "cepero, ceperis, ceperit, ceperimus, ceperitis, ceperint");
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(FuturePerfect.Get4(AUDIO),
                             "audivero, audiveris, audiverit, audiverimus, audiveritis, audiverint");
    }
  }
}
