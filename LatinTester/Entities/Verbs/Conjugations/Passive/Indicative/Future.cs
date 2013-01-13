using System;
using CsharpUtils;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Passive.Indicative
{
  public class Future : IConjugation
  {
    private enum InfixType
    {
      B,
      A
    }

    private readonly string _stem;
    private readonly InfixType _infixType;

    private Future(string stem, InfixType infixType)
    {
      _stem = stem;
      _infixType = infixType;
    }

    private static IConjugation Get12(VerbPrincipalParts parts)
    {
      return new Future(parts.Infinitive.TruncateEnding("re"), InfixType.B);
    }

    private static IConjugation Get34(VerbPrincipalParts parts)
    {
      return new Future(parts.Present.TruncateEnding("o"), InfixType.A);
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
      return string.Format("{0}{1}{2}", _stem, GetInfix(person, number), ENDINGS.Ending(person, number));
    }

    private string GetInfix(Person person, Number number)
    {
      switch (_infixType)
      {
        case InfixType.B:
          if (person == Person.First && number == Number.Singular)
          {
            return "bo";
          }
          if (person == Person.Second && number == Number.Singular)
          {
            return "be";
          }
          if (person == Person.Third && number == Number.Plural)
          {
            return "bu";
          }
          return "bi";
        case InfixType.A:
          if (person == Person.First && number == Number.Singular)
          {
            return "a";
          }
          return "e";
        default:
          throw new NotImplementedException();
      }
    }

    private static readonly ConjugationEndings ENDINGS = new ConjugationEndings("r, ris, tur, mur, mini, ntur");
  }
}
