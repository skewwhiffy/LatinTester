using System.Collections.Generic;
using LatinTester.Entity;
using LatinTester.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entity
{
  [TestClass]
  public class NounDeclension1Test : NounDeclensionTestBase
  {
    #region Set up

    private Noun _puella;
    private Noun _cometes;

    [TestInitialize]
    public void SetUp()
    {
      _puella = new NounDeclension1(new NounPrincipalParts("PUELLA", "puellae"), "girl");
      _cometes = new NounDeclension1(new NounPrincipalParts("COMETES", "cometae"), "comet", Gender.Masculine);
    }

    #endregion

    #region Regular noun

    [TestMethod]
    public void PuellaSingularWorks()
    {
      NounWorks(
        _puella,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "puella"},
            {Case.Vocative, "puella"},
            {Case.Accusative, "puellam"},
            {Case.Genitive, "puellae"},
            {Case.Dative, "puellae"},
            {Case.Ablative, "puella"}
          },
        Number.Singular,
        "puella");
    }

    [TestMethod]
    public void PuellaPluralWorks()
    {
      NounWorks(
        _puella,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "puellae"},
            {Case.Vocative, "puellae"},
            {Case.Accusative, "puellas"},
            {Case.Genitive, "puellarum"},
            {Case.Dative, "puellis"},
            {Case.Ablative, "puellis"}
          },
        Number.Plural,
        "puella");
    }

    [TestMethod]
    public void PuellaGenderWorks()
    {
      Assert.AreEqual(Gender.Feminine, _puella.Gender);
    }

    #endregion

    #region Irregular noun

    [TestMethod]
    public void CometesSingularWorks()
    {
      NounWorks(
        _cometes,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "cometes"},
            {Case.Vocative, "cometa"},
            {Case.Accusative, "cometam"},
            {Case.Genitive, "cometae"},
            {Case.Dative, "cometae"},
            {Case.Ablative, "cometa"}
          },
        Number.Singular,
        "cometes");
    }

    [TestMethod]
    public void CometesGendersWork()
    {
      Assert.AreEqual(Gender.Masculine, _cometes.Gender);
    }

    #endregion

    private void NounWorks(Noun noun, Dictionary<Case, string> expected, Number number, string nounName)
    {
      foreach (KeyValuePair<Case, string> kvp in expected)
      {
        Assert.AreEqual(kvp.Value, noun.Get(kvp.Key, number), "{0} {1} for {2} doesn't work", kvp.Key, number, nounName);
      }
    }
  }
}
