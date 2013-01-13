using System;
using System.Collections.Generic;
using CsharpUtils;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Active.Indicative
{
  public class Future : IConjugation
  {
    private enum Endings
    {
      Bo,
      Am
    }

    private readonly Endings _endings;
    private readonly string _stem;

    private Future(string stem, Endings endings)
    {
      _endings = endings;
      _stem = stem;
    }

    private static IConjugation Get12(VerbPrincipalParts parts)
    {
      return new Future(parts.Infinitive.TruncateEnding("re"), Endings.Bo);
    }

    private static IConjugation Get34(VerbPrincipalParts parts)
    {
      return new Future(parts.Present.TruncateEnding("o"), Endings.Am);
    }

    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return Get12(parts);
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return Get12(parts);
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      return Get34(parts);
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return Get34(parts);
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", _stem, GetEnding(person, number));
    }

    private string GetEnding(Person person, Number number)
    {
      if (!ENDINGS.ContainsKey(_endings))
      {
        throw new NotSupportedException(string.Format("unrecognised endings : {0}", _endings));
      }
      return ENDINGS[_endings].Ending(person, number);
    }

    private static readonly Dictionary<Endings, ConjugationEndings> ENDINGS =
      new Dictionary<Endings, ConjugationEndings>
        {
          {Endings.Bo, new ConjugationEndings("bo, bis, bit, bimus, bitis, bunt")},
          {Endings.Am, new ConjugationEndings("am, es, et, emus, etis, ent")}
        };
  }
}
