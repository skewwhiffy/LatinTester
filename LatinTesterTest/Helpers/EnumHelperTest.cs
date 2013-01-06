using System.Collections.Generic;
using System.Linq;
using LatinTester.Enums;
using LatinTester.Exceptions;
using LatinTester.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnumHelper = CsharpUtils.EnumHelper;

namespace LatinTesterTest.Helpers
{
  [TestClass]
  public class EnumHelperTest
  {
    #region Gender to short string

    [TestMethod]
    public void GenderToShortStringWorksForMasculine()
    {
      Assert.AreEqual("m", Gender.Masculine.ToShortString());
    }

    [TestMethod]
    public void GenderToShortStringWorksForFeminine()
    {
      Assert.AreEqual("f", Gender.Feminine.ToShortString());
    }

    [TestMethod]
    public void GenderToShortStringWorksForNeuter()
    {
      Assert.AreEqual("n", Gender.Neuter.ToShortString());
    }

    [TestMethod]
    [ExpectedException(typeof(GenderNotRecognizedException))]
    public void GenderToShortStringThrowsForInvalidType()
    {
      List<Gender> genders = EnumHelper.GetValues<Gender>();
      var nonExistentGender = (Gender) (genders.Max(g => (int) g) + 1);
      nonExistentGender.ToShortString();
    }

    #endregion
  }
}
