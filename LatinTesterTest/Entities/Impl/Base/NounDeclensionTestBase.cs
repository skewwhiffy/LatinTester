using System.Collections.Generic;
using LatinTester.Entities.Base;
using LatinTester.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Impl.Base
{
  public abstract class NounDeclensionTestBase
  {
    protected void NounWorks(Noun noun, Dictionary<Case, string> expected, Number number, string nounName)
    {
      foreach (KeyValuePair<Case, string> kvp in expected)
      {
        Assert.AreEqual(kvp.Value, noun.Get(kvp.Key, number), "{0} {1} for {2} doesn't work", kvp.Key, number, nounName);
      }
    }
  }
}
