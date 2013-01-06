using System;
using LatinTester.Entities.Verbs.Conjugations;
using LatinTesterTest.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations
{
  [TestClass]
  public class PresentIndicativeActiveRegularTest : ConjugationTestBase
  {
    #region First conjugation

    [TestMethod]
    [ExpectedException(typeof(NotSupportedException))]
    public void FirstConjugationNeedsToEndInO()
    {
      PresentIndicativeActiveRegular.Get1("doesNotEndInOActually");
    }

    [TestMethod]
    public void FirstConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(PresentIndicativeActiveRegular.Get1("AMO"),
        "amo",
        "amas",
        "amat",
        "amamus",
        "amatis",
        "amant"));
    }

    #endregion

    #region Second conjugation

    [TestMethod]
    [ExpectedException(typeof(NotSupportedException))]
    public void SecondConjugationNeedsToEndInO()
    {
      PresentIndicativeActiveRegular.Get2("doesNotEndInOActually");
    }

    [TestMethod]
    public void SecondConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(PresentIndicativeActiveRegular.Get2("habeo"),
        "habeo",
        "habes",
        "habet",
        "habemus",
        "habetis",
        "habent"));
    }

    #endregion

    #region Third conjugation

    [TestMethod]
    [ExpectedException(typeof(NotSupportedException))]
    public void ThirdConjugationNeedsToEndInO()
    {
      PresentIndicativeActiveRegular.Get3("doesNotEndInOActually");
    }

    [TestMethod]
    public void ThirdConjugationWorksWithoutIStem()
    {
      Assert.IsTrue(
        ConjugationWorks(PresentIndicativeActiveRegular.Get3("mitto"),
        "mitto",
        "mittis",
        "mittit",
        "mittimus",
        "mittitis",
        "mittunt"));
    }

    [TestMethod]
    public void ThirdConjugationWorksWithIStem()
    {
      Assert.IsTrue(
        ConjugationWorks(PresentIndicativeActiveRegular.Get3("capio"),
        "capio",
        "capis",
        "capit",
        "capimus",
        "capitis",
        "capiunt"));
    }

    #endregion

    #region Fourth conjugation

    [TestMethod]
    [ExpectedException(typeof(NotSupportedException))]
    public void FourthConjugationNeedsToEndInO()
    {
      PresentIndicativeActiveRegular.Get4("doesNotEndInOActually");
    }

    [TestMethod]
    public void FourthConjugationWorks()
    {
      Assert.IsTrue(
        ConjugationWorks(PresentIndicativeActiveRegular.Get4("audio"),
        "audio",
        "audis",
        "audit",
        "audimus",
        "auditis",
        "audiunt"));
    }

    #endregion
  }
}
