using System;
using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Active.Indicative
{
  public class Imperfect : IConjugation
  {
    private readonly string _stem;

    private Imperfect(string stem)
    {
      _stem = stem;
    }

    public static Imperfect Get1(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive.TruncateLastChars(2));
    }

    public static Imperfect Get2(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive.TruncateLastChars(2));
    }

    public static Imperfect Get3(VerbPrincipalParts parts)
    {
      return parts.Present.EndsWith("io") ?
        new Imperfect(parts.Present.TruncateLastChars(1) + "e") :
        new Imperfect(parts.Infinitive.TruncateLastChars(2));
    }

    public static Imperfect Get4(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive.TruncateLastChars(2) + "e");
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}ba{1}", _stem, GetEnding(person, number));
    }

    public string GetEnding(Person person, Number number)
    {
      switch (number)
      {
        case Number.Singular:
          switch (person)
          {
            case Person.First:
              return "m";
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
