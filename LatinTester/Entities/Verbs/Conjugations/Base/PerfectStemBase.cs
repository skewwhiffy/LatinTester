using System;
using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Base
{
  public abstract class PerfectStemBase : IConjugation
  {
    private readonly string _stem;

    protected PerfectStemBase(VerbPrincipalParts parts)
    {
      _stem = parts.Perfect.TruncateLastChars(1);
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", _stem, GetEnding(person, number));
    }

    public string GetEnding(Person person, Number number)
    {
      if (!Endings.ContainsKey(number))
      {
        throw new NotSupportedException(string.Format("unrecognised number: {0}", number));
      }
      if (!Endings[number].ContainsKey(person))
      {
        throw new NotSupportedException(string.Format("unrecognised person: {0}", person));
      }
      return Endings[number][person];
    }

    protected abstract ConjugationEndings Endings { get; }
  }
}
