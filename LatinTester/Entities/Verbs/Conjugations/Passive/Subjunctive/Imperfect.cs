using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Passive.Subjunctive
{
  public class Imperfect : IConjugation
  {
    private readonly string _stem;

    private Imperfect(VerbPrincipalParts parts)
    {
      _stem = parts.Infinitive;
    }
    
    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return new Imperfect(parts);
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return new Imperfect(parts);
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      return new Imperfect(parts);
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return new Imperfect(parts);
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}", _stem, ENDINGS.Ending(person, number));
    }

    private static readonly ConjugationEndings ENDINGS = new ConjugationEndings("r, ris, tur, mur, mini, ntur");
  }
}
