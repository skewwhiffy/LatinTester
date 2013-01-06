using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations
{
  public class PresentIndicativeActiveRegular : IConjugation
  {
    private readonly string _baseStem;
    private readonly string _firstSingularInfix;
    private readonly string _normalInfix;
    private readonly string _thirdPluralInfix;

    private PresentIndicativeActiveRegular(
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

    public static PresentIndicativeActiveRegular Get1(string firstPersonSingular)
    {
      firstPersonSingular = firstPersonSingular.ToLowerInvariant();
      CheckEndsInO(firstPersonSingular);
      return new PresentIndicativeActiveRegular(
        firstPersonSingular.TruncateLastChars(1),
        string.Empty,
        "a",
        "a");
    }

    public static PresentIndicativeActiveRegular Get2(string firstPersonSingular)
    {
      firstPersonSingular = firstPersonSingular.ToLowerInvariant();
      CheckEndsInO(firstPersonSingular);
      return new PresentIndicativeActiveRegular(
        firstPersonSingular.TruncateLastChars(1),
        string.Empty,
        string.Empty,
        string.Empty);
    }

    public static PresentIndicativeActiveRegular Get3(string firstPersonSingular)
    {
      firstPersonSingular = firstPersonSingular.ToLowerInvariant();
      CheckEndsInO(firstPersonSingular);
      return new PresentIndicativeActiveRegular(
        firstPersonSingular.TruncateLastChars(1),
        string.Empty,
        firstPersonSingular.EndsWith("io") ? string.Empty : "i",
        "u");
    }

    public static PresentIndicativeActiveRegular Get4(string firstPersonSingular)
    {
      firstPersonSingular = firstPersonSingular.ToLowerInvariant();
      CheckEndsInO(firstPersonSingular);
      return new PresentIndicativeActiveRegular(
        firstPersonSingular.TruncateLastChars(1),
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

    private static void CheckEndsInO(string firstPersonSingular)
    {
      if (!firstPersonSingular.EndsWith("o"))
      {
        throw new NotSupportedException("First person singular present indicative active must end in o");
      }
    }
  }
}
