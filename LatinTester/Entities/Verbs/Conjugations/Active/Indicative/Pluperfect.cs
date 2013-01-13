using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;

namespace LatinTester.Entities.Verbs.Conjugations.Active.Indicative
{
  public class Pluperfect : PerfectStemBase
  {
    private Pluperfect(VerbPrincipalParts parts) : base(parts) {}

    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return new Pluperfect(parts);
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return new Pluperfect(parts);
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      return new Pluperfect(parts);
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return new Pluperfect(parts);
    }

    protected override ConjugationEndings Endings
    {
      get { return ENDINGS; }
    }

    private static readonly ConjugationEndings ENDINGS =
      new ConjugationEndings("eram, eras, erat, eramus, eratis, erant");
  }
}
