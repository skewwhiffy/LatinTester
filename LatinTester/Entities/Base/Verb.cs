using LatinTester.Entities.PrincipalParts;

namespace LatinTester.Entities.Base
{
  public abstract class Verb
  {
    public string English { get; set; }

    public VerbPrincipalParts PrincipalParts
    {
      get
      {
        // QQ TODO: return new VerbPrincipalParts();
        return new VerbPrincipalParts(null, null, null, null);
      }
    }
  }
}
