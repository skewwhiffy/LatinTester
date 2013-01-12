using LatinTester.Entities.Verbs.Conjugations.Irregular;
using LatinTester.Enums;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Irregular
{
  [TestClass]
  public class SumTest : ConjugationTestBase
  {
    [TestMethod]
    public void IndicativePresentWorks()
    {
      AssertConjugationWorks(Sum.Get(Mood.Indicative, Voice.Active, Tense.Present), "sum, es, est, sumus, estis, sunt");
    }
  }
}
