using System;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Helpers
{
  public static class VerbHelper
  {
    public static string Ending(this ConjugationEndings endings, Person person, Number number)
    {
      if (!endings.ContainsKey(number))
      {
        throw new NotSupportedException(string.Format("unrecognised number : {0}", number));
      }
      if (!endings[number].ContainsKey(person))
      {
        throw new NotSupportedException(string.Format("unrecognised person : {0}", person));
      }
      return endings[number][person];
    }
  }
}
