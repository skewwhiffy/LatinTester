using System;
using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Active.Indicative
{
  public class PresentIndicativeActive : IConjugation
  {
    private readonly string _baseStem;
    private readonly string _firstSingularInfix;
    private readonly string _normalInfix;
    private readonly string _thirdPluralInfix;

    private PresentIndicativeActive(
      string baseStem,
      string firstSingularInfix,
      string normalInfix,
      string thirdPluralInfix)
    {
      _baseStem = baseStem;
      _firstSingularInfix = firstSingularInfix;
      _normalInfix = normalInfix;
      _thirdPluralInfix = thirdPluralInfix;
    }

    public static PresentIndicativeActive Get1(VerbPrincipalParts parts)
    {
      return new PresentIndicativeActive(
        parts.Present.TruncateLastChars(1),
        string.Empty,
        "a",
        "a");
    }

    public static PresentIndicativeActive Get2(VerbPrincipalParts parts)
    {
      return new PresentIndicativeActive(
        parts.Present.TruncateLastChars(1),
        string.Empty,
        string.Empty,
        string.Empty);
    }

    public static PresentIndicativeActive Get3(VerbPrincipalParts parts)
    {
      return new PresentIndicativeActive(
        parts.Present.TruncateLastChars(1),
        string.Empty,
        parts.Present.EndsWith("io") ? string.Empty : "i",
        "u");
    }

    public static PresentIndicativeActive Get4(VerbPrincipalParts parts)
    {
      return new PresentIndicativeActive(
        parts.Present.TruncateLastChars(1),
        string.Empty,
        string.Empty,
        "u");
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", GetStem(person, number), GetEnding(person, number));
    }

    private string GetStem(Person person, Number number)
    {
      string infix;
      if (person == Person.First && number == Number.Singular)
      {
        infix = _firstSingularInfix;
      }
      else if (person == Person.Third && number == Number.Plural)
      {
        infix = _thirdPluralInfix;
      }
      else
      {
        infix = _normalInfix;
      }
      return string.Format("{0}{1}", _baseStem, infix);
    }

    private string GetEnding(Person person, Number number)
    {
      switch (number)
      {
        case Number.Singular:
          switch (person)
          {
            case Person.First:
              return "o";
            case Person.Second:
              return "s";
            case Person.Third:
              return "t";
            default:
              throw new NotSupportedException(string.Format("unrecognised person : {0}", person));
          }
        case Number.Plural:
          switch (person)
          {
            case Person.First:
              return "mus";
            case Person.Second:
              return "tis";
            case Person.Third:
              return "nt";
            default:
              throw new NotSupportedException(string.Format("unrecognised person : {0}", person));
          }
        default:
          throw new NotSupportedException(string.Format("unrecognised number : {0}", number));
      }
    }
  }
}
