using System;
using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Passive.Indicative
{
  public class Imperfect : IConjugation
  {
    private readonly string _stem;

    private Imperfect(string stem)
    {
      _stem = stem;
    }

    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive.TruncateLastChars(2));
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive.TruncateLastChars(2));
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      return new Imperfect(string.Format("{0}e", parts.Present.TruncateLastChars(1)));
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return new Imperfect(string.Format("{0}e", parts.Present.TruncateLastChars(1)));
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", _stem, ENDINGS[number][person]);
    }

    private static readonly ConjugationEndings ENDINGS =
      new ConjugationEndings("bar, baris, batur, bamur, bamini, bantur");
  }
}
