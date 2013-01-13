using LatinTester.Entities.Verbs.Conjugations.Irregular;
using LatinTester.Enums;
using LatinTesterTest.Entities.Verbs.Conjugations.TestBase;
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

    [TestMethod]
    public void IndicativeImperfectWorks()
    {
      AssertConjugationWorks(Sum.Get(Mood.Indicative, Voice.Active, Tense.Imperfect),
                             "eram, eras, erat, eramus, eratis, erant");
    }

    [TestMethod]
    public void IndicativeFutureWorks()
    {
      AssertConjugationWorks(Sum.Get(Mood.Indicative, Voice.Active, Tense.Future),
                             "ero, eris, erit, erimus, eritis, erunt");
    }

    [TestMethod]
    public void SubjunctivePresentWorks()
    {
      AssertConjugationWorks(Sum.Get(Mood.Subjunctive, Voice.Active, Tense.Present), "sim, sis, sit, simus, sitis, sint");
    }

    [TestMethod]
    public void SubjunctiveImperfectWorks()
    {
      AssertConjugationWorks(Sum.Get(Mood.Subjunctive, Voice.Active, Tense.Imperfect),
                             "essem, esses, esset, essemus, essetis, essent");
    }
  }
}
