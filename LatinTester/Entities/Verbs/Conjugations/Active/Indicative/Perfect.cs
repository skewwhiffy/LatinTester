using System;
using System.Collections.Generic;
using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Active.Indicative
{
  public class Perfect : IConjugation
  {
    private readonly string _stem;

    private Perfect(VerbPrincipalParts parts)
    {
      _stem = parts.Perfect.TruncateLastChars(1);
    }

    public static Perfect Get1(VerbPrincipalParts parts)
    {
      return new Perfect(parts);
    }

    public static Perfect Get2(VerbPrincipalParts parts)
    {
      return new Perfect(parts);
    }

    public static Perfect Get3(VerbPrincipalParts parts)
    {
      return new Perfect(parts);
    }

    public static Perfect Get4(VerbPrincipalParts parts)
    {
      return new Perfect(parts);
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", _stem, GetEnding(person, number));
    }

    public string GetEnding(Person person, Number number)
    {
      if (!ENDINGS.ContainsKey(number))
      {
        throw new NotSupportedException(string.Format("unrecognised number: {0}", number));
      }
      if (!ENDINGS[number].ContainsKey(person))
      {
        throw new NotSupportedException(string.Format("unrecognised person: {0}", person));
      }
      return ENDINGS[number][person];
    }

    private static readonly Dictionary<Number, Dictionary<Person, string>> ENDINGS = new Dictionary<Number, Dictionary<Person, string>>
      {
        {Number.Singular, new Dictionary<Person, string>
          {
            {Person.First, "i"},
            {Person.Second, "isti"},
            {Person.Third, "it"}
          }},
          {Number.Plural, new Dictionary<Person, string>
            {
              {Person.First, "imus"},
              {Person.Second, "istis"},
              {Person.Third, "erunt"}
            }}
      }; 
  }
}
