using System;
using System.Collections.Generic;
using System.Linq;
using CsharpUtils;
using LatinTester.Enums;

namespace LatinTester.Entities.PrincipalParts
{
  public class VerbPrincipalParts
  {

    public VerbPrincipalParts(string present, string infinitive, string perfect, string supine)
    {
      Present = present.ToLowerInvariant();
      Infinitive = infinitive.ToLowerInvariant();
      Perfect = perfect.ToLowerInvariant();
      Supine = supine.ToLowerInvariant();
    }

    public string Present { get; private set; }
    public string Infinitive { get; private set; }
    public string Perfect { get; private set; }
    public string Supine { get; private set; }
    public string FutureParticiple
    {
      get { return string.Format("{0}{1}", Supine.TruncateLastChars(2), "urus"); }
    }

    public Conjugation Conjugation
    {
      get
      {
        if (Infinitive.EndsWith("are"))
        {
          return Conjugation.First;
        }
        if (Present.EndsWith("eo"))
        {
          return Conjugation.Second;
        }
        if (Infinitive.EndsWith("ere"))
        {
          return Conjugation.Third;
        }
        if (Infinitive.EndsWith("ire"))
        {
          return Conjugation.Fourth;
        }
        throw new NotSupportedException(string.Format("Cannot recognise conjugation of {0}", ToString()));
      }
    }

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
