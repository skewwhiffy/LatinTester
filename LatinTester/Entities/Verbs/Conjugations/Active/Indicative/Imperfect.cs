using CsharpUtils;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Active.Indicative
{
  public class Imperfect : IConjugation
  {
    private readonly string _stem;

    private Imperfect(string stem)
    {
      _stem = stem;
    }

    private static IConjugation Get12(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive.TruncateEnding("re"));
    }

    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return Get12(parts);
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return Get12(parts);
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Present.TruncateEnding("o") + "e");
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive.TruncateEnding("re") + "e");
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}ba{1}", _stem, ENDINGS.Ending(person, number));
    }

    private static readonly ConjugationEndings ENDINGS = new ConjugationEndings("m, s, t, mus, tis, nt");
  }
}
