using CsharpUtils;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Active.Indicative
{
  public class Present : IConjugation
  {
    private readonly string _baseStem;
    private readonly string _firstSingularInfix;
    private readonly string _normalInfix;
    private readonly string _thirdPluralInfix;

    private Present(
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

    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return new Present(
        parts.Present.TruncateEnding("o"),
        string.Empty,
        "a",
        "a");
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return new Present(
        parts.Present.TruncateEnding("o"),
        string.Empty,
        string.Empty,
        string.Empty);
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      return new Present(
        parts.Present.TruncateEnding("o"),
        string.Empty,
        parts.Present.EndsWith("io") ? string.Empty : "i",
        "u");
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return new Present(
        parts.Present.TruncateEnding("o"),
        string.Empty,
        string.Empty,
        "u");
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", GetStem(person, number), ENDINGS.Ending(person, number));
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

    private static readonly ConjugationEndings ENDINGS = new ConjugationEndings("o, s, t, mus, tis, nt");
  }
}
