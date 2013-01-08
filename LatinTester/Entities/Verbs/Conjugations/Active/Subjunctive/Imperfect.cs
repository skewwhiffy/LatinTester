using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;
using LatinTester.Helpers;

namespace LatinTester.Entities.Verbs.Conjugations.Active.Subjunctive
{
  public class Imperfect : IConjugation
  {
    private readonly string _stem;

    private Imperfect(string stem)
    {
      _stem = stem;
    }

    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive);
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive);
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive);
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return new Imperfect(parts.Infinitive);
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", _stem, ENDINGS.Ending(person, number));
    }

    private static readonly ConjugationEndings ENDINGS = new ConjugationEndings("m, s, t, mus, tis, nt");
  }
}
