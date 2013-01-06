using System;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;

namespace LatinTester.Entities.Impl
{
  public class NounDeclension1 : Noun
  {
    public NounDeclension1(NounPrincipalParts principalParts, string english, Gender gender = Gender.Feminine)
    {
      English = english;
      if (!principalParts.GenitiveSingular.EndsWith("ae"))
      {
        // This is actually a valid but rare case: see nymphe, nymphes
        throw new NotSupportedException("First declension nouns with genitive singular not ending in -AE not implemented");
      }
      _stem = principalParts.GenitiveSingular.Substring(0, principalParts.GenitiveSingular.Length - 2);
      _gender = gender;
      // If the nominative singular is irregular, store it (see cometes, cometae, for example)
      if (principalParts.NominativeSingular != _stem + "a")
      {
        _nominativeSingular = principalParts.NominativeSingular;
      }
    }

    private readonly string _stem;
    private readonly Gender _gender;
    private readonly string _nominativeSingular;

    protected override string GetRegular(Case nounCase, Number number)
    {
      if (_nominativeSingular != null && nounCase == Case.Nominative && number == Number.Singular)
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
            case Case.Vocative:
            case Case.Ablative:
              return "a";
            case Case.Accusative:
              return "am";
            case Case.Genitive:
            case Case.Dative:
              return "ae";
            default:
              throw new NotImplementedException();
          }
        case Number.Plural:
          switch (nounCase)
          {
            case Case.Nominative:
            case Case.Vocative:
              return "ae";
            case Case.Accusative:
              return "as";
            case Case.Genitive:
              return "arum";
            case Case.Ablative:
            case Case.Dative:
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
