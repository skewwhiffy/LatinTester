using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CsharpUtils;
using LatinTester.Entities.Verbs.Conjugations.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Base
{
  [TestClass]
  public class ConjugationBaseTest
  {
    [TestMethod]
    public void AllConjugationsHaveGettersForAllVerbConjugationGroups()
    {
      var problems = new List<string>();
      Assembly
        .GetAssembly(typeof (IConjugation))
        .GetTypes()
        .Where(
          t => t.GetInterfaces().Contains(typeof (IConjugation))
            && t.Namespace != null
            && !t.Namespace.ToLowerInvariant().Contains("irregular")
            && !t.IsAbstract)
        .ForEach(c =>
          {
            List<string> staticMethodsReturningConjugation =
              c.GetMethods()
               .Where(m => m.IsStatic && m.ReturnType == typeof (IConjugation))
               .Select(m => m.Name)
               .ToList();
            for(int i = 1; i <= 4; i++)
            {
              if (staticMethodsReturningConjugation.Contains(string.Format("Get{0}", i)))
              {
                continue;
              }
              problems.Add(string.Format("{0} class does not contain method Get{1}", c.Name, i));
            }
          });
      if (problems.IsNullOrEmpty())
      {
        return;
      }
      Assert.Fail(string.Join("; ", problems));
    }
  }
}
