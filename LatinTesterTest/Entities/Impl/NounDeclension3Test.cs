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
  public class NounDeclension3Test : NounDeclensionTestBase
  {
    #region Set up

    private Noun _homo;
    private Noun _nomen;
    private Noun _nox;
    private Noun _animal;

    [TestInitialize]
    public void SetUp()
    {
      _homo = new NounDeclension3(new NounPrincipalParts("homo", "hominis"), "man", Gender.Masculine, false);
      _nomen = new NounDeclension3(new NounPrincipalParts("nomen", "nominis"), "name", Gender.Neuter, false);
      _nox = new NounDeclension3(new NounPrincipalParts("nox", "noctis"), "night", Gender.Feminine, true);
      _animal = new NounDeclension3(new NounPrincipalParts("animal", "animalis"), "animal", Gender.Neuter, true);
    }

    #endregion

    #region Non-neuter consonent stem

    [TestMethod]
    public void HomoWorks()
    {
      NounWorks(
        _homo,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "homo"},
            {Case.Vocative, "homo"},
            {Case.Accusative, "hominem"},
            {Case.Genitive, "hominis"},
            {Case.Dative, "homini"},
            {Case.Ablative, "homine"}
          },
        Number.Singular,
        "homo");
      NounWorks(
        _homo,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "homines"},
            {Case.Vocative, "homines"},
            {Case.Accusative, "homines"},
            {Case.Genitive, "hominum"},
            {Case.Dative, "hominibus"},
            {Case.Ablative, "hominibus"}
          },
        Number.Plural,
        "homo");
      Assert.AreEqual(Gender.Masculine, _homo.Gender);
      Assert.AreEqual("man", _homo.English);
    }

    #endregion

    #region Neuter consonent stem

    [TestMethod]
    public void NomenWorks()
    {
      NounWorks(
        _nomen,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "nomen"},
            {Case.Vocative, "nomen"},
            {Case.Accusative, "nomen"},
            {Case.Genitive, "nominis"},
            {Case.Dative, "nomini"},
            {Case.Ablative, "nomine"}
          },
        Number.Singular,
        "nomen");
      NounWorks(
        _nomen,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "nomina"},
            {Case.Vocative, "nomina"},
            {Case.Accusative, "nomina"},
            {Case.Genitive, "nominum"},
            {Case.Dative, "nominibus"},
            {Case.Ablative, "nominibus"}
          },
        Number.Plural,
        "nomen");
      Assert.AreEqual(Gender.Neuter, _nomen.Gender);
      Assert.AreEqual("name", _nomen.English);
    }

    #endregion

    #region Non-neuter I stem

    [TestMethod]
    public void NoxWorks()
    {
      NounWorks(
        _nox,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "nox"},
            {Case.Vocative, "nox"},
            {Case.Accusative, "noctem"},
            {Case.Genitive, "noctis"},
            {Case.Dative, "nocti"},
            {Case.Ablative, "nocte"}
          },
        Number.Singular,
        "nox");
      NounWorks(
        _nox,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "noctes"},
            {Case.Vocative, "noctes"},
            {Case.Accusative, "noctes"},
            {Case.Genitive, "noctium"},
            {Case.Dative, "noctibus"},
            {Case.Ablative, "noctibus"}
          },
        Number.Plural,
        "nox");
      Assert.AreEqual(Gender.Feminine, _nox.Gender);
      Assert.AreEqual("night", _nox.English);
    }

    #endregion

    #region Neuter I stem

    [TestMethod]
    public void AnimalWorks()
    {
      NounWorks(
        _animal,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "animal"},
            {Case.Vocative, "animal"},
            {Case.Accusative, "animal"},
            {Case.Genitive, "animalis"},
            {Case.Dative, "animali"},
            {Case.Ablative, "animale"}
          },
        Number.Singular,
        "animal");
      NounWorks(
        _animal,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "animalia"},
            {Case.Vocative, "animalia"},
            {Case.Accusative, "animalia"},
            {Case.Genitive, "animalium"},
            {Case.Dative, "animalibus"},
            {Case.Ablative, "animalibus"}
          },
        Number.Plural,
        "animal");
      Assert.AreEqual(Gender.Neuter, _animal.Gender);
      Assert.AreEqual("animal", _animal.English);
    }

    #endregion
  }
}
