using System.Collections.Generic;
using LatinTester.Entity;
using LatinTester.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entity
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
    public void ServusWorksInSingular()
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
    }

    [TestMethod]
    public void ServusWorksInPlural()
    {
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
    }

    [TestMethod]
    public void ServusGenderWorks()
    {
      Assert.AreEqual(Gender.Masculine, _servus.Gender);
    }

    #endregion

    #region Regular masculine ending in -IUS

    [TestMethod]
    public void FiliusWorksInSingular()
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
    }

    [TestMethod]
    public void FiliusWorksInPlural()
    {
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
    }

    #endregion

    #region Regular masculine ending in -ER

    [TestMethod]
    public void MagisterWorksInSingular()
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
    }

    [TestMethod]
    public void MagisterWorksInPlural()
    {
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
    }

    #endregion

    #region Regular neuter

    [TestMethod]
    public void BellumWorksInSingular()
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
    }

    [TestMethod]
    public void BellumWorksInPlural()
    {
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
    }

    [TestMethod]
    public void BellumGenderWorks()
    {
      Assert.AreEqual(Gender.Neuter, _bellum.Gender);
    }

    #endregion
  }
}
