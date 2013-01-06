using System;
using System.IO;
using LatinTester.Enums;

namespace LatinTester.Entities
{
  public class NounDeclension4 : Noun
  {
    public NounDeclension4(NounPrincipalParts principalParts, string english)
      : this(principalParts, english, principalParts.NominativeSingular.EndsWith("us") ? Gender.Masculine : Gender.Neuter)
    {
    }

    public NounDeclension4(NounPrincipalParts principalParts, string english, Gender gender)
    {
      if (!principalParts.GenitiveSingular.EndsWith("us"))
      {
        throw new NotImplementedException("Fourth declension noun not ending in -US not supported");
      }
      _stem = principalParts.GenitiveSingular.Substring(0, principalParts.GenitiveSingular.Length - 2);
      _gender = gender;
      English = english;
    }

    private readonly Gender _gender;
    private readonly string _stem;

    protected override string GetRegular(Case nounCase, Number number)
    {
      return string.Format("{0}{1}", _stem, GetEnding(nounCase, number));
    }

    private string GetEnding(Case nounCase, Number number)
    {
      switch (number)
      {
        case Number.Singular:
          switch (nounCase)
          {
            case Case.Nominative:
            case Case.Vocative:
              if (Gender == Gender.Neuter)
              {
                return "u";
              }
              return "us";
            case Case.Accusative:
              if (Gender == Gender.Neuter)
              {
                return "u";
              }
              return "um";
            case Case.Genitive:
              return "us";
            case Case.Dative:
              return "ui";
            case Case.Ablative:
              return "u";
            default:
              throw new InvalidDataException(string.Format("{0} ending does not exist in the singular", nounCase));
          }
        case Number.Plural:
          switch (nounCase)
          {
            case Case.Nominative:
            case Case.Vocative:
            case Case.Accusative:
              return Gender == Gender.Neuter ? "ua" : "us";
            case Case.Genitive:
              return "uum";
            case Case.Dative:
            case Case.Ablative:
              return "ibus";
            default:
              throw new NotImplementedException();
          }
        default:
          throw new NotImplementedException();
      }
    }

    public override Gender Gender
    {
      get { return _gender; }
    }
  }
}
