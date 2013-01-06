using System.Collections.Generic;
using LatinTester.Entities;
using LatinTester.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities
{
  [TestClass]
  public class NounDeclension5Test : NounDeclensionTestBase
  {
    #region Set up

    private Noun _effigies;

    [TestInitialize]
    public void SetUp()
    {
      _effigies = new NounDeclension5(new NounPrincipalParts("effigies", "effigiei"), "effigy");
    }

    #endregion

    #region Regular feminine

    [TestMethod]
    public void EffigiesWorks()
    {
      NounWorks(
        _effigies,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "effigies"},
            {Case.Vocative, "effigies"},
            {Case.Accusative, "effigiem"},
            {Case.Genitive, "effigiei"},
            {Case.Dative, "effigiei"},
            {Case.Ablative, "effigie"}
          },
        Number.Singular,
        "effigies");
      NounWorks(
        _effigies,
        new Dictionary<Case, string>
          {
            {Case.Nominative, "effigies"},
            {Case.Vocative, "effigies"},
            {Case.Accusative, "effigies"},
            {Case.Genitive, "effigierum"},
            {Case.Dative, "effigiebus"},
            {Case.Ablative, "effigiebus"}
          },
        Number.Plural,
        "effigies");
      Assert.AreEqual(Gender.Feminine, _effigies.Gender);
      Assert.AreEqual("effigy", _effigies.English);
    }

    #endregion
  }
}
