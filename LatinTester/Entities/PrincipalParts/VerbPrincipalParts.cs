using System.Collections.Generic;
using System.Linq;

namespace LatinTester.Entities.PrincipalParts
{
  public class VerbPrincipalParts
  {

    public VerbPrincipalParts(string present, string infinitive, string perfect, string supine)
    {
      Present = present;
      Infinitive = infinitive;
      Perfect = perfect;
      Supine = supine;
    }

    public string Present { get; private set; }
    public string Infinitive { get; private set; }
    public string Perfect { get; private set; }
    public string Supine { get; private set; }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj))
      {
        return false;
      }
      if (ReferenceEquals(this, obj))
      {
        return true;
      }
      if (obj.GetType() != GetType())
      {
        return false;
      }
      return Equals((VerbPrincipalParts) obj);
    }

    protected bool Equals(VerbPrincipalParts other)
    {
      List<string> parts = Parts;
      List<string> otherParts = other.Parts;
      return parts.Count == otherParts.Count && Enumerable.Range(0, parts.Count).All(i => parts[i] == otherParts[i]);
    }

    private List<string> Parts
    {
      get { return new List<string>{Present, Infinitive, Perfect, Supine}; }
    }

    public override int GetHashCode()
    {
      unchecked
      {
        int hashCode = (Present != null ? Present.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (Infinitive != null ? Infinitive.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (Perfect != null ? Perfect.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (Supine != null ? Supine.GetHashCode() : 0);
        return hashCode;
      }
    }
  }
}
