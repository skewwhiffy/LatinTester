using CsharpUtils;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Passive.Subjunctive
{
  public class Present : IConjugation
  {
    private readonly string _stem;

    private Present(VerbPrincipalParts parts, string infix = "a")
    {
      _stem = string.Format("{0}{1}", parts.Present.TruncateEnding("o"), infix);
    }
    
    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return new Present(parts, "e");
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return new Present(parts);
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      return new Present(parts);
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return new Present(parts);
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", _stem, ENDINGS.Ending(person, number));
    }

    private static readonly ConjugationEndings ENDINGS = new ConjugationEndings("r, ris, tur, mur, mini, ntur");
  }
}
