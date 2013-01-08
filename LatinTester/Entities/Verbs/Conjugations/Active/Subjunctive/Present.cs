using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;
using LatinTester.Helpers;

namespace LatinTester.Entities.Verbs.Conjugations.Active.Subjunctive
{
  public class Present : IConjugation
  {
    private enum Endings
    {
      Em,
      Am
    }

    private readonly string _stem;

    private Present(string stem, Endings endings)
    {
      _stem = string.Format("{0}{1}", stem, endings == Endings.Em ? "e" : "a");
    }

    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return new Present(parts.Present.TruncateLastChars(1), Endings.Em);
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return new Present(parts.Present.TruncateLastChars(1), Endings.Am);
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      return new Present(parts.Present.TruncateLastChars(1), Endings.Am);
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return new Present(parts.Present.TruncateLastChars(1), Endings.Am);
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", _stem, ENDINGS.Ending(person, number));
    }

    private static readonly ConjugationEndings ENDINGS = new ConjugationEndings("m, s, t, mus, tis, nt");
  }
}
