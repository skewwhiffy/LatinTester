using CsharpUtils;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;

namespace LatinTester.Entities.Verbs.Conjugations.NonFinite
{
  public class Participles : IParticiple
  {
    public Participles(VerbPrincipalParts parts)
    {
      ActivePresent = parts.Present.EndsWith("io")
                        ? string.Format("{0}ens", parts.Present.TruncateEnding("o"))
                        : string.Format("{0}ns", parts.Infinitive.TruncateEnding("re"));
      PassivePerfect = parts.Supine.EndsWith("us")
                         ? parts.Supine
                         : string.Format("{0}us", parts.Supine.TruncateEnding("um"));
      ActiveFuture = string.Format("{0}urus", PassivePerfect.TruncateEnding("us"));
    }
    public string ActivePresent { get; private set; }
    public string ActiveFuture { get; private set; }
    public string PassivePerfect { get; private set; }
  }
}
