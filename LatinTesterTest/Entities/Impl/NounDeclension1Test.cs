using System.Collections.Generic;
using LatinTester.Entities.Base;
using LatinTester.Entities.Impl;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;
using LatinTesterTest.Entities.Impl.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Impl
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
    public void PuellaWorks()
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
      Assert.AreEqual(Gender.Feminine, _puella.Gender);
      Assert.AreEqual("girl", _puella.English);
    }

    #endregion

    #region Masculine noun

    [TestMethod]
    public void CometesWorks()
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
      Assert.AreEqual(Gender.Masculine, _cometes.Gender);
      Assert.AreEqual("comet", _cometes.English);
    }

    #endregion
  }
}
