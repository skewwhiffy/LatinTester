using System;
using CsharpUtils;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.NonFinite
{
  public class Infinitives : IInfinitive
  {
    public Infinitives(VerbPrincipalParts parts)
    {
      ActivePresent = parts.Infinitive;
      ActiveFuture = string.Format("{0} {1}", parts.FutureParticiple, "esse");
      ActivePerfect = string.Format("{0}sse", parts.Perfect);
      PassivePresent = string.Format("{0}i", parts.Infinitive.TruncateEnding(parts.Conjugation == Conjugation.Third ? "ere" : "e"));
      string supineStem = parts.Supine.TruncateLastChars(2);
      PassiveFuture = string.Format("{0}um iri", supineStem);
      PassivePerfect = string.Format("{0}us esse", supineStem);
    }

    public string ActivePresent { get; private set; }
    public string ActiveFuture { get; private set; }
    public string ActivePerfect { get; private set; }
    public string PassivePresent { get; private set; }
    public string PassiveFuture { get; private set; }
    public string PassivePerfect { get; private set; }
  }
}
