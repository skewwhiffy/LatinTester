using LatinTester.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entity
{
  [TestClass]
  public class NounDeclension1Test
  {
    #region Set up
    private Noun _puella;

    [TestInitialize]
    public void SetUp()
    {
      _puella = new NounDeclension1("puella");
    }

    #endregion

    [TestMethod]
    public void PuellaNomSingWorks()
    {
      Assert.AreEqual("puella", _puella.Get(Case.Nominative, Number.Singular));
    }
  }
}
