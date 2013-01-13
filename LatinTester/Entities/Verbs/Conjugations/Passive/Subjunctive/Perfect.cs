using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Entities.Verbs.Conjugations.Irregular;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Passive.Subjunctive
{
  public class Perfect : PastParticipleBase
  {
    private Perfect(VerbPrincipalParts parts) : base(parts) {}

    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return new Perfect(parts);
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      return new Perfect(parts);
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      return new Perfect(parts);
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      return new Perfect(parts);
    }

    protected override IConjugation AuxiliaryVerb
    {
      get { return Sum.Get(Mood.Subjunctive, Voice.Active, Tense.Present); }
    }
  }
}
