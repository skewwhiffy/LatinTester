using System;
using CsharpUtils;
using LatinTester.Enum;

namespace LatinTester.Entity
{
  public class NounDeclension2 : Noun
  {
    public NounDeclension2(NounPrincipalParts principalParts, string english)
      : this(principalParts, english, Gender.Masculine)
    {
      if (principalParts.NominativeSingular.EndsWith("um"))
      {
        _gender = Gender.Neuter;
      }
    }

    public NounDeclension2(NounPrincipalParts principalParts, string english, Gender gender)
    {
      English = english;
      if (!principalParts.GenitiveSingular.EndsWith("i"))
      {
        throw new NotImplementedException("Second declension nouns with genitive singular not ending in -I not implemented");
      }
      _stem = principalParts.GenitiveSingular.Substring(0, principalParts.GenitiveSingular.Length - 1);
      _gender = gender;
      if (!principalParts.NominativeSingular.IsOneOf(_stem + "us", _stem + "um"))
      {
        _nominativeSingular = principalParts.NominativeSingular;
      }
    }

    private readonly string _nominativeSingular;
    private readonly string _stem;
    private readonly Gender _gender;

    protected override string GetRegular(Case nounCase, Number number)
    {
      if (_nominativeSingular != null && (nounCase.IsOneOf(Case.Nominative, Case.Vocative)) && number == Number.Singular)
      {
        return _nominativeSingular;
      }
      return string.Format("{0}{1}", _stem, GetEnding(nounCase, number));
    }

    protected string GetEnding(Case nounCase, Number number)
    {
      switch (number)
      {
        case Number.Singular:
          switch (nounCase)
          {
            case Case.Nominative:
              if (Gender == Gender.Neuter)
              {
                return "um";
              }
              return "us";
            case Case.Vocative:
              if (Gender == Gender.Neuter)
              {
                return "um";
              }
              if (_stem.EndsWith("i"))
              {
                return "";
              }
              return "e";
            case Case.Accusative:
              return "um";
            case Case.Genitive:
              return "i";
            case Case.Dative:
            case Case.Ablative:
              return "o";
            default:
              throw new NotImplementedException();
          }
        case Number.Plural:
          switch (nounCase)
          {
            case Case.Nominative:
            case Case.Vocative:
              if (Gender == Gender.Neuter)
              {
                return "a";
              }
              return "i";
            case Case.Accusative:
              if (Gender == Gender.Neuter)
              {
                return "a";
              }
              return "os";
            case Case.Genitive:
              return "orum";
            case Case.Dative:
            case Case.Ablative:
              return "is";
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
