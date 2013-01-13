using LatinTester.Entities.Verbs.Conjugations.Active.Subjunctive;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Active.Subjunctive
{
  [TestClass]
  public class PerfectTest : ConjugationTestBase
  {
    [TestMethod]
    public void FirstConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get1(AMO), "amaverim, amaveris, amaverit, amaverimus, amaveritis, amaverint");
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get2(HABEO), "habuerim, habueris, habuerit, habuerimus, habueritis, habuerint");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      AssertConjugationWorks(Perfect.Get3(MITTO), "miserim, miseris, miserit, miserimus, miseritis, miserint");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      AssertConjugationWorks(Perfect.Get3(CAPIO), "ceperim, ceperis, ceperit, ceperimus, ceperitis, ceperint");
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      AssertConjugationWorks(Perfect.Get4(AUDIO),
                             "audiverim, audiveris, audiverit, audiverimus, audiveritis, audiverint");
    }
  }
}
