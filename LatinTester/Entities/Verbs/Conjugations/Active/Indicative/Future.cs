using System;
using System.Collections.Generic;
using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Active.Indicative
{
  public class Future : IConjugation
  {
    private enum FutureEndings
    {
      Bo,
      Am
    }

    private readonly FutureEndings _endings;
    private readonly string _stem;

    private Future(string stem, FutureEndings endings)
    {
      _endings = endings;
      _stem = stem;
    }

    public static Future Get1(VerbPrincipalParts parts)
    {
      return new Future(parts.Infinitive.TruncateLastChars(2), FutureEndings.Bo);
    }

    public static Future Get2(VerbPrincipalParts parts)
    {
      return new Future(parts.Infinitive.TruncateLastChars(2), FutureEndings.Bo);
    }

    public static Future Get3(VerbPrincipalParts parts)
    {
      return new Future(parts.Present.TruncateLastChars(1), FutureEndings.Am);
    }

    public static Future Get4(VerbPrincipalParts parts)
    {
      return new Future(parts.Infinitive.TruncateLastChars(2), FutureEndings.Am);
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", _stem, GetEnding(person, number));
    }

    public string GetEnding(Person person, Number number)
    {
      if (!ENDINGS.ContainsKey(_endings))
      {
        throw new NotSupportedException(string.Format("unrecognised endings : {0}", _endings));
      }
      if (!ENDINGS[_endings].ContainsKey(number))
      {
        throw new NotSupportedException(string.Format("unrecognised number: {0}", number));
      }
      if (!ENDINGS[_endings][number].ContainsKey(person))
      {
        throw new NotSupportedException(string.Format("unrecognised person: {0}", person));
      }
      return ENDINGS[_endings][number][person];
    }

    private static readonly Dictionary<FutureEndings, Dictionary<Number, Dictionary<Person, string>>> ENDINGS
      = new Dictionary<FutureEndings, Dictionary<Number, Dictionary<Person, string>>>
        {
          {
            FutureEndings.Bo, new Dictionary<Number, Dictionary<Person, string>>
              {
                {
                  Number.Singular, new Dictionary<Person, string>
                    {
                      {Person.First, "bo"},
                      {Person.Second, "bis"},
                      {Person.Third, "bit"}
                    }
                },
                {
                  Number.Plural, new Dictionary<Person, string>
                    {
                      {Person.First, "bimus"},
                      {Person.Second, "bitis"},
                      {Person.Third, "bunt"}
                    }
                }
              }
          },
          {
            FutureEndings.Am, new Dictionary<Number, Dictionary<Person, string>>
              {
                {
                  Number.Singular, new Dictionary<Person, string>
                    {
                      {Person.First, "am"},
                      {Person.Second, "es"},
                      {Person.Third, "et"}
                    }
                },
                {
                  Number.Plural, new Dictionary<Person, string>
                    {
                      {Person.First, "emus"},
                      {Person.Second, "etis"},
                      {Person.Third, "ent"}
                    }
                }
              }
          }
        };
  }
}
