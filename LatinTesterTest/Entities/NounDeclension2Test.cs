using System.Collections.Generic;
using LatinTester.Entities;
using LatinTester.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities
{
  [TestClass]
  public class NounDeclension2Test : NounDeclensionTestBase
  {
    #region Set up

    private Noun _servus;
    private Noun _bellum;
    private Noun _filius;
    private Noun _magister;

    [TestInitialize]
    public void SetUp()
    {
      _servus = new NounDeclension2(new NounPrincipalParts("servus", "servi"), "slave");
      _bellum = new NounDeclension2(new NounPrincipalParts("bellum", "belli"), "war");
      _filius = new NounDeclension2(new NounPrincipalParts("filius", "filii"), "son");
      _magister = new NounDeclension2(new NounPrincipalParts("magister", "magistri"), "teacher");
    }

    #endregion

    #region Regular masculine

    [TestMethod]
    public void ServusWorks()
    {
      NounWorks(
        _servus,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "servus"},
            {Case.Vocative, "serve"},
            {Case.Accusative, "servum"},
            {Case.Genitive, "servi"},
            {Case.Dative, "servo"},
            {Case.Ablative, "servo"}
          },
        Number.Singular,
        "servus");
      NounWorks(
        _servus,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "servi"},
            {Case.Vocative, "servi"},
            {Case.Accusative, "servos"},
            {Case.Genitive, "servorum"},
            {Case.Dative, "servis"},
            {Case.Ablative, "servis"}
          },
        Number.Plural,
        "servus");
      Assert.AreEqual(Gender.Masculine, _servus.Gender);
      Assert.AreEqual("slave", _servus.English);
    }

    [TestMethod]
    public void ServusGenderWorks()
    {
      Assert.AreEqual(Gender.Masculine, _servus.Gender);
    }

    #endregion

    #region Regular masculine ending in -IUS

    [TestMethod]
    public void FiliusWorks()
    {
      NounWorks(
        _filius,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "filius"},
            {Case.Vocative, "fili"},
            {Case.Accusative, "filium"},
            {Case.Genitive, "filii"},
            {Case.Dative, "filio"},
            {Case.Ablative, "filio"}
          },
        Number.Singular,
        "filius");
      NounWorks(
        _filius,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "filii"},
            {Case.Vocative, "filii"},
            {Case.Accusative, "filios"},
            {Case.Genitive, "filiorum"},
            {Case.Dative, "filiis"},
            {Case.Ablative, "filiis"}
          },
        Number.Plural,
        "filius");
      Assert.AreEqual(Gender.Masculine, _filius.Gender);
      Assert.AreEqual("son", _filius.English);
    }

    #endregion

    #region Regular masculine ending in -ER

    [TestMethod]
    public void MagisterWorks()
    {
      NounWorks(
        _magister,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "magister"},
            {Case.Vocative, "magister"},
            {Case.Accusative, "magistrum"},
            {Case.Genitive, "magistri"},
            {Case.Dative, "magistro"},
            {Case.Ablative, "magistro"}
          },
        Number.Singular,
        "magister");
      NounWorks(
        _magister,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "magistri"},
            {Case.Vocative, "magistri"},
            {Case.Accusative, "magistros"},
            {Case.Genitive, "magistrorum"},
            {Case.Dative, "magistris"},
            {Case.Ablative, "magistris"}
          },
        Number.Plural,
        "magister");
      Assert.AreEqual(Gender.Masculine, _magister.Gender);
      Assert.AreEqual("teacher", _magister.English);
    }

    #endregion

    #region Regular neuter

    [TestMethod]
    public void BellumWorks()
    {
      NounWorks(
        _bellum,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "bellum"},
            {Case.Vocative, "bellum"},
            {Case.Accusative, "bellum"},
            {Case.Genitive, "belli"},
            {Case.Dative, "bello"},
            {Case.Ablative, "bello"}
          },
        Number.Singular,
        "bellum");
      NounWorks(
        _bellum,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "bella"},
            {Case.Vocative, "bella"},
            {Case.Accusative, "bella"},
            {Case.Genitive, "bellorum"},
            {Case.Dative, "bellis"},
            {Case.Ablative, "bellis"}
          },
        Number.Plural,
        "bellum");
      Assert.AreEqual(Gender.Neuter, _bellum.Gender);
      Assert.AreEqual("war", _bellum.English);
    }

    #endregion
  }
}
