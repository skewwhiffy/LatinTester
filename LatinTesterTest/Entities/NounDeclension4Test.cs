using System.Collections.Generic;
using LatinTester.Entities;
using LatinTester.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities
{
  [TestClass]
  public class NounDeclension4Test : NounDeclensionTestBase
  {
    #region Set up

    private Noun _portus;
    private Noun _cornu;

    [TestInitialize]
    public void SetUp()
    {
      _portus = new NounDeclension4(new NounPrincipalParts("portus", "portus"), "port");
      _cornu = new NounDeclension4(new NounPrincipalParts("cornu", "cornus"), "horn");
    }

    #endregion

    #region Regular non-neuter

    [TestMethod]
    public void PortusWorks()
    {
      NounWorks(
        _portus,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "portus"},
            {Case.Vocative, "portus"},
            {Case.Accusative, "portum"},
            {Case.Genitive, "portus"},
            {Case.Dative, "portui"},
            {Case.Ablative, "portu"}
          },
        Number.Singular,
        "portus");
      NounWorks(
        _portus,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "portus"},
            {Case.Vocative, "portus"},
            {Case.Accusative, "portus"},
            {Case.Genitive, "portuum"},
            {Case.Dative, "portibus"},
            {Case.Ablative, "portibus"}
          },
        Number.Plural,
        "portus");
      Assert.AreEqual(Gender.Masculine, _portus.Gender);
      Assert.AreEqual("port", _portus.English);
    }

    #endregion

    #region Regular neuter

    [TestMethod]
    public void CornuWorks()
    {
      NounWorks(
        _cornu,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "cornu"},
            {Case.Vocative, "cornu"},
            {Case.Accusative, "cornu"},
            {Case.Genitive, "cornus"},
            {Case.Dative, "cornui"},
            {Case.Ablative, "cornu"}
          },
        Number.Singular,
        "cornu");
      NounWorks(
        _cornu,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "cornua"},
            {Case.Vocative, "cornua"},
            {Case.Accusative, "cornua"},
            {Case.Genitive, "cornuum"},
            {Case.Dative, "cornibus"},
            {Case.Ablative, "cornibus"}
          },
        Number.Plural,
        "cornu");
      Assert.AreEqual(Gender.Neuter, _cornu.Gender);
      Assert.AreEqual("horn", _cornu.English);
    }

    #endregion
  }
}
