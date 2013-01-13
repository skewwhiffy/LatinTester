using System;
using System.IO;
using LatinTester.Entities.Nouns.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;

namespace LatinTester.Entities.Nouns
{
  public class NounDeclension5 : Noun
  {
    public NounDeclension5(NounPrincipalParts principalParts, string english, Gender gender = Gender.Feminine)
    {
      if (!principalParts.GenitiveSingular.EndsWith("ei"))
      {
        throw new NotSupportedException("Fifth declension noun with genitive singular not ending in -EI not supported");
      }
      if (!principalParts.NominativeSingular.EndsWith("es"))
      {
        throw new NotSupportedException("Fifth declension noun with nominative singular not ending in -ES not supported");
      }
      _stem = principalParts.GenitiveSingular.Substring(0, principalParts.GenitiveSingular.Length - 2);
      if (_stem != principalParts.NominativeSingular.Substring(0, principalParts.NominativeSingular.Length - 2))
      {
        throw new NotSupportedException("Fifth declension noun has different stem in nominative and genitive singular");
      }
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
              return "es";
            case Case.Accusative:
              return "em";
            case Case.Genitive:
              return "ei";
            case Case.Dative:
              return "ei";
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
              return "es";
            case Case.Genitive:
              return "erum";
            case Case.Dative:
            case Case.Ablative:
              return "ebus";
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
