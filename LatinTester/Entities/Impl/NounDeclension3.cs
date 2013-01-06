using System;
using System.IO;
using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;

namespace LatinTester.Entities.Impl
{
  public class NounDeclension3 : Noun
  {
    public NounDeclension3(NounPrincipalParts principalParts, string english, Gender gender, bool iStem)
    {
      if (!principalParts.GenitiveSingular.EndsWith("is"))
      {
        throw new NotSupportedException("Third declension nouns in genitive singular not ending in -IS not implemented");
      }
      _stem = principalParts.GenitiveSingular.Substring(0, principalParts.GenitiveSingular.Length - 2);
      English = english;
      _gender = gender;
      _iStem = iStem;
      _nominativeSingular = principalParts.NominativeSingular;
    }

    private readonly Gender _gender;
    private readonly string _nominativeSingular;
    private readonly string _stem;
    private readonly bool _iStem;

    protected override string GetRegular(Case nounCase, Number number)
    {
      if (number == Number.Singular &&
        ((nounCase.IsOneOf(Case.Nominative, Case.Vocative))
          || (nounCase == Case.Accusative && Gender == Gender.Neuter)))
      {
        return _nominativeSingular;
      }
      return string.Format("{0}{1}", _stem, GetEnding(nounCase, number));
    }

    private string GetEnding(Case nounCase, Number number)
    {
      switch (number)
      {
        case Number.Singular:
          switch (nounCase)
          {
            case Case.Accusative:
              return "em";
            case Case.Genitive:
              return "is";
            case Case.Dative:
              return "i";
            case Case.Ablative:
              return "e";
            default:
              throw new InvalidDataException(string.Format("{0} ending does not exist in the singular", nounCase));
          }
        case Number.Plural:
          switch (nounCase)
          {
            case Case.Nominative:
            case Case.Vocative:
            case Case.Accusative:
              if (Gender == Gender.Neuter)
              {
                if (_iStem)
                {
                  return "ia";
                }
                return "a";
              }
              return "es";
            case Case.Genitive:
              if (_iStem)
              {
                return "ium";
              }
              return "um";
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
