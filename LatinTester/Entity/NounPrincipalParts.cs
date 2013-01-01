namespace LatinTester.Entity
{
  public class NounPrincipalParts
  {
    public NounPrincipalParts(string nominativeSingular, string genitiveSingular)
    {
      NominativeSingular = nominativeSingular.ToLowerInvariant();
      GenitiveSingular = genitiveSingular.ToLowerInvariant();
    }

    public string NominativeSingular { get; private set; }
    public string GenitiveSingular { get; private set; }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((NounPrincipalParts) obj);
    }

    protected bool Equals(NounPrincipalParts other)
    {
      return string.Equals(NominativeSingular, other.NominativeSingular) && string.Equals(GenitiveSingular, other.GenitiveSingular);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((NominativeSingular != null ? NominativeSingular.GetHashCode() : 0) * 397) ^ (GenitiveSingular != null ? GenitiveSingular.GetHashCode() : 0);
      }
    }
  }
}
