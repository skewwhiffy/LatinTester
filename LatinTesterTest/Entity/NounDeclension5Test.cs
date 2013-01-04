using System.Collections.Generic;
using LatinTester.Entity;
using LatinTester.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entity
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
    public void PortusWorks()
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
    }

    #endregion
  }
}
