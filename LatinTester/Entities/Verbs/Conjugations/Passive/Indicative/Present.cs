using CsharpUtils;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Passive.Indicative
{
  public class Present : IConjugation
  {
    private readonly string _stem;
    private readonly string _firstSingularInfix;
    private readonly string _secondSingularInfix;
    private readonly string _usualInfix;
    private readonly string _thirdPluralInfix;

    private Present(
      string stem,
      string firstSingularInfix = "",
      string secondSingularInfix = null,
      string usualInfix = null,
      string thirdPluralInfix = null)
    {
      _stem = stem;
      _firstSingularInfix = firstSingularInfix;
      _secondSingularInfix = secondSingularInfix ?? _firstSingularInfix;
      _usualInfix = usualInfix ?? _secondSingularInfix;
      _thirdPluralInfix = thirdPluralInfix ?? _usualInfix;
    }

    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return new Present(parts.Present.TruncateEnding("o"), "", "a");
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return new Present(parts.Present.TruncateEnding("o"));
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      if (parts.Present.EndsWith("io"))
      {
        return new Present(parts.Present.TruncateEnding("io"), "i", "e", "i", "iu");
      }
      return new Present(parts.Present.TruncateEnding("o"), "", "e", "i", "u");
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return new Present(parts.Present.TruncateEnding("o"), "", "", "", "u");
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}{2}", _stem, GetInfix(person, number), ENDINGS.Ending(person, number));
    }

    public string GetInfix(Person person, Number number)
    {
      if (person == Person.First && number == Number.Singular)
      {
        return _firstSingularInfix;
      }
      if (person == Person.Second && number == Number.Singular)
      {
        return _secondSingularInfix;
      }
      if (person == Person.Third && number == Number.Plural)
      {
        return _thirdPluralInfix;
      }
      return _usualInfix;
    }

    private static readonly ConjugationEndings ENDINGS = new ConjugationEndings("or, ris, tur, mur, mini, ntur");
  }
}
